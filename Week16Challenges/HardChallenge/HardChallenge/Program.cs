using System;

namespace HardChallenge
{
	class Program
	{
		static void Main(string[] args)
		{
            var space = " ";//variable for space
            var star = "*";//variable for each star
            //this loop ensures that there wil be 5 rows of stars
            for (var i = 0; i < 6; i++) 
            {
                //loop for spaces. they decrease as long as j is greater than i, which will continue until the five rows are shown

                for (var j = 5; j > i; j--) 
                {
                    Console.Write(space);
                }
                //
                for (var m = 1; m <= (2 * i - 1); m++) 
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
		}
	}
}
