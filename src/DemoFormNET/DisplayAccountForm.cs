using BanckClassLibrary;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static BanckClassLibrary.Account;

namespace DemoFormNET
{
    public partial class DisplayAccountForm : Form
    {
        private Account myAccount;
        BindingList<Transaction> data;

        private DisplayAccountForm() { }

        public  DisplayAccountForm(Account aAccount)
        {
            InitializeComponent();
            myAccount                          = aAccount;
            CustomerNamePanel.TextInput        = myAccount.CustomerName;

            UpdateBalanceTextField();
            //BalanceControlPanel.TextInput    = myAccount.Balance.ToString();

            data                               = new BindingList<Transaction>(myAccount.ListOfTransactions);
            listBoxTransactions.DataSource     = data; //myAccount.TransactionList;
            listBoxTransactions.DisplayMember  = "Summary";
        }

        private void listBoxTransactions_SelectedIndexChanged(object sender ,System.EventArgs e)
        {
            int newIndex                       = listBoxTransactions.SelectedIndex;
            Transaction selectedTransaction    = myAccount.ListOfTransactions[newIndex];
            
            TransactionTypePanel.TextInput     = selectedTransaction.TransactionTypeString;
            TransactionDatePanel.TextInput     = selectedTransaction.DateString;
            TranscationAmountPanel.TextInput   = selectedTransaction.MoneyAmount.ToString();
            TransactionLocationPanel.TextInput = selectedTransaction.LocationString;       


        }
        private void UpdateBalanceTextField()
        {
            BalanceControlPanel.TextInput = myAccount.CurrentBalance.ToString();            
        }
        private void btnDeposit_Click(object sender ,System.EventArgs e)
        {
            double depositAmount = Convert.ToDouble(txtDeposit.Text.ToString());
            if(!myAccount.DepositMoney(depositAmount))
            {
                MessageBox.Show("Deposit request is not valid");
                return;
            }
           
            UpdateBalanceTextField();
            data.ResetBindings();
        }

        private void btnWithdraw_Click(object sender ,EventArgs e)
        {
            double WithdrawAmount = Convert.ToDouble(txtWithdraw.Text.ToString());
            if(!myAccount.WithdrawMoney(WithdrawAmount))
            {
                MessageBox.Show("Withdraw request is not valid");
                return;
            }
            UpdateBalanceTextField();
            data.ResetBindings();
        }
    }
}
