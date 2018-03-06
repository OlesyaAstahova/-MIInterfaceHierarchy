using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    interface IDrawable
    {
        void Draw();
    }
    interface IPrintable
    {
        void Draw(); //Возможен конфликт имен
        void Print();
    }
    //Множественное наследование интерфейсов. Ок
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** MI Interface Hierarchy *****\n");
            Square mySquare = new Square();
            IPrintable t=(IPrintable)mySquare;
            t.Draw();
            IDrawable p = (IDrawable)mySquare;
            p.Draw();
            mySquare.Print();
            Console.WriteLine(mySquare.GetNumberOfSides());
            Console.WriteLine("\n");

            Rectangle Rec = new Rectangle();
            Rec.GetNumberOfSides();
            Rec.Draw();
            Rec.Print();
            Console.WriteLine(Rec.GetNumberOfSides());
            Console.ReadLine();
        }
    }
}
