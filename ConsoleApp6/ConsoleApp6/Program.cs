using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt(n) % 1 == 0) 
                Console.WriteLine("yes");
              else 
                Console.WriteLine("no");
            
            
            
        }
    }
}
echo "# C-Khuisf" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/Rezaniknami/C-Khuisf.git
git push -u origin main