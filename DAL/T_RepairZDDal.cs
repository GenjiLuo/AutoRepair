// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairZD.cs
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
    /// 数据层实例化接口类 dbo.T_RepairZD.
    /// </summary>
    public partial class T_RepairZDDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_RepairZDDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_RepairZDModel">T_RepairZD实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_RepairZDEntity _T_RepairZDModel)
		{
			string sqlStr="insert into T_RepairZD([ID],[DocumentID],[ItemName],[Money],[Remark],[RepairMan]) values(@ID,@DocumentID,@ItemName,@Money,@Remark,@RepairMan) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@DocumentID",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@RepairMan",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairZDModel.ID;
			_param[1].Value=_T_RepairZDModel.DocumentID;
			_param[2].Value=_T_RepairZDModel.ItemName;
			_param[3].Value=_T_RepairZDModel.Money;
			_param[4].Value=_T_RepairZDModel.Remark;
			_param[5].Value=_T_RepairZDModel.RepairMan;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairZDModel">T_RepairZD实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_RepairZDEntity _T_RepairZDModel)
		{
			string sqlStr="insert into T_RepairZD([ID],[DocumentID],[ItemName],[Money],[Remark],[RepairMan]) values(@ID,@DocumentID,@ItemName,@Money,@Remark,@RepairMan) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@DocumentID",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@RepairMan",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairZDModel.ID;
			_param[1].Value=_T_RepairZDModel.DocumentID;
			_param[2].Value=_T_RepairZDModel.ItemName;
			_param[3].Value=_T_RepairZDModel.Money;
			_param[4].Value=_T_RepairZDModel.Remark;
			_param[5].Value=_T_RepairZDModel.RepairMan;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_RepairZD更新一条记录。
		/// </summary>
		/// <param name="_T_RepairZDModel">_T_RepairZDModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_RepairZDEntity _T_RepairZDModel)
		{
            string sqlStr="update T_RepairZD set [DocumentID]=@DocumentID,[ItemName]=@ItemName,[Money]=@Money,[Remark]=@Remark,[RepairMan]=@RepairMan where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@DocumentID",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@RepairMan",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairZDModel.ID;
				_param[1].Value=_T_RepairZDModel.DocumentID;
				_param[2].Value=_T_RepairZDModel.ItemName;
				_param[3].Value=_T_RepairZDModel.Money;
				_param[4].Value=_T_RepairZDModel.Remark;
				_param[5].Value=_T_RepairZDModel.RepairMan;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_RepairZD更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairZDModel">_T_RepairZDModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_RepairZDEntity _T_RepairZDModel)
		{
            string sqlStr="update T_RepairZD set [DocumentID]=@DocumentID,[ItemName]=@ItemName,[Money]=@Money,[Remark]=@Remark,[RepairMan]=@RepairMan where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@DocumentID",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@RepairMan",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairZDModel.ID;
				_param[1].Value=_T_RepairZDModel.DocumentID;
				_param[2].Value=_T_RepairZDModel.ItemName;
				_param[3].Value=_T_RepairZDModel.Money;
				_param[4].Value=_T_RepairZDModel.Remark;
				_param[5].Value=_T_RepairZDModel.RepairMan;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_RepairZD中的一条记录
		/// </summary>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ID)
		{
			string sqlStr="delete from T_RepairZD where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_RepairZD中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ID)
		{
			string sqlStr="delete from T_RepairZD where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_repairzd 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_repairzd 数据实体</returns>
		public T_RepairZDEntity Populate_T_RepairZDEntity_FromDr(DataRow row)
		{
			T_RepairZDEntity Obj = new T_RepairZDEntity();
			if(row!=null)
			{
				Obj.ID = (( row["ID"])==DBNull.Value)?0:Convert.ToInt32( row["ID"]);
				Obj.DocumentID = (( row["DocumentID"])==DBNull.Value)?0:Convert.ToInt32( row["DocumentID"]);
				Obj.ItemName =  row["ItemName"].ToString();
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
				Obj.Remark =  row["Remark"].ToString();
				Obj.RepairMan =  row["RepairMan"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  t_repairzd 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_repairzd 数据实体</returns>
		public T_RepairZDEntity Populate_T_RepairZDEntity_FromDr(IDataReader dr)
		{
			T_RepairZDEntity Obj = new T_RepairZDEntity();
			
				Obj.ID = (( dr["ID"])==DBNull.Value)?0:Convert.ToInt32( dr["ID"]);
				Obj.DocumentID = (( dr["DocumentID"])==DBNull.Value)?0:Convert.ToInt32( dr["DocumentID"]);
				Obj.ItemName =  dr["ItemName"].ToString();
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Remark =  dr["Remark"].ToString();
				Obj.RepairMan =  dr["RepairMan"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_RepairZD对象
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>T_RepairZD对象</returns>
		public T_RepairZDEntity Get_T_RepairZDEntity (int iD)
		{
			T_RepairZDEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int)
			};
			_param[0].Value=iD;
			string sqlStr="select * from T_RepairZD with(nolock) where ID=@ID";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_RepairZDEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_RepairZD所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_RepairZDEntity> Get_T_RepairZDAll()
		{
			IList< T_RepairZDEntity> Obj=new List< T_RepairZDEntity>();
			string sqlStr="select * from T_RepairZD";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_RepairZDEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>是/否</returns>
		public bool IsExistT_RepairZD(int iD)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@iD",SqlDbType.Int)
                                  };
            _param[0].Value=iD;
            string sqlStr="select Count(*) from T_RepairZD where ID=@iD";
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
