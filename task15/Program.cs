// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string GetUserInput(string str) // запрос на ввод
{
    Console.Write(str);
    string day = Console.ReadLine();
    return day;
}
 string dey (string day)
 {
    if (day == "1")
    {
        Console.WriteLine("нет");
    }
    else if (day == "2")
    {
        Console.WriteLine("нет");
    }
    else if (day == "3")
    {
        Console.WriteLine("нет");
    }
    else if (day == "4")
    {
        Console.WriteLine("нет");
    }
    else if (day == "5")
    {
        Console.WriteLine("нет");
    }
    else if (day == "6")
    {
        Console.WriteLine("да");
    }
    else if (day == "7")
    {
        Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("Некоректный Ввод");
    }
    return day;

 }


string num1 = GetUserInput("введите день недели");
string result = dey(num1);
Console.WriteLine(result);

