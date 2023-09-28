// SНапишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SecondDigit(int num)
{
    int number2 = num / 10;

    return  number2 % 10;
}


int num1 = GetUserInput("введите трех значное число");
int result = SecondDigit(num1);
Console.WriteLine(result);

