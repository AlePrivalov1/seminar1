// напишите програму каторая прингимает число 
// и выдает количество чисел в числе
// 456 -- > 3
// 78 --> 2

int GetUserInput(string msg)
{
    Console.WriteLine($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int LenghtNum(int num)
{
    if (num == 0) return 1; 
    int count = 0;
    while (num != 0 )
    {
        count ++;
        num = num/10;
    }
    return count;
}

int number = GetUserInput("enter a number");
int lenghr = LenghtNum(number);

Console.WriteLine($"{number} -> {lenghr}");