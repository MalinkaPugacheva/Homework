
/*

// Задача 1. Найти квадрат.

Console.Write("Input integer number");
int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;

Console.WriteLine($"Quad of {number} is {kvadrat}");

*/
// Задача 3. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

/*
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine($"{num1} is a quod of {num2}");
}
else
{
    Console.WriteLine($"{num1} is not a quad of {num2}");
}
*/

// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа
/*
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнее число.
/*
Console.Write("Input three-digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.WriteLine($"Last digit of {num} is {result}");
*/

