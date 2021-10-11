using System.Collections.Generic;
using System.IO;

namespace LetterFrequency.Interfaces
{
    public interface IContentProvider
    {
        List<char> ReadFile(StreamReader textFile);
    }
}
