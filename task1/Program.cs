// Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array, int m, int n)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            int num = new Random().Next(0, 10);
            array[i, j] = num;
        }
    }
}

int sizem = DataEntry("Введите m размер массива ");
int sizen = DataEntry("Введите n размер массива ");
int[,] numbers = new int[sizem, sizen];

FillArray(numbers, sizem, sizen);
for(int i=0; i<sizem; i++)
{
    for(int j=0; j<sizen; j++)
    {
        System.Console.Write(numbers[i, j]);
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}

int sumact = 0;
int indact = 0;
for(int i=0; i<sizem; i++)
{
    int sum = 0;
    for(int j=0; j<sizen; j++)
    {
        sum = sum + numbers[i, j];
    }
    // System.Console.WriteLine(sum);
    if(sum<sumact || sumact == 0)
    {
        sumact = sum;
        indact = i;
    }
}
System.Console.Write("Индекс строки с наименьшей суммой элементов: ");
System.Console.WriteLine(indact);



