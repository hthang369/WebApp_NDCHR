﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region FAAssetDecreaseItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:FAAssetDecreaseItemsController
	//Created Date:Wednesday, December 14, 2011
	//-----------------------------------------------------------
	
	public class FAAssetDecreaseItemsController:BaseBusinessController
	{
		public FAAssetDecreaseItemsController()
		{
			dal= new DALBaseProvider("FAAssetDecreaseItems",typeof(FAAssetDecreaseItemsInfo));
		}

        public Boolean CheckFAAsset(int iAssetID)
        {
            String str = String.Format(@"SELECT * FROM FAAssetDecreaseItems WHERE AAStatus='Alive' AND FK_FAAssetID={0} AND FK_FAAssetDecreaseID IN (SELECT FAAssetDecreaseID FROM FAAssetDecreases WHERE AAStatus='Alive')", iAssetID);
            DataSet ds=dal.GetDataSet(str);
            if (ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        public double GetLifeByFAAset(int iAssetID)
        {
            return GetLifeByFAAset(iAssetID, DateTime.MaxValue);
        }
        public double GetLifeByFAAset(int iAssetID,DateTime dtTo)
        {
            return GetSumColAmtByAsset(iAssetID, DateTime.MaxValue, "FAAssetDecreaseItemLife");
        }
        public double GetBookAmtByFAAset(int iAssetID)
        {
            return GetBookAmtByFAAset(iAssetID, DateTime.MaxValue);
        }
        public double GetBookAmtByFAAset(int iAssetID, DateTime dtTo)
        {
            return GetSumColAmtByAsset(iAssetID, dtTo, "FAAssetDecreaseItemNetBookAmt");
        }
        public double GetAccumDeprAmtByFAAset(int iAssetID)
        {
            return GetAccumDeprAmtByFAAset(iAssetID, DateTime.MaxValue);
        }
        public double GetAccumDeprAmtByFAAset(int iAssetID, DateTime dtTo)
        {
            return GetSumColAmtByAsset(iAssetID, dtTo, "FAAssetDecreaseItemAccumDeprAmt");
        }
        public double GetSumColAmtByAsset(int iAssetID, DateTime dtTo, string sColAmt)
        {
            String str = String.Format(@"SELECT SUM({1})
FROM FAAssetDecreaseItems a 
INNER JOIN FAAssetDecreases b ON a.FK_FAAssetDecreaseID = b.FAAssetDecreaseID
    AND a.AAStatus='Alive' AND b.AAStatus='Alive'
    AND FK_FAAssetID={0}
", iAssetID, sColAmt);
            if (dtTo < DateTime.MaxValue & dtTo > DateTime.MinValue)
            { 
                str += string.Format(@" AND FAAssetDecreaseDate <= '{0}'",dtTo.ToString("yyyyMMdd"));
            }
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return 0;
        }

        // V.Hung add 24/08/2015 Lấy danh sách ghi giảm TSCĐ
        public DataSet GetAllDataByAssset(int iFAAssetID)
        {
            string strQuery = string.Format(@"SELECT  FAAssetDecreaseItems.*
                                                FROM    dbo.FAAssetDecreaseItems
                                                        INNER JOIN dbo.FAAssetDecreases ON dbo.FAAssetDecreaseItems.FK_FAAssetDecreaseID = dbo.FAAssetDecreases.FAAssetDecreaseID
                                                            AND dbo.FAAssetDecreaseItems.AAStatus = 'Alive'
                                                            AND dbo.FAAssetDecreases.AAStatus = 'Alive'
                                                            AND FK_FAAssetID = {0}", iFAAssetID);
            return GetDataSet(strQuery);
        }
	}
	#endregion
}