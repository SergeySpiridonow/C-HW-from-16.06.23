/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();
// int Length = number.Length;

// if (Length == 5)
// {
//     if(number[0] == number [4] && number [1] == number [3])
//      Console.WriteLine("Введённое число является палиндромом ");
//     else
//     Console.WriteLine("Введённое число не является палиндромом");
// }
// else
// {
//     Console.WriteLine("Введённое число не является пятизначным, повторите ввод ");
// }




// /*
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// */

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// double Distanse(int xa, int ya, int za, int xb, int yb, int zb)
// {
//     int delayx = xb - xa;
//     int delayy = yb - ya;
//     int delayz = za - zb;
//     return Math.Sqrt(Math.Pow((delayx), 2) + Math.Pow((delayy), 2) + Math.Pow((delayz), 2));
// }

// int xa = InputNum("Введите координату хa: ");
// int ya = InputNum("Введите координату ya: ");
// int za = InputNum("Введите координату za: ");
// int xb = InputNum("Введите координату xb: ");
// int yb = InputNum("Введите координату yb: ");
// int zb = InputNum("Введите координату zb: ");

// double res = Distanse(xa, ya, za, xb, yb, zb);
// Console.WriteLine($"Расстояние равно {Distanse(xa, ya, za, xb, yb, zb)}");


/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }
// int num = InputNum("Введите целое число");
// for (int i = 1; i <= num; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)} ");
//     if (i < num)
//     {
//         Console.Write(",");
//     }
//     else
//     {
//         Console.Write(".");
//     }
// }