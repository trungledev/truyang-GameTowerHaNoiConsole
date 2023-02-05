namespace TowerOfHaNoi.Controllers;

public static class SetupGame
{
    //Setup: tower[0] chứa toàn bộ disk có value khác 0
    //Việc chuyển đổi ở đây chỉ đơn giản là xóa disk tại tower này và thêm vào tower khác 
    public static void SetDefault(ref Game game)
    {
        var numberDisk = game.GetNumberDisk();
        //Add all disk to tower[0] tower1
        var allDisk = game.GetAllDisk();
        var allTowers = game.GetAllTower();
        //Đảo ngược chuỗi vì theo nguyên tắc to nằm dưới
        Array.Reverse(allDisk);
        Disk[] decreaseDisk = allDisk;

        //Thiết lập trực tiếp vào đối tượng tower trong đối tượng game, không cần cầu trung gian
        //Thêm tất cả disk vào tower[0](đối tượng đầu tiên)
        foreach (var tower in allTowers)
        {
            if (tower.TowerId == 1)
                tower.Disks = decreaseDisk;
            else
                tower.Disks = Array.Empty<Disk>();
        }
        game.ChangeAllTower(allTowers);
    }
}