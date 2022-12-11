// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
//A (0,0); B (1,1), -> ~1.4
//A (2,4); B (0,7) -> ~3.6

Console.WriteLine("Напишите координаты x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" x1= {x1}");
Console.WriteLine("Напишите координаты y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" y1={y1}");
Console.WriteLine("Напишите координаты x2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" x2= {x2}");
Console.WriteLine("Напишите координаты y1");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" y2={y2}");
double Distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine($"Расстояние между двумя точками равно:{Distance}");





//Console.Write("Введите имя: ");
//string? name = Console.ReadLine();
//Console.Write("Введите возраст: ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите рост: ");
//double height = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите размер зарплаты: ");
//decimal salary = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");
