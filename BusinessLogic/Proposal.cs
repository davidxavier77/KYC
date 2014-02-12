using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Proposal:BaseClass
    {
        public static int CreateProposal(ProposalBO proposalBO)
        {
            using (var session = BaseClass.KYCDB.OpenSession())
            {
                session.Store(proposalBO);
                session.SaveChanges();
                return proposalBO.Id;
            }
        }
    }
}
