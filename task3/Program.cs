// Сформируйте двухмерный массив из неповторяющихся случайных 
// двузначных чисел (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.


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

bool Contains(int[,] array, int m, int n, int p)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            if(array[i, j] == p)
            {
                return true;
            }
        }
    } 
    
    return false;
}

void FillArray(int[,] array, int m, int n)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            int num = 0;
            do
            {
                num = new Random().Next(10, 99);
            }
            while(Contains(array, m, n, num));

            array[i, j] = num;
        }
    }
}

int sizem = DataEntry("Введите m размер массива ");
int sizen = DataEntry("Введите n размер массива ");
int[,] numbers = new int[sizem, sizen];

if(sizem*sizen>50)
{
    System.Console.WriteLine("Превышен размер массива(более 50 элементов)");
}
else
{
    FillArray(numbers, sizem, sizen);
    ShowArray(numbers, sizem, sizen);
}

