package cardmodel;

public enum CardSymbol {

    SA(1),
    S2(2),
    S3(3),
    S4(4),
    S5(5),
    S6(6),
    S7(7),
    SJ(0.5f),
    SQ(0.5f),
    SK(0.5f);

    private float value;

    CardSymbol(float value) {
        this.value = value;
    }

    //Returns the value of the symbol.

    public float getValue() {
        return value;
    }

    //Returns the symbol in string format.

    @Override
    public String toString() {
        return super.toString().substring(1);
    }
}
