// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
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
    /// 数据层实例化接口类 dbo.tb_Users.
    /// </summary>
    public partial class tb_UsersDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_UsersDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_UsersModel">tb_Users实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_UsersEntity _tb_UsersModel)
		{
            string sqlStr = "insert into tb_Users([Phone],[Pwd],[RealName],[Mail],[LocationId],[Addtime],[IdCard],[IdentityType],[OpenID]) values(@Phone,@Pwd,@RealName,@Mail,@LocationId,@Addtime,@IdCard,@IdentityType,@OpenID) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Pwd",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Mail",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
            new SqlParameter("@IdCard",SqlDbType.VarChar),
            new SqlParameter("@IdentityType",SqlDbType.Int),
            new SqlParameter("@OpenID",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_UsersModel.Phone;
			_param[1].Value=_tb_UsersModel.Pwd;
			_param[2].Value=_tb_UsersModel.RealName;
			_param[3].Value=_tb_UsersModel.Mail;
			_param[4].Value=_tb_UsersModel.LocationId;
			_param[5].Value=_tb_UsersModel.Addtime;
            _param[6].Value = _tb_UsersModel.IdCard;
            _param[7].Value = _tb_UsersModel.IdentityType;
            _param[8].Value = _tb_UsersModel.OpenID;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_UsersModel">tb_Users实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_UsersEntity _tb_UsersModel)
		{
            string sqlStr = "insert into tb_Users([Phone],[Pwd],[RealName],[Mail],[LocationId],[Addtime],[IdCard],[IdentityType],[OpenID]) values(@Phone,@Pwd,@RealName,@Mail,@LocationId,@Addtime,@IdCard,@IdentityType,@OpenID) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Pwd",SqlDbType.VarChar),
			new SqlParameter("@RealName",SqlDbType.VarChar),
			new SqlParameter("@Mail",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
            new SqlParameter("@IdCard",SqlDbType.VarChar),
            new SqlParameter("@IdentityType",SqlDbType.Int),
            new SqlParameter("@OpenID",SqlDbType.VarChar)
			};
            _param[0].Value = _tb_UsersModel.Phone;
            _param[1].Value = _tb_UsersModel.Pwd;
            _param[2].Value = _tb_UsersModel.RealName;
            _param[3].Value = _tb_UsersModel.Mail;
            _param[4].Value = _tb_UsersModel.LocationId;
            _param[5].Value = _tb_UsersModel.Addtime;
            _param[6].Value = _tb_UsersModel.IdCard;
            _param[7].Value = _tb_UsersModel.IdentityType;
            _param[8].Value = _tb_UsersModel.OpenID;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Users更新一条记录。
		/// </summary>
		/// <param name="_tb_UsersModel">_tb_UsersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_UsersEntity _tb_UsersModel)
		{
            string sqlStr = "update tb_Users set [Phone]=@Phone,[Pwd]=@Pwd,[RealName]=@RealName,[Mail]=@Mail,[LocationId]=@LocationId,[Addtime]=@Addtime,[IdCard]=@IdCard,[IdentityType]=@IdentityType,OpenID=@OpenID where UserId=@UserId";
			SqlParameter[] _param={				
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Pwd",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Mail",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
                new SqlParameter("@IdCard",SqlDbType.VarChar),
                new SqlParameter("@IdentityType",SqlDbType.Int),
                new SqlParameter("@OpenID",SqlDbType.VarChar),
				};				
				_param[0].Value=_tb_UsersModel.UserId;
				_param[1].Value=_tb_UsersModel.Phone;
				_param[2].Value=_tb_UsersModel.Pwd;
				_param[3].Value=_tb_UsersModel.RealName;
				_param[4].Value=_tb_UsersModel.Mail;
				_param[5].Value=_tb_UsersModel.LocationId;
				_param[6].Value=_tb_UsersModel.Addtime;
                _param[7].Value = _tb_UsersModel.IdCard;
                _param[8].Value = _tb_UsersModel.IdentityType;
                _param[9].Value = _tb_UsersModel.OpenID;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Users更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_UsersModel">_tb_UsersModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_UsersEntity _tb_UsersModel)
		{
            string sqlStr = "update tb_Users set [Phone]=@Phone,[Pwd]=@Pwd,[RealName]=@RealName,[Mail]=@Mail,[LocationId]=@LocationId,[Addtime]=@Addtime,[IdCard]=@IdCard,[IdentityType]=@IdentityType,OpenID=@OpenID where UserId=@UserId";
            SqlParameter[] _param ={				
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Pwd",SqlDbType.VarChar),
				new SqlParameter("@RealName",SqlDbType.VarChar),
				new SqlParameter("@Mail",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
                new SqlParameter("@IdCard",SqlDbType.VarChar),
                new SqlParameter("@IdentityType",SqlDbType.Int),
                new SqlParameter("@OpenID",SqlDbType.VarChar),
				};
            _param[0].Value = _tb_UsersModel.UserId;
            _param[1].Value = _tb_UsersModel.Phone;
            _param[2].Value = _tb_UsersModel.Pwd;
            _param[3].Value = _tb_UsersModel.RealName;
            _param[4].Value = _tb_UsersModel.Mail;
            _param[5].Value = _tb_UsersModel.LocationId;
            _param[6].Value = _tb_UsersModel.Addtime;
            _param[7].Value = _tb_UsersModel.IdCard;
            _param[8].Value = _tb_UsersModel.IdentityType;
            _param[9].Value = _tb_UsersModel.OpenID;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Users中的一条记录
		/// </summary>
	    /// <param name="UserId">userId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int UserId)
		{
			string sqlStr="delete from tb_Users where [UserId]=@UserId";
			SqlParameter[] _param={			
			new SqlParameter("@UserId",SqlDbType.Int),
			
			};			
			_param[0].Value=UserId;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Users中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="UserId">userId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int UserId)
		{
			string sqlStr="delete from tb_Users where [UserId]=@UserId";
			SqlParameter[] _param={			
			new SqlParameter("@UserId",SqlDbType.Int),
			
			};			
			_param[0].Value=UserId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_users 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_users 数据实体</returns>
		public tb_UsersEntity Populate_tb_UsersEntity_FromDr(DataRow row)
		{
			tb_UsersEntity Obj = new tb_UsersEntity();
			if(row!=null)
			{
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.Phone =  row["Phone"].ToString();
				Obj.Pwd =  row["Pwd"].ToString();
				Obj.RealName =  row["RealName"].ToString();
				Obj.Mail =  row["Mail"].ToString();
				Obj.LocationId = (( row["LocationId"])==DBNull.Value)?0:Convert.ToInt32(row["LocationId"]);
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
                Obj.IdCard = row["IdCard"].ToString();
                Obj.IdentityType = ((row["IdentityType"])==DBNull.Value)?0:Convert.ToInt32(row["IdentityType"]);
                Obj.OpenID = row["OpenID"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_users 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_users 数据实体</returns>
		public tb_UsersEntity Populate_tb_UsersEntity_FromDr(IDataReader dr)
		{
			tb_UsersEntity Obj = new tb_UsersEntity();
			
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.Phone =  dr["Phone"].ToString();
				Obj.Pwd =  dr["Pwd"].ToString();
				Obj.RealName =  dr["RealName"].ToString();
				Obj.Mail =  dr["Mail"].ToString();
				Obj.LocationId = (( dr["LocationId"])==DBNull.Value)?0:Convert.ToInt32( dr["LocationId"]);
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
                Obj.IdCard = dr["IdCard"].ToString();
                Obj.IdentityType = ((dr["IdentityType"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["IdentityType"]);
                Obj.OpenID = dr["OpenID"].ToString();
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Users对象
		/// </summary>
		/// <param name="userId">userId</param>
		/// <returns>tb_Users对象</returns>
		public tb_UsersEntity Get_tb_UsersEntity (int userId)
		{
			tb_UsersEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
			_param[0].Value=userId;
			string sqlStr="select * from tb_Users with(nolock) where UserId=@UserId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_UsersEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Users所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_UsersEntity> Get_tb_UsersAll()
		{
			IList< tb_UsersEntity> Obj=new List< tb_UsersEntity>();
			string sqlStr="select * from tb_Users";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_UsersEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Users(int userId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@userId",SqlDbType.Int)
                                  };
            _param[0].Value=userId;
            string sqlStr="select Count(*) from tb_Users where UserId=@userId";
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
