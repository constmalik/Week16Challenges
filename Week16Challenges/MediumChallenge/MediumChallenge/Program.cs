using System;

namespace MediumChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string of one star
            var star = "*";
            //var stars = star + star + star + star + star + star + star + star + star + star;

            //display 5 rows of 10 stars 
            for (var i = 0; i < 5; i++) 
            {
                
                for (var j = 0; j < 10; j++) 
                {
                    Console.Write(star);
                }

                Console.Write("\n");
            }
        }
    }
}
