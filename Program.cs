//задайте число N и выведите натуральные значения от N до 1 с помощью рекурсии
Console.WriteLine("Введите целое положительное число N:");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 1;
void Vivod (int m,int m1)
{
    if (m > m1) return;
    Vivod (m+1,m1);
    Console.WriteLine($"{m}");
}
Vivod (n1,n);
