//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int N;
Console.WriteLine("Enter N: ");
N = int.Parse(Console.ReadLine().ToString());
if (N.ToString().Length > 2)
{
    while (N.ToString().Length > 3)
        N /= 10;
    Console.WriteLine(N % 10);
}
else
    Console.WriteLine("No third digit!");
