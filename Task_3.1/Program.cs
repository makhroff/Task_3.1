namespace Task_3._1
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("===INTEGER===");
            Integer._1(73654).Print();
            Integer._3(236754).Print();
            Integer._6(21).Print();
            Integer._9(765).Print();
            Integer._12(875).Print();
            Integer._15(123).Print();
            Integer._18(535749683).Print();
            Integer._21(84600).Print();
            Integer._24(365).Print();
            Integer._27(365).Print();
            Integer._30(2022).Print();

            Console.WriteLine();
            Console.WriteLine("===BOOLEAN===");
            Boolean._1(3246).Print();
            Boolean._3(69).Print();
            Boolean._6(1, 2, 3).Print();
            Boolean._9(1, 2).Print();
            Boolean._12(1, 2, 3).Print();
            Boolean._15(1, 2, 3).Print();
            Boolean._18(1, 2, 3).Print();
            Boolean._21(347).Print();
            Boolean._24(6, 7, 3).Print();
            Boolean._27(-23, 8).Print();
            Boolean._30(354, 230, 876).Print();
            Boolean._33(23, 87, 23).Print();
            Boolean._36(1, 2, 3, 4).Print();
            Boolean._39(1, 2, 3, 4).Print();

            Console.WriteLine();
            Console.WriteLine("===IF===");
            If._1(4635).Print();
            If._3(325677).Print();
            If._6(3465, 23654).Print();
            If._9(21012022, 275634).Print();
            If._12(5476, 65, 335).Print();
            If._15(5476, 65, 335).Print();
            If._18(5476, 65, 335).Print();
            If._21(56, 0).Print();
            If._24(234.5).Print();
            If._27(546.0).Print();
            If._30(654).Print();
        }

        static class Integer
        {
            public static int _1(int distanceInCentimeters) => distanceInCentimeters / 100;
            public static int _3(int sizeInBytes) => sizeInBytes / 1024;
            public static string _6(int number) => $"Decimal: {number / 10}, Unit: {number % 10}";
            public static int _9(int number) => number / 100;

            public static int _12(int number)
            {
                int unit = number % 10;
                int @decimal = number % 100 / 10;
                int aHundred = number / 100;
                int newNumber = unit * 100 + @decimal * 10 + aHundred;
                return newNumber;
            }
            public static int _15(int number)
            {
                int unit = number % 10;
                int @decimal = number % 100 / 10;
                int aHundred = number / 100;
                int newNumber = @decimal * 100 + aHundred * 10 + unit;
                return newNumber;
            }

            public static int _18(int number) => number % 10000 / 1000;
            public static int _21(int seconds) => seconds / 3600;
            public static int _24(int numberOfDay) => numberOfDay % 7;
            public static int _27(int numberOfDay) => (numberOfDay + 4) % 7 + 1;
            public static int _30(int year) => year / 100 + 1;
        }

        static class Boolean
        {
            public static bool _1(int number) => number >= 0;
            public static bool _3(int number) => number % 2 == 0;
            public static bool _6(int a, int b, int c) => a < b && b < c;
            public static bool _9(int a, int b) => a % 2 != 0 || b  % 2 != 0;
            public static bool _12(int a, int b, int c) => a >= 0 && b >= 0 && c >= 0;
            public static bool _15(int a, int b, int c) => a >= 0 && b >= 0 && c < 0 || a >= 0 && b < 0 && c >= 0 || a < 0 && b >= 0 && c >= 0;
            public static bool _18(int a, int b, int c) => a == b || b == c || c == a;
            public static bool _21(int number)
            {
                int unit = number % 10;
                int @decimal = number % 100 / 10;
                int aHundred = number / 100;
                return aHundred < @decimal && @decimal < unit;
            }
            public static bool _24(int a, int b, int c) => (b * b) - (4 * a * c) > 0;
            public static bool _27(int x, int y) => x < 0 && y > 0 || x < 0 && y < 0;
            public static bool _30(int a, int b, int c) => a == b && b == c;
            public static bool _33(int a, int b, int c) => (a < b + c) && (b < a + c) && (c < a + b);
            public static bool _36(int x1, int y1, int x2, int y2) => (x1 == x2) || (y1 == y2);
            public static bool _39(int x1, int y1, int x2, int y2) => (Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) || (x1 == x2) || (y1 == y2);
        }

        static class If
        {
            public static int _1(int number)
            {
                if (number >= 0) return number++;
                return number;
            }
            public static int _3(int number)
            {
                if(number > 0) return number++;
                if(number < 0) return number - 2;
                return 10;
            }
            public static int _6(int num1, int num2)
            {
                if(num1 > num2) return num1;
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
                if(num1 < num2 && num1 < num3) return num1;
                if(num2 < num3 && num2 < num1) return num2;
                return num3;
            }
            public static int _15(int num1, int num2, int num3)
            {
                if(num1 > num3 && num2 > num3) return num1 + num2;
                if(num2 > num1 && num3 > num1) return num2 + num3;
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
                if(x == 0 && y == 0) return 0;
                if(x == 0 && y != 0) return 1;
                if(x != 0 && y == 0) return 2;
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
                if(num <= 0) return "Error";
                if(num >= 1000) return "Error";

                if(num < 10)
                {
                    if (num % 2 == 0) return "Even one-digit number";
                    return "Odd one-digit number";
                }
                else if(num < 100)
                {
                    if (num % 2 == 0) return "Even two-digit number";
                    return "Odd two-digit number";
                }

                if (num % 2 == 0) return "Even three-digit number";
                return "Odd three-digit number";
            }
        }



        static void Print(this int obj) => Console.WriteLine(obj);
        static void Print(this double obj) => Console.WriteLine(obj);
        static void Print(this bool obj) => Console.WriteLine(obj);
        static void Print(this string obj) => Console.WriteLine(obj);
    }
}