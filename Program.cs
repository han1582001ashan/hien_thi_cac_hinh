using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace DisplayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Print the rectangle:");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");
            int choice;
            do
            {
                   choice = Int32.Parse(Console.ReadLine());
            
                switch (choice)
                {
                    
                    case 1:
                        for (int i = 1; i <= 6; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        for (int i = 7; i >1; i--)
                        {
                            for (int j = i; j > 1; j--)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                        case 3:
                         for (int i = 1; i <= 7; i++)
                        {
                            for (int j = 1; j < i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                }

            } while (choice != 4);


        }
    }
}

