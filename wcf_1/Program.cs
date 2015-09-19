using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace wcf_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WSHttpBinding b = new WSHttpBinding();

            Console.WriteLine("Анализируемая привязка {0} состоит из:", b.GetType().Name);

            BindingElementCollection elements = b.CreateBindingElements();
            foreach (BindingElement element in elements)
                Console.WriteLine("Базовая привязка {0}",  element.GetType().FullName);

            Console.WriteLine();
        }
    }
}
