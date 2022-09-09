using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
         public virtual ICollection<AddressLines> addressLine { get; set; }
    }
}