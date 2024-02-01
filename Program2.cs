
using System;

class Program
{
    static void Main()
    {
        // 1
        Console.WriteLine("Задание №1");

        double G1, f1, y1, e1;

        Console.WriteLine("Введите значение перременной f");
        f1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e1 = Convert.ToDouble(Console.ReadLine());

        G1 = (Math.Pow(e1, 2 * y1) + Math.Sin(f1)) / (Math.Log(3.8 * y1 + f1));

        Console.WriteLine($"Результат задания №1 = {G1}");


        // 2
        Console.WriteLine("Задание №2");

        double F2, d2, y2;

        Console.WriteLine("Введите значение перременной d");
        d2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y2 = Convert.ToDouble(Console.ReadLine());


        F2 = Math.Log(d2) * ((3.5 * Math.Pow(d2, 2) + 1) / (Math.Cos(2) * y2));

        Console.WriteLine($"Результат задания №2 = {F2}");


        // 3
        Console.WriteLine("Задание №3");

        double U3, y3, e3, k3;

        Console.WriteLine("Введите значение перременной y");
        y3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k3 = Convert.ToDouble(Console.ReadLine());

        U3 = (Math.Log(k3 - y3) + Math.Pow(y3, 4)) / (Math.Pow(e3, y3) + 2.355 * Math.Pow(k3, 2));

        Console.WriteLine($"Результат задания №3 = {U3}");


        // 4
        Console.WriteLine("Задание №4");

        double G4, w4, y4;

        Console.WriteLine("Введите значение перременной w");
        w4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y4 = Convert.ToDouble(Console.ReadLine());

        G4 = (9.33 * Math.Pow(w4, 3) + Math.Sqrt(w4)) / (Math.Log(y4 + 3.5) + Math.Sqrt(y4));

        Console.WriteLine($"Результат задания №4 = {G4}");


        // 5
        Console.WriteLine("Задание №5");

        double D5, t5, y5, e5, a5;

        Console.WriteLine("Введите значение перременной t");
        t5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a5 = Convert.ToDouble(Console.ReadLine());

        D5 = (7.8 * Math.Pow(a5, 2) + 3.52 * t5) / (Math.Log(a5 + 2 * y5) + Math.Pow(e5, y5));

        Console.WriteLine($"Результат задания №5 = {D5}");


        // 6
        Console.WriteLine("Задание №6");

        double L6, i6, y6;

        Console.WriteLine("Введите значение перременной i");
        i6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y6 = Convert.ToDouble(Console.ReadLine());



        L6 = (0.81 * Math.Cos(i6)) / (Math.Log(y6) + 2 * Math.Pow(i6, 3));

        Console.WriteLine($"Результат задания №6 = {L6}");


        // 7
        Console.WriteLine("Задание №7");

        double N7, m7, y7;

        Console.WriteLine("Введите значение перременной m");
        m7 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y7 = Convert.ToDouble(Console.ReadLine());


        N7 = (Math.Pow(m7, 2) + 2.8 * m7 + 0.355) / (Math.Cos(2) * y7 + 3.6);

        Console.WriteLine($"Результат задания №7 = {N7}");


        // 8
        Console.WriteLine("Задание №8");

        double T8, r8, y8;

        Console.WriteLine("Введите значение перременной r");
        r8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y8 = Convert.ToDouble(Console.ReadLine());


        T8 = (2.37 * Math.Sin(r8 + 1)) / (Math.Sqrt(4 * Math.Pow(y8, 2) - 0.1 * y8 + 5));

        Console.WriteLine($"Результат задания №8 = {T8}");


        // 9
        Console.WriteLine("Задание №9");

        double V9, w9, y9;

        Console.WriteLine("Введите значение перременной w");
        w9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y9 = Convert.ToDouble(Console.ReadLine());


        V9 = Math.Pow((y9 + 2 * w9), 3) / (Math.Log(y9 + 0.75));

        Console.WriteLine($"Результат задания №9 = {V9}");


        // 10
        Console.WriteLine("Задание №10");

        double Z10, t10, y10;

        Console.WriteLine("Введите значение перременной t");
        t10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y10 = Convert.ToDouble(Console.ReadLine());


        Z10 = (2 * y10 + y10 * Math.Cos(t10)) / (Math.Sqrt(y10 + 4.831));

        Console.WriteLine($"Результат задания №10 = {Z10}");


        // 11
        Console.WriteLine("Задание №11");

        double D11, n11, y11;

        Console.WriteLine("Введите значение перременной n");
        n11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y11 = Convert.ToDouble(Console.ReadLine());


        D11 = Math.Pow(y11, 2) * ((0.5 * n11 + 4.8) / (Math.Sin(y11)));

        Console.WriteLine($"Результат задания №11 = {D11}");


        // 12
        Console.WriteLine("Задание №12");

        double R12, r12, y12;

        Console.WriteLine("Введите значение перременной r");
        r12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y12 = Convert.ToDouble(Console.ReadLine());


        R12 = (Math.Pow((Math.Sin(2 * r12 + 1)), 2) + 0.3) / (Math.Log(r12 + y12));

        Console.WriteLine($"Результат задания №12 = {R12}");


        // 13
        Console.WriteLine("Задание №13");

        double A13, h13, y13, e13, k13;

        Console.WriteLine("Введите значение перременной h");
        h13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной k");
        k13 = Convert.ToDouble(Console.ReadLine());

        A13 = (Math.Sin(2 * y13 + h13) + Math.Pow(h13, 2)) / (Math.Pow(e13, k13) + y13);

        Console.WriteLine($"Результат задания №13 = {A13}");


        // 14
        Console.WriteLine("Задание №14");

        double P14, h14, y14, e14;

        Console.WriteLine("Введите значение перременной h");
        h14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y14 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e14 = Convert.ToDouble(Console.ReadLine());


        P14 = (Math.Pow(e14, y14 + 2.3) + 7.1 * Math.Pow(h14, 2)) / (Math.Log(Math.Sqrt(y14 + 0.04 * h14)));

        Console.WriteLine($"Результат задания №14 = {P14}");


        // 15
        Console.WriteLine("Задание №15");

        double F15, j15, y15;

        Console.WriteLine("Введите значение перременной j");
        j15 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y15 = Convert.ToDouble(Console.ReadLine());

        F15 = (2 * Math.Sin(0.354 * y15 + 1)) / (Math.Log(y15 + 2 * j15));

        Console.WriteLine($"Результат задания №15 = {F15}");


        // 16
        Console.WriteLine("Задание №16");

        double W16, t16, y16, e16, r16;

        Console.WriteLine("Введите значение перременной t");
        t16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной r");
        r16 = Convert.ToDouble(Console.ReadLine());

        W16 = (4 * Math.Pow(r16, 3) + Math.Log(r16)) / (Math.Pow(e16, y16 + r16) + 7.2 * Math.Sin(r16));

        Console.WriteLine($"Результат задания №16 = {W16}");


        // 17
        Console.WriteLine("Задание №17");

        double H17, n17, y17;

        Console.WriteLine("Введите значение перременной n");
        n17 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y17 = Convert.ToDouble(Console.ReadLine());


        H17 = (Math.Pow(y17, 2) - 0.8 * y17 + Math.Sqrt(y17)) / (23.1 * Math.Pow(n17, 2) + Math.Cos(n17));

        Console.WriteLine($"Результат задания №17 = {H17}");


        // 18
        Console.WriteLine("Задание №18");

        double R18, k18, y18;

        Console.WriteLine("Введите значение перременной k");
        k18 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y18 = Convert.ToDouble(Console.ReadLine());


        R18 = (Math.Sqrt(Math.Pow((Math.Sin(y18)), 2)) + 6.835) / (Math.Log(y18 + k18) + 3 * Math.Pow(y18, 2));

        Console.WriteLine($"Результат задания №18 = {R18}");


        //19
        Console.WriteLine("Задание №19");

        double E19, q19, y19;

        Console.WriteLine("Введите значение перременной ");
        q19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y19 = Convert.ToDouble(Console.ReadLine());


        E19 = (Math.Log(0.7 * y19 + 2 * q19)) / (Math.Sqrt(3 * Math.Pow(y19, 2) + 0.5 * y19 + 4));

        Console.WriteLine($"Результат задания №19 = {E19}");


        // 20
        Console.WriteLine("Задание №20");

        double K20, t20, y20, e20, l20;

        Console.WriteLine("Введите значение перременной t");
        t20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной l");
        l20 = Convert.ToDouble(Console.ReadLine());

        K20 = (2 * Math.Pow(t20, 2) + 3 * l20 + 7.2) / (Math.Log(y20) + Math.Pow(e20, 2 * t20));

        Console.WriteLine($"Результат задания №20 = {K20}");


        // 21
        Console.WriteLine("Задание №21");

        double Q21, k21, p21, x21, d21;

        Console.WriteLine("Введите значение перременной k");
        k21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной p");
        p21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной l");
        d21 = Convert.ToDouble(Console.ReadLine());

        Q21 = (Math.Sqrt(k21 + 2.6 * p21 * Math.Sin(k21))) / (x21 - Math.Pow(d21, 3));

        Console.WriteLine($"Результат задания №21 = {Q21}");


        // 22
        Console.WriteLine("Задание №22");

        double S22, t22, y22;

        Console.WriteLine("Введите значение перременной t");
        t22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y22 = Convert.ToDouble(Console.ReadLine());

        S22 = (4.351 * Math.Pow(y22, 3) + 2) * t22 * Math.Log(t22) / (Math.Sqrt(Math.Cos(2) * y22 + 4.351));

        Console.WriteLine($"Результат задания №22 = {S22}");


        // 23
        Console.WriteLine("Задание №23");

        double R23, d23, y23, e23;

        Console.WriteLine("Введите значение перременной d");
        d23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e23 = Convert.ToDouble(Console.ReadLine());


        R23 = (Math.Pow((Math.Sin(y23)), 2) + 0.3 * d23) / (Math.Pow(e23, y23) + Math.Log(d23));

        Console.WriteLine($"Результат задания №23 = {R23}");


        // 24
        Console.WriteLine("Задание №24");

        double U24, k24, y24, e24;

        Console.WriteLine("Введите значение перременной k");
        k24 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y24 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e24 = Convert.ToDouble(Console.ReadLine());


        U24 = (Math.Log(2 * k24 + 4.3)) / (Math.Pow(e24, k24 + y24) + Math.Sqrt(y24));

        Console.WriteLine($"Результат задания №24 = {U24}");


        // 25
        Console.WriteLine("Задание №25");

        double L25, t25, c25;

        Console.WriteLine("Введите значение перременной t");
        t25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c25 = Convert.ToDouble(Console.ReadLine());


        L25 = Math.Pow((Math.Cos(c25)), 2) * ((3 * Math.Pow(t25, 2) + 4) / (Math.Sqrt(c25 + t25)));

        Console.WriteLine($"Результат задания №25 = {L25}");


        // 26
        Console.WriteLine("Задание №26");

        double T26, u26, y26;

        Console.WriteLine("Введите значение перременной u");
        u26 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y26 = Convert.ToDouble(Console.ReadLine());


        T26 = (Math.Sin(2) * u26) / (Math.Log(2 * y26 + u26));

        Console.WriteLine($"Результат задания №26 = {T26}");


        // 27
        Console.WriteLine("Задание №27");

        double Z27, p27, y27;

        Console.WriteLine("Введите значение перременной P");
        p27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y27 = Convert.ToDouble(Console.ReadLine());

        Z27 = (Math.Sin(Math.Pow((p27 + 0.4), 2))) / (Math.Pow(y27, 2) + 7.325 * p27);

        Console.WriteLine($"Результат задания №27 = {Z27}");


        // 28
        Console.WriteLine("Задание №28");

        double W28, v28, y28, e28;

        Console.WriteLine("Введите значение перременной v");
        v28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e28 = Convert.ToDouble(Console.ReadLine());


        W28 = (0.004 * v28 + Math.Pow(e28, 2 * y28)) / (Math.Pow(e28, y28 / 2));

        Console.WriteLine($"Результат задания №28 = {W28}");


        // 29
        Console.WriteLine("Задание №29");

        double T29, h29, y29, e29;

        Console.WriteLine("Введите значение перременной h");
        h29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e29 = Convert.ToDouble(Console.ReadLine());

        T29 = (0.355 * Math.Pow(h29, 2) - 4.355) / (Math.Pow(e29, y29 + h29) + Math.Sqrt(2.7 * y29));

        Console.WriteLine($"Результат задания №29 = {T29}");


        // 30
        Console.WriteLine("Задание №30");

        double N30, p30, y30, e30;

        Console.WriteLine("Введите значение перременной p");
        p30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e30 = Convert.ToDouble(Console.ReadLine());


        N30 = (3 * Math.Pow(y30, 2) + Math.Sqrt(y30 + 1)) / (Math.Log(p30 + y30) + Math.Pow(e30, p30));

        Console.WriteLine($"Результат задания №30 = {N30}");
    }
}