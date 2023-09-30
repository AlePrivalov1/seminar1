// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetUserInput(string msg)
{
    Console.WriteLine($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int LenghtNum(int num)
{
    
    int result = 0;
    while (num > 0 )
    {
        result += num %10; //прибовляем остаток от деления последнюю цифру
        num = num/10; //уменьшаем разряд
    }
    return result;
}

Console.WriteLine("Введите число ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sumNumbers = LenghtNum(numberB);
Console.WriteLine($"{numberB} -> {sumNumbers}");