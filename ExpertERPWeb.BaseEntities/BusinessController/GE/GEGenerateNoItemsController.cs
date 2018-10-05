using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEGenerateNoItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEGenerateNoItemsController
	//Created Date:14 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class GEGenerateNoItemsController:BaseBusinessController
	{
		public GEGenerateNoItemsController()
		{
			dal= new DALBaseProvider("GEGenerateNoItems",typeof(GEGenerateNoItemsInfo));
		}

        public DataSet GetAllDataByGenerateNoANDOrderBy(int iGEGenerateNoID)
        {
            String str = String.Format(@"SELECT * FROM dbo.GEGenerateNoItems
                                        WHERE FK_GEGenerateNoID = {0}
                                        ORDER BY GEGenerateNoItemOrderBy ASC
                                    ", iGEGenerateNoID);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}