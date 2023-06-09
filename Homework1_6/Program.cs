//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter your number: ");
int yourNumber = Convert.ToInt32(Console.ReadLine());

if (yourNumber % 2 != 0)
{
    Console.WriteLine(yourNumber + " is ODD/НЕЧЕТНОЕ");
}
else
{
    Console.WriteLine(yourNumber + " is EVEN/ЧЕТНОЕ");
}