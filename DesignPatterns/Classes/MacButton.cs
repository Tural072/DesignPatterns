using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MacButton : Button
    {
        public override void Creat()
        {
            Console.WriteLine("I am Mac Button");
        }
    }
}
