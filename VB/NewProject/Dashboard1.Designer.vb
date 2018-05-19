Imports Microsoft.VisualBasic
Imports System
Namespace NewProject
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardParameter1 As New DevExpress.DashboardCommon.DashboardParameter()
			Dim dashboardParameter2 As New DevExpress.DashboardCommon.DashboardParameter()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' chartDashboardItem1
			' 
			dimension1.DataMember = "Name"
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure1.DataMember = "Sales"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.chartDashboardItem1.DataSource = Me.dashboardObjectDataSource1
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = "Chart 1"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ShowCaption = True
			' 
			' dashboardObjectDataSource1
			' 
			Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
			Me.dashboardObjectDataSource1.DataSource = GetType(NewProject.MyClass)
			Me.dashboardObjectDataSource1.Name = "Object Data Source 1"
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			dashboardParameter1.Name = "Parameter1"
			dashboardParameter1.Type = GetType(Integer)
			dashboardParameter1.Value = 0
			dashboardParameter2.Name = "Parameter2"
			dashboardParameter2.Type = GetType(String)
			dashboardParameter2.Value = "Name1"
			Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() { dashboardParameter1, dashboardParameter2})
			Me.Title.Text = "Dashboard"
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
	End Class
End Namespace
