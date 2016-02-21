using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var videogames = new []
			{
				new Videogame("Super Mario Galaxy", "Nintendo Wii", 40),
				new Videogame("Lemmings", "Super Nintendo", 35),
				new Videogame("Worms","PC",20), 
				new Videogame("Pokemon","GameBoy", 25), 
				new Videogame("Halo","Xbox",30),
				new Videogame("Sonic","Sega MasterSystem")
			};

			Console.WriteLine ("Games in Library: " + Videogame.GameCount);
		
			foreach (var b in videogames)
			{
				Console.WriteLine("{0,-40} {1,-40} {2,8:0.00} EUR", b.Title, b.Platform, b.CurrentValue);

			}

			foreach (var b in videogames) {
				if (b.Platform == "PC") {
					b.CurrentValue = b.CurrentValue + 5;
				}
			}
				
			Console.WriteLine ();

			foreach (var b in videogames)
			{
				Console.WriteLine("{0,-40} {1,-40} {2,8:0.00} EUR {3,8:0.00}", b.Title, b.Platform, b.CurrentValue,b.getValueFactor());

			}

		}
	}
}
