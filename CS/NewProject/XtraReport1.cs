using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraCharts;

namespace NewProject
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(System.Data.DataTable table)
            : this()
        {
            Table = table;
            xrChart1.DataSource = Table;
            xrChart1.Series[0].LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
        }
        
        protected XtraReport1()
        {
            InitializeComponent();
        }

        public void ChangeChartType(DevExpress.DashboardCommon.SimpleSeriesType seriesType)
        {
            switch (seriesType)
            {
                case DevExpress.DashboardCommon.SimpleSeriesType.Bar:
                    xrChart1.Series[0].ChangeView(ViewType.Bar);
                    break;

            }
        }
        public System.Data.DataTable Table { get; private set; }
        public string ValueDataMember
        {
            get
            {
                if (xrChart1.Series[0].ValueDataMembers.Count != 0)
                    return xrChart1.Series[0].ValueDataMembers[0];
                else
                    return string.Empty;
            }
            set
            {
                xrChart1.Series[0].ValueDataMembers.Clear();
                xrChart1.Series[0].ValueDataMembers.AddRange(new string[] { value });
            }
        }
        public string ArgumentDataMember
        {
            get { return xrChart1.Series[0].ArgumentDataMember; }
            set { xrChart1.Series[0].ArgumentDataMember = value; }
        }

    }
}
