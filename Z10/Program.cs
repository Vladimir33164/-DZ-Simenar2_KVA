//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
//цифру этого числа.

//456 -> 5
//782 -> 8 
//918 -> 1


Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string snumber = Convert.ToString(number);
Console.WriteLine("The second digit of this number -> " + snumber[1]);

                              //Numeric variant (via void)

using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int N;

            while (true)
            {
                Console.WriteLine("Enter a three-digit integer N (or -1 to terminate the program): ");

                N = int.Parse(Console.ReadLine().ToString());// по условию задачи на вход поступает именно трехзначное число,
                                                             // значит какие-либо последующие проверки не требуются.
                if (N == -1)
                    break;

                N /= 10;

                Console.WriteLine(N % 10);
            }

        }
    }
}


                              //Numeric variant (via while)

int a;
int result;
Console.Write("Enter a three-digit number: ");
a = Convert.ToInt32(Console.ReadLine());
while ((a > 999) || (a < 100))
{
   Console.Write("Error! Enter a number from 100 to 999: ");
   a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}
result = (a / 10) % 10;
Console.WriteLine(result);
