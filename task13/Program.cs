// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int GetUserInput(string str) // запрос на ввод
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SecondDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }

    return  num % 10;
}

bool numerA (int num)
{
    if (num <100)
    {
        Console.WriteLine(" нет третьей цифры");
        return false;
    }
    return true;
}   

int num =GetUserInput ("введите чяисло");
if (numerA(num))
{
    Console.WriteLine(SecondDigit(num));
}