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
    public partial class AlevelForm : NavigationalPagesTemplate
    {
        public AlevelForm(User user) : base(user)
        {
            InitializeComponent();
        }
    }
}
