var player = new MusicPlayer();
var remote = new MusicRemote();

remote.SetCommand(new PlayCommand(player));
Console.WriteLine(remote.PressButton());

remote.SetCommand(new PauseCommand(player));
Console.WriteLine(remote.PressButton());

remote.SetCommand(new SkipCommand(player));
Console.WriteLine(remote.PressButton());