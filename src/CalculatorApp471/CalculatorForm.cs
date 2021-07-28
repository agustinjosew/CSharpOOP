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
        public delegate int    Add        (int x ,int y);
        public delegate int    Subtract   (int x ,int y);
        public delegate double Sqrt       (int x);
        public delegate long   Square     (int x);
        public delegate float  Divide     (int x , int y);
        public delegate long   Multiply   (int x , int y);

        //fields to hold instances of this delegates
        public Add      AddDelegate;
        public Subtract SubtractDelegate;
        public Sqrt     SqrtDelegate;
        public Square   SquareDelegate;
        public Divide   DivideDelegate;
        public Multiply MultiplyDelegate;

        //properties
        private int x
        {
            get
            {
                if(xInputBox.Value > 1000)
                {
                    throw new ArgumentOutOfRangeException("X", "X cannot be larger than 1000.");
                }
                return ( int ) xInputBox.Value;
            }
        }

        private int y
        {
            get
            {
                if(yInputBox.Value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Y" ,"Y cannot be larger than 1000.");
                }
                return ( int ) yInputBox.Value;
            }
        }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender ,EventArgs e)
        {
            try
            {
                ResultTextBox.Text = AddDelegate(x,y).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Add funcionality is not available:\n" + ex.Message);
                AddButton.Enabled = false;
            }
            
        }

        private void SubtractButton_Click(object sender ,EventArgs e)
        {
            try
            {
                ResultTextBox.Text = SubtractDelegate(x,y).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Subtract funcionality is not available:\n" + ex.Message);
                SubtractButton.Enabled = false;
            }
            
        }

        private void SquareButton_Click(object sender ,EventArgs e)
        {            
            try
            {
                ResultTextBox.Text = SquareDelegate(x).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Square funcionality is not available:\n" + ex.Message);
                SquareButton.Enabled = false;
            }
        }

        private void SquareRootButton_Click(object sender ,EventArgs e)
        {            
            try
            {
               ResultTextBox.Text = SqrtDelegate(x).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Square Root funcionality is not available:\n" + ex.Message);
                SquareRootButton.Enabled = false;
            }
        }

        private void DivideButton_Click(object sender ,EventArgs e)
        {
            try
            {
                if(y == 0)
                {
                    throw new DivideByZeroException();
                }
                ResultTextBox.Text = DivideDelegate(x ,y).ToString();
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);                
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Division funcionality is not available:\n" + ex.Message);
                DivideButton.Enabled = false;
            }
        }

        private void MultiplyButton_Click(object sender ,EventArgs e)
        {
            try
            {
                ResultTextBox.Text = MultiplyDelegate(x ,y).ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Multipply functionality is not available:\n" + ex.Message);
            }
        }
    }
}
