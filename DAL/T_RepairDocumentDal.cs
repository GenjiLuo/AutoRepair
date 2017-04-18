// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairDocument.cs
// 项目名称：买车网
// 创建时间：2016/9/2
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Jnwf.Utils.Data;
using AutoRepair.Entity;



namespace AutoRepair.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.T_RepairDocument.
    /// </summary>
    public partial class T_RepairDocumentDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_RepairDocumentDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_RepairDocumentModel">T_RepairDocument实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_RepairDocumentEntity _T_RepairDocumentModel)
		{
			string sqlStr="insert into T_RepairDocument([ID],[CardKey],[RepairNumber],[AutoUnit],[RepairMan],[PlateNumber],[AutoBrand],[VIN],[EngineNumber],[ChassisNumber],[CarColor],[PlateColor],[AutoType],[RepairSort],[Waiter],[CheckMan],[SignDate],[FinishDate],[ContractNumber],[CertificateNumber],[Mileage],[Oil],[Phone],[UnitID],[UnitName],[UnitPhone],[UnitAddress],[Email],[BankName],[BankID],[ZDF],[JCF],[GSF],[CLF],[JGF],[QTF],[TotalMoney],[Remark],[CheckResult],[HGZH],[UploadTime],[ZBLC],[ZBRQ]) values(@ID,@CardKey,@RepairNumber,@AutoUnit,@RepairMan,@PlateNumber,@AutoBrand,@VIN,@EngineNumber,@ChassisNumber,@CarColor,@PlateColor,@AutoType,@RepairSort,@Waiter,@CheckMan,@SignDate,@FinishDate,@ContractNumber,@CertificateNumber,@Mileage,@Oil,@Phone,@UnitID,@UnitName,@UnitPhone,@UnitAddress,@Email,@BankName,@BankID,@ZDF,@JCF,@GSF,@CLF,@JGF,@QTF,@TotalMoney,@Remark,@CheckResult,@HGZH,@UploadTime,@ZBLC,@ZBRQ) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@CardKey",SqlDbType.VarChar),
			new SqlParameter("@RepairNumber",SqlDbType.VarChar),
			new SqlParameter("@AutoUnit",SqlDbType.VarChar),
			new SqlParameter("@RepairMan",SqlDbType.VarChar),
			new SqlParameter("@PlateNumber",SqlDbType.VarChar),
			new SqlParameter("@AutoBrand",SqlDbType.VarChar),
			new SqlParameter("@VIN",SqlDbType.VarChar),
			new SqlParameter("@EngineNumber",SqlDbType.VarChar),
			new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
			new SqlParameter("@CarColor",SqlDbType.VarChar),
			new SqlParameter("@PlateColor",SqlDbType.VarChar),
			new SqlParameter("@AutoType",SqlDbType.VarChar),
			new SqlParameter("@RepairSort",SqlDbType.VarChar),
			new SqlParameter("@Waiter",SqlDbType.VarChar),
			new SqlParameter("@CheckMan",SqlDbType.VarChar),
			new SqlParameter("@SignDate",SqlDbType.DateTime),
			new SqlParameter("@FinishDate",SqlDbType.DateTime),
			new SqlParameter("@ContractNumber",SqlDbType.VarChar),
			new SqlParameter("@CertificateNumber",SqlDbType.VarChar),
			new SqlParameter("@Mileage",SqlDbType.VarChar),
			new SqlParameter("@Oil",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@UnitName",SqlDbType.VarChar),
			new SqlParameter("@UnitPhone",SqlDbType.VarChar),
			new SqlParameter("@UnitAddress",SqlDbType.VarChar),
			new SqlParameter("@Email",SqlDbType.VarChar),
			new SqlParameter("@BankName",SqlDbType.VarChar),
			new SqlParameter("@BankID",SqlDbType.VarChar),
			new SqlParameter("@ZDF",SqlDbType.Decimal),
			new SqlParameter("@JCF",SqlDbType.Decimal),
			new SqlParameter("@GSF",SqlDbType.Decimal),
			new SqlParameter("@CLF",SqlDbType.Decimal),
			new SqlParameter("@JGF",SqlDbType.Decimal),
			new SqlParameter("@QTF",SqlDbType.Decimal),
			new SqlParameter("@TotalMoney",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@CheckResult",SqlDbType.VarChar),
			new SqlParameter("@HGZH",SqlDbType.VarChar),
			new SqlParameter("@UploadTime",SqlDbType.DateTime),
			new SqlParameter("@ZBLC",SqlDbType.VarChar),
			new SqlParameter("@ZBRQ",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairDocumentModel.ID;
			_param[1].Value=_T_RepairDocumentModel.CardKey;
			_param[2].Value=_T_RepairDocumentModel.RepairNumber;
			_param[3].Value=_T_RepairDocumentModel.AutoUnit;
			_param[4].Value=_T_RepairDocumentModel.RepairMan;
			_param[5].Value=_T_RepairDocumentModel.PlateNumber;
			_param[6].Value=_T_RepairDocumentModel.AutoBrand;
			_param[7].Value=_T_RepairDocumentModel.VIN;
			_param[8].Value=_T_RepairDocumentModel.EngineNumber;
			_param[9].Value=_T_RepairDocumentModel.ChassisNumber;
			_param[10].Value=_T_RepairDocumentModel.CarColor;
			_param[11].Value=_T_RepairDocumentModel.PlateColor;
			_param[12].Value=_T_RepairDocumentModel.AutoType;
			_param[13].Value=_T_RepairDocumentModel.RepairSort;
			_param[14].Value=_T_RepairDocumentModel.Waiter;
			_param[15].Value=_T_RepairDocumentModel.CheckMan;
			_param[16].Value=_T_RepairDocumentModel.SignDate;
			_param[17].Value=_T_RepairDocumentModel.FinishDate;
			_param[18].Value=_T_RepairDocumentModel.ContractNumber;
			_param[19].Value=_T_RepairDocumentModel.CertificateNumber;
			_param[20].Value=_T_RepairDocumentModel.Mileage;
			_param[21].Value=_T_RepairDocumentModel.Oil;
			_param[22].Value=_T_RepairDocumentModel.Phone;
			_param[23].Value=_T_RepairDocumentModel.UnitID;
			_param[24].Value=_T_RepairDocumentModel.UnitName;
			_param[25].Value=_T_RepairDocumentModel.UnitPhone;
			_param[26].Value=_T_RepairDocumentModel.UnitAddress;
			_param[27].Value=_T_RepairDocumentModel.Email;
			_param[28].Value=_T_RepairDocumentModel.BankName;
			_param[29].Value=_T_RepairDocumentModel.BankID;
			_param[30].Value=_T_RepairDocumentModel.ZDF;
			_param[31].Value=_T_RepairDocumentModel.JCF;
			_param[32].Value=_T_RepairDocumentModel.GSF;
			_param[33].Value=_T_RepairDocumentModel.CLF;
			_param[34].Value=_T_RepairDocumentModel.JGF;
			_param[35].Value=_T_RepairDocumentModel.QTF;
			_param[36].Value=_T_RepairDocumentModel.TotalMoney;
			_param[37].Value=_T_RepairDocumentModel.Remark;
			_param[38].Value=_T_RepairDocumentModel.CheckResult;
			_param[39].Value=_T_RepairDocumentModel.HGZH;
			_param[40].Value=_T_RepairDocumentModel.UploadTime;
			_param[41].Value=_T_RepairDocumentModel.ZBLC;
			_param[42].Value=_T_RepairDocumentModel.ZBRQ;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairDocumentModel">T_RepairDocument实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_RepairDocumentEntity _T_RepairDocumentModel)
		{
			string sqlStr="insert into T_RepairDocument([ID],[CardKey],[RepairNumber],[AutoUnit],[RepairMan],[PlateNumber],[AutoBrand],[VIN],[EngineNumber],[ChassisNumber],[CarColor],[PlateColor],[AutoType],[RepairSort],[Waiter],[CheckMan],[SignDate],[FinishDate],[ContractNumber],[CertificateNumber],[Mileage],[Oil],[Phone],[UnitID],[UnitName],[UnitPhone],[UnitAddress],[Email],[BankName],[BankID],[ZDF],[JCF],[GSF],[CLF],[JGF],[QTF],[TotalMoney],[Remark],[CheckResult],[HGZH],[UploadTime],[ZBLC],[ZBRQ]) values(@ID,@CardKey,@RepairNumber,@AutoUnit,@RepairMan,@PlateNumber,@AutoBrand,@VIN,@EngineNumber,@ChassisNumber,@CarColor,@PlateColor,@AutoType,@RepairSort,@Waiter,@CheckMan,@SignDate,@FinishDate,@ContractNumber,@CertificateNumber,@Mileage,@Oil,@Phone,@UnitID,@UnitName,@UnitPhone,@UnitAddress,@Email,@BankName,@BankID,@ZDF,@JCF,@GSF,@CLF,@JGF,@QTF,@TotalMoney,@Remark,@CheckResult,@HGZH,@UploadTime,@ZBLC,@ZBRQ) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@CardKey",SqlDbType.VarChar),
			new SqlParameter("@RepairNumber",SqlDbType.VarChar),
			new SqlParameter("@AutoUnit",SqlDbType.VarChar),
			new SqlParameter("@RepairMan",SqlDbType.VarChar),
			new SqlParameter("@PlateNumber",SqlDbType.VarChar),
			new SqlParameter("@AutoBrand",SqlDbType.VarChar),
			new SqlParameter("@VIN",SqlDbType.VarChar),
			new SqlParameter("@EngineNumber",SqlDbType.VarChar),
			new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
			new SqlParameter("@CarColor",SqlDbType.VarChar),
			new SqlParameter("@PlateColor",SqlDbType.VarChar),
			new SqlParameter("@AutoType",SqlDbType.VarChar),
			new SqlParameter("@RepairSort",SqlDbType.VarChar),
			new SqlParameter("@Waiter",SqlDbType.VarChar),
			new SqlParameter("@CheckMan",SqlDbType.VarChar),
			new SqlParameter("@SignDate",SqlDbType.DateTime),
			new SqlParameter("@FinishDate",SqlDbType.DateTime),
			new SqlParameter("@ContractNumber",SqlDbType.VarChar),
			new SqlParameter("@CertificateNumber",SqlDbType.VarChar),
			new SqlParameter("@Mileage",SqlDbType.VarChar),
			new SqlParameter("@Oil",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@UnitName",SqlDbType.VarChar),
			new SqlParameter("@UnitPhone",SqlDbType.VarChar),
			new SqlParameter("@UnitAddress",SqlDbType.VarChar),
			new SqlParameter("@Email",SqlDbType.VarChar),
			new SqlParameter("@BankName",SqlDbType.VarChar),
			new SqlParameter("@BankID",SqlDbType.VarChar),
			new SqlParameter("@ZDF",SqlDbType.Decimal),
			new SqlParameter("@JCF",SqlDbType.Decimal),
			new SqlParameter("@GSF",SqlDbType.Decimal),
			new SqlParameter("@CLF",SqlDbType.Decimal),
			new SqlParameter("@JGF",SqlDbType.Decimal),
			new SqlParameter("@QTF",SqlDbType.Decimal),
			new SqlParameter("@TotalMoney",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@CheckResult",SqlDbType.VarChar),
			new SqlParameter("@HGZH",SqlDbType.VarChar),
			new SqlParameter("@UploadTime",SqlDbType.DateTime),
			new SqlParameter("@ZBLC",SqlDbType.VarChar),
			new SqlParameter("@ZBRQ",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairDocumentModel.ID;
			_param[1].Value=_T_RepairDocumentModel.CardKey;
			_param[2].Value=_T_RepairDocumentModel.RepairNumber;
			_param[3].Value=_T_RepairDocumentModel.AutoUnit;
			_param[4].Value=_T_RepairDocumentModel.RepairMan;
			_param[5].Value=_T_RepairDocumentModel.PlateNumber;
			_param[6].Value=_T_RepairDocumentModel.AutoBrand;
			_param[7].Value=_T_RepairDocumentModel.VIN;
			_param[8].Value=_T_RepairDocumentModel.EngineNumber;
			_param[9].Value=_T_RepairDocumentModel.ChassisNumber;
			_param[10].Value=_T_RepairDocumentModel.CarColor;
			_param[11].Value=_T_RepairDocumentModel.PlateColor;
			_param[12].Value=_T_RepairDocumentModel.AutoType;
			_param[13].Value=_T_RepairDocumentModel.RepairSort;
			_param[14].Value=_T_RepairDocumentModel.Waiter;
			_param[15].Value=_T_RepairDocumentModel.CheckMan;
			_param[16].Value=_T_RepairDocumentModel.SignDate;
			_param[17].Value=_T_RepairDocumentModel.FinishDate;
			_param[18].Value=_T_RepairDocumentModel.ContractNumber;
			_param[19].Value=_T_RepairDocumentModel.CertificateNumber;
			_param[20].Value=_T_RepairDocumentModel.Mileage;
			_param[21].Value=_T_RepairDocumentModel.Oil;
			_param[22].Value=_T_RepairDocumentModel.Phone;
			_param[23].Value=_T_RepairDocumentModel.UnitID;
			_param[24].Value=_T_RepairDocumentModel.UnitName;
			_param[25].Value=_T_RepairDocumentModel.UnitPhone;
			_param[26].Value=_T_RepairDocumentModel.UnitAddress;
			_param[27].Value=_T_RepairDocumentModel.Email;
			_param[28].Value=_T_RepairDocumentModel.BankName;
			_param[29].Value=_T_RepairDocumentModel.BankID;
			_param[30].Value=_T_RepairDocumentModel.ZDF;
			_param[31].Value=_T_RepairDocumentModel.JCF;
			_param[32].Value=_T_RepairDocumentModel.GSF;
			_param[33].Value=_T_RepairDocumentModel.CLF;
			_param[34].Value=_T_RepairDocumentModel.JGF;
			_param[35].Value=_T_RepairDocumentModel.QTF;
			_param[36].Value=_T_RepairDocumentModel.TotalMoney;
			_param[37].Value=_T_RepairDocumentModel.Remark;
			_param[38].Value=_T_RepairDocumentModel.CheckResult;
			_param[39].Value=_T_RepairDocumentModel.HGZH;
			_param[40].Value=_T_RepairDocumentModel.UploadTime;
			_param[41].Value=_T_RepairDocumentModel.ZBLC;
			_param[42].Value=_T_RepairDocumentModel.ZBRQ;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_RepairDocument更新一条记录。
		/// </summary>
		/// <param name="_T_RepairDocumentModel">_T_RepairDocumentModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_RepairDocumentEntity _T_RepairDocumentModel)
		{
            string sqlStr="update T_RepairDocument set [CardKey]=@CardKey,[RepairNumber]=@RepairNumber,[AutoUnit]=@AutoUnit,[RepairMan]=@RepairMan,[PlateNumber]=@PlateNumber,[AutoBrand]=@AutoBrand,[VIN]=@VIN,[EngineNumber]=@EngineNumber,[ChassisNumber]=@ChassisNumber,[CarColor]=@CarColor,[PlateColor]=@PlateColor,[AutoType]=@AutoType,[RepairSort]=@RepairSort,[Waiter]=@Waiter,[CheckMan]=@CheckMan,[SignDate]=@SignDate,[FinishDate]=@FinishDate,[ContractNumber]=@ContractNumber,[CertificateNumber]=@CertificateNumber,[Mileage]=@Mileage,[Oil]=@Oil,[Phone]=@Phone,[UnitID]=@UnitID,[UnitName]=@UnitName,[UnitPhone]=@UnitPhone,[UnitAddress]=@UnitAddress,[Email]=@Email,[BankName]=@BankName,[BankID]=@BankID,[ZDF]=@ZDF,[JCF]=@JCF,[GSF]=@GSF,[CLF]=@CLF,[JGF]=@JGF,[QTF]=@QTF,[TotalMoney]=@TotalMoney,[Remark]=@Remark,[CheckResult]=@CheckResult,[HGZH]=@HGZH,[UploadTime]=@UploadTime,[ZBLC]=@ZBLC,[ZBRQ]=@ZBRQ where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@CardKey",SqlDbType.VarChar),
				new SqlParameter("@RepairNumber",SqlDbType.VarChar),
				new SqlParameter("@AutoUnit",SqlDbType.VarChar),
				new SqlParameter("@RepairMan",SqlDbType.VarChar),
				new SqlParameter("@PlateNumber",SqlDbType.VarChar),
				new SqlParameter("@AutoBrand",SqlDbType.VarChar),
				new SqlParameter("@VIN",SqlDbType.VarChar),
				new SqlParameter("@EngineNumber",SqlDbType.VarChar),
				new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
				new SqlParameter("@CarColor",SqlDbType.VarChar),
				new SqlParameter("@PlateColor",SqlDbType.VarChar),
				new SqlParameter("@AutoType",SqlDbType.VarChar),
				new SqlParameter("@RepairSort",SqlDbType.VarChar),
				new SqlParameter("@Waiter",SqlDbType.VarChar),
				new SqlParameter("@CheckMan",SqlDbType.VarChar),
				new SqlParameter("@SignDate",SqlDbType.DateTime),
				new SqlParameter("@FinishDate",SqlDbType.DateTime),
				new SqlParameter("@ContractNumber",SqlDbType.VarChar),
				new SqlParameter("@CertificateNumber",SqlDbType.VarChar),
				new SqlParameter("@Mileage",SqlDbType.VarChar),
				new SqlParameter("@Oil",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@UnitName",SqlDbType.VarChar),
				new SqlParameter("@UnitPhone",SqlDbType.VarChar),
				new SqlParameter("@UnitAddress",SqlDbType.VarChar),
				new SqlParameter("@Email",SqlDbType.VarChar),
				new SqlParameter("@BankName",SqlDbType.VarChar),
				new SqlParameter("@BankID",SqlDbType.VarChar),
				new SqlParameter("@ZDF",SqlDbType.Decimal),
				new SqlParameter("@JCF",SqlDbType.Decimal),
				new SqlParameter("@GSF",SqlDbType.Decimal),
				new SqlParameter("@CLF",SqlDbType.Decimal),
				new SqlParameter("@JGF",SqlDbType.Decimal),
				new SqlParameter("@QTF",SqlDbType.Decimal),
				new SqlParameter("@TotalMoney",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@CheckResult",SqlDbType.VarChar),
				new SqlParameter("@HGZH",SqlDbType.VarChar),
				new SqlParameter("@UploadTime",SqlDbType.DateTime),
				new SqlParameter("@ZBLC",SqlDbType.VarChar),
				new SqlParameter("@ZBRQ",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairDocumentModel.ID;
				_param[1].Value=_T_RepairDocumentModel.CardKey;
				_param[2].Value=_T_RepairDocumentModel.RepairNumber;
				_param[3].Value=_T_RepairDocumentModel.AutoUnit;
				_param[4].Value=_T_RepairDocumentModel.RepairMan;
				_param[5].Value=_T_RepairDocumentModel.PlateNumber;
				_param[6].Value=_T_RepairDocumentModel.AutoBrand;
				_param[7].Value=_T_RepairDocumentModel.VIN;
				_param[8].Value=_T_RepairDocumentModel.EngineNumber;
				_param[9].Value=_T_RepairDocumentModel.ChassisNumber;
				_param[10].Value=_T_RepairDocumentModel.CarColor;
				_param[11].Value=_T_RepairDocumentModel.PlateColor;
				_param[12].Value=_T_RepairDocumentModel.AutoType;
				_param[13].Value=_T_RepairDocumentModel.RepairSort;
				_param[14].Value=_T_RepairDocumentModel.Waiter;
				_param[15].Value=_T_RepairDocumentModel.CheckMan;
				_param[16].Value=_T_RepairDocumentModel.SignDate;
				_param[17].Value=_T_RepairDocumentModel.FinishDate;
				_param[18].Value=_T_RepairDocumentModel.ContractNumber;
				_param[19].Value=_T_RepairDocumentModel.CertificateNumber;
				_param[20].Value=_T_RepairDocumentModel.Mileage;
				_param[21].Value=_T_RepairDocumentModel.Oil;
				_param[22].Value=_T_RepairDocumentModel.Phone;
				_param[23].Value=_T_RepairDocumentModel.UnitID;
				_param[24].Value=_T_RepairDocumentModel.UnitName;
				_param[25].Value=_T_RepairDocumentModel.UnitPhone;
				_param[26].Value=_T_RepairDocumentModel.UnitAddress;
				_param[27].Value=_T_RepairDocumentModel.Email;
				_param[28].Value=_T_RepairDocumentModel.BankName;
				_param[29].Value=_T_RepairDocumentModel.BankID;
				_param[30].Value=_T_RepairDocumentModel.ZDF;
				_param[31].Value=_T_RepairDocumentModel.JCF;
				_param[32].Value=_T_RepairDocumentModel.GSF;
				_param[33].Value=_T_RepairDocumentModel.CLF;
				_param[34].Value=_T_RepairDocumentModel.JGF;
				_param[35].Value=_T_RepairDocumentModel.QTF;
				_param[36].Value=_T_RepairDocumentModel.TotalMoney;
				_param[37].Value=_T_RepairDocumentModel.Remark;
				_param[38].Value=_T_RepairDocumentModel.CheckResult;
				_param[39].Value=_T_RepairDocumentModel.HGZH;
				_param[40].Value=_T_RepairDocumentModel.UploadTime;
				_param[41].Value=_T_RepairDocumentModel.ZBLC;
				_param[42].Value=_T_RepairDocumentModel.ZBRQ;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_RepairDocument更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairDocumentModel">_T_RepairDocumentModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_RepairDocumentEntity _T_RepairDocumentModel)
		{
            string sqlStr="update T_RepairDocument set [CardKey]=@CardKey,[RepairNumber]=@RepairNumber,[AutoUnit]=@AutoUnit,[RepairMan]=@RepairMan,[PlateNumber]=@PlateNumber,[AutoBrand]=@AutoBrand,[VIN]=@VIN,[EngineNumber]=@EngineNumber,[ChassisNumber]=@ChassisNumber,[CarColor]=@CarColor,[PlateColor]=@PlateColor,[AutoType]=@AutoType,[RepairSort]=@RepairSort,[Waiter]=@Waiter,[CheckMan]=@CheckMan,[SignDate]=@SignDate,[FinishDate]=@FinishDate,[ContractNumber]=@ContractNumber,[CertificateNumber]=@CertificateNumber,[Mileage]=@Mileage,[Oil]=@Oil,[Phone]=@Phone,[UnitID]=@UnitID,[UnitName]=@UnitName,[UnitPhone]=@UnitPhone,[UnitAddress]=@UnitAddress,[Email]=@Email,[BankName]=@BankName,[BankID]=@BankID,[ZDF]=@ZDF,[JCF]=@JCF,[GSF]=@GSF,[CLF]=@CLF,[JGF]=@JGF,[QTF]=@QTF,[TotalMoney]=@TotalMoney,[Remark]=@Remark,[CheckResult]=@CheckResult,[HGZH]=@HGZH,[UploadTime]=@UploadTime,[ZBLC]=@ZBLC,[ZBRQ]=@ZBRQ where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@CardKey",SqlDbType.VarChar),
				new SqlParameter("@RepairNumber",SqlDbType.VarChar),
				new SqlParameter("@AutoUnit",SqlDbType.VarChar),
				new SqlParameter("@RepairMan",SqlDbType.VarChar),
				new SqlParameter("@PlateNumber",SqlDbType.VarChar),
				new SqlParameter("@AutoBrand",SqlDbType.VarChar),
				new SqlParameter("@VIN",SqlDbType.VarChar),
				new SqlParameter("@EngineNumber",SqlDbType.VarChar),
				new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
				new SqlParameter("@CarColor",SqlDbType.VarChar),
				new SqlParameter("@PlateColor",SqlDbType.VarChar),
				new SqlParameter("@AutoType",SqlDbType.VarChar),
				new SqlParameter("@RepairSort",SqlDbType.VarChar),
				new SqlParameter("@Waiter",SqlDbType.VarChar),
				new SqlParameter("@CheckMan",SqlDbType.VarChar),
				new SqlParameter("@SignDate",SqlDbType.DateTime),
				new SqlParameter("@FinishDate",SqlDbType.DateTime),
				new SqlParameter("@ContractNumber",SqlDbType.VarChar),
				new SqlParameter("@CertificateNumber",SqlDbType.VarChar),
				new SqlParameter("@Mileage",SqlDbType.VarChar),
				new SqlParameter("@Oil",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@UnitName",SqlDbType.VarChar),
				new SqlParameter("@UnitPhone",SqlDbType.VarChar),
				new SqlParameter("@UnitAddress",SqlDbType.VarChar),
				new SqlParameter("@Email",SqlDbType.VarChar),
				new SqlParameter("@BankName",SqlDbType.VarChar),
				new SqlParameter("@BankID",SqlDbType.VarChar),
				new SqlParameter("@ZDF",SqlDbType.Decimal),
				new SqlParameter("@JCF",SqlDbType.Decimal),
				new SqlParameter("@GSF",SqlDbType.Decimal),
				new SqlParameter("@CLF",SqlDbType.Decimal),
				new SqlParameter("@JGF",SqlDbType.Decimal),
				new SqlParameter("@QTF",SqlDbType.Decimal),
				new SqlParameter("@TotalMoney",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@CheckResult",SqlDbType.VarChar),
				new SqlParameter("@HGZH",SqlDbType.VarChar),
				new SqlParameter("@UploadTime",SqlDbType.DateTime),
				new SqlParameter("@ZBLC",SqlDbType.VarChar),
				new SqlParameter("@ZBRQ",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairDocumentModel.ID;
				_param[1].Value=_T_RepairDocumentModel.CardKey;
				_param[2].Value=_T_RepairDocumentModel.RepairNumber;
				_param[3].Value=_T_RepairDocumentModel.AutoUnit;
				_param[4].Value=_T_RepairDocumentModel.RepairMan;
				_param[5].Value=_T_RepairDocumentModel.PlateNumber;
				_param[6].Value=_T_RepairDocumentModel.AutoBrand;
				_param[7].Value=_T_RepairDocumentModel.VIN;
				_param[8].Value=_T_RepairDocumentModel.EngineNumber;
				_param[9].Value=_T_RepairDocumentModel.ChassisNumber;
				_param[10].Value=_T_RepairDocumentModel.CarColor;
				_param[11].Value=_T_RepairDocumentModel.PlateColor;
				_param[12].Value=_T_RepairDocumentModel.AutoType;
				_param[13].Value=_T_RepairDocumentModel.RepairSort;
				_param[14].Value=_T_RepairDocumentModel.Waiter;
				_param[15].Value=_T_RepairDocumentModel.CheckMan;
				_param[16].Value=_T_RepairDocumentModel.SignDate;
				_param[17].Value=_T_RepairDocumentModel.FinishDate;
				_param[18].Value=_T_RepairDocumentModel.ContractNumber;
				_param[19].Value=_T_RepairDocumentModel.CertificateNumber;
				_param[20].Value=_T_RepairDocumentModel.Mileage;
				_param[21].Value=_T_RepairDocumentModel.Oil;
				_param[22].Value=_T_RepairDocumentModel.Phone;
				_param[23].Value=_T_RepairDocumentModel.UnitID;
				_param[24].Value=_T_RepairDocumentModel.UnitName;
				_param[25].Value=_T_RepairDocumentModel.UnitPhone;
				_param[26].Value=_T_RepairDocumentModel.UnitAddress;
				_param[27].Value=_T_RepairDocumentModel.Email;
				_param[28].Value=_T_RepairDocumentModel.BankName;
				_param[29].Value=_T_RepairDocumentModel.BankID;
				_param[30].Value=_T_RepairDocumentModel.ZDF;
				_param[31].Value=_T_RepairDocumentModel.JCF;
				_param[32].Value=_T_RepairDocumentModel.GSF;
				_param[33].Value=_T_RepairDocumentModel.CLF;
				_param[34].Value=_T_RepairDocumentModel.JGF;
				_param[35].Value=_T_RepairDocumentModel.QTF;
				_param[36].Value=_T_RepairDocumentModel.TotalMoney;
				_param[37].Value=_T_RepairDocumentModel.Remark;
				_param[38].Value=_T_RepairDocumentModel.CheckResult;
				_param[39].Value=_T_RepairDocumentModel.HGZH;
				_param[40].Value=_T_RepairDocumentModel.UploadTime;
				_param[41].Value=_T_RepairDocumentModel.ZBLC;
				_param[42].Value=_T_RepairDocumentModel.ZBRQ;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_RepairDocument中的一条记录
		/// </summary>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ID)
		{
			string sqlStr="delete from T_RepairDocument where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_RepairDocument中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ID)
		{
			string sqlStr="delete from T_RepairDocument where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_repairdocument 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_repairdocument 数据实体</returns>
		public T_RepairDocumentEntity Populate_T_RepairDocumentEntity_FromDr(DataRow row)
		{
			T_RepairDocumentEntity Obj = new T_RepairDocumentEntity();
			if(row!=null)
			{
				Obj.ID = (( row["ID"])==DBNull.Value)?0:Convert.ToInt32( row["ID"]);
				Obj.CardKey =  row["CardKey"].ToString();
				Obj.RepairNumber =  row["RepairNumber"].ToString();
				Obj.AutoUnit =  row["AutoUnit"].ToString();
				Obj.RepairMan =  row["RepairMan"].ToString();
				Obj.PlateNumber =  row["PlateNumber"].ToString();
				Obj.AutoBrand =  row["AutoBrand"].ToString();
				Obj.VIN =  row["VIN"].ToString();
				Obj.EngineNumber =  row["EngineNumber"].ToString();
				Obj.ChassisNumber =  row["ChassisNumber"].ToString();
				Obj.CarColor =  row["CarColor"].ToString();
				Obj.PlateColor =  row["PlateColor"].ToString();
				Obj.AutoType =  row["AutoType"].ToString();
				Obj.RepairSort =  row["RepairSort"].ToString();
				Obj.Waiter =  row["Waiter"].ToString();
				Obj.CheckMan =  row["CheckMan"].ToString();
				Obj.SignDate = (( row["SignDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["SignDate"]);
				Obj.FinishDate = (( row["FinishDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["FinishDate"]);
				Obj.ContractNumber =  row["ContractNumber"].ToString();
				Obj.CertificateNumber =  row["CertificateNumber"].ToString();
				Obj.Mileage =  row["Mileage"].ToString();
				Obj.Oil =  row["Oil"].ToString();
				Obj.Phone =  row["Phone"].ToString();
				Obj.UnitID =  row["UnitID"].ToString();
				Obj.UnitName =  row["UnitName"].ToString();
				Obj.UnitPhone =  row["UnitPhone"].ToString();
				Obj.UnitAddress =  row["UnitAddress"].ToString();
				Obj.Email =  row["Email"].ToString();
				Obj.BankName =  row["BankName"].ToString();
				Obj.BankID =  row["BankID"].ToString();
				Obj.ZDF = (( row["ZDF"])==DBNull.Value)?0:Convert.ToDecimal( row["ZDF"]);
				Obj.JCF = (( row["JCF"])==DBNull.Value)?0:Convert.ToDecimal( row["JCF"]);
				Obj.GSF = (( row["GSF"])==DBNull.Value)?0:Convert.ToDecimal( row["GSF"]);
				Obj.CLF = (( row["CLF"])==DBNull.Value)?0:Convert.ToDecimal( row["CLF"]);
				Obj.JGF = (( row["JGF"])==DBNull.Value)?0:Convert.ToDecimal( row["JGF"]);
				Obj.QTF = (( row["QTF"])==DBNull.Value)?0:Convert.ToDecimal( row["QTF"]);
				Obj.TotalMoney = (( row["TotalMoney"])==DBNull.Value)?0:Convert.ToDecimal( row["TotalMoney"]);
				Obj.Remark =  row["Remark"].ToString();
				Obj.CheckResult =  row["CheckResult"].ToString();
				Obj.HGZH =  row["HGZH"].ToString();
				Obj.UploadTime = (( row["UploadTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UploadTime"]);
				Obj.ZBLC =  row["ZBLC"].ToString();
				Obj.ZBRQ =  row["ZBRQ"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  t_repairdocument 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_repairdocument 数据实体</returns>
		public T_RepairDocumentEntity Populate_T_RepairDocumentEntity_FromDr(IDataReader dr)
		{
			T_RepairDocumentEntity Obj = new T_RepairDocumentEntity();
			
				Obj.ID = (( dr["ID"])==DBNull.Value)?0:Convert.ToInt32( dr["ID"]);
				Obj.CardKey =  dr["CardKey"].ToString();
				Obj.RepairNumber =  dr["RepairNumber"].ToString();
				Obj.AutoUnit =  dr["AutoUnit"].ToString();
				Obj.RepairMan =  dr["RepairMan"].ToString();
				Obj.PlateNumber =  dr["PlateNumber"].ToString();
				Obj.AutoBrand =  dr["AutoBrand"].ToString();
				Obj.VIN =  dr["VIN"].ToString();
				Obj.EngineNumber =  dr["EngineNumber"].ToString();
				Obj.ChassisNumber =  dr["ChassisNumber"].ToString();
				Obj.CarColor =  dr["CarColor"].ToString();
				Obj.PlateColor =  dr["PlateColor"].ToString();
				Obj.AutoType =  dr["AutoType"].ToString();
				Obj.RepairSort =  dr["RepairSort"].ToString();
				Obj.Waiter =  dr["Waiter"].ToString();
				Obj.CheckMan =  dr["CheckMan"].ToString();
				Obj.SignDate = (( dr["SignDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["SignDate"]);
				Obj.FinishDate = (( dr["FinishDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["FinishDate"]);
				Obj.ContractNumber =  dr["ContractNumber"].ToString();
				Obj.CertificateNumber =  dr["CertificateNumber"].ToString();
				Obj.Mileage =  dr["Mileage"].ToString();
				Obj.Oil =  dr["Oil"].ToString();
				Obj.Phone =  dr["Phone"].ToString();
				Obj.UnitID =  dr["UnitID"].ToString();
				Obj.UnitName =  dr["UnitName"].ToString();
				Obj.UnitPhone =  dr["UnitPhone"].ToString();
				Obj.UnitAddress =  dr["UnitAddress"].ToString();
				Obj.Email =  dr["Email"].ToString();
				Obj.BankName =  dr["BankName"].ToString();
				Obj.BankID =  dr["BankID"].ToString();
				Obj.ZDF = (( dr["ZDF"])==DBNull.Value)?0:Convert.ToDecimal( dr["ZDF"]);
				Obj.JCF = (( dr["JCF"])==DBNull.Value)?0:Convert.ToDecimal( dr["JCF"]);
				Obj.GSF = (( dr["GSF"])==DBNull.Value)?0:Convert.ToDecimal( dr["GSF"]);
				Obj.CLF = (( dr["CLF"])==DBNull.Value)?0:Convert.ToDecimal( dr["CLF"]);
				Obj.JGF = (( dr["JGF"])==DBNull.Value)?0:Convert.ToDecimal( dr["JGF"]);
				Obj.QTF = (( dr["QTF"])==DBNull.Value)?0:Convert.ToDecimal( dr["QTF"]);
				Obj.TotalMoney = (( dr["TotalMoney"])==DBNull.Value)?0:Convert.ToDecimal( dr["TotalMoney"]);
				Obj.Remark =  dr["Remark"].ToString();
				Obj.CheckResult =  dr["CheckResult"].ToString();
				Obj.HGZH =  dr["HGZH"].ToString();
				Obj.UploadTime = (( dr["UploadTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UploadTime"]);
				Obj.ZBLC =  dr["ZBLC"].ToString();
				Obj.ZBRQ =  dr["ZBRQ"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_RepairDocument对象
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>T_RepairDocument对象</returns>
		public T_RepairDocumentEntity Get_T_RepairDocumentEntity (int iD)
		{
			T_RepairDocumentEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int)
			};
			_param[0].Value=iD;
			string sqlStr="select * from T_RepairDocument with(nolock) where ID=@ID";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_RepairDocumentEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_RepairDocument所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_RepairDocumentEntity> Get_T_RepairDocumentAll()
		{
			IList< T_RepairDocumentEntity> Obj=new List< T_RepairDocumentEntity>();
			string sqlStr="select * from T_RepairDocument";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_RepairDocumentEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>是/否</returns>
		public bool IsExistT_RepairDocument(int iD)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@iD",SqlDbType.Int)
                                  };
            _param[0].Value=iD;
            string sqlStr="select Count(*) from T_RepairDocument where ID=@iD";
            int a=Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
            if(a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

        #endregion
		
		#region----------自定义实例化接口函数----------
		#endregion
    }
}
