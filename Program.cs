using System;

namespace DemoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
           Core.Saludar();
           Core core=new Core();
           core.Despedir();
           
        }
    }
}
