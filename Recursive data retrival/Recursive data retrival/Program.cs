using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_data_retrival
{
    class Program
    {
            static void Main(string[] args)
            {
                List<string> route = new List<string>();

                FindAllFilesOfType("C:\\temp\\random", route, ".txt");
                foreach (string s in route)
                {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
            }
            static void FindAllFilesOfType(string path, List<string> paths, string extension)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.Extension == extension)
                    paths.Add(file.FullName);
            }
                DirectoryInfo[] direct = dir.GetDirectories();
                foreach (DirectoryInfo item in direct)
                {
                    FindAllFilesOfType(item.FullName, paths, extension);
                }
            }
        }
    }