Console.Write ("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите число B: ");
int numberB = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите число C: ");
int numberC = Convert.ToInt32 (Console.ReadLine());
if (numberA >= numberB && numberA >= numberC)
{  
    Console.WriteLine ($"{numberA } максимальное число.");
}
if (numberB >= numberA && numberB >= numberC)
{  
    Console.WriteLine ($"{numberB } максимальное число.");
}
if (numberC >= numberA && numberC >= numberB)
{  
    Console.WriteLine ($"{numberC } максимальное число.");
}
