// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_AutoInfo.cs
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
    /// 数据层实例化接口类 dbo.T_AutoInfo.
    /// </summary>
    public partial class T_AutoInfoDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_AutoInfoDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_AutoInfoModel">T_AutoInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_AutoInfoEntity _T_AutoInfoModel)
		{
			string sqlStr="insert into T_AutoInfo([ID],[PlateNumber],[PlateColor],[VIN],[AutoBrand],[AutoType],[AutoNature],[UnitName],[LinkMan],[Phone],[EngineNumber],[AutoColor],[ChassisNumber],[Remark],[CardNumber],[UnitID],[BusinessInsuranceCompany],[BusinessInsuranceNumber],[BusinessInsuranceDate],[EnforceInsuranceCompany],[EnforceInsuranceNumber],[EnforceInsuranceDate]) values(@ID,@PlateNumber,@PlateColor,@VIN,@AutoBrand,@AutoType,@AutoNature,@UnitName,@LinkMan,@Phone,@EngineNumber,@AutoColor,@ChassisNumber,@Remark,@CardNumber,@UnitID,@BusinessInsuranceCompany,@BusinessInsuranceNumber,@BusinessInsuranceDate,@EnforceInsuranceCompany,@EnforceInsuranceNumber,@EnforceInsuranceDate) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@PlateNumber",SqlDbType.VarChar),
			new SqlParameter("@PlateColor",SqlDbType.VarChar),
			new SqlParameter("@VIN",SqlDbType.VarChar),
			new SqlParameter("@AutoBrand",SqlDbType.VarChar),
			new SqlParameter("@AutoType",SqlDbType.VarChar),
			new SqlParameter("@AutoNature",SqlDbType.VarChar),
			new SqlParameter("@UnitName",SqlDbType.VarChar),
			new SqlParameter("@LinkMan",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@EngineNumber",SqlDbType.VarChar),
			new SqlParameter("@AutoColor",SqlDbType.VarChar),
			new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@CardNumber",SqlDbType.VarChar),
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@BusinessInsuranceCompany",SqlDbType.VarChar),
			new SqlParameter("@BusinessInsuranceNumber",SqlDbType.VarChar),
			new SqlParameter("@BusinessInsuranceDate",SqlDbType.DateTime),
			new SqlParameter("@EnforceInsuranceCompany",SqlDbType.VarChar),
			new SqlParameter("@EnforceInsuranceNumber",SqlDbType.VarChar),
			new SqlParameter("@EnforceInsuranceDate",SqlDbType.DateTime)
			};			
			_param[0].Value=_T_AutoInfoModel.ID;
			_param[1].Value=_T_AutoInfoModel.PlateNumber;
			_param[2].Value=_T_AutoInfoModel.PlateColor;
			_param[3].Value=_T_AutoInfoModel.VIN;
			_param[4].Value=_T_AutoInfoModel.AutoBrand;
			_param[5].Value=_T_AutoInfoModel.AutoType;
			_param[6].Value=_T_AutoInfoModel.AutoNature;
			_param[7].Value=_T_AutoInfoModel.UnitName;
			_param[8].Value=_T_AutoInfoModel.LinkMan;
			_param[9].Value=_T_AutoInfoModel.Phone;
			_param[10].Value=_T_AutoInfoModel.EngineNumber;
			_param[11].Value=_T_AutoInfoModel.AutoColor;
			_param[12].Value=_T_AutoInfoModel.ChassisNumber;
			_param[13].Value=_T_AutoInfoModel.Remark;
			_param[14].Value=_T_AutoInfoModel.CardNumber;
			_param[15].Value=_T_AutoInfoModel.UnitID;
			_param[16].Value=_T_AutoInfoModel.BusinessInsuranceCompany;
			_param[17].Value=_T_AutoInfoModel.BusinessInsuranceNumber;
			_param[18].Value=_T_AutoInfoModel.BusinessInsuranceDate;
			_param[19].Value=_T_AutoInfoModel.EnforceInsuranceCompany;
			_param[20].Value=_T_AutoInfoModel.EnforceInsuranceNumber;
			_param[21].Value=_T_AutoInfoModel.EnforceInsuranceDate;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_AutoInfoModel">T_AutoInfo实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_AutoInfoEntity _T_AutoInfoModel)
		{
			string sqlStr="insert into T_AutoInfo([ID],[PlateNumber],[PlateColor],[VIN],[AutoBrand],[AutoType],[AutoNature],[UnitName],[LinkMan],[Phone],[EngineNumber],[AutoColor],[ChassisNumber],[Remark],[CardNumber],[UnitID],[BusinessInsuranceCompany],[BusinessInsuranceNumber],[BusinessInsuranceDate],[EnforceInsuranceCompany],[EnforceInsuranceNumber],[EnforceInsuranceDate]) values(@ID,@PlateNumber,@PlateColor,@VIN,@AutoBrand,@AutoType,@AutoNature,@UnitName,@LinkMan,@Phone,@EngineNumber,@AutoColor,@ChassisNumber,@Remark,@CardNumber,@UnitID,@BusinessInsuranceCompany,@BusinessInsuranceNumber,@BusinessInsuranceDate,@EnforceInsuranceCompany,@EnforceInsuranceNumber,@EnforceInsuranceDate) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@PlateNumber",SqlDbType.VarChar),
			new SqlParameter("@PlateColor",SqlDbType.VarChar),
			new SqlParameter("@VIN",SqlDbType.VarChar),
			new SqlParameter("@AutoBrand",SqlDbType.VarChar),
			new SqlParameter("@AutoType",SqlDbType.VarChar),
			new SqlParameter("@AutoNature",SqlDbType.VarChar),
			new SqlParameter("@UnitName",SqlDbType.VarChar),
			new SqlParameter("@LinkMan",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@EngineNumber",SqlDbType.VarChar),
			new SqlParameter("@AutoColor",SqlDbType.VarChar),
			new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@CardNumber",SqlDbType.VarChar),
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@BusinessInsuranceCompany",SqlDbType.VarChar),
			new SqlParameter("@BusinessInsuranceNumber",SqlDbType.VarChar),
			new SqlParameter("@BusinessInsuranceDate",SqlDbType.DateTime),
			new SqlParameter("@EnforceInsuranceCompany",SqlDbType.VarChar),
			new SqlParameter("@EnforceInsuranceNumber",SqlDbType.VarChar),
			new SqlParameter("@EnforceInsuranceDate",SqlDbType.DateTime)
			};			
			_param[0].Value=_T_AutoInfoModel.ID;
			_param[1].Value=_T_AutoInfoModel.PlateNumber;
			_param[2].Value=_T_AutoInfoModel.PlateColor;
			_param[3].Value=_T_AutoInfoModel.VIN;
			_param[4].Value=_T_AutoInfoModel.AutoBrand;
			_param[5].Value=_T_AutoInfoModel.AutoType;
			_param[6].Value=_T_AutoInfoModel.AutoNature;
			_param[7].Value=_T_AutoInfoModel.UnitName;
			_param[8].Value=_T_AutoInfoModel.LinkMan;
			_param[9].Value=_T_AutoInfoModel.Phone;
			_param[10].Value=_T_AutoInfoModel.EngineNumber;
			_param[11].Value=_T_AutoInfoModel.AutoColor;
			_param[12].Value=_T_AutoInfoModel.ChassisNumber;
			_param[13].Value=_T_AutoInfoModel.Remark;
			_param[14].Value=_T_AutoInfoModel.CardNumber;
			_param[15].Value=_T_AutoInfoModel.UnitID;
			_param[16].Value=_T_AutoInfoModel.BusinessInsuranceCompany;
			_param[17].Value=_T_AutoInfoModel.BusinessInsuranceNumber;
			_param[18].Value=_T_AutoInfoModel.BusinessInsuranceDate;
			_param[19].Value=_T_AutoInfoModel.EnforceInsuranceCompany;
			_param[20].Value=_T_AutoInfoModel.EnforceInsuranceNumber;
			_param[21].Value=_T_AutoInfoModel.EnforceInsuranceDate;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_AutoInfo更新一条记录。
		/// </summary>
		/// <param name="_T_AutoInfoModel">_T_AutoInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_AutoInfoEntity _T_AutoInfoModel)
		{
            string sqlStr="update T_AutoInfo set [PlateNumber]=@PlateNumber,[PlateColor]=@PlateColor,[VIN]=@VIN,[AutoBrand]=@AutoBrand,[AutoType]=@AutoType,[AutoNature]=@AutoNature,[UnitName]=@UnitName,[LinkMan]=@LinkMan,[Phone]=@Phone,[EngineNumber]=@EngineNumber,[AutoColor]=@AutoColor,[ChassisNumber]=@ChassisNumber,[Remark]=@Remark,[CardNumber]=@CardNumber,[UnitID]=@UnitID,[BusinessInsuranceCompany]=@BusinessInsuranceCompany,[BusinessInsuranceNumber]=@BusinessInsuranceNumber,[BusinessInsuranceDate]=@BusinessInsuranceDate,[EnforceInsuranceCompany]=@EnforceInsuranceCompany,[EnforceInsuranceNumber]=@EnforceInsuranceNumber,[EnforceInsuranceDate]=@EnforceInsuranceDate where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@PlateNumber",SqlDbType.VarChar),
				new SqlParameter("@PlateColor",SqlDbType.VarChar),
				new SqlParameter("@VIN",SqlDbType.VarChar),
				new SqlParameter("@AutoBrand",SqlDbType.VarChar),
				new SqlParameter("@AutoType",SqlDbType.VarChar),
				new SqlParameter("@AutoNature",SqlDbType.VarChar),
				new SqlParameter("@UnitName",SqlDbType.VarChar),
				new SqlParameter("@LinkMan",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@EngineNumber",SqlDbType.VarChar),
				new SqlParameter("@AutoColor",SqlDbType.VarChar),
				new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@CardNumber",SqlDbType.VarChar),
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@BusinessInsuranceCompany",SqlDbType.VarChar),
				new SqlParameter("@BusinessInsuranceNumber",SqlDbType.VarChar),
				new SqlParameter("@BusinessInsuranceDate",SqlDbType.DateTime),
				new SqlParameter("@EnforceInsuranceCompany",SqlDbType.VarChar),
				new SqlParameter("@EnforceInsuranceNumber",SqlDbType.VarChar),
				new SqlParameter("@EnforceInsuranceDate",SqlDbType.DateTime)
				};				
				_param[0].Value=_T_AutoInfoModel.ID;
				_param[1].Value=_T_AutoInfoModel.PlateNumber;
				_param[2].Value=_T_AutoInfoModel.PlateColor;
				_param[3].Value=_T_AutoInfoModel.VIN;
				_param[4].Value=_T_AutoInfoModel.AutoBrand;
				_param[5].Value=_T_AutoInfoModel.AutoType;
				_param[6].Value=_T_AutoInfoModel.AutoNature;
				_param[7].Value=_T_AutoInfoModel.UnitName;
				_param[8].Value=_T_AutoInfoModel.LinkMan;
				_param[9].Value=_T_AutoInfoModel.Phone;
				_param[10].Value=_T_AutoInfoModel.EngineNumber;
				_param[11].Value=_T_AutoInfoModel.AutoColor;
				_param[12].Value=_T_AutoInfoModel.ChassisNumber;
				_param[13].Value=_T_AutoInfoModel.Remark;
				_param[14].Value=_T_AutoInfoModel.CardNumber;
				_param[15].Value=_T_AutoInfoModel.UnitID;
				_param[16].Value=_T_AutoInfoModel.BusinessInsuranceCompany;
				_param[17].Value=_T_AutoInfoModel.BusinessInsuranceNumber;
				_param[18].Value=_T_AutoInfoModel.BusinessInsuranceDate;
				_param[19].Value=_T_AutoInfoModel.EnforceInsuranceCompany;
				_param[20].Value=_T_AutoInfoModel.EnforceInsuranceNumber;
				_param[21].Value=_T_AutoInfoModel.EnforceInsuranceDate;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_AutoInfo更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_AutoInfoModel">_T_AutoInfoModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_AutoInfoEntity _T_AutoInfoModel)
		{
            string sqlStr="update T_AutoInfo set [PlateNumber]=@PlateNumber,[PlateColor]=@PlateColor,[VIN]=@VIN,[AutoBrand]=@AutoBrand,[AutoType]=@AutoType,[AutoNature]=@AutoNature,[UnitName]=@UnitName,[LinkMan]=@LinkMan,[Phone]=@Phone,[EngineNumber]=@EngineNumber,[AutoColor]=@AutoColor,[ChassisNumber]=@ChassisNumber,[Remark]=@Remark,[CardNumber]=@CardNumber,[UnitID]=@UnitID,[BusinessInsuranceCompany]=@BusinessInsuranceCompany,[BusinessInsuranceNumber]=@BusinessInsuranceNumber,[BusinessInsuranceDate]=@BusinessInsuranceDate,[EnforceInsuranceCompany]=@EnforceInsuranceCompany,[EnforceInsuranceNumber]=@EnforceInsuranceNumber,[EnforceInsuranceDate]=@EnforceInsuranceDate where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@PlateNumber",SqlDbType.VarChar),
				new SqlParameter("@PlateColor",SqlDbType.VarChar),
				new SqlParameter("@VIN",SqlDbType.VarChar),
				new SqlParameter("@AutoBrand",SqlDbType.VarChar),
				new SqlParameter("@AutoType",SqlDbType.VarChar),
				new SqlParameter("@AutoNature",SqlDbType.VarChar),
				new SqlParameter("@UnitName",SqlDbType.VarChar),
				new SqlParameter("@LinkMan",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@EngineNumber",SqlDbType.VarChar),
				new SqlParameter("@AutoColor",SqlDbType.VarChar),
				new SqlParameter("@ChassisNumber",SqlDbType.VarChar),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@CardNumber",SqlDbType.VarChar),
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@BusinessInsuranceCompany",SqlDbType.VarChar),
				new SqlParameter("@BusinessInsuranceNumber",SqlDbType.VarChar),
				new SqlParameter("@BusinessInsuranceDate",SqlDbType.DateTime),
				new SqlParameter("@EnforceInsuranceCompany",SqlDbType.VarChar),
				new SqlParameter("@EnforceInsuranceNumber",SqlDbType.VarChar),
				new SqlParameter("@EnforceInsuranceDate",SqlDbType.DateTime)
				};				
				_param[0].Value=_T_AutoInfoModel.ID;
				_param[1].Value=_T_AutoInfoModel.PlateNumber;
				_param[2].Value=_T_AutoInfoModel.PlateColor;
				_param[3].Value=_T_AutoInfoModel.VIN;
				_param[4].Value=_T_AutoInfoModel.AutoBrand;
				_param[5].Value=_T_AutoInfoModel.AutoType;
				_param[6].Value=_T_AutoInfoModel.AutoNature;
				_param[7].Value=_T_AutoInfoModel.UnitName;
				_param[8].Value=_T_AutoInfoModel.LinkMan;
				_param[9].Value=_T_AutoInfoModel.Phone;
				_param[10].Value=_T_AutoInfoModel.EngineNumber;
				_param[11].Value=_T_AutoInfoModel.AutoColor;
				_param[12].Value=_T_AutoInfoModel.ChassisNumber;
				_param[13].Value=_T_AutoInfoModel.Remark;
				_param[14].Value=_T_AutoInfoModel.CardNumber;
				_param[15].Value=_T_AutoInfoModel.UnitID;
				_param[16].Value=_T_AutoInfoModel.BusinessInsuranceCompany;
				_param[17].Value=_T_AutoInfoModel.BusinessInsuranceNumber;
				_param[18].Value=_T_AutoInfoModel.BusinessInsuranceDate;
				_param[19].Value=_T_AutoInfoModel.EnforceInsuranceCompany;
				_param[20].Value=_T_AutoInfoModel.EnforceInsuranceNumber;
				_param[21].Value=_T_AutoInfoModel.EnforceInsuranceDate;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_AutoInfo中的一条记录
		/// </summary>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ID)
		{
			string sqlStr="delete from T_AutoInfo where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_AutoInfo中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ID)
		{
			string sqlStr="delete from T_AutoInfo where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_autoinfo 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_autoinfo 数据实体</returns>
		public T_AutoInfoEntity Populate_T_AutoInfoEntity_FromDr(DataRow row)
		{
			T_AutoInfoEntity Obj = new T_AutoInfoEntity();
			if(row!=null)
			{
				Obj.ID = (( row["ID"])==DBNull.Value)?0:Convert.ToInt32( row["ID"]);
				Obj.PlateNumber =  row["PlateNumber"].ToString();
				Obj.PlateColor =  row["PlateColor"].ToString();
				Obj.VIN =  row["VIN"].ToString();
				Obj.AutoBrand =  row["AutoBrand"].ToString();
				Obj.AutoType =  row["AutoType"].ToString();
				Obj.AutoNature =  row["AutoNature"].ToString();
				Obj.UnitName =  row["UnitName"].ToString();
				Obj.LinkMan =  row["LinkMan"].ToString();
				Obj.Phone =  row["Phone"].ToString();
				Obj.EngineNumber =  row["EngineNumber"].ToString();
				Obj.AutoColor =  row["AutoColor"].ToString();
				Obj.ChassisNumber =  row["ChassisNumber"].ToString();
				Obj.Remark =  row["Remark"].ToString();
				Obj.CardNumber =  row["CardNumber"].ToString();
				Obj.UnitID =  row["UnitID"].ToString();
				Obj.BusinessInsuranceCompany =  row["BusinessInsuranceCompany"].ToString();
				Obj.BusinessInsuranceNumber =  row["BusinessInsuranceNumber"].ToString();
				Obj.BusinessInsuranceDate = (( row["BusinessInsuranceDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["BusinessInsuranceDate"]);
				Obj.EnforceInsuranceCompany =  row["EnforceInsuranceCompany"].ToString();
				Obj.EnforceInsuranceNumber =  row["EnforceInsuranceNumber"].ToString();
				Obj.EnforceInsuranceDate = (( row["EnforceInsuranceDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["EnforceInsuranceDate"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  t_autoinfo 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_autoinfo 数据实体</returns>
		public T_AutoInfoEntity Populate_T_AutoInfoEntity_FromDr(IDataReader dr)
		{
			T_AutoInfoEntity Obj = new T_AutoInfoEntity();
			
				Obj.ID = (( dr["ID"])==DBNull.Value)?0:Convert.ToInt32( dr["ID"]);
				Obj.PlateNumber =  dr["PlateNumber"].ToString();
				Obj.PlateColor =  dr["PlateColor"].ToString();
				Obj.VIN =  dr["VIN"].ToString();
				Obj.AutoBrand =  dr["AutoBrand"].ToString();
				Obj.AutoType =  dr["AutoType"].ToString();
				Obj.AutoNature =  dr["AutoNature"].ToString();
				Obj.UnitName =  dr["UnitName"].ToString();
				Obj.LinkMan =  dr["LinkMan"].ToString();
				Obj.Phone =  dr["Phone"].ToString();
				Obj.EngineNumber =  dr["EngineNumber"].ToString();
				Obj.AutoColor =  dr["AutoColor"].ToString();
				Obj.ChassisNumber =  dr["ChassisNumber"].ToString();
				Obj.Remark =  dr["Remark"].ToString();
				Obj.CardNumber =  dr["CardNumber"].ToString();
				Obj.UnitID =  dr["UnitID"].ToString();
				Obj.BusinessInsuranceCompany =  dr["BusinessInsuranceCompany"].ToString();
				Obj.BusinessInsuranceNumber =  dr["BusinessInsuranceNumber"].ToString();
				Obj.BusinessInsuranceDate = (( dr["BusinessInsuranceDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["BusinessInsuranceDate"]);
				Obj.EnforceInsuranceCompany =  dr["EnforceInsuranceCompany"].ToString();
				Obj.EnforceInsuranceNumber =  dr["EnforceInsuranceNumber"].ToString();
				Obj.EnforceInsuranceDate = (( dr["EnforceInsuranceDate"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["EnforceInsuranceDate"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_AutoInfo对象
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>T_AutoInfo对象</returns>
		public T_AutoInfoEntity Get_T_AutoInfoEntity (int iD)
		{
			T_AutoInfoEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int)
			};
			_param[0].Value=iD;
			string sqlStr="select * from T_AutoInfo with(nolock) where ID=@ID";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_AutoInfoEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_AutoInfo所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_AutoInfoEntity> Get_T_AutoInfoAll()
		{
			IList< T_AutoInfoEntity> Obj=new List< T_AutoInfoEntity>();
			string sqlStr="select * from T_AutoInfo";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_AutoInfoEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>是/否</returns>
		public bool IsExistT_AutoInfo(int iD)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@iD",SqlDbType.Int)
                                  };
            _param[0].Value=iD;
            string sqlStr="select Count(*) from T_AutoInfo where ID=@iD";
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
