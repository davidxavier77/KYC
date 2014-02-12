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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //commond to be user to create a User
            //User.CreateUser(new BusinessEntities.UserBO(){FirstName="David",LastName="Xavier",UserId=Guid.NewGuid(),Password="test@123",UserName="davidxavier"});
            User user = new User("davidxavier","test@123");
            MessageBox.Show("User is Authenticated" + user.IsAuthenticated.ToString());
        }
    }
}
