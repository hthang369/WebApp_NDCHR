using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region FAAssetUpgrades
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:FAAssetUpgradesController
	//Created Date:04 Tháng Giêng 2012
	//-----------------------------------------------------------
	
	public class FAAssetUpgradesController:BaseBusinessController
	{
		public FAAssetUpgradesController()
		{
			dal= new DALBaseProvider("FAAssetUpgrades",typeof(FAAssetUpgradesInfo));
		}
        public double GettUpgradeLifeByFAAset(int iAssetID)
        {
            String str = String.Format(@"SELECT SUM(a.FAAssetUpgradeItemLife) FROM FAAssetUpgradeItems a 
INNER JOIN FAAssetUpgrades ON a.AAStatus='Alive' AND b.AAStatus='Alive'
    AND FK_FAAssetID={0}
", iAssetID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return 0;
        }

        // V.Hung add 31/07/2015 Lấy danh sách ghi tăng của TSCD sau ngày nào đó
        public DataSet GetAllDataByAssetAfterDate(int iFAAssetID, DateTime dtDateTime)
        {
            string strQuery = string.Format(@"SELECT  *
                                FROM    dbo.FAAssetUpgrades
                                        INNER JOIN dbo.FAAssetUpgradeItems ON dbo.FAAssetUpgrades.FAAssetUpgradeID = dbo.FAAssetUpgradeItems.FK_FAAssetUpgradeID
                                              AND dbo.FAAssetUpgrades.AAStatus = 'Alive'
                                              AND dbo.FAAssetUpgradeItems.AAStatus = 'Alive'
                                              AND dbo.FAAssetUpgradeItems.FK_FAAssetID = {0}
                                              AND CONVERT(NVARCHAR(10), dbo.FAAssetUpgrades.FAAssetUpgradeDate, 112) > CONVERT(NVARCHAR(10), '{1}', 112)", iFAAssetID, dtDateTime.ToString("yyyyMMdd"));
            return GetDataSet(strQuery);
        }
	}
	#endregion
}