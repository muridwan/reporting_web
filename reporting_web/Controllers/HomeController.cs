using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reporting_web.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using reporting_web.Security;

namespace reporting_web.Controllers
{
    public class HomeController : Controller
    {
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
            
            return View();
        }

        public ActionResult About()
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
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

            ViewBag.Message = "Pleas Contact Your Administrator";

            return View();
        }

        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
             DataCOB entities = new DataCOB();
            var cob_tables = (from cob_table in entities.COBs
                             where cob_table.DESCRIPTION.Contains(prefix)  || cob_table.COB1.Contains(prefix)
                              select new
                             {
                                 label = cob_table.COB1 + "-" + cob_table.DESCRIPTION,
                                 val = cob_table.COB1
                             }).ToList();

            return Json(cob_tables);
        }
        [HttpGet]
        public JsonResult GetSumProduksiKlaim(string SDate, string EDate, string spName, string stoken="", int iroleid=0)
        {
            if (spName != "")
            {
                var list = GetListSumProduksiKlaim(SDate, EDate, spName, stoken, iroleid);
                return Json
                (new
                    {
                        data = list,
                        recordsTotal = list.Count,
                        recordsFiltered = 0
                    }, JsonRequestBehavior.AllowGet
                );

            }
            else
                return null;
        }

        public List <DataSumProduksiKlaim> GetListSumProduksiKlaim(string SDate, string EDate, string spName, string token="", int roleid=0)
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
                if (token!="")
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
                var list = ConvertDataTableToList<DataSumProduksiKlaim>(dt);
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
        private static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
            }
            Console.ReadLine();
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
    }
}