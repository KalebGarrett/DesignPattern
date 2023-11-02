﻿namespace DesignPattern.Command;

// Receiver
public class Tv
{
    private int volume = 50; // Initialize volume to 50

    public void TurnOn()
    {
        Console.WriteLine("TV is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is OFF");
    }

    public void ChangeChannel(int channel)
    {
        Console.WriteLine("Changed to channel " + channel);
    }

    public void IncreaseVolume()
    {
        if (volume < 100)
        {
            volume += 5;
            Console.WriteLine("Volume increased to " + volume);
        }
        else
        {
            Console.WriteLine("Volume is already at maximum.");
        }
    }

    public void DecreaseVolume()
    {
        if (volume > 0)
        {
            volume -= 5;
            Console.WriteLine("Volume decreased to " + volume);
        }
        else
        {
            Console.WriteLine("Volume is already at minimum.");
        }
    }

    public int GetVolume()
    {
        return volume;
    }
}