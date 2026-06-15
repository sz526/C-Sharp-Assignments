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
    [Fact]
    public void GainXp_ShouldIncreaseXp()
    {
        // Arrange
        var player = new Player("Hero");

        // Act
        player.GainXp(40);

        // Assert
        Assert.Equal(40, player.Xp);
    } 
    [Fact]
    public void GainXp_ReachingOneHundredXp_ShouldLevelUp()
    {
        // Arrange
        var player = new Player("Hero");

        // Act
        player.GainXp(100);

        // Assert
        Assert.Equal(2, player.Level);
        Assert.Equal(0, player.Xp);
    }
}