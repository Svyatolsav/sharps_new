namespace Task4_ClassLibrary
{
    public class Computer1
    {
        public string Processor { get; }

        public int MHz { get; }

        public int RAM { get; }

        public Computer1(string processor, int mhz, int ram)
        {
            Processor = processor;
            MHz = mhz;
            RAM = ram;
        }

        public virtual double Q()
        {
            return MHz * 0.1 + RAM;
        }

        public override string ToString()
        {
            return $"Компьютер1|CPU={Processor}|MHz={MHz}|RAM={RAM}|Q={Q()}";
        }
    }
}
