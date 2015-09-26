using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace disc_space_service
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(DiscSpace)))
            {
                sh.Open();
                Console.WriteLine("For exit press <ENTER>\n");
                Console.ReadLine();
            }
        }
    }

    [ServiceContract]
    public interface IDiscSpace
    {
        [OperationContract]
        long FreeSpace(string disc);

        [OperationContract]
        long TotalSpace(string disc);
    }

    public class DiscSpace : IDiscSpace
    {
        public long FreeSpace(string disc)
        {
            var d = new System.IO.DriveInfo(disc);
            return d.TotalFreeSpace;
        }

        public long TotalSpace(string disc)
        {
            var d = new System.IO.DriveInfo(disc);
            return d.TotalSize;
        }
    }


}
