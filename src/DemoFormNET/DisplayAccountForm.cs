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

            data                               = new BindingList<Transaction>(myAccount.TransactionList);
            listBoxTransactions.DataSource     = data; //myAccount.TransactionList;
            listBoxTransactions.DisplayMember  = "Summary";
        }

        private void listBoxTransactions_SelectedIndexChanged(object sender ,System.EventArgs e)
        {
            int newIndex                       = listBoxTransactions.SelectedIndex;
            Transaction selectedTransaction    = myAccount.TransactionList[newIndex];
            
            TransactionTypePanel.TextInput     = selectedTransaction.TranscationTypeString;
            TransactionDatePanel.TextInput     = selectedTransaction.DateString;
            TranscationAmountPanel.TextInput   = selectedTransaction.MoneyAmount.ToString();
            TransactionLocationPanel.TextInput = selectedTransaction.LocationString;       


        }
        private void UpdateBalanceTextField()
        {
            BalanceControlPanel.TextInput      = myAccount.Balance.ToString();            
        }
        private void btnDeposit_Click(object sender ,System.EventArgs e)
        {
            double depositAmount = Convert.ToDouble(txtDeposit.Text.ToString());
            myAccount.DepositMoney(depositAmount);
            UpdateBalanceTextField();
            data.ResetBindings();
        }

        private void btnWithdraw_Click(object sender ,EventArgs e)
        {
            double WithdrawAmount = Convert.ToDouble(txtWithdraw.Text.ToString());
            myAccount.WithdrawMoney(WithdrawAmount);
            UpdateBalanceTextField();
            data.ResetBindings();
        }
    }
}
