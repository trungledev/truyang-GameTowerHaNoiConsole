using TowerOfHaNoi.Views;
namespace TowerOfHaNoi;

public class GameTowerHaNoi
{
    private Game _game = null!;
    //Noting setup default
    public GameTowerHaNoi(){}
    public void Run()
    {
        HeadGame();
        AssestView.PrintBorderBottom(5);
        BodyGame();
    }


    private void HeadGame()
    {
        IntroGameView.ShowIntroGame();
        GetNumDiskView.StartGame();
    }
    private void BodyGame()
    {
        TowerView.ShowAllTower();
    }
    private void EndGame()
    {

    }
}