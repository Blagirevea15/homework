Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());
int startnumber = 2;
while (startnumber <= number)
{
    Console.Write (startnumber + ",");
    startnumber +=2;
}
Console.Write("\b.");