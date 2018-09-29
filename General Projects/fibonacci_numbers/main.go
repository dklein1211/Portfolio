package main

import (
	"fmt"
	"os"
	"strconv"
)

//////////////////////////////////////
//MAIN
/////////////////////////////////////
func main() {
	fmt.Println(fibRecur(strconv.Atoi(os.Args[1]))) //Prints the fibRecur function that takes in the command line argument by converting it from a string to an int, error
}

//////////////////////////////////////
//FUNCTIONS
/////////////////////////////////////

//Fib Recursive Function: that calls the fibTail after checking that the error perm is not nil.
func fibRecur(n int, err error) int {
	if err != nil { //If user does not enter a whole number the program will display the error and exit the program.
		fmt.Println("Error: An invalid input was entered, please enter in a whole number.\nError Message:", err)
		os.Exit(0)
	}
	return fibTail(n, 0, 1) //runs the tail recursion function.
}

//Fib Recursive Tail Function: This fucntion is used to find the fib value for the number entered by the user.
func fibTail(n, first, second int) int {
	if n == 0 {
		return first
	}

	return fibTail(n-1, second, first+second)
}
