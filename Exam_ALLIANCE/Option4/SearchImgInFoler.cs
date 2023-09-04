using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ALLIANCE.Option4;
internal class SearchImgInFoler
{
    public static List<string> SubFodlerImage(string pathOfFolder)
    {
        List<string> listImageFile = new List<string>();
        string[] fileExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        IEnumerable<string> findAllFileImages = 
            Directory.EnumerateFiles(pathOfFolder, "*.*", SearchOption.AllDirectories)
                                    .Where(file => fileExtensions.Contains(Path.GetExtension(file).ToLowerInvariant()));

        foreach(var filePath in findAllFileImages)
        {
            string fileName = Path.GetFileName(filePath);
            listImageFile.Add(fileName);
        }
        
        return listImageFile;

    }
}
