using System.Windows;
using System.Windows.Controls;

namespace SukiUI
{
    public partial class MessageWindow : ChildWindow
    {
        public MessageWindow(string Title, string Message)
        {
            InitializeComponent();
            TextBlockMessage.Text = Message;
            TextBlockTitle.Text = Title;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

    
    }
}

