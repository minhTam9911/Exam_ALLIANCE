using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_ALLIANCE.Option3;
internal class FormatName
{

    public static string FormatString(string name)
    {
        name = name.ToLower();
        name = Regex.Replace(name, "[`~!@#$%^&*()_+={}:;',<>.?“”/]", "");
        name = Regex.Replace(name.Trim(), @"\b(\w)", m => m.Value.ToUpper());
        name = Regex.Replace(name, @"\s+", " ");
        Console.WriteLine(name);
        return name;
    }
}
