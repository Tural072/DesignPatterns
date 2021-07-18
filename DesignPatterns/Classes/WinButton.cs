using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WinButton : Button
    {
        public override void Creat()
        {
            Console.WriteLine("I am Windows Button");
        }
    }
}
