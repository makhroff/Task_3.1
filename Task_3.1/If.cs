﻿namespace Task_3._1
{
    static class If
    {
        public static int _1(int number)
        {
            if (number >= 0) return number++;
            return number;
        }
        public static int _3(int number)
        {
            if (number > 0) return number++;
            if (number < 0) return number - 2;
            return 10;
        }
        public static int _6(int num1, int num2)
        {
            if (num1 > num2) return num1;
            return num2;
        }
        public static string _9(double a, double b)
        {
            if (a > b)
            {
                double b1 = a;
                a = b;
                b = b1;
            }
            return $"A: {a}, B: {b}";
        }
        public static int _12(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3) return num1;
            if (num2 < num3 && num2 < num1) return num2;
            return num3;
        }
        public static int _15(int num1, int num2, int num3)
        {
            if (num1 > num3 && num2 > num3) return num1 + num2;
            if (num2 > num1 && num3 > num1) return num2 + num3;
            return num3 + num1;
        }
        public static int _18(int num1, int num2, int num3)
        {
            if (num1 == num2) return 3;
            else if (num2 == num3) return 1;
            return 2;
        }
        public static int _21(int x, int y)
        {
            if (x == 0 && y == 0) return 0;
            if (x == 0 && y != 0) return 1;
            if (x != 0 && y == 0) return 2;
            return 3;
        }
        public static double _24(double x)
        {
            if (x > 0) return 2 * Math.Sin(x);
            return 6 - x;
        }
        public static double _27(double x)
        {
            if (x < 0) return 0;
            if (x % 2 == 0) return 1;
            return -1;
        }
        public static string _30(int num)
        {
            if (num <= 0) return "Error";
            if (num >= 1000) return "Error";

            if (num < 10)
            {
                if (num % 2 == 0) return "Even one-digit number";
                return "Odd one-digit number";
            }
            else if (num < 100)
            {
                if (num % 2 == 0) return "Even two-digit number";
                return "Odd two-digit number";
            }

            if (num % 2 == 0) return "Even three-digit number";
            return "Odd three-digit number";
        }
    }

}
