using System;
using System.Collections.Generic;
using LetterFrequency.Interfaces;
using LetterFrequency.Models;

namespace LetterFrequency.Methods
{
    public class FrequencyDictionary : ILetterFrequency
    {
        /// <summary>
        /// As parameter method FrequencyDictionaryGen receives character list. Then iterates through english alphabet
        /// and counts how many times each letter appears in provided character list. Then creates new object
        /// which consist of letter and integer of how many times it appears in character list.
        /// </summary>
        /// <param name="generatedCharList">
        /// List with upper case letter characters
        /// </param>
        /// <returns>
        /// Return  Dictionary with char as key and double as value.
        /// </returns>
        public Dictionary<char, double> FrequencyDictionaryGen(List<char> generatedCharList)
        {
            char[] alphabet =
                { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Z' };

            Dictionary<char, double> frequencyDictionary = new Dictionary<char, double>();
            List<CharObject> charObjectList = new List<CharObject>();
            var charString = new String(generatedCharList.ToArray());

            foreach (var charValue in alphabet)
            {
                var charCount = charString.Split(charValue).Length - 1;

                charObjectList.Add(new CharObject(charValue, charCount));
            }

            foreach (var charObjectValue in charObjectList)
            {
                double charCountDouble = (Convert.ToDouble(charObjectValue.ReturnInt) / generatedCharList.Count) * 100;
                frequencyDictionary.Add(charObjectValue.ReturnChar, charCountDouble);
            }

            return frequencyDictionary;
        }
    }
}
