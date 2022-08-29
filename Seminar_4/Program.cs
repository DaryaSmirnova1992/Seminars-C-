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



int[] array = new int[8];

// заполняем массив
void FillArray(int[] collection) {
	int length = collection.Length;
	int index = 0;
	while (index < length) {
		collection[index] = new Random().Next(0, 2);
		index++;
	}
}

// выводим массив
void PrintArray(int[] col) {
	int count = col.Length;
	int position = 0;
	while (position < count) {
		Console.Write(col[position] + ",");
		position++;
	}
}

FillArray(array);
PrintArray(array);
