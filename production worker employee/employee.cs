using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace production_worker_employee
{
    class employee
    {
        public employee(string name, int id)
        {
            EName = name;
            ENumber = id;
        }

        public string EName { get; set; }
        public int ENumber { get; set; }
        public override string ToString()
        {
            return "Employee Name:" + EName + "\r\n" +
                   "employee ID" + ENumber + "\r\n";
        }
    }
}
