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
            int.TryParse(inputString, out number);

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
            int.TryParse(num1, out number1);
            int.TryParse(num2, out number2);

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
            int.TryParse(num3, out number3);

            Console.WriteLine("Enter Length");
            var num4 = Console.ReadLine();
            int number4;
            int.TryParse(num4, out number4);

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
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        public void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Exercise2()
        {
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        public void Exercise3()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public void Exercise4()
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
   
}



