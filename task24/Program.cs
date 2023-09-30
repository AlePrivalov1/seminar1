// напишите программу каторая принимает на вход число А и выдает сумму чисел от 1 до А
// 7 -> 28
// 4- > 10
// 8 ->36

int Sumnumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("Введите целое положтелнок число");
int number = Convert.ToInt32(Console.ReadLine());


int sumNumbers = Sumnumbers(number);
Console.WriteLine($"сумма чисел от 1 до {number} = {sumNumbers}");

