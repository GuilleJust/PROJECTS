package CaterinFX.model;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Menu{

    LocalDate date;
    List<MenuElement> elements;

    public Menu(LocalDate date){
        this.date = date;
        elements = new ArrayList<>();
    }
    public LocalDate getDate(){
        return date;
    }

    public void SetDate(LocalDate date){this.date = date;}

    public void addNewElement(MenuElement newMenuElement){
        elements.add(newMenuElement);
    }

    public void SetElements(List<MenuElement> elements) {
        this.elements = elements;
    }
    public List<MenuElement> getElements() {
        return elements;
    }

    @Override
    public String toString() {
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
        return elements.toString();
    }

    public void setElements(List<MenuElement> elements) {
        this.elements = elements;
    }

    public void setDate(LocalDate date) {
        this.date = date;
    }
}