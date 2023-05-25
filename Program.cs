//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
        if (arrayForEven[i] > 99 && arrayForEven[i] < 1000)   //задаю трехзнычные числа и проверяю
            count ++;
        if (arrayForEven.Length % 2 == 0)     //проверка на четность
            Console.WriteLine($"Even-numbered elements are: {count}");
        else
            Console.WriteLine("There are not even-numbered elements!");
   
}

int sizeArray = 4;
int minValue = 100;
int maxValue = 999;

int [] createdArray = CreateRandomArray(sizeArray, minValue, maxValue);
ShowArray(createdArray);
EvenNumberFinder(createdArray);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0






//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76




