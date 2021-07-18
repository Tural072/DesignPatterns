using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class WinChekbox : Chekbox
    {
        public override void Creat()
        {
            Console.WriteLine("I am Windows Checkbox");
        }
    }
}
