using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AddRider_ShouldAdd_Successfully()
        {
           
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Yamaha", 100, 500);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            string resultMessage = raceEntry.AddRider(rider);
            int expectedCount = 1;

            Assert.That(raceEntry.Counter, Is.EqualTo(expectedCount));
            Assert.AreEqual("Rider Pesho added in race.", resultMessage);

        }
        [Test]
        public void AddRider_WhenRider_IsNull_ThrowsInvalidOperationException()
        {

            RaceEntry raceEntry = new RaceEntry();
         
            UnitRider rider = null;
            
            int expectedCount = 0;
           
            string expectedMessage = "Rider cannot be null.";

            var exeption = Assert.Throws<InvalidOperationException>(
                () => raceEntry.AddRider(rider));

            Assert.AreEqual(expectedMessage, exeption.Message);

            Assert.That(raceEntry.Counter, Is.EqualTo(expectedCount));
        }
        [Test]
        public void AddRider_WhenRider_Exicts_ThrowsInvalidOperationException()
        {

            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Yamaha", 100, 500);
            UnitRider rider = new UnitRider("Pesho", motorcycle);         

            string resultMessage = raceEntry.AddRider(rider);

            string expectedMessage = "Rider Pesho is already added.";

            int expectedCount = 1;

            var exeption = Assert.Throws<InvalidOperationException>(
                () => raceEntry.AddRider(rider));

            Assert.AreEqual(expectedMessage, exeption.Message);

            Assert.That(raceEntry.Counter, Is.EqualTo(expectedCount));

        }
        [Test]
        public void CalculateAverageHorsePower_ShouldReturnAverageHorsePower_OfAllRiders()
        {

            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Yamaha", 10, 500);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            UnitMotorcycle motorcycle2 = new UnitMotorcycle("Honda", 20, 500);
            UnitRider rider2 = new UnitRider("Gosho", motorcycle2);

            UnitMotorcycle motorcycle3 = new UnitMotorcycle("CBR", 30, 500);
            UnitRider rider3 = new UnitRider("Ivan", motorcycle3);

            raceEntry.AddRider(rider);
            raceEntry.AddRider(rider2);
            raceEntry.AddRider(rider3);

            double result = raceEntry.CalculateAverageHorsePower();

            double expectedHP = 20;

            Assert.AreEqual(expectedHP, result);
        }
        [Test]
        public void CalculateAverageHorsePower_WhenOnly_OneRider_Added()
        {

            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Yamaha", 10, 500);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            raceEntry.AddRider(rider);

            string expectedMessage = "The race cannot start with less than 2 participants.";

            var exeption = Assert.Throws<InvalidOperationException>(
                () => raceEntry.CalculateAverageHorsePower());

            Assert.AreEqual(expectedMessage, exeption.Message);

        }
    }
}