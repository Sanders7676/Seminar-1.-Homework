// Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter the first number: ");

int firstnumber = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");

int secondnumber = int.Parse(Console.ReadLine());

if (firstnumber == secondnumber) Console.WriteLine("The numbers are equal");

else
{
	if (firstnumber > secondnumber) Console.Write(firstnumber + " more than " + secondnumber);
    
	else
    {
		Console.WriteLine(secondnumber  + " more than " + firstnumber);
    }
}