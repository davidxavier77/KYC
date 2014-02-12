using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class User:BaseClass
    {
        /// <summary>
        /// static class to create a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int CreateUser(UserBO user)
        {
            using (var session = BaseClass.UserDB.OpenSession())
            {
                session.Store(user);
                session.SaveChanges();
                return user.Id;
            }
        }

        private UserBO mUserBO;

        public User(string UserName,string Password)
        {
            using (var session = BaseClass.UserDB.OpenSession())
            {
                var results = from userbo in session.Query<UserBO>()
                          where userbo.UserName == UserName && userbo.Password == Password
                          select userbo;
                mUserBO = results.FirstOrDefault<UserBO>();
            }
        }

        public string UserName { get { return mUserBO.UserName; } set {mUserBO.UserName =value ;} }

        public bool IsAuthenticated { get { return (mUserBO != null);} }
    
    }


}
