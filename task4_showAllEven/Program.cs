// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("введите число, и я покажу все четные числа от 1 до введенного числа");
int number = int.Parse(Console.ReadLine());
int evenNumber = 2;

while (evenNumber < number)
{
    if (evenNumber % 2 == 0)
    Console.WriteLine(evenNumber);
    evenNumber = evenNumber +2;
}