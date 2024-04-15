using RemoteControl.Commands;
using RemoteControl.Gadgets;
using RemoteControl.Remotes;
using Utilities;

namespace RemoteControl;

public class Program {
    static void Main(string[] args) {
        SimpleRemoteControl remote1 = new SimpleRemoteControl();
        Light light1 = new Light();
        GarageDoor door1 = new GarageDoor();
        LightToggleCommand lightCommand = new LightToggleCommand(light1);
        
        remote1.SetCommand(lightCommand);
        remote1.ButtonWasPressed();
        remote1.SetCommand(new GarageDoorUpCommand(door1));
        remote1.ButtonWasPressed();

        door1.GarageLight = light1;

        remote1.SetCommand(lightCommand);
        remote1.ButtonWasPressed();
        remote1.SetCommand(new GarageDoorDownCommand(door1));
        remote1.ButtonWasPressed();

        ConsoleUtilities.Separator();

        FullRemoteControl remote2 = new FullRemoteControl();
        Light light2 = new Light();
        Stereo stereo1 = new Stereo();
        GarageDoor door2 = new GarageDoor();
        CeilingFan fan1 = new CeilingFan("Living Room");
        HotTub tub = new HotTub();
        Television tv = new Television("Family Room", 4);

        Console.WriteLine(light2.ToString());
        Console.WriteLine(stereo1.ToString());
        Console.WriteLine(door2.ToString());
                
        remote2.OnCommands[0] = new LightOnCommand(light2);
        remote2.OffCommands[0] = new LightOffCommand(light2);
        remote2.OnCommands[1] = new StereoOnAndCdCommand(stereo1);
        remote2.OffCommands[1] = new StereoOffCommand(stereo1);
        remote2.OnCommands[2] = new GarageDoorUpCommand(door2);
        remote2.OffCommands[2] = new GarageDoorDownCommand(door2);
        remote2.OnCommands[3] = new CeilingFanHighCommand(fan1);
        remote2.OffCommands[3] = new CeilingFanOffCommand(fan1);
        remote2.OnCommands[4] = new CeilingFanMediumCommand(fan1);
        remote2.OffCommands[4] = new CeilingFanOffCommand(fan1);
        remote2.OnCommands[5] = new CeilingFanLowCommand(fan1);
        remote2.OffCommands[5] = new CeilingFanOffCommand(fan1);
        remote2.OnCommands[6] = new MacroCommand(new List<ICommand>() {
            new LightOnCommand(light2),
            new StereoOnAndCdCommand(stereo1),
            new TelevisionOnCommand(tv),
            new TelevisionChangeChannelCommand(tv,69),
            new HotTubHeaterOnCommand(tub),
            new HotTubWhirlpoolOnCommand(tub),
        });
        remote2.OffCommands[6] = new MacroCommand(new List<ICommand>() {
            new LightOffCommand(light2),
            new StereoOffCommand(stereo1),
            new TelevisionOffCommand(tv),
            new HotTubHeaterOffCommand(tub),
            new HotTubWhirlpoolOffCommand(tub),
        });

        Console.WriteLine(remote2.ToString());

        remote2.OnButtonWasPressed(0);
        remote2.UndoButtonWasPressed();
        
        remote2.OnButtonWasPressed(1);
        remote2.UndoButtonWasPressed();
        
        remote2.OnButtonWasPressed(2);
        remote2.UndoButtonWasPressed();

        remote2.OnButtonWasPressed(3);
        remote2.OnButtonWasPressed(4);
        remote2.OnButtonWasPressed(5);
        remote2.OffButtonWasPressed(3);
        remote2.UndoButtonWasPressed();
        remote2.UndoButtonWasPressed();
        remote2.UndoButtonWasPressed();
        remote2.UndoButtonWasPressed();

        Console.WriteLine(remote2.ToString());

        remote2.OnButtonWasPressed(6);
        remote2.UndoButtonWasPressed();
        remote2.OnButtonWasPressed(6);
        remote2.OffButtonWasPressed(6);

    }
}