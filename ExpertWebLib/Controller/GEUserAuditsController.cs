using System;
using System.Data;
using System.Linq;

namespace ExpertWebLib
{
    public class GEUserAuditsController : BaseBusinessController
    {
        private readonly string spGetGEUserAuditsByGEUserAuditModuleName = "GEUserAudits_SelectByGEUserAuditModuleName";
        private readonly string spGetGEUserAuditsByADUserID = "GEUserAudits_SelectByADUserID";
        private readonly string spGetGEUserAuditsByADUserIDAndModuleName = "GEUserAudits_SelectByADUserIDAndModuleName";
        private readonly string spGetGEUserAuditsByModuleNamdAndParameter = "GEUserAudits_SelectByModuleNameAndParameter";
        private readonly string spGetGEUserAuditsByModuleNameAndParameterAndAction = "GEUserAudits_SelectByModuleNameAndParameterAndAction";
        private readonly string spDeleteGEUserAuditsByADUserID = "GEUserAudits_DeleteByADUserID";
        private readonly string spDeleteGEUserAuditsByADUserIDAndModuleName = "GEUserAudits_DeleteByADUserIDAndModuleName";
        private readonly string spDeleteGEUserAuditsByADUserIDAndModuleNameAndParameterAndAction = "GEUserAudits_DeleteByADUserIDAndModuleNameAndParameterAndAction";
        private readonly string spGetGEUserAuditsByADUserName = "GEUserAudits_SelectByADUserName";

        public GEUserAuditsController()
        {
            base.dal = new DALBaseProvider("GEUserAudits", typeof(GEUserAuditsInfo));
        }

        public void DeleteGEUserAuditsByADUserID(int iADUserID)
        {
            object[] paramValues = new object[] { iADUserID };
            base.dal.GetDataSet(this.spDeleteGEUserAuditsByADUserID, paramValues);
        }

        public void DeleteGEUserAuditsByADUserIDAndModuleName(int iADUserID, string strModuleName)
        {
            object[] paramValues = new object[] { iADUserID, strModuleName };
            base.dal.GetDataSet(this.spDeleteGEUserAuditsByADUserIDAndModuleName, paramValues);
        }

        public void DeleteGEUserAuditsByADUserIDAndModuleNameAndParameterAndAction(int iADUserID, string strGEUserAuditModuleName, string strGEUserAuditParameter, string strGEUserAuditAction)
        {
            object[] paramValues = new object[] { iADUserID, strGEUserAuditModuleName, strGEUserAuditParameter, strGEUserAuditAction };
            base.dal.GetDataSet(this.spDeleteGEUserAuditsByADUserIDAndModuleNameAndParameterAndAction, paramValues);
        }

        public GEUserAuditsInfo GetGEUserAuditsByADUserID(int iADUserID)
        {
            object[] paramValues = new object[] { iADUserID };
            return (GEUserAuditsInfo)base.dal.GetDataObject(this.spGetGEUserAuditsByADUserID, paramValues);
        }

        public GEUserAuditsInfo GetGEUserAuditsByADUserIDAndModuleName(int iADUserID, string strModuleName)
        {
            object[] paramValues = new object[] { iADUserID, strModuleName };
            return (GEUserAuditsInfo)base.dal.GetDataObject(this.spGetGEUserAuditsByADUserIDAndModuleName, paramValues);
        }

        public GEUserAuditsInfo GetGEUserAuditsByADUserName(string strADUserName)
        {
            object[] paramValues = new object[] { strADUserName };
            return (GEUserAuditsInfo)base.dal.GetDataObject(this.spGetGEUserAuditsByADUserName, paramValues);
        }

        public DataSet GetGEUserAuditsByGEUserAuditModuleName(string strGEUserAuditModuleName)
        {
            string strQuery = string.Format("Select * From [GEUserAudits] Where [GEUserAuditModuleName]='{0}' And [AAStatus]='Alive'", strGEUserAuditModuleName);
            return this.GetDataSet(strQuery);
        }

        public GEUserAuditsInfo GetGEUserAuditsByModuleNameAndParameter(string strGEUserAuditModuleName, string strGEUserAuditParameter)
        {
            object[] paramValues = new object[] { strGEUserAuditModuleName, strGEUserAuditParameter };
            return (GEUserAuditsInfo)base.dal.GetDataObject(this.spGetGEUserAuditsByModuleNamdAndParameter, paramValues);
        }

        public GEUserAuditsInfo GetGEUserAuditsByModuleNameAndParameterAndAction(string strGEUserAuditModuleName, string strGEUserAuditParameter, string strGEUserAuditAction)
        {
            object[] paramValues = new object[] { strGEUserAuditModuleName, strGEUserAuditParameter, strGEUserAuditAction };
            return (GEUserAuditsInfo)base.dal.GetDataObject(this.spGetGEUserAuditsByModuleNameAndParameterAndAction, paramValues);
        }

        public bool IsExistUser(int iADUserID)
        {
            return (this.GetGEUserAuditsByADUserID(iADUserID) != null);
        }
        public int GetCountLoginFail(string strUserName, string sModuleName, DateTime dt)
        {
            return Convert.ToInt32(GMCDbUtil.ExecuteScalar(string.Format(@"SELECT COUNT(GEUserAuditID) FROM GEUserAudits 
                                     WHERE AAStatus = 'Alive' 
                                        AND GEUserAuditAction = 'LoginFail' 
                                        AND ADUserName = '{0}'
                                        AND GEUserAuditModuleName = '{1}'
                                        AND FORMAT(GEUserAuditBeginDate,'yyyy-MM-dd') = '{2}'", strUserName, sModuleName, dt.ToString("yyyy-MM-dd"))));
        }
    }
}
