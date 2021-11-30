using DatabaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoservice
{
    public partial class Menu : Form
    {
        private User user;
        //Для закрытия формы вне формы
        public delegate void ShowAncestor();
        private ShowAncestor showAncestor;

        public Menu(User user, ShowAncestor _delegate)
        {
            this.user = user;
            showAncestor = _delegate;
            InitializeComponent();
        }

        #region Form events
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAncestor.Invoke();
        }
        #endregion
    }
}
