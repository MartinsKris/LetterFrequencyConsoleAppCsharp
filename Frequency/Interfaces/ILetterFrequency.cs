using System.Collections.Generic;

namespace LetterFrequency.Interfaces
{
    public interface ILetterFrequency
    {
        Dictionary<char, double> FrequencyDictionaryGen(List<char> generatedCharList);
    }
}
