using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp5
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
                Console.WriteLine("what is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("\nHello " + name + ".");

                Console.WriteLine("\nHow old are you: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease enter your gender, 'M' or 'F': ");
                char gender = char.Parse(Console.ReadLine());

                Console.WriteLine("\nPlease enter your address: ");
                string address = Console.ReadLine();

                Console.WriteLine("\nThank you. Your details are as follows: \nName: {0}\nAge: {1}\nGender: {2}\nAddress: {3}", name, age, gender, address);
                Console.ReadLine();
            }
            else if (input == 2)
            {
                Console.WriteLine("Please enter a number: \n ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter another number: \n");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Press 1 to add\nPress 2 for -\nPress 3 for *\nPress 4 for / ");

                int input1 = int.Parse(Console.ReadLine());

                double result = 0;
                if (input1 == 1)
                {
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                }
                else if (input1 == 2)
                {
                    result = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                }
                else if (input1 == 3)
                {
                    result = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                }
                else if (input1 == 4)
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                }
                    
                    Console.WriteLine($"\nYour answer is: \n\n{num1} + {num2} = {result} ");
                    Console.ReadLine();
                    
                
                }
                else if (input == 3)
                {



                    Console.WriteLine("What is your first name: ");
                    string fname = Console.ReadLine();

                    Console.WriteLine("What is your last name: ");
                    string lname = Console.ReadLine();

                    string fullname = fname + " " + lname;
                    Console.WriteLine("hello, " + fullname);
                    

                }
                else
                {
                    Console.WriteLine("Sorry, we dont understand your input, Please try again.");
                }
               
                st.Stop();
                Console.WriteLine("Congradulations, you have wasted " + st.Elapsed + "seconds of your life.");
                Console.ReadLine();
            }
        }
    }



            

        




        
    

