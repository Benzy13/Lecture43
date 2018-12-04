using System;

namespace Lecture43
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            Console.WriteLine("Question 1:\nEnter a number between 1 and 10");
            var inputString = Console.ReadLine();

            int number;
            Int32.TryParse(inputString, out number);

            if (number > 1 && number < 10) 
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //Question 2

            Console.WriteLine("\nQuestion 2:\nEnter a number");
            var num1 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            var num2 = Console.ReadLine();

            int number1;
            int number2;
            Int32.TryParse(num1, out number1);
            Int32.TryParse(num2, out number2);

            if (number1 > number2)
            {
                Console.WriteLine("1st number is geater");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("2nd number is greater");
            }
            else
            {
                Console.WriteLine("Square");
            }

            //Question 3

            Console.WriteLine("\nQuestion 3:\nEnter Height");
            var num3 = Console.ReadLine();
            int number3;
            Int32.TryParse(num3, out number3);

            Console.WriteLine("Enter Length");
            var num4 = Console.ReadLine();
            int number4;
            Int32.TryParse(num4, out number4);

            if (number3 > number4)
            {
                Console.WriteLine("Landscape");
            }
            else if (number3 < number4)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Square");
            }

            //Question 4

            Console.WriteLine("\nQuestion 4:\nImagine you are driving a car, what is your current velocity?");
            var strVelocity = Console.ReadLine();
            float velocity;
            Single.TryParse(strVelocity, out velocity);
            //int velocity = Int32.Parse(strVelocity);      A conversion method that does not catch errors

            var speedLimit = 120;

            Console.WriteLine(string.Format("The speed limit is {0}km/h", speedLimit));

            if (velocity <= speedLimit)
            {
                Console.WriteLine("Which means that you're OK.");
            }
            else
            {
                var points = (velocity - speedLimit)/5;
                var fine = points * 100;
                Console.WriteLine(string.Format("You have {0} Points. You have a fine of R{1}",points,fine));
                if (points>=12)
                {
                    Console.WriteLine("Your license is suspended!");
                }
            }
        }
    }
}

