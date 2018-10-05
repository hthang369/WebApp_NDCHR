using DevExpress.Web;
using DevExpress.Web.Mvc;
using ExpertERPWeb.BaseEntities;
using ExpertWebLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DXWebApp.Helpers
{
    public static class HtmlControls
    {
        public static MvcHtmlString GroupPanel(this HtmlHelper helper, string title, string content, string footer = "")
        {
            StringBuilder str = new StringBuilder("<div class=\"panel panel-default\">");
            if (!string.IsNullOrEmpty(title))
                str.AppendLine(string.Format("<div class=\"panel-heading\">{0}</div>", title));
            str.AppendLine("<div class=\"panel-body\">");
            str.AppendLine(content);
            str.AppendLine("</div> <!-- panel-body -->");
            if (!string.IsNullOrEmpty(footer))
            {
                str.AppendLine("<div class=\"panel-footer\">");
                str.AppendLine(footer);
                str.AppendLine("</div> <!-- panel-footer -->");
            }
            str.AppendLine("</div> <!-- panel panel-default -->");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString GroupPanelStartTag(this HtmlHelper helper, string title)
        {
            StringBuilder str = new StringBuilder("<div class=\"panel panel-default\">");
            str.AppendLine(string.Format("<div class=\"panel-heading\">{0}</div>", title));
            str.AppendLine("<div class=\"panel-body\">");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString GroupPanelEndTag(this HtmlHelper helper, string footer = "")
        {
            StringBuilder str = new StringBuilder("</div> <!-- panel-body -->");
            if (!string.IsNullOrEmpty(footer))
            {
                str.AppendLine("<div class=\"panel-footer\">");
                str.AppendLine(footer);
                str.AppendLine("</div> <!-- panel-footer -->");
            }
            str.AppendLine("</div> <!-- panel panel-default -->");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString ModalPanel(this HtmlHelper helper, string title, string content, string footer = "")
        {
            StringBuilder str = new StringBuilder("<div class=\"modal-content\">");
            str.AppendLine("<div class=\"modal-header\">");
            str.AppendLine("<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            str.AppendLine(string.Format("<h4 class=\"modal-title\">{0}</h4>", title));
            str.AppendLine("</div> <!-- modal-header -->");
            str.AppendLine("<div class=\"modal-body no-padding\">");
            str.AppendLine(content);
            str.AppendLine("</div> <!-- modal-body -->");
            if (!string.IsNullOrEmpty(footer))
            {
                str.AppendLine("<div class=\"modal-footer\">");
                str.AppendLine(footer);
                str.AppendLine("</div> <!-- modal-footer -->");
            }
            str.AppendLine("</div> <!-- modal-content -->");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString ModalPanelStartTag(this HtmlHelper helper, string title)
        {
            StringBuilder str = new StringBuilder("<div class=\"modal-content\">");
            str.AppendLine("<div class=\"modal-header\">");
            str.AppendLine("<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            str.AppendLine(string.Format("<h4 class=\"modal-title\">{0}</h4>", title));
            str.AppendLine("</div> <!-- modal-header -->");
            str.AppendLine("<div class=\"modal-body no-padding\">");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString ModalPanelEndTag(this HtmlHelper helper, string footer = "")
        {
            StringBuilder str = new StringBuilder("</div> <!-- modal-body -->");
            if (!string.IsNullOrEmpty(footer))
            {
                str.AppendLine("<div class=\"modal-footer\">");
                str.AppendLine(footer);
                str.AppendLine("</div> <!-- modal-footer -->");
            }
            str.AppendLine("</div> <!-- modal-content -->");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString FormPanel(this HtmlHelper helper, string strHtml, string strClass = "form-horizontal")
        {
            StringBuilder str = new StringBuilder(string.Format("<div class=\"{0}\">", strClass));
            str.AppendLine(strHtml);
            str.AppendLine("</div> <!-- end form-horizontal -->");
            return new MvcHtmlString(str.ToString());
        }
        public static MvcHtmlString FormControlPanel(this HtmlHelper helper, string objLabel, string objContent, string strClass = "col-sm-4")
        {
            StringBuilder tag = new StringBuilder();
            TagBuilder tagDiv = new TagBuilder("div");
            tagDiv.AddCssClass(strClass);
            tagDiv.InnerHtml = objContent;
            tag.Append(objLabel);
            tag.AppendLine(tagDiv.ToString());
            return new MvcHtmlString(tag.ToString());
        }
        public static MvcHtmlString FormGroupControlPanel(this HtmlHelper helper, string strContent, string strClass = "form-group")
        {
            TagBuilder tag = new TagBuilder("div");
            tag.AddCssClass(strClass);
            tag.InnerHtml = strContent;
            return new MvcHtmlString(tag.ToString());
        }
        public static ComboBoxProperties InitColumnLookupEdit(ComboBoxProperties cboProperty, STGridColumnsInfo objGridColumnInfo)
        {
            string sTGridColumnRepository = objGridColumnInfo.STGridColumnRepository;
            if (string.IsNullOrEmpty(sTGridColumnRepository))
            {
                //GMCDbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(objGridColumnInfo.STGridColumnTableName, objGridColumnInfo.STGridColumnName);
            }
            string lookupQueryColumn = GetLookupQueryColumn(objGridColumnInfo);
            TryToInitLookupTable(sTGridColumnRepository, lookupQueryColumn);
            if (!GMCWebApp.LookupTables.ContainsKey(sTGridColumnRepository))
            {
                return null;
            }
            DataView dvLookupTable = new DataView();
            string strPrimaryRepostory = GMCDbUtil.GetTablePrimaryColumn(sTGridColumnRepository);
            if (GMCDbUtil.IsForeignKey(sTGridColumnRepository, objGridColumnInfo.STGridColumnRepoDsplMem))
            {
                string primaryTableWhichForeignColumnReferenceTo = GMCDbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(sTGridColumnRepository, objGridColumnInfo.STGridColumnRepoDsplMem);
                if (!string.IsNullOrEmpty(primaryTableWhichForeignColumnReferenceTo))
                {
                    string str7 = GMCWebApp.GetLookupQueryColumn(primaryTableWhichForeignColumnReferenceTo);
                    if (string.IsNullOrEmpty(str7))
                        str7 = "*";
                    else
                        str7 = str7.Replace(",", ",b.");
                    string strQuery = string.Format("SELECT a.{0},b.{5}\r\n                        FROM {1} a\r\n                        INNER JOIN {2} b ON a.{3} = b.{4}", new object[] { strPrimaryRepostory, sTGridColumnRepository, primaryTableWhichForeignColumnReferenceTo, objGridColumnInfo.STGridColumnRepoDsplMem, GMCDbUtil.GetTablePrimaryColumn(primaryTableWhichForeignColumnReferenceTo), str7 });
                    DataSet dataSet = BusinessControllerFactory.GetBusinessController(sTGridColumnRepository + "Controller").GetDataSet(strQuery);
                    if ((dataSet != null) && (dataSet.Tables.Count > 0))
                    {
                        string strLookupTableName = sTGridColumnRepository + "_" + primaryTableWhichForeignColumnReferenceTo;
                        dvLookupTable = dataSet.Tables[0].DefaultView;
                        if (!GMCWebApp.LookupTables.ContainsKey(strLookupTableName))
                        {
                            GMCWebApp.LookupTables.Add(strLookupTableName, dataSet.Tables[0]);
                        }
                        else
                        {
                            GMCWebApp.LookupTables[strLookupTableName] = dataSet.Tables[0];
                        }
                    }
                }
            }
            else
                dvLookupTable = GMCWebApp.LookupTables[sTGridColumnRepository].DefaultView;
            string sTGridColumnRepoDsplMem = objGridColumnInfo.STGridColumnRepoDsplMem;
            if (!dvLookupTable.Table.Columns.Contains(sTGridColumnRepoDsplMem)) sTGridColumnRepoDsplMem = "";
            if (string.IsNullOrEmpty(sTGridColumnRepoDsplMem))
            {
                sTGridColumnRepoDsplMem = strPrimaryRepostory.Substring(0, strPrimaryRepostory.Length - 2) + "No";
            }
            if (GMCDbUtil.IsForeignKey(sTGridColumnRepository, objGridColumnInfo.STGridColumnRepoDsplMem))
            {
                string str13 = GMCDbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(sTGridColumnRepository, objGridColumnInfo.STGridColumnRepoDsplMem);
                if (string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoCol1))
                {
                    sTGridColumnRepoDsplMem = str13.Substring(0, str13.Length - 1) + "No";
                }
                else
                {
                    sTGridColumnRepoDsplMem = objGridColumnInfo.STGridColumnRepoCol1;
                }
            }
            if(cboProperty == null)
                cboProperty = new ComboBoxProperties();
            DataTable dtLookupTable = dvLookupTable.ToTable(false, strPrimaryRepostory, sTGridColumnRepoDsplMem);
            cboProperty.DataSource = dtLookupTable.DefaultView;
            cboProperty.TextField = sTGridColumnRepoDsplMem;
            cboProperty.ValueField = strPrimaryRepostory;
            cboProperty.ValueType = GMCDbUtil.GetCSharpVariableType(objGridColumnInfo.STGridColumnTableName, objGridColumnInfo.STGridColumnName);
            cboProperty.DropDownStyle = DropDownStyle.DropDownList;
            if (string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoCol1))
            {
                ListBoxColumn column = new ListBoxColumn(sTGridColumnRepoDsplMem);
                if (sTGridColumnRepoDsplMem.EndsWith("No"))
                {
                    column.Caption = "Mã số";
                    column.Width = 50;
                }
                else if (sTGridColumnRepoDsplMem.EndsWith("Name"))
                {
                    column.Caption = "Tên";
                    column.Width = 200;
                }
                cboProperty.Columns.AddColumn(dtLookupTable, column);
                if (!GMCDbUtil.IsForeignKey(sTGridColumnRepository, objGridColumnInfo.STGridColumnRepoDsplMem))
                {
                    ListBoxColumn column1 = new ListBoxColumn();
                    if (sTGridColumnRepoDsplMem.EndsWith("No"))
                    {
                        column1.FieldName = sTGridColumnRepoDsplMem.Substring(0, sTGridColumnRepoDsplMem.Length - 2) + "Name";
                        column1.Caption = GMCWebApp.GetControlText("Tên");
                        column1.Width = 200;
                    }
                    else if (sTGridColumnRepoDsplMem.EndsWith("Name"))
                    {
                        column1.FieldName = sTGridColumnRepoDsplMem.Substring(0, sTGridColumnRepoDsplMem.Length - 4) + "No";
                        column1.Caption = GMCWebApp.GetControlText("Mã số");
                        column1.Width = 50;
                    }
                    cboProperty.Columns.AddColumn(dtLookupTable, column1);
                }
            }
            else
            {
                ListBoxColumn info6 = new ListBoxColumn
                {
                    FieldName = objGridColumnInfo.STGridColumnRepoCol1,
                    Caption = GMCWebApp.GetControlText(objGridColumnInfo.STGridColumnRepoCol1Caption),
                    Width = 100
                };
                cboProperty.Columns.AddColumn(dtLookupTable, info6);
                if (!string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoCol2))
                {
                    ListBoxColumn info7 = new ListBoxColumn
                    {
                        FieldName = objGridColumnInfo.STGridColumnRepoCol2,
                        Caption = GMCWebApp.GetControlText(objGridColumnInfo.STGridColumnRepoCol2Caption),
                        Width = 100,
                    };
                    cboProperty.Columns.AddColumn(dtLookupTable, info7);
                }
                if (!string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoCol3))
                {
                    ListBoxColumn info8 = new ListBoxColumn
                    {
                        FieldName = objGridColumnInfo.STGridColumnRepoCol3,
                        Caption = GMCWebApp.GetControlText(objGridColumnInfo.STGridColumnRepoCol3Caption),
                        Width = 100
                    };
                    cboProperty.Columns.AddColumn(dtLookupTable, info8);
                }
                if (!string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoCol4))
                {
                    ListBoxColumn info9 = new ListBoxColumn
                    {
                        FieldName = objGridColumnInfo.STGridColumnRepoCol4,
                        Caption = GMCWebApp.GetControlText(objGridColumnInfo.STGridColumnRepoCol4Caption),
                        Width = 100
                    };
                    cboProperty.Columns.AddColumn(dtLookupTable, info9);
                }
                if (!string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoCol5))
                {
                    ListBoxColumn info10 = new ListBoxColumn
                    {
                        FieldName = objGridColumnInfo.STGridColumnRepoCol5,
                        Caption = GMCWebApp.GetControlText(objGridColumnInfo.STGridColumnRepoCol5Caption),
                        Width = 100
                    };
                    cboProperty.Columns.AddColumn(dtLookupTable, info10);
                }
            }
            if (!string.IsNullOrEmpty(objGridColumnInfo.STGridColumnRepoDsplMem))
            {
                int idx = cboProperty.Columns.Cast<ListBoxColumn>().ToList().FindIndex(x => x.FieldName.Equals(objGridColumnInfo.STGridColumnRepoDsplMem));
                if (idx != -1)
                    cboProperty.TextFormatString = "{" + idx.ToString() + "}";
            }
            return cboProperty;
        }
        private static void AddColumn(this ListBoxColumnCollection lstCol, DataTable dt, ListBoxColumn col)
        {
            if(col.FieldName.Length > 0 && dt.Columns.Contains(col.FieldName))
            {
                lstCol.Add(col);
            }
        }
        private static string GetLookupQueryColumn(STGridColumnsInfo objSTGridColumnsInfo)
        {
            string str = string.Empty;
            string tablePrimaryColumn = GMCDbUtil.GetTablePrimaryColumn(objSTGridColumnsInfo.STGridColumnRepository);
            str = str + string.Format("{0},", tablePrimaryColumn);
            string name = tablePrimaryColumn.Substring(0, tablePrimaryColumn.Length - 2) + "No";
            string str4 = tablePrimaryColumn.Substring(0, tablePrimaryColumn.Length - 2) + "Name";
            try
            {
                System.Type businessObjectType = BusinessObjectFactory.GetBusinessObject(objSTGridColumnsInfo.STGridColumnRepository + "Info").GetType();
                if (businessObjectType != null)
                {
                    if (businessObjectType.GetProperty(name) != null)
                    {
                        str = str + string.Format("{0},", name);
                    }
                    if (businessObjectType.GetProperty(str4) != null)
                    {
                        str = str + string.Format("{0},", str4);
                    }
                }
            }
            catch { }
            if (!string.IsNullOrEmpty(objSTGridColumnsInfo.STGridColumnRepoDsplMem) && ((!objSTGridColumnsInfo.STGridColumnRepoDsplMem.Equals(tablePrimaryColumn) && !objSTGridColumnsInfo.STGridColumnRepoDsplMem.Equals(name)) && !objSTGridColumnsInfo.STGridColumnRepoDsplMem.Equals(str4)))
            {
                str = str + string.Format("{0},", objSTGridColumnsInfo.STGridColumnRepoDsplMem);
            }
            if (!objSTGridColumnsInfo.STGridColumnRepoDsplMem.StartsWith("FK_"))
            {
                if (!string.IsNullOrEmpty(objSTGridColumnsInfo.STGridColumnRepoCol1) && ((!objSTGridColumnsInfo.STGridColumnRepoCol1.Equals(tablePrimaryColumn) && !objSTGridColumnsInfo.STGridColumnRepoCol1.Equals(name)) && !objSTGridColumnsInfo.STGridColumnRepoCol1.Equals(str4)))
                {
                    str = str + string.Format("{0},", objSTGridColumnsInfo.STGridColumnRepoCol1);
                }
                if (!string.IsNullOrEmpty(objSTGridColumnsInfo.STGridColumnRepoCol2) && ((!objSTGridColumnsInfo.STGridColumnRepoCol2.Equals(tablePrimaryColumn) && !objSTGridColumnsInfo.STGridColumnRepoCol2.Equals(name)) && !objSTGridColumnsInfo.STGridColumnRepoCol2.Equals(str4)))
                {
                    str = str + string.Format("{0},", objSTGridColumnsInfo.STGridColumnRepoCol2);
                }
                if (!string.IsNullOrEmpty(objSTGridColumnsInfo.STGridColumnRepoCol3) && ((!objSTGridColumnsInfo.STGridColumnRepoCol3.Equals(tablePrimaryColumn) && !objSTGridColumnsInfo.STGridColumnRepoCol3.Equals(name)) && !objSTGridColumnsInfo.STGridColumnRepoCol3.Equals(str4)))
                {
                    str = str + string.Format("{0},", objSTGridColumnsInfo.STGridColumnRepoCol3);
                }
                if (!string.IsNullOrEmpty(objSTGridColumnsInfo.STGridColumnRepoCol4) && ((!objSTGridColumnsInfo.STGridColumnRepoCol4.Equals(tablePrimaryColumn) && !objSTGridColumnsInfo.STGridColumnRepoCol4.Equals(name)) && !objSTGridColumnsInfo.STGridColumnRepoCol4.Equals(str4)))
                {
                    str = str + string.Format("{0},", objSTGridColumnsInfo.STGridColumnRepoCol4);
                }
                if (!string.IsNullOrEmpty(objSTGridColumnsInfo.STGridColumnRepoCol5) && ((!objSTGridColumnsInfo.STGridColumnRepoCol5.Equals(tablePrimaryColumn) && !objSTGridColumnsInfo.STGridColumnRepoCol5.Equals(name)) && !objSTGridColumnsInfo.STGridColumnRepoCol5.Equals(str4)))
                {
                    str = str + string.Format("{0},", objSTGridColumnsInfo.STGridColumnRepoCol5);
                }
            }
            if (GMCWebApp.LookupExColumsList.ContainsKey(objSTGridColumnsInfo.STGridColumnRepository))
            {
                str = str + string.Format("{0},", GMCWebApp.LookupExColumsList[objSTGridColumnsInfo.STGridColumnRepository]);
            }
            if (str.Substring(str.Length - 1).Equals(","))
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        public static bool TryToInitLookupTable(string strLookupTable, string strQueryColumn)
        {
            if (GMCWebApp.LookupTables == null)
            {
                GMCWebApp.InitLookupTables();
            }
            if (!GMCWebApp.LookupTables.ContainsKey(strLookupTable))
            {
                if (!string.IsNullOrEmpty(strLookupTable))
                {
                    DataSet allObjectForDataLookups = GetAllObjectForDataLookups(strLookupTable, strQueryColumn);
                    if ((allObjectForDataLookups != null) && (allObjectForDataLookups.Tables.Count > 0))
                    {
                        GMCWebApp.LookupTables.Add(strLookupTable, allObjectForDataLookups.Tables[0]);
                        GMCWebApp.LookupTablesUpdatedDate.Add(strLookupTable, DateTime.Now);
                    }
                }
                return true;
            }
            else if(GMCWebApp.LookupTables[strLookupTable].Columns.Count < strQueryColumn.Split(',').Length)
            {
                DataSet allObjectForDataLookups = GetAllObjectForDataLookups(strLookupTable, strQueryColumn);
                if ((allObjectForDataLookups != null) && (allObjectForDataLookups.Tables.Count > 0))
                {
                    GMCWebApp.LookupTables[strLookupTable] = allObjectForDataLookups.Tables[0];
                }
            }
            else
            {
                return true;
            }
            return false;
        }
        private static DataSet GetAllObjectForDataLookups(string strTableName, string strQueryColumn)
        {
            try
            {
                Type businessObjectType = BusinessObjectFactory.GetBusinessObject(strTableName + "Info").GetType();
                string strQueryCommand = string.Empty;
                if (businessObjectType != null)
                {
                    if (businessObjectType.GetProperty("AAStatus") != null)
                    {
                        strQueryCommand = string.Format("Select {0} From [{1}] Where [AAStatus]='Alive'", strQueryColumn, strTableName);
                    }
                    else
                    {
                        strQueryCommand = string.Format("Select {0} From [{1}]", strQueryColumn, strTableName);
                    }
                }
                else
                {
                    strQueryCommand = string.Format("Select {0} From [{1}]", strQueryColumn, strTableName);
                }
                return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(strQueryCommand));
            }
            catch{ }
            return null;
        }
        public static List<SelectListItem> GetDropDownListObjects(string sTableName, string sValueMember, string sDisplayMember, object sObjectNo = null)
        {
            DataSet ds = GetAllObjectForDataLookups(sTableName, string.Join(",", sValueMember, sDisplayMember));
            DataTable dt = null;
            if (ds != null && ds.Tables.Count > 0) dt = ds.Tables[0];
            return GetDropDownListObjects(dt, sValueMember, sDisplayMember, sObjectNo);
        }
        public static List<SelectListItem> GetDropDownListObjects(DataTable dtData, string sValueMember, string sDisplayMember, object sObjectNo = null)
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            if (dtData != null)
            {
                foreach (DataRow item in dtData.Rows)
                {
                    SelectListItem idx = new SelectListItem();
                    idx.Value = Convert.ToString(item[sValueMember]);
                    idx.Text = Convert.ToString(item[sDisplayMember]);
                    idx.Selected = Convert.ToString(sObjectNo).Equals(idx.Value);
                    lst.Add(idx);
                }
            }
            return lst;
        }
    }
}