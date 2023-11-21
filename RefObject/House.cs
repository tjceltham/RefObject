using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefObject
{
    internal class House
    {
        private string house;
        public House(string h)
        {
            house = h;
        }

        public void PrintHouse()
        {
            Console.WriteLine(house);
        }
    }
}
