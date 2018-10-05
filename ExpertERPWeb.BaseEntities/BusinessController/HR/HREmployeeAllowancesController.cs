﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeAllowances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeAllowancesController
	//Created Date:Saturday, June 13, 2009
	//-----------------------------------------------------------
	
	public class HREmployeeAllowancesController:BaseBusinessController
	{
        private readonly static string spGetEmployeeAllowancesByEmployeeAndAllowanceAndSortOrderByYearAndPeriod =
                                        "HREmployeeAllowances_SelectByEmployeeAndAllowanceAndSortByEffYearAndEffPeriod";

		public HREmployeeAllowancesController()
		{
			dal= new DALBaseProvider("HREmployeeAllowances",typeof(HREmployeeAllowancesInfo));
		}

        public DataSet GetAllowanceByEmployeeAndAllowanceAndSortOrderByYearAndPeriod(int iHREmployeeID, int iHRAllowanceRateID)
        {
            return dal.GetDataSet(spGetEmployeeAllowancesByEmployeeAndAllowanceAndSortOrderByYearAndPeriod, iHREmployeeID, iHRAllowanceRateID);
        }

        //#region Get Allowance By Employee and HREmployeeAllowanceTypeCombo --Vinh --20/02/2013 --Lấy tất cả các phụ cấp của nhân viên theo loại phụ cấp

        //public DataSet GetEmployeeAllowanceByEmployeeANDTypeComboANDYearMonth(int iEmployeeID, String strTypeCombo, int iMonth, int iYear)
        //{
        //    String str = String.Format(@"   SELECT * FROM dbo.HREmployeeAllowances 
        //                                    WHERE FK_HREmployeeID={0} 
        //                                    AND HREmployeeAllowanceEffFiscalYear = {1}
        //                                    AND (HREmployeeAllowancePeriod = {2} OR HREmployeeAllowancePeriod = 0)", iEmployeeID, iYear, iMonth);
        //    if (strTypeCombo != String.Empty)
        //    {
        //        str += String.Format(@" AND HREmployeeAllowanceTypeCombo LIKE '%{0}%'", strTypeCombo);
        //    }
        //    return dal.GetDataSet(str);
        //}

        //#endregion

        #region Lấy tất cả các phụ cấp của nhân viên theo hợp đồng và loại phụ cấp --Vinh --07/05/2013 

        public DataSet GetEmployeeAllowanceByEmployeeANDTypeComboANDEmployeeContract(int iEmployeeID, int iEmployeeContractID, String strTypeCombo, DateTime dt)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HREmployeeAllowances 
                                             JOIN dbo.HRAllowanceRateTypes 
                                             ON (HRAllowanceRateTypes.HRAllowanceRateTypeID = HREmployeeAllowances.FK_HRAllowanceRateTypeID
                                             AND HRAllowanceRateTypes.AAStatus=HREmployeeAllowances.AAStatus)
                                            WHERE FK_HREmployeeID={0}
                                            AND FK_HREmployeeContractID IN (
									                                            SELECT HREmployeeContractID FROM dbo.HREmployeeContracts
									                                            WHERE AAStatus = 'Alive'
									                                            AND 
									                                            (
										                                            HREmployeeContractID = {1}
                                                                                    OR
                                                                                    (
											                                            FK_HRParentEmployeeContractID = {1}
											                                            AND
											                                            (
												                                            (
													                                            CONVERT(VARCHAR,HREmployeeContractStartAppDate, 112) <= '{3}'
													                                            AND 
													                                            HREmployeeContractStartAppDate IS NULL
												                                            )
												                                            OR
												                                            (
													                                            CONVERT(VARCHAR,HREmployeeContractStartAppDate, 112) <= '{3}'
													                                            AND 
													                                            CONVERT(VARCHAR,HREmployeeContractEndAppDate, 112) >= '{3}'
												                                            )
											                                            )
										                                            )
									                                            )
								                                            )
                                            AND HRAllowanceRateTypes.HRAllowanceRateTypeNo LIKE '{2}'", iEmployeeID, iEmployeeContractID, strTypeCombo, dt.ToString("yyyyMMdd"));            
            return dal.GetDataSet(str);
        }

        #endregion
        public double GetAmtEmployeeAllowance(int iEmployeeContractID)
        {
            String str = String.Format(@"   SELECT  SUM(HREmployeeAllowances.HREmployeeAllowanceAmt)
                                            FROM    dbo.HREmployeeAllowances HREmployeeAllowances
                                            WHERE FK_HREmployeeContractID = {0}",iEmployeeContractID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }

            return 0;
        }
        public DataSet GetEmployeeAllowanceByEmployeeANDEmployeeContract(int iEmployeeID, int iEmployeeContractID, String strAllowanceRateNo, DateTime dt)
        {
            String str = String.Format(@"SELECT * FROM dbo.HREmployeeAllowances 
                                             JOIN dbo.HRAllowanceRates 
                                             ON (HRAllowanceRates.HRAllowanceRateID = HREmployeeAllowances.FK_HRAllowanceRateID
                                             AND HRAllowanceRates.AAStatus=HREmployeeAllowances.AAStatus)
                                            WHERE FK_HREmployeeID={0}
                                            AND FK_HREmployeeContractID IN (
									                                            SELECT HREmployeeContractID FROM dbo.HREmployeeContracts
									                                            WHERE AAStatus = 'Alive'
									                                            AND 
									                                            (
										                                            HREmployeeContractID = {1}
                                                                                    OR
                                                                                    (
											                                            FK_HRParentEmployeeContractID = {1}
											                                            AND
											                                            (
												                                            (
													                                            CONVERT(VARCHAR,HREmployeeContractStartAppDate, 112) <= '{3}'
													                                            AND 
													                                            HREmployeeContractStartAppDate IS NULL
												                                            )
												                                            OR
												                                            (
													                                            CONVERT(VARCHAR,HREmployeeContractStartAppDate, 112) <= '{3}'
													                                            AND 
													                                            CONVERT(VARCHAR,HREmployeeContractEndAppDate, 112) >= '{3}'
												                                            )
											                                            )
										                                            )
									                                            )
								                                            )
                                            AND HRAllowanceRates.HRAllowanceRateNo LIKE '{2}'", iEmployeeID, iEmployeeContractID, strAllowanceRateNo, dt.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

    }
	#endregion
}