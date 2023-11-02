namespace DesignPattern.Command.Command;

public class TurnOffTv : ICommand
{
    public Tv Tv { get; set; }

    public TurnOffTv(Tv tv)
    {
        Tv = tv;
    }
    
    public void Execute()
    {
        Tv.TurnOff();
    }
}