using System;

namespace Task2
{
	public class Videogame
	{
		private decimal PurchasePrice;

		/// <summary>
		/// Creates a new Videogame object.
		/// </summary>
		/// <param name="title">Title must not be empty.</param>
		/// <param name="platform">Platform</param>
		/// <param name="price">Price in EUR must not be negative.</param>
		public Videogame(string title, string platform, decimal purchasePrice)
		{
			if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title must not be empty.", nameof(title));
			if (string.IsNullOrWhiteSpace(platform)) throw new ArgumentException("Platform must not be empty.", nameof(platform));

			Title = title;
			Platform = platform;
			CurrentValue = purchasePrice;
			PurchasePrice = purchasePrice;
			GameCount++;
		}
	
		public Videogame(string title, string platform)
		{
			if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title must not be empty.", nameof(title));
			if (string.IsNullOrWhiteSpace(platform)) throw new ArgumentException("Platform must not be empty.", nameof(platform));

			Title = title;
			Platform = platform;
			CurrentValue = 20;
			PurchasePrice = 20;
			GameCount++;
		}

		static public int GameCount { get; private set; }

		/// <summary>
		/// Gets the game title.
		/// </summary>
		public string Title { get; }

		/// <summary>
		/// Gets the Platform.
		/// </summary>
		public string Platform { get; }

		/// <summary>
		/// Gets or sets the current value of the game.
		/// </summary>
		/// <value>The current value of the game.</value>
		public decimal CurrentValue { get; set; }


		/// <summary>
		/// Calculates the value changes. 
		/// </summary>
		/// <value>The get value factor.</value>
		public decimal getValueFactor() {
			return CurrentValue/PurchasePrice;
		}

	}
}

