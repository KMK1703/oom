using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            var imediums = new IMedium[]
            {
                new Videogame("Stick of Truth", "PS3",40,"South Park PRG","Viedeogame"),
                new Videogame("Golgen Sun", "GameBoy", 20, "Fantasy RPG","Viedeogame"),
                new MusikCD("Heroes","Sabaton",40,"Limited Edition Earbook","Musik CD", "Heavy Metal"),
                new MusikCD("Bigger, Better, Faster, More!","4 non Blondes", 15, "Album 1992", "Musik CD", "Alternative-Rock"),
            };
			var videogames = new []
			{
				new Videogame("Super Mario Galaxy", "Nintendo Wii", 40, "Jump and Run Game", "Viedeogame"),
				new Videogame("Lemmings", "Super Nintendo", 35, "Help the Lemmings find their way!", "Viedeogame"),
				new Videogame("Worms","PC",20, "Worms against other Worms, Strategy Game", "Viedeogame"), 
				new Videogame("Pokemon","GameBoy", 25, "Catch em all!", "Viedeogame"), 
				new Videogame("Halo","Xbox",30, "First person shooter", "Viedeogame"),			
			};

            var musicCDs = new[]
            {
                new MusikCD("Live Licks","The Rolling Stones", 20, "Live Album 2004", "Musik CD", "Classic Rock"),
                new MusikCD("Drunken Lullabies","Flogging Molly",15, "Studio Album 2002", "Musik CD", "Irish Folk"),
                new MusikCD("Live After Death","Iron Maiden",17,"Live Album 1985", "Musik CD","Heavy Metal"),
                new MusikCD("Back in Black","AC/DC",15,"Studio Album 1980","Musik CD","Hard Rock"),
            };

            Console.WriteLine();
            foreach (var b in imediums)
            {
                Console.WriteLine("{0,-20}{1,-40}{2,8:0.00} EUR", b.MediumType, b.Title, b.CurrentValue);
            }

            Console.WriteLine();
            Console.WriteLine ("Games in Library: " + Videogame.GameCount);
            Console.WriteLine();

            foreach (var b in videogames)
			{
				Console.WriteLine("{0,-40} {1,-40} {2,8:0.00} EUR", b.Title, b.Platform, b.CurrentValue);

			}

            Console.WriteLine();

            foreach (var b in musicCDs)
            {
                Console.WriteLine("{0,-20} {1,-20} {2, -20} {3,-20} {4,8:0.00} EUR", b.Title, b.Interpret, b.Description, b.Genre, b.CurrentValue);
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
