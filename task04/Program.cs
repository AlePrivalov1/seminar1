Console.WriteLine("Введите трехзначное число:");
int nemberA = Convert.ToInt32(Console.ReadLine());

if (nemberA < 0 ) nemberA *= -1;

if (nemberA >= 100 && nemberA <= 999);
{
    int lastDigit = nemberA % 10;

    Console.Write($"последняя цифра числа -> {lastDigit}");
}
// else
// {
//     Console.WriteLine("некоректный ввод");
// } 


