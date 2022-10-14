using System;
internal class Program
{
    static void Main(string[] args)
    {
        int q = 0;
        while (q < 1)
        {
            Console.WriteLine("Выберите одну из трех программ:\n" +
                "1)-Угадай число\n" +
                "2)-Таблица Умножения\n" +
                "3)-Делители числа\n" +
                "4)-Закончить работу программы");
            int nomer = Convert.ToInt32(Console.ReadLine());
            if (nomer == 1)
            {
                chislo();
            }
            if (nomer == 2)
            {
                tabl();
            }
            if (nomer == 3)
            {
                delitel();
            }
            if (nomer == 4)
            {
                break;
            }
        }
    }
    static void chislo()
    {
     Random ran = new Random();
        int a = ran.Next(0, 100);
        Console.WriteLine("Угадайте число от 0 до 100.");
        int b = Convert.ToInt32(Console.ReadLine());
        while (b != a)
        {
            b = Convert.ToInt32(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine("Много");
            }
            else if (b < a)
            {
                Console.WriteLine("Мало");
            }
        }
        Console.WriteLine("Угадал.");
    }
    static void tabl()
    {
        int[,] tabl = new int[10, 10];
        for (int x = 1; x < 10; x++)
            for (int y = 1; y < 10; y++)
                tabl[x, y] = x * y;
        for (int x = 1; x < 10; x++)
        {
            for (int y = 1; y < 10; y++)
                Console.Write("{0,6}", tabl[x, y]);
            Console.WriteLine();
        }
    }
    static void delitel()
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Делится на:");
        for (int i = 1; i <= a; i++)
            if (a % i == 0)
            {
                Console.WriteLine(i);
            }
    }
}