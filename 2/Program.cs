// See https://aka.ms/new-console-template for more information
/*3. Напишите программу, которая будет выдавать название
дня недели по заданному номеру.

3 -> Среда
5 -> Пятница 
Console.Clear();

Console.WriteLine("Введите номер дня недели:");
int day = int.Parse(Console.ReadLine());

switch(day)
{
case 1:
Console.WriteLine("понедельник");
break;
case 2:
Console.WriteLine("вторник");
break;
case 3:
Console.WriteLine("среда");
break;
case 4:
Console.WriteLine("четверг");
break;
case 5:
Console.WriteLine("пятница");
break;
case 6:
Console.WriteLine("суббота");
break;
case 7:
Console.WriteLine("воскресенье");
break;
default:
Console.WriteLine("В неделе всего 7 дней");
break;
}
*/
Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int number = int.Parse(Console.ReadLine());
while(number > 7 || number<1 ) // && - это и || - это или
{
    Console.WriteLine("В неделе всего 7 дней");
    Console.WriteLine("Введите число от 1 до 7");
    number = int.Parse(Console.ReadLine());

} 
string [] Week = new string [] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};  
Console.WriteLine($"{number} день недели это {Week[number-1]}");
