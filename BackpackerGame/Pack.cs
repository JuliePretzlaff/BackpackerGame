using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackerGame
{
    public class Pack
    {
        

        //method to fill pack:
        public static void FillPack()
        {
            string[] backpack = new string[8];
            for (int i = 0; i<backpack.Length; i++)
			{
                Console.WriteLine("Please enter item number " + (i+1) + " to place in  your pack: ");
                backpack[i] = Console.ReadLine().ToLower();
                while ((backpack[i] != "stove and fuel") && (backpack[i] != "flint") && (backpack[i] != "matches") && (backpack[i] != "tent") &&
                    (backpack[i] != "sleeping bag") && (backpack[i] != "hammock") && (backpack[i] != "first aid kit") && (backpack[i] != "knife") &&
                    (backpack[i] != "rope") && (backpack[i] != "rain coat") && (backpack[i] != "water filter") && ( backpack[i] != "warm clothes") && (backpack[i] != "good book"))

                {
                    Console.WriteLine("That is not a valid object.  Please choose an object from the list above.");
                    backpack[i] = Console.ReadLine();
                }
            }

            Console.WriteLine("\nGreat!  Here is what's in your pack!");
            for (int i = 0; i < backpack.Length; i++)
            {
                Console.WriteLine(backpack[i]);
            }
        }

    }
}
