using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testing1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"G:\test folder");
            int c1 = 0, c2 = 0, c3 = 0;
            
            // Check the naming conventions
            // https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions
            
            Class1 fm = new Class1();
            foreach (FileInfo flInfo in dir.GetFiles())
            {
                fm.FileName = flInfo.Name;
                c1++;
                fm.FileSize = flInfo.Length;
                if (fm.FileSize > 5)
                    c2++;
                fm.FileTime = flInfo.CreationTime;
                fm.FileExtension = flInfo.Extension;
                if (fm.FileExtension.Equals(".txt"))
                    c3++;
                Console.WriteLine("{0}  {1}  {2}  {3}", fm.FileName, fm.FileSize, fm.FileTime, fm.FileExtension);
            }
            Console.WriteLine();
            Console.WriteLine("The total number of files are : {0}", c1);
            Console.WriteLine("Number of files having length more than 5 are : {0}", c2);
            Console.WriteLine("Number of files having txt extension are : {0}", c3);
            Console.ReadLine();
        }
    }
}
