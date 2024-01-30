using System.Text;

namespace TowerOfHaNoi.Controllers;

public class TowerController : Controller
{
    public void ShowAllTower(Tower[] towers)
    {
        var allTower = towers;
        StringBuilder builder = new StringBuilder();
        builder.Append("\n");
        int numberDisk = allTower[0].Disks.Length - 2;
        int maxMarginY = numberDisk * 2 + 2;
        int storeDisk = numberDisk + 2;
        for (int j = storeDisk - 1; j >= 0; j--)
        {
            int valueDiskExist = 0;
            for (int i = 0; i < allTower.Length; i++)
            {
                var valueDisk = allTower[i].Disks[j].Value;
                if (valueDisk == 0)
                {
                    builder.Append( new string(' ', maxMarginY - valueDiskExist) + "*");
                    valueDiskExist = 0;
                }
                else
                {
                    builder.Append( new string(' ', maxMarginY - valueDisk) + new string('x', valueDisk * 2 + 1));
                    valueDiskExist = valueDisk;
                }

                if (i == allTower.Length - 1)
                    builder.Append( "\n");

            }
        }
        View(new object[] { builder.ToString() });
    }
    //Nen tach viec xac thuc tung number tower 
    public bool VerificationSelectTower(Tower[] towers, int firstTower, int secondTower)
    {
        //Must firstTower != secondTower
        if(firstTower == secondTower)
        {
            //Not valid secondTower
            
        }
        Disk[] disksFirstTower = towers[firstTower].Disks;
        Disk[] disksSecondTower = towers[secondTower].Disks;
        //Get last disk first tower
        int indexLastFirst = GetIndexLastDisk(disksFirstTower);
        int indexLastSecond = GetIndexLastDisk(disksSecondTower);
        bool isValid;
        try
        {
            isValid = disksFirstTower[indexLastFirst].Value < disksSecondTower[indexLastSecond].Value;
        }
        catch (Exception ex)
        {
            isValid = false;
            WriteLog.WriteLogToFile(ex.Message + " in verificationSelectTower");
        }
        return isValid;
    }
    public Tower[] ChangeDisk(Tower[] towers, int firstTower, int secondTower)
    {
        if (towers == null)
            WriteLog.WriteLogToFile("Tower is null. in ChangeDisk() TowerController");
        //Remove last disk at firstTower <=> set value = 0;
        //Find lastDisk at firstTower
        Disk[] disksFirstTower = towers![firstTower].Disks;
        int valueDiskLast = 0;
        int indexDiskLast = 0;
        for (int i = 0; i < disksFirstTower.Length; i++)
        {
            if (disksFirstTower[i].Value == 0)
            {
                if (i > 1)
                {
                    indexDiskLast = i - 1;
                    valueDiskLast = disksFirstTower[indexDiskLast].Value;
                    towers[firstTower].Disks.ElementAt(indexDiskLast).Value = 0;
                    break;
                }
            }
        }

        //Add value to second Tower
        Disk[] disksSecondTower = towers[secondTower].Disks;
        for (int i = 0; i < disksSecondTower.Length; i++)
        {
            if (disksSecondTower[i].Value == 0 && valueDiskLast != 0)
            {
                disksSecondTower[i].Value = valueDiskLast;
                break;
            }
        }

        return towers;
    }
    private int GetIndexLastDisk(Disk[] disks)
    {
        int indexDiskLast = -1;
        for (int i = 0; i < disks.Length; i++)
        {
            if (disks[i].Value == 0)
            {
                if (i > 1)
                {
                    indexDiskLast = i - 1;
                    break;
                }
            }
        }
        return indexDiskLast;
    }
}