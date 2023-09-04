using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ALLIANCE;
internal class Menu
{
    public static void ListMenu()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Nhập 1: Kiểm tra một số có nằm trong mảng hay không (mảng đã có sẳn)");
        Console.WriteLine("Nhập 2: Kiểm tra thời gian xử lý khi tìm một số có trong mảng (mảng đã có sẳn)");
        Console.WriteLine("Nhập 3: Kiểm tra tiếng mèo kêu");
        Console.WriteLine("Nhập 4: Format lại tên");
        Console.WriteLine("Nhập 5: Xóa mảng trong một phạm vi");
        Console.WriteLine("Nhập 6: Hiển thị tất cả các file hình ảnh");
        Console.WriteLine("Nhập 7: lam việc DB");
        Console.WriteLine("Nhập 99: Kết thúc");
        Console.WriteLine("---------------------------------------------");
    }
}