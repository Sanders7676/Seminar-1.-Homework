//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter the first number: ");

int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine(firstNumber);

Console.Write("Enter the second number: ");

int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine(secondNumber);

Console.Write("Enter the third number ");

int thirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine(thirdNumber);

int max = firstNumber;

if (secondNumber > firstNumber) 
{
	max = secondNumber;
}
else
{
	if(thirdNumber > max)
	{
		max = thirdNumber;
	}
}
Console.Write("The maximum number is ");
Console.Write(max);