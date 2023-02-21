using System;

namespace CodeHomeWork_2_2
{
    /// <summary>
    ///   
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var darkcandy = new NewYearGift()
            {
                Name = "Чорна",
                WeightOfCandy = 0.100,
                DarkCandy = new Candy()
                {
                    CandyDarkChoc = new Chocolate()
                    {
                        DarkChocolate = true,
                        WhiteChocolate = false,
                    },
                },
            };

            var whitecandy = new NewYearGift()
            {
                Name = "Біла",
                WeightOfCandy = 0.200,
                WhiteCandy = new Candy()
                {
                    CandyDarkChoc = new Chocolate()
                    {
                        DarkChocolate = false,
                        WhiteChocolate = true,
                    },
                },
            };

            var setoflollipop = new NewYearGift()
            {
                Name = "Льодяники",
                WeightOfCandy = 0.300,
                Lollipops = new Lollipop[]
                {
                   new Lollipop() { Lollipops = "Яблуко" }, new Lollipop() { Lollipops = "Ананас" },
                   new Lollipop() { Lollipops = "Малина" },
                },
            };

            NewYearGift gift = new NewYearGift();

            int choise;
            int countOfIter = 0;
            void DoPackage(IPack pack)
            {
                pack.Package();
            }

            do
            {
                Console.WriteLine("Виберіть 3 солодощів які потрібно запакувати в подарунок: \n1. Чорна \t2. Біла \t3. Льодяники");
                choise = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choise)
                {
                    case 1:
                        gift.AddCandyToGift(darkcandy);
                        DoPackage(darkcandy);
                        gift.ShowAllCandy();
                        break;
                    case 2:
                        gift.AddCandyToGift(whitecandy);
                        DoPackage(whitecandy);
                        gift.ShowAllCandy();
                        break;
                    case 3:
                        gift.AddCandyToGift(setoflollipop);
                        DoPackage(setoflollipop);
                        gift.ShowAllCandy();
                        break;
                    default:
                        break;
                }

                countOfIter++;
            }
            while (countOfIter != 3);

            gift.Sort();
            gift.Search();
            Console.ReadKey();
        }
    }
}
