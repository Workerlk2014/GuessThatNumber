using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls teh function Guessnumber
            GuessNumber();
            //keeps the window open
            Console.ReadKey();
        }
        static void GuessNumber()
        {
            //declares a variable called random that is generating a random number
            var random = new Random();
            //declares a variable called cpuNum that is selecting a random number between 1 and 100
            var cpuNum = random.Next(0,100);
            //prints out a string asking the player for a number between 1 and 100
            Console.WriteLine("Come come! Guess a number between 1-100. What's your first guess?");
            //declares a variable called input that prompts a blank line for user input
            var input = Console.ReadLine();
            //declares a variable that converts user input into a number
            var nowNum = Convert.ToInt32(input);
            //declares a variable that is a count for the players attempts 
            var attempts = 0;
            //Creates a while loop that will loop until the nowNum is equal to the cpuNum
            while(nowNum != cpuNum)
            {
                //creates an if statement first asking if the nowNum is lower than the cpuNum
                if(nowNum < cpuNum)
                {
                    //prints a line that says you're too low and to try again
                    Console.WriteLine("Not Quite, but you're too low try again!");
                    //creates another blank line ready for user input
                    input = Console.ReadLine();
                    //takes user input and converts it from a string to an interger
                    nowNum = Convert.ToInt32(input);
                    //adds a count to the attempts counter
                    attempts = attempts + 1;
                }
                //creates an if statement first asking if the nowNum is higher than the cpuNum
                else if (nowNum > cpuNum)
                {
                    //prints a line that says you're too low and to try again
                    Console.WriteLine("Nope! You're too high try again!");
                    //creates another blank line ready for user input
                    input = Console.ReadLine();
                    //takes user input and converts it from a string to an interger
                    nowNum = Convert.ToInt32(input);
                    //adds a count to the attempts counter
                    attempts = attempts + 1;
                }
                
            }
            //prints a confrimation of the number has been found
            Console.WriteLine("Yes! The number is: " + cpuNum);
            //prints out the amount number of attempts 
            Console.WriteLine("Your Attempts" + attempts);

        }
    }
}
