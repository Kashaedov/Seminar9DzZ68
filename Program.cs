Console.WriteLine("Введите два неотрицательных числа:");
Console.Write("Введите число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());
int Akerman( int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akerman(m - 1, Akerman(m, n - 1));
    else return n + 1;
}
Console.WriteLine ($"Функция Аккермана равна {Akerman(m, n)}");
