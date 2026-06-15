using Xunit;
using XpSystem;

namespace XpSystem.Tests;

public class PlayerTests
{
    [Fact]
    public void NewPlayer_ShouldStartAtLevelOneAndZeroXp()
    {
        // Arrange & Act
        var player = new Player("Hero");

        // Assert
        Assert.Equal(1, player.Level);
        Assert.Equal(0, player.Xp);
    }

}