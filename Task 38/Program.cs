// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

// Вариант 1

// double MaxElement(double[] array)
// {
//     double maxarr = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > maxarr)
//         {
//             maxarr = array[i];
//         }
//     }
//     return maxarr;

// }

// double MinElement(double[] array)
// {
//     double minarr = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < minarr)
//         {
//             minarr = array[i];
//         }
//     }
//     return minarr;
// }


// double[] myArray = GenerateArray(9);
// PrintArray(myArray);
// System.Console.WriteLine();
// System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {Math.Round(MaxElement(myArray) - MinElement(myArray), 4)}");

// Вариант 2

double PrintDiffMinMax(double[] array)
{
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        difference = array.Max() - array.Min();
    }
    return difference;
}

double[] myArray = GenerateArray(9);
PrintArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {Math.Round(PrintDiffMinMax(myArray), 4)}");