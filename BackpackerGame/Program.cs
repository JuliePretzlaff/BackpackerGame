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
            //1 tent 2 sleepingbag 3pad 4 stove 5 first aid kit  6 
            Console.WriteLine("\nWhen you started your overnight camping trip, had enough space in your backpack to hold 10 meals of food, plus 12 items." +
                "\nFrom the below items, please choose 10 to place in your pack.  After each selection, press enter.");
            Console.WriteLine("stove and fuel \nflint \nmatches");
            Console.WriteLine("tent \nsleeping bag \nhammock");
            Console.WriteLine("first aid kit \nknife \nrope");
            Console.WriteLine("rain coat \nwarm clothes \ngood book");
            Console.WriteLine("camera \n flashlight \nbear canister");
            Pack.FillPack();


            //explanation:
            Console.WriteLine("\nBelow you will see status display for your hiker.");
            Console.WriteLine("Each condition is assigned a value between 1-10.");
            Console.WriteLine("The higher the vlue, the healthier/more satisfied you are.");
            Console.WriteLine("The lower the value, the less satisfied and healthy you are.");

            //opening status display:
            hiker1.StatusDisplay();

           // Console.WriteLine("Hiker {0}, on the);


            

       
        }
    }
}
