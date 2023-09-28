// напишите програму каторая принимает на ввод число проверяет кратно 
//ли оно одновременно 7 и 23

int GetUserInput(string str)
{
    Console.Write(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool DivisionTo7and23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Введите число");

bool result = DivisionTo7and23 (number);

Console.WriteLine(result ? $"{number} --> да" : $"{number} --> нет");


