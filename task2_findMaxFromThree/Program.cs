// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа и я скажу, какое из них наибольшее");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberС = int.Parse(Console.ReadLine());

int max = numberA;
if (numberB > max) max = numberB;
if (numberС > max) max = numberС;

Console.WriteLine($"среди этих двух чисел наибольшим является {max}");