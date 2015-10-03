using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Threading;

namespace math_server
{
    [DataContract]
    public class MathResult
    {
        [DataMember]
        public double Sum { get; set; }

        [DataMember]
        public double Sub { get; set; }
        
        [DataMember]
        public double Mult { get; set; }
        
        [DataMember]
        public double Div { get; set; }
    }

    [DataContract]
    public enum MyEnum
    {
        [EnumMember]
        Enum1,
        [EnumMember]
        Enum2,
        [EnumMember]
        Enum3
    }
    
    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract(Name = "AddInt")]
        int Add(int x, int y);

        [OperationContract(Name = "AddDouble")]
        double Add(double x, double y);
        
        [OperationContract]
        MathResult Total(int a, int b);

        [OperationContract]
        void TwoWayOperation(string str);

        [OperationContract(IsOneWay = true)]
        void OneWayOperation(string str);
    }

    public class MyMath : IMyMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public MathResult Total(int a, int b)
        {
            MathResult mr = new MathResult();
            mr.Sum = a + b;
            mr.Sub = a - b;
            mr.Mult = a * b;
            mr.Div = a / b;
            return mr;
        }

        public void TwoWayOperation(string str)
        {
            Thread.Sleep(5000);
        }

        public void OneWayOperation(string str)
        {
            Thread.Sleep(5000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MyMath));

            // sh.AddServiceEndpoint(typeof(IMyMath), new WSHttpBinding(), "http://localhost:8082/MyMath/Ep1");

            sh.Open();
            Console.WriteLine("For exit press <ENTER>\n");
            Console.ReadLine();
            sh.Close();
        }
    }
}
