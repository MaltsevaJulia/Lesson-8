// Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить произведение двух матриц.

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowArray(int[,] array, int sizem, int sizen)
{
   for(int i=0; i<sizem; i++)
    {
        for(int j=0; j<sizen; j++)
        {
            System.Console.Write(array[i, j]);
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
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
int[,] numbers1 = new int[sizem, sizen];
int[,] numbers2 = new int[sizem, sizen];
int[,] numbersRez = new int[sizem, sizen];


FillArray(numbers1, sizem, sizen);
FillArray(numbers2, sizem, sizen);

ShowArray(numbers1, sizem, sizen);
System.Console.WriteLine("-----");
ShowArray(numbers2, sizem, sizen);

for(int i=0; i<sizem; i++)
{
    int sum = 0;
    for(int j=0; j<sizen; j++)
    {
        numbersRez[i, j] = numbers1[i, j]*numbers2[i, j];
    }
}
System.Console.WriteLine("-Результирующая матрица-");
ShowArray(numbersRez, sizem, sizen);
 





