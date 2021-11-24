using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice.Forms
{
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
            transportTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void transportTypeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { transportTypeComboBox.Select(0, 0); }));
        }
    }
}
