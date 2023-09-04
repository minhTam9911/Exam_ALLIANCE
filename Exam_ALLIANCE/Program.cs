using Exam_ALLIANCE;
using Exam_ALLIANCE.Models;
using Exam_ALLIANCE.Option1;
using Exam_ALLIANCE.Option2;
using Exam_ALLIANCE.Option3;
using Exam_ALLIANCE.Option4;
using Exam_ALLIANCE.WorkDB;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;


Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 77777, 88888, 99999, 11111, 22222, 33333, 44444, 55555, 66666, 101010 };
int[] B;
int size = A.Length;
int n;
var checkInArray = new CheckInArray();
while (true)
{
    Menu.ListMenu();
    Console.WriteLine("Nhập lựa chọn của bạn: ");
    var choose = int.TryParse(Console.ReadLine(), out int option) ? option : 0;
    
    switch (choose)
    {
        case 1:
            Console.WriteLine("Nhập số bạn muốn kiểm tra: ");
            n = int.TryParse(Console.ReadLine(), out int result1) ? result1 : 0;
            checkInArray.CheckNumInArray(A, size, n);
            break;
        case 2:
            checkInArray.A = A;
            checkInArray.size = A.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            checkInArray.UseCheckumNInArray();
            stopwatch.Stop();
            Console.WriteLine($"Thời gian thực thi: {stopwatch.ElapsedMilliseconds} ms");
            break;
        case 3:
            CheckMeow.CheckCaterwaul();
            break;
        case 4:
            List<string> names = new List<string>();
            names.Add("Nguyễn  vAn Thanh");
            names.Add("  trần  thị Nhung");
            names.Add("Huỳnh Thúc Điền.");
            names.Add("“Lê van  NaM”");
            foreach (var name in names)
            {
                FormatName.FormatString(name);
            }
            break;

        case 5:

            Console.WriteLine("Nhập vị trí bạn muốn bắt đầu xóa: ");
            int fromIndex = int.TryParse(Console.ReadLine(), out int result5) ? result5 : 0;
            Console.WriteLine("Nhập vị trí bạn muốn kết thúc xóa: ");
            int toIndex = int.TryParse(Console.ReadLine(), out int result4) ? result4 : 0;
            var dataa = checkInArray.DeleteRangeIndexInArray(A, fromIndex, toIndex);
            Console.WriteLine("Mang sau khi đã xóa là : ");
            foreach (var item in dataa)
            {
                Console.WriteLine(item);
            }
            break;
        case 6:
            Console.WriteLine("Vui lòng nhập đường dẫn foler : ");
            var pathOfFolder = Console.ReadLine();
            var data = SearchImgInFoler.SubFodlerImage(pathOfFolder);
            Console.WriteLine("Các file ảnh là: ");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            break;
        case 7:
            var db = new DBWorking();
            Stopwatch stopwatchX = new Stopwatch();
            List<Department> listDepartment = db.GetAllDepartment();
            List<Staff> listStaff = db.GetStaff();
            stopwatchX.Start();
            foreach (var item in listStaff)
            {
               var dep = db.GetDepartment(item.DepartmentId);
                item.DepartmentName = dep.Name;
            }
            stopwatchX.Stop();
            Console.WriteLine($"Thời gian thực thi chưa tối ưu: {stopwatchX.ElapsedMilliseconds} ms");
            Stopwatch stopwatchX2 = new Stopwatch();
            stopwatchX2.Start();

            foreach (var item in listStaff)
            {
                var dep = listDepartment.FirstOrDefault(x => x.Id == item.DepartmentId);
                item.DepartmentName = dep.Name;
            }
            stopwatchX2.Stop();
            Console.WriteLine($"Thời gian thực thi đã tối ưu: {stopwatchX2.ElapsedMilliseconds} ms");
            break;
        default:
            break;
        case 99:
            return;
    }
    Console.WriteLine("---------------------------------------------");
}









