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
                int result = proxy.Add(35, 38);
                Console.WriteLine("result: {0}", result);

                Console.ReadLine();
            }
            //ChannelFactory<IMyMath> factory = new ChannelFactory<IMyMath>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8082/MyMath/EP1t"));

            //IMyMath channel = factory.CreateChannel();
            //int result = channel.Add(35, 38);
            //Console.WriteLine("result: {0}", result);

            //Console.ReadLine();
            //factory.Close();
        }
    }

    //[ServiceContract]
    //public interface IMyMath
    //{
    //    [OperationContract]
    //    int Add(int x, int y);
    //}
}
