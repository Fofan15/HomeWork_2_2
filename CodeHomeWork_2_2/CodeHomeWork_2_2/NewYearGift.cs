using System;

namespace CodeHomeWork_2_2
{
    public class NewYearGift : IPack
    {
        private const int ArraySize = 3;
        private static double weightOfGift = 0;
        private NewYearGift[] gift = new NewYearGift[ArraySize];
        private int addedCandyCount = 0;
        private double weightOfAllCandy = 0;
        private int number;

        public Candy DarkCandy { get; set; }

        public Candy WhiteCandy { get; set; }

        public Lollipop[] Lollipops { get; set; }

        public string Name { get; set; }

        public double WeightOfCandy { get; set; }

        public void AddCandyToGift(NewYearGift p)
        {
            this.gift[this.addedCandyCount] = p;
            this.addedCandyCount++;
        }

        public void Package()
        {
            Console.WriteLine("Кількість солодощів:");
            this.number = int.Parse(Console.ReadLine());

            this.weightOfAllCandy = this.WeightOfCandy * this.number;
            Console.WriteLine();
            Console.WriteLine($"Вага солодощів {this.weightOfAllCandy} кг");

            weightOfGift += this.weightOfAllCandy;
            Console.WriteLine();
            Console.WriteLine($"Вага подарунку {weightOfGift} кг");
        }

        public void ShowAllCandy()
        {
            Console.WriteLine();
            Console.WriteLine("Дитячий дарунок містить такі цукерки: ");
            foreach (NewYearGift candy in this.gift)
            {
                if (candy != null)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{candy.Name} - {candy.weightOfAllCandy} кг");
                    Console.WriteLine();
                }
            }
        }

        public void Sort()
        {
            for (int i = 0; i < this.gift.Length - 1; i++)
            {
                for (int j = i + 1; j < this.gift.Length; j++)
                {
                    if (this.gift[i].weightOfAllCandy > this.gift[j].weightOfAllCandy)
                    {
                        NewYearGift temp = this.gift[i];
                        this.gift[i] = this.gift[j];
                        this.gift[j] = temp;
                    }
                }
            }

            Console.WriteLine("Відсортований подарунок по вазі:");
            for (int i = 0; i < this.gift.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{this.gift[i].Name} - {this.gift[i].weightOfAllCandy} кг");
            }
        }

        public void Search()
        {
            double weight = 0.200;
            NewYearGift foundCandy = null;

            foreach (NewYearGift candy in this.gift)
            {
                if (candy.WeightOfCandy == weight)
                {
                    foundCandy = candy;
                    break;
                }
            }

            if (foundCandy != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Знайдено цукерку '{foundCandy.Name}'");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Цукерка з вагою {weight} г не знайдена в дарунку");
            }
        }
    }
}
