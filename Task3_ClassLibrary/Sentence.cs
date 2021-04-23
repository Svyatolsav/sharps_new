using System.Collections.Generic;

namespace Task3_ClassLibrary
{
    public class Sentence
    {
        public IEnumerable<Word> Words { get; }

        public Sentence(IEnumerable<Word> words)
        {
            Words = words;
        }
    }
}
