using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QlvtPhanTan
{
    public partial class ReportDDH : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDDH()
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connectStr;
            sqlDataSource1.Fill();
        }

    }
}
