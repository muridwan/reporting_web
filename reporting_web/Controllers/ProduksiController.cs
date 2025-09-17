using Microsoft.SqlServer.Server;
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
using System.Text.RegularExpressions;

namespace reporting_web.Controllers
{
    public class ProduksiController : Controller
    {      
                      

        // GET: Produksi
        public ActionResult GetDataProduksi()
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

        public ActionResult DataPersenKontribusiCbg()
        {
            using (DataTOC db = new DataTOC())
            {
                var result = (from TOCList in db.TOCs select TOCList).ToList();
                if (result != null)
                {
                    ViewBag.COBID = result.Select(x => new SelectListItem { Text = x.DESCRIPTION, Value = x.TOC1.ToString() });
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
        public ActionResult DataRatioTabarruCbg()
        {
            using (DataTOC db = new DataTOC())
            {
                var result = (from TOCList in db.TOCs select TOCList).ToList();
                if (result != null)
                {
                    ViewBag.COBID = result.Select(x => new SelectListItem { Text = x.DESCRIPTION, Value = x.TOC1.ToString() });
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
        public ActionResult DataPersenKontribusiUsia()
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

        public ActionResult DataPersenJumlahUsia()
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

        public ActionResult DataPersenJumlahTSI()
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

        public ActionResult DataPersenJumlahKontribusi()
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

        public ActionResult DataPersenKontribusiSgm()
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

        public ActionResult ViewMoreKontribusi(string status)
        {            
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
        public ActionResult ViewMoreKontribusiCob(string status, string kdcbg)
        {
            ViewBag.STATUS = status;
            ViewBag.CBG = kdcbg;            
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
            string CurrentURL = Request.Url.AbsolutePath;//.AbsoluteUri;
            string filename = CurrentURL;//System.IO.Path.GetFileNameWithoutExtension(CurrentURL); -If AbsoluteUri

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }
        public ActionResult ViewMoreKontribusiSgm(string status, string kdcbg)
        {
            ViewBag.STATUS = status;
            ViewBag.CBG = kdcbg;            
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
            string CurrentURL = Request.Url.AbsolutePath;// .AbsoluteUri;
            string filename = CurrentURL;//System.IO.Path.GetFileNameWithoutExtension(CurrentURL); -if AbsoluteUri

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }
        public ActionResult ViewMoreKontribusiMkt(string status, string kdcbg)
        {
            ViewBag.STATUS = status;
            ViewBag.CBG = kdcbg;
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
            string CurrentURL = Request.Url.AbsolutePath;// .AbsoluteUri;
            string filename = CurrentURL;//System.IO.Path.GetFileNameWithoutExtension(CurrentURL); -if AbsoluteUri

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
        }
        public void GetDataProduksiReas(string Sdate, string Edate)
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
                    cmd.CommandText = "spINSTOProduksiReas";
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
        //[ValidateAntiForgeryToken]
        public void GetAppendDataProduksiReas(string token,string Sdate, string Edate, string FClear)
        {
            VerifiyToken vt = new VerifiyToken();
            if (vt.TrueToken(token))
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
                        cmd.CommandText = "spINSTOProduksiReas";
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

        }

        public List<DataProduksi> GetAllDataProduksi()
        {
            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            try
            {
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "spGetProduksiReasAll";
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataProduksi>(dt);
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
        public List<DataProduksi> GetDataProduksiPeriode(string SDate, string EDate, string spName)
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
                var list = ConvertDataTableToList<DataProduksi>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataPersenKontribusiCbg> GetDataPersenKontribusiCbg(string SDate, string EDate, string spName, string COB, string TOC, List <string> ListTOC, string token="", long roleid = 0)
        {
            
            string[] listTOC = { "%" };
            DataTable tvp = new DataTable();            
            if (ListTOC != null)
            {
                var searchCountList = ListTOC.Count(s => { return Regex.IsMatch(s, "^"); });
                tvp.Columns.Add(new DataColumn("TOC", typeof(String)));
                for (int i = 0; i < searchCountList; i++)
                {
                    listTOC = ListTOC[i].Split(new string[] { "," }, StringSplitOptions.None);
                    tvp.Rows.Add(listTOC);
                }
            }
            else
            {
                tvp.Columns.Add(new DataColumn("TOC", typeof(String)));
                tvp.Rows.Add(listTOC);
            }
            
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
                cmd.Parameters.Add("@COB", SqlDbType.VarChar).Value = COB;
                cmd.Parameters.Add("@TOC", SqlDbType.VarChar).Value = TOC;
                cmd.Parameters.Add("@ListTOC", SqlDbType.Structured);
                cmd.Parameters["@ListTOC"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ListTOC"].TypeName = "dbo.toc_list_tbltype";
                cmd.Parameters["@ListTOC"].Value = tvp;               
                cmd.Parameters.Add("@Token", SqlDbType.VarChar).Value = token;
                cmd.Parameters.Add("@RoleId", SqlDbType.BigInt).Value = roleid;                
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataPersenKontribusiCbg>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataTabarruRatio> GetListPersenTabarruCbg(string SDate, string EDate, string spName, string COB, string TOC, List<string> ListTOC)
        {

            string[] listTOC = { "%" };
            DataTable tvp = new DataTable();
            if (ListTOC != null)
            {
                var searchCountList = ListTOC.Count(s => { return Regex.IsMatch(s, "^"); });
                tvp.Columns.Add(new DataColumn("TOC", typeof(String)));
                for (int i = 0; i < searchCountList; i++)
                {
                    listTOC = ListTOC[i].Split(new string[] { "," }, StringSplitOptions.None);
                    tvp.Rows.Add(listTOC);
                }
            }
            else
            {
                tvp.Columns.Add(new DataColumn("TOC", typeof(String)));
                tvp.Rows.Add(listTOC);
            }

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
                cmd.Parameters.Add("@COB", SqlDbType.VarChar).Value = COB;
                cmd.Parameters.Add("@TOC", SqlDbType.VarChar).Value = TOC;
                cmd.Parameters.Add("@ListTOC", SqlDbType.Structured);
                cmd.Parameters["@ListTOC"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ListTOC"].TypeName = "dbo.toc_list_tbltype";
                cmd.Parameters["@ListTOC"].Value = tvp;
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataTabarruRatio>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataPersenKontribusiCob> GetListPersenKontribusiCob(string SDate, string EDate, string spName, string CBG, string token = "", int roleid = 0)
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
                cmd.Parameters.Add("@CBG", SqlDbType.VarChar).Value = CBG;
                if (token != "")
                {
                    cmd.Parameters.Add("@Token", SqlDbType.VarChar).Value = token;
                }
                if (roleid != 0)
                {
                    cmd.Parameters.Add("@RoleId", SqlDbType.VarChar).Value = roleid;
                }
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataPersenKontribusiCob>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataPersenKontribusiSgm> GetDataPersenKontribusiSgm(string SDate, string EDate, string spName)
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
                var list = ConvertDataTableToList<DataPersenKontribusiSgm>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataPersenKontribusiSgm> GetDataPersenKontribusiSgmCbg(string SDate, string EDate, string spName, string kdcbg, string token = "", long roleid = 0 )
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
                cmd.Parameters.Add("@Cbg", SqlDbType.VarChar).Value = kdcbg.ToString();
                if (token != "")
                {
                    cmd.Parameters.Add("@Token", SqlDbType.VarChar).Value = token;
                }
                if (roleid != 0)
                {
                    cmd.Parameters.Add("@RoleId", SqlDbType.VarChar).Value = roleid;
                }
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataPersenKontribusiSgm>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataPersenKontribusiMkt> GetDataPersenKontribusiMktCbg(string SDate, string EDate, string spName, string kdcbg, string token = "", long roleid = 0)
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
                cmd.Parameters.Add("@Cbg", SqlDbType.VarChar).Value = kdcbg.ToString();
                if (token != "")
                {
                    cmd.Parameters.Add("@Token", SqlDbType.VarChar).Value = token;
                }
                if (roleid != 0)
                {
                    cmd.Parameters.Add("@RoleId", SqlDbType.VarChar).Value = roleid;
                }
                cmd.CommandTimeout = 1200000;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                var list = ConvertDataTableToList<DataPersenKontribusiMkt>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataPersenKategori> GetDataPersenKategori(string SDate, string EDate, string spName)
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
                var list = ConvertDataTableToList<DataPersenKategori>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public JsonResult GetData(DataProduksi model)
        {
            
            var list = GetAllDataProduksi(); // list of records to be displayed in datatable
            return Json(new
            {
                data = list,
                recordsTotal = list.Count,
                recordsFiltered = 0
            }, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetDataDate(string SDate, string EDate, string TypeReport, List <string> ListTOC, string COB = "%", string TOC = "%", string stoken = "", int iroleid = 0)
        {
            
            if (TypeReport=="DATAPRODUKSI")
            {
                var list = GetDataProduksiPeriode(SDate, EDate, "spGetProduksiReas"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if(TypeReport == "DATALOGPRODUKSI")
            {
                var list = GetDataSysLog(SDate, EDate, "spGetLogProduksi"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "DATALOGKLAIM")
            {
                var list = GetDataSysLog(SDate, EDate, "spGetLogKlaim"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport== "PERSENKONTRIBUSICBG")
            {
                var list = GetDataPersenKontribusiCbg(SDate, EDate, "spGetPersenKontribusiCbg1",COB, TOC,ListTOC,stoken,iroleid); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENKONTRIBUSIUSIA")
            {
                var list = GetDataPersenKategori(SDate, EDate, "spGetPersenKontribusiUsia"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENJUMLAHUSIA")
            {
                var list = GetDataPersenKategori(SDate, EDate, "spGetPersenUsia"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENJUMLAHTSI")
            {
                var list = GetDataPersenKategori(SDate, EDate, "spGetPersenTSI"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENJUMLAHKONTRIBUSI")
            {
                var list = GetDataPersenKategori(SDate, EDate, "spGetPersenKontribusi"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENKONTRIBUSISGM")
            {
                var list = GetDataPersenKontribusiSgm(SDate, EDate, "spGetPersenKontribusiSegment"); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENKONTRIBUSISGMCBG")
            {
                var list = GetDataPersenKontribusiSgmCbg(SDate, EDate, "spGetPersenKontribusiSegment",COB, stoken, iroleid); //COB AS Branch // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENKONTRIBUSIMKTCBG")
            {
                var list = GetDataPersenKontribusiMktCbg(SDate, EDate, "spGetPersenKontribusiMKT", COB, stoken, iroleid); //COB AS Branch // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENTABARRUCBG")
            {
                var list = GetListPersenTabarruCbg(SDate, EDate, "spGetRatioTabarruCbg", COB, TOC, ListTOC); // list of records to be displayed in datatable
                return Json(new
                {
                    data = list,
                    recordsTotal = list.Count,
                    recordsFiltered = 0
                }, JsonRequestBehavior.AllowGet);
            }
            else if (TypeReport == "PERSENKONTRIBUSICOB")
            {
                var list = GetListPersenKontribusiCob(SDate, EDate, "spGetPersenKontribusiCob", COB, stoken, iroleid); // COB as CBG // list of records to be displayed in datatable
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
                            pro.SetValue(obj, dr[column.ColumnName],null);
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

        private static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
            }
            Console.ReadLine();
        }

        private static bool IsAvailable(SqlConnection connection)
        {
            

            try
            {
                SqlExtensions.QuickOpen(connection,120);                
            }
            catch (SqlException ex)
            {                
                return false;
            }

            return true;
        }
        
    }

    public static class SqlExtensions
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