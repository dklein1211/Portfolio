package main

import "testing"

func TestNewDeck(t *testing.T) {
	d := newDeck()

	if len(d) != 16 {
		t.Errorf("Expected deck length of 16, but got %v", len(d))
	}

	id d[0] != "Ace of Spades" {
		t.Errorf("This is not the right card %v, d[0]")
	}
}
