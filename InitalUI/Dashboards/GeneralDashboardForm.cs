using InitalUI.Navigational;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class GeneralDashboardForm : Form
    {
        private User CurrentUser;
        public GeneralDashboardForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void GCSEbtn_Click(object sender, EventArgs e)
        {
            GCSEForm gcse = new GCSEForm(CurrentUser);
            gcse.Show();
            this.Hide();
        }

        private void Alevelbtn_Click(object sender, EventArgs e)
        {
            AlevelForm alevel = new AlevelForm(CurrentUser);
            alevel.Show();
            this.Hide();
        }

        private void Demobtn_Click(object sender, EventArgs e)
        {
            DemosForm demos = new DemosForm(CurrentUser);
            demos.Show();
            this.Hide();
        }

        private void Furtherbtn_Click(object sender, EventArgs e)
        {
            FurtherForm further = new FurtherForm(CurrentUser);
            further.Show();
            this.Hide();
        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show(); 
        }

        private void TeacherDashboard_btn(object sender, EventArgs e)
        {
            TeachersDashboard tDash = new TeachersDashboard();
            tDash.Show();
            this.Hide();
        }
    }
}
