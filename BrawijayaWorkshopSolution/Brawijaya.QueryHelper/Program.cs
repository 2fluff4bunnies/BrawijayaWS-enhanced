using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrawijayaWorkshop.Utils;
using BrawijayaWorkshop.Constant;
using System.Configuration;

namespace Brawijaya.QueryHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQLDB db = new MySQLDB();
            Console.WriteLine("start DeletePurchasingsComplete");
            db.DeletePurchasingsComplete();
            Console.WriteLine("finish DeletePurchasingsComplete");
            Console.WriteLine("start DeleteSparepartNotSpecial");
            db.DeleteSparepartNotSpecial();
            Console.WriteLine("finish DeleteSparepartNotSpecial");
            //Console.WriteLine("start DeleteSparepartSpecial");
            //db.DeleteSparepartSpecial();
            //Console.WriteLine("finish DeleteSparepartSpecial");
            
            Console.Read();
        }
    }
}
