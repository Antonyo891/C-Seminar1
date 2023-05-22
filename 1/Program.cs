// See https://aka.ms/new-console-template for more information
/*1.Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.

a = 25; b = 5->да
a = 2 b = 10->нет
a = 9; b = -3->да
a = -3 b = 9->нет*/
Console.Clear();
Console.WriteLine("Введите 2 числа через Enter");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Выажение в IF {Math.Pow(Number2,2) == Number1}");
if (Math.Pow(Number2,2)==Number1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Первое число не является квадратом второго");
}