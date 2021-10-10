using LetterFrequency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterFrequencyTest
{
    [TestClass]
    public class TestObjectCreationAndCharCount
    {
        [TestMethod]
        public void FrequencyDictionary_ListWithTestCharsAndTestDictionary_TrueIfReceivedDictionaryContainsTestDictionaryKeysAndValues()
        {
            //Arrange
            List<char> testListOfChars = new List<char>() { 'A', 'B', 'Z', 'B' };
            Dictionary<char, double> testDictionary = new Dictionary<char, double>()
            {
                { 'A', 25 }, { 'B', 50 }, { 'C', 0 }, { 'D', 0 }, { 'E', 0 },
                { 'F', 0 }, { 'G', 0 }, { 'H', 0 }, { 'I', 0 }, { 'J', 0 },
                { 'K', 0 }, { 'L', 0 }, { 'M', 0 }, { 'N', 0 }, { 'O', 0 },
                { 'P', 0 }, { 'Q', 0 }, { 'R', 0 }, { 'S', 0 }, { 'T', 0 },
                { 'U', 0 }, { 'V', 0 }, { 'W', 0 }, { 'X', 0 }, { 'Z', 25 }
            };

            //Act
            var dictionaryValue = Program.FrequencyDictionary(testListOfChars);

            //Assert
            Assert.IsTrue(dictionaryValue.All(value => testDictionary.Contains(value)));
        }

        [TestMethod]
        public void CharObject_TestCharAndTestIntProvidedToNewObject_ReceivedObjectElementsAreTheSameAsTestValues()
        {
            //Arrange
            var testChar = 'Q';
            var testInt = 32;
            
            //Act
            var objectValue = new CharObject(testChar, testInt);

            //Assert
            Assert.AreEqual(testChar, objectValue.ReturnChar);
            Assert.AreEqual(testInt, objectValue.ReturnInt);
        }
    }
}
