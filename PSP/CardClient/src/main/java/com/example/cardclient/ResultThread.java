package com.example.cardclient;

import javafx.application.Platform;
import javafx.scene.control.Label;
import javafx.scene.layout.HBox;
import javafx.scene.paint.Color;

import java.io.DataInputStream;
import java.io.IOException;

public class ResultThread extends Thread{

    DataInputStream socketIn;
    Label txtResult;
    HBox hBoxRetry;

    //Constructor of the client socket and the components that will be modified after receiving the result.
    public ResultThread(DataInputStream s, Label txtResult, HBox hBoxRetry) {

        socketIn = s;
        this.txtResult = txtResult;
        this.hBoxRetry = hBoxRetry;
    }

    //Function that waits for a message from the server containing the result of the game

    @Override
    public void run() {

        String result = "";

        try {
            result = socketIn.readUTF();
        }

        catch (IOException e) {
            Platform.runLater(() -> MessageUtils.showError("Problems with the server",
                    "Can not get any result"));
        }

        if(!result.isEmpty()) {

            String finalResult = result;
            Platform.runLater(() -> {

                txtResult.setText(finalResult);
                System.out.println(finalResult);

                if(finalResult.equals("WINNER! :)"))
                    txtResult.setTextFill(Color.GREEN);

                else if(finalResult.equals("DRAW :|"))
                    txtResult.setTextFill(Color.YELLOW);

                else
                    txtResult.setTextFill(Color.RED);

                txtResult.setVisible(true);
            });
        }

        Platform.runLater(() -> hBoxRetry.setVisible(true));
    }
}
