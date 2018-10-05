﻿ using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewResourceEvaluations
	//-----------------------------------------------------------
	//Generated By: SQLDBTools.NET - LINHCLH (v2.0.8)
	//Class: ViewResourceEvaluationsController
	//Created Date: Monday, 26 Jun 2017
	//-----------------------------------------------------------
	
	public class ViewResourceEvaluationsController : BaseBusinessController
	{
		public ViewResourceEvaluationsController()
		{
			dal = new DALBaseProvider("ViewResourceEvaluations",typeof(ViewResourceEvaluationsInfo));
		}
        public DataSet GetAllObjectByCondition(int iPPPhaseCfgID, int iWeek, int iYear)
        {
            string strQuery = string.Format(@"  IF OBJECT_ID('tempdb..#PhaseTotal') IS NOT NULL
                                                    DROP TABLE #PhaseTotal;
                                                IF OBJECT_ID('tempdb..#Evaluations') IS NOT NULL
                                                    DROP TABLE #Evaluations;
                                                IF OBJECT_ID('tempdb..#Totals') IS NOT NULL
                                                    DROP TABLE #Totals;
                                                --Tong thoi gian lam viec trong 1 ngay (s)
                                                DECLARE @PPShiftTotal FLOAT;
                                                SET @PPShiftTotal =
                                                (
                                                    SELECT SUM(ISNULL(PPShiftQty, 0) * ISNULL(PPResourceUOMSQty, 0)) AS ResourceShiftTime
                                                    FROM dbo.PPShifts
                                                        INNER JOIN dbo.PPResourceUOMs
                                                            ON PPResourceUOMs.PPResourceUOMID = PPShifts.FK_PPResourceUOMID
                                                                AND PPResourceUOMs.AAStatus = 'Alive'
                                                    WHERE PPShifts.AAStatus = 'Alive'
                                                            AND ISNULL(PPShiftQty, 0) > 0
                                                            AND ISNULL(PPResourceUOMSQty, 0) > 0
                                                );
                                                --- Tong nang suat trong 1 ngay cua tung cong doan
                                                SELECT PPResourceItems.FK_PPPhaseCfgID,
                                                        ((SUM(ISNULL(PPResourceItems.PPResourceItemivityQty, 0)) * ISNULL(PPResources.PPResourceQty, 0)))
                                                        * @PPShiftTotal / PPResourceUOMs.PPResourceUOMSQty AS CAPQty
                                                INTO #PhaseTotal
                                                FROM dbo.PPResources
                                                    INNER JOIN dbo.PPResourceItems
                                                        ON PPResourceItems.FK_PPResourceID = PPResources.PPResourceID
                                                            AND PPResourceItems.AAStatus = 'Alive'
                                                    INNER JOIN dbo.PPResourceUOMs
                                                        ON PPResourceItems.FK_PPResourceItemivityUOMID = PPResourceUOMs.PPResourceUOMID
                                                            AND PPResourceUOMs.AAStatus = 'Alive'
                                                            AND ISNULL(PPResourceUOMs.PPResourceUOMSQty, 0) > 0
                                                WHERE PPResources.AAStatus = 'Alive'
													  AND ISNULL(PPResources.PPResourceQty,0) > 0
                                                GROUP BY PPResourceItems.FK_PPPhaseCfgID,
                                                            PPResources.PPResourceQty,
                                                            PPResourceUOMs.PPResourceUOMSQty;
                                                --- Ket Qua Tham dinh
                                                SELECT PPProductionCalendars.FK_ICProductID AS FK_ICProductID,
                                                        PPProductionCalendars.PPProductionCalendarLotNo AS ViewResourceEvaluationLotNo,
                                                        PPProductionCalendars.FK_PPPhaseCfgID AS FK_PPPhaseCfgID,
                                                        PPProductionCalendars.PPProductionCalendarQty AS ViewResourceEvaluationApplyTime,
                                                        PPProductionCalendars.PPProductionCalendarDate AS ViewResourceEvaluationDate,
                                                        PPProductionCalendars.PPProductionCalendarWeek AS ViewResourceEvaluationWeek,
                                                        PPProductionCalendars.PPProductionCalendarPlanDate AS ViewResourceEvaluationShpDate,
                                                        PPProductionCalendars.PPProductionCalendarPlanWeek AS ViewResourceEvaluationShpWeek,
                                                        #PhaseTotal.CAPQty AS ViewResourceEvaluationCAP
                                                INTO #Evaluations
                                                FROM dbo.PPProductionCalendars
                                                    INNER JOIN #PhaseTotal
                                                        ON #PhaseTotal.FK_PPPhaseCfgID = PPProductionCalendars.FK_PPPhaseCfgID
														AND #PhaseTotal.CAPQty > 0
                                                WHERE PPProductionCalendars.PPProductionCalendarDate IS NOT NULL
                                                        AND PPProductionCalendars.AAStatus = 'Alive'
                                                        AND PPProductionCalendars.PPProductionCalendarQty > 0
	                                                    AND (PPProductionCalendars.FK_PPPhaseCfgID = {0} OR 0 = {0})
	                                                    AND PPProductionCalendars.PPProductionCalendarPlanWeek = {1}
	                                                    AND PPProductionCalendars.PPProductionCalendarPlanYear = {2};
                                                --- Tong cong
                                                SELECT #Evaluations.FK_PPPhaseCfgID,
                                                        #Evaluations.ViewResourceEvaluationCAP,
                                                        SUM(#Evaluations.ViewResourceEvaluationApplyTime) AS ViewResourceEvaluationApplyTime
                                                INTO #Totals
                                                FROM #Evaluations
                                                GROUP BY #Evaluations.FK_PPPhaseCfgID,
                                                            #Evaluations.ViewResourceEvaluationCAP;
                                                -- Gop ket qua tham dinh va tong cong
                                                SELECT #Evaluations.FK_ICProductID,
                                                        #Evaluations.ViewResourceEvaluationLotNo,
                                                        #Evaluations.FK_PPPhaseCfgID,
                                                        #Evaluations.ViewResourceEvaluationApplyTime,
                                                        #Evaluations.ViewResourceEvaluationDate,
                                                        #Evaluations.ViewResourceEvaluationWeek,
                                                        #Evaluations.ViewResourceEvaluationShpWeek,
                                                        #Evaluations.ViewResourceEvaluationShpDate,
                                                        #Evaluations.ViewResourceEvaluationCAP,
                                                        0 AS ViewResourceEvaluationACTUALCALLOFF,
                                                        '' AS ViewResourceEvaluationType,
                                                        '' AS ViewResourceEvaluationPPPhaseCfgNo
                                                FROM #Evaluations
                                                UNION ALL
                                                SELECT 0 AS FK_ICProductID,
                                                        '' AS ViewResourceEvaluationLotNo,
                                                        #Totals.FK_PPPhaseCfgID,
                                                        #Totals.ViewResourceEvaluationApplyTime,
                                                        NULL AS ViewResourceEvaluationDate,
                                                        0 AS ViewResourceEvaluationWeek,
                                                        0 AS ViewResourceEvaluationShpWeek,
                                                        NULL AS ViewResourceEvaluationShpDate,
                                                        #Totals.ViewResourceEvaluationCAP,
                                                        CASE
                                                            WHEN ISNULL(#Totals.ViewResourceEvaluationCAP, 0) > 0 THEN
                                                                ROUND(
                                                                        (ISNULL(#Totals.ViewResourceEvaluationApplyTime, 0)
                                                                            / ISNULL(#Totals.ViewResourceEvaluationCAP, 1)
                                                                        ) * 100,
                                                                        0
                                                                    )
                                                            ELSE
                                                                0
                                                        END ViewResourceEvaluationACTUALCALLOFF,
                                                        'Act. Call-off Utilized' ViewResourceEvaluationType,
                                                        PPPhaseCfgs.PPPhaseCfgNo AS ViewResourceEvaluationPPPhaseCfgNo
                                                FROM #Totals
                                                    LEFT JOIN dbo.PPPhaseCfgs
                                                        ON PPPhaseCfgs.PPPhaseCfgID = #Totals.FK_PPPhaseCfgID
                                                            AND PPPhaseCfgs.AAStatus = 'Alive'
                                                WHERE ISNULL(#Totals.ViewResourceEvaluationCAP, 0) > 0
                                                UNION ALL
                                                SELECT 0 AS FK_ICProductID,
                                                        '' AS ViewResourceEvaluationLotNo,
                                                        #Totals.FK_PPPhaseCfgID,
                                                        #Totals.ViewResourceEvaluationApplyTime,
                                                        NULL AS ViewResourceEvaluationDate,
                                                        0 AS ViewResourceEvaluationWeek,
                                                        0 AS ViewResourceEvaluationShpWeek,
                                                        NULL AS ViewResourceEvaluationShpDate,
                                                        #Totals.ViewResourceEvaluationCAP,
                                                        100 ViewResourceEvaluationACTUALCALLOFF,
                                                        'Std. Avai.' ViewResourceEvaluationType,
                                                        PPPhaseCfgs.PPPhaseCfgNo AS ViewResourceEvaluationPPPhaseCfgNo
                                                FROM #Totals
                                                    LEFT JOIN dbo.PPPhaseCfgs
                                                        ON PPPhaseCfgs.PPPhaseCfgID = #Totals.FK_PPPhaseCfgID
                                                            AND PPPhaseCfgs.AAStatus = 'Alive'
                                                WHERE ISNULL(#Totals.ViewResourceEvaluationCAP, 0) > 0;"
                                                , iPPPhaseCfgID, iWeek, iYear);
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}