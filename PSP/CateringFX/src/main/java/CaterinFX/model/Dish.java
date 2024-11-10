package CaterinFX.model;

import java.util.*;

public class Dish implements MenuElement, Nameable{

    String name;
    String description;
    List<Ingredient> ingredients;

    public Dish(String name, String description){
        this.name = name;
        this.description = description;
        ingredients = new ArrayList<Ingredient>();
    }

    public Dish(){
        name = "";
        description = "";
        ingredients = null;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public void setIngredients(List<Ingredient> ingredients) {
        this.ingredients = ingredients;
    }

    @Override
    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    @Override
    public double getCalories() {
        double getCalories = 0;
        for (Ingredient i : ingredients){
            getCalories += i.getCalories();
        }
        return getCalories;
    }

    @Override
    public double getCarbohydrates() {
        double getCarbohydrates = 0;
        for (Ingredient i : ingredients){
            getCarbohydrates += i.getCarbohydrates();
        }
        return getCarbohydrates;
    }

    @Override
    public double getFat() {
        double getFat = 0;
        for (Ingredient i : ingredients){
            getFat += i.getFat();
        }
        return getFat;
    }

    @Override
    public boolean hasMilk() {
        boolean hasMilk = false;
        for(Ingredient i: ingredients){
            if(i.hasMilk() == true)
                hasMilk = true;
        }
        return hasMilk;
    }

    @Override
    public boolean hasNuts() {
        boolean hasNuts = false;
        for(Ingredient i: ingredients){
            if(i.hasNuts() == true)
                hasNuts = true;
        }
        return hasNuts;
    }

    @Override
    public boolean hasEggs() {
        boolean hasEggs = false;
        for(Ingredient i: ingredients){
            if(i.hasEggs() == true)
                hasEggs = true;
        }
        return hasEggs;
    }

    @Override
    public boolean hasGluten() {
        boolean hasGluten = false;
        for(Ingredient i: ingredients){
            if(i.hasMilk() == true)
                hasGluten = true;
        }
        return hasGluten;
    }

    public void addIngredient(Ingredient ingredient){
        ingredients.add(ingredient);
    }

    public List<Ingredient> getIngredients(){
        return ingredients;
    }

    @Override
    public String toString() {
        return  name + ";" +
                description + ";" +
                ingredients.toString();
    }
}
