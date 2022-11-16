using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Город Улица",11.1,22.2,33.3);
            Console.WriteLine(building.Print());

            MultiBuilding multiBuilding = new MultiBuilding("Город Улица", 11.1, 22.2, 33.3, 12);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
