package com.example.cateringfx;

import CaterinFX.model.Aliment;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

import static CaterinfFX.utils.FileUtils.storeAliment;
import static CaterinfFX.utils.MessageUtils.showError;
import static CaterinfFX.utils.MessageUtils.showMessage;

public class NewAlimentController implements Initializable {

    @FXML
    private TextField nameAliment;

    @FXML
    private TextField descriptionAliment;

    @FXML
    private TextField frequencyAliment;

    @FXML
    private TextField caloriesAliment;

    @FXML
    private TextField carbohydratesAliment;

    @FXML
    private TextField fatAliment;

    @FXML
    private Button btnSaveAliment;

    @FXML
    private Button btnGoBack;

    @FXML
    private CheckBox chkMilkAliment;

    @FXML
    private CheckBox chkNutsAliment;

    @FXML
    private CheckBox chkEggAliment;

    @FXML
    private CheckBox chkGlutenAliment;


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

    }

    //Function to go back to Main Menu
    public void goBack(ActionEvent event) throws IOException {
        Parent root = FXMLLoader.load(HelloApplication.class.getResource("hello-view.fxml"));
        Scene helloView = new Scene(root);
        Stage stage = (Stage) ((Node)event.getSource()).getScene().getWindow();
        stage.setScene(helloView);
        stage.show();
    }

    //Function to store a new aliment on the file aliments.txt
    public void SaveAliment(ActionEvent event) throws IOException{
        if (nameAliment.getText().equals("") ||
                descriptionAliment.getText().equals("") ||
                caloriesAliment.getText().equals("") ||
                fatAliment.getText().equals("") ||
                frequencyAliment.getText().equals("") ||
                carbohydratesAliment.getText().equals("")){

            showError("Error", "At least 1 field is empty");
        }
        else {

            Aliment a = new Aliment(nameAliment.getText(), descriptionAliment.getText()
                    ,frequencyAliment.getText(),
                    Boolean.parseBoolean(String.valueOf(chkMilkAliment.getText())),
                    Boolean.parseBoolean(String.valueOf(chkNutsAliment.getText())),
                    Boolean.parseBoolean(String.valueOf(chkEggAliment.getText())),
                    Boolean.parseBoolean(String.valueOf(chkGlutenAliment.getText())),
                    Double.parseDouble(caloriesAliment.getText()),
                    Double.parseDouble(carbohydratesAliment.getText()),
                    Double.parseDouble(fatAliment.getText()));

            storeAliment(a);

            nameAliment.setText("");
            descriptionAliment.setText("");
            frequencyAliment.setText("");
            caloriesAliment.setText("");
            carbohydratesAliment.setText("");
            fatAliment.setText("");
            chkEggAliment.setSelected(false);
            chkMilkAliment.setSelected(false);
            chkGlutenAliment.setSelected(false);
            chkNutsAliment.setSelected(false);

            showMessage("Confirmation", "Save ok.");
        }

    }
}
