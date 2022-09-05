// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите число А ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число C ");
// int C = Convert.ToInt32(Console.ReadLine());
// if(A + B >C && A + C >B && C + B > A)
// {
//     Console.WriteLine("Треугольник может существовать");
// }
// else
//     Console.WriteLine("Треугольник не может существовать");

// или

// Console.WriteLine("Введите стороны треугольника(a,b,c): ");
// double number1 = Convert.ToDouble(Console.ReadLine());
// double number2 = Convert.ToDouble(Console.ReadLine());
// double number3 = Convert.ToDouble(Console.ReadLine());


// void CheckTriangle(double a,double b,double c)
// {
//     if( a < b + c && b < c + a && c < a + b)
//     {
//         Console.WriteLine("треугольник со сторонами такой длины может существовать.");
//     }
//     else
//     {
//         Console.WriteLine("такой треугольник не существует");
//     }
// }
// CheckTriangle(number1,number2,number3);


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите десятичное число");
// int number = Convert.ToInt32(Console.ReadLine());

// void TenToBinary(int n)
// {
//     string binaryNum = string.Empty;
//     while (n > 0)
//     {
//         binaryNum = n%2 + binaryNum;
//         n = n/2;
//     }
// Console.WriteLine(binaryNum);
// }
// TenToBinary(number);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число n ");
// int number = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[number];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < number-1; i++)
// {
//     array[i+1] = array[i] + array[i-1];
//     Console.Write(array[i+1]+ " ");
// }

// НЕ РАБОТАЕТ

// Console.WriteLine("Введите число n ");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;
// Console.Write(firstNum + ", ");
// Console.Write(secondNum);

// for(int i = 3; i <= num; i++)
// {
//     int newNum = firstNum + secondNum;
//     Console.Write(", " + newNum);
//     firstNum = secondNum;
//     secondNum = newNum;
// }