namespace TowerOfHaNoi.Views;
/*
    Vì dữ liệu được in từng dòng một từ trái qua phải
        =>Cột sẽ được truy vấn toàn bộ một lượt từ trên xuống
        Với 2 dòng đầu là cột luôn trống 

*/
public static class TowerView
{
    public static void ShowAllTower()
    {
        
    }
    private static void ShowOneTower()
    {

    }
    private static string GetStringOneEmptyTower()
    {
        string spaceLeftRight = new string(' ', MaxMarginY);
        string bodyTower = "*";
        string oneTower = new string(spaceLeftRight + bodyTower + spaceLeftRight);
        return oneTower;
    }
}