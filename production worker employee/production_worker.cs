using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace production_worker_employee
{
    class production_worker : employee
    {
        public production_worker(string name, int id, int shift, decimal hourlypay)
         : base(name, id)
        {
            SNumber = shift;
            Hour_pay_rate = hourlypay;
        }
        public int SNumber { get; set; }
        public decimal Hour_pay_rate { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                "worker shift:" + SNumber + "\r\n" +
                   "worker hourlypay" + Hour_pay_rate + "\r\n";
        }
    }
}
