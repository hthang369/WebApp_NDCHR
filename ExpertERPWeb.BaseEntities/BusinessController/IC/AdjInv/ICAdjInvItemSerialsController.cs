using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICAdjInvItemSerials
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICAdjInvItemSerialsController
	//Created Date:04 Tháng Mười Một 2009
	//-----------------------------------------------------------
	
	public class ICAdjInvItemSerialsController:BaseBusinessController
	{
		public ICAdjInvItemSerialsController()
		{
			dal= new DALBaseProvider("ICAdjInvItemSerials",typeof(ICAdjInvItemSerialsInfo));
		}
        public DataSet GetDataSetICAdjInvItemSerialsByFK_ICAdjInvItemIDAndFK_ICProductID(int ICAdjInvItemID, int ICProductID)
        {
            return dal.GetDataSet("ICAdjInvItemSerials_SelectByFK_ICAdjInvItemIDAndFK_ICProductID", ICAdjInvItemID, ICProductID);
        }
	}
	#endregion
}