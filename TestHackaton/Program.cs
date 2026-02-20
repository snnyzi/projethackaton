using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(Hackaton unH in ClassePasserelle.GetLesHackatons())
            Console.WriteLine(unH);
        }
    }
}
