using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentDay13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop lap = new Laptop();
            IConnectable connectable = lap;
            connectable.Dispay();
            IRechargable rechargable = lap;
            rechargable.Display();
            IDisplayable dispayable = lap;
            dispayable.Display();
            Smartphone smt = new Smartphone();
            IConnectable connectable1 = smt;
            connectable1.Dispay();
            IDisplayable connectable2 = smt;
            connectable2.Display();
            IRechargable connectable3 = smt;
            connectable3.Display();
            Console.ReadKey();

        }
    }
}
