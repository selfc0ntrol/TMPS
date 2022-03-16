using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Collections;

namespace Builder

{

    class HappyMeal

    {

        ArrayList parts = new ArrayList();

        public void Add(string part)

        {

            parts.Add(part);

        }

        public void Show()

        {

            Console.WriteLine(" Happy Meal Parts ——-");

            foreach (string part in parts)

                Console.WriteLine(part);

        }

    }

    abstract class HappyMealBuilder

    {

        public abstract void BuildBurger();

        public abstract void BuildPepsi();

        public abstract void BuildToy();

        public abstract HappyMeal GetProduct();

    }

    class BigHappyMealBuilder : HappyMealBuilder

    {

        private HappyMeal happy_meal = new HappyMeal();

        public override void BuildBurger()

        {

            happy_meal.Add("BigMac");

        }

        public override void BuildPepsi()

        {

            happy_meal.Add("Pepsi 0.7");

        }

        public override void BuildToy()

        {

            happy_meal.Add("Two toys");

        }

        public override HappyMeal GetProduct()

        {

            return happy_meal;

        }

    }

    class SmallHappyMealBuilder : HappyMealBuilder

    {

        private HappyMeal happy_meal = new HappyMeal();

        public override void BuildBurger()

        {

            happy_meal.Add("Hamburger");

        }

        public override void BuildPepsi()

        {

            happy_meal.Add("Pepsi 0.3");

        }

        public override void BuildToy()

        {

            happy_meal.Add("One toy");

        }

        public override HappyMeal GetProduct()

        {

            return happy_meal;

        }

    }

    class Director

    {


        public void Construct(HappyMealBuilder builder)

        {

            builder.BuildBurger();

            builder.BuildPepsi();

            builder.BuildToy();

        }

    }

    class Program

    {

        public static void Main()

        {

            Director director = new Director();

            HappyMealBuilder big_hmbuilder = new BigHappyMealBuilder();

            HappyMealBuilder small_hmbuilder = new SmallHappyMealBuilder();

         
            director.Construct(big_hmbuilder);

            HappyMeal hm1 = big_hmbuilder.GetProduct();

            hm1.Show();

            director.Construct(small_hmbuilder);

            HappyMeal hm2 = small_hmbuilder.GetProduct();

            hm2.Show();

            Console.Read();

        }

    }

}