using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var darkcandy = new NewYearGift()
            {
                WeightOfCandy = 0.100,
                DarkCandy = new Candy()
                {
                    CandyDarkChoc = new Chocolate()
                    {
                        DarkChocolate = true,
                        WhiteChocolate = false
                    }
                }
            };

            var whitecandy = new NewYearGift()
            {
                WeightOfCandy = 0.200,
                WhiteCandy = new Candy()
                {
                    CandyDarkChoc = new Chocolate()
                    {
                        DarkChocolate = false,
                        WhiteChocolate = true
                    }
                }
            };

            var setoflollipop = new NewYearGift()
            {
                WeightOfCandy = 0.300,
                lollipops = new Lollipop[]
                {
                   new Lollipop() { Lollipops = "Яблуко" }, new Lollipop() { Lollipops = "Ананас" }, new Lollipop() { Lollipops = "Малина" }
                }
            };

            void DoPackage(IPack pack)
            {
                pack.Package();
            };

            int choise;
            do
            {
                Console.WriteLine("Виберіть солодощі які потрібно запакувати в подарунок: \n1. Чорна \t2. Біла \t3. Льодяники \t4. Закінчити упаковку ");
                choise = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choise)
                {
                    case 1:
                        DoPackage(darkcandy);
                        break;
                    case 2:
                        DoPackage(whitecandy);
                        break;
                    case 3:
                        DoPackage(setoflollipop);
                        break;
                    default:
                        break;
                }
            } while (choise != 4);

            Console.ReadKey();
        }
    }
}
