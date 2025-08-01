using RealEstateCRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCRM.Domain.Model
{
    public class User
    {
        public Name Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Contact> Contacts { get; set; }
        public Account Account { get; set; }
        public List<Favorite> Favorites { get; set; }
        public string TaxNumber { get; set; }
        public Role Role { get; set; }
    }
}
