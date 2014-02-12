using BusinessEntities;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KYCUI.Winform
{
    public partial class SaveProposal : Form
    {
        public SaveProposal()
        {
            InitializeComponent();
        }

        private void btnSaveProposal_Click(object sender, EventArgs e)
        {
            ProposalBO bo = new ProposalBO();
            bo.Customer = new CustomerBO();
            bo.Customer.ProofOfIdentity = new List<DocumentBO>();
            bo.Customer.ProofOfIdentity.Add(new DocumentBO(){DocumentType = DocumentType.AadharCard,Filedata = System.IO.File.ReadAllBytes("c:\\SUService.log"),FileName="SUSServiceLog"});
            int id =  Proposal.CreateProposal(bo);
            MessageBox.Show(id.ToString());

        }
    }
}
