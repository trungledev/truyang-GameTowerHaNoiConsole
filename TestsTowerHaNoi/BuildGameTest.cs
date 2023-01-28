public class BuildTowerGameTest
{
    const int NUMBER_TOWER = 3;
    protected Game _game;
    private int NumberDisk { get; set; }
    public BuildTowerGameTest(int numberDisk)
    {
        NumberDisk = numberDisk;
        var initGame = new InitializeGame(EnvironmentGame.Testing, numberDisk);
        _game = initGame.CreateGameTest();
    }
    protected Disk[] GetAllDisk()
    {
        return _game.GetAllDisk();
    }
    protected int GetNumberDiskInput()
    {
        return NumberDisk;
    }
    protected int GetNumberTowerInput()
    {
        return NUMBER_TOWER;
    }
    protected int[] ValueDisksExpected()
    {
        IList<int> valueDiskList = new List<int>();
        for (int i = 1; i <= NumberDisk; i++)
        {
            valueDiskList.Add(i);
        }
        return valueDiskList.ToArray();
    }
    protected int[] IdTowersExpected()
    {
        IList<int> valueDiskList = new List<int>();
        for (int i = 1; i <= NUMBER_TOWER; i++)
        {
            valueDiskList.Add(i);
        }
        return valueDiskList.ToArray();
    }
}