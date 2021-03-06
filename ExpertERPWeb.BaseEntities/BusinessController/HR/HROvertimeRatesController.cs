﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HROvertimeRates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HROvertimeRatesController
	//Created Date:Wednesday, April 08, 2009
	//-----------------------------------------------------------
	
	public class HROvertimeRatesController:BaseBusinessController
	{
		public HROvertimeRatesController()
		{
			dal= new DALBaseProvider("HROvertimeRates",typeof(HROvertimeRatesInfo));
        }

        #region GetDataByTypeCombo --Vinh --02/02/2013  --Lấy tất cả các các tỷ lệ tăng ca có type truyền vào

        public DataSet GetAllDataByType(String strType)
        {
            String str = String.Format(@"SELECT * FROM HROvertimeRates WHERE AAStatus='Alive' AND HROvertimeRateTypeCombo LIKE'{0}%' ORDER BY HROvertimeRate ASC", strType);
            return dal.GetDataSet(str);
        }

        #endregion
    }
	#endregion
}