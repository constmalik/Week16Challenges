using System;

namespace EasyChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number. Please!");

            while(true) {

                try 
                {
                    //collect integer from user
					int userInput = Convert.ToInt16(Console.ReadLine());
                    //initiate number of guesses before user begins
					int guesses = 0;
                    //number user needs to at least enter
					int initNumber = 10;
                    //display if the user's number reaches the limit to complete the application
					if (userInput < initNumber)
					{
						Console.WriteLine("This number is too small.");
                        //this will add one to the guesses variable each time the user doesn't reach the limit
						guesses++;
                        //continue allows the application to keep running until the user reaches the number
						continue;
					}//if the user's number reaches the initial number the application if complete
					else if (userInput >= initNumber)
					{
                        //let the user know they have reached the number required to finish
						Console.WriteLine("This number is big enough.");
                        //break out of the while loop to initiate the end of the application/game.
						break;
					}
				} catch (Exception) 
                {
                    Console.WriteLine("That's not an integer goofy, try again please.");
                }            
            }
        }
    }
}
