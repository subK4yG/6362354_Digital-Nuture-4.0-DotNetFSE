namespace BuilderPatternExample
{
    public class Computer
    {
        public string CPU { get; private set; }
        public string RAM { get; private set; }
        public string Storage { get; private set; }
        public string GPU { get; private set; }
        private Computer(Builder builder)
        {
            CPU = builder.CPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
            GPU = builder.GPU;
        }
        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {(string.IsNullOrEmpty(GPU) ? "None" : GPU)}";
        }
        public class Builder
        {
            public string CPU { get; private set; }
            public string RAM { get; private set; }
            public string Storage { get; private set; }
            public string GPU { get; private set; }
            public Builder SetCPU(string cpu)
            {
                CPU = cpu;
                return this;
            }
            public Builder SetRAM(string ram)
            {
                RAM = ram;
                return this;
            }
            public Builder SetStorage(string storage)
            {
                Storage = storage;
                return this;
            }
            public Builder SetGPU(string gpu)
            {
                GPU = gpu;
                return this;
            }
            public Computer Build()
            {
                return new Computer(this);
            }
        }
    }
}