using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class CustomerBO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Lastname { get; set; }
        public string FathersName { get; set; }
        public Gender Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string PanNumber { get; set; }
        public AddressBO CustomerAddress { get; set; }
        public List<DocumentBO> ProofOfIdentity { get; set; }
    }
}
