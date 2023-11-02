using DesignPattern.Command;
using DesignPattern.Command.Command;

var tv = new Tv();

var turnOnCommand = new TurnOnTv(tv);
var turnOffCommand = new TurnOffTv(tv);
var changeChannelCommand = new ChangeChannel(tv, 247);
var increaseVolumeCommand = new IncreaseVolume(tv);
var decreaseVolumeCommand = new DecreaseVolume(tv);

var remoteControl = new TvRemote();

remoteControl.SetCommand(turnOnCommand);
remoteControl.PressButton();

remoteControl.SetCommand(changeChannelCommand);
remoteControl.PressButton();

remoteControl.SetCommand(increaseVolumeCommand);
remoteControl.PressButton();
remoteControl.PressButton();

remoteControl.SetCommand(decreaseVolumeCommand);
remoteControl.PressButton();
remoteControl.PressButton();
remoteControl.PressButton();
remoteControl.PressButton();
remoteControl.PressButton();
remoteControl.PressButton();

var currentVolume = tv.GetVolume();
Console.WriteLine($"\nCurrent TV volume: {currentVolume}\n");

remoteControl.SetCommand(turnOffCommand);
remoteControl.PressButton();

Console.ReadKey();