using InitalUI.Navigational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitalUI
{
    public class BaseFormsPage : Form
    {
        protected User CurrentUser;
        protected Button Helpbtn;

        public BaseFormsPage(User user)
        {
            CurrentUser = user;
            Helpbtn = InitalizeHelpButton();
        }

        public BaseFormsPage()
        {
            CurrentUser = new User("", "");
            InitalizeHelpButton();
        }

        private Button InitalizeHelpButton()
        {
            Button btn = new Button();
            btn.Text = "Help";
            btn.Size = new Size(150, 40);
            btn.Location = new Point(10, this.ClientSize.Height - btn.Height - 10); // bottom-left corner
            btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn.Click += Helpbtn_Click;
            Controls.Add(btn);
            return btn;
        }

        private void Helpbtn_Click(object? sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
