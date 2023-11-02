namespace DesignPattern.Command.Command;

public class DecreaseVolume : ICommand
{
    public Tv Tv { get; set; }
    
    public DecreaseVolume(Tv tv)
    {
        Tv = tv;
    }

    public void Execute()
    {
        Tv.DecreaseVolume();
    }
}