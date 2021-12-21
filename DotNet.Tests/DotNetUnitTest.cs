using DotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNet.Tests {
    [TestClass]
    public class DotNetUnitTest {
        [TestMethod]
        //Naming Convention: Name_Scenario_ExpectedBehaviour
        public void BookAvailability_BookIsAvailable_ReturnsTrue () {
            //Arrange
            var bookAvailability = new BookAvailability ();

            //Act
            var result = bookAvailability.AvailabilityOfBook (new Book { IsAvailable = true });

            //Assert
            Assert.IsTrue (result, $"This book is avaiable");
        }

        [TestMethod]
        public void BookAvailability_BookIsWritten_ReturnTrue () {
            //Arrange
            var book = new Book ();
            var bookAvailability = new BookAvailability { WrittenBook = book };

            //Act
            var result = bookAvailability.AvailabilityOfBook (book);

            //Assert
            Assert.IsTrue (result, $"This book is written");
        }

        [TestMethod]
        public void BookAvailability_AnotherBookIsWritten_ReturnFalse () {
            //Arrange
            var bookAvailability = new BookAvailability { WrittenBook = new Book () };

            //Act
            var result = bookAvailability.AvailabilityOfBook (new Book ());

            //Assert
            Assert.IsFalse (result, $"This book is not written");
        }
    }
}