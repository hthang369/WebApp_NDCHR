using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ADMessageTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ADMessageTypesController
	//Created Date:08 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ADMessageTypesController:BaseBusinessController
	{
		public ADMessageTypesController()
		{
			dal= new DALBaseProvider("ADMessageTypes",typeof(ADMessageTypesInfo));
		}

        public DataSet LayTatCaLoaiTheoAlertConfig(int iADAlertConfigID)
        {
            String str = String.Format(@"SELECT  ADMessageTypes.*
                                        FROM    dbo.ADMessageTypes
                                                INNER JOIN dbo.ADAlertConfigMessageTypes ON ( ADAlertConfigMessageTypes.FK_ADMessageTypeID = ADMessageTypes.ADMessageTypeID
                                                                                              AND AAStatus = 'Alive'
                                                                                            )
                                                INNER JOIN dbo.ADAlertConfigs ON ( ADAlertConfigs.ADAlertConfigID = ADAlertConfigMessageTypes.FK_ADAlertConfigID
                                                                                   AND ADAlertConfigs.AAStatus = ADMessageTypes.AAStatus
                                                                                   AND ADAlertConfigs.ADAlertConfigID = {0}
                                                                                 )"
                                    , iADAlertConfigID);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}