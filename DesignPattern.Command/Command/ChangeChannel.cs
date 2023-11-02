namespace DesignPattern.Command.Command;

public class ChangeChannel : ICommand
{
    public Tv Tv { get; set; }
    public int Channel { get; set; }
    
    public ChangeChannel(Tv tv, int channel)
    {
        Tv = tv;
        Channel = channel;
    }

    public void Execute()
    {
        Tv.ChangeChannel(Channel);
    }
}