/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number;
for (i=number; i>1000; i=i/10);
if (i<100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine(i%10);
}