using reporting_web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using reporting_web.Security;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace reporting_web.Controllers
{
    public class FinAccController : Controller
    {
        // GET: FinAcc
        public ActionResult Index()
        {
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public ActionResult GetDataJurnal()
        {
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public ActionResult ViewMoreLabaRugi(string status)
        {
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            String token = Session["Token"].ToString();
            if (idrole < 10)
            {
                using (DataGroupBranch db = new DataGroupBranch())
                {
                    var result = (from BranchList in db.BranchesGroup select BranchList).ToList();
                    if (result != null)
                    {
                        ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                    }
                }
            }
            else
            {
                using (DataBranchUser db = new DataBranchUser())
                {
                    var result = (from BranchList in db.vUserBranches where (BranchList.Token == token) select BranchList).ToList();
                    if (result != null)
                    {
                        ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch.ToString() });
                    }
                }
            }

            ViewBag.STATUS = status;
            VerifiyToken menu = new VerifiyToken();
            
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public ActionResult ViewMoreSurplusTabarru(string status)
        {
            using (DataGroupBranch db = new DataGroupBranch())
            {
                var result = (from BranchList in db.BranchesGroup select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }

            ViewBag.STATUS = status;
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }
        public ActionResult UWResultReport()
        {
            using (DataBranch db = new DataBranch())
            {
                var result = (from BranchList in db.Branches select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public ActionResult SurplusDefisitReport()
        {
            using (DataBranch db = new DataBranch())
            {
                var result = (from BranchList in db.Branches select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public ActionResult LabaRugiGabReport()
        {
            using (DataBranch db = new DataBranch())
            {
                var result = (from BranchList in db.Branches select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public ActionResult ListJurnalTrans()
        {
            using (DataBranch db1 = new DataBranch())
            {
                var result1 = (from BranchList in db1.Branches select BranchList).ToList();
                if(result1 != null)
                {
                    ViewBag.BranchCode = result1.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }
            using (DataAccount db2 = new DataAccount())
            {
                var result2 = (from AccountList in db2.Accounts select AccountList).ToList();
                if (result2 != null)
                {
                    ViewBag.AccountCode = result2.Select(x => new SelectListItem { Text = x.Description, Value = x.Account1.ToString() });
                }
            }
            VerifiyToken menu = new VerifiyToken();
            long idrole = Int64.Parse(Session["RoleId"].ToString());
            if (idrole == 1)
            {
                ViewBag.MenuParent = menu.getMenuParent();
                ViewBag.SubMenu1 = menu.getSubMenu1();
                ViewBag.SubMenu2 = menu.getSubMenu2();
            }
            else
            {
                ViewBag.MenuParent = menu.getMenuParent(idrole);
                ViewBag.SubMenu1 = menu.getSubMenu1(idrole);
                ViewBag.SubMenu2 = menu.getSubMenu2(idrole);
            }
            string CurrentURL = Request.Url.AbsoluteUri;
            string filename = System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }

        public JsonResult getSaldoAWalBjlLalu(int tahun)
        {
            DataSaldoAwalBjlLalu entities = new DataSaldoAwalBjlLalu();
            var saldoawalbjllalu_tables = (from saldoawalbjllalu_table in entities.SaldoAwalBjlLalus
                                           where saldoawalbjllalu_table.Tahun.Equals(tahun)
                                           select new
                                           {
                                               valsaldobjl = saldoawalbjllalu_table.SaldoAwalBerjalan,
                                               valsaldolalu = saldoawalbjllalu_table.SaldoAwalLalu 
                                           }).ToList();
            return Json(saldoawalbjllalu_tables, JsonRequestBehavior.AllowGet);
        }

        public void GetDataJurnalTrans(string Sdate, string Edate)
        {
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;

            try
            {
                SqlConnection cnn = new SqlConnection(cnnString);
                if (IsAvailable(cnn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spINSTOJurnalTrans";
                    //add any parameters the stored procedure might require
                    cmd.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DateTime.Parse(Sdate);
                    cmd.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DateTime.Parse(Edate);
                    cmd.Parameters.Add("@user_exe", SqlDbType.VarChar).Value = Session["UserName"];
                    cmd.CommandTimeout = 1200000;
                    //cnn.Open();
                    object o = cmd.ExecuteScalar();
                    cnn.Close();
                    cmd.Dispose();
                }
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }

        }

        public void GetAppendDataJurnal(string Sdate, string Edate, string FClear)
        {
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;

            try
            {
                SqlConnection cnn = new SqlConnection(cnnString);
                if (IsAvailable(cnn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spINSTOJurnalTrans";
                    //add any parameters the stored procedure might require
                    cmd.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DateTime.Parse(Sdate);
                    cmd.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DateTime.Parse(Edate);
                    cmd.Parameters.Add("@FClear", SqlDbType.Bit).Value = Convert.ToInt32(FClear);
                    cmd.Parameters.Add("@user_exe", SqlDbType.VarChar).Value = Session["UserName"];
                    cmd.CommandTimeout = 1200000;
                    //cnn.Open();
                    object o = cmd.ExecuteScalar();
                    cnn.Close();
                    cmd.Dispose();
                }
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }

        }

        private static bool IsAvailable(SqlConnection connection)
        {
            try
            {
                SqlExtensionsJurnal.QuickOpen(connection, 120);
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return false;
            }

            return true;
        }

        private static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
            }
            Console.ReadLine();
        }

        public JsonResult GetJsonLogDate(string SDate, string EDate, string TypeReport)
        {
            if (TypeReport != "")
            {
                string spName = "";

                if (TypeReport == "DATALOGJURNAL")
                    spName = "spGetLogAccounting";
                
                var list = GetDataSysLog(SDate, EDate, spName); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return null;
            }
        }

        public JsonResult GetDataLabaRugiPerMonth(int m)
        {
            var list = GetDataLabaRugiMonth(m);
            return Json(new
            {
                data = list,
                recordsTotal = list.Count,
                recordsFiltered = 0
            }, JsonRequestBehavior.AllowGet);
        }
        public List<DataLabaRugiGab> GetDataLabaRugiMonth(int m)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            try
            {
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spLabaRugiPerMonth";
                cmd.Parameters.Add("@Month", SqlDbType.Int).Value = m;
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataLabaRugiGab>(dt);
                return list;
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return null;
            }
        }
        public JsonResult GetDataLabaRugiPeriode(string sdate, string edate, string branch, string stoken = "", long iroleid = 0)
        {
            var list = ListLabaRugiPeriode(sdate,edate,branch,stoken,iroleid);
            return Json(new
            {
                data = list,
                recordsTotal = list.Count,
                recordsFiltered = 0
            }, JsonRequestBehavior.AllowGet);
        }
        public List<DataLabaRugiGab> ListLabaRugiPeriode(string sdate, string edate, string branch, string token="", long roleid=0)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            try
            {
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spLabaRugiPeriode";
                cmd.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DateTime.Parse(sdate);
                cmd.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DateTime.Parse(edate );
                if (token == "" && roleid < 10)
                {
                    cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = branch;
                }
                else
                {
                    cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = "%";
                    cmd.Parameters.Add("@Token", SqlDbType.VarChar).Value = token;
                    cmd.Parameters.Add("@RoleId", SqlDbType.BigInt).Value = roleid;
                }

                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataLabaRugiGab>(dt);
                return list;
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return null;
            }
        }
        public JsonResult GetDataSurplusTabarruPeriode(string sdate, string edate, string branch="%")
        {
            var list = ListSurplusTabarruPeriode(sdate, edate, branch);
            return Json(new
            {
                data = list,
                recordsTotal = list.Count,
                recordsFiltered = 0
            }, JsonRequestBehavior.AllowGet);
        }
        public List<DataSurplusDefisitTabarru> ListSurplusTabarruPeriode(string sdate, string edate, string branch)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            try
            {
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spSurplusTabarruPeriode";
                cmd.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DateTime.Parse(sdate);
                cmd.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DateTime.Parse(edate);
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = branch;
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataSurplusDefisitTabarru>(dt);
                return list;
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return null;
            }
        }
        public List<DataSysLog> GetDataSysLog(string SDate, string EDate, string spName)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            try
            {
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = spName;
                cmd.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DateTime.Parse(SDate);
                cmd.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DateTime.Parse(EDate);
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataSysLog>(dt);
                return list;
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return null;
            }
        }

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
                        //pro.SetValue(obj, dr[column.ColumnName], null);
                        try
                        {
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        }
                        catch (Exception)
                        {
                            string columntype = column.DataType.Name;
                            if (columntype == "Double")
                                pro.SetValue(obj, 0.0);
                        }



                    else
                        continue;
                }
            }
            return obj;
        }

        public void GenerateUWResultReport(string stTime, string enTime, string kdCab, List<string> ListCab)
        {
            ReportParams<DataUWResult> objReportParams = new ReportParams<DataUWResult>();
            objReportParams.DataSource = GetUWResult(stTime, enTime, kdCab, ListCab);
            objReportParams.ReportTitle = "Hasil Underwriting " + stTime + " s/d " + enTime;
            objReportParams.RptFileName = "UWResultReport.rpt";
            this.HttpContext.Session["ReportType"] = "ReportFinAcc";
            this.HttpContext.Session["ReportParam"] = objReportParams;
        }
        public void GenerateLabaRugiGab(string stTime, string enTime, string kdCab, List<string> ListCab)
        {
            ReportParams<DataLabaRugiGab> objReportParams = new ReportParams<DataLabaRugiGab>();
            objReportParams.DataSource = GetLabaRugiGab(stTime, enTime, kdCab, ListCab);
            objReportParams.ReportTitle = "Laba Rugi " + stTime + " s/d " + enTime;
            objReportParams.RptFileName = "LabaRugiGabReport.rpt";
            objReportParams.dtTimeParam1 = DateTime.Parse(stTime);
            objReportParams.dtTimeParam2 = DateTime.Parse(enTime);
            this.HttpContext.Session["ReportType"] = "ReportFinAcc";
            this.HttpContext.Session["ReportParam"] = objReportParams;
        }
        public JsonResult GenerateLabaRugiGabAuto(string stTime, string enTime)
        {
            ReportParams<DataLabaRugiGab> objReportParams = new ReportParams<DataLabaRugiGab>();
            objReportParams.DataSource = GetLabaRugiGab(stTime, enTime, "%", null);
            objReportParams.ReportTitle = "Laba Rugi " + stTime + " s/d " + enTime;
            objReportParams.RptFileName = "LabaRugiGabReport.rpt";
            objReportParams.dtTimeParam1 = DateTime.Parse(stTime);
            objReportParams.dtTimeParam2 = DateTime.Parse(enTime);
            this.HttpContext.Session["ReportType"] = "ReportFinAcc";
            this.HttpContext.Session["ReportParam"] = objReportParams;
            //string url = "../Report/ReportViewer.aspx?rpname=LABARUGIGABAUTO";
            //Response.Redirect(url);
            ReportDocument rd = new ReportDocument();
            string path = Server.MapPath("~") + "Report//Rpt//" + objReportParams.RptFileName;
            var dataSource = objReportParams.DataSource;
            rd.Load(path);
            rd.SetDataSource(dataSource);
            rd.SetParameterValue("@rptName", objReportParams.ReportTitle);
            rd.SetParameterValue("@sDate", objReportParams.dtTimeParam1);
            rd.SetParameterValue("@eDate", objReportParams.dtTimeParam2);
            string filePath = @"c:\windows\temp\crystal.pdf";
            rd.ExportToDisk(ExportFormatType.PortableDocFormat, filePath);
            return  Json(new { Success = true }, JsonRequestBehavior.AllowGet);
        }
        public void GenerateListJurnal(string stTime, string enTime, string kdCab, List<string> ListCab, string kdAcc, List<string> ListAcc)
        {
            ReportParams<DataListJurnalTrans> objReportParams = new ReportParams<DataListJurnalTrans>();
            objReportParams.DataSource = GetListJurnal(stTime, enTime, kdCab, ListCab, kdAcc, ListAcc);
            objReportParams.ReportTitle = "List Jurnal Transaction " + stTime + " s/d " + enTime;
            objReportParams.RptFileName = "ListJurnalTrans.rpt";
            objReportParams.dtTimeParam1 = DateTime.Parse(stTime);
            objReportParams.dtTimeParam2 = DateTime.Parse(enTime);
            this.HttpContext.Session["ReportType"] = "ReportFinAcc";
            this.HttpContext.Session["ReportParam"] = objReportParams;
        }
        public void GenerateSurplusDefisitReport(string stTime, string enTime, string saldoAwalBjl, string saldoAwalLalu, string kdCab, List<string> ListCab)
        {
            ReportParams<DataSurplusReport> objReportParams = new ReportParams<DataSurplusReport>();
            objReportParams.DataSource = GetSurplusDefisitTabarru(stTime, enTime, kdCab, ListCab);
            objReportParams.ReportTitle = kdCab;
            objReportParams.RptFileName = "SurplusDefisitReport.rpt";
            objReportParams.Param1 = saldoAwalBjl;
            objReportParams.Param2 = saldoAwalLalu;
            objReportParams.dtTimeParam1 = DateTime.Parse(stTime);
            objReportParams.dtTimeParam2 = DateTime.Parse(enTime);
            this.HttpContext.Session["ReportType"] = "ReportFinAcc";
            this.HttpContext.Session["ReportParam"] = objReportParams;
        }

        public List<DataUWResult> GetUWResult(string stTime, string enTime, string kdCab, List<string> ListCab)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            DataTable dt = new DataTable();
            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("n", typeof(String)));

            if (ListCab != null)
            {
                //string[] listCab = ListCab[0].Split(new string[] { "," }, StringSplitOptions.None);
                foreach (var kodecab in ListCab)
                    tvp.Rows.Add(kodecab);
            }
            else
            {
                string[] listCab = new string[1];
                listCab[0] = "";
                foreach (var kodecab in listCab)
                    tvp.Rows.Add(kodecab);
            }
           

            // populate DataTable from your List here
            
            string sql = "Select * From fnUwResult(@sdate,@edate,@kdcab,@listCab)";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.Add("@sdate", SqlDbType.DateTime).Value = DateTime.Parse(stTime);
            cmd.Parameters.Add("@edate", SqlDbType.DateTime).Value = DateTime.Parse(enTime);
            cmd.Parameters.Add("@kdcab", SqlDbType.VarChar).Value = kdCab;
            cmd.Parameters.Add("@listCab", SqlDbType.Structured);
            cmd.Parameters["@listCab"].Direction = ParameterDirection.Input;
            cmd.Parameters["@listCab"].TypeName = "dbo.varchar_list_tbltype";
            cmd.Parameters["@listCab"].Value = tvp;
            cmd.CommandTimeout = 1200000;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            var list = ConvertDataTableToList<DataUWResult>(dt);
            return list;
        }

        public List<DataLabaRugiGab> GetLabaRugiGab(string stTime, string enTime, string kdCab, List<string> ListCab)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            DataTable dt = new DataTable();
            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("n", typeof(String)));

            if (ListCab != null)
            {
                //string[] listCab = ListCab[0].Split(new string[] { "," }, StringSplitOptions.None);
                foreach (var kodecab in ListCab)
                    tvp.Rows.Add(kodecab);
            }
            else
            {
                string[] listCab = new string[1];
                listCab[0] = "";
                foreach (var kodecab in listCab)
                    tvp.Rows.Add(kodecab);
            }


            // populate DataTable from your List here

            string sql = "Select * From LabaRugiGabungan(@sdate,@edate,@kdcab,@listCab)";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@sdate", SqlDbType.DateTime).Value = DateTime.Parse(stTime);
            cmd.Parameters.Add("@edate", SqlDbType.DateTime).Value = DateTime.Parse(enTime);
            cmd.Parameters.Add("@kdcab", SqlDbType.VarChar).Value = kdCab;
            cmd.Parameters.Add("@listCab", SqlDbType.Structured);
            cmd.Parameters["@listCab"].Direction = ParameterDirection.Input;
            cmd.Parameters["@listCab"].TypeName = "dbo.varchar_list_tbltype";
            cmd.Parameters["@listCab"].Value = tvp;
            cmd.CommandTimeout = 1200000;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            var list = ConvertDataTableToList<DataLabaRugiGab>(dt);
            return list;
        }

        public List<DataListJurnalTrans> GetListJurnal(string stTime, string enTime, string kdCab, List<string> ListCab, string kdAcc, List<string> ListAcc)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            DataTable dt = new DataTable();
            DataTable tvp = new DataTable();
            DataTable accdt = new DataTable();

            tvp.Columns.Add(new DataColumn("n", typeof(String)));
            accdt.Columns.Add(new DataColumn("acc", typeof(String)));

            if (ListCab != null)
            {
                //string[] listCab = ListCab[0].Split(new string[] { "," }, StringSplitOptions.None);
                foreach (var kodecab in ListCab)
                    tvp.Rows.Add(kodecab);
            }
            else
            {
                string[] listCab = new string[1];
                listCab[0] = "";
                foreach (var kodecab in listCab)
                    tvp.Rows.Add(kodecab);
            }

            if (ListAcc != null)
            {
                foreach (var kodeacc in ListAcc)
                    accdt.Rows.Add(kodeacc);
            }
            else
            {
                string[] listAcc = new string[1];
                listAcc[0] = "";
                foreach (var kodeacc in listAcc)
                    accdt.Rows.Add(kodeacc);
            }

            // populate DataTable from your List here

            string sql = "Select * From fnListJurnalTrans(@sdate,@edate,@kdcab,@listCab,@kdacc,@listAcc)";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@sdate", SqlDbType.DateTime).Value = DateTime.Parse(stTime);
            cmd.Parameters.Add("@edate", SqlDbType.DateTime).Value = DateTime.Parse(enTime);
            cmd.Parameters.Add("@kdcab", SqlDbType.VarChar).Value = kdCab;
            cmd.Parameters.Add("@listCab", SqlDbType.Structured);
            cmd.Parameters["@listCab"].Direction = ParameterDirection.Input;
            cmd.Parameters["@listCab"].TypeName = "dbo.varchar_list_tbltype";
            cmd.Parameters["@listCab"].Value = tvp;
            cmd.Parameters.Add("@kdacc", SqlDbType.VarChar).Value = kdAcc;
            cmd.Parameters.Add("@listAcc", SqlDbType.Structured);
            cmd.Parameters["@listAcc"].Direction = ParameterDirection.Input;
            cmd.Parameters["@listAcc"].TypeName = "dbo.account_list_tbltype";
            cmd.Parameters["@listAcc"].Value = accdt;
            cmd.CommandTimeout = 1200000;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            var list = ConvertDataTableToList<DataListJurnalTrans>(dt);
            return list;
        }

        public List<DataSurplusReport> GetSurplusDefisitTabarru(string stTime, string enTime, string kdCab, List<string> ListCab)
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            DataTable dt = new DataTable();
            DataTable tvp = new DataTable();
            kdCab = kdCab.Replace("\n", string.Empty);
            kdCab = kdCab.Replace("\r", string.Empty);
            kdCab = kdCab.Replace("\t", string.Empty);
            tvp.Columns.Add(new DataColumn("n", typeof(String)));

            if (ListCab != null)
            {
                //string[] listCab = ListCab[1].Split(new string[] { "," }, StringSplitOptions.None);
                foreach (var kodecab in ListCab)
                    tvp.Rows.Add(kodecab);
            }
            else
            {
                string[] listCab = new string[1];
                listCab[0] = "";
                foreach (var kodecab in listCab)
                    tvp.Rows.Add(kodecab);
            }
            string sql = "Select * From fnSurplusDefisit(@sdate,@edate,@kdcab,@listCab) ORDER BY Uraian";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@sdate", SqlDbType.DateTime).Value = DateTime.Parse(stTime);
            cmd.Parameters.Add("@edate", SqlDbType.DateTime).Value = DateTime.Parse(enTime);
            cmd.Parameters.Add("@kdcab", SqlDbType.VarChar).Value = kdCab;
            cmd.Parameters.Add("@listCab", SqlDbType.Structured);
            cmd.Parameters["@listCab"].Direction = ParameterDirection.Input;
            cmd.Parameters["@listCab"].TypeName = "dbo.varchar_list_tbltype";
            cmd.Parameters["@listCab"].Value = tvp;
            cmd.CommandTimeout = 1200000;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            var list = ConvertDataTableToList<DataSurplusReport>(dt);
            return list;
        }
    }

    public static class SqlExtensionsJurnal
    {
        public static void QuickOpen(this SqlConnection conn, int timeout)
        {
            // We'll use a Stopwatch here for simplicity. A comparison to a stored DateTime.Now value could also be used
            Stopwatch sw = new Stopwatch();
            bool connectSuccess = false;

            // Try to open the connection, if anything goes wrong, make sure we set connectSuccess = false
            Thread t = new Thread(delegate ()
            {
                try
                {
                    sw.Start();
                    conn.Open();
                    connectSuccess = true;
                }
                catch { }
            });

            // Make sure it's marked as a background thread so it'll get cleaned up automatically
            t.IsBackground = true;
            t.Start();

            // Keep trying to join the thread until we either succeed or the timeout value has been exceeded
            while (timeout > sw.ElapsedMilliseconds)
                if (t.Join(1))
                    break;

            // If we didn't connect successfully, throw an exception
            if (!connectSuccess)
                throw new Exception("Timed out while trying to connect.");
        }
    }
}