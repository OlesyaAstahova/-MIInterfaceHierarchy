using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        //Использование явной реализации для устранения конфликта имен членов
        void IPrintable.Draw()
        {
            Console.WriteLine("Вывод на принтер");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Вывод на экран...");
        }
        public void Print()
        {
            Console.WriteLine("Печать");
        }
        public int GetNumberOfSides()
        {
            return 4;
        }
    }
}
