using BanckClassLibrary;
using System;
using System.Windows.Forms;

namespace DemoFormNET
{
    public partial class CreateAccountForm : Form
    {
        private string PhoneTextInput
        {
            get
            {
                if(txtPhone.Enabled)
                {
                    return txtPhone.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        private string AddressTextInput
        {
            get
            {
                if(rtbAddress.Enabled)
                {
                    return rtbAddress.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender ,EventArgs e)
        {}

        private void btnCreateAccount_Click(object sender ,EventArgs e)
        {
            string customerName = txtNameCustomer.Text;
            DateTime birthDate  = dtpBirthDate.Value;

            if(!validateCustomerName(customerName))
            {
                MessageBox.Show("Customer name in invalid");
                return;
            }
            else if(!ValidateCustomerBirthDay(birthDate))
            {
                MessageBox.Show("Birthdate is invalid");
                return;

            };

            string phone        = PhoneTextInput;
            string address      = AddressTextInput;

            //Account newAccount = new Account(customerName, birthDate, phone, address);

            CheckingAccount newCheckingAccount = new CheckingAccount(-1, customerName, birthDate, phone, address);
            SavingsAccount newSavingAccount    = new SavingsAccount(-1, customerName, birthDate, phone, address);

            //newAccount.DepositMoney(1000);
            //newAccount.WithdrawMoney(500);

            //newAccount.DisplayAccountInfo();
            //newCheckingAccount.DisplayAccountInfo();

            //StorageUtilityFunctions.SaveAccount(newAccount);
            //Account lastAccount = StorageUtilityFunctions.GetLastAccount();

            //DisplayAccountForm displayAccount = new DisplayAccountForm(newAccount);
            DisplayAccountForm displayAccount1 = new DisplayAccountForm(newCheckingAccount);
            displayAccount1.Text = "Checking Account";

            DisplayAccountForm displayAccount2 = new DisplayAccountForm(newSavingAccount);
            displayAccount2.Text = "Savings Account";

            this.Hide();
            //displayAccount.ShowDialog();
            displayAccount1.Show();
            displayAccount2.Show();
            //this.Show();

        }

        private void chkBoxPhone_CheckedChanged(object sender ,EventArgs e)
        {
            txtPhone.Enabled = chkBoxPhone.Checked;
        }

        private void chkBoxAddress_CheckedChanged(object sender ,EventArgs e)
        {
            rtbAddress.Enabled = chkBoxAddress.Checked;
        }

        private bool validateCustomerName(string atextToValidate)
        {
            if(!string.IsNullOrEmpty(atextToValidate) &&  
                atextToValidate.Length > 2 && 
                atextToValidate.Length < 26)
            { 
                return true; 
            }
            return false;
        }

        private bool ValidateCustomerBirthDay(DateTime adateToValidate)
        {
            if(DateTime.Compare(adateToValidate, new DateTime(DateTime.Now.Year - 18,12,31)) > 0)
            { 
                return false; 
            };
            return true;

        }
    }
}
