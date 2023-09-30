// напишите прогграмму каторая принимает на вход число N 
// и выдает произведение чисел от 1 до n
// 4 -> 24
// 5 - >120

int Sumnumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum *= i;
        }
        
    }
    return sum;
}
Console.WriteLine("Введите целое положтелнок число");
int number = Convert.ToInt32(Console.ReadLine());


int sumNumbers = Sumnumbers(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {sumNumbers}");