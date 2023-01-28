namespace TowerOfHaNoi.Services;

public class DisksTower
{
    //Đếm số disk có value khác 0 tương đương số count disk đang tồn tại trong tower
    public static int GetCountDiskInTower(Tower tower)
    {
        Disk[] diskArr = tower.Disks;
        int count = 0;
        foreach (var disk in diskArr)
        {
            if (disk.Value != 0)
                count++;
        }
        return count;
    }
}