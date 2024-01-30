namespace TowerOfHaNoi.Tests;

public class TestCreateGame : BuildTowerGameTest
{
    public TestCreateGame() : base(5) { }
    //Kiểm tra việc tạo và sử dụng disk với mỗi disk mang giá trị riêng
    [Theory]
    [InlineData(5, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(3, new int[] { 1, 2, 3 })]
    public void TestCreateDisk(int numberDisk, int[] valueDisks)
    {
        // Given
        var valueDisksExpected = valueDisks;

        // When
        _game.SetNumberDisk(numberDisk);
        var disks = _game.GetAllDisk();
        var valueDisksResult = ToolsForTest.ValueAnyDisk(disks);

        // Then
        Assert.Equal(numberDisk, disks.Length);
        Assert.Equal(valueDisksExpected, valueDisksResult);

    }
    [Fact]
    public void TestCreateTower()
    {
        //Arrange
        var numberTower = 3;
        var idTowersExpected = new int[] { 1, 2, 3 };

        //Action
        var towers = _game.GetAllTower();
        IList<int> listId = new List<int>();
        foreach (var tower in towers)
        {
            listId.Add(tower.TowerId);
        }
        int[] idTowers = listId.ToArray();
        //Assert
        Assert.Equal(numberTower, towers.Length);
        Assert.Equal(idTowersExpected, idTowers);

    }
}