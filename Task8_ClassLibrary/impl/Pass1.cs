using System.Threading;

namespace Task8
{
    public class Pass1 : IPass
    {
        public void Dispatch()
        {
            Thread.Sleep(11000);
        }
    }
}
