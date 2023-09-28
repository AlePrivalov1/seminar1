// напитшите программу каторая выводит случайное число из отреска от 10 до 99 и показывает наибольшую цифру.

int numberA = new Random().Next(10, 100); // 99 +1
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {numberA}");


// int firstDigit = numberA / 10;// 78 / 70 = 7
// int secondDigit = numberA % 10; //78 = 70 + 8 

// if (firstDigit > secondDigit) 
// {
//     Console.WriteLine($"наибольшая цифра числа -> {firstDigit}");
// }
// else 
// {
//     Console.WriteLine($" наибольшая цифра числа -> {secondDigit}");
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // тернарный оператор условие ?- тогда  : - иначе.
// Console.WriteLine($" наибольшая цифра числа -> { maxDigit}");

int maxDigit = MaxDigit(numberA);
Console.WriteLine($" наибольшая цифра числа -> { maxDigit}");

int MaxDigit (int num) 
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; 
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}