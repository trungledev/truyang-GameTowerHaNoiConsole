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
    //Việc khởi tạo ứng dụng thực nghiệm được chuyển hướng tại đây
    /*
        Sẽ truyền giá trị numberDisk theo THợp:
            +Testing: được truyền vào theo hàm tạo
            +Playing(thợp còn lại): thông qua ReadLine của console
    */
    public InitializeGame(EnvironmentGame environment, int numberDisk)
    {
        _game = new Game(NUMBER_TOWER, numberDisk);
        if (environment == EnvironmentGame.Testing)
        {
            bool sucessSetNumberDisk = _game.SetNumberDisk((int)numberDisk);
            if (!sucessSetNumberDisk)
                WriteLog.WriteLogToFile("Set number disk false");

        }
    }
    public InitializeGame()
    {
        _game = new Game(NUMBER_TOWER, 0);
        bool sucessSetNumberDisk = _game.SetNumberDisk(GetNumberDiskConsole());
        if (!sucessSetNumberDisk)
            WriteLog.WriteLogToFile("Set number disk false");

    }
    public Game CreateGameTest()
    {
        return _game;
    }
    public Game CreateGame()
    {
        //Display.DisplayStartMenu();
        return _game;
    }
    private int GetNumberDiskConsole()
    {
        string messageGetNumber = "Get number disk: (Please press number 3 to 5)";
        int input = GetNumberConsole(messageGetNumber);
        while (!VerificationInput(input))
        {
            Console.WriteLine(input + " not validable press again ");
            input = GetNumberConsole(messageGetNumber);
        }
        Console.WriteLine("Number disk is: " + input);
        return input;
    }

    private bool VerificationInput(int input)
    {
        return input >= MIN_DISK && input <= MAX_DISK;
    }

    //Lấy các số từ người dùng qua Console.Read()
    private int GetNumberConsole(string message)
    {
        Console.WriteLine(message);
        var input = Console.ReadLine();
        int number;
        int.TryParse(input, out number);
        return number;
    }
}
