﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeInsurances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeInsurancesController
	//Created Date:Monday, April 13, 2009
	//-----------------------------------------------------------
	
	public class HREmployeeInsurancesController:BaseBusinessController
	{
		public HREmployeeInsurancesController()
		{
			dal= new DALBaseProvider("HREmployeeInsurances",typeof(HREmployeeInsurancesInfo));
		}
               
        #region Lấy tất cả EmployeeInsurance của nhân viên từ ngày đến ngày --Vinh --12/03/2013

        public DataSet GetEmployeeInsuranceByEmployeeANDDate(String strInsuranceNo, int iInsuranceID, int iEmployeeID, DateTime dtFrom, DateTime dtTo)
        {
            String strNo = "";
            if (!String.IsNullOrEmpty(strInsuranceNo))
            {
                strNo = String.Format(@" AND HREmployeeInsuranceNo = '{0}'", strInsuranceNo);
            }

            String str = String.Format(@"SELECT * FROM HREmployeeInsurances WHERE AAStatus='Alive'
                                        AND (FK_HREmployeeID = {0} OR {0} = 0)
                                        AND (FK_HRInsuranceID = {1} OR {1} = 0)
                                        AND (CONVERT(VARCHAR(10), HREmployeeInsuranceApplyDate, 112)>= CONVERT(VARCHAR(10), '{2}', 112))
                                        AND (CONVERT(VARCHAR(10), HREmployeeInsuranceApplyDate, 112)<= CONVERT(VARCHAR(10), '{3}', 112))
                                        {4}
                                        ", iEmployeeID, iInsuranceID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        public DataSet GetEmployeeInsuranceByDate(int iperiod, int iYear)
        {
            String str = String.Format(@"SELECT HREmployees.HREmployeeNo,
                                        HREmployees.HREmployeeName,
                                        HREmployees.HREmployeeContractSalaryAmount,
                                        HREmployees.FK_HRSectionID,
                                        HREmployees.FK_HRDepartmentID,
                                        HREmployeeInsurances.HREmployeeInsuranceNo,
                                        HREmployeeInsurances.FK_HRInsuranceID,
                                        HREmployeeInsurances.HREmployeeInsuranceDateFrom
                                    FROM dbo.HREmployees INNER JOIN dbo.HREmployeeInsurances 
					                    ON dbo.HREmployees.HREmployeeID = dbo.HREmployeeInsurances.FK_HREmployeeID
				                        INNER JOIN dbo.HRInsurances 
					                    ON dbo.HREmployeeInsurances.FK_HRInsuranceID = dbo.HRInsurances.HRInsuranceID
                                    WHERE HREmployees.AAStatus = 'Alive'
                                        AND HREmployeeInsurances.AAStatus = 'Alive'
                                        AND (MONTH(HREmployeeInsurances.HREmployeeInsuranceDateFrom)+ YEAR(HREmployeeInsurances.HREmployeeInsuranceDateFrom)*12)<= ({0}+{1} * 12)
                                        --AND (MONTH(HREmployeeInsurances.HREmployeeInsuranceDateTo)+ YEAR(HREmployeeInsurances.HREmployeeInsuranceDateTo)*12)>= ({0}+{1} * 12)
                                        AND HREmployeeInsurances.HREmployeeInsuranceStatusCombo = 'InDeclaration'", iperiod, iYear);
            return dal.GetDataSet(str);
        }
        #endregion
	}
	#endregion
}