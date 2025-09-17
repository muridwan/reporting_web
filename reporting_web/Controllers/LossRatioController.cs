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
    public class LossRatioController : Controller
    {
        // GET: LossRatio
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
        public ActionResult ViewLossRatio()
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
        public ActionResult ViewLossRatioCbg()
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
                SqlExtensionsForLR.QuickOpen(connection, 120);
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

        public List<DataLR> GetDataLR(string SDate, string EDate, string spName)
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
                var list = ConvertDataTableToList<DataLR>(dt);
                return list;
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);
                return null;
            }

        }

        public JsonResult GetDataLRJson(string SDate, string EDate, string TypeReport)
        {
            if (TypeReport != "")
            {
                string spName = "";

                if (TypeReport == "LOSSRATIO")
                    spName = "spGetLossRatio";
                else if (TypeReport == "LOSSRATIOCBG")
                    spName = "spGetLossRatioCbg";
                var list = GetDataLR(SDate, EDate, spName); // list of records to be displayed in datatable
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

    public static class SqlExtensionsForLR
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

    
