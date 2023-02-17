using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_2_2
{
    public class NewYearGift : IPack
    {
        public NewYearGift[] AllCandy { get; set; }
        public Candy DarkCandy { get; set; }
        public Candy WhiteCandy { get; set; }
        public Lollipop[] lollipops { get; set; }
        public double WeightOfCandy { get; set; }
        public double WeightOfGift = 0;

        public void Package()
        {
            Console.WriteLine("Кількість солодощів:");
            int number = Int32.Parse(Console.ReadLine());

            double weight = WeightOfCandy * number;

            Console.WriteLine($"Вага подарунка {weight} кг");
            Console.WriteLine();
            WeightOfGift += weight;
        }

    }
}
