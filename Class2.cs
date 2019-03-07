using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            st.Start();



            Console.WriteLine("Welcome to your menu. \nChoose '1' if you would like to run exercise 1. \nChoose '2' if you would like to run exercise 2. \nChoose '3' if you would like to run exercise 3.");

            int input = int.Parse(Console.ReadLine());



            if (input == 1)

            {

                Console.WriteLine("What is your name:");

                string name = Console.ReadLine();

                Console.WriteLine("\nhello " + name + ".");



                Console.WriteLine("\nHow old are you: ");

                int age = int.Parse(Console.ReadLine());



                Console.WriteLine("\nPlease enter your gender, 'm' or 'f': ");

                char gender = char.Parse(Console.ReadLine());



                Console.WriteLine("\nPlease enter your address: ");

                string address = Console.ReadLine();



                Console.WriteLine("\nThank you. Your details are as follows:\nAge: {0}\nGender: {1}\nAddress: {2}", age, gender, address);

                Console.ReadLine();

            }

            else if (input == 2)

            {

                Console.WriteLine("Please enter a number:\n ");

                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease type another number:\n ");

                double num2 = double.Parse(Console.ReadLine());







                double result1 = num1 + num2;

                double result2 = num1 - num2;

                double result3 = num1 * num2;

                double result4 = num1 / num2;



                Console.WriteLine("\nYour answer is: \n\n{0} + {1} = {2}", num1, num2, result1);

                Console.WriteLine("\nYour answer is: \n\n{0} - {1} = {2}", num1, num2, result2);

                Console.WriteLine("\nYour answer is: \n\n{0} * {1} = {2}", num1, num2, result3);

                Console.WriteLine("\nYour answer is: \n\n{0} / {1} = {2}", num1, num2, result4);



                Console.WriteLine($"\nYour answer is: \n\n{num1} + {num2} = {result1}");



                Console.ReadLine();

            }

            else if (input == 3)

            {

                Console.WriteLine("What is your first name: ");

                string fname = Console.ReadLine();



                Console.WriteLine("What is your Last name: ");

                string lname = Console.ReadLine();



                //Task 3b//



                string fullname = fname + " " + lname;

                Console.WriteLine("Hello, " + fullname);

                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Sorry, we dont understand your input. Please try again.");
            }

            Console.ReadLine();

            st.Stop();

            Console.WriteLine("\n Congradulations, you have wasted " + st.Elapsed + "seconds of your life.");

            Console.ReadLine();

        }











    }









}


        
    

