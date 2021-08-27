<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569249/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T172158)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/SplineChart/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/SplineChart/MainWindow.xaml))
<!-- default file list end -->
# How to create a 2D Spline Chart


The following example demonstrates how to create a <strong>2D Spline </strong>chart. To do this, it is necessary to assign the <a href="http://larix/ReferenceBrowserMain_14_2/LoadItem.aspx?Member=P%3aDevExpress.Xpf.Charts.ChartControl.Diagram&Template=MemberPropertyTopic">ChartControl.Diagram</a> property to <a href="http://larix/ReferenceBrowserMain_14_2/LoadItem.aspx?Member=T%3aDevExpress.Xpf.Charts.XYDiagram2D&Template=ClassTopic">XYDiagram2D</a>, and then add a <strong>SplineSeries2D</strong><br />object with points to the diagram's <a href="http://larix/ReferenceBrowserMain_14_2/LoadItem.aspx?Member=P%3aDevExpress.Xpf.Charts.Diagram.Series&Template=MemberPropertyTopic">Diagram.Series</a> collection. <br />
<p>Also, this example shows how to specify <strong>SplineSeries2D.LineTension</strong> and <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsLineSeries2D_MarkerSizetopic">LineSeries2D.MarkerSize</a><strong> </strong>properties and add a title to a chart.</p>

<br/>


