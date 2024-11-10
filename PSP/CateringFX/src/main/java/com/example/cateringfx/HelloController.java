package com.example.cateringfx;

import CaterinFX.model.Aliment;
import CaterinFX.model.Menu;
import CaterinFX.model.MenuElement;
import CaterinFX.model.Nameable;
import CaterinfFX.utils.FileUtils;
import CaterinfFX.utils.MessageUtils;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.paint.Color;
import javafx.stage.Stage;


import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.ResourceBundle;
import java.util.stream.Collectors;

import static com.example.cateringfx.SetLimitsController.*;
import static java.awt.SystemColor.menu;

public class HelloController implements Initializable {
    @FXML
    private CheckBox MilkCB;
    @FXML
    private CheckBox NutsCB;
    @FXML
    private CheckBox EggCB;
    @FXML
    private CheckBox GlutenCB;
    @FXML
    private TextField SerachText;
    @FXML
    private DatePicker Date;
    @FXML
    private TableView<MenuElement> tableLeft;
    @FXML
    private TableView<MenuElement> tableRight;
    @FXML
    private TableColumn<MenuElement, String> colNameLeft;
    @FXML
    private TableColumn<MenuElement, Double> ColCalories;
    @FXML
    private TableColumn<MenuElement, String> colNameRight;
    @FXML
    private TableColumn<MenuElement, String> colDescription;
    @FXML
    private TableColumn<MenuElement, Double> ColCarbo;
    @FXML
    private TableColumn<MenuElement, Double> ColFat;
    @FXML
    private Label TotalCalories;
    @FXML
    private Label TotalCarbohydrates;
    @FXML
    private Label TotalFat;
    private ObservableList<MenuElement> menuElement;
    private Menu menu;
    private List<MenuElement>menuList;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {

        ShowItems();
        TotalCalories.setText("0");
        TotalCarbohydrates.setText("0");
        TotalFat.setText("0");
    }

    //Function to show all the items stored in the files on the left table
    public void ShowItems(){

        List<MenuElement> list = FileUtils.loadElements();
        menuElement = FXCollections.observableArrayList(list);

        menu = new Menu(LocalDate.now());
        Date.setValue(menu.getDate());

        colNameLeft.setCellValueFactory(new PropertyValueFactory<>("name"));
        ColCalories.setCellValueFactory(new PropertyValueFactory<>("calories"));
        ColCarbo.setCellValueFactory(new PropertyValueFactory<>("carbohydrates"));
        ColFat.setCellValueFactory(new PropertyValueFactory<>("fat"));

        colNameRight.setCellValueFactory(new PropertyValueFactory<>("name"));
        colDescription.setCellValueFactory(new PropertyValueFactory<>("description"));

        tableLeft.setItems(menuElement);
        menuList = new ArrayList<>();
    }

    //Opens the New Aliment window
    public void gotoViewAliment(ActionEvent event) throws IOException {

        Parent root = FXMLLoader.load(HelloApplication.class.getResource("newAliment.fxml"));
        Scene newAlimentScene = new Scene(root);
        Stage stage = (Stage) ((Node)event.getSource()).getScene().getWindow();
        stage.setScene(newAlimentScene);
        stage.show();
    }

    //Opens the Set Limits window
    public void gotoSetLimits(ActionEvent event) throws IOException{
        Parent root = FXMLLoader.load(HelloApplication.class.getResource("setLimitsFX.fxml"));
        Scene setLimitsFX = new Scene(root);
        Stage stage = (Stage) ((Node)event.getSource()).getScene().getWindow();
        stage.setScene(setLimitsFX);
        stage.show();
    }

    //Function to add a component from the left table to the right table
    @FXML
    public void addComponent(ActionEvent event) throws IOException{

        if(tableLeft.getSelectionModel().getSelectedItem() !=null){
            menuList.add(tableLeft.getItems().get(tableLeft.getSelectionModel().getSelectedIndex()));
            tableRight.setItems(FXCollections.observableArrayList(menuList));

            menu.addNewElement(tableRight.getSelectionModel().getSelectedItem());
            setUpNutritionalLimits();
        }
        else{
            MessageUtils.showError("Error", "No item selected.");
        }
    }

    //Function to remove a component from the right table
    public void removeComponent(ActionEvent event) throws IOException{

        if(tableRight.getSelectionModel().getSelectedItem() != null){
            menuList.remove(tableRight.getItems().get(tableRight.getSelectionModel().getSelectedIndex()));
            tableRight.setItems(FXCollections.observableArrayList(menuList));

            menu.getElements().remove(tableRight.getSelectionModel().getSelectedItem());
            setUpNutritionalLimits();
        }
        else{
            MessageUtils.showError("Error", "No item selected.");
        }
    }

