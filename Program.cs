using System;

class Program
{
    static void Main()
    {
        double R, t, l;

        Console.WriteLine("Задание 1");

        Console.WriteLine("Введите значение переменной t:");
        t = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной l:");
        l = Convert.ToDouble(Console.ReadLine());

        R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9;

        Console.WriteLine($"Значение R = {R}");


        Console.WriteLine("Задание 2");

        double K, p, y;

        Console.WriteLine("Введите значение переменной p:");
        p = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной y:");
        y = Convert.ToDouble(Console.ReadLine());

        K = Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3)) + Math.Exp(p);

        Console.WriteLine($"Значение K = {K}");


        Console.WriteLine("задание 3");
        double G, n, Y;

        Console.WriteLine("Введите значение переменной n");
        n = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y");
        Y = Convert.ToDouble(Console.ReadLine());

        G = n + (y + 3.5) + Math.Sqrt(y);

        Console.WriteLine($"Значение G = {G}");


        Console.WriteLine("задание 4");
        double D, a, s;

        Console.WriteLine("Введите значение переменной а");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("d");
        s = Convert.ToDouble(Console.ReadLine());

        D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(s, 5));

        Console.WriteLine($"Значение D = {D}");

        Console.WriteLine("Задание 5");
        double L, x;

        Console.WriteLine("Введите значение переменной x:");
        x = Convert.ToDouble(Console.ReadLine());

        L = 1.51 * Math.Pow(Math.Cos(x), 2) + 2 * Math.Pow(x, 3);

        Console.WriteLine($"Значение L = {L}");

        Console.WriteLine("Задание 6");
        double M, Q, W;

        Console.WriteLine("Введите значение переменной Q:");
        Q = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной W:");
        W = Convert.ToDouble(Console.ReadLine());

        M = Math.Cos(2 * y) + 3.6 * Math.Exp(x);

        Console.WriteLine($"Значение M = {M}");

        Console.WriteLine("Задание 7");
        double N, m;

        Console.WriteLine("Введите значение переменной m:");
        m = Convert.ToDouble(Console.ReadLine());

        N = Math.Pow(m, 2) - 2.8 * Math.Abs(m) - 0.55;

        Console.WriteLine($"Значение N = {N}");
    }
}