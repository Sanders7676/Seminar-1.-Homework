// Задача 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter the number: ");

int num = int.Parse(Console.ReadLine());

int ev = 2;

while (ev <= num)
{
	Console.Write(ev);
    Console.Write(", ");
	ev+=2;
}