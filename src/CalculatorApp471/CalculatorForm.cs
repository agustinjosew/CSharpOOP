using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        //delegate definitions
        public delegate int    Add      (int x ,int y);
        public delegate int    Subtract (int x ,int y);
        public delegate double Sqrt     (int x);
        public delegate long   Square   (int x);

        //fields to hold instances of this delegates
        public Add      AddDelegate;
        public Subtract SubtractDelegate;
        public Sqrt     SqrtDelegate;
        public Square   SquareDelegate;

        //properties
        private int x
        {
            get
            {
                return ( int ) xInputBox.Value;
            }
        }

        private int y
        {
            get
            {
                return ( int ) yInputBox.Value;
            }
        }



        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender ,EventArgs e)
        {
            ResultTextBox.Text = AddDelegate(x,y).ToString();
        }

        private void SubtractButton_Click(object sender ,EventArgs e)
        {
            ResultTextBox.Text = SubtractDelegate(x,y).ToString();
        }

        private void SquareButton_Click(object sender ,EventArgs e)
        {
            ResultTextBox.Text = SquareDelegate(x).ToString();
        }

        private void SquareRootButton_Click(object sender ,EventArgs e)
        {
            ResultTextBox.Text = SqrtDelegate(x).ToString();
        }
    }
}
