﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region FAAssetDecreases
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:FAAssetDecreasesController
	//Created Date:Wednesday, December 14, 2011
	//-----------------------------------------------------------
	
	public class FAAssetDecreasesController:BaseBusinessController
	{
		public FAAssetDecreasesController()
		{
			dal= new DALBaseProvider("FAAssetDecreases",typeof(FAAssetDecreasesInfo));
		}
        
        //V.Hung add 31/07/2015 Lấy danh sách ghi giảm của TSCD sau ngày nào đó
        public DataSet GetAllDataByAssetAfterDate(int iFAAssetID, DateTime dtDateTime)
        {
            string strQuery = string.Format(@"SELECT  dbo.FAAssetDecreases.*
                    FROM    dbo.FAAssetDecreases
                            INNER JOIN dbo.FAAssetDecreaseItems ON dbo.FAAssetDecreases.FAAssetDecreaseID = dbo.FAAssetDecreaseItems.FK_FAAssetDecreaseID
                                                                   AND dbo.FAAssetDecreases.AAStatus = 'Alive'
                                                                   AND dbo.FAAssetDecreaseItems.AAStatus = 'Alive'
                                                                   AND dbo.FAAssetDecreaseItems.FK_FAAssetID = {0}
                                                                   AND CONVERT(NVARCHAR(10), dbo.FAAssetDecreases.FAAssetDecreaseDate, 112) > CONVERT(NVARCHAR(10), '{1}', 112)",iFAAssetID,dtDateTime.ToString("yyyyMMdd"));
            return GetDataSet(strQuery);
        }

        public FAAssetDecreasesInfo GetDataBrokenAndDisposeByAsset(int iFAAssetID)
        {
            string strQuery = string.Format(@"SELECT  TOP 1 dbo.FAAssetDecreases.*
FROM    dbo.FAAssetDecreaseItems
        INNER JOIN dbo.FAAssetDecreases ON dbo.FAAssetDecreases.FAAssetDecreaseID = dbo.FAAssetDecreaseItems.FK_FAAssetDecreaseID
                                           AND dbo.FAAssetDecreases.AAStatus = 'Alive'
                                           AND dbo.FAAssetDecreaseItems.AAStatus = 'Alive'
                                           AND ( dbo.FAAssetDecreaseItems.FAAssetDecreaseItemTypeCombo = 'BaoHong'
                                                 OR dbo.FAAssetDecreaseItems.FAAssetDecreaseItemTypeCombo = 'ThanhLy'
                                               )
                                           AND FK_FAAssetID = {0}", iFAAssetID);
            DataSet ds = GetDataSet(strQuery);
            FAAssetDecreasesInfo objFAAssetDecreaseInfo = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                objFAAssetDecreaseInfo = (FAAssetDecreasesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return objFAAssetDecreaseInfo;
        }
	}
	#endregion
}