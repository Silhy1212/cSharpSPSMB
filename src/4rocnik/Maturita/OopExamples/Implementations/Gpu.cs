using OopExamples.Interfaces;
using OopExamples.Interfaces.Exceptions;

namespace OopExamples.Implementations;

public class Gpu : IGPU
{
    public string Name { get; set; }
    public GPUConnector[] Connectors { get; }
    public IComputer? Computer { get; set; }
    public GPUConnector[] AvailableConnectors { get; }
    public IMonitor[] ConnectedMonitors { get; set; }
    public bool IsUsed { get; set; }

    public void Connect(IComputer computer)
    {
        if (IsUsed)
        {
            throw new ComponentAlreadyConnectedException();
        }
        else Computer = null;
    }

    public void Disconnect()
    {
        if (!IsUsed)
        {
            throw new ComponentNotConnectedException();
        }

        else Computer = Computer;
    }

    public void ConnectMonitor(IMonitor monitor)
    {
        if (ConnectedMonitors.Contains(monitor))
        {
            throw new ComponentAlreadyConnectedException();
        }
        else if (AvailableConnectors.Contains != null)
        {
            throw new InvalidConnectorException();
        }
        else ConnectedMonitors = new Monitor[0];
        
    }

    public void DisconnectMonitor(IMonitor monitor)
    {
        throw new NotImplementedException();
    }
}