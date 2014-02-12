using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class BankDetailsBO
    {
        public int Id { get; set; }
        public string MICRCode { get; set; } 
        public string BankName { get; set; }
        public string Branchname { get; set; }
        public AddressBO Address { get; set; }
        public AccountType AccountType{ get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }

    }

    public enum AccountType
    {
        Savings,Current,NRI
    }
}
