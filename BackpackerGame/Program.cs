using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //greeting:
            Console.WriteLine("Welcome to the backpacker game! \nPlease enter your name: ");
            string name = Console.ReadLine();

            Hiker hiker1 = new Hiker(name);

            //pick backpack items:
            Console.WriteLine("\nWhen you started your overnight camping trip, had enough space in your backpack to " +
                "hold 10 meals of food, plus 12 items." +
                "\nFrom the below items, please choose 10 to place in your pack.  After each selection, press enter.");
            Console.WriteLine("stove and fuel \nflint \nmatches");
            Console.WriteLine("tent \nsleeping bag \nhammock");
            Console.WriteLine("first aid kit \nknife \nrope");
            Console.WriteLine("rain coat \nwarm clothes \ngood book");
            Console.WriteLine("camera \nflashlight \nbear canister");
            Pack.FillPack();


            //explanation:
            Console.WriteLine("\nBelow you will see status display for your hiker.");
            Console.WriteLine("Each condition is assigned a value between 1-10.");
            Console.WriteLine("The higher the vlue, the healthier/more satisfied you are.");
            Console.WriteLine("The lower the value, the less satisfied and healthy you are.");

            //opening status display:
            hiker1.StatusDisplay();

           Console.WriteLine("Hiker {0}, on the first night of your hike, you take a wrong turn and get lost, " +
               "and your map blows away down a ravine.  See if you can take care of yourself in the wilderness " +
               "until you can find your way back to civilization!" +
               "Ration your food, use your gear, and make smart decisions!");


            

       
        }
    }
}
