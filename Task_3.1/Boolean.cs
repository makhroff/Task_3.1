namespace Task_3._1
{
    class Boolean : AbramyanTasks
    {
        public static bool Task_1(int number) => number >= 0;
        public static bool Task_3(int number) => number % 2 == 0;
        public static bool Task_6(int a, int b, int c) => a < b && b < c;
        public static bool Task_9(int a, int b) => a % 2 != 0 || b % 2 != 0;
        public static bool Task_12(int a, int b, int c) => a >= 0 && b >= 0 && c >= 0;
        public static bool Task_15(int a, int b, int c) => a >= 0 && b >= 0 && c < 0 || a >= 0 && b < 0 && c >= 0 || a < 0 && b >= 0 && c >= 0;
        public static bool Task_18(int a, int b, int c) => a == b || b == c || c == a;
        public static bool Task_21(int number)
        {
            int unit = number % 10;
            int @decimal = number % 100 / 10;
            int aHundred = number / 100;
            return aHundred < @decimal && @decimal < unit;
        }
        public static bool Task_24(int a, int b, int c) => (b * b) - (4 * a * c) > 0;
        public static bool Task_27(int x, int y) => x < 0 && y > 0 || x < 0 && y < 0;
        public static bool Task_30(int a, int b, int c) => a == b && b == c;
        public static bool Task_33(int a, int b, int c) => (a < b + c) && (b < a + c) && (c < a + b);
        public static bool Task_36(int x1, int y1, int x2, int y2) => (x1 == x2) || (y1 == y2);
        public static bool Task_39(int x1, int y1, int x2, int y2) => (Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) || (x1 == x2) || (y1 == y2);
    }
}
