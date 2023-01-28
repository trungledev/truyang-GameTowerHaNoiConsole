namespace TowerOfHaNoi.Models;

/*
    Tower:
        TowerId : Xác nhận tính duy nhất của tower
        Disks : Vùng chứa các disk đang nằm trong tower
            Disk sẽ chúa trong mảng tại tower
*/

public class Tower
{
    public int TowerId { get; set; }
    public Disk[] Disks { get; set; } = null!;
}