using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoForm
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void PhoneCheckBox_CheckedChanged(object sender ,EventArgs e)
        {
            txtTelefono.Enabled = PhoneCheckBox.Checked;
        }

        private void AddressCheckBox_CheckedChanged(object sender ,EventArgs e)
        {
            txtAddress.Enabled = AddressCheckBox.Checked;
        }

        private void btnCreateAccount_Click(object sender ,EventArgs e)
        {
           
        }
    }
}
