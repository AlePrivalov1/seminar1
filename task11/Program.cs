// ввод трехзначное вывод двузначное
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thrdDigit = num % 10;
    return  firstDigit * 10 + thrdDigit; 
}




int numberA = new Random().Next(100,1000);
Console.WriteLine(numberA);
// int firstDigit = numberA / 100;
// int thrdDigit = numberA % 10;
// int result = firstDigit * 10 + thrdDigit;
int result = DeleteSecondDigit(numberA);
Console.WriteLine(result);