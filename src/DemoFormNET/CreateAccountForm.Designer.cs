
namespace DemoFormNET
{
    partial class CreateAccountForm
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
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.chkBoxAddress = new System.Windows.Forms.CheckBox();
            this.chkBoxPhone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(259, 250);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 110);
            this.txtPhone.Mask = "(000)000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 23);
            this.txtPhone.TabIndex = 5;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(112, 148);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(222, 96);
            this.rtbAddress.TabIndex = 6;
            this.rtbAddress.Text = "";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(113, 72);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(221, 23);
            this.dtpBirthDate.TabIndex = 7;
            this.dtpBirthDate.Value = new System.DateTime(1894, 1, 14, 0, 0, 0, 0);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(113, 34);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(221, 23);
            this.txtNameCustomer.TabIndex = 8;
            // 
            // chkBoxAddress
            // 
            this.chkBoxAddress.AutoSize = true;
            this.chkBoxAddress.Checked = true;
            this.chkBoxAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAddress.Location = new System.Drawing.Point(12, 148);
            this.chkBoxAddress.Name = "chkBoxAddress";
            this.chkBoxAddress.Size = new System.Drawing.Size(15, 14);
            this.chkBoxAddress.TabIndex = 9;
            this.chkBoxAddress.UseVisualStyleBackColor = true;
            this.chkBoxAddress.CheckedChanged += new System.EventHandler(this.chkBoxAddress_CheckedChanged);
            // 
            // chkBoxPhone
            // 
            this.chkBoxPhone.AutoSize = true;
            this.chkBoxPhone.Checked = true;
            this.chkBoxPhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxPhone.Location = new System.Drawing.Point(12, 110);
            this.chkBoxPhone.Name = "chkBoxPhone";
            this.chkBoxPhone.Size = new System.Drawing.Size(15, 14);
            this.chkBoxPhone.TabIndex = 10;
            this.chkBoxPhone.UseVisualStyleBackColor = true;
            this.chkBoxPhone.CheckedChanged += new System.EventHandler(this.chkBoxPhone_CheckedChanged);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 285);
            this.Controls.Add(this.chkBoxPhone);
            this.Controls.Add(this.chkBoxAddress);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.CheckBox chkBoxAddress;
        private System.Windows.Forms.CheckBox chkBoxPhone;
    }
}