
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace Aug25Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            Console.Write("1.Copy in same folder\n2.Copy in diff folder\n3.Delete\n4.Move\n");
            int input=Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    string s =@"C:\Users\saivignesh\";
                    Console.WriteLine("Enter File Names");
                    string m=Console.ReadLine();
                    string t=string.Concat(s,m);
                    string p=Console.ReadLine();
                    string h=string.Concat(s,p);
                    File.Copy(t,h);
                    FileInfo g = new FileInfo(h);
                    Console.WriteLine(g.Extension);
                    Console.WriteLine(g.CreationTime);
                    Console.WriteLine(g.DirectoryName);

                    break;
                case 2:
                    string pr = @"C:\Users\saivignesh\";
                    string jr = @"C:\Users\saivignesh\Desktop\programmed\";
                    Console.WriteLine("Enter File Names");
                    string mr = Console.ReadLine();
                    string rr=Console.ReadLine();
                    string tr = string.Concat(pr,mr);
                    
                    string hr = string.Concat(jr,rr);
                    File.Copy(tr,hr);
                    FileInfo gr = new FileInfo(tr);
                    Console.WriteLine(gr.Extension);
                    Console.WriteLine(gr.CreationTime);
                    Console.WriteLine(gr.DirectoryName);
                    break;
                case 3:
                    string sp = @"C:\Users\saivignesh\";
                    Console.WriteLine("Enter File Names");
                    string mp = Console.ReadLine();
                    string tp = string.Concat(sp, mp);
                    File.Delete(tp);
                    break;
                case 4:
                    string st = @"C:\Users\saivignesh\";
                    Console.WriteLine("Enter File Names");
                    string mt = Console.ReadLine();
                    string tt = string.Concat(st,mt);
                    string pt = Console.ReadLine();
                    string ht = string.Concat(st,pt);
                    File.Move(tt, ht);
                    FileInfo gt = new FileInfo(ht);
                    Console.WriteLine(gt.Extension);
                    Console.WriteLine(gt.CreationTime);
                    Console.WriteLine(gt.DirectoryName);
                    break;
            }
        }
    }
}