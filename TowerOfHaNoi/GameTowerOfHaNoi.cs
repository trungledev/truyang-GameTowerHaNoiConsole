using TowerOfHaNoi.Views;
namespace TowerOfHaNoi;

public class GameTowerHaNoi
{
    //Noting setup default
    public GameTowerHaNoi(){}
    public void Run()
    {
        StartGame();
        AssestView.PrintBorderBottom(5);
    }


    private void StartGame()
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