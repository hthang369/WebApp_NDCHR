using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLEquipmentAllocates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLEquipmentAllocatesController
	//Created Date:Thursday, December 15, 2011
	//-----------------------------------------------------------
	
	public class GLEquipmentAllocatesController:BaseBusinessController
	{
		public GLEquipmentAllocatesController()
		{
			dal= new DALBaseProvider("GLEquipmentAllocates",typeof(GLEquipmentAllocatesInfo));
		}
        public DataSet GetAllObjectsDiffDispose()
        {
            return dal.GetDataSet("Select * from GLEquipmentAllocates where AAStatus='Alive' and GLEquipmentAllocateStatusCombo not like 'Dispose'");
        }
        public DataSet GetAllObjectsByShipmentNoANdProductID(string sShipmentNo, int iProduct)
        {
            return dal.GetDataSet(string.Format(@"Select * from GLEquipmentAllocates where AAStatus='Alive' and ICShipmentNo = '{0}' AND FK_ICProductID = {1}", sShipmentNo, iProduct));
        }
        public DataSet DeleteObjectsByShipmentNo(string sShipmentNo)
        {
            return dal.GetDataSet(string.Format(@"UPDATE GLEquipmentAllocates SET AAStatus='Delete' WHERE ICShipmentNo = '{0}'", sShipmentNo));
        }
        public DataSet DeleteObjectsByProductNotInShipmentNo(string sShipmentNo)
        {
            return dal.GetDataSet(string.Format(@"UPDATE GLEquipmentAllocates SET AAStatus='Delete' WHERE ICShipmentNo = '{0}' AND FK_ICProductID NOT IN (SELECT CASE WHEN FK_ICProductParentID = 0 THEN FK_ICProductID ELSE FK_ICProductParentID END FROM ICShipmentItems a INNER JOIN ICShipments b ON a.FK_ICShipmentID = b.ICShipmentID AND b.ICShipmentNo = '{0)' AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive')", sShipmentNo));
        }
        
	}
	#endregion
}