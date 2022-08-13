//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
//цифру этого числа.

//456 -> 5
//782 -> 8 
//918 -> 1


Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string snumber = Convert.ToString(number);
Console.WriteLine("The second digit of this number -> " + snumber[1]);
       