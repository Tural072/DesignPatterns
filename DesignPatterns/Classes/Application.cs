using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Application
    {
        private IGuiFactory Factory;
        private Button Button;
        private Chekbox Chekbox;
        public Application(IGuiFactory factory)
        {
            Factory = factory;
        }
        public void CreaUI()
        {
            Button = Factory.CreateButton();
            Chekbox = Factory.CreateChekbox();
        }
        public void Creat()
        {
            Button.Creat();
            Chekbox.Creat();
        }
    }
}
