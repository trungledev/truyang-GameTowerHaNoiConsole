namespace TowerOfHaNoi.Controllers;

public enum TypeAction
{
    SELECT_TOWER,
    RESET_GAME,
    QUIT_GAME
}
public class DataAction
{
    public TypeAction TypeActionUser { get; set; }
    public int FirstTower { get; set; }
    public int SecondTower { get; set; }

}