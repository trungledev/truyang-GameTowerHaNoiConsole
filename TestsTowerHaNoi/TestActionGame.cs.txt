namespace TowerOfHaNoi.Tests;

public class TestActionGame : BuildTowerGameTest
{
    //Xét trong trường hợp ban đầu mặc định
    //Với giá trị tower1 chứa 3 disk và 2 tower còn lại empty
    private ActionGame _controllerGame;
    public TestActionGame() : base(3)
    {
        SetupGame.SetDefault(ref _game);
        _controllerGame = new ActionGame(ref _game);
    }
    /*
        Hai trường hợp cần kiểm tra trong 
            TestChooseFirstTower: Hợp lệ và không hợp lệ:
            1,Trường hợp Hợp lệ: 2 điều cần
                +TowerId hợp lệ
                +Chứa ít nhất 1 disk
            2,K hợp lệ: còn lại
    */

    [Fact]
    public void TestTower()
    {
        var allTower = _game.GetAllTower();
        IList<int> countDisk = new List<int>();
        foreach (var tower in allTower)
        {
            countDisk.Add(tower.Disks.Length);
        }
        var count = countDisk.ToArray();

        Assert.Equal(new int[] { 3, 0, 0 }, count);
    }
    [Fact]
    public void TestStoredTower()
    {
        var result = _controllerGame.GetCountDiskInTower();

        Assert.Equal(new int[] { 3, 0, 0 }, result);
    }
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, -1)]
    [InlineData(6, -1)]
    public void TestChooseFirstTower(int towerId, int resultExpected)
    {
        //Arrange

        //Action
        var resultActual = _controllerGame.ChooseFirstTower(towerId);

        //Assert
        Assert.Equal(resultExpected, resultActual);
    }
    /*
        Hai trường hợp cần kiểm tra trong 
            TestChooseSecondTower: Hợp lệ và không hợp lệ:
            1,Trường hợp Hợp lệ: 2 điều cần
                +TowerId hợp lệ
                +Disk cuối cùng phải có giá trị lớn disk chuyển 
            2,K hợp lệ: còn lại
    */
    [Theory]
    [InlineData(1, 3, 3)]
    [InlineData(2, 1, -1)]
    [InlineData(1, 6, -1)]
    [InlineData(1, 2, 2)]
    public void TestChooseSecondTower(int valueDiskTranfer, int towerId, int resultExpected)
    {
        //Arrange

        //Action
        var resultActual = _controllerGame.ChooseSecondTower(valueDiskTranfer, towerId);

        //Assert
        Assert.Equal(resultExpected, resultActual);
    }
    [Fact]
    public void TestTranferDisk()
    {
        //Arrange
        int towerId1 = 1,towerId2 = 2;
        Tower? tower1 = FindTowerById(towerId1);
        Tower? tower2 = FindTowerById(towerId2);
        Disk lastDisk1 = tower1!.Disks.Last();

        //Act
        var resultActual = _controllerGame.TransferDisk(towerId1, towerId2);
        Disk lastDisk2 = tower2!.Disks.Last();
        //Assert
        Assert.True(resultActual);
        Assert.Equal(lastDisk1,lastDisk2);
    }
    private bool CheckLastDisk()
    {
        return true;
    }
    private Tower? FindTowerById(int towerId)
    {
        var allTower = _game.GetAllTower();
        foreach (var tower in allTower)
        {
            if (tower.TowerId == towerId)
                return tower;
        }
        return null;
    }
}