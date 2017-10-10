using System;

namespace VeryHardChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //begin program by asking user to enter a number they want converted
				Console.WriteLine("Please enter and Integer.");
				int number = Convert.ToInt32(Console.ReadLine());
                //ask the user how they want the number to be converted.
				Console.WriteLine("Specify how you want to convert your number. \nPlease enter 'I' for Inches, 'G' for Gallons, 'M for Miles, or 'P' for pounds.'");
				string conversion = Console.ReadLine();

                //representation of the conversion for each variable 
                var inches = (number * 2.54);
                var gallons = (number * 3.785);
                var miles = (number * 1.609);
                var pounds = (number * 0.454);

                //if user input for conversion is equal to any of the following 
                //cases then the conversion statement will be displayed along 
                //with the previous type. 
				switch (conversion)
				{
					case "I":
						Console.WriteLine(number + " inches is " + inches + " in centimeters.");
						break;
					case "G":
						Console.WriteLine(number + " gallons is " + gallons + " in liters.");
						break;
					case "M":
						Console.WriteLine(number + " miles is " + miles + " in kilometers.");
						break;
					case "P":
						Console.WriteLine(number + " pounds is " + pounds + " in kilograms.");
						break;
					default:
						Console.WriteLine("You were supposed to enter \n'I' for Inches, 'G' for Gallons, 'M for Miles, or 'P' for pounds. \nTry again'");
						break;
				}                
            } catch (Exception) 
            {
                Console.WriteLine("You must enter a valid number!");
            }

        }
    }
}
