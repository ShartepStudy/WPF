using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Math_client
{
    class Program
    {
        static void Main(string[] args) 
        {
            ChannelFactory<IMyMath> factory = new ChannelFactory<IMyMath>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8082/MyMathEndPoint"));

            IMyMath channel = factory.CreateChannel();
            int result = channel.Add(35, 38);
            Console.WriteLine("result: {0}", result);

            Console.ReadLine();
            factory.Close();
        }
    }

    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract]
        int Add(int x, int y);
    }
}
