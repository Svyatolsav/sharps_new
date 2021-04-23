namespace Task4_ClassLibrary
{
    public class Computer2 : Computer1
    {

        public int HDD { get; }

        public Computer2(string processor, int mhz, int ram, int hdd) : base(processor, mhz, ram)
        {
            HDD = hdd;
        }

        public override double Q()
        {
            return base.Q() + 0.5 * HDD;
        }

        public override string ToString()
        {
            return $"Компьютер2|CPU={Processor}|MHz={MHz}|RAM={RAM}|HDD={HDD}|Q_P={Q()}";
        }
    }
}
