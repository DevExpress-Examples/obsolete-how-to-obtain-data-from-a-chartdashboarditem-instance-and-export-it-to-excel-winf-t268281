Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Namespace NewProject
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New(ByVal table As System.Data.DataTable)
			Me.New()
			Table = table
			xrChart1.DataSource = Table
			xrChart1.Series(0).LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
		End Sub

		Protected Sub New()
			InitializeComponent()
		End Sub

		Public Sub ChangeChartType(ByVal seriesType As DevExpress.DashboardCommon.SimpleSeriesType)
			Select Case seriesType
				Case DevExpress.DashboardCommon.SimpleSeriesType.Bar
					xrChart1.Series(0).ChangeView(ViewType.Bar)

			End Select
		End Sub
		Private privateTable As System.Data.DataTable
		Public Property Table() As System.Data.DataTable
			Get
				Return privateTable
			End Get
			Private Set(ByVal value As System.Data.DataTable)
				privateTable = value
			End Set
		End Property
		Public Property ValueDataMember() As String
			Get
				If xrChart1.Series(0).ValueDataMembers.Count <> 0 Then
					Return xrChart1.Series(0).ValueDataMembers(0)
				Else
					Return String.Empty
				End If
			End Get
			Set(ByVal value As String)
				xrChart1.Series(0).ValueDataMembers.Clear()
				xrChart1.Series(0).ValueDataMembers.AddRange(New String() { value })
			End Set
		End Property
		Public Property ArgumentDataMember() As String
			Get
				Return xrChart1.Series(0).ArgumentDataMember
			End Get
			Set(ByVal value As String)
				xrChart1.Series(0).ArgumentDataMember = value
			End Set
		End Property

	End Class
End Namespace
