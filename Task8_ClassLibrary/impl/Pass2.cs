using System.Threading;

namespace Task8
{
    public class Pass2 : IPass
    {
        public void Dispatch()
        {
            Thread.Sleep(10000);
        }
    }
}
