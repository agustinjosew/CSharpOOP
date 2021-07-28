using System.Windows.Forms;

namespace DemoFormNET
{
    public partial class CustomTextBoxControl : UserControl
    {
        public string LabelText
        {
            get => CustomLabel.Text;
            set => CustomLabel.Text = value; 
        }

        public string TextInput
        {
            get => CustomTextBox.Text;
            set => CustomTextBox.Text = value;
        }
        public CustomTextBoxControl()
        {
            InitializeComponent();
        }
    }
}
