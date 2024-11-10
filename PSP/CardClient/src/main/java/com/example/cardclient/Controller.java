package com.example.cardclient;

import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.scene.layout.HBox;
import javafx.scene.paint.Color;
import cardmodel.*;
import java.io.*;
import java.net.Socket;
import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {

    @FXML
    private ListView listCard;
    @FXML
    private HBox hBoxUpperBar;
    @FXML
    private HBox hBoxMoreCards;
    @FXML
    private HBox hBoxRetry;
    @FXML
    private Label txtResult;
    @FXML
    private TextField txtAddress;
    @FXML
    private TextField txtPort;
    @FXML
    private Label txtCurrentCard;
    @FXML
    private Label txtScore;

    private int defaultPort;

    private Socket mySocket;
    private ObjectInputStream objectSocketIn;
    private DataOutputStream dataSocketOut;
    private DataInputStream dataSocketIn;
    private float totalValue;

    static private Color[] suitsColors =  {

            Color.GOLD,
            Color.CORAL,
            Color.DEEPSKYBLUE,
            Color.GREEN
    };

    //Constructor to initialize the internal variables.

    public Controller() {

        defaultPort = 7000;
        totalValue = 0;
    }

    //Method to initialize all the components of the window.

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

        disableMoreCardsOption(true);
        resetGame();
    }

    @FXML
    private void connectToServer() {

        disableUpperBar(true);

        try {

            mySocket = new Socket(txtAddress.getText(), extractPortNumber());

            objectSocketIn = new ObjectInputStream(mySocket.getInputStream());
            dataSocketOut = new DataOutputStream(mySocket.getOutputStream());
            dataSocketIn = new DataInputStream(mySocket.getInputStream());

            getNextCard();
        }

        catch (IOException e) {

            MessageUtils.showError("Connection error", "Could not connect with the server");
            closeResources();
        }
    }

    private int extractPortNumber() {

        int port;

        try {
            port = Integer.parseInt(txtPort.getText());
        }

        catch (NumberFormatException e) {

            txtPort.setText(String.valueOf(defaultPort));
            return defaultPort;
        }

        return port;
    }

    private void closeResources() {

        if(mySocket != null) {
            try { mySocket.close(); } catch (IOException e) {}
        }

        if(objectSocketIn != null) {
            try { objectSocketIn.close(); } catch (IOException e) {}
        }

        if(dataSocketOut != null) {
            try { dataSocketOut.close(); } catch (IOException e) {}
        }

        if(dataSocketIn != null) {
            try { dataSocketIn.close(); } catch (IOException e) {}
        }

        disableUpperBar(false);
    }

    @FXML
    private void getNextCard() {

        disableMoreCardsOption(false);

        try {

            Card currentCard = (Card) objectSocketIn.readObject();
            listCard.getItems().add(currentCard);
            totalValue += currentCard.getValue();

            setCardName(currentCard);
            setScore();
        }

        catch (IOException e) {

            MessageUtils.showError("Problems with the server", "A card was not received");
            resetByConnectionError();
        }

        catch (ClassNotFoundException e) {

            e.printStackTrace();
            resetByConnectionError();
        }

        if(totalValue >= 7.5f) {

            getResult();
            disableMoreCardsOption(true);
        }
    }

    private void setScore() {

        txtScore.setText(String.valueOf(totalValue));
        txtScore.setTextFill(totalValue <= 7.5f? Color.BLUE:Color.RED);
    }

    private void setCardName(Card card) {

        txtCurrentCard.setText(card.toString());
        txtCurrentCard.setTextFill(suitsColors[card.getSuitIndex()]);
    }

    private void disableUpperBar(boolean disable) {
        hBoxUpperBar.setDisable(disable);
    }

    private void disableMoreCardsOption(boolean disable) {
        hBoxMoreCards.setVisible(!disable);
    }

    @FXML
    private void askForNewCard() {

        if(sendMessageToServer("YES"))
            getNextCard();
    }

    @FXML
    private void refuseNewCard() {

        if(sendMessageToServer("NO"))
            getResult();

        disableMoreCardsOption(true);
    }

    @FXML
    private void retryGame() {

        if(sendMessageToServer("YES")) {

            boolean canRetry = canRetryGame();

            resetGame();

            if (canRetry)
                getNextCard();

            else {

                MessageUtils.showMessage("Game Over!", "At least one player does not want another game");
                disableUpperBar(false);
            }
        }
    }

    @FXML
    private void NoRetryGame() {

        if(sendMessageToServer("NO")) {

            canRetryGame();
            resetGame();
            disableUpperBar(false);
        }
    }

    private boolean sendMessageToServer(String message) {

        try {

            dataSocketOut.writeUTF(message);
            dataSocketOut.flush();
        }

        catch (IOException e) {

            MessageUtils.showError("Problems with the server", "No message received from the server");
            resetByConnectionError();

            return false;
        }

        return true;
    }

    private void getResult() {

        new ResultThread(dataSocketIn, txtResult, hBoxRetry).start();
    }

    private void resetGame() {

        listCard.getItems().clear();
        totalValue = 0;
        txtScore.setText("...");
        txtResult.setVisible(false);
        txtCurrentCard.setText("...");
        hBoxRetry.setVisible(false);
        txtScore.setTextFill(Color.BLACK);
        txtCurrentCard.setTextFill(Color.BLACK);
    }

    private void resetByConnectionError() {

        disableMoreCardsOption(true);
        resetGame();
        closeResources();
    }

    private boolean canRetryGame() {

        String result = "";

        try {
            result = dataSocketIn.readUTF();
        }

        catch (IOException e) {
            MessageUtils.showError("Problems with the server", "No response from the server");
        }

        if(result.equals("RETRY"))
            return true;

        return false;
    }
}