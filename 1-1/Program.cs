// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int max = 0;
int min = 0;

Console.Write("Первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);