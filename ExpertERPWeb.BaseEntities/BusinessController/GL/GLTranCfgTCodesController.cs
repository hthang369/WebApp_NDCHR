using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgTCodes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLTranCfgTCodesController
	//Created Date:Friday, August 22, 2014
	//-----------------------------------------------------------
	
	public class GLTranCfgTCodesController:BaseBusinessController
	{
		public GLTranCfgTCodesController()
		{
			dal= new DALBaseProvider("GLTranCfgTCodes",typeof(GLTranCfgTCodesInfo));
		}
        public DataSet GetDataByGLTranCfgID(int iGLTranCfgID)
        {
            string strQuery = String.Format(@"
SELECT a.*,b.ADOFNo
FROM    GLTranCfgTCodes a
        INNER JOIN ADOFs b ON a.FK_ADOFID = b.ADOFID 
            AND b.AAStatus = 'Alive'
WHERE   FK_GLTranCfgID = {0}"
                , iGLTranCfgID);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}