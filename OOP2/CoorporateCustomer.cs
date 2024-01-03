using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{       // kurumsal müşteri
    internal class CoorporateCustomer:Customer   // miras(inheritance)
    {
        public string CoorporateName { get; set; }
        public string TaxNum { get; set; }
    }
}
