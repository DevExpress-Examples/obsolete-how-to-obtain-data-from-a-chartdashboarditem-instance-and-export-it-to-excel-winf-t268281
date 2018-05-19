Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.DashboardCommon
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Namespace NewProject
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs) Handles dashboardViewer1.DataLoading
			Dim list As List(Of [MyClass]) = CreateDataSource()
			e.Data = list
		End Sub
		Private Shared Function CreateDataSource() As List(Of [MyClass])
			Dim list As New List(Of [MyClass])()
			Dim _r As New Random()
			For i As Integer = 0 To 10 - 1
				list.Add(New [MyClass]() With {.ID = i, .Name = "Name" & i, .Sales =CSng(_r.NextDouble()), .Date = DateTime.Now.AddDays(i)})
			Next i
			Return list
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim chartItem As ChartDashboardItem = TryCast(dashboardViewer1.Dashboard.Items(0), ChartDashboardItem)
			If chartItem IsNot Nothing Then
				Dim path As String = "test.xlsx"
				Dim table As DataTable = ConvertDashboardUnderlyingDataSetToDataTable(dashboardViewer1.GetUnderlyingData(chartItem.ComponentName))
				Dim rep As New XtraReport1(table)
				rep.ArgumentDataMember = chartItem.Arguments(0).DataMember
				rep.ValueDataMember = (CType(chartItem.Panes(0).Series(0), SimpleSeries)).Value.DataMember
				rep.ChangeChartType((CType(chartItem.Panes(0).Series(0), SimpleSeries)).SeriesType)

				rep.ExportToXlsx(path)
				Process.Start(path)
			End If
		End Sub
		Private Function ConvertDashboardUnderlyingDataSetToDataTable(ByVal data As DashboardUnderlyingDataSet) As DataTable
			Dim result As New DataTable()
			Dim source As DashboardUnderlyingDataSet = data
			Dim dataProperties As ITypedList = CType(source, ITypedList)
			If dataProperties Is Nothing Then
				Return result
			End If
			For Each prop As PropertyDescriptor In dataProperties.GetItemProperties(Nothing)
				result.Columns.Add(prop.Name, prop.PropertyType)
			Next prop
			For row As Integer = 0 To source.RowCount - 1
				Dim values As New List(Of Object)()
				For Each col As DataColumn In result.Columns
					values.Add(source.GetValue(row, col.ColumnName))
				Next col
				result.Rows.Add(values.ToArray())
			Next row
			Return result
		End Function
	End Class
End Namespace