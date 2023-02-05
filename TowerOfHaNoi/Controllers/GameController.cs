namespace TowerOfHaNoi.Controllers;

public class GameController : Controller
{
    private Game _game = new Game();
    private int _numberDisk;
    public void Start()
    {
        string nameGame = "\t Game Tower of HaNoi \n";
        string ruleGame = "Rule game: Move all disk in tower1 to tower3";
        string introGame = nameGame + ruleGame;
        //Call to View Introduction Game
        View(new object[] { introGame });

        //Initialize Game
        InitializeGame initializeGame = new InitializeGame();
        _game = initializeGame.Create();
    }
}