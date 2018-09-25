package main

import (
	"fmt"
)

//Create a new type of deck
//Which is a slice of strings
type deck []string

func newDeck() deck {
	cards := deck{}

	cardSuits := []string{"Spade", "Hearts", "Diamond", "Clubs"}
	cardValues := []string{"Ace", "Two", "Three", "Four"}

	for _, suit := range cardSuits {
		for _, value := range cardValues {
			cards = append(cards, value+" of "+suit) //Saves the values for each card.
		}
	}
	return cards
}

func (d deck) print() {
	for i, card := range d {
		fmt.Println(i, card)
	}
}

func deal(d deck, handSize int) (deck, deck) { // returns 2 type decks
	return d[:handSize], d[handSize:] // Return everything from the deck upto the handSize -1 and everything after
}
