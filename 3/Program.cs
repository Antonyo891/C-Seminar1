// See https://aka.ms/new-console-template for more information
// /*5. Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.
Console.Clear();
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
Console.Write($"Целые числа в интервале от {-Number} до {Number} ");
 Console.WriteLine();
for (int i = - Number; i<=Number ; i++)
{
   
    Console.Write($" {i} ");
    
}
 Console.WriteLine();

