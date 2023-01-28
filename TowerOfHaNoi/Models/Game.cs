namespace TowerOfHaNoi.Models;

public class Game
{
    //Khoảng khoảng cách lớn nhất của 1 cọc về 1 phía
    private int MaxMarginY { get; set; }
    private int NumberDisk { get; set; }
    private int NumberTower { get; set; }
    //Lưu trữ toàn bộ đĩa 
    private Disk[] Disks { get; set; } = null!;
    //Lưu trữ 3 Cọc 
    private Tower[] Towers { get; set; } = null!;


    public Game(int numberTower, int numberDisk)
    {
        NumberTower = numberTower;
        NumberDisk = numberDisk;
        //Khởi tạo mặc định các đối tượng : Disk, Tower, Value of Disk
        if (numberDisk != 0)
        {
            Disks = InitializeDisks(NumberDisk);
        }
        else
        {

        }
        Towers = InitializeTowersEmpty(NumberTower);
        MaxMarginY = NumberDisk + 1;
    }
    public bool SetNumberDisk(int numberDisk)
    {
        NumberDisk = numberDisk;
        if (NumberDisk != 0)
        {
            Disks = InitializeDisks(NumberDisk);
            if(Disks.Length == NumberDisk)
                return true;
        }
        return false;
    }
    public int GetNumberDisk()
    {
        return NumberDisk;
    }
    public Tower[] GetAllTower()
    {
        return Towers;
    }
    public Disk[] GetAllDisk()
    {
        return Disks;
    }
    public void ChangeAllTower(Tower[] towers )
    {
        Towers = towers;
    }
    private Tower[] InitializeTowersEmpty(int numberTower)
    {
        IList<Tower> towers = new List<Tower>();
        for (int i = 0; i < numberTower; i++)
        {
            towers.Add(new Tower()
            {
                TowerId = i + 1,
                Disks = new Disk[NumberDisk]
            });
        }
        return towers.ToArray();
    }
    private Disk[] InitializeDisks(int numberDisk)
    {
        IList<Disk> disks = new List<Disk>();
        for (var i = 0; i < numberDisk; i++)
        {
            disks.Add(new Disk()
            {
                Value = i + 1
            });
        }
        return disks.ToArray();
    }
}