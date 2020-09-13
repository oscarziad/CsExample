using System;
using System.Collections.Generic;
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
    /// Interaction logic for ContactViewModel.xaml
    /// </summary>
    public partial class ContactViewModel : UserControl
    {
        public ContactViewModel()
        {
            InitializeComponent();

            contactList.Children.Add(new Controls.ContactControl() { ContactName = "Oscar Keirouz" });
            contactList.Children.Add(new Controls.ContactControl() { ContactName = "Hans Mattin-Lassei" });
            contactList.Children.Add(new Controls.ContactControl() { ContactName = "Joakim Andersson" });
            contactList.Children.Add(new Controls.ContactControl() { ContactName = "Markus Bergstad" });
            contactList.Children.Add(new Controls.ContactControl() { ContactName = "Dino Gustav Ek" });
        }
    }
}
