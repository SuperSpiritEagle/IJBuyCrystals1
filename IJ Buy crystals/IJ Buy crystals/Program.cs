using System;

namespace IJ_Buy_crystals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int countCrystals;
            int crystals = 50;
            int costCrystals = 10;
            Console.WriteLine("В ведите количество золота");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какое количестов кристаллов вы хотите купить");
            countCrystals = Convert.ToInt32(Console.ReadLine());
            crystals -= countCrystals;
            countCrystals *= costCrystals;
            gold -= countCrystals;
            Console.WriteLine($"остаток золота {gold} остаток кристаллов {crystals}");
        }
    }
}
