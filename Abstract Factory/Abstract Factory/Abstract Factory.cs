using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Abstract_factory

{

    class Program

    {

        public static void Main()

        {

            Client client = null;

            client = new Client(new CocaColaFactory());

            client.Run();

            client = new Client(new PepsiFactory());

            client.Run();

            Console.ReadKey();

        }

    }

    class Client

    {

        private AbstractWater water;

        private AbstractBottle bottle;

        public Client(AbstractFactory factory)

        {

            water = factory.CreateWater();

            bottle = factory.CreateBottle();

        }

        public void Run()

        {

            bottle.Interact(water);

        }

    }

    abstract class AbstractFactory

    {

        public abstract AbstractWater CreateWater();

        public abstract AbstractBottle CreateBottle();

    }

    class CocaColaFactory : AbstractFactory

    {

        public override AbstractWater CreateWater()

        {

            return new CocaColaWater();

        }

        public override AbstractBottle CreateBottle()

        {

            return new CocaColaBottle();

        }

    }

    class PepsiFactory : AbstractFactory

    {

        public override AbstractWater CreateWater()

        {

            return new PepsiWater();

        }

        public override AbstractBottle CreateBottle()

        {

            return new PepsiBottle();

        }

    }

    abstract class AbstractWater

    {

    }

    class CocaColaWater : AbstractWater

    {

    }

    class PepsiWater : AbstractWater

    {

    }

    abstract class AbstractBottle

    {

        public abstract void Interact(AbstractWater water);

    }

    class CocaColaBottle : AbstractBottle

    {

        public override void Interact(AbstractWater water)

        {

            Console.WriteLine(this + " interacts with " + water);

        }

    }

    class PepsiBottle : AbstractBottle

    {

        public override void Interact(AbstractWater water)

        {

            Console.WriteLine(this + " interacts with " + water);

        }

    }

}