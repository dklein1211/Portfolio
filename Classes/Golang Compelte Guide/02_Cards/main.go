package main

func main() {
	cards := newDeck()

	hand, remmainingCards := deal(cards, 5)

	hand.print()
	remmainingCards.print()
}
