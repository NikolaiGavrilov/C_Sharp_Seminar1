//Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.WriteLine("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA != numberB)
{
    if (numberA > numberB)
    {
        Console.WriteLine(numberA + " is BIGGER than " + numberB);
        Console.WriteLine("First number is MAX and second number is MIN");
    }
    else
    {
       Console.WriteLine(numberB + " is BIGGER than " + numberA);
       Console.WriteLine("Second number is MAX and first number is MIN");
    }
}
else
{
    Console.WriteLine(numberA + " is equal to " + numberB);
    Console.WriteLine("First number and second number are EQUAL numbers!");
}