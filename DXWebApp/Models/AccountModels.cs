using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Xml.Linq;
using System.Linq;
using ExpertWebLib;

namespace DXWebApp.Models
{
    public class ChangePasswordModel
    {
        //[Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ResetPassWordModel
    {
        [Required]
        [MinLength(9)]
        [MaxLength(12)]
        //[RegularExpression("[0-9]", ErrorMessage = "Please enter a valid CMND.")]
        [Display(Name = "CMND")]
        public string CMND { get; set; }

        [Required]
        [Display(Name = "Server")]
        public string Server { get; set; }
    }
    public class LoginModel
    {
        XDocument xDoc;
        public LoginModel()
        {
            xDoc = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath(AuthConfig.strFilePath));
        }
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Server")]
        public string Server { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "WorkingDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime WorkingDate { get; set; }

        bool? rememberMe;
        [Display(Name = "Remember me?")]
        public bool? RememberMe
        {
            get { return rememberMe ?? false; }
            set { rememberMe = value; }
        }

        public List<SelectListItem> InitCompanys()
        {
            var xElements = xDoc.Element("Servers").Elements("item");
            XDocument xDocCfg = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath(AuthConfig.strCfgPath));
            var xElementCfgs = xDocCfg.Element("configs").Elements("item");
            List<SelectListItem> lst = new List<SelectListItem>();
            string strSvr = AuthConfig.GetCookie("Server");
            if(xElementCfgs.FirstOrDefault() != null && string.IsNullOrEmpty(strSvr))
                strSvr = xElementCfgs.Where(x=>x.Attribute("Key").Value.Equals("Server")).Select(x=>x.Attribute("Value").Value).FirstOrDefault();
            
            foreach (var item in xElements)
            {                
                SelectListItem items = new SelectListItem();
                items.Text = item.Value;
                items.Value = item.Attribute("Name").Value;
                items.Selected = item.Attribute("Server").Value.Equals(strSvr);
                lst.Add(items);
            }
            return lst;
        }
    }
    public class RegisterModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class AccountModels
    {
        public ADUsersInfo GetEmployeeUserByIDNumber(string sNumber)
        {
            DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetEmployeeUserByIDNumber", sNumber);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return new ADUsersController().GetObjectFromDataRow(ds.Tables[0].Rows[0]) as ADUsersInfo;
            return null;
        }
    }
}