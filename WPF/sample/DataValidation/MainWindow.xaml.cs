using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty MailAddressProperty =
        DependencyProperty.Register("MailAddress", typeof(string),
        typeof(MainWindow), new UIPropertyMetadata("xbollart@gmail.com"));
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public string MailAddress
        {
            get { return (string)GetValue(MailAddressProperty); }
            set { SetValue(MailAddressProperty, value); }
        }
    }
}
