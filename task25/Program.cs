// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetUserInput(string msg)
{
    Console.WriteLine($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int Sumnumbers(int numberA, int numberB)
{
    int numberC = numberA;  
    
    for (int i = 1; i < numberB; i++)
    {
        checked
        {
            numberA = numberC * numberA;
        }
        
    }
    return numberA;
}


Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int numberB = Convert.ToInt32(Console.ReadLine());

int sumNumbers = Sumnumbers(numberA, numberB);
Console.WriteLine($" {numberA}, {numberB} -> {sumNumbers}");

