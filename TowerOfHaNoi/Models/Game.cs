namespace TowerOfHaNoi.Models;

public class Game
{
    //Lưu trữ toàn bộ đĩa 
    public Disk[] Disks { get; set; } = null!;
    //Lưu trữ 3 Cọc 
    public Tower[] Towers { get; set; } = null!;
}