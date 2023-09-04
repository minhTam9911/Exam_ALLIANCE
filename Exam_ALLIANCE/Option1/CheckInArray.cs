using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Exam_ALLIANCE.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exam_ALLIANCE.Option1;
internal class CheckInArray
{
    public int[] A;
    public int size;
    public int n;
    //public List<int> Input(int size)
    //{
    //    this.size = size;
    //    List<int> A = new List<int>();
    //    for (int i = 1; i <= size; i++)
    //    {
    //        Console.WriteLine("Nhập giá trị thứ " + i + " : ");
    //        int value = int.TryParse(Console.ReadLine(), out int result2) ? result2 : 0;
    //        A.Add(value);
    //    }
    //    this.A = A;
    //    return A;
    //}

    public bool CheckNumInArray(int[] A, int size, int n)
    {
        var check = A.FirstOrDefault(x => x == n);
        return check != 0 ? true : false;
    }

    public void UseCheckumNInArray()
    {
        var totalThread = 8;
        var sizeFor = 1000000 / totalThread;
        for (var i = 0; i < 1000000; i += sizeFor)
        {
            ThreadPool.QueueUserWorkItem(x =>
            {
                var start = (int)x;
                var end = start + sizeFor - 1;
                for (var j = start; j <= end; j++)
                {
                    bool check = CheckNumInArray(this.A, this.size, j);
                    //if (check)
                    //{
                    //    Console.WriteLine(check.ToString() + "  " + j);
                    //}
                }
            }, i);
        }
    }

    public int[] DeleteIndexInArray(int[] A, int index)
    {
        List<int> listInt = A.ToList();
        listInt.RemoveAt(index);
        A = listInt.ToArray();
        return A;
    }
    public  int[] DeleteRangeIndexInArray(int[] A, int fromIndex, int toIndex)
    {
        if (toIndex >= fromIndex)
        {
            int[] arrayA = A;
            for (int i = fromIndex; i <= toIndex; i++)
            {
                arrayA = DeleteIndexInArray(arrayA, fromIndex);
            }
            return arrayA;
        }
        else
        {
            Console.WriteLine("Xoa That Bai! Vui long nhap gia trị hợp lệ.");
            return A;
        }
    }


    

}
