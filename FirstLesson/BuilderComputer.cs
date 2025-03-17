public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HDD { get; set; }

    public override string ToString() =>
        $"Computer with {CPU} CPU, {RAM} RAM and {HDD} HDD.";
}

public class ComputerBuilder
{
    private Computer _computer = new Computer();

    public ComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRAM(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetHDD(string hdd)
    {
        _computer.HDD = hdd;
        return this;
    }

    public Computer Build() => _computer;
}