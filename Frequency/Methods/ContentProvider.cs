using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using LetterFrequency.Interfaces;

namespace LetterFrequency.Methods
{
    public class ContentProvider : IContentProvider
    {
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
        public List<char> ReadFile(StreamReader textFile)
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
