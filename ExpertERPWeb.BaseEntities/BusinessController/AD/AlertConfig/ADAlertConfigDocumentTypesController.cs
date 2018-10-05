using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ADAlertConfigDocumentTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ADAlertConfigDocumentTypesController
	//Created Date:09 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ADAlertConfigDocumentTypesController:BaseBusinessController
	{
		public ADAlertConfigDocumentTypesController()
		{
			dal= new DALBaseProvider("ADAlertConfigDocumentTypes",typeof(ADAlertConfigDocumentTypesInfo));
		}

        public ADAlertConfigDocumentTypesInfo GetRelationFromAlertConfigAndDocumentType(int iAlertConfigID, int iDocumentTypeID)
        {
            String strQuery = String.Format(@"SELECT * 
                                                FROM ADAlertConfigDocumentTypes
                                                WHERE FK_ADAlertConfigID = {0}
                                                AND FK_ADDocumentTypeID = {1}
                                                        ", iAlertConfigID, iDocumentTypeID);
            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ADAlertConfigDocumentTypesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public void DeleteAllObjectByAlertConfig(int iAlertConfigID)
        {
            String strQuery = String.Format(@"DELETE ADAlertConfigDocumentTypes
                                                WHERE FK_ADAlertConfigID = {0}
                                                        ", iAlertConfigID);
            GetDataSet(strQuery);
        }
	}
	#endregion
}