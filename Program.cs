//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//1. задать 3 значность
//2. задать положительность
//3. рандомно заполнить массив 
//4. Функция которая покажет количество четных чисел в массиве


/*
int [] CreateRandomArray(int size, int minVal, int maxVal)  //создала рандомный массив
{
    int [] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int [] array1)  //вывести массив
{
    for(int i = 0; i < array1.Length; i++)
       Console.Write(array1[i] + " ");
    Console.WriteLine();
}

void EvenNumberFinder (int [] arrayForEven)
{
    int count = 0;
    for(int i = 0; i < arrayForEven.Length; i++)
       if (arrayForEven [i] % 2 == 0)     //проверка на четность
           {
               count += 1;
               Console.WriteLine($"Even-numbered elements are: {count}");
           }
        
}

int sizeArray = 4;
int minValue = 100;
int maxValue = 999;

int [] createdArray = CreateRandomArray(sizeArray, minValue, maxValue);
ShowArray(createdArray);
EvenNumberFinder(createdArray);
*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. (1,3)
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*

int [] CreateRandomArray (int size, int minVal, int maxVal)  //создала рандомный массив со случайными числами
{
    int [] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray(int [] array1)  //вывести массив
{
    for(int i = 0; i < array1.Length; i++)
       Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int FindSumNotEvenNum (int [] array1)  //поиск суммы чисел на нечетных позициях
{
    int notEvenNum = 0;
    for(int i = 0; i < array1.Length; i = i + 2)
       if(array1[i] % 2 != 0)
         sum += array1[i];
    return notEvenNum;
}

int sizeArray = 4;
int minArray = -99;
int maxArray = 99;

int [] newArray = CreateRandomArray (int sizeArray, int minArray, int maxArray);
ShowArray(newArray);
int [] createdArray = FindSumNotEvenNum(newArray);
ShowArray(createdArray);
Console.WriteLine($"The sum of not even-numbered elements are {FindSumNotEvenNum(createdArray)}");
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int [] CreateRandomArray (int size, int minVal, int maxVal)  
{
    int [] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void PrintArray(int [] array1)  
{
    for(int i = 0; i < array1.Length; i++)
       Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int DifferenceFinder (int [] array)
{
    int result;
    int minElem = 0;
    int maxElem = 1;
    for(int i = 0; i < array.Length; i++)
    {
        result = array[maxElem] - array[minElem];
        if(array[i] > array[maxElem])
           array[i] = array[maxElem];
        else if(array[i] < array[minElem])
           array[i] = array[minElem];
        else 
           return array[i];
    }
    return array;
}

int sizeArray = 5;
int minValue = 0;
int maxValue = 99;

int [] createdArr = CreateRandomArray(sizeArray, minValue, maxValue);
PrintArray(createdArr);
int [] newArray = DifferenceFinder(createdArr);
PrintArray(newArray);
Console.WriteLine($"Difference between max and min is: {newArray}");

*/