using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLoopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    for(int i = 0; i < 100; i++)
            //    {
            //        if(i%5 == 0)
            //        {

            //            break;
            //        }
            //        Console.WriteLine(i + "\t");
            //    }
            //    Console.ReadKey();
            //}

            //int num;
            //string choice;
            //do
            //{
            //    Console.WriteLine("Enter number to find out table of the number");
            //    num = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Table of {num} as follows");
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.WriteLine($"{num}*{i}=\t{(num * i)}");

            //    }
            //    Console.WriteLine("Do you wann learn more \n if yes press y \n To exit press any other key");
            //    choice = Console.ReadLine().ToLower();
            //}
            //while (choice == "y");

            //  string username;
            //  string password;
            //  Console.WriteLine("Please provide username: ");
            //  username = Console.ReadLine();

            //  Console.WriteLine("Please provide password: ");
            //   password = Console.ReadLine();


            //if (username == "admin1256" && password == "admin@1256@1256")
            //  {
            //      Console.WriteLine("SignIn Success");
            //  }
            // else  if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //  {
            //      Console.WriteLine("Please provide username and password");
            //  }
            //  else
            //  {
            //      Console.WriteLine("!Invalid user ");
            //  }

            //  Console.ReadKey();

            //var myNum = 12;

            //var myString = "Sam";

            //var status = true;

            //var grade = 'A';

            //Console.WriteLine("Value Stored in myNum is: " + myNum + "\n Data Type: " + myNum.GetType());

            //Console.WriteLine("Value Stored in myString is: " + myString + "\n Data Type: " + myString.GetType());


            //Console.WriteLine("Value Stored in status is: " + status + "\n Data Type : " + status.GetType());

            //Console.WriteLine("Value Stored in grade is: " + grade + "\n Data Type : " + grade.GetType());

            //Console.ReadKey();

            var myNum = 12;

            dynamic myDynamic = 45;

            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:  " + myDynamic.GetType());

            myDynamic = "I am Sam";

            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is" + myDynamic.GetType());


            myDynamic = 'A';

            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is " + myDynamic.GetType());
            Console.WriteLine("Value Stored in mylum is:" + myNum + "\n Data Type: " + myDynamic.GetType());




            Console.ReadKey();
            try
            {

                Console.WriteLine("Please enter a number");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))

                {

                    Console.WriteLine("Parsed Number using intTryParse is: \t" + result);



                }
                else
                {


                    Console.WriteLine("Failed to Parse");

                }
            }


            catch (Exception ex)

            {
                Console.WriteLine("Error!!!" + ex.Message);
            }


            finally
            {

                Console.ReadKey();
            }
        }
             try
             {

                 double num1, num2, result;

        Console.WriteLine("Enter First Number ");

                 num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Second Number");

                 num2 = double.Parse(Console.ReadLine());

        result = num1 / num2;
                 Console.WriteLine($"Result after dividing {num1} by {num2} is = \t {result}");

 catch (Exception ex)

             { Console.WriteLine("Error!!!" + ex.Message); }

             finally {

                 Console.ReadKey();
             }
         }
            double num1, num2, result;
Console.WriteLine("Enter First Number");
double.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Enter Second Number");
double.TryParse(Console.ReadLine(), out num2);
result = num1 / num2;
Console.WriteLine($"Result after dividing {num1} by {num2} is = \t {result}");

Console.ReadKey();
        }
    }
}
    

