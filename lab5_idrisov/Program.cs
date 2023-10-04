//Лаб 5, Средний уровень, задание 24

Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c:");
double c = double.Parse(Console.ReadLine());
if ((a==b) || (a==c) || (b==c)) {
    Console.WriteLine("Имеется пара равных");
} else { Console.WriteLine("Не имеется пара равных"); }
