//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
//цифру этого числа.

//456 -> 5
//782 -> 8 
//918 -> 1


Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string snumber = Convert.ToString(number);
Console.WriteLine("The second digit of this number -> " + snumber[1]);

                              //Numeric variant (via string)

string number = Console.ReadLine();
Console.WriteLine(number[1]);

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
