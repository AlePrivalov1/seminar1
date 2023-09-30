// напишите программу каторая по заданному номеру
//  четверти показывает диапозон возможных координат в этой четверти

string RangeCoordinates(int num)
{
    if (num == 1) return "x > 0 , y > 0";
    if (num == 2) return "x < 0 , y > 0";
    if (num == 3) return "x < 0 , y < 0";
    if (num == 4) return "x > 0 , y > 0";
    return null;
}

Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());

string range = RangeCoordinates(quater);

string result = range !=  null
                    ?$"диапозо координат для указанной четверти {range}"
                     : "Введены некоректный номер четверти";

Console.WriteLine(result);


