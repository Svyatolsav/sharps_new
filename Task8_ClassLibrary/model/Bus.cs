using System;

namespace Task8
{
    public class Bus : Subject
    {
        private static readonly Random random = new Random();

        private bool running = true;

        private readonly Station worker;

        public Bus(string modelName) : base(modelName, 100)
        {
            this.worker = new Station();
            this.worker.ProgressEvent += (owner) =>
            {
                if (owner != this)
                {
                    return;
                }
                this.RaiseEvent($"Автобус переполнен, ожидаем высвобождения({worker.Progress}%)");
                if (worker.Progress == 100)
                {
                    this.running = true;
                }
            };
            this.worker.Start();
        }

        protected override void Tick()
        {
            if (!this.running)
            {
                return;
            }

            var random = Bus.random.NextDouble();
            if (random < 0.006)
            {
                this.running = false;
                if (random < 0.003)
                {
                    var @interface = InterfaceContainer.GetRandomInterface();
                    this.RaiseEvent($"Посадка пассажира.");
                    @interface.ProgressEvent += (owner) =>
                    {
                        if (owner != this)
                        {
                            return;
                        }
                        this.running = true;
                    };
                    @interface.Request(this);
                }
                else
                {
                    worker.Request(this);
                }
            }

            if (this.running)
            {
                this.RaiseEvent("Идёт по маршруту");
                return;
            }
        }
    }
}
