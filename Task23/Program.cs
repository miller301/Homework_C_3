Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
PrintSqr(n);

void PrintSqr(int a)
{
for (int i = 1; i <= a; i++)
{
    System.Console.Write($"{i*i*i} ");
}
}