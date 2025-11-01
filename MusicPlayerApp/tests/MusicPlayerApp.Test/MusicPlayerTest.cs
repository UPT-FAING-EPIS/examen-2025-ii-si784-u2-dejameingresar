using Xunit;

public class MusicPlayerTests
{
    [Fact]
    public void PlayCommand_ShouldReturnCorrectMessage()
    {
        var player = new MusicPlayer();
        var command = new PlayCommand(player);
        Assert.Equal("Playing the song.", command.Execute());
    }

    [Fact]
    public void PauseCommand_ShouldReturnCorrectMessage()
    {
        var player = new MusicPlayer();
        var command = new PauseCommand(player);
        Assert.Equal("Pausing the song.", command.Execute());
    }

    [Fact]
    public void SkipCommand_ShouldReturnCorrectMessage()
    {
        var player = new MusicPlayer();
        var command = new SkipCommand(player);
        Assert.Equal("Skipping to the next song.", command.Execute());
    }

    [Fact]
    public void Remote_ShouldExecuteCommand()
    {
        var player = new MusicPlayer();
        var remote = new MusicRemote();
        remote.SetCommand(new PlayCommand(player));
        Assert.Equal("Playing the song.", remote.PressButton());
    }
}