using Utilities;

namespace Task_3._1
{
    static class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("===INTEGER===");
            Integer.Task_1(73654).Print();
            Integer.Task_3(236754).Print();
            Integer.Task_6(21).Print();
            Integer.Task_9(765).Print();
            Integer.Task_12(875).Print();
            Integer.Task_15(123).Print();
            Integer.Task_18(535749683).Print();
            Integer.Task_21(84600).Print();
            Integer.Task_24(365).Print();
            Integer.Task_27(365).Print();
            Integer.Task_30(2022).Print();

            

            Console.WriteLine();
            Console.WriteLine("===BOOLEAN===");
            Boolean.Task_1(3246).Print();
            Boolean.Task_3(69).Print();
            Boolean.Task_6(1, 2, 3).Print();
            Boolean.Task_9(1, 2).Print();
            Boolean.Task_12(1, 2, 3).Print();
            Boolean.Task_15(1, 2, 3).Print();
            Boolean.Task_18(1, 2, 3).Print();
            Boolean.Task_21(347).Print();
            Boolean.Task_24(6, 7, 3).Print();
            Boolean.Task_27(-23, 8).Print();
            Boolean.Task_30(354, 230, 876).Print();
            Boolean.Task_33(23, 87, 23).Print();
            Boolean.Task_36(1, 2, 3, 4).Print();
            Boolean.Task_39(1, 2, 3, 4).Print();

            Console.WriteLine();
            Console.WriteLine("===IF===");
            If.Task_1(4635).Print();
            If.Task_3(325677).Print();
            If.Task_6(3465, 23654).Print();
            If.Task_9(21012022, 275634).Print();
            If.Task_12(5476, 65, 335).Print();
            If.Task_15(5476, 65, 335).Print();
            If.Task_18(5476, 65, 335).Print();
            If.Task_21(56, 0).Print();
            If.Task_24(234.5).Print();
            If.Task_27(546.0).Print();
            If.Task_30(654).Print();
        }
    }
}