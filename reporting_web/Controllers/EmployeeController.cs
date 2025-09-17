using reporting_web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace reporting_web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeReport()
        {
            return View();
        }

        public ActionResult EmployeeReportDate()
        {
            return View();
        }


        public void GenerateEmployeeReport()
        {
            ReportParams<EmployeeInfoEntity> objReportParams = new ReportParams<EmployeeInfoEntity>();
            objReportParams.DataSource = GetAllEmployee();
            objReportParams.ReportTitle = "Employee Inf Report";
            objReportParams.RptFileName = "EmployeeInfReport.rpt";
            this.HttpContext.Session["ReportType"] = "EmployeeInfoReport";
            this.HttpContext.Session["ReportParam"] = objReportParams;

        }

        public void GenerateEmployeeReportDate(string dtTime)
        {
            ReportParams<EmployeeInfoEntity> objReportParams = new ReportParams<EmployeeInfoEntity>();
            objReportParams.DataSource = GetAllEmployeeDate(dtTime);
            objReportParams.ReportTitle = "Employee Inf Report Date";
            objReportParams.RptFileName = "EmployeeInfReport.rpt";
            this.HttpContext.Session["ReportType"] = "EmployeeInfoReport";
            this.HttpContext.Session["ReportParam"] = objReportParams;
        }

        public List<EmployeeInfoEntity> GetAllEmployee()
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            DataTable dt = new DataTable();
            string sql = "Select * From Employee";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            var list = ConvertDataTableToList<EmployeeInfoEntity>(dt);
            return list;
        }

        public List<EmployeeInfoEntity> GetAllEmployeeDate(string dtTime)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            DataTable dt = new DataTable();
            string sql = "Select * From Employee Where JoinDate >='" + dtTime + "'";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            var list = ConvertDataTableToList<EmployeeInfoEntity>(dt);
            return list;
        }

        //For List Convert
        private static List<T> ConvertDataTableToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);

            }

            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public void runSP()
        {
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spTest";
            //add any parameters the stored procedure might require
            cnn.Open();
            object o = cmd.ExecuteScalar();
            cnn.Close();
        }
    }
}