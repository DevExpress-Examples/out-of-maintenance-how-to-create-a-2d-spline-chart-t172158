using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace SplineChart {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        public ObservableCollection<DataPoint> Data { get; private set; }
        public ChartViewModel() {
            int lastYear = DateTime.Now.Year - 1;
            Data = new ObservableCollection<DataPoint> {
                        new DataPoint (new DateTime(lastYear,1,1), 138.7),
                        new DataPoint (new DateTime(lastYear,2,1), 141.4),
                        new DataPoint (new DateTime(lastYear,3,1), 159.5),
                        new DataPoint (new DateTime(lastYear,4,1), 160.7),
                        new DataPoint (new DateTime(lastYear,5,1), 148.8),
                        new DataPoint (new DateTime(lastYear,6,1), 166.6)
                };
        }
    }
    public class DataPoint {
        public DateTime Argument { get; set; }
        public double Value { get; set; }
        public DataPoint(DateTime argument, double value) {
            Argument = argument;
            Value = value;
        }
    }
}
