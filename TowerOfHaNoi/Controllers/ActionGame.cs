namespace TowerOfHaNoi.Controllers;

/*
    Sumary
        Việc chuyển đổi yêu cầu:
            +Tower được lấy phải đảm bảo tồn tại ít nhất 1 đĩa trong đó
            +Disk được lấy phải được xóa tại tower đó 
            +Tower được chuyển phải thêm disk đó
            => Việc cần làm :
                +Kiểm tra tower được chọn có tồn tại ít nhất 1 đĩa không
                +Xóa disk vị trí cuối của tower chọn
                +Thêm disk vào tower mới với điều kiện disk cuối tại tower đó có value nhỏ hơn
*/
public class ActionGame
{
    private Game _game;
    public ActionGame(ref Game game)
    {
        _game = game;
    }
    /*
        Kết quả -1 là tower không hợp lệ 
                0 là kết quả default(lệnh không được thực thi)
                khác các quả trên là tower hợp lệ
    */
    public int[] GetCountDiskInTower()
    {
        var allTower = _game.GetAllTower();
        IList<int> countDisk = new List<int>();
        foreach (var tower in allTower)
        {
            countDisk.Add(tower.Disks.Length);
        }
        return countDisk.ToArray();
    }
    public int ChooseFirstTower(int towerId)
    {
        int reuslt = 0;
        //Xét trường hợp thỏa mãn: tồn tại ít nhất 1 disk
        var towerFound = FindTowerById(towerId);
        if (towerFound != null)
        {
            reuslt = towerId;
            var disks = towerFound.Disks;
            bool existDisk = disks.Length > 0;
            if (existDisk)
                reuslt = towerId;
            else
                reuslt = -1;
        }
        else
            reuslt = -1;
        return reuslt;
    }
    public bool TransferDisk(int towerId1, int towerId2)
    {
        if (towerId1 != towerId2)
        {
            var tower1 = FindTowerById(towerId1);
            var tower2 = FindTowerById(towerId2);
            if (tower1 != null && tower2 != null)
            {
                var lastDiskTower1 = tower1.Disks.Last();
                var result = true;
                //Thực hiện xóa disk đó tại tower1
                //result = tower1.Disks.Remove(lastDiskTower1);
                //Thêm vào tower2
                //tower2.Disks.Add(lastDiskTower1);
                if(!result)
                    Log.WriteLog.WriteLogToFile("Remove disk failed at TransferDisk()");
                return result;
            }
        }
        return false;
    }
    /*
        Lựa chọn tower thứ 2 thõa mãn:
            +TowerId hợp lệ 
            +Không tồn tại đĩa cuối có Value lớn hơn value disk chuyển 
            => Cần cầu nối giữa 2 phương thức 
    */
    public int ChooseSecondTower(int valueDiskTranfer, int towerId)
    {
        int result = 0;
        //Xét trường hợp tower thõa mãn 
        var tower = FindTowerById(towerId);
        if (tower != null)
        {
            var allDisk = tower.Disks;
            if (allDisk.Length == 0)
            {
                return towerId;
            }
            Disk lastDisk = allDisk.Last();
            int valueLastDisk = lastDisk.Value;
            if (valueDiskTranfer < valueLastDisk)
                result = towerId;
            else
                result = -1;
        }
        else
            result = -1;
        return result;
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

    private Disk? FindDiskInTowerByValue(int valueDisk, Tower tower)
    {
        foreach (var disk in tower.Disks)
        {
            if (disk.Value == valueDisk)
                return disk;
        }
        return null;
    }
}