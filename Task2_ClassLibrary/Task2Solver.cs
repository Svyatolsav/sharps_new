using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2_ClassLibrary
{
    public class Task2Solver
    {
        public string Input { get; set; }
        public int N { get; set; }
        public string Output { get; set; }

        public Task2Solver()
        {

        }

        public void Extract()
        {
            var regex = new Regex($"\\w+");
            var input = File.ReadAllText(Input);
            var outout = regex.Matches(input).Cast<Match>().Select(x => x.Value).Where(x => x.Length == N);
            File.WriteAllLines(this.Output, outout);
        }
    }
}
