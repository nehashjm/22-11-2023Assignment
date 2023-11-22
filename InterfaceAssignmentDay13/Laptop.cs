using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentDay13
{
    public class Laptop : IConnectable, IRechargable, IDisplayable
    {
        void IConnectable.Dispay()
        {
            Console.WriteLine("I am an Iconnectable Laptop class");
        }

        void IRechargable.Display()
        {
            Console.WriteLine("I am an IRechargable Laptop class");
        }

        void IDisplayable.Display()
        {
            Console.WriteLine("I am an IDisplayable Laptop class");
        }
    }
}
