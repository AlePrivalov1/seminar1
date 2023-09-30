// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] RandomArray(int arrlenght)
{
    int[] arr = new int[arrlenght];
    Random rand = new Random();
    for (int i = 0; i < arrlenght; i++)
    {
        arr[i] = rand.Next(2);
    }
    return arr;
}


void PrintArray2(int[] array)
{

    Console.Write(' ');
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]} --> [");
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]} ]");
        }
    }

}

int[] arr = RandomArray(8);

PrintArray2(arr);