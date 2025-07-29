using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitalUI.Navigational
{
    public class NavigationalPagesTemplate : BaseFormsPage
    {
        protected Button BackToDashboardbtn;

        public NavigationalPagesTemplate(User user)
        {
            CurrentUser = user;
            BackToDashboardbtn = InitalizeBackButton();
        }
        public NavigationalPagesTemplate()
        {
            CurrentUser = new User("", "");
            BackToDashboardbtn = InitalizeBackButton();
        }

        private Button InitalizeBackButton()
        {
            Button btn = new Button();
            btn.Text = "Back";
            btn.Size = new Size(150, 40);
            btn.Location = new Point(
            this.ClientSize.Width - btn.Width - 10,
            this.ClientSize.Height - btn.Height - 10
            ); // bottom right corner
            btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn.Click += BackToDashboardbtn_Click;
            Controls.Add(btn);
            return btn;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // NavigationalPagesTemplate
            // 
            ClientSize = new Size(366, 158);
            Name = "NavigationalPagesTemplate";
            ResumeLayout(false);
        }

        private void BackToDashboardbtn_Click(object? sender, EventArgs e)
        {
            GeneralDashboardForm dashboard = new GeneralDashboardForm(CurrentUser);
            dashboard.Show();
            this.Close();
        }

    }
}
