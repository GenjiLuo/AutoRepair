// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Department.cs
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
    /// 数据层实例化接口类 dbo.tb_Department.
    /// </summary>
    public partial class tb_DepartmentDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_DepartmentDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_DepartmentModel">tb_Department实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_DepartmentEntity _tb_DepartmentModel)
		{
            string sqlStr = "insert into tb_Department([Name],[Address],[LocationId],[Contacts],[Phone],[UserName],[UserPwd],[Addtime],[Updatetime],[Status],[PermissionNum]) values(@Name,@Address,@LocationId,@Contacts,@Phone,@UserName,@UserPwd,@Addtime,@Updatetime,@Status,@PermissionNum) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@Contacts",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@UserName",SqlDbType.VarChar),
			new SqlParameter("@UserPwd",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@Status",SqlDbType.Int),
            new SqlParameter("@PermissionNum",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_DepartmentModel.Name;
			_param[1].Value=_tb_DepartmentModel.Address;
			_param[2].Value=_tb_DepartmentModel.LocationId;
			_param[3].Value=_tb_DepartmentModel.Contacts;
			_param[4].Value=_tb_DepartmentModel.Phone;
			_param[5].Value=_tb_DepartmentModel.UserName;
			_param[6].Value=_tb_DepartmentModel.UserPwd;
			_param[7].Value=_tb_DepartmentModel.Addtime;
			_param[8].Value=_tb_DepartmentModel.Updatetime;
            _param[9].Value = _tb_DepartmentModel.Status;
            _param[10].Value = _tb_DepartmentModel.PermissionNum;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_DepartmentModel">tb_Department实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_DepartmentEntity _tb_DepartmentModel)
		{
            string sqlStr = "insert into tb_Department([Name],[Address],[LocationId],[Contacts],[Phone],[UserName],[UserPwd],[Addtime],[Updatetime],[Status],[PermissionNum]) values(@Name,@Address,@LocationId,@Contacts,@Phone,@UserName,@UserPwd,@Addtime,@Updatetime,@Status,@PermissionNum) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@Name",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@LocationId",SqlDbType.Int),
			new SqlParameter("@Contacts",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@UserName",SqlDbType.VarChar),
			new SqlParameter("@UserPwd",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Updatetime",SqlDbType.DateTime),
            new SqlParameter("@Status",SqlDbType.Int),
            new SqlParameter("@PermissionNum",SqlDbType.VarChar)
			};
            _param[0].Value = _tb_DepartmentModel.Name;
            _param[1].Value = _tb_DepartmentModel.Address;
            _param[2].Value = _tb_DepartmentModel.LocationId;
            _param[3].Value = _tb_DepartmentModel.Contacts;
            _param[4].Value = _tb_DepartmentModel.Phone;
            _param[5].Value = _tb_DepartmentModel.UserName;
            _param[6].Value = _tb_DepartmentModel.UserPwd;
            _param[7].Value = _tb_DepartmentModel.Addtime;
            _param[8].Value = _tb_DepartmentModel.Updatetime;
            _param[9].Value = _tb_DepartmentModel.Status;
            _param[10].Value = _tb_DepartmentModel.PermissionNum;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Department更新一条记录。
		/// </summary>
		/// <param name="_tb_DepartmentModel">_tb_DepartmentModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_DepartmentEntity _tb_DepartmentModel)
		{
            string sqlStr = "update tb_Department set [Name]=@Name,[Address]=@Address,[LocationId]=@LocationId,[Contacts]=@Contacts,[Phone]=@Phone,[UserName]=@UserName,[UserPwd]=@UserPwd,[Addtime]=@Addtime,[Updatetime]=@Updatetime ,[Status]=@Status,[PermissionNum]=@PermissionNum where DepartmentId=@DepartmentId";
			SqlParameter[] _param={				
				new SqlParameter("@DepartmentId",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@Contacts",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@UserName",SqlDbType.VarChar),
				new SqlParameter("@UserPwd",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@Status",SqlDbType.Int),
                new SqlParameter("@PermissionNum",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_DepartmentModel.DepartmentId;
				_param[1].Value=_tb_DepartmentModel.Name;
				_param[2].Value=_tb_DepartmentModel.Address;
				_param[3].Value=_tb_DepartmentModel.LocationId;
				_param[4].Value=_tb_DepartmentModel.Contacts;
				_param[5].Value=_tb_DepartmentModel.Phone;
				_param[6].Value=_tb_DepartmentModel.UserName;
				_param[7].Value=_tb_DepartmentModel.UserPwd;
				_param[8].Value=_tb_DepartmentModel.Addtime;
				_param[9].Value=_tb_DepartmentModel.Updatetime;
                _param[10].Value = _tb_DepartmentModel.Status;
                _param[11].Value = _tb_DepartmentModel.PermissionNum;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Department更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_DepartmentModel">_tb_DepartmentModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_DepartmentEntity _tb_DepartmentModel)
		{
            string sqlStr = "update tb_Department set [Name]=@Name,[Address]=@Address,[LocationId]=@LocationId,[Contacts]=@Contacts,[Phone]=@Phone,[UserName]=@UserName,[UserPwd]=@UserPwd,[Addtime]=@Addtime,[Updatetime]=@Updatetime ,[Status]=@Status,[PermissionNum]=@PermissionNum where DepartmentId=@DepartmentId";
            SqlParameter[] _param ={				
				new SqlParameter("@DepartmentId",SqlDbType.Int),
				new SqlParameter("@Name",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@LocationId",SqlDbType.Int),
				new SqlParameter("@Contacts",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@UserName",SqlDbType.VarChar),
				new SqlParameter("@UserPwd",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Updatetime",SqlDbType.DateTime),
                new SqlParameter("@Status",SqlDbType.Int),
                new SqlParameter("@PermissionNum",SqlDbType.VarChar)
				};
            _param[0].Value = _tb_DepartmentModel.DepartmentId;
            _param[1].Value = _tb_DepartmentModel.Name;
            _param[2].Value = _tb_DepartmentModel.Address;
            _param[3].Value = _tb_DepartmentModel.LocationId;
            _param[4].Value = _tb_DepartmentModel.Contacts;
            _param[5].Value = _tb_DepartmentModel.Phone;
            _param[6].Value = _tb_DepartmentModel.UserName;
            _param[7].Value = _tb_DepartmentModel.UserPwd;
            _param[8].Value = _tb_DepartmentModel.Addtime;
            _param[9].Value = _tb_DepartmentModel.Updatetime;
            _param[10].Value = _tb_DepartmentModel.Status;
            _param[11].Value = _tb_DepartmentModel.PermissionNum;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Department中的一条记录
		/// </summary>
	    /// <param name="DepartmentId">departmentId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int DepartmentId)
		{
			string sqlStr="delete from tb_Department where [DepartmentId]=@DepartmentId";
			SqlParameter[] _param={			
			new SqlParameter("@DepartmentId",SqlDbType.Int),
			
			};			
			_param[0].Value=DepartmentId;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Department中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="DepartmentId">departmentId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int DepartmentId)
		{
			string sqlStr="delete from tb_Department where [DepartmentId]=@DepartmentId";
			SqlParameter[] _param={			
			new SqlParameter("@DepartmentId",SqlDbType.Int),
			
			};			
			_param[0].Value=DepartmentId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_department 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_department 数据实体</returns>
		public tb_DepartmentEntity Populate_tb_DepartmentEntity_FromDr(DataRow row)
		{
			tb_DepartmentEntity Obj = new tb_DepartmentEntity();
			if(row!=null)
			{
				Obj.DepartmentId = (( row["DepartmentId"])==DBNull.Value)?0:Convert.ToInt32( row["DepartmentId"]);
				Obj.Name =  row["Name"].ToString();
				Obj.Address =  row["Address"].ToString();
				Obj.LocationId = (( row["LocationId"])==DBNull.Value)?0:Convert.ToInt32( row["LocationId"]);
				Obj.Contacts =  row["Contacts"].ToString();
				Obj.Phone =  row["Phone"].ToString();
				Obj.UserName =  row["UserName"].ToString();
				Obj.UserPwd =  row["UserPwd"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Updatetime = (( row["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Updatetime"]);
                Obj.Status = ((row["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(row["Status"]);
                Obj.PermissionNum = row["PermissionNum"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_department 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_department 数据实体</returns>
		public tb_DepartmentEntity Populate_tb_DepartmentEntity_FromDr(IDataReader dr)
		{
			tb_DepartmentEntity Obj = new tb_DepartmentEntity();
			
				Obj.DepartmentId = (( dr["DepartmentId"])==DBNull.Value)?0:Convert.ToInt32( dr["DepartmentId"]);
				Obj.Name =  dr["Name"].ToString();
				Obj.Address =  dr["Address"].ToString();
				Obj.LocationId = (( dr["LocationId"])==DBNull.Value)?0:Convert.ToInt32( dr["LocationId"]);
				Obj.Contacts =  dr["Contacts"].ToString();
				Obj.Phone =  dr["Phone"].ToString();
				Obj.UserName =  dr["UserName"].ToString();
				Obj.UserPwd =  dr["UserPwd"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Updatetime = (( dr["Updatetime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Updatetime"]);
                Obj.Status = ((dr["Status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["Status"]);
                Obj.PermissionNum = dr["PermissionNum"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Department对象
		/// </summary>
		/// <param name="departmentId">departmentId</param>
		/// <returns>tb_Department对象</returns>
		public tb_DepartmentEntity Get_tb_DepartmentEntity (int departmentId)
		{
			tb_DepartmentEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@DepartmentId",SqlDbType.Int)
			};
			_param[0].Value=departmentId;
			string sqlStr="select * from tb_Department with(nolock) where DepartmentId=@DepartmentId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_DepartmentEntity_FromDr(dr);
				}
			}
			return _obj;
		}
	
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="departmentId">departmentId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Department(int departmentId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@departmentId",SqlDbType.Int)
                                  };
            _param[0].Value=departmentId;
            string sqlStr="select Count(*) from tb_Department where DepartmentId=@departmentId";
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
