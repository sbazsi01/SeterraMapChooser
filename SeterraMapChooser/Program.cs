using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seterrachooser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SeterraChooser chooser = new SeterraChooser();
            chooser.ChooseMaps();
            Console.ReadLine();
        }
    }
}
