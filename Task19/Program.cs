Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int tmp1 = num/10000;
int tmp2 = num%10;
int d = (num/10)%1000;
if (tmp1 == tmp2)
{
    if (d/100 == d%10)
    {
        Console.WriteLine($"число {num} палиндром");
    }
    else
    {
        Console.WriteLine($"число {num} не палиндром");
    }
}
else
{
    Console.WriteLine($"число {num} не палиндром");
}