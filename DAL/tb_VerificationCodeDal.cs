// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_VerificationCode.cs
// 项目名称：买车网
// 创建时间：2016/8/29
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
    /// 数据层实例化接口类 dbo.tb_VerificationCode.
    /// </summary>
    public partial class tb_VerificationCodeDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_VerificationCodeDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_VerificationCodeModel">tb_VerificationCode实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_VerificationCodeEntity _tb_VerificationCodeModel)
		{
			string sqlStr="insert into tb_VerificationCode([Phone],[Code],[Addtime],[Outtime]) values(@Phone,@Code,@Addtime,@Outtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Code",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Outtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_VerificationCodeModel.Phone;
			_param[1].Value=_tb_VerificationCodeModel.Code;
			_param[2].Value=_tb_VerificationCodeModel.Addtime;
			_param[3].Value=_tb_VerificationCodeModel.Outtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_VerificationCodeModel">tb_VerificationCode实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_VerificationCodeEntity _tb_VerificationCodeModel)
		{
			string sqlStr="insert into tb_VerificationCode([Phone],[Code],[Addtime],[Outtime]) values(@Phone,@Code,@Addtime,@Outtime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Code",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Outtime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_VerificationCodeModel.Phone;
			_param[1].Value=_tb_VerificationCodeModel.Code;
			_param[2].Value=_tb_VerificationCodeModel.Addtime;
			_param[3].Value=_tb_VerificationCodeModel.Outtime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_VerificationCode更新一条记录。
		/// </summary>
		/// <param name="_tb_VerificationCodeModel">_tb_VerificationCodeModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_VerificationCodeEntity _tb_VerificationCodeModel)
		{
            string sqlStr="update tb_VerificationCode set [Phone]=@Phone,[Code]=@Code,[Addtime]=@Addtime,[Outtime]=@Outtime where VerificationId=@VerificationId";
			SqlParameter[] _param={				
				new SqlParameter("@VerificationId",SqlDbType.Int),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Code",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Outtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_VerificationCodeModel.VerificationId;
				_param[1].Value=_tb_VerificationCodeModel.Phone;
				_param[2].Value=_tb_VerificationCodeModel.Code;
				_param[3].Value=_tb_VerificationCodeModel.Addtime;
				_param[4].Value=_tb_VerificationCodeModel.Outtime;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_VerificationCode更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_VerificationCodeModel">_tb_VerificationCodeModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_VerificationCodeEntity _tb_VerificationCodeModel)
		{
            string sqlStr="update tb_VerificationCode set [Phone]=@Phone,[Code]=@Code,[Addtime]=@Addtime,[Outtime]=@Outtime where VerificationId=@VerificationId";
			SqlParameter[] _param={				
				new SqlParameter("@VerificationId",SqlDbType.Int),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Code",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Outtime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_VerificationCodeModel.VerificationId;
				_param[1].Value=_tb_VerificationCodeModel.Phone;
				_param[2].Value=_tb_VerificationCodeModel.Code;
				_param[3].Value=_tb_VerificationCodeModel.Addtime;
				_param[4].Value=_tb_VerificationCodeModel.Outtime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_VerificationCode中的一条记录
		/// </summary>
	    /// <param name="VerificationId">verificationId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int VerificationId)
		{
			string sqlStr="delete from tb_VerificationCode where [VerificationId]=@VerificationId";
			SqlParameter[] _param={			
			new SqlParameter("@VerificationId",SqlDbType.Int),
			
			};			
			_param[0].Value=VerificationId;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_VerificationCode中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="VerificationId">verificationId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int VerificationId)
		{
			string sqlStr="delete from tb_VerificationCode where [VerificationId]=@VerificationId";
			SqlParameter[] _param={			
			new SqlParameter("@VerificationId",SqlDbType.Int),
			
			};			
			_param[0].Value=VerificationId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_verificationcode 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_verificationcode 数据实体</returns>
		public tb_VerificationCodeEntity Populate_tb_VerificationCodeEntity_FromDr(DataRow row)
		{
			tb_VerificationCodeEntity Obj = new tb_VerificationCodeEntity();
			if(row!=null)
			{
				Obj.VerificationId = (( row["VerificationId"])==DBNull.Value)?0:Convert.ToInt32( row["VerificationId"]);
				Obj.Phone =  row["Phone"].ToString();
				Obj.Code =  row["Code"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Outtime = (( row["Outtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Outtime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_verificationcode 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_verificationcode 数据实体</returns>
		public tb_VerificationCodeEntity Populate_tb_VerificationCodeEntity_FromDr(IDataReader dr)
		{
			tb_VerificationCodeEntity Obj = new tb_VerificationCodeEntity();
			
				Obj.VerificationId = (( dr["VerificationId"])==DBNull.Value)?0:Convert.ToInt32( dr["VerificationId"]);
				Obj.Phone =  dr["Phone"].ToString();
				Obj.Code =  dr["Code"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Outtime = (( dr["Outtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Outtime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_VerificationCode对象
		/// </summary>
		/// <param name="verificationId">verificationId</param>
		/// <returns>tb_VerificationCode对象</returns>
		public tb_VerificationCodeEntity Get_tb_VerificationCodeEntity (int verificationId)
		{
			tb_VerificationCodeEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@VerificationId",SqlDbType.Int)
			};
			_param[0].Value=verificationId;
			string sqlStr="select * from tb_VerificationCode with(nolock) where VerificationId=@VerificationId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_VerificationCodeEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_VerificationCode所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_VerificationCodeEntity> Get_tb_VerificationCodeAll()
		{
			IList< tb_VerificationCodeEntity> Obj=new List< tb_VerificationCodeEntity>();
			string sqlStr="select * from tb_VerificationCode";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_VerificationCodeEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="verificationId">verificationId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_VerificationCode(int verificationId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@verificationId",SqlDbType.Int)
                                  };
            _param[0].Value=verificationId;
            string sqlStr="select Count(*) from tb_VerificationCode where VerificationId=@verificationId";
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
