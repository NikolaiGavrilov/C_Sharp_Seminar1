//Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA != numberB && numberA != numberC && numberB != numberC)
{
    if (numberA > numberB && numberA > numberC)
    {
        Console.WriteLine("First number is MAX. " + "MAX = " + numberA);
    }
    else
    {
        if (numberA < numberB && numberB > numberC)
        {
            Console.WriteLine("Second number is MAX. " + "MAX = " + numberB);
        }
        else
        {
            Console.WriteLine("Third number is MAX. " + "MAX = " + numberC);
        }
    }
}
else
{
    if (numberA == numberB && numberA == numberC)
        {
            Console.WriteLine("First number, second number, and third number are EQUAL numbers!" + " MAX = " + numberA);
        }
    else
        if (numberA == numberB)
        {
            if (numberA > numberC && numberB > numberC)
            {
                Console.WriteLine ("First number and second number are MAX." + " MAX = " + numberA);
            }
            else
            {
                Console.WriteLine ("Third number is MAX." + " MAX = " + numberC);
            }
        }
        else
        {
            if (numberB == numberC)
            {
                if (numberC > numberA && numberB > numberA)
                {
                    Console.WriteLine ("Second number and third number are MAX." + " MAX = " + numberB);
                }
                else
                {
                    Console.WriteLine ("First number is MAX." + " MAX = " + numberA);
                }
            }
            else
                if (numberA == numberC)
                {
                    if (numberA > numberB && numberC > numberB)
                    {
                        Console.WriteLine ("First number and third number are MAX." + " MAX = " + numberA);
                    }
                    else
                    {
                        Console.WriteLine ("Second number is MAX." + " MAX = " + numberB);
                    }
                }
                else 
                {
                    if (numberA == numberB)
                    {
                        if (numberA > numberC && numberB > numberC)
                        {
                            Console.WriteLine ("First number and second number are MAX." + " MAX = " + numberA);
                        }
                        else
                        {
                            Console.WriteLine ("Third number is MAX." + " MAX = " + numberC);
                        }
                    }
                }
        }
}

