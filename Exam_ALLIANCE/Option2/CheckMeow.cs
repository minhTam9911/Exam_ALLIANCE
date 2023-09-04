using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_ALLIANCE.Option2;
internal class CheckMeow
{

    public static bool CheckCaterwaul()
    {

        Console.WriteLine("Nhập tiếng mèo kêu: ");
        var x = Console.ReadLine();
        var regex = new Regex(@"^m{1,}e{1,}o{1,}w{1,}$", RegexOptions.Compiled);
        if (regex.IsMatch(x))
        {
            Console.WriteLine("Được xem là tiếng mèo kêu");
        }
        else
        {
            Console.WriteLine("Không được xem là tiếng mèo kêu");
        }
        return regex.IsMatch(x);
    }
}
