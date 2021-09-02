Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace SplineChart
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
		Private privateData As ObservableCollection(Of DataPoint)
		Public Property Data() As ObservableCollection(Of DataPoint)
			Get
				Return privateData
			End Get
			Private Set(ByVal value As ObservableCollection(Of DataPoint))
				privateData = value
			End Set
		End Property
		Public Sub New()
			Dim lastYear As Integer = DateTime.Now.Year - 1
			Data = New ObservableCollection(Of DataPoint) From {
				New DataPoint(New DateTime(lastYear,1,1), 138.7),
				New DataPoint(New DateTime(lastYear,2,1), 141.4),
				New DataPoint(New DateTime(lastYear,3,1), 159.5),
				New DataPoint(New DateTime(lastYear,4,1), 160.7),
				New DataPoint(New DateTime(lastYear,5,1), 148.8),
				New DataPoint(New DateTime(lastYear,6,1), 166.6)
			}
		End Sub
	End Class
	Public Class DataPoint
		Public Property Argument() As DateTime
		Public Property Value() As Double
		Public Sub New(ByVal argument As DateTime, ByVal value As Double)
			Me.Argument = argument
			Me.Value = value
		End Sub
	End Class
End Namespace
