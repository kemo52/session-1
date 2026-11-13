using System;
using System.Security.Cryptography.X509Certificates;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////TASK 1 

            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            if (name == ("IEEE"))
            {
                Console.WriteLine(" my name is IEEE");
            }
            else
            {
                Console.WriteLine(" not IEEE");
            }

            ////TASK 2

            string[] day = { "invalid day", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday (weekend)", "Friday (weekend)" };

            Console.WriteLine("Enter a day of the week:");
            int dayIndex = int.Parse(Console.ReadLine());

            if (dayIndex >= 0 && dayIndex < day.Length)
            {
                Console.WriteLine($"You entered: {day[dayIndex]}");
            }
            else
            {
                Console.WriteLine("Invalid day index.");
            }

            //TASK 3
            //both brint "Ali"

            //TASK 6

            Console.WriteLine("Enter the 1st number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine($" {number1} + {number2} = {number1 + number2}");
            Console.WriteLine($" {number1} - {number2} = {number1 - number2}");
            Console.WriteLine($" {number1} * {number2} = {number1 * number2}");
            Console.WriteLine($" {number1} / {number2} = {number1 / number2}");
            Console.WriteLine($" {number1} % {number2} = {number1 % number2}");

            // int cannot be used for division because it will return an integer result not accurate for decimal values 
            // double is used to allow for decimal results in division

           
        }
    }
}