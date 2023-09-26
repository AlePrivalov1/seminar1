Console.WriteLine("Введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB * numberB == numberA)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
