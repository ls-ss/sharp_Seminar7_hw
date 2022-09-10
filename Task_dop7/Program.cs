/* Дополнительная задача: Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, 
   сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.

4 4 7 5
4 3 5 3
8 1 6 8 -> нет

2 4 7 2
4 3 5 3
2 1 6 2 -> да
*/
Console.Clear();
int[,] array = CreateArray(); // Создаем двумерный массив
PrintArray(array); // Выводим на консоль созданный двумерный массив

int sunAngles = SunNumAngles(array); // Сумма значений угловых элементов матрицы

int[] sumColumns = SumNumColumns(array); // Массив сумм значений элементов столбцов матрицы

PrintCompare(sunAngles, sumColumns); // Сравниваем сумму углов и столбцов. Выводим результат.

// Ф-ция задающая двумерный массив случайным образом
int[,] CreateArray(){
    int m = new Random().Next(3, 7); // Задаем случайным образом длину строки массива (3...6)
    int n = new Random().Next(3, 7); // Задаем случайным образом длину столбца массива (3...6)

    Console.WriteLine($"Матрица {m} x {n}:");

    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }

    return array;
}

// Ф-ция подсчета значений угловых элементов матрицы.
int SunNumAngles(int [,] array){
    int sumAngles = array[0, 0] 
                     + array[0, array.GetLength(1) - 1]
                     + array[array.GetLength(0) - 1, 0] 
                     + array[array.GetLength(0) -1, array.GetLength(1) -1];
    Console.WriteLine($"Сумма значений углов= {sumAngles}");
    
    return sumAngles;
}

// Ф-ция подсчета суммы каждого столбца.
int[] SumNumColumns(int[,] array){
    int[] sumColumns = new int[array.GetLength(1)];
    int sum = 0;

    for(int j = 0; j < array.GetLength(1); j++){
        Console.Write($"Сумма значений столбца {j}: ");
        for(int i = 0; i < array.GetLength(0); i++){
            sum += array[i,j];
        }
        sumColumns[j] = sum;
        Console.WriteLine($"{sum};");

        sum = 0;
    }
    return sumColumns;
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

// Ф-ция сравнения и вывода результата на консоль.
void PrintCompare(int sunAngles, int[] sumColumns){
    string text = "-> Нет.";

    for(int i = 0; i < sumColumns.Length; i++){
        if(sumColumns[i] > sunAngles){
            text = "-> Да.";
            break;
        }
    }

    Console.WriteLine(text);
}