using Utilities;

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
    }
}