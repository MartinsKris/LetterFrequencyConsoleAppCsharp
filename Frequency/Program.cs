using LetterFrequency.Methods;
using System;
using System.Collections.Generic;
using System.IO;

namespace LetterFrequency
{
    public class Program
    {
        static void Main(string[] args)
        {
            using StreamReader txtFile = new StreamReader("..\\..\\..\\Configuration\\sampleTextFrequency.txt");
            FrequencyDictionary dictionaryOfFrequencies = new FrequencyDictionary();
            ContentProvider characterList = new ContentProvider();

            foreach (KeyValuePair<char, double> values in dictionaryOfFrequencies.FrequencyDictionaryGen(characterList.ReadFile(txtFile)))
            {
                Console.WriteLine("{0} = {1}%", values.Key, values.Value);
            }

            Console.ReadKey();
        }
    }
}
