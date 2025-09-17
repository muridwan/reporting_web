using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reporting_web.Models;
using System.Security.Cryptography;
using System.IO;

namespace reporting_web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult ValidateUser(string userid, string password)
        {
            DataLogin db = new DataLogin();
            string passencrypt = Encryptor(password, "PAASW0rd"); //HtmMRllBRhg= Encrypt dari 12345
            var data = from c in db.tblUsers where c.EmpId == userid && c.Password == passencrypt select c;
            if (data.Count() > 0)
            {
                foreach(var item in data)
                {
                    Session["EmpId"] = item.EmpId;
                    Session["UserName"] = item.Username;
                    Session["Token"] = item.Token;
                    Session["RoleId"] = item.RoleId;
                    
                }

                //return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
                return Json(new { Success = true, EmpID = Session["EmpId"], UserName = Session["UserName"], Token = Session["Token"] }, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SignOut()
        {
            Session.Abandon();
            Session["EmpId"] = null;
            Session["UserName"] = null;
            Session["RoleId"] = null;
            return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult ChangePassword(string password, string newpassword)
        {
            DataLogin db = new DataLogin();
            string userid = Session["EmpId"].ToString();
            string passencrypt = Encryptor(password, "PAASW0rd");
            var data = from c in db.tblUsers where c.EmpId == userid && c.Password == passencrypt select c;
            if (data.Count() > 0)
            {                
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        foreach(var item in data)
                        {
                            item.Password = Encryptor(newpassword,"PAASW0rd");                                                      
                            db.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch(Exception)
                    {
                        transaction.Rollback();
                    }
                }
                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
        }

        public string Encryptor(string strText, string EncrKey)
        {
            byte[] byKey = { };
            byte[] IV =
              {
            18,52,86,120,144,171,205,239
        };
            byKey = System.Text.Encoding.UTF8.GetBytes(EncrKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(strText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }


        public string DecryptFromBase64String(string stringToDecrypt, string EncryptionKey)
        {
            byte[] inputByteArray = new byte[stringToDecrypt.Length];
            byte[] byKey = { };
            byte[] IV =
            {
            18,52,86,120,144,171,205,239
        };
            byKey = System.Text.Encoding.UTF8.GetBytes(EncryptionKey);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(stringToDecrypt);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }

    }
}