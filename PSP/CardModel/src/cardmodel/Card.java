package cardmodel;

import java.io.Serializable;

public class Card implements Serializable{

    private CardSymbol symbol;
    private CardSuit suit;

    //Constructor that initializes a card with a symbol and suit passed by parameter.

    public Card(CardSymbol symbol, CardSuit suit) {

        this.symbol = symbol;
        this.suit = suit;
    }

    //Returns the value of the card in the game of seven and a half.

    public float getValue() {
        return symbol.getValue();
    }

   //Returns the index in the enumerator of its symbol.

    public int getSymbolIndex() {
        return symbol.ordinal();
    }

    //Returns the index in the enumerator of its suit.

    public int getSuitIndex() {
        return suit.ordinal();
    }

    //Returns a text string with the card information.

    @Override
    public String toString() {
        return symbol + " " + suit;
    }
}
