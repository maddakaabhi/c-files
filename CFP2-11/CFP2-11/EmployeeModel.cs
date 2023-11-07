using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFP2_11
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string userName {  get; set; }
        public int Age {  get; set; }
        public string address {  get; set; }

        public override string ToString()
        {
            string data="id: "+Id+" username: "+userName+" Age:"+Age+" address:"+address;
            return data;
        }
    }
}
