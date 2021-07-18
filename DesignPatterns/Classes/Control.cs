using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns
{
    static class Control
    {
        static public void Run()
        {

            try
            {
                while (true)
                {
                    IGuiFactory guiFactory;
                    Console.WriteLine("1)Windows chekbox and button");
                    Console.WriteLine("2)Mac chekbox and button");
                    Console.WriteLine("3)Linux chekbox and button");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        guiFactory = new WinFactory();
                    }
                    else if (a == 2)
                    {
                        guiFactory = new MacFactory();
                    }
                    else if (a == 3)
                    {
                        guiFactory = new LinuxFactory();
                    }
                    else
                    {
                        throw new Exception();
                    }
                    Application application = new Application(guiFactory);
                    application.CreaUI();
                    application.Creat();
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong selection!");
                Thread.Sleep(1000);
                Console.ResetColor();
                Console.Clear();
                Control.Run();
            }
        }
    }
}
