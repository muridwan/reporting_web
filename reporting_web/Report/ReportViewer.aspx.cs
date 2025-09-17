using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace reporting_web.Report
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string rpname = "";
            rpname = Request.QueryString["rpname"];            
            LoadReport(rpname);
        }

        public void LoadReport(string stRepName)
        {
            var reportParam = (dynamic)HttpContext.Current.Session["ReportParam"];
            ReportDocument rd = new ReportDocument();
            string path = Server.MapPath("~") + "Report//Rpt//" + reportParam.RptFileName;
            var dataSource = reportParam.DataSource;
            rd.Load(path);
            rd.SetDataSource(dataSource);
            if (stRepName == "UWRESULT")
            {
                rd.SetParameterValue("@rptName", reportParam.ReportTitle);                    
            }
            else if (stRepName == "SURPLUSDEFISIT")
            {
                rd.SetParameterValue("@rptName", reportParam.ReportTitle);
                rd.SetParameterValue("@saldoAwalBjl", reportParam.Param1);
                rd.SetParameterValue("@saldoAwalLalu", reportParam.Param2);
                rd.SetParameterValue("@sDate", reportParam.dtTimeParam1);
                rd.SetParameterValue("@eDate", reportParam.dtTimeParam2);
            }
            else if (stRepName == "LABARUGIGAB")
            {
                rd.SetParameterValue("@rptName", reportParam.ReportTitle);                
                rd.SetParameterValue("@sDate", reportParam.dtTimeParam1);
                rd.SetParameterValue("@eDate", reportParam.dtTimeParam2);
            }
            else if (stRepName == "LISTJURNAL")
            {
                rd.SetParameterValue("@rptName", reportParam.ReportTitle);
                rd.SetParameterValue("@sDate", reportParam.dtTimeParam1);
                rd.SetParameterValue("@eDate", reportParam.dtTimeParam2);
            }            

            CrystalReportViewer1.ReportSource = rd;
            CrystalReportViewer1.ReuseParameterValuesOnRefresh = true;
            //string filePath = Server.MapPath("~/GeneratedReports/") + "Cristal.pdf";
            //string filePath = @"c:\windows\temp\crystal.pdf";
            //rd.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, filePath);
            //rd.ExportToDisk(ExportFormatType.PortableDocFormat, filePath);
        }
    }
}