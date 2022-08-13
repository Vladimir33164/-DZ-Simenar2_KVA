/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет

                                Первое решение задачи

Console.Write("Enter the number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if(dayNumber == 1)
{
    Console.WriteLine("1 -> No");
}
if(dayNumber == 2)
{
    Console.WriteLine("2 -> No");
}
if(dayNumber == 3)
{
    Console.WriteLine("3 -> No");
}
if(dayNumber == 4)
{
    Console.WriteLine("4 -> No");
}
if(dayNumber == 5)
{
    Console.WriteLine("5 -> No");
}
if(dayNumber == 6)
{
    Console.WriteLine("6 -> Yes");
}
if(dayNumber == 7)
{
    Console.WriteLine("7 -> Yes");
}

                                    Второе решение задачи
*/

Console.Write("Enter the number of the day of the week: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
void WeeklyTest(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("Weekend"); //Выходной
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("Is this exactly the day of the week?"); //Это точно день недели?
    }
    else Console.WriteLine("The day is not a day off"); //День не выходной
}
WeeklyTest(dayNum);
