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
using reporting_web.Helpers;
using ClosedXML.Excel;
using System.IO;

namespace reporting_web.Controllers
{
    public class KlaimController : Controller
    {
        private bool IsLogin()
        {
            return Session["EmpId"] != null
                && Session["UserName"] != null
                && Session["RoleId"] != null
                && Session["Token"] != null;
        }
        // GET: Klaim
        public ActionResult Index()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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

        public ActionResult GetDataSettleKlaim()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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

        public ActionResult DataKlaimSubro()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

            using (DataBranch db = new DataBranch())
            {
                var result = (from BranchList in db.Branches select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }
            
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
        public ActionResult DataPersenKlaimCbg()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataPersenKlaimUYear()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataPersenKlaimCOL()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

            using (DataBranch db = new DataBranch())
            {
                var result = (from BranchList in db.Branches select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }

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
        public ActionResult DataPersenKlaimUsiaDie()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataPersenJumKlaimWaktuDie()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataPersenKlaimUsiaWaktuDie()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataPersenKlaimDescLossDie()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataPersenJumKlaimUsiaPHK()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult DataKlaimSumbis()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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

        public ActionResult DataKlaimLossRatio()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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

        public ActionResult DataPersenJumKlaimUsiaKrm()
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult ViewMoreKlaim(string status)
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult ViewMoreSubrogasi(string status)
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
        public ActionResult ViewMoreKlaimCOB(string status, string kdcbg)
        {
            if (!IsLogin())
                return RedirectToAction("Login", "Login");

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
            string filename = CurrentURL;//System.IO.Path.GetFileNameWithoutExtension(CurrentURL);

            ViewBag.AksesUser = menu.getAccessMenu(filename, idrole);

            return View();
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

        public void GetDataKlaimSettle(string Sdate, string Edate)
        {           
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmd = new SqlCommand();

            try
            {                
                if (IsAvailable(cnn))
                {                    
                    cmd.Connection = cnn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spINSTOSettleKlaim";
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
                cnn.Close();
                cmd.Dispose();
                DisplaySqlErrors(ex);
            }

        }

        public void GetAppendDataKlaimSettle(string token, string Sdate, string Edate, string FClear)
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
                        cmd.CommandText = "spINSTOSettleKlaim";
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

        private static bool IsAvailable(SqlConnection connection)
        {
            try
            {
                SqlExtensionsForClaim.QuickOpen(connection, 120);
            }
            catch (SqlException ex)
            {
                return false;
            }

            return true;
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

        public List<DataSettleKlaim> GetDataPersenKlaim2(string SDate, string EDate, string spName, string COB, string TOC,string Branch, List<string> ListTOC,List<string> ListBranch, string token = "", int roleid = 0)
        {
            string[] listTOC = ListTOC[0].Split(new string[] { "," }, StringSplitOptions.None);
            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("TOC", typeof(String)));

            // populate DataTable from your List here
            foreach (var idtoc in listTOC)
                tvp.Rows.Add(idtoc);

            string[] listBranch = ListBranch[0].Split(new string[] { "," }, StringSplitOptions.None);
            DataTable dtb = new DataTable();
            dtb.Columns.Add(new DataColumn("n",typeof(String)));
            foreach (var idbranch in listBranch)
                dtb.Rows.Add(idbranch);

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
                cmd.Parameters.Add("@Branch", SqlDbType.VarChar).Value = Branch;
                cmd.Parameters.Add("@ListBranch", SqlDbType.Structured);
                cmd.Parameters["@ListBranch"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ListBranch"].TypeName = "dbo.varchar_list_tbltype";
                cmd.Parameters["@ListBranch"].Value = dtb;
                cmd.Parameters.Add("@ListTOC", SqlDbType.Structured);
                cmd.Parameters["@ListTOC"].Direction = ParameterDirection.Input;
                cmd.Parameters["@ListTOC"].TypeName = "dbo.toc_list_tbltype";
                cmd.Parameters["@ListTOC"].Value = tvp;
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
                var list = ConvertDataTableToList<DataSettleKlaim>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<DataSettleKlaim> GetDataPersenKlaim(string SDate, string EDate, string spName, string COB, string TOC, List<string> ListTOC, string token = "", int roleid = 0)
        {
            string[] listTOC = ListTOC[0].Split(new string[] { "," }, StringSplitOptions.None);
            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("TOC", typeof(String)));

            // populate DataTable from your List here
            foreach (var idtoc in listTOC)
                tvp.Rows.Add(idtoc);

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
                var list = ConvertDataTableToList<DataSettleKlaim>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public List<T> GetDataReport<T>(string SDate,string EDate,string spName,string COB,string TOC,List<string> ListTOC,string token = "",
                                        int roleid = 0)
        {
            string[] listTOC = ListTOC[0].Split(new string[] { "," }, StringSplitOptions.None);

            DataTable tvp = new DataTable();
            tvp.Columns.Add(new DataColumn("TOC", typeof(string)));

            foreach (var idtoc in listTOC)
                tvp.Rows.Add(idtoc);

            string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;

            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection con = new SqlConnection(constr))
                using (SqlCommand cmd = new SqlCommand(spName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DateTime.Parse(SDate);
                    cmd.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DateTime.Parse(EDate);
                    cmd.Parameters.Add("@COB", SqlDbType.VarChar).Value = COB;
                    cmd.Parameters.Add("@TOC", SqlDbType.VarChar).Value = TOC;

                    cmd.Parameters.Add("@ListTOC", SqlDbType.Structured);
                    cmd.Parameters["@ListTOC"].TypeName = "dbo.toc_list_tbltype";
                    cmd.Parameters["@ListTOC"].Value = tvp;

                    if (!string.IsNullOrEmpty(token))
                        cmd.Parameters.Add("@Token", SqlDbType.VarChar).Value = token;

                    if (roleid != 0)
                        cmd.Parameters.Add("@RoleId", SqlDbType.BigInt).Value = roleid;

                    cmd.CommandTimeout = 1200000;

                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(dt);
                }

                return ConvertDataTableToList<T>(dt);
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return null;
            }
        }

        public JsonResult GetDataKlaimDate2(string SDate, string EDate, string TypeReport, List<string> ListTOC,List<string> ListBranch, string COB = "%", string TOC = "%", string Branch = "%", string stoken = "", int iroleid = 0)
        {
            if (TypeReport != "")
            {
                string spName = "";

                if (TypeReport == "PERSENKLAIMSUBRO")
                    spName = "spGetPersenKlaimSubroCbg";
                else if (TypeReport == "PERSENKLAIMCOL")
                    spName = "spGetPersenKlaimCOL";
                var list = GetDataPersenKlaim2(SDate, EDate, spName, COB, TOC, Branch, ListTOC, ListBranch, stoken, iroleid); // list of records to be displayed in datatable
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

        public JsonResult GetDataKlaimDate(string SDate,string EDate,string TypeReport,List<string> ListTOC,string COB = "%",string TOC = "%",
                                           string stoken = "", int iroleid = 0)
        {

            ReportDefinition report;

            if (!ReportHelper.Reports.TryGetValue(TypeReport, out report))
            {
                return Json(new
                {
                    success = false,
                    message = "Report tidak ditemukan."
                }, JsonRequestBehavior.AllowGet);
            }

            var result = ReportExecutor.Execute(this,report,SDate,EDate,COB,TOC,ListTOC,stoken,iroleid);

            dynamic list = result;

            return Json(new
            {
                data = list,
                recordsTotal = list.Count,
                recordsFiltered = list.Count
            }, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult GenerateLossRatioReport()
        {
            try
            {
                // =====================================================
                // PARAMETER REPORT
                // =====================================================

                string SDate =
                    Request.Form["SDate"] ?? "";

                string EDate =
                    Request.Form["EDate"] ?? "";

                string COB =
                    Request.Form["COB"] ?? "%";

                string TOC =
                    Request.Form["TOC"] ?? "%";


                // =====================================================
                // VALIDASI TANGGAL
                // =====================================================

                DateTime startDate;
                DateTime endDate;

                if (!DateTime.TryParse(SDate, out startDate))
                {
                    return Json(new
                    {
                        success = false,
                        message = "Start Date tidak valid."
                    });
                }

                if (!DateTime.TryParse(EDate, out endDate))
                {
                    return Json(new
                    {
                        success = false,
                        message = "End Date tidak valid."
                    });
                }


                // =====================================================
                // LIST TOC
                // =====================================================

                string[] listTOCValues =
                    Request.Form.GetValues("ListTOC");

                List<string> ListTOC =
                    new List<string>();

                if (listTOCValues != null)
                {
                    foreach (string value in listTOCValues)
                    {
                        if (string.IsNullOrWhiteSpace(value))
                            continue;

                        string[] splitValues =
                            value.Split(
                                new[] { ',' },
                                StringSplitOptions.RemoveEmptyEntries
                            );

                        foreach (string toc in splitValues)
                        {
                            string cleanTOC =
                                toc.Trim();

                            if (!string.IsNullOrEmpty(cleanTOC))
                            {
                                ListTOC.Add(cleanTOC);
                            }
                        }
                    }
                }


                // =====================================================
                // TOKEN & ROLE
                // =====================================================

                string stoken =
                    Request.Form["stoken"] ?? "";

                int iroleid = 0;

                int.TryParse(
                    Request.Form["iroleid"],
                    out iroleid
                );


                // =====================================================
                // EXECUTE GENERATE
                // =====================================================

                Guid reportKey;

                int recordsTotal;

                bool success =
                    GenerateLossRatioReport(
                        startDate,
                        endDate,
                        COB,
                        TOC,
                        ListTOC,
                        stoken,
                        iroleid,
                        out reportKey,
                        out recordsTotal
                    );


                if (!success)
                {
                    return Json(new
                    {
                        success = false,
                        message = "Gagal generate report Loss Ratio."
                    });
                }


                // =====================================================
                // RETURN REPORT KEY
                // =====================================================

                return Json(new
                {
                    success = true,
                    reportKey = reportKey.ToString(),
                    recordsTotal = recordsTotal
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }

        private bool GenerateLossRatioReport(
    DateTime SDate,
    DateTime EDate,
    string COB,
    string TOC,
    List<string> ListTOC,
    string token,
    int roleid,
    out Guid reportKey,
    out int recordsTotal)
        {
            reportKey = Guid.Empty;
            recordsTotal = 0;

            try
            {
                // =====================================================
                // TVP LIST TOC
                // =====================================================

                DataTable tvp = new DataTable();

                tvp.Columns.Add(
                    new DataColumn(
                        "TOC",
                        typeof(string)
                    )
                );

                if (ListTOC != null)
                {
                    foreach (string toc in ListTOC)
                    {
                        if (!string.IsNullOrWhiteSpace(toc))
                        {
                            tvp.Rows.Add(
                                toc.Trim()
                            );
                        }
                    }
                }


                // =====================================================
                // CONNECTION STRING
                // =====================================================

                string constr =
                    ConfigurationManager
                        .ConnectionStrings["SqlDBDRC"]
                        .ConnectionString;


                // =====================================================
                // CONNECTION
                // =====================================================

                using (SqlConnection con =
                    new SqlConnection(constr))
                {
                    // BUKA CONNECTION
                    con.Open();


                    // =================================================
                    // COMMAND GENERATE
                    // =================================================

                    using (SqlCommand cmd =
                        new SqlCommand(
                            "spLaporanLossRatio",
                            con))
                    {
                        cmd.CommandType =
                            CommandType.StoredProcedure;

                        cmd.CommandTimeout =
                            1200;


                        // =============================================
                        // SDATE
                        // =============================================

                        cmd.Parameters.Add(
                            "@SDate",
                            SqlDbType.Date
                        ).Value =
                            SDate.Date;


                        // =============================================
                        // EDATE
                        // =============================================

                        cmd.Parameters.Add(
                            "@EDate",
                            SqlDbType.Date
                        ).Value =
                            EDate.Date;


                        // =============================================
                        // COB
                        // =============================================

                        cmd.Parameters.Add(
                            "@COB",
                            SqlDbType.VarChar,
                            2
                        ).Value =
                            string.IsNullOrWhiteSpace(COB)
                                ? "%"
                                : COB;


                        // =============================================
                        // TOC
                        // =============================================

                        cmd.Parameters.Add(
                            "@TOC",
                            SqlDbType.VarChar
                        ).Value =
                            string.IsNullOrWhiteSpace(TOC)
                                ? "%"
                                : TOC;


                        // =============================================
                        // LIST TOC
                        // =============================================

                        SqlParameter pListTOC =
                            cmd.Parameters.Add(
                                "@ListTOC",
                                SqlDbType.Structured
                            );

                        pListTOC.TypeName =
                            "dbo.toc_list_tbltype";

                        pListTOC.Value =
                            tvp;


                        // =============================================
                        // TOKEN
                        // =============================================

                        cmd.Parameters.Add(
                            "@Token",
                            SqlDbType.VarChar,
                            100
                        ).Value =
                            token ?? "";


                        // =============================================
                        // ROLE
                        // =============================================

                        cmd.Parameters.Add(
                            "@RoleId",
                            SqlDbType.BigInt
                        ).Value =
                            roleid;


                        // =============================================
                        // REPORT KEY OUTPUT
                        // =============================================

                        SqlParameter pReportKey =
                            cmd.Parameters.Add(
                                "@ReportKey",
                                SqlDbType.UniqueIdentifier
                            );

                        pReportKey.Direction =
                            ParameterDirection.Output;


                        // =============================================
                        // EXECUTE SP
                        // =============================================

                        cmd.ExecuteNonQuery();


                        // =============================================
                        // BACA REPORT KEY
                        // =============================================

                        if (pReportKey.Value != null &&
                            pReportKey.Value != DBNull.Value)
                        {
                            reportKey =
                                (Guid)pReportKey.Value;
                        }
                    }


                    // =================================================
                    // VALIDASI REPORT KEY
                    // =================================================

                    if (reportKey == Guid.Empty)
                    {
                        return false;
                    }


                    // =================================================
                    // AMBIL TOTAL DATA DARI CACHE
                    // =================================================

                    using (SqlCommand cmdCount =
                        new SqlCommand(
                            @"
                    SELECT COUNT(*)
                    FROM dbo.LossRatioReportCache
                    WHERE ID = @ReportKey
                    ",
                            con))
                    {
                        cmdCount.CommandType =
                            CommandType.Text;

                        cmdCount.Parameters.Add(
                            "@ReportKey",
                            SqlDbType.UniqueIdentifier
                        ).Value =
                            reportKey;


                        recordsTotal =
                            Convert.ToInt32(
                                cmdCount.ExecuteScalar()
                            );
                    }
                }


                return true;
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }


        private List<DataKlaimLossRatio> GetDataKlaimLossRatioPaged(
            Guid reportKey,int start,int length,string search,int orderColumn,                                                                               
            string orderDir,out int recordsTotal,out int recordsFiltered,             
            out double totalPremi,out double totalPotongan,
            out double totalPremiNet,out double totalSettleKlaim,
            out double totalSubrogasi,out double totalKlaimNet,
            out double totalOSKlaim, out double totalClaim, 
            out double totalLRSettleKlaim, out double totalLRGrossTotal,
            out double totalLRGrossSettledNet, out double totalLRNetSettled,
            out double totalLRNetTotal, out double totalLRNetSettledNet)
        {
            recordsTotal = 0;
            recordsFiltered = 0;

            totalPremi = 0;
            totalPotongan = 0;
            totalPremiNet = 0;

            totalSettleKlaim = 0;
            totalOSKlaim = 0;
            totalClaim = 0;

            totalSubrogasi = 0;
            totalKlaimNet = 0;

            totalLRSettleKlaim = 0;
            totalLRGrossTotal = 0;
            totalLRGrossSettledNet = 0;

            totalLRNetSettled = 0;
            totalLRNetTotal = 0;
            totalLRNetSettledNet = 0;

            DataTable dt = new DataTable();

            try
            {
                // =====================================================
                // CONNECTION
                // =====================================================

                string constr = ConfigurationManager.ConnectionStrings["SqlDBDRC"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                using (SqlCommand cmd = new SqlCommand("spLaporanLossRatioPaged",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 120;

                    // =================================================
                    // REPORT KEY
                    // =================================================

                    cmd.Parameters.Add("@ReportKey",SqlDbType.UniqueIdentifier).Value = reportKey;

                    // =================================================
                    // DATATABLES START
                    // =================================================

                    cmd.Parameters.Add("@Start",SqlDbType.Int).Value = start;

                    // =================================================
                    // DATATABLES LENGTH
                    // =================================================

                    cmd.Parameters.Add("@Length",SqlDbType.Int).Value = length;

                    // =================================================
                    // SEARCH
                    // =================================================

                    cmd.Parameters.Add("@Search",SqlDbType.VarChar,200).Value = search ?? "";

                    // =================================================
                    // ORDER COLUMN
                    // =================================================

                    cmd.Parameters.Add("@OrderColumn",SqlDbType.Int).Value = orderColumn;

                    // =================================================
                    // ORDER DIRECTION
                    // =================================================

                    cmd.Parameters.Add("@OrderDir",SqlDbType.VarChar,4).Value = orderDir == "desc" ? "desc" : "asc";

                    // =================================================
                    // RECORD TOTAL
                    // =================================================

                    SqlParameter pRecordsTotal = cmd.Parameters.Add("@RecordsTotal", SqlDbType.Int );

                    pRecordsTotal.Direction = ParameterDirection.Output;

                    // =================================================
                    // RECORD FILTERED
                    // =================================================

                    SqlParameter pRecordsFiltered = cmd.Parameters.Add("@RecordsFiltered",SqlDbType.Int);

                    pRecordsFiltered.Direction = ParameterDirection.Output;

                    SqlParameter pTotalPremi = cmd.Parameters.Add("@TotalPremi",SqlDbType.Float);

                    pTotalPremi.Direction = ParameterDirection.Output;

                    SqlParameter pTotalPotongan = cmd.Parameters.Add("@TotalPotongan",SqlDbType.Float);

                    pTotalPotongan.Direction = ParameterDirection.Output;

                    SqlParameter pTotalPremiNet = cmd.Parameters.Add("@TotalPremiNet",SqlDbType.Float);

                    pTotalPremiNet.Direction = ParameterDirection.Output;

                    SqlParameter pTotalSettleKlaim = cmd.Parameters.Add("@TotalSettleKlaim",SqlDbType.Float);

                    pTotalSettleKlaim.Direction = ParameterDirection.Output;

                    SqlParameter pTotalSubrogasi = cmd.Parameters.Add("@TotalSubrogasi",SqlDbType.Float);

                    pTotalSubrogasi.Direction = ParameterDirection.Output;

                    SqlParameter pTotalKlaimNet = cmd.Parameters.Add("@TotalKlaimNet",SqlDbType.Float);

                    pTotalKlaimNet.Direction = ParameterDirection.Output;

                    SqlParameter pTotalOSKlaim = cmd.Parameters.Add("@TotalOSKlaim",SqlDbType.Float);

                    pTotalOSKlaim.Direction = ParameterDirection.Output;

                    SqlParameter pTotalLRSettleKlaim = cmd.Parameters.Add("@TotalLRSettleKlaim",SqlDbType.Float);

                    pTotalLRSettleKlaim.Direction = ParameterDirection.Output;

                    SqlParameter pTotalClaim = cmd.Parameters.Add("@TotalClaim", SqlDbType.Float);

                    pTotalClaim.Direction = ParameterDirection.Output;

                    SqlParameter pTotalLRGrossTotal = cmd.Parameters.Add("@TotalLRGrossTotal",SqlDbType.Float);

                    pTotalLRGrossTotal.Direction = ParameterDirection.Output;

                    SqlParameter pTotalLRGrossSettledNet = cmd.Parameters.Add("@TotalLRGrossSettledNet",SqlDbType.Float);

                    pTotalLRGrossSettledNet.Direction = ParameterDirection.Output;

                    SqlParameter pTotalLRNetSettled = cmd.Parameters.Add("@TotalLRNetSettled",SqlDbType.Float);

                    pTotalLRNetSettled.Direction = ParameterDirection.Output;

                    SqlParameter pTotalLRNetTotal = cmd.Parameters.Add("@TotalLRNetTotal", SqlDbType.Float);

                    pTotalLRNetTotal.Direction = ParameterDirection.Output;

                    SqlParameter pTotalLRNetSettledNet = cmd.Parameters.Add("@TotalLRNetSettledNet", SqlDbType.Float);

                    pTotalLRNetSettledNet.Direction = ParameterDirection.Output;
 
                    // =================================================
                    // EXECUTE
                    // =================================================

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);

                        if (pRecordsTotal.Value != DBNull.Value)
                        {
                            recordsTotal = Convert.ToInt32(pRecordsTotal.Value);
                        }

                        if (pRecordsFiltered.Value != DBNull.Value)
                        {
                            recordsFiltered = Convert.ToInt32(pRecordsFiltered.Value);

                            totalPremi = pTotalPremi.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalPremi.Value);

                            totalPotongan = pTotalPotongan.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalPotongan.Value);

                            totalPremiNet = pTotalPremiNet.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalPremiNet.Value);

                            totalSettleKlaim = pTotalSettleKlaim.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalSettleKlaim.Value);

                            totalOSKlaim = pTotalOSKlaim.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalOSKlaim.Value);

                            totalClaim = pTotalClaim.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalClaim.Value);

                            totalSubrogasi = pTotalSubrogasi.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalSubrogasi.Value);

                            totalKlaimNet = pTotalKlaimNet.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalKlaimNet.Value);
                           
                            totalLRSettleKlaim = pTotalLRSettleKlaim.Value == DBNull.Value ? 0 : Convert.ToDouble( pTotalLRSettleKlaim.Value);

                            totalLRGrossTotal = pTotalLRGrossTotal.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalLRGrossTotal.Value);

                            totalLRGrossSettledNet = pTotalLRGrossSettledNet.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalLRGrossSettledNet.Value);

                            totalLRNetSettled = pTotalLRNetSettled.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalLRNetSettled.Value);

                            totalLRNetTotal = pTotalLRNetTotal.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalLRNetTotal.Value);

                            totalLRNetSettledNet = pTotalLRNetSettledNet.Value == DBNull.Value ? 0 : Convert.ToDouble(pTotalLRNetSettledNet.Value);
                        }

                    }

                    // =================================================
                    // READ RECORD TOTAL
                    // =================================================

                    if (pRecordsTotal.Value != null && pRecordsTotal.Value != DBNull.Value)
                    {
                        recordsTotal = Convert.ToInt32(pRecordsTotal.Value);
                    }


                    // =================================================
                    // READ RECORD FILTERED
                    // =================================================

                    if (pRecordsFiltered.Value != null &&
                        pRecordsFiltered.Value != DBNull.Value)
                    {
                        recordsFiltered = Convert.ToInt32(pRecordsFiltered.Value);
                    }
                }

                // =====================================================
                // DATATABLE -> MODEL
                // =====================================================

                return ConvertDataTableToList<DataKlaimLossRatio>(dt);
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
                return new List<DataKlaimLossRatio>();
            }
        }

        [HttpPost]
        public JsonResult GetDataKlaimLossRatioServerSide()
        {
            // =====================================================
            // DATATABLES
            // =====================================================

            int draw = 0;
            int start = 0;
            int length = 25;

            try
            {
               
                int.TryParse(Request.Form["draw"],out draw);
                int.TryParse(Request.Form["start"],out start);
                int.TryParse(Request.Form["length"],out length);

                // =====================================================
                // SEARCH
                // =====================================================

                string search = Request.Form["search[value]"] ?? "";

                // =====================================================
                // ORDER
                // =====================================================

                int orderColumn = 1;
                int.TryParse(Request.Form["order[0][column]"],out orderColumn);

                string orderDir = Request.Form["order[0][dir]"] ?? "asc";

                // =====================================================
                // REPORT KEY
                // =====================================================

                string reportKeyString = Request.Form["ReportKey"] ?? "";

                Guid reportKey;

                if (!Guid.TryParse(reportKeyString,out reportKey))
                {
                    return Json(
                        new
                        {
                            draw = draw,
                            recordsTotal = 0,
                            recordsFiltered = 0,
                            data =
                                new List<DataKlaimLossRatio>(),
                            error =
                                "ReportKey tidak valid atau report belum digenerate."
                        },
                        JsonRequestBehavior.AllowGet
                    );
                }


                // =====================================================
                // GET PAGED DATA
                // =====================================================

                int recordsTotal;
                int recordsFiltered;

                double totalPremi;
                double totalPotongan;
                double totalPremiNet;

                double totalSettleKlaim;
                double totalOSKlaim;
                double totalClaim;

                double totalSubrogasi;
                double totalKlaimNet;

                double totalLRSettleKlaim;
                double totalLRGrossTotal;
                double totalLRGrossSettledNet;

                double totalLRNetSettled;
                double totalLRNetTotal;
                double totalLRNetSettledNet;

                List<DataKlaimLossRatio> data = GetDataKlaimLossRatioPaged(
                        reportKey,
                        start,
                        length,
                        search,
                        orderColumn,
                        orderDir,

                        out recordsTotal,
                        out recordsFiltered,

                        out totalPremi,
                        out totalPotongan,
                        out totalPremiNet,

                        out totalSettleKlaim,
                        out totalOSKlaim,
                        out totalClaim,

                        out totalSubrogasi,
                        out totalKlaimNet,

                        out totalLRSettleKlaim,
                        out totalLRGrossTotal,
                        out totalLRGrossSettledNet,

                        out totalLRNetSettled,
                        out totalLRNetTotal,
                        out totalLRNetSettledNet
                    );

                // =====================================================
                // RESPONSE DATATABLES
                // =====================================================

                return Json(
                    new
                    {
                        draw = draw,

                        recordsTotal =
                            recordsTotal,

                        recordsFiltered =
                            recordsFiltered,

                        data =
                            data ??
                            new List<DataKlaimLossRatio>(),

                        totals = new
                        {
                            Premi = totalPremi,
                            Potongan = totalPotongan,
                            PremiNet = totalPremiNet,

                            SettleKlaim = totalSettleKlaim,
                            OSKlaim = totalOSKlaim,
                            TotalClaim = totalClaim,

                            Subrogasi = totalSubrogasi,
                            KlaimNet = totalKlaimNet,

                            LR_SettleKlaim = totalLRSettleKlaim,
                            LR_Gross_Total = totalLRGrossTotal,
                            LR_Gross_SettledNet = totalLRGrossSettledNet,

                            LR_Net_Settled = totalLRNetSettled,
                            LR_Net_Total = totalLRNetTotal,
                            LR_Net_SettledNet = totalLRNetSettledNet
                        }
                    },
                    JsonRequestBehavior.AllowGet
                );
            }
            catch (Exception ex)
            {
                return Json(
                    new
                    {
                        draw = draw,
                        recordsTotal = 0,
                        recordsFiltered = 0,

                        data =
                            new List<DataKlaimLossRatio>(),

                        error =
                            ex.Message
                    },
                    JsonRequestBehavior.AllowGet
                );
            }
        }

        [HttpGet]        
        public ActionResult ExportLossRatioExcel(Guid ReportKey,string Search = "")
        {
            try
            {
                // =====================================================
                // VALIDASI
                // =====================================================

                if (ReportKey == Guid.Empty)
                {
                    return Content("ReportKey tidak valid.");
                }

                Search = Search ?? "";
                Search = Search.Trim();


                // =====================================================
                // CONNECTION
                // =====================================================

                string constr =
                    ConfigurationManager
                        .ConnectionStrings["SqlDBDRC"]
                        .ConnectionString;


                DataTable dt = new DataTable();


                // =====================================================
                // AMBIL DATA DARI CACHE
                // =====================================================

                using (SqlConnection con =
                    new SqlConnection(constr))

                using (SqlCommand cmd =
                    new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = @"

                SELECT
                    Branch,
                    Branch_Name,
                    TOC,
                    TOC_NAME,
                    Segmen,

                    Premi,
                    Potongan,
                    PremiNet,

                    SettleKlaim,
                    OSKlaim,
                    TotalClaim,

                    Subrogasi,
                    KlaimNet,

                    LR_SettleKlaim,
                    LR_Gross_Total,
                    LR_Gross_SettledNet,

                    LR_Net_Settled,
                    LR_Net_Total,
                    LR_Net_SettledNet

                FROM dbo.LossRatioReportCache

                WHERE ID = @ReportKey

                AND
                (
                    @Search = ''

                    OR Branch LIKE '%' + @Search + '%'
                    OR Branch_Name LIKE '%' + @Search + '%'
                    OR TOC LIKE '%' + @Search + '%'
                    OR TOC_NAME LIKE '%' + @Search + '%'
                    OR Segmen LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), Premi)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), Potongan)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), PremiNet)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), SettleKlaim)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), OSKlaim)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), TotalClaim)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), Subrogasi)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), KlaimNet)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), LR_SettleKlaim)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), LR_Gross_Total)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), LR_Gross_SettledNet)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), LR_Net_Settled)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), LR_Net_Total)
                        LIKE '%' + @Search + '%'

                    OR CONVERT(VARCHAR(50), LR_Net_SettledNet)
                        LIKE '%' + @Search + '%'
                )

                ORDER BY
                    Branch,
                    TOC,
                    Segmen
            ";


                    cmd.Parameters.Add(
                        "@ReportKey",
                        SqlDbType.UniqueIdentifier
                    ).Value = ReportKey;


                    cmd.Parameters.Add(
                        "@Search",
                        SqlDbType.VarChar,
                        200
                    ).Value = Search;


                    cmd.CommandTimeout = 120;


                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }


                // =====================================================
                // VALIDASI DATA
                // =====================================================

                if (dt.Rows.Count == 0)
                {
                    return Content(
                        "Tidak ada data yang dapat diexport."
                    );
                }


                // =====================================================
                // BUAT EXCEL
                // =====================================================

                using (XLWorkbook workbook =
                    new XLWorkbook())
                {
                    IXLWorksheet ws =
                        workbook.Worksheets.Add(
                            "Loss Ratio"
                        );


                    // =================================================
                    // JUMLAH KOLOM = 20
                    // =================================================

                    const int totalColumns = 20;


                    // =================================================
                    // BRANCH DAN TOC HARUS TEXT
                    // =================================================

                    ws.Column(2)
                        .Style
                        .NumberFormat
                        .Format = "@";

                    ws.Column(4)
                        .Style
                        .NumberFormat
                        .Format = "@";


                    // =================================================
                    // TITLE
                    // =================================================

                    ws.Cell(1, 1).Value =
                        "DATA KLAIM LOSS RATIO";

                    ws.Range(
                        1,
                        1,
                        1,
                        totalColumns
                    ).Merge();


                    ws.Cell(1, 1)
                        .Style
                        .Font
                        .Bold = true;

                    ws.Cell(1, 1)
                        .Style
                        .Font
                        .FontSize = 14;

                    ws.Cell(1, 1)
                        .Style
                        .Alignment
                        .Horizontal =
                            XLAlignmentHorizontalValues.Center;


                    // =================================================
                    // HEADER
                    // =================================================

                    string[] headers =
                    {
                "No",
                "Branch",
                "Branch Name",
                "TOC",
                "TOC Name",
                "Segmen",

                "Kontribusi Bruto",
                "Komisi",
                "Kontribusi Netto",
                "Settled Claim",
                "OS Claim",
                "Total Claim",
                "Subrogasi",
                "Settled Claim - Net",

                "LR Gross vs Settled Claim",
                "LR Gross vs Total Claim",
                "LR Gross vs Settled Claim Net",
                "LR Net vs Settled",
                "LR Net vs Total",
                "LR Net vs Settled Claim Net"
            };


                    for (int i = 0;
                         i < headers.Length;
                         i++)
                    {
                        ws.Cell(3, i + 1)
                            .Value = headers[i];
                    }


                    // =================================================
                    // HEADER STYLE
                    // =================================================

                    var headerRange =
                        ws.Range(
                            3,
                            1,
                            3,
                            totalColumns
                        );


                    headerRange.Style.Font.Bold = true;

                    headerRange.Style.Alignment.Horizontal =
                        XLAlignmentHorizontalValues.Center;

                    headerRange.Style.Alignment.Vertical =
                        XLAlignmentVerticalValues.Center;

                    headerRange.Style.Alignment.WrapText = true;

                    headerRange.Style.Fill.BackgroundColor =
                        XLColor.LightGray;

                    headerRange.Style.Border.OutsideBorder =
                        XLBorderStyleValues.Thin;

                    headerRange.Style.Border.InsideBorder =
                        XLBorderStyleValues.Thin;


                    // =================================================
                    // DATA
                    // =================================================

                    int rowExcel = 4;


                    foreach (DataRow row in dt.Rows)
                    {
                        // =============================================
                        // 0. NO
                        // =============================================

                        ws.Cell(rowExcel, 1)
                            .Value = rowExcel - 3;


                        // =============================================
                        // 1. BRANCH
                        // TEXT
                        // =============================================

                        string branch =
                            row["Branch"] == DBNull.Value
                                ? ""
                                : row["Branch"]
                                    .ToString()
                                    .Trim();

                        ws.Cell(rowExcel, 2)
                            .SetValue(branch);

                        ws.Cell(rowExcel, 2)
                            .Style.NumberFormat
                            .Format = "@";


                        // =============================================
                        // 2. BRANCH NAME
                        // =============================================

                        ws.Cell(rowExcel, 3)
                            .SetValue(
                                row["Branch_Name"] == DBNull.Value
                                    ? ""
                                    : row["Branch_Name"]
                                        .ToString()
                            );


                        // =============================================
                        // 3. TOC
                        // TEXT
                        // =============================================

                        string toc =
                            row["TOC"] == DBNull.Value
                                ? ""
                                : row["TOC"]
                                    .ToString()
                                    .Trim();

                        ws.Cell(rowExcel, 4)
                            .SetValue(toc);

                        ws.Cell(rowExcel, 4)
                            .Style.NumberFormat
                            .Format = "@";


                        // =============================================
                        // 4. TOC NAME
                        // =============================================

                        ws.Cell(rowExcel, 5)
                            .SetValue(
                                row["TOC_NAME"] == DBNull.Value
                                    ? ""
                                    : row["TOC_NAME"]
                                        .ToString()
                            );


                        // =============================================
                        // 5. SEGMEN
                        // =============================================

                        ws.Cell(rowExcel, 6)
                            .SetValue(
                                row["Segmen"] == DBNull.Value
                                    ? ""
                                    : row["Segmen"]
                                        .ToString()
                            );


                        // =============================================
                        // 6. KONTRIBUSI BRUTO
                        // Premi
                        // =============================================

                        ws.Cell(rowExcel, 7)
                            .Value =
                            row["Premi"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["Premi"]
                                );


                        // =============================================
                        // 7. KOMISI
                        // Potongan
                        // =============================================

                        ws.Cell(rowExcel, 8)
                            .Value =
                            row["Potongan"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["Potongan"]
                                );


                        // =============================================
                        // 8. KONTRIBUSI NETTO
                        // PremiNet
                        // =============================================

                        ws.Cell(rowExcel, 9)
                            .Value =
                            row["PremiNet"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["PremiNet"]
                                );


                        // =============================================
                        // 9. SETTLED CLAIM
                        // =============================================

                        ws.Cell(rowExcel, 10)
                            .Value =
                            row["SettleKlaim"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["SettleKlaim"]
                                );


                        // =============================================
                        // 10. OS CLAIM
                        // =============================================

                        ws.Cell(rowExcel, 11)
                            .Value =
                            row["OSKlaim"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["OSKlaim"]
                                );


                        // =============================================
                        // 11. TOTAL CLAIM
                        // =============================================

                        ws.Cell(rowExcel, 12)
                            .Value =
                            row["TotalClaim"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["TotalClaim"]
                                );


                        // =============================================
                        // 12. SUBROGASI
                        // =============================================

                        ws.Cell(rowExcel, 13)
                            .Value =
                            row["Subrogasi"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["Subrogasi"]
                                );


                        // =============================================
                        // 13. SETTLED CLAIM - NET
                        // =============================================

                        ws.Cell(rowExcel, 14)
                            .Value =
                            row["KlaimNet"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["KlaimNet"]
                                );


                        // =============================================
                        // 14. LR GROSS VS SETTLED
                        // =============================================

                        ws.Cell(rowExcel, 15)
                            .Value =
                            row["LR_SettleKlaim"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["LR_SettleKlaim"]
                                );


                        // =============================================
                        // 15. LR GROSS VS TOTAL
                        // =============================================

                        ws.Cell(rowExcel, 16)
                            .Value =
                            row["LR_Gross_Total"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["LR_Gross_Total"]
                                );


                        // =============================================
                        // 16. LR GROSS VS SETTLED NET
                        // =============================================

                        ws.Cell(rowExcel, 17)
                            .Value =
                            row["LR_Gross_SettledNet"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["LR_Gross_SettledNet"]
                                );


                        // =============================================
                        // 17. LR NET VS SETTLED
                        // =============================================

                        ws.Cell(rowExcel, 18)
                            .Value =
                            row["LR_Net_Settled"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["LR_Net_Settled"]
                                );


                        // =============================================
                        // 18. LR NET VS TOTAL
                        // =============================================

                        ws.Cell(rowExcel, 19)
                            .Value =
                            row["LR_Net_Total"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["LR_Net_Total"]
                                );


                        // =============================================
                        // 19. LR NET VS SETTLED NET
                        // =============================================

                        ws.Cell(rowExcel, 20)
                            .Value =
                            row["LR_Net_SettledNet"] == DBNull.Value
                                ? 0
                                : Convert.ToDouble(
                                    row["LR_Net_SettledNet"]
                                );


                        rowExcel++;
                    }


                    // =================================================
                    // NUMBER FORMAT
                    // =================================================

                    // Nilai kontribusi / klaim
                    ws.Range(
                        4,
                        7,
                        rowExcel - 1,
                        14
                    )
                    .Style
                    .NumberFormat
                    .Format = "#,##0.00";


                    // Loss Ratio
                    ws.Range(
                        4,
                        15,
                        rowExcel - 1,
                        20
                    )
                    .Style
                    .NumberFormat
                    .Format = "0.00";


                    // =================================================
                    // ALIGNMENT
                    // =================================================

                    ws.Range(
                        4,
                        1,
                        rowExcel - 1,
                        6
                    )
                    .Style
                    .Alignment
                    .Horizontal =
                        XLAlignmentHorizontalValues.Left;


                    ws.Range(
                        4,
                        7,
                        rowExcel - 1,
                        20
                    )
                    .Style
                    .Alignment
                    .Horizontal =
                        XLAlignmentHorizontalValues.Right;


                    // =================================================
                    // BORDER DATA
                    // =================================================

                    ws.Range(
                        3,
                        1,
                        rowExcel - 1,
                        totalColumns
                    )
                    .Style
                    .Border
                    .OutsideBorder =
                        XLBorderStyleValues.Thin;

                    ws.Range(
                        3,
                        1,
                        rowExcel - 1,
                        totalColumns
                    )
                    .Style
                    .Border
                    .InsideBorder =
                        XLBorderStyleValues.Thin;


                    // =================================================
                    // TOTAL
                    // =================================================

                    int totalRow = rowExcel;


                    ws.Cell(totalRow, 2)
                        .Value = "TOTAL";


                    ws.Cell(totalRow, 2)
                        .Style
                        .Font
                        .Bold = true;


                    // ---------------------------------------------
                    // Kontribusi Bruto
                    // ---------------------------------------------

                    ws.Cell(totalRow, 7)
                        .FormulaA1 =
                        "=SUM(G4:G" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // Komisi
                    // ---------------------------------------------

                    ws.Cell(totalRow, 8)
                        .FormulaA1 =
                        "=SUM(H4:H" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // Kontribusi Netto
                    // ---------------------------------------------

                    ws.Cell(totalRow, 9)
                        .FormulaA1 =
                        "=SUM(I4:I" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // Settled Claim
                    // ---------------------------------------------

                    ws.Cell(totalRow, 10)
                        .FormulaA1 =
                        "=SUM(J4:J" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // OS Claim
                    // ---------------------------------------------

                    ws.Cell(totalRow, 11)
                        .FormulaA1 =
                        "=SUM(K4:K" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // Total Claim
                    // ---------------------------------------------

                    ws.Cell(totalRow, 12)
                        .FormulaA1 =
                        "=SUM(L4:L" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // Subrogasi
                    // ---------------------------------------------

                    ws.Cell(totalRow, 13)
                        .FormulaA1 =
                        "=SUM(M4:M" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // Settled Claim - Net
                    // ---------------------------------------------

                    ws.Cell(totalRow, 14)
                        .FormulaA1 =
                        "=SUM(N4:N" +
                        (rowExcel - 1) +
                        ")";


                    // ---------------------------------------------
                    // LR Gross vs Settled Claim
                    // (4) / (1)
                    // ---------------------------------------------

                    ws.Cell(totalRow, 15)
                        .FormulaA1 =
                        "=IF(G" +
                        totalRow +
                        "=0,0,(J" +
                        totalRow +
                        "/G" +
                        totalRow +
                        ")*100)";


                    // ---------------------------------------------
                    // LR Gross vs Total Claim
                    // (6) / (1)
                    // ---------------------------------------------

                    ws.Cell(totalRow, 16)
                        .FormulaA1 =
                        "=IF(G" +
                        totalRow +
                        "=0,0,(L" +
                        totalRow +
                        "/G" +
                        totalRow +
                        ")*100)";


                    // ---------------------------------------------
                    // LR Gross vs Settled Claim Net
                    // (8) / (1)
                    // ---------------------------------------------

                    ws.Cell(totalRow, 17)
                        .FormulaA1 =
                        "=IF(G" +
                        totalRow +
                        "=0,0,(N" +
                        totalRow +
                        "/G" +
                        totalRow +
                        ")*100)";


                    // ---------------------------------------------
                    // LR Net vs Settled
                    // (4) / (3)
                    // ---------------------------------------------

                    ws.Cell(totalRow, 18)
                        .FormulaA1 =
                        "=IF(I" +
                        totalRow +
                        "=0,0,(J" +
                        totalRow +
                        "/I" +
                        totalRow +
                        ")*100)";


                    // ---------------------------------------------
                    // LR Net vs Total
                    // (6) / (3)
                    // ---------------------------------------------

                    ws.Cell(totalRow, 19)
                        .FormulaA1 =
                        "=IF(I" +
                        totalRow +
                        "=0,0,(L" +
                        totalRow +
                        "/I" +
                        totalRow +
                        ")*100)";


                    // ---------------------------------------------
                    // LR Net vs Settled Claim Net
                    // (8) / (3)
                    // ---------------------------------------------

                    ws.Cell(totalRow, 20)
                        .FormulaA1 =
                        "=IF(I" +
                        totalRow +
                        "=0,0,(N" +
                        totalRow +
                        "/I" +
                        totalRow +
                        ")*100)";


                    // =================================================
                    // FORMAT TOTAL
                    // =================================================

                    ws.Range(
                        totalRow,
                        7,
                        totalRow,
                        14
                    )
                    .Style
                    .NumberFormat
                    .Format = "#,##0.00";


                    ws.Range(
                        totalRow,
                        15,
                        totalRow,
                        20
                    )
                    .Style
                    .NumberFormat
                    .Format = "0.00";


                    ws.Range(
                        totalRow,
                        1,
                        totalRow,
                        totalColumns
                    )
                    .Style
                    .Font
                    .Bold = true;


                    ws.Range(
                        totalRow,
                        1,
                        totalRow,
                        totalColumns
                    )
                    .Style
                    .Border
                    .OutsideBorder =
                        XLBorderStyleValues.Thin;


                    ws.Range(
                        totalRow,
                        1,
                        totalRow,
                        totalColumns
                    )
                    .Style
                    .Border
                    .InsideBorder =
                        XLBorderStyleValues.Thin;


                    // =================================================
                    // FREEZE HEADER
                    // =================================================

                    ws.SheetView
                        .FreezeRows(3);


                    // =================================================
                    // FILTER
                    // =================================================

                    ws.Range(
                        3,
                        1,
                        rowExcel - 1,
                        totalColumns
                    )
                    .SetAutoFilter();


                    // =================================================
                    // COLUMN WIDTH
                    // =================================================

                    ws.Column(1).Width = 7;

                    ws.Column(2).Width = 10;

                    ws.Column(3).Width = 28;

                    ws.Column(4).Width = 10;

                    ws.Column(5).Width = 30;

                    ws.Column(6).Width = 20;


                    // Nilai
                    for (int col = 7; col <= 14; col++)
                    {
                        ws.Column(col).Width = 18;
                    }


                    // LR
                    for (int col = 15; col <= 20; col++)
                    {
                        ws.Column(col).Width = 22;
                    }


                    // =================================================
                    // RESPONSE
                    // =================================================

                    using (MemoryStream stream =
                        new MemoryStream())
                    {
                        workbook.SaveAs(stream);

                        return File(
                            stream.ToArray(),
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                            "DataKlaimLossRatio.xlsx"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                return Content(
                    "Gagal export Excel: " +
                    ex.Message
                );
            }
        }
        //public JsonResult GetDataKlaimDate(string SDate, string EDate, string TypeReport, List<string> ListTOC, string COB = "%", string TOC = "%", string stoken = "", int iroleid = 0)
        //{

        //    if (TypeReport != "")
        //    {
        //        string spName="";                

        //        if (TypeReport == "PERSENKLAIMCBG")
        //        {
        //            spName = "spGetPersenKlaimCbg";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMUY")
        //        {
        //            spName = "spGetPersenKlaimUY";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMCOL")
        //        {
        //            spName = "spGetPersenKlaimCOL";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMUSIADIE")
        //        {
        //            spName = "spGetPersenJumKlaimUsiaDie";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMWAKTUDIE")
        //        {
        //            spName = "spGetPersenJumKlaimWaktuDie";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMUSIAWAKTUDIE")
        //        {
        //            spName = "spGetPersenJumKlaimWaktuUsiaDie";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMDESCLOSSDIE")
        //        {
        //            spName = "spGetPersenKlaimDescLossDie";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMUSIAPHK")
        //        {
        //            spName = "spGetPersenJumKlaimUsiaPHK";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMUSIAKRM")
        //        {
        //            spName = "spGetPersenJumKlaimUsiaKrm";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMCOB")
        //        {
        //            spName = "spGetPersenKlaimCob";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "PERSENKLAIMSUBRO")
        //        {
        //            spName = "spGetPersenSubroCbg";
        //            var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }
        //        else if (TypeReport == "LAPORANKLAIMSUMBIS")
        //        {
        //            spName = "spLaporanKlaimSumbis";
        //            var list = GetDataReport<DataKlaimSumbis>(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid);
        //            return Json(new
        //            {
        //                data = list,
        //                recordsTotal = list.Count,
        //                recordsFiltered = 0
        //            }, JsonRequestBehavior.AllowGet);
        //        }                
        //        else
        //        {
        //            return Json(new
        //            {
        //                success = false,
        //                message = "TypeReport tidak dikenali."
        //            }, JsonRequestBehavior.AllowGet);
        //        }                
        //    }
        //    else
        //    {
        //        return Json(new
        //        {
        //            success = false,
        //            message = "TypeReport tidak dikenali."
        //        }, JsonRequestBehavior.AllowGet);
        //    }
        //}

    }

    public static class SqlExtensionsForClaim
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