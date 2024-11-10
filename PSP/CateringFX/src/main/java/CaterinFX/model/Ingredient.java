package CaterinFX.model;

public class Ingredient implements MenuElement{

    double quantity;
    Aliment aliment;

    public Ingredient(double quantity, Aliment aliment){
        this.quantity = quantity;
        this.aliment = aliment;
    }

    public Ingredient(){
        quantity = 0;
        aliment = null;
    }
    @Override
    public double getCalories() {
        return aliment.getCalories() * quantity;
    }

    @Override
    public double getCarbohydrates() {
        return aliment.getCarbohydrates() * quantity;
    }

    @Override
    public double getFat() {
        return aliment.getFat() * quantity;
    }

    @Override
    public boolean hasMilk() {
        return aliment.hasMilk();
    }

    @Override
    public boolean hasNuts() {
        return aliment.hasNuts();
    }

    @Override
    public boolean hasEggs() {
        return aliment.hasEggs();
    }

    @Override
    public boolean hasGluten() {
        return aliment.hasGluten();
    }

    @Override
    public String toString() {
        return  ";" + quantity +
                ";" + aliment.toString();
    }
}
