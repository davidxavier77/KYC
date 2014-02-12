using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class ProposalBO
    {
        public int Id { get; set; }
        public CustomerBO Customer { get; set; }
        public BankDetailsBO Bankdetails { get; set; }
        public UserBO CreatedBy { get; set; }
        public UserBO ApprovedBy { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
