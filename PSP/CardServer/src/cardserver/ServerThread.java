package cardserver;

import java.io.*;
import java.net.Socket;
import java.util.concurrent.TimeUnit;
import cardmodel.*;

public class ServerThread extends Thread{

    private int numPlayer;
    private Socket service;
    DataInputStream dataSocketIn;
    ObjectOutputStream ObjectSocketOut;
    DataOutputStream DataSocketOut;

    private Deck deck;
    private float totalValue;

    //Enumerator containing the three states of election

    public enum ELECTION {
        NOTHING,
        YES,
        NO
    }

    private static ELECTION readyToStart = ELECTION.NOTHING;
    private ELECTION ready;
    private boolean gameOver;
    private String gameResult;
    private static ELECTION repeatGame = ELECTION.NOTHING;
    private ELECTION retry;

    private static boolean haveBuggyPlayer = false;
    private boolean connectionErrors = false;

    //Constructor to initialize the sockets that are assigned to the player.

    public ServerThread(Socket s, int numPlayer)
    {
        this.numPlayer = numPlayer;
        setConnection(s);
    }

    //Gets the value of the game of the player

    public float getTotalValue() {
        return totalValue;
    }

    //Method to get ready for the players

    public static void setReadyToStart(ELECTION ready) {
        readyToStart = ready;
    }

    //Method to check to election of the player

    public ELECTION getReady() {
        return ready;
    }

    //Method that indicates the player has agreed to start

    public void setReady(ELECTION ready) {
        this.ready = ready;
    }

    //Method to check if the game is still active.

    public boolean isGameOver() {
        return gameOver;
    }


    //Method to repeat the game

    public static void setRepeatGame(ELECTION repeatGame) {
        ServerThread.repeatGame = repeatGame;
    }

    //Checks the option of the player

    public ELECTION getRetry() {
        return retry;
    }

    //Message that has the value for the GAME OVER

    public void setGameResult(String gameResult) {
        this.gameResult = gameResult;
    }

    //Returns true if you have some player with connection error.

    public static boolean getHaveBuggyPlayer() {
        return haveBuggyPlayer;
    }

    //Returns true if you have Connection errors.

    public boolean isConnectionErrors() {
        return connectionErrors;
    }

    private void setConnection(Socket s) {
        service = s;

        try {

            dataSocketIn = new DataInputStream(service.getInputStream());
            ObjectSocketOut = new ObjectOutputStream(service.getOutputStream());
            DataSocketOut = new DataOutputStream(service.getOutputStream());
        }

        catch (IOException e) {
            showConnectionError("Failed to establish connection to client.");
        }
    }

    private void resetData() {

        deck = new Deck();
        totalValue = 0;
        gameOver = false;
        gameResult = "";
        ready = ELECTION.YES;
        retry = ELECTION.NOTHING;
    }

    //Method that manages the connections with the player.

    @Override
    public void run()
    {
        do {

            resetData();
            waitPlayersToStart();

            play();
            waitToResult();

            askForRetry();
            waitForRetry();

            if(!connectionErrors)
                sendMessage(repeatGame == ELECTION.YES? "RETRY": "FINISH");
        }

        while (repeatGame == ELECTION.YES);

        closeServer();
        showDebuggerMessage("Left the game.");
    }

    private void waitPlayersToStart() {

        while(readyToStart == ELECTION.NOTHING && !haveBuggyPlayer) {
            sleepSeconds(1);
        }
    }

    private void play() {

        if(!connectionErrors) {
            String message;

            while (!gameOver) {

                sendMessage(getNextCard());
                gameOver = totalValue >= 7.5f;
                showDebuggerMessage("Total value -> " + totalValue);

                if (!gameOver) {

                    message = readMessage();
                    showDebuggerMessage("More cards? -> " + message);

                    gameOver = message == null || message.equals("NO");
                }
            }
        }
    }

    private Card getNextCard() {

        Card card = deck.next();
        totalValue += card.getValue();
        return card;
    }

    private void waitToResult() {

        while(gameResult.isEmpty())
            sleepSeconds(1);

        if(!connectionErrors)
            sendMessage(gameResult);
    }

    private void askForRetry() {

        if(!connectionErrors) {

            String message = readMessage();
            showDebuggerMessage("Retry -> " + message);

            retry = message != null && message.equals("YES") ? ELECTION.YES : ELECTION.NO;
        }
    }

    private void waitForRetry() {

        while(repeatGame == ELECTION.NOTHING)
            sleepSeconds(1);
    }

    private void sendMessage(String message) {

        try {

            DataSocketOut.writeUTF(message);
            DataSocketOut.flush();
        }

        catch (IOException e) {
            showConnectionError("Error trying to send message to client.");
        }
    }

    private <T extends Serializable> void sendMessage(T message) {

        try {

            ObjectSocketOut.writeObject(message);
            ObjectSocketOut.flush();
        }

        catch (IOException e) {
            showConnectionError("Error trying to send message to client.");
        }
    }

    private String readMessage() {

        try {
            return dataSocketIn.readUTF();
        }

        catch (IOException e) {
            showConnectionError("Error trying to read message from client.");
            return null;
        }
    }

    private void sleepSeconds(int seconds) {

        try {
            TimeUnit.SECONDS.sleep(seconds);
        }

        catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    private void closeServer() {

        if (service != null)
            try { service.close(); } catch (IOException ex) {}

        if(dataSocketIn != null)
            try { dataSocketIn.close(); } catch (IOException e) {}

        if(ObjectSocketOut != null)
            try { ObjectSocketOut.close(); } catch (IOException e) {}

        if(DataSocketOut != null)
            try { DataSocketOut.close(); } catch (IOException e) {}
    }

    private void showConnectionError(String message) {

        showDebuggerError(message);
        haveBuggyPlayer = true;
        connectionErrors = true;
    }

    private void showDebuggerError(String message) {
        System.err.println("Player " + numPlayer + ": " + message);
    }

    private void showDebuggerMessage(String message) {
        System.out.println("Player " + numPlayer + ": " + message);
    }
}
