//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Lifetime;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programming.Testing
//{
//    public class Sample
//    {
//        public static int smapler { get; set; }
//        public Sample()
//        {
//            if (smapler == 0) smapler = 1;   
//            Console.WriteLine($"Sample Constructor Called {smapler}");
//        }
        
//        static Sample()
//        {
//            if (smapler == 0) smapler = 2;
//            Console.WriteLine($"Sample Static Called {smapler}");
//        }

//        public void Value()
//        {
//            if (smapler == 1) smapler = 3;
//            Console.WriteLine($"Sample Value Called {smapler}");
//        }
//    }

//    public class RemoteObject: MarshalByRefObject
//    {
//        public override object InitializeLifetimeService()
//        {
//            ILease lease = (ILease)base.InitializeLifetimeService(); 
//            if(lease.CurrentState == LeaseState.Initial)
//            {
//                lease.InitialLeaseTime = TimeSpan.FromSeconds(5);
//                lease.SponsorshipTimeout = TimeSpan.FromSeconds(5);
//                lease.RenewOnCallTime = TimeSpan.FromSeconds(5);
//            }

//            return lease;
//        }

//        public string GetData()
//        {
//            return "Remote Data";
//        }
//    }
//}
