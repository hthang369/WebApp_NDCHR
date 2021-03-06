using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APLandedCosts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APLandedCostsController
	//Created Date:Tuesday, October 16, 2012
	//-----------------------------------------------------------
	
	public class APLandedCostsController:BaseBusinessController
	{
		public APLandedCostsController()
		{
			dal= new DALBaseProvider("APLandedCosts",typeof(APLandedCostsInfo));
		}

        public string GenerateLandedCostNo(string strNo)
        {
            string LandedCostNo = string.Empty;
            DateTime dt = DateTime.Now;
            string strYear = string.Format("{0:yy}", dt);
            string strQuery = string.Format("select max(right(APLandedCostNo,len(APLandedCostNo) - len('{0}{1}'))) as NumberNo from APLandedCosts where APLandedCostNo like '{2}%'", strNo, strYear, strNo);
            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int number = 0;
                string strNum = ds.Tables[0].Rows[0][0].ToString();
                if (!string.IsNullOrEmpty(strNum))
                    number = int.Parse(strNum);
                number++;
                LandedCostNo = strNo + strYear + number.ToString().PadLeft(4, '0');
            }
            else
                LandedCostNo = strNo + strYear + "0001";
            return LandedCostNo;
        }
    }
	#endregion
}