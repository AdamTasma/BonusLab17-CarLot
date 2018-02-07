using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab_17_v2
{
    static class CarApp
    {
        public static int carCount;
        public static List<Car> carList = new List<Car>();
        public static void UserInput()
        {
            Console.WriteLine("how many cars would you like to input data for?");
            carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                Car c = new Car();
                Console.WriteLine("-----New Car-----");
                Console.WriteLine("what is the car's make?");
                c.Make = Console.ReadLine();
                Console.WriteLine("What is the car's model?");
                c.Model = Console.ReadLine();
                Console.WriteLine("What is the car's year?");
                c.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the car's price?");
                c.Price = double.Parse(Console.ReadLine());
                carList.Add(c);
                //Console.WriteLine(c.Model);
            }
            //Console.WriteLine(carList.Count);
            PrintCarList();
        }
        public static void PrintCarList()
        {
            Console.WriteLine("current car list");
            foreach (Car auto in carList)
            {
                //Console.WriteLine(Car.Make);
                Console.WriteLine(auto.ToString());
            }
        }
        public override string ToString()
        {
            https://msdn.microsoft.com/en-us/library/system.object.tostring%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
        }

    }
}
