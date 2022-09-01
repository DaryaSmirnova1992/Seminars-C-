// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Количество цифр в числе: "+ GetCount(num) );

// int GetCount(int number)
// {
//  int count =0;
//  while(number>0)
//  {
// 		count++;
// 		number/=10;
//  }
// 	return count;

// }


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + " -> " + GetSum(num));

// int GetSum(int number)
// {
//     int pr = 1;
//     int count = 0;
//     while (number > count)
//     {
//         count++;
//         pr *= count;
//     }
//     return pr;
// }

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = GetArray(8);
// Console.WriteLine(string.Join(",",array));

// int [] GetArray(int size)
// {
//         int [] result = new int [size];
//         for(int i=0; i< size; i++)
//         {
//             result[i] = new Random().Next(0,2);
//         }
//         return result;
// }



// int[] array = new int[8];

// // заполняем массив
// void FillArray(int[] collection) {
// 	int length = collection.Length;
// 	int index = 0;
// 	while (index < length) {
// 		collection[index] = new Random().Next(0, 2);
// 		index++;
// 	}
// }

// // выводим массив
// void PrintArray(int[] col) {
// 	int count = col.Length;
// 	int position = 0;
// 	while (position < count) {
// 		Console.Write(col[position] + ",");
// 		position++;
// 	}
// }

// FillArray(array);
// PrintArray(array);




// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] array= new int [12];
// int size= array.Length;

// int positiveSum=0;
// int negativeSum=0;

// for(int i=0;i<size; i++)
// {
//     array[i]=new Random().Next(-9,10);

//     if(array[i]>0)
//     {
//         positiveSum+=array[i];

//     }
//     else
//     {
//         negativeSum+=array[i];

//     }

// }
// Console.WriteLine("Сумма положительных чисел = "+ positiveSum+" | Сумма отрицательных чисел"+negativeSum);
// Console.WriteLine(String.Join(";",array));



// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int [] inputArray= {1,2,3,4,5};

// int [] resultArray= new int[inputArray.Length/2 + inputArray.Length%2];

// for(int i=0;i<resultArray.Length;i++)
// {
// 	resultArray[i]= inputArray[i]*inputArray[inputArray.Length-1-i];

// 	if(i==inputArray.Length-1-i)
// 	{
// 		resultArray[i]=inputArray[i];
// 	}
// }
// Console.WriteLine("[{0}]", String.Join(";",resultArray));

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] array= {-4, -8, 8, 2};
// for(int i=0; i < array.Length; i++)
// {
// 	array[i]*=-1;
// }

// Console.WriteLine("[{0}]", String.Join(",", array));


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = "нет";
// int [] array= {6, 7, 19, 345, 3};
// for(int i=0; i < array.Length; i++)
// {
// 	if(array[i]== num)
// 	{
// 		result = "да";
// 	}
	
// }
// Console.WriteLine(result);