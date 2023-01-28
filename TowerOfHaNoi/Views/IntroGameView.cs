namespace TowerOfHaNoi.Views;

public class IntroGameView 
{
    public IntroGameView()
    {

    }
    public static void ShowIntroGame()
    {
        ShowGameName();
        ShowRuleGame();
    }
    private static void ShowGameName()
    {
        string gameName = "Tower Of Ha Noi";
        string leftMargin = new String(' ', 10);
        string gameStart = leftMargin + gameName;
        Console.WriteLine(gameStart);
    }
    private static void ShowRuleGame()
    {
        string ruleGame = "Rule game: Move all disk in tower1 to tower3";
        Console.WriteLine(ruleGame);
    }
}