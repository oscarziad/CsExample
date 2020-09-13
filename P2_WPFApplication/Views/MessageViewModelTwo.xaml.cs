﻿using P2_WPFApplication.Models;
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
    /// Interaction logic for MessageViewModelTwo.xaml
    /// </summary>
    public partial class MessageViewModelTwo : UserControl
    {
        public MessageViewModelTwo()
        {
            InitializeComponent();

        }
        private void btnCurrentMessage_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CurrentMessage();
        }
    }
}
