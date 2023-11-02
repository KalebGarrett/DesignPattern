using System.Windows.Input;

namespace DesignPattern.Command.Command;

public class TurnOnTv : ICommand
{
    public Tv Tv { get; set; }

    public TurnOnTv(Tv tv)
    {
        Tv = tv;
    }

    public void Execute()
    {
        Tv.TurnOn();
    }
}