using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICROs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICROsController
	//Created Date:28 Tháng Hai 2013
	//-----------------------------------------------------------
	
	public class ICROsController:BaseBusinessController
	{
		public ICROsController()
		{
			dal= new DALBaseProvider("ICROs",typeof(ICROsInfo));
		}

        public DataSet GetRO(DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ICROs WHERE AAStatus='Alive' 
                                            AND CONVERT(VARCHAR(10), [ICRODate], 112)>= CONVERT(VARCHAR(10), '{0}', 112) 
                                            AND CONVERT(VARCHAR(10), [ICRODate], 112)<= CONVERT(VARCHAR(10), '{1}', 112)", FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"));
            return dal.GetDataSet(strQuery);
        }      

        public DataSet GetAllDataByTransfer(int iTransferID)
        {
            String strQuery = String.Format(@"SELECT  *
                                                FROM    ICROs
                                                WHERE   AAStatus = 'Alive'
                                                        AND ICROID IN ( SELECT  FK_ICROID
                                                                        FROM    dbo.ICTransferROs
                                                                        WHERE   AAStatus = 'Alive'
                                                                                AND FK_ICTransferID = {0} )", iTransferID);
            return GetDataSet(strQuery);
        }
    }
	#endregion
}