using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region ICProductGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICProductGroupsController
	//Created Date:Wednesday, March 12, 2008
	//-----------------------------------------------------------
	
	public class ICProductGroupsController:BaseBusinessController
	{
		public ICProductGroupsController()
		{
			dal= new DALBaseProvider("ICProductGroups",typeof(ICProductGroupsInfo));
		}

        public List<ICProductGroupsInfo> ListProductGroups()
        {
            List<ICProductGroupsInfo> lst = new List<ICProductGroupsInfo>();
            DataSet ds = dal.GetAllObject();
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ICProductGroupsInfo objICProductGroupsInfo = (ICProductGroupsInfo)dal.GetObjectFromDataRow(row);
                        if (objICProductGroupsInfo != null)
                        {
                            lst.Add(objICProductGroupsInfo);
                        }
                    }
                }
            }
            return lst;
        }
        
	}
	#endregion
}