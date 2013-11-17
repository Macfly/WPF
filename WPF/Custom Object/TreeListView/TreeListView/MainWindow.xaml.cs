using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace TreeListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Topic> Topics = new ObservableCollection<Topic>();

        public MainWindow()
        {
            InitializeComponent();

            Topics.Add(new Topic("Desk 1", "544", "10", "3", "4"));
            Topics.Add(new Topic("Desk 2", "11", "22", "33", "44"));
            Topic DataGridTopic = new Topic("Desk 3", "0.1", "0.2", "0.3", "0.4");
            DataGridTopic.ChildTopics.Add(new Topic("Equity","20/22","26/20","75/100","25/50"));
            DataGridTopic.ChildTopics.Add(new Topic("Forex", "20/22", "26/20", "75/100", "25/50"));
            DataGridTopic.ChildTopics.Add(new Topic("Options", "20/22", "26/20", "75/100", "25/50"));
            Topics.Add(DataGridTopic);

                
            myTreeView.DataContext = Topics;
        }

        private void myTreeView_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void myTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }
}
