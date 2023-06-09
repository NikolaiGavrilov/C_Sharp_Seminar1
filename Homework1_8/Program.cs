// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter any number: ");
int yourNumber = Convert.ToInt32(Console.ReadLine());

int initialNumber = 1;
int firstEvenNumber = 2;

if (yourNumber > initialNumber)
{
    if (yourNumber % 2 == 0)
    {
        while (firstEvenNumber < yourNumber)
        {
          Console.Write(firstEvenNumber + ", ");
          firstEvenNumber = firstEvenNumber + 2;
        }
        Console.Write(yourNumber);
    }
    else
        while (firstEvenNumber < yourNumber)
        {
          Console.Write(firstEvenNumber + ", ");
          firstEvenNumber = firstEvenNumber + 2;
        }
}
else
{
    if (yourNumber != 0)
    {
        Console.WriteLine("You have a NEGATIVE number. It DOESN'T BELONG to natural numbers! ");
        Console.Write("Try again with another number and MAKE SURE THAT YOUR NEW NUMBER IS NATURAL.");   
    }
    else
    {
        Console.Write("0");
    }
}