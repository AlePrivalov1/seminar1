// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

// bool even = numberA % 2;


if (numberA % 2)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}