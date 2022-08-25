
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace Aug25Exercises
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                Console.WriteLine("C drive info");
                DriveInfo info = new DriveInfo("C");
                Console.WriteLine(info.Name);
                Console.WriteLine(info.TotalSize);
                Console.WriteLine(info.DriveType);
                Console.WriteLine(info.DriveFormat);
                Console.WriteLine("----------------------------");
                DriveInfo[] dinfo = DriveInfo.GetDrives();
                foreach (var item in dinfo)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();
            
        
    

}
    }
}