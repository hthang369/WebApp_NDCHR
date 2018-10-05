
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductIntermediates
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.80)
	//Class: ICProductIntermediatesController
	//Created Date: Friday, 11 Nov 2016
	//-----------------------------------------------------------
	
	public class ICProductIntermediatesController : BaseBusinessController
	{
		public ICProductIntermediatesController()
		{
			dal = new DALBaseProvider("ICProductIntermediates",typeof(ICProductIntermediatesInfo));
		}
        public DataSet GetAllMappingProduct(int iObjectID)
        {
            return GetAllDataByForeignColumn("FK_ICIntermediateProductID", iObjectID);
        }
        public DataSet GetAllMappingProductIntermediate(int iObjectID)
        {
            return GetAllDataByForeignColumn("FK_ICProductID", iObjectID);
        }
        public DataSet GetAllDataByListID(string[] lstID)
        {
            string strQuery = string.Format("SELECT * FROM {0} WHERE FK_ICIntermediateProductID IN({1}) AND AASelected = 1", dal.TableName, string.Join(",", lstID));
            return GetDataSet(strQuery);
        }
    }
	#endregion
}