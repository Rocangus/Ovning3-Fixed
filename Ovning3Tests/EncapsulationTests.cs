using System;
using Xunit;
using Ovning3.Encapsulation;

namespace Ovning3Tests
{
    public class EncapsulationTests
    {
        [Fact]
        public void PersonHandlerTests()
        {
            // Arrange
            Person pers1 = PersonHandler.CreatePerson(24, "Henning", "Odén", 1.75, 58.5);
            Person pers2 = PersonHandler.CreatePerson(70, "Nils", "Odén", 1.73, 67.4);
            Person invalidAge = PersonHandler.CreatePerson(-56, "Invalid", "Age", 1.67, 63.1);
            Person noFirstName = PersonHandler.CreatePerson(34, "", "Bad Name", 1.84, 70.6);
            Person noLastName = PersonHandler.CreatePerson(46, "Missing Name", "", 1.53, 53.7);
            Person invalidHeight = PersonHandler.CreatePerson(56, "Negative", "Height", -3.65, 53.7);
            Person InvalidWeight = PersonHandler.CreatePerson(43, "Bad", "Weight", 1.67, -45);

            // Act
            Person pers1Expected = pers1;
            Person pers2Expected = pers2;

            // Assert
            Assert.Same(pers1, pers1Expected);
            Assert.Same(pers2, pers2Expected);
            Assert.Null(invalidAge);
            Assert.Null(noFirstName);
            Assert.Null(noLastName);
            Assert.Null(invalidHeight);
            Assert.Null(InvalidWeight);
        }
    }
}
