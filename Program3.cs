

using System;

class Program
{
    static void Main()
    {
        // 1
        Console.WriteLine("Задание №1");

        double L1, e1, x1, a1, g1, c1;

        Console.WriteLine("Введите значение перременной e");
        e1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной g");
        g1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c1 = Convert.ToDouble(Console.ReadLine());

        L1 = (Math.Sqrt(Math.Pow(e1, x1) - Math.Pow((Math.Cos(Math.Pow(x1, 2) * Math.Pow(a1, 5))), 4))) + Math.Pow((Math.Atanh(a1 - Math.Pow(x1, 5))), 4) / (Math.Pow((Math.Abs(a1 + x1 * Math.Pow(c1, 4))), e1 / 2));

        Console.WriteLine($"Результат задания №1 = {L1}");


        // 2
        Console.WriteLine("Задание №2");

        double L2, c2, x2, t2;

        Console.WriteLine("Введите значение перременной c");
        c2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной t");
        t2 = Convert.ToDouble(Console.ReadLine());


        L2 = Math.Pow((Math.Tanh(c2)), 2) * ((2 * Math.Pow(x2, 2) + 5)) / (Math.Sqrt(c2 + t2));

        Console.WriteLine($"Результат задания №2 = {L2}");


        // 3
        Console.WriteLine("Задание №3");

        double A3, y3, h3;

        Console.WriteLine("Введите значение перременной y");
        y3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной h");
        h3 = Convert.ToDouble(Console.ReadLine());

        A3 = (Math.Tan(Math.Pow(y3, 3) - Math.Pow(h3, 4)) + Math.Pow(h3, 2)) / (Math.Pow((Math.Sin(h3)), 3) + y3);

        Console.WriteLine($"Результат задания №3 = {A3}");


        // 4
        Console.WriteLine("Задание №4");

        double F4, y4, x4;

        Console.WriteLine("Введите значение перременной e");
        y4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x4 = Convert.ToDouble(Console.ReadLine());
        F4 = (Math.Sqrt(Math.Pow((2 + y4), 2) + Math.Pow((Math.Sin(y4 + 5)), 7 / 2))) / (Math.Log(x4 + 1) - Math.Pow(y4, 3));

        Console.WriteLine($"Результат задания №4 = {F4}");


        // 5
        Console.WriteLine("Задание 5");

        double G5, x5, z5, y5, c5;

        Console.WriteLine("Введите значение перременной z");
        z5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c5 = Convert.ToDouble(Console.ReadLine());


        G5 = (Math.Tan(Math.Pow(x5, 4) - 6) - Math.Pow((Math.Cos(z5 + x5 * y5)), 3)) / (Math.Pow((Math.Cos(Math.Pow(x5, 3) * Math.Pow(c5, 2))), 4));

        Console.WriteLine($"Результат задания №5 = {G5}");


        // 6
        Console.WriteLine("Задание №6");

        double K6, x6, b6, a6, y6;

        Console.WriteLine("Введите значение перременной x");
        x6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной b");
        b6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y6 = Convert.ToDouble(Console.ReadLine());


        K6 = (Math.Sqrt(x6 + b6 - a6) + Math.Log(y6)) / (Math.Atan(b6 + a6));

        Console.WriteLine($"Результат задания №6 = {K6}");


        // 7
        Console.WriteLine("Задание №7");

        double D7, y7, x7, a7;

        Console.WriteLine("Введите значение перременной y");
        y7 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x7 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a7 = Convert.ToDouble(Console.ReadLine());


        D7 = (Math.Cos(Math.Pow(x7, 3) + 6) - Math.Sin(y7 - a7)) / (Math.Log(Math.Pow(x7, 4)) - 2 * Math.Pow(Math.Sin(x7), 5));

        Console.WriteLine($"Результат задания №7 = {D7}");


        // 8
        Console.WriteLine("Задание №8");

        double P8, y8, x8, c8, a8;

        Console.WriteLine("Введите значение перременной y");
        y8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c8 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a8 = Convert.ToDouble(Console.ReadLine());


        P8 = (Math.Pow(a8, 5) + Math.Pow((Math.Sin(y8 - c8)), 4)) / (Math.Pow((Math.Sin(x8 + y8)), 3) + Math.Abs(x8 - y8));

        Console.WriteLine($"Результат задания №8 = {P8}");


        // 9
        Console.WriteLine("Задание №9");

        double R9, y9, x9, d9, e9;

        Console.WriteLine("Введите значение перременной e");
        e9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y9 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной d");
        d9 = Convert.ToDouble(Console.ReadLine());


        R9 = (Math.Pow((Math.Cos(y9)), 3) + Math.Pow(2, x9) * d9) / (Math.Pow(e9, x9) + Math.Log(Math.Pow((Math.Sin(x9)), 2) + 7.4));

        Console.WriteLine($"Результат задания №9 = {R9}");


        // 10
        Console.WriteLine("Задание №10");

        double U10, e10, x10, y10;

        Console.WriteLine("Введите значение перременной e");
        e10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x10 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y10 = Convert.ToDouble(Console.ReadLine());


        U10 = (Math.Pow(e10, Math.Pow(x10, 3)) + Math.Pow((Math.Cos(x10 - 4)), 2)) / (Math.Atan(10) + 5.2 * y10);

        Console.WriteLine($"Результат задания №10 = {U10}");


        // 11
        Console.WriteLine("Задание №11");

        double I11, y11, x11, e11;

        Console.WriteLine("Введите значение перременной e");
        e11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x11 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y11 = Convert.ToDouble(Console.ReadLine());

        I11 = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow((Math.Cos(y11)), 2)))) / (Math.Pow(e11, y11) + Math.Pow((Math.Sin(x11)), 2));

        Console.WriteLine($"Результат задания №11 = {I11}");


        // 12
        Console.WriteLine("Задание №12");

        double G12, y12, x12, a12;

        Console.WriteLine("Введите значение перременной y");
        y12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x12 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a12 = Convert.ToDouble(Console.ReadLine());


        G12 = (Math.Pow((Math.Cos(Math.Abs(y12 + x12))), 3) - (x12 + y12)) / (Math.Pow((Math.Atan(x12 + a12)), 4) * Math.Pow(x12, 3));

        Console.WriteLine($"Результат задания №12 = {G12}");


        // 13
        Console.WriteLine("Задание №13");

        double R13, b13, x13, a13;

        Console.WriteLine("Введите значение перременной b");
        b13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a13 = Convert.ToDouble(Console.ReadLine());

        R13 = ((a13) / (x13 - a13)) + ((Math.Pow(b13, x13) + Math.Pow((Math.Cos(x13)), 3)) / (Math.Pow((Math.Log(a13)), 3) + 4.5));

        Console.WriteLine($"Результат задания №13 = {R13}");


        // 14
        Console.WriteLine("Задание №14");

        double R14, x14;


        Console.WriteLine("Введите значение перременной x");
        x14 = Convert.ToDouble(Console.ReadLine());

        R14 = (Math.Sin(Math.Pow(((Math.Pow(x14, 2)) + 4), 3)) + 4.3) / (Math.Pow((Math.Cos(Math.Pow(x14, 4))), 3));

        Console.WriteLine($"Результат задания №14 = {A3}");


        // 15
        Console.WriteLine("Задание №15");

        double N15, y15, m15;

        Console.WriteLine("Введите значение перременной y");
        y15 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной m");
        m15 = Convert.ToDouble(Console.ReadLine());

        N15 = (Math.Pow(m15, 2) + 2.8 * m15 + 0.355) / (Math.Cos(2) * y15 + 3.6);

        Console.WriteLine($"Результат задания №15 = {N15}");

        // 16
        Console.WriteLine("Задание №16");
        double P16, t16, x16, y16, e16;
        Console.WriteLine("Введите значение перременной t");
        t16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y16 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e16 = Convert.ToDouble(Console.ReadLine());
        P16 = (Math.Pow((Math.Sin(x16)), 3) + Math.Log10(2 * y16 + 3 * x16)) / (Math.Pow(t16, e16) + Math.Sqrt(x16));
        Console.WriteLine($"Результат задания №16 = {P16}");

        // 17
        Console.WriteLine("Задание №17");
        double T17, a17, b17, x17, y17;
        Console.WriteLine("Введите значение перременной a");
        a17 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной b");
        b17 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x17 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y17 = Convert.ToDouble(Console.ReadLine());
        T17 = (Math.Sqrt(x17 + b17 - a17) + Math.Log10(y17)) / (Math.Atan(b17 + a17));
        Console.WriteLine($"Результат задания №17 = {T17}");

        // 18
        Console.WriteLine("Задание №18");
        double S18, t18, y18;
        Console.WriteLine("Введите значение перременной t");
        t18 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y18 = Convert.ToDouble(Console.ReadLine());
        S18 = (4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log10(t18)) / (Math.Sqrt(Math.Cos(2 * y18) + 4.351));
        Console.WriteLine($"Результат задания №18 = {S18}");

        // 19
        Console.WriteLine("Задание №19");
        double D19, K19, a19, b19, x19, y19, arx;

        Console.WriteLine("Введите значение перременной K");
        K19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной arx");
        arx = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной a");
        a19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной b");
        b19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x19 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y19 = Convert.ToDouble(Console.ReadLine());
        D19 = (Math.Pow(K19, arx) - a19 * Math.Sqrt(6) - Math.Cos(3 * a19 * b19)) / (Math.Pow(Math.Sin(a19 * Math.Asin(x19) + Math.Log10(y19)), 2));
        Console.WriteLine($"Результат задания №19 = {D19}");

        // 20
        Console.WriteLine("Задание №20");
        double U20, a20, b20, c20, x20, y20;
        Console.WriteLine("Введите значение перременной a");
        a20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной b");
        b20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x20 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y20 = Convert.ToDouble(Console.ReadLine());
        U20 = (Math.Pow(Math.Tan(y20), 3) + Math.Pow(Math.Sin(x20 * Math.Sqrt(b20 - c20)), 3)) / (Math.Sqrt(a20 - b20 + c20));
        Console.WriteLine($"Результат задания №20 = {U20}");

        // 21
        Console.WriteLine("Задание №21");
        double N21, z21, x21, e21, a21;
        Console.WriteLine("Введите значение перременной a");
        a21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x21 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной z");
        z21 = Convert.ToDouble(Console.ReadLine());
        N21 = (Math.Pow((z21 * Math.Sqrt(z21 * x21)), 3 / 2)) / (Math.Pow(e21, x21) + Math.Pow(a21, 3) * Math.Atanh(x21));
        Console.WriteLine($"Результат задания №21 = {N21}");

        // 22
        Console.WriteLine("Задание №22");
        double F22, x22, y22;
        Console.WriteLine("Введите значение перременной x");
        x22 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y22 = Convert.ToDouble(Console.ReadLine());
        F22 = (Math.Cos(Math.Pow(x22, 2) + 2) + ((3.5 * Math.Pow(x22, 2) + 1) / (Math.Pow(Math.Cos(y22), 2))));
        Console.WriteLine($"Результат задания №22 = {F22}");

        // 23
        Console.WriteLine("Задание №23");
        double F23, x23, z23, b23, a23;
        Console.WriteLine("Введите значение перременной a");
        a23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной b");
        b23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x23 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной z");
        z23 = Convert.ToDouble(Console.ReadLine());
        F23 = (Math.Sqrt(Math.Abs(x23) + Math.Pow(Math.Cos(x23), 3) + Math.Pow(z23, 4))) / (Math.Log10(x23) - Math.Asin(b23 * x23 - a23));
        Console.WriteLine($"Результат задания №23 = {F23}");

        // 24
        Console.WriteLine("Задание №24");
        double f24, b24, a24, x24, z24;
        Console.WriteLine("Введите значение перременной a");
        a24 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной b");
        b24 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x24 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной z");
        z24 = Convert.ToDouble(Console.ReadLine());
        f24 = (Math.Pow(Math.Cos(b24 * Math.Pow(x24, 5)), 7) - (Math.Sin(Math.Pow(a24, 2)) - Math.Cos(Math.Pow(x24, 3) + Math.Pow(z24, 5) - Math.Pow(a24, 2)))) / (Math.Asin(Math.Pow(a24, 2)) + Math.Acos(Math.Pow(x24, 7) - Math.Pow(a24, 2)));
        Console.WriteLine($"Результат задания №24 = {f24}");

        // 25
        Console.WriteLine("Задание №25");
        double J25, a25, x25, y25;
        Console.WriteLine("Введите значение перременной a");
        a25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y25 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x25 = Convert.ToDouble(Console.ReadLine());
        J25 = (Math.Pow(Math.Tan(Math.Pow(a25, 3)), 3) + Math.Pow(Math.Atan(a25), 2)) / (Math.Sqrt(Math.Pow(y25, Math.Tan(x25))));
        Console.WriteLine($"Результат задания №25 = {J25}");

        // 26
        Console.WriteLine("Задание №26");
        double U26, x26, y26, e26, k26;
        Console.WriteLine("Введите значение перременной k");
        k26 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной e");
        e26 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x26 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y26 = Convert.ToDouble(Console.ReadLine());
        U26 = (Math.Log10(Math.Pow(x26, 3) + y26) - Math.Pow(y26, 4)) / (Math.Pow(e26, y26) + 5.4 * Math.Pow(k26, 3));
        Console.WriteLine($"Результат задания №26 = {U26}");

        // 27
        Console.WriteLine("Задание №27");
        double P27, a27, c27, x27, y27;
        Console.WriteLine("Введите значение перременной a");
        a27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной c");
        c27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x27 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y27 = Convert.ToDouble(Console.ReadLine());
        P27 = (Math.Pow(a27, 5) + Math.Acos(a27 + Math.Pow(x27, 3)) - Math.Pow(Math.Sin(y27 - c27), 4)) / (Math.Pow(Math.Sin(x27 - y27), 3) + Math.Abs(x27 - y27));
        Console.WriteLine($"Результат задания №27 = {P27}");

        // 28
        Console.WriteLine("Задание №28");
        double G28, c28, x28, y28, z28;
        Console.WriteLine("Введите значение перременной c");
        c28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной x");
        x28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной y");
        y28 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение перременной z");
        z28 = Convert.ToDouble(Console.ReadLine());
        G28 = (Math.Tan(Math.Pow(x28, 4) - 6) - Math.Pow(Math.Cos(z28 + Math.Pow(x28, 3) * y28), 3 * x28)) / (Math.Pow(Math.Cos(Math.Pow(x28, 3) * Math.Pow(c28, 2)), 2));
        Console.WriteLine($"Результат задания №28 = {G28}");

        // 29
        Console.WriteLine("Задание №29");
        double R29, x29, y29, d29, e29;
        Console.WriteLine("Введите значение переменной x:");
        x29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y:");
        y29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной d:");
        d29 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e:");
        e29 = Convert.ToDouble(Console.ReadLine());
        R29 = (Math.Pow(Math.Cos(y29), 2) + 2.4 * d29) / (Math.Pow(e29, y29) + Math.Log10(Math.Pow(Math.Sin(x29 + 6), 2)));
        Console.WriteLine($"Результат задания №29 = {R29}");

        // 30
        Console.WriteLine("Задание №30");
        double K30, x30, e30;
        Console.WriteLine("Введите значение переменной x:");
        x30 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной e:");
        e30 = Convert.ToDouble(Console.ReadLine());
        K30 = (Math.Sqrt(Math.Pow((3 + x30), 6) - Math.Log10(x30))) / (Math.Pow(e30, 0) + Math.Asin(6 * Math.Pow(x30, 2)));
        Console.WriteLine($"Результат задания №30 = {K30}");
    }
}