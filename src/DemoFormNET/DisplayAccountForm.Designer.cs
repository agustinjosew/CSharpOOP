
namespace DemoFormNET
{
    partial class DisplayAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTransactions = new System.Windows.Forms.ListBox();
            this.CustomerNamePanel = new DemoFormNET.CustomTextBoxControl();
            this.TransactionTypePanel = new DemoFormNET.CustomTextBoxControl();
            this.TranscationAmountPanel = new DemoFormNET.CustomTextBoxControl();
            this.TransactionDatePanel = new DemoFormNET.CustomTextBoxControl();
            this.TransactionLocationPanel = new DemoFormNET.CustomTextBoxControl();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.BalanceControlPanel = new DemoFormNET.CustomTextBoxControl();
            this.SuspendLayout();
            // 
            // listBoxTransactions
            // 
            this.listBoxTransactions.FormattingEnabled = true;
            this.listBoxTransactions.ItemHeight = 15;
            this.listBoxTransactions.Items.AddRange(new object[] {
            "Transaction 1",
            "Transaction 2"});
            this.listBoxTransactions.Location = new System.Drawing.Point(12, 12);
            this.listBoxTransactions.Name = "listBoxTransactions";
            this.listBoxTransactions.Size = new System.Drawing.Size(302, 349);
            this.listBoxTransactions.TabIndex = 0;
            this.listBoxTransactions.SelectedIndexChanged += new System.EventHandler(this.listBoxTransactions_SelectedIndexChanged);
            // 
            // CustomerNamePanel
            // 
            this.CustomerNamePanel.LabelText = "Customer Name:";
            this.CustomerNamePanel.Location = new System.Drawing.Point(320, 12);
            this.CustomerNamePanel.Name = "CustomerNamePanel";
            this.CustomerNamePanel.Size = new System.Drawing.Size(357, 39);
            this.CustomerNamePanel.TabIndex = 1;
            this.CustomerNamePanel.TextInput = "";
            // 
            // TransactionTypePanel
            // 
            this.TransactionTypePanel.LabelText = "Transaction type:";
            this.TransactionTypePanel.Location = new System.Drawing.Point(320, 94);
            this.TransactionTypePanel.Name = "TransactionTypePanel";
            this.TransactionTypePanel.Size = new System.Drawing.Size(357, 39);
            this.TransactionTypePanel.TabIndex = 2;
            this.TransactionTypePanel.TextInput = "";
            // 
            // TranscationAmountPanel
            // 
            this.TranscationAmountPanel.LabelText = "Transaction amount:";
            this.TranscationAmountPanel.Location = new System.Drawing.Point(320, 135);
            this.TranscationAmountPanel.Name = "TranscationAmountPanel";
            this.TranscationAmountPanel.Size = new System.Drawing.Size(357, 39);
            this.TranscationAmountPanel.TabIndex = 3;
            this.TranscationAmountPanel.TextInput = "";
            // 
            // TransactionDatePanel
            // 
            this.TransactionDatePanel.LabelText = "Transaction date:";
            this.TransactionDatePanel.Location = new System.Drawing.Point(320, 176);
            this.TransactionDatePanel.Name = "TransactionDatePanel";
            this.TransactionDatePanel.Size = new System.Drawing.Size(357, 39);
            this.TransactionDatePanel.TabIndex = 4;
            this.TransactionDatePanel.TextInput = "";
            // 
            // TransactionLocationPanel
            // 
            this.TransactionLocationPanel.LabelText = "Transaction location:";
            this.TransactionLocationPanel.Location = new System.Drawing.Point(320, 217);
            this.TransactionLocationPanel.Name = "TransactionLocationPanel";
            this.TransactionLocationPanel.Size = new System.Drawing.Size(357, 39);
            this.TransactionLocationPanel.TabIndex = 5;
            this.TransactionLocationPanel.TextInput = "";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(12, 390);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(122, 23);
            this.txtDeposit.TabIndex = 6;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(58, 420);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(238, 420);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(192, 390);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(122, 23);
            this.txtWithdraw.TabIndex = 8;
            // 
            // BalanceControlPanel
            // 
            this.BalanceControlPanel.LabelText = "Current Balance";
            this.BalanceControlPanel.Location = new System.Drawing.Point(320, 53);
            this.BalanceControlPanel.Name = "BalanceControlPanel";
            this.BalanceControlPanel.Size = new System.Drawing.Size(357, 39);
            this.BalanceControlPanel.TabIndex = 10;
            this.BalanceControlPanel.TextInput = "";
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BalanceControlPanel);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.TransactionLocationPanel);
            this.Controls.Add(this.TransactionDatePanel);
            this.Controls.Add(this.TranscationAmountPanel);
            this.Controls.Add(this.TransactionTypePanel);
            this.Controls.Add(this.CustomerNamePanel);
            this.Controls.Add(this.listBoxTransactions);
            this.Name = "DisplayAccountForm";
            this.Text = "Account Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTransactions;
        private CustomTextBoxControl CustomerNamePanel;
        private CustomTextBoxControl TransactionTypePanel;
        private CustomTextBoxControl TranscationAmountPanel;
        private CustomTextBoxControl TransactionDatePanel;
        private CustomTextBoxControl TransactionLocationPanel;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private CustomTextBoxControl BalanceControlPanel;
    }
}