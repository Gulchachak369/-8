// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

const int length = 2; 
const int minVal = 10; 
const int maxVal = 99; 
 
void PrintArrayRandomNumb() { 
    Random rnd = new Random(); 
    int[,,] randArr = new int[length, length, length]; 
 
    for (int i = 0; i < length; i++) { 
        for (int j = 0; j < length; j++) { 
            for (int k = 0; k < length; k++) { 
                int randNumb = rnd.Next(minVal, maxVal); 
                System.Console.Write("{0}({1},{2},{3}) ", randNumb, i, j, k); 
            } 
            System.Console.WriteLine();   
        }   
    }   
} 
 
PrintArrayRandomNumb();

