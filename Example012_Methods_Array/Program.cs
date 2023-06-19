//Упорядочить массивы
//Было:68321457
//Результат:12345678

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) //метод, который выводт массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array) //метод, который упорядочивает массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) 
            {
                minPosition = j; //поиск минимального
            }
        }
        int temporary = array[i]; //обменяли местами 2 переменные, через временную
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);