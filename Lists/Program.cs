using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Array");	
			Console.WriteLine("Inventory System");
			Console.WriteLine();

			string currentItem;
			string[] inventory1 = new string[10];

			//init
			currentItem = "Smokes"; //Metal gear
		/*	inventory[0] = "";
			inventory[1] = "";
			inventory[2] = "";
			inventory[3] = "";
			inventory[4] = "";
			inventory[5] = "";
			inventory[6] = "";
			inventory[7] = "";
			inventory[8] = "";
			inventory[9] = "";*/

			for (int i = 0; 1 <= inventory1.Length - 1; i++) // 0..9 (for 10 items)
			{
				inventory1[i] = "";
			}

			// simulated gameplay
			// player picks up "health potion"

			inventory1[0] = "health postion"; // works, but doesn't .. what if 0 is taken??

			// player drops/use "health potion"
			// ???



			Console.WriteLine("Lists");
			Console.WriteLine("Inventory System");
			Console.WriteLine();

			List<string> inventory = new List<string>();
			// ^^^^^^^^^^^^^
			// declaration
			//                      ^^^^^^^^^^^^^^^^^^
			//                        instantiation

			Console.WriteLine("Inventory size = " + inventory.Count);
			inventory.Add("health potion");
			Console.WriteLine("Inventory size = " + inventory.Count);
			inventory.Add("health potion");
			Console.WriteLine("Inventory size = " + inventory.Count);

			//show inventory?
			for (int i = 0; i <= inventory.Count - 1; i++)
			{
				Console.WriteLine(inventory[i]);
			}
			foreach (string item in inventory)
			{
				Console.WriteLine(item);
			}
			// foreach and for loops show the same thing

			// drop health potion
			inventory.Remove("health potion");

			foreach (string item in inventory)
			{
				Console.WriteLine(item);
			}



			Console.ReadKey(true);
		}
	}
}
