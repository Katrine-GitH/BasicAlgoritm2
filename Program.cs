//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ
Console.WriteLine("Write a 5-digit number");
int number = int.Parse(Console.ReadLine()); 
int digits2 = (number / 1000) % 10;
int digits4 = (number / 10) % 10;
int digits1 = (number / 10000) % 10;
int digits5 = number % 10;
//Console.WriteLine($"digits2:{digits2}, digits4:{digits4}, digits1:{digits1}, digits5:{digits5}");
if (digits1 == digits5)
    if (digits2 == digits4)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
else
{
    Console.WriteLine("No");
}