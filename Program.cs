Console.Write ("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите число B: ");
int numberB = Convert.ToInt32 (Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine ($"{numberA } больше {numberB}");
}
if (numberA == numberB)
{
    Console.WriteLine ($"{numberA } равно {numberB}");
}
else
{
    Console.WriteLine ($"{numberA } меньше {numberB}");
}
