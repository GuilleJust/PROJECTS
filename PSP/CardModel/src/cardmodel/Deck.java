package cardmodel;

import java.util.Arrays;
import java.util.Collections;
import java.util.Stack;

public class Deck {

    private Stack<Card> cards;

    //Initialize a deck in random order.
    public Deck() {

        cards = new Stack<>();

        Arrays.stream(CardSuit.values()).forEach(suit -> {

            Arrays.stream(CardSymbol.values()).forEach( symbol -> {
                cards.push(new Card(symbol, suit));
            });
        });

        Collections.shuffle(cards);
    }

    //Return and remove the next card from the deck.

    public Card next() {

        if(cards.size() > 0)
            return cards.pop();

        else
            return null;
    }
}
