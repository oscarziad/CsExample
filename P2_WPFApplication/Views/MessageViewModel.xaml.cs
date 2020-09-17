using P2_WPFApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P2_WPFApplication.Views
{
    /// <summary>
    /// Interaction logic for MessageViewModel.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        public MessageViewModel()
        {
            InitializeComponent();

            messageList.Children.Add(new Controls.MessageControl() { MessageName = "Oscar Keirouz", MessageDescription = "Short description of the message here", MessageDate = "2020-09-23", MessageTime = "19:57" });
            messageList.Children.Add(new Controls.MessageControl() { MessageName = "Hans Mattin-Lassei", MessageDescription = "Short description of the message here", MessageDate = "2020-09-23", MessageTime = "19:54" });
            messageList.Children.Add(new Controls.MessageControl() { MessageName = "Joakim Andersson", MessageDescription = "Short description of the message here", MessageDate = "2020-09-22", MessageTime = "21:12" });
            messageList.Children.Add(new Controls.MessageControl() { MessageName = "Markus Bergstad", MessageDescription = "Short description of the message here", MessageDate = "2020-09-22", MessageTime = "12:31" });
            messageList.Children.Add(new Controls.MessageControl() { MessageName = "Dino Gustav Ek", MessageDescription = "Short description of the message here", MessageDate = "2020-09-22", MessageTime = "09:23" });
        }
        private void btnCurrentMessage_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CurrentMessageModel();
        }
    }
}
