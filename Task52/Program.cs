/* 
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
int[,] array = CreateArray(); // Создаем двумерный массив
PrintArray(array); // Выводим на консоль созданный двумерный массив

PrintAverageColumn(array); // Подсчет ср. арифметического каждого столбца. Вывод результата на экран.

// Ф-ция задающая двумерный массив случайным образом
int[,] CreateArray(){
    int m = new Random().Next(3, 7); // Задаем случайным образом длину строки массива (3...6)
    int n = new Random().Next(3, 7); // Задаем случайным образом длину столбца массива (3...6)

    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }

    return array;
}

// Ф-ция подсчета ср. арифметического в каждом столбце. Вывод результата на экран.
void PrintAverageColumn(int[,] array){
    int sum = 0;
    for(int j = 0; j < array.GetLength(1); j++){
        Console.Write($"Ср. арифметическое {j}-го столбца: ");
        for(int i = 0; i < array.GetLength(0); i++){
            sum += array[i,j];
        }
        Console.WriteLine("{0,00};", (double)sum/array.GetLength(0) );

        sum = 0;
    }
}

// Ф-ция вывода на консоль двумерного массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("]");
    }
}