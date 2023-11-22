using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentDay13
{
    public class Smartphone : IRechargable, IConnectable, IDisplayable
    {
        void IConnectable.Dispay()
        {
            Console.WriteLine("I am an Iconnectable smartphone class");
        }

        void IRechargable.Display()
        {
            Console.WriteLine("I am a smartphone class");
        }

        void IDisplayable.Display()
        {
            Console.WriteLine("I am an IDisplayable smartphone class");
        }
    }
}
