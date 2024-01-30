namespace TowerOfHaNoi.Tests;

public class TestDefaultGame : BuildTowerGameTest
{
    public TestDefaultGame() : base(3)
    {
        SetupGame.SetDefault(ref _game);
    }
    [Fact]
    public void TestDefault()
    {
        //Arrange
        var towers = _game.GetAllTower();
        var tower1 = towers[0];
        var reusltExpected = ValueDisksExpected().Reverse();
        int idTower1Expected = 1;

        //Action
        int idTower1 = tower1.TowerId;
        int[] result = ToolsForTest.ValueDisksInTower(tower1);

        //Assert
        Assert.Equal(idTower1Expected, idTower1);
        Assert.Equal(reusltExpected, result);
        Assert.Empty(towers[1].Disks);
        Assert.Empty(towers[2].Disks);
    }

}