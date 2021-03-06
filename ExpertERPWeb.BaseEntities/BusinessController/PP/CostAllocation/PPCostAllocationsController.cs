﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPCostAllocations
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPCostAllocationsController
	//Created Date:Friday, October 07, 2016
	//-----------------------------------------------------------
	
	public class PPCostAllocationsController:BaseBusinessController
	{
		public PPCostAllocationsController()
		{
			dal= new DALBaseProvider("PPCostAllocations",typeof(PPCostAllocationsInfo));
		}

        //Lấy thông tin tách chi phí trong kỳ
        public PPCostAllocationsInfo GetCostAllocationInPeriod(int iPeriod,int iYear)
        {
            string strQuery = string.Format(@"
                                SELECT * FROM dbo.PPCostAllocations
                                WHERE PPPeriod = '{0}' 
                                      AND PPYear ='{1}'
                                      AND AAStatus='Alive'
                                ", iPeriod, iYear);
            DataSet ds = GetDataSet(strQuery);
            if(ds.Tables[0].Rows.Count>0)
            {
                return (PPCostAllocationsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]); ;
            }
            return null;
        }
	}
	#endregion
}