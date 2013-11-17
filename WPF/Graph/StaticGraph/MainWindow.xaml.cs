using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace StaticGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        private List<DataModel> LoadData()
        {
            var result = new List<DataModel>();

            result.Add(new DataModel(new DateTime(2012, 10, 1, 5, 5, 1), 22));
            result.Add(new DataModel(new DateTime(2012, 10, 1, 5, 6, 1), 25));
            result.Add(new DataModel(new DateTime(2012, 10, 1, 5, 7, 1), 30));
            return result;
        }

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            List<DataModel> bugInfoList = LoadData();

            DateTime[] dates = new DateTime[bugInfoList.Count];
            int[] numberOpen = new int[bugInfoList.Count];


            for (int i = 0; i < bugInfoList.Count; ++i)
            {
                dates[i] = bugInfoList[i].Date;
                numberOpen[i] = bugInfoList[i].Value;
            }

            var datesDataSource = new EnumerableDataSource<DateTime>(dates);
            datesDataSource.SetXMapping(x => dateAxis.ConvertToDouble(x));

            var numberOpenDataSource = new EnumerableDataSource<int>(numberOpen);
            numberOpenDataSource.SetYMapping(y => Convert.ToDouble(y));

            CompositeDataSource compositeDataSource1 = new CompositeDataSource(datesDataSource, numberOpenDataSource);

            plotter.AddLineGraph(compositeDataSource1,
                      new Pen(Brushes.Blue, 2),
                      new CirclePointMarker { Size = 10.0, Fill = Brushes.Red },
                      new PenDescription("graph of values"));


            plotter.Viewport.FitToView();
        } 
    }
}
