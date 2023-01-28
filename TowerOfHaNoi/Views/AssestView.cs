namespace TowerOfHaNoi.Views;

/*
    +Tạo lớp cho lớp khác kế thừa 
    +Các lớp con sẽ được gọi tại thành phần body của lớp cha
*/
public static class AssestView
{
    public static void PrintBorderBottom(int maxValueDisk)
    {
        string border = new String('-', 6 * maxValueDisk + 6);
        Console.WriteLine(border);
    }
}