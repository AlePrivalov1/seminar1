// напишите программу каторая выводит массив из 8 элементов 
// заполняемый единицами и нулями с лучайг=ном порядке


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

void PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}," : $"{array[i]}";
    }
    Console.WriteLine(output);
}

void PrintArray2(int[] array)
{

    Console.Write('[');
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
PrintArray(arr);