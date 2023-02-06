namespace TowerOfHaNoi.Controllers;

public class GameController : Controller
{
    private Game _game = new Game();
    private TowerController _towerController = new TowerController();
    private UserController _userController = new UserController();
    public void Start()
    {
        string nameGame = "\t Game Tower of HaNoi \n";
        string ruleGame = "Rule game: Move all disk in tower1 to tower3";
        string introGame = nameGame + ruleGame;
        //Call to View Introduction Game
        View(new object[] { introGame });

        //Initialize Game
        InitializeGameDefalut();
        Body();
    }
    public void InitializeGameDefalut()
    {
        InitializeGame initializeGame = new InitializeGame();
        _game = initializeGame.Create();
    }
    public void Body()
    {
        _towerController.ShowAllTower(_game);
        _userController.ActionUserFirst();
    }
}