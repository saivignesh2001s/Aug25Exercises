
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace Aug25Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            do
            {
                Console.Write("1.ADD\n2.APPEND\n3.TRUNCATE\n4.READ\n");
                string input = Console.ReadLine();
                Console.WriteLine("EnterFilename");
                string p = Console.ReadLine();
                switch (input)
                {
                    case "ADD":
                        if (File.Exists(p))
                        {
                            Console.WriteLine("File already exists");
                        }
                        else
                        {

                            FileStream fs = new FileStream(p, FileMode.CreateNew, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine("I am sai vignesh");
                            fs.Flush();
                            sw.Close();
                            fs.Close();
                            sw.Dispose();
                            fs.Dispose();
                        }
                        break;
                    case "APPEND":
                        FileStream gs = new FileStream(p, FileMode.Append, FileAccess.Write);
                        StreamWriter gw = new StreamWriter(gs);
                        gw.WriteLine("I am saivignesh");
                        gs.Flush();
                        gw.Close();
                        gs.Close();
                        gw.Dispose();
                        gs.Dispose();

                        break;
                    case "TRUNCATE":
                        FileStream ps = new FileStream(p, FileMode.Truncate, FileAccess.Write);
                        StreamWriter pw = new StreamWriter(ps);
                        pw.WriteLine(" ");
                        ps.Flush();
                        pw.Close();
                        ps.Close();
                        pw.Dispose();
                        ps.Dispose();

                        break;
                    case "READ":
                        if (!File.Exists(p))
                        {
                            Console.Write("File does not exist");
                        }
                        else
                        {
                            FileStream ms = new FileStream(p, FileMode.Open, FileAccess.Read);
                            StreamReader mw = new StreamReader(ms);
                            string h = mw.ReadToEnd();
                            Console.WriteLine(h);

                            ms.Flush();
                            mw.Close();
                            ms.Close();
                            mw.Dispose();
                            ms.Dispose();
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter 1 to Continue");
                int k = Convert.ToInt32(Console.ReadLine());
                flag = k;
            } while (flag != 0);
            Console.ReadLine();
        }
    }
}