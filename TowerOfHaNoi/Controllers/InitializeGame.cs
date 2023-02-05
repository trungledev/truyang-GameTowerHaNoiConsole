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

        InitializePropertyGame(numberDisk);
    }
    private void InitializePropertyGame(int numberDisk)
    {
        bool sucessInitTower = InitializeTower(_game, numberDisk);
        bool successInitDisk = InitializeDisk(_game, numberDisk);
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
        if (disks.Count() == numberDisk && disks[0].Value == 1)
            return true;
        return false;
    }

    private bool InitializeTower(Game game, int numberDisk)
    {
        Tower[] towers = new Tower[NUMBER_TOWER];
        for (int i = 0; i < NUMBER_TOWER; i++)
        {
            towers[i] = new Tower()
            {
                TowerId = i + 1,
                Disks = new Disk[numberDisk]
            };
        }
        game.Towers = towers;
        if (game.Towers.Count() != NUMBER_TOWER)
            return false;
        return true;
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
