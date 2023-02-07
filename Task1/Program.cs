
// Написать программу, которая обменивает элементы первой строки и последней строки

// Фун-я заполнения массива случайными числами
void FillArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
        }
    }
}

// Фун-я вывода массива
void PrintArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i, j]+"\t");
        }
         Console.WriteLine();
    }
}

// Фун-я перестановки местами строк массива
void swapString(int[,] array, int arg)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        int temp = array[0,i];
        array[0,i] = array[arg-1,i];
        array[arg-1,i] = temp;
    }
}

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr = new int[line,column];
FillArray(arr);
PrintArray(arr);
swapString(arr, line);
PrintArray(arr);