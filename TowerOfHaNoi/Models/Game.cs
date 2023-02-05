namespace TowerOfHaNoi.Models;

public class Game
{
    //Khoảng khoảng cách lớn nhất của 1 cọc về 1 phía
    public int MaxMarginY { get; set; }
    public int NumberDisk { get; set; }
    public int NumberTower { get; set; }
    //Lưu trữ toàn bộ đĩa 
    public Disk[] Disks { get; set; } = null!;
    //Lưu trữ 3 Cọc 
    public Tower[] Towers { get; set; } = null!;
}