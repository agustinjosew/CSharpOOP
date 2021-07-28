namespace CalculatorApp
{
    partial class CalculatorForm
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
            if (disposing && (components != null))
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
            this.XLabel = new System.Windows.Forms.Label();
            this.xInputBox = new System.Windows.Forms.NumericUpDown();
            this.yInputBox = new System.Windows.Forms.NumericUpDown();
            this.yLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.EqualLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(13, 32);
            this.XLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(23, 13);
            this.XLabel.TabIndex = 0;
            this.XLabel.Text = "X : ";
            // 
            // xInputBox
            // 
            this.xInputBox.Location = new System.Drawing.Point(39, 31);
            this.xInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.xInputBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.xInputBox.Name = "xInputBox";
            this.xInputBox.Size = new System.Drawing.Size(59, 20);
            this.xInputBox.TabIndex = 1;
            // 
            // yInputBox
            // 
            this.yInputBox.Location = new System.Drawing.Point(39, 57);
            this.yInputBox.Margin = new System.Windows.Forms.Padding(2);
            this.yInputBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.yInputBox.Name = "yInputBox";
            this.yInputBox.Size = new System.Drawing.Size(59, 20);
            this.yInputBox.TabIndex = 3;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(13, 58);
            this.yLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(23, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y : ";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 80);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 19);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(9, 103);
            this.SubtractButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(97, 19);
            this.SubtractButton.TabIndex = 5;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(9, 127);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(2);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(97, 19);
            this.DivideButton.TabIndex = 6;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(9, 150);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(97, 19);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(9, 174);
            this.SquareButton.Margin = new System.Windows.Forms.Padding(2);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(97, 19);
            this.SquareButton.TabIndex = 8;
            this.SquareButton.Text = "Square";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Location = new System.Drawing.Point(9, 197);
            this.SquareRootButton.Margin = new System.Windows.Forms.Padding(2);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(97, 19);
            this.SquareRootButton.TabIndex = 9;
            this.SquareRootButton.Text = "Square Root";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(28, 230);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(76, 20);
            this.ResultTextBox.TabIndex = 10;
            this.ResultTextBox.Text = "Result";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EqualLabel
            // 
            this.EqualLabel.AutoSize = true;
            this.EqualLabel.Location = new System.Drawing.Point(9, 232);
            this.EqualLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(13, 13);
            this.EqualLabel.TabIndex = 11;
            this.EqualLabel.Text = "=";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(112, 270);
            this.Controls.Add(this.EqualLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.yInputBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xInputBox);
            this.Controls.Add(this.XLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.xInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.NumericUpDown xInputBox;
        private System.Windows.Forms.NumericUpDown yInputBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label EqualLabel;
    }
}