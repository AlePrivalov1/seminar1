// напишите программу каторая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2д пространстве

// А (3,6); И(2,1) -> 5,09
// A (7,-5);bool (1,-1) -> 7,21

int GetUserInput(string message)
{
    Console.Write($"{message}): ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double Distance(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow((y2 - y1), 2));
    return res;
}

int x1 = GetUserInput("Введите координту первой точки Х");
int y1 = GetUserInput("Введите координту первой точки Y");
Console.WriteLine("---------------------------");
int x2 = GetUserInput("Введите координту второй точки Х");
int y2 = GetUserInput("Введите координту второй точки Y");

double distance = Distance(x1,y1,x2,y2);


Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));