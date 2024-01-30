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
        InitializeGameDefault();
        Body();
    }
    private void InitializeGameDefault()
    {
        InitializeGame initializeGame = new InitializeGame();
        _game = initializeGame.Create();
    }
    public void Body()
    {
        _towerController.ShowAllTower(_game.Towers);
        var dataAction = _userController.ActionUserFirst();
        ActionGame(dataAction);
    }
    private void ActionGame(DataAction dataAction)
    {
        switch (dataAction.TypeActionUser)
        {
            case TypeAction.SELECT_TOWER:
                //Change Disk in tower
                _game.Towers = _towerController.ChangeDisk(_game.Towers, dataAction.FirstTower, dataAction.SecondTower);
                break;
            case TypeAction.RESET_GAME:
                InitializeGameDefault();
                break;
            case TypeAction.QUIT_GAME:
                EndGame();
                break;
        }

    }
    private void ShowResultAction()
    {

    }
    private void EndGame()
    {
        throw new NotImplementedException();
    }
}