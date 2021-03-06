using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLCostAdjAllocates
	//-----------------------------------------------------------
	//Generated By: SQLDBTools
	//Class:GLCostAdjAllocatesController
	//Created Date: 14 Jul 2015
	//-----------------------------------------------------------
	
	public class GLCostAdjAllocatesController:BaseBusinessController
	{
		public GLCostAdjAllocatesController()
		{
			dal= new DALBaseProvider("GLCostAdjAllocates",typeof(GLCostAdjAllocatesInfo));
		}
        public DataSet GetDataByCostAllocateInDate(int iCostAllocateID, DateTime dtGLCostAdjAllocateDate)
        {
            string strQuery = string.Format(@"SELECT  dbo.GLCostAdjAllocates.*
                                        FROM    dbo.GLCostAdjAllocates
                                                INNER JOIN dbo.GLCostAdjAllocateItems ON dbo.GLCostAdjAllocates.GLCostAdjAllocateID = dbo.GLCostAdjAllocateItems.FK_GLCostAdjAllocateID
                                         AND dbo.GLCostAdjAllocates.AAStatus = 'Alive'
                                         AND dbo.GLCostAdjAllocateItems.AAStatus = 'Alive'
                                         AND FK_GLCostAllocateID = {0}
                                         AND ( CONVERT(NVARCHAR(10), GLCostAdjAllocateDate, 112) = CONVERT(NVARCHAR(10), '{1}', 112) )", iCostAllocateID, dtGLCostAdjAllocateDate.ToString("yyyyMMdd"));
            return GetDataSet(strQuery);
        }
        // Lay Danh sach phieu thay doi phuong phap khau hao cho Tai San và Sau ngày tạo phiếu khấu hao.
        public DataSet GetDataByCostAllocateAfterDate(int iCostAllocateID, DateTime dtGLCostAdjAllocateDate)
        {
            string strQuery = string.Format(@"SELECT  dbo.GLCostAdjAllocates.*
                                        FROM    dbo.GLCostAdjAllocates
                                                INNER JOIN dbo.GLCostAdjAllocateItems ON dbo.GLCostAdjAllocates.GLCostAdjAllocateID = dbo.GLCostAdjAllocateItems.FK_GLCostAdjAllocateID
                                         AND dbo.GLCostAdjAllocates.AAStatus = 'Alive'
                                         AND dbo.GLCostAdjAllocateItems.AAStatus = 'Alive'
                                         AND FK_GLCostAllocateID = {0}
                                         AND ( CONVERT(NVARCHAR(10), GLCostAdjAllocateDate, 112) > CONVERT(NVARCHAR(10), '{1}', 112) )", iCostAllocateID, dtGLCostAdjAllocateDate.ToString("yyyyMMdd"));
            return GetDataSet(strQuery);
        }

        // V.Hung add 18/08/2015 Lấy danh sách phiếu thay đổi mức phân bổ theo chi tiết phân bổ CPTT
        public DataSet GetDataByPeriodCostAllocateItem(int iGLPeriodCostAllocateItemID)
        {
            string strQuery = string.Format(@"SELECT  dbo.GLCostAdjAllocates.*
                    FROM    dbo.GLCostAdjAllocateItems
                            INNER JOIN dbo.GLCostAdjAllocates ON dbo.GLCostAdjAllocateItems.FK_GLCostAdjAllocateID = dbo.GLCostAdjAllocates.GLCostAdjAllocateID
                                                                 AND dbo.GLCostAdjAllocateItems.AAStatus = 'Alive'
                                                                 AND dbo.GLCostAdjAllocates.AAStatus = 'Alive'
                                                                 AND dbo.GLCostAdjAllocateItems.FK_GLPeriodCostAllocateItemID = {0}",iGLPeriodCostAllocateItemID);
            return GetDataSet(strQuery);
        }
	}
	#endregion
}