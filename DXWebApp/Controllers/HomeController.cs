using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DXWebApp.Models;
using System.Collections;
using System.Data;
using ExpertERPProcedure.Utilities;
using DevExpress.Web.Mvc;
using ExpertERPWeb.BaseEntities;
using ExpertERP.BusinessEntities;

namespace DXWebApp.Controllers
{
    public class HomeController : Controller
    {
        public object Grid;
        public ActionResult Index()
        {
            if (AuthConfig.GetSession("CurrentUser") != null)
            {
                ViewData["title"] = AuthConfig.CurrentCompanyInfo.CSCompanyDesc;
                HREmployeesInfo EmployeeInfo = GMCWebApp.GetEmployeeByUserName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
                if (EmployeeInfo == null) EmployeeInfo = new HREmployeesInfo();
                ViewData["EmployeeInfo"] = EmployeeInfo;
                ViewData["lstBranchs"] = Helpers.HtmlControls.GetDropDownListObjects("BRBranchs", "BRBranchID", "BRBranchName", EmployeeInfo.FK_BRBranchID);
                ViewData["lstPositions"] = Helpers.HtmlControls.GetDropDownListObjects("HRPositions", "HRPositionID", "HRPositionName", EmployeeInfo.FK_HRPositionID);
                ViewData["lstSections"] = Helpers.HtmlControls.GetDropDownListObjects("HRSections", "HRSectionID", "HRSectionName", EmployeeInfo.FK_HRSectionID);
                ViewData["lstAreas"] = Helpers.HtmlControls.GetDropDownListObjects("HRAreas", "HRAreaID", "HRAreaName", EmployeeInfo.FK_HRAreaID);
                HomeModels home = new HomeModels();
                foreach (KeyValuePair<string, double> item in home.GetTonPhepTheoNhanVien(EmployeeInfo))
                {
                    ViewData[item.Key] = item.Value;
                }
                if (AuthConfig.GetSession("TongNgayPhep") == null)
                    AuthConfig.SetSession("TongNgayPhep", ViewData["ConLai"]);
                //DevExpress.Web.Localization.ASPxGridViewLocalizer.Active = 
                return View();
            }
            else
                return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult CheckSession()
        {
            if (AuthConfig.GetSession("CurrentUser") == null)
                return Content("FAIL");
            else
                return Content(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
        }
        [HttpPost]
        public ActionResult ClearCacheBrowser()
        {
            string str = "OK";
            try
            {
                WebBrowserHelper.ClearCache();
                str = "OK";
            }
            catch { str = "FAIL"; }
            return Content(str);
        }
        public static GridViewModel CreateGridView()
        {
            var viewModel = new GridViewModel();
            return viewModel;
        }
    }
}

public enum HeaderViewRenderMode { Full, Title, Panel }