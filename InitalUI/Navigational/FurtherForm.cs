using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitalUI.Navigational
{
    public partial class FurtherForm : NavigationalPagesTemplate
    {
        public FurtherForm(User user) : base(user)
        {
            InitializeComponent();
        }
    }
}
