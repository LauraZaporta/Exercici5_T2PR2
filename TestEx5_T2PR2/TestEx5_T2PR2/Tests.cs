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

        // NAMEANALYSER

        [TestMethod]
        public void NameAnalyser_IsShortAndPalindorme()
        {
            //Arrange
            string nameTest = "ojo";
            bool expectedResultShort = true;
            bool expectedResultPalindrom = true;
            //Act
            var result = PersonaHelper.NameAnalyser(nameTest);
            //Assert
            Assert.AreEqual(expectedResultShort, result.IsShort);
            Assert.AreEqual(expectedResultPalindrom, result.IsPalindrome);
        }
        [TestMethod]
        public void NameAnalyser_IsShortNotPalindorme()
        {
            //Arrange
            string nameTest = "rata";
            bool expectedResultShort = true;
            bool expectedResultPalindrom = false;
            //Act
            var result = PersonaHelper.NameAnalyser(nameTest);
            //Assert
            Assert.AreEqual(expectedResultShort, result.IsShort);
            Assert.AreEqual(expectedResultPalindrom, result.IsPalindrome);
        }
        [TestMethod]
        public void NameAnalyser_NotShortAndPalindorme()
        {
            //Arrange
            string nameTest = "arrarra";
            bool expectedResultShort = false;
            bool expectedResultPalindrom = true;
            //Act
            var result = PersonaHelper.NameAnalyser(nameTest);
            //Assert
            Assert.AreEqual(expectedResultShort, result.IsShort);
            Assert.AreEqual(expectedResultPalindrom, result.IsPalindrome);
        }
        [TestMethod]
        public void NameAnalyser_NotShortAndNotPalindorme()
        {
            //Arrange
            string nameTest = "toroide";
            bool expectedResultShort = false;
            bool expectedResultPalindrom = false;
            //Act
            var result = PersonaHelper.NameAnalyser(nameTest);
            //Assert
            Assert.AreEqual(expectedResultShort, result.IsShort);
            Assert.AreEqual(expectedResultPalindrom, result.IsPalindrome);
        }

        // VERIFYCOLOUR

        [TestMethod]
        public void VerifyColour_NoColour()
        {
            //Arrange
            string colorTest = "";
            int expectedResult = -1;
            int result;
            //Act
            result = PersonaHelper.VerifyColour(colorTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void VerifyColour_ColourCalmant()
        {
            //Arrange
            string colorTest = "BLAU";
            int expectedResult = 0;
            int result;
            //Act
            result = PersonaHelper.VerifyColour(colorTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void VerifyColour_ColourExclusiu()
        {
            //Arrange
            string colorTest = "Groc";
            int expectedResult = 1;
            int result;
            //Act
            result = PersonaHelper.VerifyColour(colorTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        // PERSONALITYTEST

        [TestMethod]
        public void PersonalityTest_Morning()
        {
            //Arrange
            string personalityTest = "matí";
            int expectedResult = 0;
            int result;
            //Act
            result = PersonaHelper.PersonalityTest(personalityTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PersonalityTest_Night()
        {
            //Arrange
            string personalityTest = "nit";
            int expectedResult = 1;
            int result;
            //Act
            result = PersonaHelper.PersonalityTest(personalityTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PersonalityTest_Random()
        {
            //Arrange
            string personalityTest = "aaa";
            int expectedResult = 2;
            int result;
            //Act
            result = PersonaHelper.PersonalityTest(personalityTest);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}