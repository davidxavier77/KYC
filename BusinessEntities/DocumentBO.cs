using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class DocumentBO
    {
        public int Id { get; set; }
        public byte[] Filedata { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        /// <summary>
        /// sets the typeofProof eg AddressProof,BankProof,IdentityProof
        /// </summary>
        public ProofType ProofType { get; set; }
        /// <summary>
        /// sets the Document Type eg AadharCard,PANCard,RationCard,BankStatement,CreditCardStatement
        /// </summary>
        public DocumentType DocumentType { get; set; }
    }

    public enum DocumentType
    {
        AadharCard,PANCard,RationCard,BankStatement,CreditCardStatement
    }

    public enum ProofType
    { 
        AddressProof,BankProof,IdentityProof
    }
}
