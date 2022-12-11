//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Напишите число N");
double number = 1;
double N = Convert.ToDouble(Console.ReadLine());
double Cube = 0;
while (number <= N)
{
    Cube = number * number * number;
    Console.WriteLine($"{number}^3={Cube} ");
    number++;
}