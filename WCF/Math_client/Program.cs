using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Math_client.MathService;

namespace Math_client
{
    class Program
    {
        static void Main(string[] args) 
        {
            using (MyMathClient proxy = new MyMathClient())
            {
                int result = proxy.AddInt(35, 38);
                Console.WriteLine("result: {0}", result);

                double result0 = proxy.AddDouble(35, 38);
                Console.WriteLine("result: {0}", result0);

                MathResult result1 = proxy.Total(35, 38);
                Console.WriteLine("result: {0} {1} {2} {3}", result1.Sum, result1.Sub, result1.Mult, result1.Div);

                Console.WriteLine("Async Call");
                proxy.BeginAddInt(10, 20, AddIntCallBack, proxy);
                Console.WriteLine("AsyncAdd was called");

                Console.WriteLine("Call One Way Operation");
                proxy.OneWayOperation("one way");
                Console.WriteLine("One Way Operation was called");

                Console.WriteLine("Call Two Way Operation");
                proxy.TwoWayOperation("two way");
                Console.WriteLine("Two Way Operation was called");

                Console.ReadLine();
            }
        }

        static void AddIntCallBack(IAsyncResult res)
        {
            int resInt = ((IMyMath)res.AsyncState).EndAddInt(res);
            Console.WriteLine("result: {0}", resInt);
        }
    }
}
