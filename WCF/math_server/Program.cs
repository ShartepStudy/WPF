using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace math_server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MyMath));
            sh.Open();
            Console.WriteLine("For exit press <ENTER>\n");
            Console.ReadLine();
            sh.Close();
        }
    }

    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract]
        int Add(int x, int y);
    }

    public class MyMath : IMyMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
