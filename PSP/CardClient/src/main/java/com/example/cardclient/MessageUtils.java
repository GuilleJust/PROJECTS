package com.example.cardclient;

import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;

public class MessageUtils {

    public static ButtonType showConfirmation(String header, String message){

        return createAlert("Error Dialog", header, message,
                Alert.AlertType.CONFIRMATION).showAndWait().get();
    }

    //Shows an error window.
    public static void showError(String header, String message){

        createAlert("Error Dialog", header, message,
                Alert.AlertType.ERROR).show();
    }

    //Shows an information window.
    public static void showMessage(String header, String message){

        createAlert("Message Dialog", header, message,
                Alert.AlertType.INFORMATION).show();
    }

    private static Alert createAlert(String title, String header, String message, Alert.AlertType alertType){

        Alert alert = new Alert(alertType);
        alert.setTitle(title);
        alert.setHeaderText(header);
        alert.setContentText(message);

        return alert;
    }
}
