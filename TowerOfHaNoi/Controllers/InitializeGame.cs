namespace TowerOfHaNoi.Controllers;

/* 
    Sumary
    Nhiệm vụ chính :
        +Khởi tạo
            +Game
            +Các đối tượng 
            +Các thuộc tính 
*/
public class InitializeGame
{
    //Khai báo hằng số 
    private const int NUMBER_TOWER = 3;
    private const int MAX_DISK = 5;
    private const int MIN_DISK = 3;
    private Game _game;
    private UserController _userController = new UserController();
    //Việc khởi tạo ứng dụng thực nghiệm được chuyển hướng tại đây
    /*
        Sẽ truyền giá trị numberDisk theo THợp:
            +Testing: được truyền vào theo hàm tạo
            +Playing(thợp còn lại): thông qua ReadLine của console
    */
    public InitializeGame()
    {
        _game = new Game();

        //Get int number disk
        int numberDisk = 0;
        numberDisk = _userController.GetNumberDiskValid();

        InitializePropertyGame(_game, numberDisk);
    }
    private void InitializePropertyGame(Game game, int numberDisk)
    {
        bool sucessInitTower = InitializeTower(game, numberDisk);
        bool successInitDisk = InitializeDisk(game, numberDisk);
        if (!sucessInitTower && !successInitDisk)
        {
            WriteLog.WriteLogToFile("Init failed");
        }
    }
    private bool InitializeDisk(Game game, int numberDisk)
    {
        Disk[] disks = new Disk[numberDisk];
        for (int i = 0; i < numberDisk; i++)
        {
            disks[i] = new Disk()
            {
                Value = i + 1
            };
        }
        game.Disks = disks;
        if (disks.Count() == numberDisk && disks[0].Value == 1)
            return true;
        return false;
    }

    private bool InitializeTower(Game game, int numberDisk)
    {
        Tower[] towers = new Tower[NUMBER_TOWER];
        for (int i = 0; i < NUMBER_TOWER; i++)
        {
            if (i == 0)
            {
                towers[0] = new Tower()
                {
                    TowerId = 1,
                    Disks = SetFullDisks(numberDisk)
                };
                continue;
            }
            towers[i] = new Tower()
            {
                TowerId = i + 1,
                Disks = SetDisksZeroValue(numberDisk)
            };
        }

        game.Towers = towers;
        if (game.Towers.Count() != NUMBER_TOWER)
            return false;
        return true;
    }

    private Disk[] SetFullDisks(int numberDisk)
    {
        Disk[] disks = new Disk[numberDisk + 2];
        for (int i = 0; i < numberDisk + 2; i++)
        {
            disks[i] = new Disk()
            {
                Value = (numberDisk - i) > 0 ? numberDisk - i : 0
            };
        }
        return disks;
    }

    private Disk[] SetDisksZeroValue(int numberDiks)
    {
        int numberDiskStore = numberDiks + 2;
        Disk[] disks = new Disk[numberDiskStore];
        for (int i = 0; i < numberDiskStore; i++)
        {
            disks[i] = new Disk()
            {
                Value = 0
            };
        }

        return disks;
    }
    private bool VerificationNumberDisk(int input)
    {
        return input >= MIN_DISK && input <= MAX_DISK;
    }

    internal Game Create()
    {
        return _game;
    }
}
