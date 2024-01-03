using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{       // bireysel müşteri
    internal class IndividualCustomer : Customer // miras(inheritance)
    {
        public string TcNum { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
