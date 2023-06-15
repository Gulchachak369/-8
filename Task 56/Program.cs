// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

const int minVal = 1; 
const int maxVal = 9; 
 
int[,] FillArrayRandomNumb(int length) { 
    Random rnd = new Random(); 
    int[,] randArr = new int[length, length]; 
 
    for (int i = 0; i < length; i++) { 
        for (int j = 0; j < length; j++) {  
            randArr[i, j] = rnd.Next(minVal, maxVal); 
        } 
    } 
 
    return randArr; 
} 
 
void PrintArray(int[,] arr) { 
    for (int i = 0; i < arr.GetLength(0); i++) { 
        for (int j = 0; j < arr.GetLength(1); j++)  
            System.Console.Write("{0} ", arr[i, j]); 
         
        System.Console.WriteLine(); 
    } 
 
} 
 
int MinSumRowCalc(int[,] arr) { 
    int minSumRow = 0; 
    int minSum = 0; 
 
    for (int i = 0; i < arr.GetLength(0); i++) { 
        int rowSum = 0; 
 
        for (int j = 0; j < arr.GetLength(1); j++) { 
            rowSum += arr[i, j]; 
        } 
 
        if (i == 0 || rowSum < minSum) { 
            minSum = rowSum; 
            minSumRow = i + 1; 
        } 
    } 
    return minSumRow; 
} 
 
System.Console.Write("Введите число m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
 
int[,] arr = FillArrayRandomNumb(m); 
PrintArray(arr); 
 
int row = MinSumRowCalc(arr); 
System.Console.WriteLine("номер строки с наименьшей суммой элементов: {0} строка", row);

