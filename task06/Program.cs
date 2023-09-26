// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("введите первоне число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
     max = numberB;
}

if (max < numberC)
{
     max = numberC;
}

Console.Write($"{numberA} , {numberB} , {numberC} -> {max}");
