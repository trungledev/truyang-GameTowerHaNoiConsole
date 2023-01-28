namespace TowerOfHaNoi.Tests.Tools;

public static class ToolsForTest
{
    public static int[] ValueAnyDisk(IList<Disk> input)
    {
        IList<int> listValue = new List<int>(); 
        foreach (var disk in input)
        {
            listValue.Add(disk.Value);
        }
        return listValue.ToArray(); 
    }
    public static int[] ValueDisksInTower(Tower input)
    {
       return ValueAnyDisk(input.Disks.ToArray());
    }
}