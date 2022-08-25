// Console.WriteLine("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// if(x>0&&y>0)
// {
//     Console.WriteLine("1");
// }
// if(x>0&&y>0)
// {
//     Console.WriteLine("2");
// }
// if(x>0&&y>0)
// {
//     Console.WriteLine("3");
// }
// if(x>0&&y>0)
// {
//     Console.WriteLine("4");
// }
// if(x>0||y>0)
// {
//     Console.WriteLine("Определить нельзя");
// }


// Console.WriteLine("Введите номер четверти");
// int q = Convert.ToInt32(Console.ReadLine());

// if (q > 4 || q < 1)
// {
//     Console.WriteLine("Ошибка");
// }

// if(q == 1)
// {
//     Console.WriteLine("x > 0, Y > 0");
// }
// if(q == 2)
// {
//     Console.WriteLine("x < 0, Y > 0");
// }
// if(q == 3)
// {
//     Console.WriteLine("x < 0, Y < 0");
// }
// if(q == 4)
// {
//     Console.WriteLine("x > 0, Y > 0");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// int katet1 = (x1 -x2);
// int katet2 = (y1 -y2);
// double result = Math.Sqrt(katet1*katet1 + katet2*katet2);
// Console.WriteLine(result);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while(count<=N)
// {
//     Console.WriteLine(Math.Pow(A,2));
//     count++;
// }

for (int count = 1; count<=N; count++) {
	double result = Math.Pow(count, 2);
	Console.WriteLine(result);
}

