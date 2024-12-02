using ExerciseFive;

namespace TestEx5_T2PR2
{
    [TestClass]
    public class UnitTestPersonaHelper
    {
        // CLASSIFYAGE

        [TestMethod]
        public void ClassifyAge_Child()
        {
            //Arrange
            int numTest = 3;
            int result;
            int expectedResult = 0;
            //Act
            result = PersonaHelper.ClassifyAge(numTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ClassifyAge_Adult()
        {
            //Arrange
            int numTest = 37;
            int result;
            int expectedResult = 1;
            //Act
            result = PersonaHelper.ClassifyAge(numTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ClassifyAge_Elder()
        {
            //Arrange
            int numTest = 80;
            int result;
            int expectedResult = 2;
            //Act
            result = PersonaHelper.ClassifyAge(numTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ClassifyAge_NotInValidRange()
        {
            //Arrange
            int numTest = -4;
            int result;
            int expectedResult = -1;
            //Act
            result = PersonaHelper.ClassifyAge(numTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ClassifyAge_NotValidInput()
        {
            //Arrange
            int numTest = '@';
            int result;
            int expectedResult = -1;
            //Act
            result = PersonaHelper.ClassifyAge(numTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // ISEVEN

        [TestMethod]
        public void IsEven_ExpectedTrue()
        {
            //Arrange
            int numTest = 10;
            bool result;
            //Act
            result = PersonaHelper.IsEven(numTest);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsEven_ExpectedFalse()
        {
            //Arrange
            int numTest = 9;
            bool result;
            //Act
            result = PersonaHelper.IsEven(numTest);
            //Assert
            Assert.IsFalse(result);
        }
    }
}