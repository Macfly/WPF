using System.Windows;
using System.Collections.ObjectModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ListViewOfCheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
        }

        private ObservableCollection<ObsDesk> deskBlackList = new ObservableCollection<ObsDesk>();
        public ObservableCollection<ObsDesk> DeskBlackList { get { return deskBlackList; } set { deskBlackList = value; }}

        private void Button_Click(object sender, RoutedEventArgs e)
        {  
            DeskBlackList.Add(new ObsDesk() { Name = "Desk1", Visible = true });
            DeskBlackList.Add(new ObsDesk() { Name = "Desk2", Visible = false });
            DeskBlackList.Add(new ObsDesk() { Name = "Desk3", Visible = true });   
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            ObsDesk desk = checkbox.DataContext as ObsDesk;
            Console.WriteLine(desk.Name + " as been checked");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            ObsDesk desk = checkbox.DataContext as ObsDesk;
            Console.WriteLine(desk.Name + " as been unChecked");
        }
    }
}
