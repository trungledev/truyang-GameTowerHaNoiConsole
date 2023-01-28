namespace TowerOfHaNoi.Models;

/*
    Disk:
        Sử dụng Value như là Id của đối tượng Disk:
            Lý do: để đảm bảo luôn là giá trị của mỗi disk cũng là duy nhất
        Value : Giá trị của disk
        +Quy định với disk có value = 0 tương đương với việc không tồn tại disk tại tower đó
            =>Việc thêm bớt disk được chuyển thành việc thay đổi giá trị disk phù hợp
        +Phải đảm bảo số lượng disk là bảo toàn trong suốt quá trình
*/

public class Disk
{
    public int Value { get; set; }
}


