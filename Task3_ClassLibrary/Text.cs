using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task3_ClassLibrary
{
    public class Text
    {
        public IEnumerable<Sentence> Sentences { get; private set; }

        public Text(string text)
        {
            Sentences = ToText(text);
        }

        private IEnumerable<Sentence> ToText(string text)
        {
            return new Regex("\\S.+?\\.").
                Matches(text).
                Cast<Match>().
                Select(x => x.Value).
                Select(x => new Sentence(new Regex("\\S+").
                    Matches(x).
                    Cast<Match>().
                    Select(y => y.Value).
                    Select(y => new Word(y))
                ));
        }

        public void AppendText(string text)
        {
            Sentences = Sentences.Concat(ToText(text));
        }

        public string PrintText()
        {
            return string.Join(".", 
                Sentences.Select(x => string.Join(" ", 
                    x.Words.Select(y => y.Content)
                ))
            );
        }

        public string TextHeader()
        {
            return Sentences.FirstOrDefault()?.Words.FirstOrDefault()?.Content ?? "";
        }
    }
}
