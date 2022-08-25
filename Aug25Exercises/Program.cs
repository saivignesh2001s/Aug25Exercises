
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Aug25Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = @"D:\Sai";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            DirectoryInfo s = new DirectoryInfo(@"D:\Sai");
            for (int i = 0; i < 3; i++)
            {
                String p = Console.ReadLine();
                
                    s.CreateSubdirectory(@p);
                   
                
            }
            string[] fnames=Directory.GetDirectories(@"D:\Sai");
           
            Console.WriteLine(fnames[0]);
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    string k = Console.ReadLine();
                    string v = string.Concat(fnames[i], k);
                    File.Create(@v);
                }
            }
            
            for(int i = 0; i < 3; i++)
            {
                DirectoryInfo pa = new DirectoryInfo(fnames[i]);
                for (int j = 0; j < 12; j++)
                {
                    var p= (Months)j+1;
                    string r = p.ToString();
                    pa.CreateSubdirectory(r);
                    
                }
            }
            for (int i = 0; i < 3; i++)
            {

                DirectoryInfo di = new DirectoryInfo(fnames[i]);
                List<DirectoryInfo> subDirs =
                    di.EnumerateDirectories().OrderBy(d=>d.CreationTime.Millisecond).ToList();
               
            }

            Console.ReadLine();
        }
    }
    enum Months
    {
        Jan=1,
        Feb=2,
        Mar=3,
        Apr=4,
        May=5,
        June=6,
        July=7,
        Aug=8,
        Sep=9,
        Oct=10,
        Nov=11,
        Dec=12
    }
}