using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> listhuman = new List<Human>();
            Address one_home = new Address("Alicante", "Castanos", 43);
            Human one = new Human("Christina", "Bakhir", 18, one_home);
            Human two = new Human("Andrey", "Petrov", 20, new Address("Paris", "Center", 6));

            List<Human> listhumans = new List<Human>();
            listhumans.Add(one);
            listhumans.Add(two);

            Console.WriteLine("People in this list");
            foreach (Human peoples in listhumans)
                peoples.printInfo();
        }
    }
}
