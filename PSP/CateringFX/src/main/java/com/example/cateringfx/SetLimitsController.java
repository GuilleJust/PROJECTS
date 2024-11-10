package com.example.cateringfx;

import CaterinfFX.utils.MessageUtils;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class SetLimitsController implements Initializable {
    @FXML
    private TextField CaloriesSL;
    @FXML
    private TextField CarbohydratesSL;
    @FXML
    private TextField FatSL;
    public static double limitCalories = 0;
    public static double limitCarbohydrates = 0;
    public static double limitFats = 0;


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

        CaloriesSL.setText(String.valueOf(limitCalories));
        CarbohydratesSL.setText(String.valueOf(limitCarbohydrates));
        FatSL.setText(String.valueOf(limitFats));
    }

    //Function to go back to Main View
    public void goBack(ActionEvent event) throws IOException {
        Parent root = FXMLLoader.load(HelloApplication.class.getResource("hello-view.fxml"));
        Scene helloView = new Scene(root);
        Stage stage = (Stage) ((Node)event.getSource()).getScene().getWindow();
        stage.setScene(helloView);
        stage.show();
    }

    //Function to save the limits
    public void SaveLimits(ActionEvent event) throws IOException{

        if(FatSL.getText().isEmpty() || CarbohydratesSL.getText().isEmpty() || CaloriesSL.getText().isEmpty()){
            MessageUtils.showError("Error", "The fields cannot be left empty.");
        }
        else {
            limitCalories = Double.parseDouble(CaloriesSL.getText());
            limitCarbohydrates = Double.parseDouble(CarbohydratesSL.getText());
            limitFats = Double.parseDouble(FatSL.getText());
        }
    }
}
