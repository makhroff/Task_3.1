namespace Task_3._1
{
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
}
