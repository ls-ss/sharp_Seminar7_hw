// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7    -2    -0,2
// 1    -3,3   8    -9,9
// 8     7,8  -7,1   9
Console.Clear();

int m = 0, n = 0; // m - кол-во строк, n - кол-во столбцов
InputMxN(ref m, ref n);

double[,] arrayMxN = new double[m, n]; // Матрица M x N
CreateArrayMxN(m, n, ref arrayMxN);

PrintArrayMxN(m, n, arrayMxN);

// ************
// Ф-ция ввода с клавиатуры строк (m) и столбцов (n) будущего двумерного массива
void InputMxN(ref int m, ref int n){
    Console.Write("Введите кол-во строк массива: ");
    m = int.Parse( Console.ReadLine() );
    Console.Write("Введите кол-во столбцов массиве: ");
    n = int.Parse( Console.ReadLine() );
}

// Ф-ция задающая двумерный массив по переданным m (строка) и n (столбец)
void CreateArrayMxN(int m, int n, ref double[,] arrayMxN){
    Random rand = new Random(); // объявление переменной для генерации чисел
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            arrayMxN[i,j] = Convert.ToDouble(rand.Next(-99, 100)/10.0);
        }
    }
}

// Ф-ция вывода двумерного массива в консоль ввиде таблицы.
void PrintArrayMxN(int m, int n, double[,] arrayMxN){
    Console.WriteLine($"Матрица размером {m} на {n}:");

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            Console.Write( String.Format("{0,6}", arrayMxN[i,j]) );
        }
        Console.WriteLine();
    }     
}