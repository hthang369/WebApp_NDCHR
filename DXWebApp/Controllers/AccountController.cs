
using DXWebApp.Models;
using ExpertWebLib;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DXWebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login()
        {
            //System.Web.HttpContext.Current.Response.Write("<script>alert('ok');</script>");
            ViewBag.Title = Properties.Settings.Default.WebTitle;
            LoginModel log = new LoginModel();
            string strRecentUser = AuthConfig.GetCookie("RecentUser");
            if (string.IsNullOrEmpty(strRecentUser))
                strRecentUser = AuthConfig.GetValueConfigSettings("RecentUser");
            //log.UserName = strRecentUser;
            log.WorkingDate = DateTime.Today;
            ViewData["lstSrv"] = log.InitCompanys();
            return View(log);
        }
        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string strSrv = model.Server;
                string strStatus = AuthConfig.LogIn(strSrv, model.UserName, model.Password, model.WorkingDate);
                if (string.IsNullOrEmpty(strStatus))
                    return Redirect(returnUrl ?? "/");
                else
                    ModelState.AddModelError("LoginFaild", strStatus/*"The user name or password provided is incorrect."*/);
            }
            ViewBag.Title = Properties.Settings.Default.WebTitle;
            ViewData["lstSrv"] = new LoginModel().InitCompanys();
            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            AuthConfig.LogOff();
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        public ActionResult ResetPassword()
        {
            ViewBag.Title = Properties.Settings.Default.WebTitle;
            ViewData["lstSrv"] = new LoginModel().InitCompanys();
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPassword(ResetPassWordModel model)
        {
            if (ModelState.IsValid)
            {
                string strCMND = model.CMND;
                string strSrv = model.Server;
                AuthConfig.ConnectionAuth(strSrv);
                AccountModels acc = new AccountModels();
                ADUsersInfo user = acc.GetEmployeeUserByIDNumber(strCMND);
                if (user == null)
                    ModelState.AddModelError("ResetPasswordFaild", "The CMND provided is incorrect.");
                else
                {
                    AuthConfig.SetSession("UserName", user.ADUserName);
                    return Redirect("ChangePassword");
                }
            }
            ViewBag.Title = Properties.Settings.Default.WebTitle;
            ViewData["lstSrv"] = new LoginModel().InitCompanys();
            return View(model);
        }
        public ActionResult ChangePassword()
        {
            ViewBag.Title = Properties.Settings.Default.WebTitle;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                Crypto crypto = new Crypto();
                string strPass = crypto.Encrypt(model.NewPassword);
                string strConfirm = crypto.Encrypt(model.ConfirmPassword);
                if(strPass != strConfirm)
                    ModelState.AddModelError("ChangePasswordFaild", "The Password provided is incorrect.");
                else
                {
                    ADUsersInfo userInfo = new ADUsersController().GetObjectByName(Convert.ToString(AuthConfig.GetSession("UserName"))) as ADUsersInfo;
                    userInfo.ADPassword = strConfirm;
                    new ADUsersController().UpdateObject(userInfo, false, "ADPassword");
                    return Redirect("Login");
                }
            }
            ViewBag.Title = Properties.Settings.Default.WebTitle;
            return View(model);
        }
    }
    //public class WebMsgBox
    //{
    //    protected static Hashtable handlerPages = new Hashtable();
    //    private WebMsgBox()
    //    {
    //    }
    //    public static void Show(string Message)
    //    {
    //        if (!(handlerPages.Contains(HttpContext.Current.Handler)))
    //        {
    //            Page currentPage = (Page)HttpContext.Current.Handler;
    //            if (!((currentPage == null)))
    //            {
    //                Queue messageQueue = new Queue();
    //                messageQueue.Enqueue(Message);
    //                handlerPages.Add(HttpContext.Current.Handler, messageQueue);
    //                currentPage.Unload += new EventHandler(CurrentPageUnload);
    //            }
    //        }
    //        else
    //        {
    //            Queue queue = ((Queue)(handlerPages[HttpContext.Current.Handler]));
    //            queue.Enqueue(Message);
    //        }
    //    }
    //    private static void CurrentPageUnload(object sender, EventArgs e)
    //    {
    //        Queue queue = ((Queue)(handlerPages[HttpContext.Current.Handler]));
    //        if (queue != null)
    //        {
    //            StringBuilder builder = new StringBuilder();
    //            int iMsgCount = queue.Count;
    //            builder.Append("<script language='javascript'>");
    //            string sMsg;
    //            while ((iMsgCount > 0))
    //            {
    //                iMsgCount = iMsgCount - 1;
    //                sMsg = System.Convert.ToString(queue.Dequeue());
    //                sMsg = sMsg.Replace("\"", "'");
    //                builder.Append("alert( \"" + sMsg + "\" );");
    //            }
    //            builder.Append("</script>");
    //            handlerPages.Remove(HttpContext.Current.Handler);
    //            HttpContext.Current.Response.Write(builder.ToString());
    //        }
    //    }
    //}
}