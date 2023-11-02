namespace DesignPattern.Command.Command;

public class IncreaseVolume : ICommand
{
    public Tv Tv { get; set; }
    
    public IncreaseVolume(Tv tv)
    {
        Tv = tv;
    }

    public void Execute()
    {
        Tv.IncreaseVolume();
    }
}