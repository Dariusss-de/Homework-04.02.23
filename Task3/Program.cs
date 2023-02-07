// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

// Фун-я суммы строк массива и вычисления минимального значения
void SmallestAmount(int[,] array,int arg1)
{
    int[] sumrow = new int[arg1]; // массив для записи суммы строк
    int min=0;
    for(int i =0; i<array.GetLength(0);i++)
    {
        int sum = 0;
        
        for(int j=0;j<array.GetLength(1);j++)
       {
            sum += array[i,j];
           sumrow[i]=sum;
            min = sumrow.Min();
       }
      Console.Write(sumrow[i]+" ");
      
    }
    Console.WriteLine();
    Console.WriteLine("Минимальное значение суммы строк массива = "+min );
}


Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
try
{
    if(line<=0 || column<=0) 
    {
    throw new Exception("wrong line or colum");
    }
}
catch
{
    Console.Write("Введите количество строк: ");
    line = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    column = int.Parse(Console.ReadLine());
}
int[,] arr = new int[line,column];
FillArray(arr);
PrintArray(arr);
if(line == column) SmallestAmount(arr,line);
else if(line !=column)  Console.WriteLine("Матрица не прямоугольная");
