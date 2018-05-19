using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.DashboardCommon;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
namespace NewProject
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_DataLoading(object sender, DataLoadingEventArgs e)
        {
            List<MyClass> list = CreateDataSource();
            e.Data = list;
        }
        private static List<MyClass> CreateDataSource()
        {
            List<MyClass> list = new List<MyClass>(10);
            Random _r = new Random();
            for (int i = 0; i < 10; i++)
                list.Add(new MyClass() { ID = i, Name = "Name" + i, Sales =(float)_r.NextDouble(), Date = DateTime.Now.AddDays(i)});
            return list;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ChartDashboardItem chartItem = dashboardViewer1.Dashboard.Items[0] as ChartDashboardItem;
            if (chartItem != null)
            {
                string path = "test.xlsx";
                DataTable table = ConvertDashboardUnderlyingDataSetToDataTable(dashboardViewer1.GetUnderlyingData(chartItem.ComponentName));
                XtraReport1 rep = new XtraReport1(table);
                rep.ArgumentDataMember = chartItem.Arguments[0].DataMember;
                rep.ValueDataMember = ((SimpleSeries)chartItem.Panes[0].Series[0]).Value.DataMember;
                rep.ChangeChartType(((SimpleSeries)chartItem.Panes[0].Series[0]).SeriesType);

                rep.ExportToXlsx(path);
                Process.Start(path);
            }
        }
        private DataTable ConvertDashboardUnderlyingDataSetToDataTable(DashboardUnderlyingDataSet data)
        {
            DataTable result = new DataTable();
            DashboardUnderlyingDataSet source = data;
            ITypedList dataProperties = (ITypedList)source;
            if (dataProperties == null) return result;
            foreach (PropertyDescriptor prop in dataProperties.GetItemProperties(null))
                result.Columns.Add(prop.Name, prop.PropertyType);
            for (int row = 0; row < source.RowCount; row++)
            {
                List<object> values = new List<object>();
                foreach (DataColumn col in result.Columns)
                    values.Add(source.GetValue(row, col.ColumnName));
                result.Rows.Add(values.ToArray());
            }
            return result;
        }
    }
}