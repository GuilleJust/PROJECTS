package CaterinFX.model;

public class Aliment implements MenuElement, Nameable{

    String name;
    String description;
    String frequency;
    double calories;
    double fat;
    double carbohydrates;
    boolean milk;
    boolean nuts;
    boolean eggs;
    boolean gluten;

    public Aliment(){
        name = "";
        description = "";
        frequency = "";
        calories = 0;
        fat = 0;
        carbohydrates = 0;
        milk = false;
        nuts = false;
        eggs = false;
        gluten = false;
    }

    public Aliment(String name, String description, String frequency,
                   boolean milk, boolean nuts, boolean eggs, boolean gluten,
                   double calories, double carbohydrates, double fat){

        this.name = name;
        this.description = description;
        this.frequency = frequency;
        this.milk = milk;
        this.nuts = nuts;
        this.eggs = eggs;
        this.gluten = gluten;
        this.calories = calories;
        this.carbohydrates = carbohydrates;
        this.fat = fat;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public void setFrequency(String frequency) {
        this.frequency = frequency;
    }

    public void setCalories(double calories) {
        this.calories = calories;
    }

    public void setFat(double fat) {
        this.fat = fat;
    }

    public void setCarbohydrates(double carbohydrates) {
        this.carbohydrates = carbohydrates;
    }

    public void setMilk(boolean milk) {
        this.milk = milk;
    }

    public void setNuts(boolean nuts) {
        this.nuts = nuts;
    }

    public void setEggs(boolean eggs) {
        this.eggs = eggs;
    }

    public void setGluten(boolean gluten) {
        this.gluten = gluten;
    }

    @Override
    public String getName() {
        return name;
    }

    public String getDescription(){return description;}

    @Override
    public double getCalories() {
        return calories;
    }

    @Override
    public double getCarbohydrates() {
        return carbohydrates;
    }

    @Override
    public double getFat() {
        return fat;
    }

    @Override
    public boolean hasMilk() {
        return milk;
    }

    @Override
    public boolean hasNuts() {
        return nuts;
    }

    @Override
    public boolean hasEggs() {
        return eggs;
    }

    @Override
    public boolean hasGluten() {
        return gluten;
    }

    @Override
    public String toString() {
        return  name + ";" +
                description + ";" +
                frequency + ";" +
                milk + ";" + nuts +
                ";" + eggs + ";"+
                gluten + ";" + calories + ";" +
                carbohydrates + ";" +
                fat;
    }
}
