// напишите программу каторая принимает на вход число N 
// и выдает таблицу квадратов чисел от 2 до N
// 5-->1,4,9,16,25.
// 2 --> 1,4/

void squareNumbers (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} -> {count*count}");
        count ++; 
    }
}

Console.WriteLine("Digit input user:");
int userNum = Convert.ToInt32(Console.ReadLine());
squareNumbers(userNum);