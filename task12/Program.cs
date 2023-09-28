// напишите программу каторая впринимает 2 числа если кратно второму, если не кратно остаток
int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int IGetRemaider(int num1, int num2)
{
     return num1 % num2;
    
}

int firstNum = GetUserInput("Ведите первое число");
int secondNum = GetUserInput("Ведите второе число");
int rem = IGetRemaider(firstNum , secondNum);

if (rem == 0)
{
    Console.WriteLine($" число {firstNum} кратно {secondNum}");
}
else
{
    Console.WriteLine($" число {firstNum} не кратно {secondNum}  остаток {rem}");
}