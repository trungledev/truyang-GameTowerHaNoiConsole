namespace TowerOfHaNoi.Views;

public class GetNumDiskView
{
    public static void StartGame()
    {
        ShowMessageAction();
        InitializeGameConsole();
    }
    private static void ShowMessageAction()
    {
        string leftMargin = new String(' ', 10);
        string message = "Action Start Game";
        //string messageInputNumberDisk = "Please enter the number of disk from 3 to 5";
        Console.WriteLine(leftMargin + message);//+ messageInputNumberDisk);
    }
    private static void InitializeGameConsole()
    {
        InitializeGame initializeGame = new InitializeGame();
    }
}