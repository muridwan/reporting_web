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

namespace reporting_web.Controllers
{
    public class KlaimController : Controller
    {
        // GET: Klaim
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

        public ActionResult GetDataSettleKlaim()
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

        public ActionResult DataKlaimSubro()
        {
            using (DataBranch db = new DataBranch())
            {
                var result = (from BranchList in db.Branches select BranchList).ToList();
                if (result != null)
                {
                    ViewBag.BranchCode = result.Select(x => new SelectListItem { Text = x.Name, Value = x.Branch1.ToString() });
                }
            }
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

        public JsonResult GetDataKlaimDate2(string SDate, string EDate, string TypeReport, List<string> ListTOC,List<string> ListBranch, string COB = "%", string TOC = "%", string Branch = "%", string stoken = "", int iroleid = 0)
        {
            if (TypeReport != "")
            {
                string spName = "";

                if (TypeReport == "PERSENKLAIMSUBRO")
                    spName = "spGetPersenKlaimSubroCbg";
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

        public JsonResult GetDataKlaimDate(string SDate, string EDate, string TypeReport, List<string> ListTOC, string COB = "%", string TOC = "%", string stoken = "", int iroleid = 0)
        {
            if (TypeReport != "")
            {
                string spName="";

                if (TypeReport == "PERSENKLAIMCBG")
                    spName = "spGetPersenKlaimCbg";
                else if (TypeReport == "PERSENKLAIMUY")
                    spName = "spGetPersenKlaimUY";
                else if (TypeReport == "PERSENKLAIMCOL")
                    spName = "spGetPersenKlaimCOL";
                else if (TypeReport == "PERSENKLAIMUSIADIE")
                    spName = "spGetPersenJumKlaimUsiaDie";
                else if (TypeReport == "PERSENKLAIMWAKTUDIE")
                    spName = "spGetPersenJumKlaimWaktuDie";
                else if (TypeReport == "PERSENKLAIMUSIAWAKTUDIE")
                    spName = "spGetPersenJumKlaimWaktuUsiaDie";
                else if (TypeReport == "PERSENKLAIMDESCLOSSDIE")
                    spName = "spGetPersenKlaimDescLossDie";
                else if (TypeReport == "PERSENKLAIMUSIAPHK")
                    spName = "spGetPersenJumKlaimUsiaPHK";
                else if (TypeReport == "PERSENKLAIMUSIAKRM")
                    spName = "spGetPersenJumKlaimUsiaKrm";
                else if (TypeReport == "PERSENKLAIMCOB")
                    spName = "spGetPersenKlaimCob";
                else if (TypeReport == "PERSENKLAIMSUBRO")
                    spName = "spGetPersenKlaimSubroCbg";
                var list = GetDataPersenKlaim(SDate, EDate, spName, COB, TOC, ListTOC, stoken, iroleid); // list of records to be displayed in datatable
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