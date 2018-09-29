using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Methods
    {
        public void FizzBuzz(int min, int max)
        {
            //If the two values are input from hightest to lowest then the program will output the values as such.
            if (min > max)
            {
                for (int i = min; i >= max; i--) //For loop that takes in the max and min values dynamically.
                {
                    var output = ""; //An output variable for storing results.

                    if (i != 0) //Catches 0's as 0 divided by any number will prompt a FizzBuzz.
                    {
                        if (i % 3 == 0) { output = "Fizz"; } //If statement that catchs divisions by 3 and stores them in the output.

                        if (i % 5 == 0) { output += "Buzz"; } //If statment that catches divisions by 5 or in the case of a FizzBuzz will add the Buzz to the Fizz.
                    }

                    if (output == "") { output = Convert.ToString(i); } //If statement for any output that is not Fizz or Buzz or FizzBuzz.

                    Console.WriteLine(output + "Test"); //Writes the output to the console line.
                }
            }

            //If the user inputs the values from lowest to highest it will output the values as such.
            else
            {
                for (int i = min; i <= max; i++) //For loop that takes in the max and min values dynamically.
                {
                    var output = ""; //An output variable for storing results.

                    if (i != 0) //Catches 0's as 0 divided by any number will prompt a FizzBuzz.
                    {
                        if (i % 3 == 0) { output = "Fizz"; } //If statement that catchs divisions by 3 and stores them in the output.

                        if (i % 5 == 0) { output += "Buzz"; } //If statment that catches divisions by 5 or in the case of a FizzBuzz will add the Buzz to the Fizz.
                    }

                    if (output == "") { output = Convert.ToString(i); } //If statement for any output that is not Fizz or Buzz or FizzBuzz.

                    Console.WriteLine(output); //Writes the output to the console line.
                }
            }
        }

        public bool ValidateInput(string[] arugsVal)
        {
            //Test to verify the user entered in 2 arguments when running the application.
            if (arugsVal.Length == 2) //
            {
                int minNum;
                int maxNum;

                bool minTest = int.TryParse(arugsVal[0], out minNum); //Converts the min value string into an int
                bool maxTest = int.TryParse(arugsVal[1], out maxNum); //Converts the max value string into an int

                //Test to verify the values entered were converted to int.
                if (minTest == false || maxTest == false)
                {
                    Console.WriteLine("Valid Number Test: Faild \nPlease enter 2 numaric values. Example: fizzBuzz.exe 7 44");
                    return false;
                }

                //Runs the fizzbuzz method.
                else
                {
                    Methods runMethod = new Methods(); //Initializes the class Methods
                    runMethod.FizzBuzz(minNum, maxNum); //Calls the class function fizzBuzz 
                    return true;
                }
            }
            //Test result if the user did not enter in 2 arguments.
            else
            {
                Console.WriteLine("Vaild Arguments Test: Faild \nPlease enter 2 valid numbers as min and max when running the application. Example: fizzBuzz.exe 7 44");
                return false;
            }
        }
    }
}
