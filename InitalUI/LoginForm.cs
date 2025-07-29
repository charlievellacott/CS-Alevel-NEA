using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitalUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            if (Username.Text != "" && Password.Text != "")
            {
                User CurrentUser = new User(Username.Text, Password.Text);
                // add validating (as a method) their info into the class
                // call it here and open the page if the info is correct or etc...
                GeneralDashboardForm dashboardForm = new GeneralDashboardForm(CurrentUser);
                dashboardForm.Show();
                this.Hide();
            }
        }
    }
}
