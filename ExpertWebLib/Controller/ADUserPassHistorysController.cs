using System;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region ADUserPassHistorys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: ADUserPassHistorysController
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------
    
    public class ADUserPassHistorysController : BaseBusinessController
    {
        public ADUserPassHistorysController()
        {
            dal = new DALBaseProvider("ADUserPassHistorys",typeof(ADUserPassHistorysInfo));
        }
        public ADUserPassHistorysInfo CreatePassHistory(int pUserID, string pPass, int pTop)
        {
            ADUserPassHistorysInfo objectFromDataRow = null;
            if (pTop <= 0)
            {
                objectFromDataRow = new ADUserPassHistorysInfo
                {
                    ADUserPassHistoryPass = pPass,
                    FK_ADUserID = pUserID
                };
                this.CreateObject(objectFromDataRow);
                return objectFromDataRow;
            }
            string strQuery = string.Format("\r\nDECLARE @ADUserPassHistoryID INT\r\n\r\nSELECT *\r\nFROM (\r\n    SELECT TOP {1} *\r\n    FROM ADUserPassHistorys\r\n    WHERE FK_ADUserID = {0}\r\n    ORDER BY AAUpdatedDate DESC\r\n    ) a\r\nORDER BY AAUpdatedDate\r\n", pUserID, pTop);
            DataSet dataSet = this.GetDataSet(strQuery);
            if (((dataSet == null) || (dataSet.Tables.Count == 0)) || (dataSet.Tables[0].Rows.Count == 0))
            {
                objectFromDataRow = new ADUserPassHistorysInfo
                {
                    ADUserPassHistoryPass = pPass,
                    FK_ADUserID = pUserID
                };
                this.CreateObject(objectFromDataRow);
                return objectFromDataRow;
            }
            objectFromDataRow = (ADUserPassHistorysInfo)this.GetObjectFromDataRow(dataSet.Tables[0].Rows[0]);
            objectFromDataRow.ADUserPassHistoryPass = pPass;
            string[] psFieldName = new string[] { "ADUserPassHistoryPass" };
            this.UpdateObject(objectFromDataRow, true, psFieldName);
            return objectFromDataRow;
        }

        public bool IsOldPassExpired(int pUserID, int pDay)
        {
            string strQuery = string.Format(@"
    DECLARE @LastDate AS DATETIME

    SELECT TOP 1 @LastDate = AAUpdatedDate
    FROM ADUserPassHistorys
    WHERE FK_ADUserID = {0}
    ORDER BY AAUpdatedDate DESC

    IF @LastDate IS NOT NULL
    BEGIN
        DECLARE @Day AS INT
        SET @Day = DATEDIFF(day, @LastDate, GetDate())
        IF DATEDIFF(day, @LastDate, GetDate()) >= {1}
            SELECT @Day
    END
    ELSE
        SELECT 0", pUserID, pDay);
            DataSet dataSet = this.GetDataSet(strQuery);
            return (((dataSet != null) && (dataSet.Tables.Count > 0)) && (dataSet.Tables[0].Rows.Count > 0));
        }

        public bool IsSameHistory(int pUserID, string pPass, int pTop)
        {
            string strQuery = string.Format(@"
SELECT TOP 1 1
FROM (
    SELECT TOP {0} ADUserPassHistoryPass
    FROM ADUserPassHistorys
    WHERE FK_ADUserID = {1}
    ORDER BY AAUpdatedDate DESC
) a
WHERE ADUserPassHistoryPass = '{2}'", pTop, pUserID, pPass.Replace("'", "''"));
            DataSet dataSet = this.GetDataSet(strQuery);
            return (((dataSet != null) && (dataSet.Tables.Count > 0)) && (dataSet.Tables[0].Rows.Count > 0));
        }
    }
    #endregion
}