<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/SplineChart/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/SplineChart/MainWindow.xaml))
<!-- default file list end -->
# How to create a 2D Spline Chart


The following example demonstrates how to create a [2D Spline chart](https://docs.devexpress.com/WPF/17680/controls-and-libraries/charts-suite/chart-control/fundamentals/series-fundamentals/2d-series-types/point,-line-and-bubble-series/spline). To do this, it is necessary to assign the [ChartControl.Diagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.Diagram) property to [XYDiagram2D](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.XYDiagram2D), and then add a [SplineSeries2D](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.SplineSeries2D)<br />object with points to the diagram's [Diagram.Series](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Diagram.Series) collection. <br />
<p>Also, this example shows how to specify [SplineSeries2D.LineTension](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.SplineSeries2D.LineTension) and [LineSeries2D.MarkerSize](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.LineSeries2D.MarkerSize) properties and add a title to a chart.</p>

<br/>


