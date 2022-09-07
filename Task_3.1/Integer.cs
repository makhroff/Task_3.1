namespace Task_3._1
{
    static class Integer
    {
        public static int Task_1(int distanceInCentimeters) => distanceInCentimeters / 100;
        public static int Task_3(int sizeInBytes) => sizeInBytes / 1024;
        public static string Task_6(int number) => $"Decimal: {number / 10}, Unit: {number % 10}";
        public static int Task_9(int number) => number / 100;

        public static int Task_12(int number)
        {
            int unit = number % 10;
            int @decimal = number % 100 / 10;
            int aHundred = number / 100;
            int newNumber = unit * 100 + @decimal * 10 + aHundred;
            return newNumber;
        }
        public static int Task_15(int number)
        {
            int unit = number % 10;
            int @decimal = number % 100 / 10;
            int aHundred = number / 100;
            int newNumber = @decimal * 100 + aHundred * 10 + unit;
            return newNumber;
        }

        public static int Task_18(int number) => number % 10000 / 1000;
        public static int Task_21(int seconds) => seconds % 60;
        public static int Task_24(int numberOfDay) => numberOfDay % 7;
        public static int Task_27(int numberOfDay) => (numberOfDay + 4) % 7 + 1;
        public static int Task_30(int year) => year / 100 + 1;
    }
}
