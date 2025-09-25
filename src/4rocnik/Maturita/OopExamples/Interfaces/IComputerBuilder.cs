namespace OopExamples.Interfaces;

public interface IComputerBuilder
{
    IComputer BuildFromConfiguration(IComputerConfiguration configuration);
    IComputerBuilder AddMotherBoard(IMotherBoard motherBoard);
    IComputerBuilder AddCpu(ICPU cpu);
    IComputerBuilder AddGpu(IGPU gpu);
    IComputerBuilder AddRam(IRAM ram);
    IComputerBuilder AddPowerSupply(IPowerSupply powerSupply);
    IComputerBuilder AddCase(ICase pcCase);
    IComputer Build();
}