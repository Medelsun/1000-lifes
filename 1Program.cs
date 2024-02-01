using System;

class Program
{
    static void Main()
    {
        // 1
        Console.WriteLine("Задание №1");

        double R1, t1, l1;

        Console.WriteLine("Введите значение перременной t");
        t1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной l");
        l1 = Convert.ToDouble(Console.ReadLine());

        R1 = 3 * Math.Pow(t1, 2) + 3 * Math.Pow(l1, 5) + 4.9;

        Console.WriteLine($"Результат задания №1 = {R1}");


        // 2
        Console.WriteLine("Задание №2");

        double K2, p2, y2, e2;

        Console.WriteLine("Введите значение перременной p");
        p2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e2 = Convert.ToDouble(Console.ReadLine());

        K2 = Math.Log(Math.Pow(p2, 2) + Math.Pow(y2, 3)) + Math.Pow(e2, p2);

        Console.WriteLine($"Результат задания №2 = {K2}");


        // 3
        Console.WriteLine("Задание №3");

        double G3, n3, y3;

        Console.WriteLine("Введите значение перременной n");
        n3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y3 = Convert.ToDouble(Console.ReadLine());


        G3 = n3 * (y3 + 3.5) + Math.Sqrt(y3);

        Console.WriteLine($"Результат задания №3 = {G3}");


        // 4
        Console.WriteLine("Задание №4");

        double D4, a4, t4;

        Console.WriteLine("Введите значение перременной a");
        a4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной t");
        t4 = Convert.ToDouble(Console.ReadLine());

        D4 = 9.8 * Math.Pow(a4, 2) + 5.52 * Math.Cos(Math.Pow(t4, 5));

        Console.WriteLine($"Результат задания №4 = {D4}");


        // 5
        Console.WriteLine("Задание №5");

        double L5, x5;

        Console.WriteLine("Введите значение перременной x");
        x5 = Convert.ToDouble(Console.ReadLine());


        L5 = 1.51 * Math.Cos(Math.Pow(x5, 2)) + 2 * Math.Pow(x5, 3);

        Console.WriteLine($"Результат задания №5 = {L5}");


        // 6
        Console.WriteLine("Задание №6");

        double M6, x6, y6, e6;

        Console.WriteLine("Введите значение перременной x");
        x6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e6 = Convert.ToDouble(Console.ReadLine());

        M6 = Math.Cos(2 * y6) + 3.6 * Math.Pow(e6, x6);

        Console.WriteLine($"Результат задания №6 = {M6}");


        // 7
        Console.WriteLine("Задание №7");

        double N7, m7;

        Console.WriteLine("Введите значение перременной m");
        m7 = Convert.ToDouble(Console.ReadLine());


        N7 = Math.Pow(m7, 2) + 2.8 * Math.Abs(m7) + 0.55;

        Console.WriteLine($"Результат задания №7 = {N7}");


        // 8
        Console.WriteLine("Задание №8");

        double T8, y8;


        Console.WriteLine("Введите значение перременной y");
        y8 = Convert.ToDouble(Console.ReadLine());


        T8 = Math.Sqrt(Math.Abs(6 * Math.Pow(y8, 2) - 0.1 * y8 + 4));
        Console.WriteLine($"Результат задания №8 = {T8}");

        // 9
        Console.WriteLine("Задание №9");

        double V9, x9, y9;

        Console.WriteLine("Введите значение перременной x");
        x9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y9 = Convert.ToDouble(Console.ReadLine());

        V9 = Math.Log(y9 + 0.95) + Math.Sin(Math.Pow(x9, 4));

        Console.WriteLine($"Результат задания №9 = {V9}");


        // 10
        Console.WriteLine("Задание №10");

        double U10, x10, y10, e10, k10;

        Console.WriteLine("Введите значение перременной x");
        x10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k10 = Convert.ToDouble(Console.ReadLine());

        U10 = Math.Pow(e10, y10) + 7.355 * Math.Pow(k10, 2) + Math.Pow(Math.Sin(x10), 2);

        Console.WriteLine($"Результат задания №10 = {U10}");


        // 11
        Console.WriteLine("Задание №11");

        double S11, x11, y11;

        Console.WriteLine("Введите значение перременной x");
        x11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y11 = Convert.ToDouble(Console.ReadLine());


        S11 = 9.756 * Math.Pow(y11, 7) + 2 * Math.Tan(11);

        Console.WriteLine($"Результат задания №11 = {S11}");

        // 12
        Console.WriteLine("Задание №12");

        double K12, t12, x12;

        Console.WriteLine("Введите значение перременной x");
        x12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной t");
        t12 = Convert.ToDouble(Console.ReadLine());



        K12 = 7 * Math.Pow(t12, 2) + 3 * Math.Sin(Math.Pow(x12, 3)) + 9.2;

        Console.WriteLine($"Результат задания №12 = {K12}");



        // 13
        Console.WriteLine("Задание №13");

        double E13, y13;

        Console.WriteLine("Введите значение перременной y");
        y13 = Convert.ToDouble(Console.ReadLine());


        E13 = Math.Sqrt(Math.Abs(3 * Math.Pow(y13, 2) + 0.5 * y13 + 4));

        Console.WriteLine($"Результат задания №13 = {E13}");


        // 14
        Console.WriteLine("Задание №14");

        double R14, x14, y14, e14;

        Console.WriteLine("Введите значение перременной x");
        x14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e14 = Convert.ToDouble(Console.ReadLine());

        R14 = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y14), 2) + 6.835) + Math.Pow(e14, y14));

        Console.WriteLine($"Результат задания №14 = {R14}");


        // 15

        Console.WriteLine("Задание №15");

        double H15, y15;


        Console.WriteLine("Введите значение перременной y");
        y15 = Convert.ToDouble(Console.ReadLine());


        H15 = Math.Sin(Math.Pow(y15, 2)) - 2.8 * y15 + Math.Sqrt(Math.Abs(y15));

        Console.WriteLine($"Результат задания №15 = {H15}");


        // 16
        Console.WriteLine("Задание №16");

        double S16, y16;

        Console.WriteLine("Введите значение перременной y");
        y16 = Convert.ToDouble(Console.ReadLine());


        S16 = Math.Sqrt(Math.Cos(4 * Math.Pow(y16, 2)) + 7.151);

        Console.WriteLine($"Результат задания №16 = {S16}");


        // 17
        Console.WriteLine("Задание №17");

        double N17, y17;


        Console.WriteLine("Введите значение перременной y");
        y17 = Convert.ToDouble(Console.ReadLine());


        N17 = 3 * Math.Pow(y17, 2) + Math.Sqrt(y17 + 1);

        Console.WriteLine($"Результат задания №17 = {N17}");


        // 18
        Console.WriteLine("Задание №18");

        double Z18, y18;


        Console.WriteLine("Введите значение перременной y");
        y18 = Convert.ToDouble(Console.ReadLine());


        Z18 = 3 * Math.Pow(y18, 2) + Math.Sqrt(Math.Pow(y18, 3) + 1);

        Console.WriteLine($"Результат задания №18 = {Z18}");


        // 19
        Console.WriteLine("Задание №19");

        double P19, g19, y19, n19;

        Console.WriteLine("Введите значение перременной g");
        g19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной n");
        n19 = Convert.ToDouble(Console.ReadLine());


        P19 = n19 * Math.Sqrt(Math.Pow(y19, 3) + 1.09 * g19);

        Console.WriteLine($"Результат задания №19 = {P19}");


        // 20
        Console.WriteLine("Задание №20");

        double U20, x20, y20, e20, k20;

        Console.WriteLine("Введите значение перременной x");
        x20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k20 = Convert.ToDouble(Console.ReadLine());

        U20 = Math.Pow(e20, k20 + y20) + Math.Tan(x20) * Math.Sqrt(x20);

        Console.WriteLine($"Результат задания №20 = {U20}");


        // 21
        Console.WriteLine("Задание №21");

        double P21, e21, y21, h21;

        Console.WriteLine("Введите значение перременной e");
        e21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной h");
        h21 = Convert.ToDouble(Console.ReadLine());


        P21 = Math.Pow(e21, y21 + 3.3) + 9.1 * Math.Pow(h21, 3);

        Console.WriteLine($"Результат задания №21 = {P21}");


        // 22
        Console.WriteLine("Задание №22");

        double T22, x22, y22, u22;

        Console.WriteLine("Введите значение перременной x");
        x22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной u");
        u22 = Convert.ToDouble(Console.ReadLine());

        T22 = Math.Sin(2 * u22) * Math.Log(2 * Math.Pow(y22, 2) + Math.Sqrt(x22));

        Console.WriteLine($"Результат задания №22 = {T22}");


        // 23
        Console.WriteLine("Задание №23");

        double G23, f23, y23, e23;

        Console.WriteLine("Введите значение перременной f");
        f23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e23 = Convert.ToDouble(Console.ReadLine());


        G23 = Math.Pow(e23, 2 * y23) + Math.Sin(f23);

        Console.WriteLine($"Результат задания №23 = {G23}");


        // 24
        Console.WriteLine("Задание №24");

        double F24, y24;

        Console.WriteLine("Введите значение перременной y");
        y24 = Convert.ToDouble(Console.ReadLine());



        F24 = 2 * Math.Sin(0.214 * Math.Pow(y24, 5) + 1);

        Console.WriteLine($"Результат задания №24 = {F24}");


        // 25
        Console.WriteLine("Задание №25");

        double G25, y25, f25, e25;

        Console.WriteLine("Введите значение перременной y");
        y25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной f");
        f25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e25 = Convert.ToDouble(Console.ReadLine());

        G25 = Math.Pow(e25, 2 * y25) + Math.Sin(Math.Pow(f25, 2));

        Console.WriteLine($"Результат задания №25 = {G25}");


        // 26
        Console.WriteLine("Задание №26");

        double Z26, p26;

        Console.WriteLine("Введите значение перременной p");
        p26 = Convert.ToDouble(Console.ReadLine());


        Z26 = Math.Sin(Math.Pow(Math.Pow(p26, 2) + 0.4, 3));

        Console.WriteLine($"Результат задания №26 = {Z26}");


        // 27
        Console.WriteLine("Задание №27");

        double W27, x27, y27, e27, v27;

        Console.WriteLine("Введите значение перременной x");
        x27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной v");
        v27 = Convert.ToDouble(Console.ReadLine());

        W27 = 1.03 * v27 + Math.Pow(e27, 2 * y27) + Math.Tan(Math.Abs(x27));


        Console.WriteLine($"Результат задания №27 = {W27}");


        // 28
        Console.WriteLine("Задание №28");

        double T28, e28, y28, h28;

        Console.WriteLine("Введите значение перременной y");
        y28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной h");
        h28 = Convert.ToDouble(Console.ReadLine());

        T28 = Math.Pow(e28, y28 * h28) + Math.Sqrt(Math.Abs(6.4 * y28));

        Console.WriteLine($"Результат задания №28 = {T28}");


        // 29
        Console.WriteLine("Задание №29");

        double N29, y29;

        Console.WriteLine("Введите значение перременной y");
        y29 = Convert.ToDouble(Console.ReadLine());


        N29 = 3 * Math.Pow(y29, 2) + Math.Sqrt(Math.Abs(y29 + 1));

        Console.WriteLine($"Результат задания №29 = {N29}");


        // 30
        Console.WriteLine("Задание №30");

        double W30, r30, y30, e30;

        Console.WriteLine("Введите значение перременной r");
        r30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e30 = Convert.ToDouble(Console.ReadLine());


        W30 = Math.Pow(e30, y30 * r30) + 7.2 * Math.Sin(r30);

        Console.WriteLine($"Результат задания №30 = {W30}");

    }
}
   