using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace Task2
{
    [TestFixture]
    
    public class Tests
    {
        //[Test]
        //public void SimpleTest()
        //{
        //    Assert.IsTrue(1 == 1);
        //}

        [Test]
        public void NegativePrice()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Videogame("Name", "Platform",-14,"Zusammenfassung","Videogame");
            });
        }
        [Test]
        public void EmptyName()
        {
            Assert.Catch(() =>
            {
                var x = new Videogame("", "Platform", 10, "Text", "Videogame");
            });
        }
        [Test]
        public void EmptyPlatform()
        {
            Assert.Catch(() =>
            {
                var x = new Videogame("Name", "", 10, "Text", "Videogame");
            });
        }
        [Test]
        public void PriceTest()
            {
            var x = new Videogame("Name", "Platform", 5, "Text", "Videogame");

            Assert.IsTrue(x.CurrentValue == 5);
            }
        [Test]
        public void PriceFactorTest()
        {
            var x = new Videogame("Name", "Platform", 5, "Text", "Videogame");
            x.CurrentValue = 10;

            Assert.IsTrue(x.getValueFactor() == 2);
        }
        [Test]
        public void GameCountTest()
        {
            var PreviousGameCount = Videogame.GameCount;
            var newGame = new Videogame("Name", "Platform", 5, "Text", "Videogame");

            Assert.IsTrue(Videogame.GameCount == (PreviousGameCount+1));
        }
        [Test]
        public void GetGenreTest()
        {
            var newCD = new MusikCD("Title", "Interpret", 10, "Text", "CD", "Rock");

            Assert.IsTrue(newCD.Genre == "Rock");
        }

        [Test]
        public void emptyDescriptionTest()
        {
            
            Assert.DoesNotThrow(() =>
            {
                var newCD = new MusikCD("Title", "Interpret", 10, "", "CD", "Rock");
            });
        }
    }

}
