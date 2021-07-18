using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class LinuxFactory : IGuiFactory
    {
        public Button CreateButton()
        {
            return new LinuxButton();
        }

        public Chekbox CreateChekbox()
        {
            return new LinuxChekbox();
        }
    }
}
