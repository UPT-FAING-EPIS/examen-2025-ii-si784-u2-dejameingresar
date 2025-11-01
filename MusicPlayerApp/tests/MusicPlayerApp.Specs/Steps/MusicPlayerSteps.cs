using TechTalk.SpecFlow;
using FluentAssertions;

[Binding]
public class MusicPlayerSteps
{
    private MusicPlayer _player;
    private MusicRemote _remote;
    private string _result;

    [Given(@"I have a music player")]
    public void GivenIHaveAMusicPlayer()
    {
        _player = new MusicPlayer();
        _remote = new MusicRemote();
    }

    [When(@"I press Play")]
    public void WhenIPressPlay()
    {
        _remote.SetCommand(new PlayCommand(_player));
        _result = _remote.PressButton();
    }

    [When(@"I press Pause")]
    public void WhenIPressPause()
    {
        _remote.SetCommand(new PauseCommand(_player));
        _result = _remote.PressButton();
    }

    [When(@"I press Skip")]
    public void WhenIPressSkip()
    {
        _remote.SetCommand(new SkipCommand(_player));
        _result = _remote.PressButton();
    }

    [Then(@"the result should be ""(.*)""")]
    public void ThenTheResultShouldBe(string expected)
    {
        _result.Should().Be(expected);
    }
}