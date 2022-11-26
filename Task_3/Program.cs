// Задача 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Enter the number: "); 

int number = int.Parse(Console.ReadLine());

int even = number % 2;

if (even == 0) Console.WriteLine("This number is even!");

else
{
	Console.WriteLine("This number is odd!");
}