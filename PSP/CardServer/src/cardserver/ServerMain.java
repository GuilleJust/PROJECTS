package cardserver;

//GUILLERMO JUST 2 DAM GROUP B

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Arrays;
import java.util.Optional;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;

public class ServerMain {

    private static Scanner sc = new Scanner(System.in);
    private static ServerThread[] threads;

    //Main method that starts the game
    public static void main(String[] args) {

        int amountOfPlayers = checkAmountOfPlayers(args);

        listenToPlayers(amountOfPlayers);
        playGame();
    }

    //Function to check the amount of players that will play the game
    private static int checkAmountOfPlayers(String[] args) {

        int amountPlayers;

        if(args.length > 0)
            amountPlayers = setAmountOfPlayers(args[0]);

        else {
            System.out.print("Amount of players: ");
            amountPlayers = setAmountOfPlayers(sc.nextLine());
        }

        return amountPlayers;
    }

    //Function to set the amount of players
    private static int setAmountOfPlayers(String text) {

        int amountPlayers;

        System.out.print("Game capacity: ");

        try {

            amountPlayers = Integer.parseInt(text);

            if(amountPlayers <= 0)
                throw new NumberFormatException();

            System.out.println(amountPlayers);
        }

        catch(NumberFormatException e) {

            amountPlayers = 2;
            System.out.println(amountPlayers + " (Prefixed)");
        }

        return amountPlayers;
    }

    //Function to wait for the players to connect
    private static void listenToPlayers(int amountOfPlayers) {

        threads = new ServerThread[amountOfPlayers];

        try (ServerSocket server = new ServerSocket(7000))
        {
            System.out.println("Waiting for players to connect");

            for (int joinedPlayers = 0; joinedPlayers < amountOfPlayers; joinedPlayers++)
            {
                Socket service = server.accept();

                System.out.println("Player " + (joinedPlayers + 1) + " joined the game.");
                ServerThread st = new ServerThread(service, joinedPlayers + 1);

                threads[joinedPlayers] = st;
                st.start();
            }

        }

        catch (IOException e) {
            System.out.println(e);
        }
    }

    //Function with basic functionality of the game
    private static void playGame() {

        boolean finish;

        do {

            System.out.println("Game is about to start...");
            startGame();
            System.out.println("The game has started!");
            waitGamesOver();
            System.out.println("Players have finished!");
            showResults();
            finish = !retryGame();
        }

        while (!finish);

        System.out.println("The game has finished!");
    }

    //Function to start the game
    private static void startGame() {

        ServerThread.setReadyToStart(ServerThread.ELECTION.NOTHING);

        boolean allPlayersReady;

        do {

            allPlayersReady = Arrays.stream(threads)
                    .allMatch(t -> t.getReady() == ServerThread.ELECTION.YES);

            if(!allPlayersReady) {
                sleepSeconds(1);
            }
        }

        while(!allPlayersReady);

        Arrays.stream(threads).forEach(t -> t.setReady(ServerThread.ELECTION.NO));
        ServerThread.setReadyToStart(ServerThread.ELECTION.YES);
    }

    //Method to check the Game Over of the players
    private static void waitGamesOver() {

        boolean isGameOver;

        do {

            isGameOver = Arrays.stream(threads).allMatch(t -> t.isGameOver());

            if(!isGameOver)
                sleepSeconds(1);
        }

        while(!isGameOver);
    }

    //Function that shows the result message to each player
    private static void showResults() {

        String victoryMessage = "WINNER! :)";
        String defeatMessage = "LOSER :(";

        Optional<Float> maxScoreOptional = Arrays.stream(threads).filter(t -> t.getTotalValue() <= 7.5f && !t.isConnectionErrors())
                .map(t -> t.getTotalValue()).max((v1, v2) -> Float.compare(v1, v2));

        float maxScore = maxScoreOptional.isPresent()? maxScoreOptional.get(): -1;

        Arrays.stream(threads).filter(t -> t.getTotalValue() != maxScore).forEach(t -> t.setGameResult(defeatMessage));

        Long winners = Arrays.stream(threads).filter(t -> t.getTotalValue() == maxScore && !t.isConnectionErrors()).count();

        if(winners > 1)
            victoryMessage = "DRAW :|";

        final String finalVictoryMessage = victoryMessage;
        Arrays.stream(threads).filter(t -> t.getTotalValue() == maxScore).forEach(t -> t.setGameResult(finalVictoryMessage));
    }

    //Function to check if another game will be played
    private static boolean retryGame() {
        boolean choicesMade, retryGame = false;

        if(ServerThread.getHaveBuggyPlayer()) {
            ServerThread.setRepeatGame(ServerThread.ELECTION.NO);
            System.err.println("The replay has been canceled because a player has connection problems.");
        }

        else {

            ServerThread.setRepeatGame(ServerThread.ELECTION.NOTHING);

            do {

                choicesMade = Arrays.stream(threads).allMatch(t -> t.getRetry() != ServerThread.ELECTION.NOTHING);

                if (choicesMade) {

                    retryGame = Arrays.stream(threads).allMatch(t -> t.getRetry() == ServerThread.ELECTION.YES);

                    ServerThread.setRepeatGame(retryGame ? ServerThread.ELECTION.YES : ServerThread.ELECTION.NO);
                }

                else
                    sleepSeconds(1);
            }

            while (!choicesMade);
        }

        return retryGame;
    }

    private static void sleepSeconds(int seconds) {

        try {
            TimeUnit.SECONDS.sleep(seconds);
        }

        catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}