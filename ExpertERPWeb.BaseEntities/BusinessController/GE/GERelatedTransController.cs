using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GERelatedTrans
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GERelatedTransController
	//Created Date:15 Tháng Mười Một 2013
	//-----------------------------------------------------------
	
	public class GERelatedTransController:BaseBusinessController
	{
		public GERelatedTransController()
		{
			dal= new DALBaseProvider("GERelatedTrans",typeof(GERelatedTransInfo));
		}
        public bool DeleteRelatedTrans(int piGERelatedTranToDocID, string psGERelatedTranToDocTableName)
        {
            string strQuery = string.Format(@"DELETE GERelatedTrans 
                WHERE GERelatedTranToDocID = {0} 
                    AND GERelatedTranToDocTableName = '{1}'"
                , piGERelatedTranToDocID, psGERelatedTranToDocTableName);
            GetDataSet(strQuery);
            return true;
        }
        public bool CheckExistsToDoc(int piGERelatedTranToDocID,string psGERelatedTranToDocTableName)
        {
            string strQuery = string.Format(@"SELECT TOP 1 1 FROM GERelatedTrans 
                WHERE GERelatedTranToDocID = {0} 
                    AND GERelatedTranToDocTableName = '{1}'"
                , piGERelatedTranToDocID, psGERelatedTranToDocTableName);
            DataSet ds = GetDataSet(strQuery);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
        public bool CheckExistsFromDoc(int piGERelatedTranFromDocID, string psGERelatedTranFromDocTableName)
        {
            string strQuery = string.Format(@"SELECT TOP 1 1 FROM GERelatedTrans WHERE GERelatedTranFromDocID = {0} 
                AND GERelatedTranFromDocTableName = '{1}'"
                , piGERelatedTranFromDocID, psGERelatedTranFromDocTableName);
            DataSet ds = GetDataSet(strQuery);
            return (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }

        public DataSet GetFromRelatedByIDTblNameAndModName(int piGERelatedTranDocID, string psGERelatedTranTableName, string psGERelatedTranModuleName)
        {
            //(Test data
            piGERelatedTranDocID = 33;
            psGERelatedTranTableName = "ARInvoices";
            psGERelatedTranModuleName = "Invoice";
            //)

            string strQuery = string.Format(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON
DECLARE @DocID as int 
DECLARE @ModName as varchar(50)
DECLARE @TableName as varchar(50)
--(Tham so chung tu hien tai
SET @DocID = {0}
SET @TableName = '{1}'
SET @ModName = '{2}'
--)

--(Tao cau truc bang ket qua
SELECT	cast( 0 as int) as Lv,
		GERelatedTranID as RelatedID,
		GERelatedTranID as ParentRelatedID
	INTO #tFrom 
	FROM GERelatedTrans
	WHERE 1 = 0
--)

DECLARE @iLv as int 
DECLARE @iID as int 
DECLARE @iParentID as int 
DECLARE @iDocID as int 
DECLARE @sDocTableName as varchar(50)
DECLARE @sDocModName as varchar(50)

--(Related From - Danh sach cac chung tu tao ra chung tu nay

--Tim cac chung tu gan nhat tao ra chung tu nay va bat dau duyet
SELECT 1 as LV,
	GERelatedTranID as RelatedParentID,
	GERelatedTranID,GERelatedTranFromDocID,GERelatedTranFromDocTableName,GERelatedTranFromDocModuleName
	INTO #tFromScan
	FROM GERelatedTrans
	WHERE	GERelatedTranToDocID = @DocID AND 
            GERelatedTranToDocTableName = @TableName AND
			GERelatedTranToDocModuleName = @ModName

--select * from #tFromScan
WHILE 1=1
BEGIN
	SET @iID = null 
	SELECT TOP 1 
		@iLV = LV,
		@iParentID = RelatedParentID, 
		@iID = GERelatedTranID, 
		@iDocID = GERelatedTranFromDocID, 
        @sDocTableName = GERelatedTranFromDocTableName,
		@sDocModName = GERelatedTranFromDocModuleName
	FROM #tFromScan
	ORDER BY GERelatedTranID DESC
		
	IF @iID is null --Khong con chung tu nao lien quan
		BREAK
	
	--(Them vao bang ket qua	
	INSERT INTO #tFrom
		VALUES(@iLV,@iID,@iParentID)
	--)
	
	--Xoa khong duyet nua
	DELETE FROM #tFromScan WHERE GERelatedTranID = @iID
	
	--Them danh sach cac chung tu moi lien quan de duyet tiep
	INSERT INTO #tFromScan
		SELECT @iLV+1,@iID,
			GERelatedTranID,GERelatedTranFromDocID,GERelatedTranFromDocTableName,GERelatedTranFromDocModuleName
			FROM GERelatedTrans
			WHERE GERelatedTranToDocID = @iDocID AND GERelatedTranToDocTableName = @sDocTableName AND GERelatedTranToDocModuleName = @sDocModName
			
END
--)


--(Hien thi ket qua

DECLARE @iDocNo as int 
DECLARE @sTableName as varchar(50)
DECLARE @sModlueDesc as nvarchar(max)
DECLARE @sUpdateTable as varchar(50)
DECLARE @strSQL as nvarchar(max)


SELECT a.*,
		GERelatedTranFromDocID as GERelatedTranDocID,
		GERelatedTranFromDocTableName as GERelatedTranDocTableName,
		GERelatedTranFromDocModuleName as GERelatedTranDocModuleName,
		GLVoucherNo as DocNo,
		GLVoucherDate as DocDate,
		STModuleDescriptionDescription as ModuleDesc
	INTO #tKQFrom
	FROM #tFrom a
		LEFT JOIN GLVouchers ON 1=2
		LEFT JOIN STModuleDescriptions ON 1=2		
		INNER JOIN GERelatedTrans b ON a.RelatedID = b.GERelatedTranID

DECLARE csScan CURSOR FOR
SELECT Distinct GERelatedTranDocTableName,GERelatedTranDocModuleName
	FROM #tKQFrom
OPEN csScan


FETCH NEXT FROM csScan
	INTO @sTableName, @sDocModName

WHILE @@FETCH_STATUS = 0 
BEGIN
	
	SELECT TOP 1 @sModlueDesc = STModuleDescriptionDescription
		FROM STModuleDescriptions a
			INNER JOIN STModules b ON a.STModuleID = b.STModuleID
		WHERE STModuleName = @sDocModName

	SET @strSQL = 'UPDATE #tKQFrom
		SET DocNo = b.' + Left(@sTableName,len(@sTableName)-1) + 'No,
			DocDate = b.' + Left(@sTableName,len(@sTableName)-1) + 'Date,
			ModuleDesc = N' + CHAR(39) + @sModlueDesc + CHAR(39) + '
		FROM #tKQFrom a
			INNER JOIN ' + @sTableName + ' b ON a.GERelatedTranDocID = b.' + LEFT(@sTableName,len(@sTableName)-1) + 'ID 
		WHERE a.GERelatedTranDocTableName = '+ CHAR(39) + @sTableName + CHAR(39) + '
		AND a.GERelatedTranDocModuleName = '+ CHAR(39) + @sDocModName + CHAR(39)
	EXEC sp_executesql @strSQL
	FETCH NEXT FROM csScan
		INTO @sTableName, @sDocModName
END
CLOSE csScan
DEALLOCATE csScan



SELECT * FROM #tKQFrom

--)
", piGERelatedTranDocID, psGERelatedTranTableName, psGERelatedTranModuleName);
            return GetDataSet(strQuery);
        }
        public DataSet GetToRelatedByIDTblNameAndModName(int piGERelatedTranDocID, string psGERelatedTranTableName, string psGERelatedTranModuleName)
        {
            //(Test data
            piGERelatedTranDocID = 33;
            psGERelatedTranTableName = "ARInvoices";
            psGERelatedTranModuleName = "Invoice";
            //)

            string strQuery = string.Format(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON
DECLARE @DocID as int 
DECLARE @ModName as varchar(50)
DECLARE @TableName as varchar(50)
--(Tham so chung tu hien tai
SET @DocID = {0}
SET @TableName = '{1}'
SET @ModName = '{2}'
--)

--(Tao cau truc bang ket qua
SELECT	cast( 0 as int) as Lv,
		GERelatedTranID as RelatedID,
		GERelatedTranID as ParentRelatedID
	INTO #tTo
	FROM GERelatedTrans
	WHERE 1 = 0
--)

DECLARE @iLv as int 
DECLARE @iID as int 
DECLARE @iParentID as int 
DECLARE @iDocID as int 
DECLARE @sDocTableName as varchar(50)
DECLARE @sDocModName as varchar(50)


--(Related To - Danh sach cac chung tu duoc tao tu chung tu nay
SELECT 1 as LV,
	GERelatedTranID as RelatedParentID,
	GERelatedTranID,GERelatedTranToDocID,GERelatedTranToDocTableName,GERelatedTranToDocModuleName
	INTO #tToScan
	FROM GERelatedTrans
	WHERE	GERelatedTranFromDocID = @DocID AND 
            GERelatedTranFromDocTableName = @TableName AND
			GERelatedTranFromDocModuleName = @ModName

--select * from #tToScan
WHILE 1=1
BEGIN
	SET @iID = null 
	SELECT TOP 1 
		@iLV = LV,
		@iParentID = RelatedParentID, 
		@iID = GERelatedTranID, 
		@iDocID = GERelatedTranToDocID, 
        @sDocTableName = GERelatedTranToDocTableName,
		@sDocModName = GERelatedTranToDocModuleName
	FROM #tToScan
	ORDER BY GERelatedTranID ASC
	
	IF @iID is null 
		BREAK
	
	INSERT INTO #tTo
		VALUES(@iLV,@iID,@iParentID)
		
	DELETE FROM #tToScan WHERE GERelatedTranID = @iID
	
	INSERT INTO #tToScan
		SELECT @iLV+1,@iID,
			GERelatedTranID,GERelatedTranToDocID,GERelatedTranToDocTableName,GERelatedTranToDocModuleName
			FROM GERelatedTrans
			WHERE GERelatedTranFromDocID = @iDocID AND GERelatedTranFromDocTableName = @sDocTableName AND GERelatedTranFromDocModuleName = @sDocModName 
			
END
--)

--(Hien thi ket qua

DECLARE @iDocNo as int 
DECLARE @sTableName as varchar(50)
DECLARE @sModlueDesc as nvarchar(max)
DECLARE @sUpdateTable as varchar(50)
DECLARE @strSQL as nvarchar(max)


SELECT a.*,
		GERelatedTranToDocID as GERelatedTranDocID,
		GERelatedTranToDocTableName as GERelatedTranDocTableName,
		GERelatedTranToDocModuleName as GERelatedTranDocModuleName,
		GLVoucherNo as DocNo,
		GLVoucherDate as DocDate,
		STModuleDescriptionDescription as ModuleDesc
	INTO #tKQTo
	FROM #tTo a
		LEFT JOIN GLVouchers ON 1=2
		LEFT JOIN STModuleDescriptions ON 1=2		
		INNER JOIN GERelatedTrans b ON a.RelatedID = b.GERelatedTranID

DECLARE csScan CURSOR FOR
SELECT Distinct GERelatedTranDocTableName,GERelatedTranDocModuleName
	FROM #tKQTo
OPEN csScan


FETCH NEXT FROM csScan
	INTO @sTableName, @sDocModName
	
WHILE @@FETCH_STATUS = 0 
BEGIN
	
	SELECT TOP 1 @sModlueDesc = STModuleDescriptionDescription
		FROM STModuleDescriptions a
			INNER JOIN STModules b ON a.STModuleID = b.STModuleID
		WHERE STModuleName = @sDocModName

	SET @strSQL = 'UPDATE #tKQTo
		SET DocNo = b.' + Left(@sTableName,len(@sTableName)-1) + 'No,
			DocDate = b.' + Left(@sTableName,len(@sTableName)-1) + 'Date,
			ModuleDesc = N' + CHAR(39) + @sModlueDesc + CHAR(39) + '
		FROM #tKQTo a
			INNER JOIN ' + @sTableName + ' b ON a.GERelatedTranDocID = b.' + LEFT(@sTableName,len(@sTableName)-1) + 'ID
		WHERE a.GERelatedTranDocTableName = '+ CHAR(39) + @sTableName + CHAR(39) + '
			AND a.GERelatedTranDocModuleName = '+ CHAR(39) + @sDocModName + CHAR(39)
	EXEC sp_executesql @strSQL
	FETCH NEXT FROM csScan
		INTO @sTableName, @sDocModName
END
CLOSE csScan
DEALLOCATE csScan
SELECT * FROM #tKQTo

--)
", piGERelatedTranDocID, psGERelatedTranTableName, psGERelatedTranModuleName);
            return GetDataSet(strQuery);
        }

        public DataSet GetFromRelation(int iGERelatedTranDocID, string strGERelatedTranTableName, string strGERelatedTranModuleName)
        {
            String str = String.Format(@"   SELECT * FROM dbo.GERelatedTrans
                                            WHERE GERelatedTranToDocID = {0}
                                            AND GERelatedTranToDocModuleName = '{1}'
                                            AND GERelatedTranToDocTableName = '{2}'"
                                        , iGERelatedTranDocID, strGERelatedTranModuleName, strGERelatedTranTableName);
            return dal.GetDataSet(str);
        }

        public DataSet GetToRelation(int iGERelatedTranDocID, string strGERelatedTranTableName, string strGERelatedTranModuleName)
        {
            String str = String.Format(@"   SELECT * FROM dbo.GERelatedTrans
                                            WHERE GERelatedTranFromDocID = {0}
                                            AND GERelatedTranFromDocModuleName = '{1}'
                                            AND GERelatedTranFromDocTableName = '{2}'"
                                        , iGERelatedTranDocID, strGERelatedTranModuleName, strGERelatedTranTableName);
            return dal.GetDataSet(str);
        }

        public GERelatedTransInfo GetGERelatedTranByDocFromANDDocTo(int iGERelatedTranFromDocID, string strGERelatedTranFromDocTableName, int iGERelatedTranToDocID, string strGERelatedTranToDocTableName)
        {
            string strQuery = string.Format(@"  SELECT TOP 1 * FROM GERelatedTrans 
                                                WHERE GERelatedTranFromDocID = {0} 
                                                AND GERelatedTranFromDocTableName = '{1}'
                                                AND GERelatedTranToDocID = {2}
                                                AND GERelatedTranToDocTableName = '{3}'"
                , iGERelatedTranFromDocID, strGERelatedTranFromDocTableName, iGERelatedTranToDocID, strGERelatedTranToDocTableName);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (GERelatedTransInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public bool DeleteRelatedTrans(int iGERelatedTranFromDocID, string strGERelatedTranFromDocTableName, int iGERelatedTranToDocID, string strGERelatedTranToDocTableName)
        {
            string strQuery = string.Format(@"  DELETE GERelatedTrans 
                                                WHERE GERelatedTranFromDocID = {0} 
                                                AND GERelatedTranFromDocTableName = '{1}'
                                                AND GERelatedTranToDocID = {2}
                                                AND GERelatedTranToDocTableName = '{3}'"
                , iGERelatedTranFromDocID, strGERelatedTranFromDocTableName, iGERelatedTranToDocID, strGERelatedTranToDocTableName);
            GetDataSet(strQuery);
            return true;
        }

        public string GetModuleNameByTableName(string strTableName)
        {
            string strQuery = string.Format(@"select STModuleName from [dbo].[STModules] where STModuleID in
                                                    (select top 1 STModuleID from [dbo].[STModuleTables] 
                                                        where STModuleTableName = '{0}' 
                                                        and STModuleTableLevelIndex = 0 order by STModuleID ASC)", strTableName);
            DataSet ds = GetDataSet(strQuery);
            if (ds == null || ds.Tables[0] == null || ds.Tables[0].Rows.Count == 0)
                return null;

            return ds.Tables[0].Rows[0]["STModuleName"].ToString();
        }
	}
	#endregion
}