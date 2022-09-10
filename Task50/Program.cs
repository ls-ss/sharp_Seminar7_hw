// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/* ********************
    Как я понял, нужно ввести номер строки и столбца, а в ответ получить значение этого элемента.
*/
Console.Clear();

int[,] array = CreateArray(); // Создаем двумерный массив
PrintArray(array); // Выводим на консоль созданный двумерный массив

int m = 0, n = 0; // m - номер строки, n - номер столбца
InputMxN(ref m, ref n); // Вводим значения нужной строки и стобца

PrintSearch(array, m, n); // Поиск заданного числа и выдача результата в консоль.

// Ф-ция задающая двумерный массив случайным образом
int[,] CreateArray(){
    int m = new Random().Next(3, 9); // Задаем случайным образом длину строки массива (3...8)
    int n = new Random().Next(3, 9); // Задаем случайным образом длину столбца массива (3...8)

    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }

    return array;
}

// Ф-ция ввода с клавиатуры номеров строк (m) и столбцов (n) двумерного массива
void InputMxN(ref int m, ref int n){
    Console.Write("Введите номер строки: ");
    m = int.Parse( Console.ReadLine() );
    Console.Write("Введите номер столбца : ");
    n = int.Parse( Console.ReadLine() );
}

// Ф-ция вывода на консоль значения элемента двумерного массива по номерам строки и столбца
void PrintSearch(int[,] array, int m, int n){
    Console.Write($"Строка m= {m}; Столбец n= {n}-> ");
    if(m <= array.GetLength(0) & n <= array.GetLength(1) ){
        Console.WriteLine($"Число {array[m-1,n-1]};");
    }
    else{
        Console.WriteLine("такого числа в массиве нет");
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