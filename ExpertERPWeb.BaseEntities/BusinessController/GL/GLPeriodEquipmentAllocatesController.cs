﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLPeriodEquipmentAllocates
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLPeriodEquipmentAllocatesController
	//Created Date:Tuesday, May 24, 2011
	//-----------------------------------------------------------
	
	public class GLPeriodEquipmentAllocatesController:BaseBusinessController
	{
		public GLPeriodEquipmentAllocatesController()
		{
			dal= new DALBaseProvider("GLPeriodEquipmentAllocates",typeof(GLPeriodEquipmentAllocatesInfo));
		}

        public bool CheckExitPeriodAndYear(int period,int year)
        {
            string strQuery = String.Format("Select count(*) from GLPeriodEquipmentAllocates where AAStatus = 'Alive' and GLPeriodEquipmentAllocatePeriod = {0} "
                                + " and GLPeriodEquipmentAllocateYear = {1}", period, year);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0].ToString().Length > 0)
            {
                if ((int)ds.Tables[0].Rows[0][0] > 0)
                    return true;
            }
            return false;
        }

        public DataSet LayDanhSachPhanBoTheoNgay(int iICProductID, DateTime dtGLEquipmentAllocateUserDate)
        {
            string strQuery = string.Format(@"SELECT  dbo.GLPeriodEquipmentAllocates.*
                    FROM    dbo.GLPeriodEquipmentAllocates
                            INNER JOIN dbo.GLPeriodEquipmentAllocateItems ON dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocateID = dbo.GLPeriodEquipmentAllocateItems.FK_GLPeriodEquipmentAllocateID
                                                                             AND dbo.GLPeriodEquipmentAllocates.AAStatus = 'Alive'
                                                                             AND GLPeriodEquipmentAllocateItems.AAStatus = 'Alive'
                                                                             AND GLPeriodEquipmentAllocateItems.FK_ICProductID = {0}
                                                                             AND dbo.GLPeriodEquipmentAllocateItems.AAStatus = 'Alive'
                                                                             AND CONVERT(NVARCHAR(10), GLPeriodEquipmentAllocateDate, 112) > CONVERT(NVARCHAR(10), '{1}', 112)", iICProductID, dtGLEquipmentAllocateUserDate.ToString("yyyyMMdd"));
            return GetDataSet(strQuery);
        }

        public bool CheckExitAfterPeriodAndYear(int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"SELECT  *
            FROM    dbo.GLPeriodEquipmentAllocates
            WHERE   AAStatus = 'Alive'
                    AND ( GLPeriodEquipmentAllocatePeriod + GLPeriodEquipmentAllocateYear
                          * 12 ) > ( {0} + {1} * 12 )",iPeriod,iYear);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public GLPeriodEquipmentAllocatesInfo LayKyPhanBoMoiNhat()
        {
            string strQuery = string.Format(@"SELECT TOP 1
                                                        *
                                                FROM    dbo.GLPeriodEquipmentAllocates
                                                WHERE   ( dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocateYear * 12
                                                          + dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocatePeriod ) = ( SELECT   MAX(dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocatePeriod
                                                                                                              + dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocateYear
                                                                                                              * 12)
                                                                                                   FROM     dbo.GLPeriodEquipmentAllocates
                                                                                                   WHERE    AAStatus = 'Alive'
                                                                                                 )
                                                        AND dbo.GLPeriodEquipmentAllocates.AAStatus = 'Alive'");
            DataSet ds = GetDataSet(strQuery);
            GLPeriodEquipmentAllocatesInfo objGLPeriodEquipmentAllocateInfo = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                objGLPeriodEquipmentAllocateInfo = (GLPeriodEquipmentAllocatesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return objGLPeriodEquipmentAllocateInfo;
        }

        public DataSet GetAllDataByProductAfterDate(int iICProductID, DateTime dtDateTime)
        { 
            string strQuery=string.Format(@"SELECT  GLPeriodEquipmentAllocates.*
                                FROM    dbo.GLPeriodEquipmentAllocates
                                        INNER JOIN dbo.GLPeriodEquipmentAllocateItems ON dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocateID = dbo.GLPeriodEquipmentAllocateItems.FK_GLPeriodEquipmentAllocateID
                                                                                         AND dbo.GLPeriodEquipmentAllocates.AAStatus = 'Alive'
                                                                                         AND dbo.GLPeriodEquipmentAllocateItems.AAStatus = 'Alive'
                                                                                         AND FK_ICProductID = {0}
                                                                                         AND CONVERT(NVARCHAR(10), GLPeriodEquipmentAllocateDate, 112) > CONVERT(NVARCHAR(10), '{1}', 112)",iICProductID,dtDateTime.ToString("yyyyMMdd"));
            return GetDataSet(strQuery);
        }

        // V.Hung add 24/08/2015 Lấy kỳ phân bổ sớm nhất của CCDC
        public GLPeriodEquipmentAllocatesInfo LayKyPhanBoSomNhat()
        {
            string strQuery = string.Format(@"SELECT TOP 1
                                                        *
                                                FROM    dbo.GLPeriodEquipmentAllocates
                                                WHERE   ( dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocateYear * 12
                                                          + dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocatePeriod ) = ( SELECT   MIN(dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocatePeriod
                                                                                                              + dbo.GLPeriodEquipmentAllocates.GLPeriodEquipmentAllocateYear
                                                                                                              * 12)
                                                                                                   FROM     dbo.GLPeriodEquipmentAllocates
                                                                                                   WHERE    AAStatus = 'Alive'
                                                                                                 )
                                                        AND dbo.GLPeriodEquipmentAllocates.AAStatus = 'Alive'");
            DataSet ds = GetDataSet(strQuery);
            GLPeriodEquipmentAllocatesInfo objGLPeriodEquipmentAllocateInfo = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                objGLPeriodEquipmentAllocateInfo = (GLPeriodEquipmentAllocatesInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return objGLPeriodEquipmentAllocateInfo;
        }

        
	}
	#endregion
}