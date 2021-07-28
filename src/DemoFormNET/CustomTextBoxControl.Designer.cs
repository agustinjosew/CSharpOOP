
namespace DemoFormNET
{
    partial class CustomTextBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTextBoxControl = new System.Windows.Forms.Panel();
            this.CustomTextBox = new System.Windows.Forms.TextBox();
            this.CustomLabel = new System.Windows.Forms.Label();
            this.pnlTextBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBoxControl
            // 
            this.pnlTextBoxControl.Controls.Add(this.CustomTextBox);
            this.pnlTextBoxControl.Controls.Add(this.CustomLabel);
            this.pnlTextBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBoxControl.Location = new System.Drawing.Point(0, 0);
            this.pnlTextBoxControl.Name = "pnlTextBoxControl";
            this.pnlTextBoxControl.Size = new System.Drawing.Size(384, 39);
            this.pnlTextBoxControl.TabIndex = 4;
            // 
            // CustomTextBox
            // 
            this.CustomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomTextBox.Location = new System.Drawing.Point(168, 3);
            this.CustomTextBox.Name = "CustomTextBox";
            this.CustomTextBox.Size = new System.Drawing.Size(213, 23);
            this.CustomTextBox.TabIndex = 2;
            // 
            // CustomLabel
            // 
            this.CustomLabel.AutoSize = true;
            this.CustomLabel.Location = new System.Drawing.Point(5, 6);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(38, 15);
            this.CustomLabel.TabIndex = 1;
            this.CustomLabel.Text = "label1";
            // 
            // CustomTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTextBoxControl);
            this.Name = "CustomTextBoxControl";
            this.Size = new System.Drawing.Size(384, 39);
            this.pnlTextBoxControl.ResumeLayout(false);
            this.pnlTextBoxControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextBoxControl;
        private System.Windows.Forms.TextBox CustomTextBox;
        private System.Windows.Forms.Label CustomLabel;
    }
}
