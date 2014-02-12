using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client;
using Raven.Client.Document;
namespace BusinessLogic
{
    public class BaseClass
    {
        public static IDocumentStore UserDB = new DocumentStore() { ConnectionStringName = "UserDB" };
        public static IDocumentStore DocumentDB = new DocumentStore() { ConnectionStringName = "DocumentDB" };
        public static IDocumentStore KYCDB = new DocumentStore() { ConnectionStringName = "KYCDB" };
        //private static 

         static BaseClass()
        {
            UserDB.Initialize();
            DocumentDB.Initialize();
            KYCDB.Initialize();
        }

        //private IDocumentStore mUserStore;
        //public IDocumentStore UserDB
        //{
        //    get 
        //    {
        //        if (mUserStore == null)
        //        {
        //            mUserStore = 
        //        }

        //        return mUserStore; }
        //    set { mUserStore = value; }
        //}

        //private IDocumentStore mDocumentStore;
        //public IDocumentStore DocumentDB
        //{
        //    get { return mDocumentStore; }
        //    set { mDocumentStore = value; }
        //}

        //private IDocumentStore mKYCStore;

        //public IDocumentStore KYCDB
        //{
        //    get { return mKYCStore; }
        //    set { mKYCStore = value; }
        //}
        
    }
}
