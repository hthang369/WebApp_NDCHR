using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationCfgParamConditions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationCfgParamConditionsController
	//Created Date:22 Tháng Mười 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationCfgParamConditionsController:BaseBusinessController
	{
		public ACCostSimulationCfgParamConditionsController()
		{
			dal= new DALBaseProvider("ACCostSimulationCfgParamConditions",typeof(ACCostSimulationCfgParamConditionsInfo));
		}

        public DataSet GetAllDataByType(int iACCostSimulationCfgParamID, String strTypeCombo)
        {
            String str = String.Format(@"SELECT Child.* FROM dbo.ACCostSimulationCfgParamConditions Child
                                        INNER JOIN dbo.ACCostSimulationCfgParams Parent ON Child.FK_ACCostSimulationCfgParamID = Parent.ACCostSimulationCfgParamID
                                        WHERE Child.AAStatus = 'Alive' AND Parent.AAStatus = 'Alive'
                                        AND Parent.ACCostSimulationCfgParamID = {0}
                                        AND Child.ACCostSimulationCfgParamConditionTypeCombo LIKE '{1}'"
                                        , iACCostSimulationCfgParamID, strTypeCombo);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}