    //Function to save Menu with date as name
    @FXML
    private void saveNewMenu(ActionEvent actionEvent) {

        if(menuList.size() > 0 && menu != null){
            menu.setElements(menuList);

            boolean result = MessageUtils.showConfirmation("Confirmation", "Do you want to save this menu?");
            if(result)
                FileUtils.storeMenu(menu);

        }else  MessageUtils.showError("Error", "No items on the menu.");
    }

    //Function to check if Milk checkbox is selected
    @FXML
    private void checkMilkSelected(ActionEvent actionEvent) {
        if(MilkCB.isSelected()){
            EggCB.setSelected(false);
            NutsCB.setSelected(false);
            GlutenCB.setSelected(false);
            tableLeft.setItems(
                    FXCollections.observableArrayList(
                            menuElement
                                    .stream()
                                    .filter(MenuElement::hasMilk)
                                    .collect(Collectors.toList()))
            );

        }else{
            MilkCB.setSelected(false);
            tableLeft.setItems(FXCollections.observableArrayList(menuElement));
        }
    }

    //Function to check if Nuts checkbox is selected
    @FXML
    private void checkNutsSelected(ActionEvent actionEvent) {
        if(NutsCB.isSelected()){
            MilkCB.setSelected(false);
            GlutenCB.setSelected(false);
            EggCB.setSelected(false);
            tableLeft.setItems(
                    FXCollections.observableArrayList(
                            menuElement.stream()
                                    .filter(MenuElement:: hasNuts)
                                    .collect(Collectors.toList()))
            );

        }else {
            NutsCB.setSelected(false);
            tableLeft.setItems(FXCollections.observableArrayList(menuElement));
        }
    }

    //Function to check if Eggs checkbox is selected
    @FXML
    private void checkEggSelected(ActionEvent actionEvent) {
        if(EggCB.isSelected()){
            MilkCB.setSelected(false);
            NutsCB.setSelected(false);
            GlutenCB.setSelected(false);
            tableLeft.setItems(
                    FXCollections.observableArrayList(
                            menuElement.stream()
                                    .filter(MenuElement:: hasEggs)
                                    .collect(Collectors.toList()))
            );

        }else{
            EggCB.setSelected(false);
            tableLeft.setItems(FXCollections.observableArrayList(menuElement));
        }
    }

    //Function to check if Gluten checkbox is selected
    @FXML
    private void checkGlutenSelected(ActionEvent actionEvent) {
        if(GlutenCB.isSelected()){
            MilkCB.setSelected(false);
            NutsCB.setSelected(false);
            EggCB.setSelected(false);
            tableLeft.setItems(
                    FXCollections.observableArrayList(
                            menuElement.stream()
                                    .filter(MenuElement:: hasGluten)
                                    .collect(Collectors.toList()))
            );

        }else{
            GlutenCB.setSelected(false);
            tableLeft.setItems(FXCollections.observableArrayList(menuElement));
        }
    }

    //Function to filter by the text(not implemented because it cracks the app)
    /*@FXML
    public void checkText(ActionEvent event) {

        tableLeft.setItems(FXCollections.observableArrayList(FXCollections.observableList
                (menuList.stream().filter(l ->((Nameable)l).getName().contains(SerachText.getText()))
                        .collect(Collectors.toList()))));
    }*/

    //Function to write the values on the bottom left
    private void setUpNutritionalLimits() {

        double calories = menuList.stream().mapToDouble(MenuElement::getCalories).sum();
        TotalCalories.setText(String.valueOf(calories));
        setUpLimitColours(TotalCalories, calories, limitCalories);

        double carbohydrates = menuList.stream().mapToDouble(MenuElement::getCarbohydrates).sum();
        TotalCarbohydrates.setText(String.valueOf(carbohydrates));
        setUpLimitColours(TotalCarbohydrates, carbohydrates, limitCarbohydrates);

        double fat = menuList.stream().mapToDouble(MenuElement::getFat).sum();
        TotalFat.setText(String.valueOf(fat));
        setUpLimitColours(TotalFat, fat, limitFats);
    }

    //Function to change the color of the values
    private void setUpLimitColours(Label label, double itemValue, double limit){
        if(itemValue> limit)
            label.setTextFill(Color.RED);
        else label.setTextFill(Color.BLACK);
    }
}