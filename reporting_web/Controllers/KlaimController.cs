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
            Guid reportKey,
            int start,
            int length,
            string search,
            int orderColumn,
            string orderDir,
            out int recordsTotal,
            out int recordsFiltered)
        {
            recordsTotal = 0;
            recordsFiltered = 0;

            DataTable dt =
                new DataTable();

            try
            {
                // =====================================================
                // CONNECTION
                // =====================================================

                string constr =
                    ConfigurationManager
                        .ConnectionStrings["SqlDBDRC"]
                        .ConnectionString;


                using (SqlConnection con =
                    new SqlConnection(constr))

                using (SqlCommand cmd =
                    new SqlCommand(
                        "spLaporanLossRatioPaged",
                        con))
                {
                    cmd.CommandType =
                        CommandType.StoredProcedure;

                    cmd.CommandTimeout =
                        120;


                    // =================================================
                    // REPORT KEY
                    // =================================================

                    cmd.Parameters.Add(
                        "@ReportKey",
                        SqlDbType.UniqueIdentifier
                    ).Value =
                        reportKey;


                    // =================================================
                    // DATATABLES START
                    // =================================================

                    cmd.Parameters.Add(
                        "@Start",
                        SqlDbType.Int
                    ).Value =
                        start;


                    // =================================================
                    // DATATABLES LENGTH
                    // =================================================

                    cmd.Parameters.Add(
                        "@Length",
                        SqlDbType.Int
                    ).Value =
                        length;


                    // =================================================
                    // SEARCH
                    // =================================================

                    cmd.Parameters.Add(
                        "@Search",
                        SqlDbType.VarChar,
                        200
                    ).Value =
                        search ?? "";


                    // =================================================
                    // ORDER COLUMN
                    // =================================================

                    cmd.Parameters.Add(
                        "@OrderColumn",
                        SqlDbType.Int
                    ).Value =
                        orderColumn;


                    // =================================================
                    // ORDER DIRECTION
                    // =================================================

                    cmd.Parameters.Add(
                        "@OrderDir",
                        SqlDbType.VarChar,
                        4
                    ).Value =
                        orderDir == "desc"
                            ? "desc"
                            : "asc";


                    // =================================================
                    // RECORD TOTAL
                    // =================================================

                    SqlParameter pRecordsTotal =
                        cmd.Parameters.Add(
                            "@RecordsTotal",
                            SqlDbType.Int
                        );

                    pRecordsTotal.Direction =
                        ParameterDirection.Output;


                    // =================================================
                    // RECORD FILTERED
                    // =================================================

                    SqlParameter pRecordsFiltered =
                        cmd.Parameters.Add(
                            "@RecordsFiltered",
                            SqlDbType.Int
                        );

                    pRecordsFiltered.Direction =
                        ParameterDirection.Output;


                    // =================================================
                    // EXECUTE
                    // =================================================

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }


                    // =================================================
                    // READ RECORD TOTAL
                    // =================================================

                    if (pRecordsTotal.Value != null &&
                        pRecordsTotal.Value != DBNull.Value)
                    {
                        recordsTotal =
                            Convert.ToInt32(
                                pRecordsTotal.Value
                            );
                    }


                    // =================================================
                    // READ RECORD FILTERED
                    // =================================================

                    if (pRecordsFiltered.Value != null &&
                        pRecordsFiltered.Value != DBNull.Value)
                    {
                        recordsFiltered =
                            Convert.ToInt32(
                                pRecordsFiltered.Value
                            );
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
               
                int.TryParse(
                    Request.Form["draw"],
                    out draw
                );

                int.TryParse(
                    Request.Form["start"],
                    out start
                );

                int.TryParse(
                    Request.Form["length"],
                    out length
                );


                // =====================================================
                // SEARCH
                // =====================================================

                string search =
                    Request.Form["search[value]"] ?? "";


                // =====================================================
                // ORDER
                // =====================================================

                int orderColumn = 1;

                int.TryParse(
                    Request.Form["order[0][column]"],
                    out orderColumn
                );


                string orderDir =
                    Request.Form["order[0][dir]"] ?? "asc";


                // =====================================================
                // REPORT KEY
                // =====================================================

                string reportKeyString =
                    Request.Form["ReportKey"] ?? "";


                Guid reportKey;


                if (!Guid.TryParse(
                    reportKeyString,
                    out reportKey))
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


                List<DataKlaimLossRatio> data =
                    GetDataKlaimLossRatioPaged(
                        reportKey,
                        start,
                        length,
                        search,
                        orderColumn,
                        orderDir,
                        out recordsTotal,
                        out recordsFiltered
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
                            new List<DataKlaimLossRatio>()
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