using System.Windows;
using DynamicGraph.ViewModel;
using System.Windows.Threading;
using System;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay;
using System.Windows.Media;
using System.ComponentModel;


namespace DynamicGraph
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int _max;
        public int Max
        {
            get { return _max; }
            set { _max = value; this.OnPropertyChanged("Max"); }
        }

        private int _min;
        public int Min
        {
            get { return _min; }
            set { _min = value; this.OnPropertyChanged("Min"); }
        }

        public GraphPointCollection pointCollection; 
        DispatcherTimer updateCollectionTimer;
        private int i = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            pointCollection = new GraphPointCollection();               

            updateCollectionTimer = new DispatcherTimer();
            updateCollectionTimer.Interval = TimeSpan.FromMilliseconds(100);
            updateCollectionTimer.Tick += new EventHandler(updateCollectionTimer_Tick);
            updateCollectionTimer.Start();

            var ds = new EnumerableDataSource<GraphPoint>(pointCollection);
            ds.SetXMapping(x => dateAxis.ConvertToDouble(x.Date));
            ds.SetYMapping(y => y.Value);
            plotter.AddLineGraph(ds, Colors.Green, 2, "sinus"); // to use this method you need "using Microsoft.Research.DynamicDataDisplay;"

            Max = 1;
            Min = -1;
            
        }

        void updateCollectionTimer_Tick(object sender, EventArgs e)
        {
            i++;
            pointCollection.Add(new GraphPoint(Math.Sin(i*0.1),DateTime.Now));
        }

        #region INotifyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
