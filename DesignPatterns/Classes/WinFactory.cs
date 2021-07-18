using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class WinFactory : IGuiFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public Chekbox CreateChekbox()
        {
            return new WinChekbox();
        }
    }
}
