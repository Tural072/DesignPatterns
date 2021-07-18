using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MacFactory : IGuiFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public Chekbox CreateChekbox()
        {
            return new MacChekbox();
        }
    }
}
