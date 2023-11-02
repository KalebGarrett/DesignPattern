using DesignPattern.Command.Command;

namespace DesignPattern.Command;

// Invoker/Command Base
public class TvRemote
{
    public ICommand Command { get; set; }

    public void SetCommand(ICommand command)
    {
        Command = command;
    }

    public void PressButton()
    {
        Command.Execute();
    }
}