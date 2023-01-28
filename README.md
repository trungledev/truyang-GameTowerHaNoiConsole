# TowerOfHaNoi in Console
Tháp Hà Nội
 		Tháp Hà Nội là một bài toán toán học cơ bản để ví dụ về ý nghĩa của đệ quy.
		Trong bài toán này, chúng ta có ba cột (A, B và C) và N đĩa.
		Ban đầu, tất cả các đĩa được xếp chồng lên nhau theo giá trị giảm dần của đường kính, tức là đĩa nhỏ nhất được đặt trên cùng và chúng nằm trên thanh A.
		Mục tiêu của bài toán đó là tìm cách di chuyển toàn bộ chồng đĩa sang một thanh khác (ở đây được coi là C) sử dụng thanh trung gian B
	
Tuân theo quy tắc đơn giản sau:
	Mỗi lần chỉ có thể di chuyển một đĩa.
		Mỗi lần di chuyển sẽ bao gồm việc lấy đĩa trên cùng từ một trong các ngăn xếp và đặt nó lên trên một ngăn xếp khác, tức là chỉ có thể di chuyển một đĩa nếu nó là đĩa trên cùng trong một ngăn xếp.
		Không được đặt đĩa to trên một đĩa nhỏ hơn.

	Một số quy định về lưu trữ và thứ tự:
		Một cọc sẽ lưu giá trị theo tỷ lệ nghịch với index(chỉ mục) của phần tử
		Vd: Với cột 1 mặc định chứa các đĩa: [disk3,disk2,disk1] với disk3 là ở đáy và disk1 ở trên đầu
	
	Chú thích tiếng anh:
		Disk : Đĩa
		Tower : Cọc
		LeftMargin : Lề trái
	Giới hạn số đĩa trong khoảng lớn hơn [3  5]

-Hiển thị minh họa:

       *        *        *                *        *        * 
       *        *        *                *        *        *
      xxx       *        *        =>      *        *        *
     xxxxx      *        *                *        *        *
    xxxxxxx     *        *             xxxxxxx    xxx     xxxxx
----------------------------------  -----------------------------------
-Hành động: 
    Lấy từ : => Input Number => 1
    Chuyển sang: 3
    Gửi thông tin trả về kết quả của hành động
    --Refesh Display--
    => Continue lặp lại từ mục hành động
    ....
