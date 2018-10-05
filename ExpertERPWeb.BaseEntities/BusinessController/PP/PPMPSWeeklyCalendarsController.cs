﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPMPSWeeklyCalendars
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPMPSWeeklyCalendarsController
	//Created Date:Friday, November 25, 2016
	//-----------------------------------------------------------
	
	public class PPMPSWeeklyCalendarsController:BaseBusinessController
	{
		public PPMPSWeeklyCalendarsController()
		{
			dal= new DALBaseProvider("PPMPSWeeklyCalendars",typeof(PPMPSWeeklyCalendarsInfo));
		}
        // NhamNDH add -25/11/2016- Move Lịch sản xuất từ CHF
        public DataSet GetAllPPMPSWeeklyCalendarsByPPMPSID(int iPPMPSID)
        {
            string strQuery = string.Format(@"  SELECT  *
                                                FROM    PPMPSWeeklyCalendars
                                                WHERE   AAStatus = 'Alive'
                                                        AND FK_PPMPSID = {0}
                                                ORDER BY PPMPSWeeklyCalendarNo ASC;"
                                        , iPPMPSID);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}