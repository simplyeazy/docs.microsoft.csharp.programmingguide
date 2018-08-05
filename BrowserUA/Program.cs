using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAParser;

namespace BrowserUA
{
    class Program
    {
        static void Main(string[] args)
        {
            string ua = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:59.0) Gecko/20100101 Firefox/59.0";
            Console.WriteLine(Parser.GetDefault().Parse(ua).OS);
            Console.WriteLine(Parser.GetDefault().Parse(ua).UA);
            Console.ReadKey();
        }
    }
}
