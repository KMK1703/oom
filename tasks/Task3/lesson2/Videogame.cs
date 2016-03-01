using System;

namespace Task2
{

    public interface IMedium
    {
        /// <summary>
        /// Gets a textual description of this item.
        /// </summary>
        string Description { get; }

        ///<Medium>
        /// What type of Medium is this?
        /// </Medium>
        string MediumType { get; }

        ///<Name>
        /// Name or Titel of the Medium
        /// </Name>
        string Title { get; }

        /// <summary>
        /// Gets or sets the current value of the game.
        /// </summary>
        /// <value>The current value of the game.</value>
        decimal CurrentValue { get; set; }

    }
    public class Videogame : IMedium
    {
        private decimal PurchasePrice;

        /// <summary>
        /// Creates a new Videogame object.
        /// </summary>
        /// <param name="title">Title must not be empty.</param>
        /// <param name="platform">Platform</param>
        /// <param name="price">Price in EUR must not be negative.</param>
        /// <param name="description">Description</param>
        /// <param name="mediumtype">Which Medium is this?</param>
        public Videogame(string title, string platform, decimal purchasePrice, string description, string mediumtype)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title must not be empty.", nameof(title));
            if (string.IsNullOrWhiteSpace(platform)) throw new ArgumentException("Platform must not be empty.", nameof(platform));

            Title = title;
            Platform = platform;
            CurrentValue = purchasePrice;
            PurchasePrice = purchasePrice;
            description = Description;
            MediumType = mediumtype;
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
        /// Gets a textual description of this item.
        /// </summary>
        public string Description { get; }

        ///<Medium>
        /// What type of Medium is this?
        /// </Medium>
        public string MediumType { get; }

        /// <summary>
        /// Gets or sets the current value of the game.
        /// </summary>
        /// <value>The current value of the game.</value>
        public decimal CurrentValue { get; set; }


        /// <summary>
        /// Calculates the value changes. 
        /// </summary>
        /// <value>The get value factor.</value>
        public decimal getValueFactor()
        {
            return CurrentValue / PurchasePrice;
        }

    }

    public class MusikCD : IMedium
    {
        /// <summary>
        /// Creates a new Videogame object.
        /// </summary>
        /// <param name="title">Title must not be empty.</param>
        /// <param name="interpret">Interpret</param>
        /// <param name="price">Price in EUR must not be negative.</param>
        /// <param name="description">Description</param>
        /// <param name="mediumtype">Which Medium is this?</param>
        /// <param name="genre">Which Genre is this?</param>
        public MusikCD(string title, string interpret, decimal purchasePrice, string description, string mediumtype, string genre)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title must not be empty.", nameof(title));
            if (string.IsNullOrWhiteSpace(interpret)) throw new ArgumentException("Platform must not be empty.", nameof(interpret));

            Title = title;
            Interpret = interpret;
            CurrentValue = purchasePrice;
            Description = description;
            MediumType = mediumtype;
            Genre = genre;
          
        }
        /// <summary>
        /// Gets the game title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the Platform.
        /// </summary>
        public string Interpret { get; }

        /// <summary>
        /// Gets a textual description of this item.
        /// </summary>
        public string Description { get; }

        ///<Medium>
        /// What type of Medium is this?
        /// </Medium>
        public string MediumType { get; }

        ///<Medium>
        /// What type of Medium is this?
        /// </Medium>
        public string Genre { get; }

        /// <summary>
        /// Gets or sets the current value of the game.
        /// </summary>
        /// <value>The current value of the game.</value>
        public decimal CurrentValue { get; set; }
        
    }
}
   

