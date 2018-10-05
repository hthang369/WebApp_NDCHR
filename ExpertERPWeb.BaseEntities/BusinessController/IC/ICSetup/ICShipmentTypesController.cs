using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICShipmentTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICShipmentTypesController
	//Created Date:16 Tháng Sáu 2011
	//-----------------------------------------------------------
	
	public class ICShipmentTypesController:BaseBusinessController
	{
		public ICShipmentTypesController()
		{
			dal= new DALBaseProvider("ICShipmentTypes",typeof(ICShipmentTypesInfo));
		}

        public DataSet GetShipmentTypeForShpEquipment()
        {
            String strQuery = String.Format("Select * FROM ICShipmentTypes WHERE AAStatus = 'Alive' AND (ICShipmentTypeNo = 'ForUsed' OR ICShipmentTypeNo = 'ForProduct')");
            return dal.GetDataSet(strQuery);
        }


	}
	#endregion
}