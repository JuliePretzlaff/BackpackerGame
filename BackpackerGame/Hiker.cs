using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackerGame
{
    public class Hiker
    {

        //properties:
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Energy { get; set; }
        public int Morale { get; set; }
        public int Health { get; set; }
        public int Orientation { get; set; }

        //constructor:
        public Hiker(string name)
        {
            this.Name = name;
            Hunger = 8;
            Thirst = 8;
            Energy = 8;
            Morale = 8;
            Health = 10;
        }



        //methods:
        public void StatusDisplay()
        {
            Console.WriteLine("\nHiker " + Name + " Status Display:");
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Thirst: " + Thirst);
            Console.WriteLine("Energy: " + Energy);
            Console.WriteLine("Morale: " + Morale);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Orientation: " + Orientation);
        }

        public void Tick()
        {
            Random r = new Random();
            int[] randomNumber = new int[1];
            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = r.Next(-1, 1);
            }

            Morale += randomNumber[0];
            Hunger -= 1;
            Thirst -= 1;


        }


    }
}
