// напишите програму каторая принимает на вход 2 числоа и проверяет 
//является ли одно число квадратом другого
int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsSsquaref(int number1, int number2)
{
    return number1 == number2 * number2 || number2 == number1 * number1;// ||- или && - и
}

int num1 = GetUserInput("введите первое число");
int num2 = GetUserInput("введите  второе число");
bool issquar = IsSsquaref(num1,num2);
Console.WriteLine(issquar ? "да" : "нет");


