using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uskey = "1";
            while (uskey != "0")
            {
                Console.WriteLine("welcome");
                Console.WriteLine("\t" + "0.Exit");
                Console.WriteLine("\t" + "1.Question1");
                Console.WriteLine("\t" + "2.Qestion2");
                Console.WriteLine("\t" + "3.Question3");
                Console.WriteLine("\t" + "4.Question4");
                Console.WriteLine("\t" + "5.Question5");
                Console.WriteLine("\t" + "6.Question6");
                Console.WriteLine("\t" + "7.Question7");
                Console.WriteLine("\t" + "8.Question8");
                Console.WriteLine("\t" + "9.Question9 ");
                Console.WriteLine("\t" + "10.Question10");
                Console.WriteLine("\t" + "11.Question11");
                Console.WriteLine("\t" + "12.Question12");
                Console.WriteLine("\t" + "13.Question13");
                Console.WriteLine("\t" + "14.Question14");
                Console.WriteLine("\t" + "15.Question15");
                Console.WriteLine("\t" + "16.Question16");
                Console.WriteLine("\t" + "Enter your choice: ");
                uskey = Console.ReadLine();
                switch (uskey)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                    case "8":
                        Question8();
                        break;
                    case "9":
                        Question9();
                        break;
                    case "10":
                        Question10();
                        break;
                    case "11":
                        Question11();
                        break;
                    case "12":
                        Question12();
                        break;
                    case "13":
                        Question13();
                        break;
                  //  case "14":
                   //     Question14();
                    //    break;
                    //case "15":
                      //  Question15();
                      //  break;
                   // case "16":
                      //  Question16();
                       // break;

                }
            }
            void Question1()
            {
                Console.WriteLine(" Hello World ");
                Console.ReadKey();
            }
            void Question2()
            {
                Console.WriteLine(" Please enter your name: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Please enter your family: ");
                string Family = Console.ReadLine();
                Console.WriteLine("Please enter your age: ");
                string Age = Console.ReadLine();
                Console.Write($"You are {Name} {Family} and are {Age} years old.");
            
                Console.ReadKey();

            }
            void Question3()
            {
                string color = Console.ForegroundColor.ToString();
                if (color == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("It is a different color");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("It is a normal color");


                }

                Console.ReadKey();
            }


            void Question4()
            {
                DateTime date = DateTime.Now;
                Console.WriteLine(date.ToString());
                Console.ReadKey();
            }

            void Question5()
            {

                Console.WriteLine(" Enter first number");
                string a = Console.ReadLine();
                int number1 = Convert.ToInt32(a);
                Console.WriteLine(" Enter second number");
                string b = Console.ReadLine();
                int number2 = Convert.ToInt32(b);
                if (number1 > number2)
                {
                    Console.Write($" The largest number is : {number1}");
                }

                if (number1 < number2)
                {
                    Console.Write($" The largest number is : {number2}");


                }
                Console.ReadKey();
            }


            void Question6()
            {
                bool flag = true;
                int n = 0;
                Random rnd = new Random();
                int rand = rnd.Next(1, 100);
                Console.WriteLine("guess a number between 1 and 100");
                while (flag)
                {

                    n++;
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (rand < number) { Console.WriteLine("Guess a lower number"); }
                    if (rand > number) { Console.WriteLine("Guess a higher number"); }
                    if (rand == number) { flag = false; }

                }
                Console.Write($"Great! You guess with {n} tries");
                Console.ReadKey();
            }

            void Question7()
            {
                Console.WriteLine(" Please enter a text ");
                string input = Console.ReadLine();
                List<string> lines = new List<string>();
                lines.Add(input);
                System.IO.File.WriteAllLines("C:\\Ny mapp\\file.text", lines);
                Console.ReadKey();

            }
            void Question8()
            {
                var lines = System.IO.File.ReadAllLines("C:\\Ny mapp\\file.text");
                foreach (var line in lines)
                { Console.WriteLine(line); }

                Console.ReadKey();
            }
            void Question9()
            {
                Console.WriteLine(" Enter a decimal number: ");
                Double number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(number));
                Console.WriteLine(Math.Pow(number, 2));
                Console.WriteLine(Math.Pow(number, 10));
                Console.ReadKey();

            }
            void Question10()
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)

                    {
                        Console.Write(i * j + "\t");

                    }
                    Console.WriteLine();

                }
                Console.ReadKey();
            }

            void Question11()
            {
                int[] number = new int[12];
                Random rand = new Random();
                for (int i = 0; i < 12; i++)
                {
                    number[i] = rand.Next(1, 1000);
                    Console.Write(number[i] + "\t");


                }
                Console.ReadKey();
                Console.WriteLine();
                int n, j, minIndex, tmp;

                for (n = 0; n < 12; n++)
                {
                    minIndex = n;
                    for (j = n + 1; j < 12; j++)
                        if (number[j] < number[minIndex])
                            minIndex = j;
                    if (minIndex != n)
                    {
                        tmp = number[n];
                        number[n] = number[minIndex];
                        number[minIndex] = tmp;
                    }
                    Console.Write(number[n] + "\t");
                }
                Console.ReadKey();

            }
            void Question12()
            {
                string instr, revstr = string.Empty;
                Console.Write("Enter a word : ");
                instr = Console.ReadLine();
                if (instr != null)
                {
                    for (int i = instr.Length - 1; i >= 0; i--)
                    {
                        revstr += instr[i].ToString();
                    }
                    if (revstr == instr)
                    {
                        Console.WriteLine("The word is Palindrome.");
                    }
                    else
                    {
                        Console.WriteLine("The word is not Palindrome.");
                    }
                }

                Console.ReadLine();
            }

            void Question13()
            {
                Console.WriteLine(" Please enter two number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                if (firstNumber < secondNumber)
                {
                    for (int i = firstNumber; i < secondNumber + 1; i++)
                    {
                        Console.Write(i + "\t");

                    }


                }
                else
                {
                    for (int i = secondNumber; i < firstNumber + 1; i++)

                    {
                        Console.Write(i + "\t");

                    }
                }
                Console.ReadKey();
            }
            
        }

    }
}
