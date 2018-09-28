package main

import (
	"fmt"
	"os"
	"strconv"
)

var arg int64

func main() {
	i, err := strconv.ParseInt(os.Args[1], 10, 0)
	if err == nil {
		arg = i

		fmt.Println(fibRecur(arg))
		//fmt.Println(fibonacciLoop(arg))
	}
}

func fibonacciLoop(n int64) int64 {
	if n < 2 {
		return n
	}

	fmt.Println("n-1=", n-1, "| n-2=", n-2)
	return fibonacciLoop(n-1) + fibonacciLoop(n-2)
}

func fibRecur(n int64) int64 {
	return fibTail(n, 0, 1)
}

func fibTail(n, first, second int64) int64 {
	if n == 0 {
		return first
	}

	return fibTail(n-1, second, first+second)
}
