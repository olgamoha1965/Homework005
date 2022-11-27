//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, maxVal);
    }
    return newArray;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountHon(int [] array)
{
    int count= 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Input size of array: ");
int size_array = Convert.ToInt32(Console.ReadLine());

int [] createdArray = CreateRandomArray(size_array, 100, 1000);
ShowArray(createdArray);

int res = CountHon(createdArray); 
Console.WriteLine($"Number of even numbers in the array is {res}.");
*/


//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray [i] = new Random().Next(minValue, maxValue + 1);
    } 
    return newArray;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

/*int SumOdd(int [] array)  //Первый метод
{
    int summ = 0;
      
    for(int i = 1; i < array.Length; i += 2)
    {
        summ = summ + array[i];
    }   
    return summ;
}
*/

/*int SumOdd1(int [] array) //Другой метод
{
    int summ = 0;
    int i = 0;   
    while(i < array.Length)
    {
        int current = i % 2;
        if(current == 1)
            summ = summ + array[i];
        i++;
    }   
    return summ;
}
*/

/*Console.WriteLine("Input size of array: ");
int size_array = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value of element: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value of element: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [] createdArray = CreateRandomArray(size_array, minVal, maxVal);
ShowArray(createdArray);

//int res = SumOdd(createdArray); // Вызываем первый метод
int res = SumOdd1(createdArray);  // Вызываем другой метод
Console.WriteLine($"Sum of array elements with odd indices is {res}.");
*/


//Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] CreateRandomArray(int size, int minValue, int maxValue)
{
    double [] newArray = new double [size];
    for(int i = 0; i < size; i++)
    {
        newArray [i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    } 
    return newArray;
}

void ShowArray(double [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 3) + "  ");
    Console.WriteLine();
}

double MinValue(double [] array)
{
    int i = 0;   
    double min = array[0];
    while(i < array.Length)
    {
        if(array[i] < min)
            min = array[i];
    i++;
    }
    return min;
}
 
double MaxValue(double [] array)
{
    int i = 0;   
    double max = array[0];
    while(i < array.Length)
    {
        if(array[i] > max)
            max = array[i];
    i++;
    }
    return max;
}

Console.WriteLine("Input size of array: ");
int size_array = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value of element: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value of element: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double [] createdArray = CreateRandomArray(size_array, minVal, maxVal);
ShowArray(createdArray);

double minValue = MinValue(createdArray); 
Console.WriteLine("Min is " + Math.Round(minValue, 3));

double maxValue = MaxValue(createdArray);
Console.WriteLine("Max is " + Math.Round(maxValue, 3));

double dif = 0;
if(minValue >= 0 && maxValue >= 0)

    dif = maxValue - minValue;

else
{
if(minValue <= 0 && maxValue >= 0)

    dif = maxValue - minValue;

if(minValue <= 0 && maxValue <= 0)
        
    dif = minValue - maxValue;
}
Console.WriteLine("Difference between max and min is " + Math.Round(dif, 3));


