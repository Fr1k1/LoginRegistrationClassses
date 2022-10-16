using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationClassses
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UsersRepository.RegisterUser( txtFirstname.Text.ToString(), txtLastname.Text.ToString(), txtUsername.Text.ToString(), txtPassword.Text.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.Close();
            this.Close();
            
        }
    }
}
