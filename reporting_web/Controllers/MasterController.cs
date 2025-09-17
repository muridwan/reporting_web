using reporting_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reporting_web.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult getCOB(string cobid)
        {
            DataCOB entities = new DataCOB();
            var cob_tables = (from cob_table in entities.COBs
                              where cob_table.COB1.Equals(cobid)
                              select new
                              {
                                  label = cob_table.DESCRIPTION,
                                  val = cob_table.COB1
                              }).ToList();

            return Json(cob_tables, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult getTOC(string cobid)
        {
            DataTOC entities = new DataTOC();
            var toc_tables = (from toc_table in entities.TOCs
                              where toc_table.COB.Equals(cobid)
                              select new
                              {
                                  label = toc_table.DESCRIPTION,
                                  val = toc_table.TOC1
                              }).ToList();

            return Json(toc_tables, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult getsysInfo(string stype)
        {
            DatasysInfo entities = new DatasysInfo();
            var sysinfo_tables = (from sysinfo_table in entities.sysInfos
                                  where sysinfo_table.Type.Equals(stype)
                                  select new
                                  {
                                      datecomplete = sysinfo_table.DateComplete.ToString(),
                                      description = sysinfo_table.Description
                                  }).ToList();
            return Json(sysinfo_tables, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult getBranch(string kdcbg)
        {
            DataBranch entities = new DataBranch();
            var branch_tables = (from branch_table in entities.Branches
                                  where branch_table.Branch1.Equals(kdcbg)
                                  select new
                                  {
                                      Branch = branch_table.Branch1.ToString(),
                                      Name = branch_table.Name
                                  }).ToList();
            return Json(branch_tables, JsonRequestBehavior.AllowGet);
        }
    }
}