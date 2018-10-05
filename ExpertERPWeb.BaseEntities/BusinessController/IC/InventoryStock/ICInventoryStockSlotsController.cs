using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStockSlots
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStockSlotsController
	//Created Date:Monday, March 24, 2008
	//-----------------------------------------------------------
	
	public class ICInventoryStockSlotsController:BaseBusinessController
	{
        private readonly string spGetICInventoryStockSlotByProductAndStockSlot =
                                "ICInventoryStockSlots_SelectByProductAndStockSlot";
         
		public ICInventoryStockSlotsController()
		{
			dal= new DALBaseProvider("ICInventoryStockSlots",typeof(ICInventoryStockSlotsInfo));
		}

        public ICInventoryStockSlotsInfo GetICInventoryStockSlotByProductAndStockSlot(int iICProductID, int iICStockSlotID)
        {
            return (ICInventoryStockSlotsInfo)dal.GetDataObject(spGetICInventoryStockSlotByProductAndStockSlot, iICProductID, iICStockSlotID);
        }
	}
	#endregion
}