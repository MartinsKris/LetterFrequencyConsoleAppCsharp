using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace LetterFrequency
{
    public class Program
    {
        static void Main(string[] args)
        {
            using StreamReader txtFile = new StreamReader("..\\..\\..\\sampleTextFrequency.txt");

            foreach (KeyValuePair<char, double> values in FrequencyDictionary(ReadFile(txtFile)))
            {
                Console.WriteLine("{0} = {1}%", values.Key, values.Value);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// As parameter method FrequencyDictionary receives character list. Then iterates through english alphabet
        /// and counts how many times each letter appears in provided character list. Then creates new object
        /// which consist of letter and integer of how many times it appears in character list.
        /// </summary>
        /// <param name="generatedCharList">
        /// List with upper case letter characters
        /// </param>
        /// <returns>
        /// Return  Dictionary with char as key and double as value.
        /// </returns>
        public static Dictionary<char, double> FrequencyDictionary(List<char> generatedCharList)
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

        /// <summary>
        /// Read by line from received text. Removes all symbols that isn't letters and empty space.
        /// Each line is splitted to character array, then when iterates through array, chars are converted to uppercase
        /// and added to final character array where is stored all letters as characters from text file.
        /// </summary>
        /// <param name="textFile">
        /// Text file (.txt) from provided user directory.
        /// </param>
        /// <returns>
        /// Character array that consists only of letters that was int parameter .txt file, all converted to upper case.
        /// </returns>
        public static List<char> ReadFile( StreamReader textFile)
        {
            string line;
            List<char> charList = new List<char>();
            Regex pattern = new Regex("[\\W\\d\\s\t\n]");

            line = textFile.ReadLine();

            while (line != null)
            {
                var cleanString = pattern.Replace(line, "");
                char[] txtCharArr = cleanString.ToCharArray();

                foreach (char charOfTxt in txtCharArr)
                {
                    charList.Add(Char.ToUpper(charOfTxt));
                }

                line = textFile.ReadLine();
            }

            return charList;
        }
    }
}
