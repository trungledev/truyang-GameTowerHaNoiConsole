namespace TowerOfHaNoi.Controllers;

public class TowerController : Controller
{
    public void ShowAllTower(Game game)
    {
        var allTower = game.Towers;
        string contentAllTower = "\n";
        int numberDisk = game.Disks.Count();
        int maxMarginY = numberDisk*2 + 2;
        int storeDisk = numberDisk + 2;
        for (int j = storeDisk - 1; j >= 0; j--)
        {
            int valueDiskExist = 0;
            for (int i = 0; i < allTower.Count(); i++)
            {
                var valueDisk = allTower[i].Disks[j].Value;
                if (valueDisk == 0)
                {
                    contentAllTower += new string(' ', maxMarginY - valueDiskExist) + "*";
                    valueDiskExist = 0;
                }
                else
                {
                    contentAllTower += new string(' ', maxMarginY - valueDisk) + new string('x', valueDisk * 2 + 1);
                    valueDiskExist = valueDisk;
                }

                if (i == allTower.Count() - 1)
                    contentAllTower += "\n";

            }
        }
        View(new object[] { contentAllTower });
    }
}