using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Prototype

{

    class Program

    {

        static void Main(string[] args)

        {

            IHappyMeal HappyMeal = new BigHappyMeal(0.7, 2);

            IHappyMeal clonedHappyMeal = HappyMeal.Clone();

            HappyMeal.GetInfo();

            clonedHappyMeal.GetInfo();

            HappyMeal = new SmallHappyMeal(0.3, 1);

            clonedHappyMeal = HappyMeal.Clone();

            HappyMeal.GetInfo();

            clonedHappyMeal.GetInfo();

            Console.Read();

        }

    }

    interface IHappyMeal

    {

        IHappyMeal Clone();

        void GetInfo();

    }

    class BigHappyMeal : IHappyMeal

    {

        double sizeOfPepsi;

        int numberOfToys;

        public BigHappyMeal(double sizeOfPepsi, int numberOfToys)

        {

            this.sizeOfPepsi = sizeOfPepsi;

            this.numberOfToys = numberOfToys;

        }

        public IHappyMeal Clone()

        {

            return new BigHappyMeal(this.sizeOfPepsi, this.numberOfToys);

        }

        public void GetInfo()

        {

            Console.WriteLine("HappyMeal cu volumul de Pepsi {0} si numarul de jucarii {1}", sizeOfPepsi, numberOfToys);

        }

    }

    class SmallHappyMeal : IHappyMeal

    {

        double sizeOfPepsi;

        int numberOfToys;

        public SmallHappyMeal(double sizeOfPepsi, int numberOfToys)

        {

            this.sizeOfPepsi = sizeOfPepsi;

            this.numberOfToys = numberOfToys;

        }

        public IHappyMeal Clone()

        {

            return new SmallHappyMeal(this.sizeOfPepsi, this.numberOfToys);

        }

        public void GetInfo()

        {

            Console.WriteLine("HappyMeal cu volumul de Pepsi {0} si numarul de jucarii  {1}", sizeOfPepsi, numberOfToys);

        }

    }

}