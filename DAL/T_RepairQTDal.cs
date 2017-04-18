// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairQT.cs
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
    /// 数据层实例化接口类 dbo.T_RepairQT.
    /// </summary>
    public partial class T_RepairQTDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_RepairQTDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_RepairQTModel">T_RepairQT实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_RepairQTEntity _T_RepairQTModel)
		{
			string sqlStr="insert into T_RepairQT([ID],[DocumentID],[ItemName],[Money],[Remark]) values(@ID,@DocumentID,@ItemName,@Money,@Remark) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@DocumentID",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairQTModel.ID;
			_param[1].Value=_T_RepairQTModel.DocumentID;
			_param[2].Value=_T_RepairQTModel.ItemName;
			_param[3].Value=_T_RepairQTModel.Money;
			_param[4].Value=_T_RepairQTModel.Remark;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairQTModel">T_RepairQT实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_RepairQTEntity _T_RepairQTModel)
		{
			string sqlStr="insert into T_RepairQT([ID],[DocumentID],[ItemName],[Money],[Remark]) values(@ID,@DocumentID,@ItemName,@Money,@Remark) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@DocumentID",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairQTModel.ID;
			_param[1].Value=_T_RepairQTModel.DocumentID;
			_param[2].Value=_T_RepairQTModel.ItemName;
			_param[3].Value=_T_RepairQTModel.Money;
			_param[4].Value=_T_RepairQTModel.Remark;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_RepairQT更新一条记录。
		/// </summary>
		/// <param name="_T_RepairQTModel">_T_RepairQTModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_RepairQTEntity _T_RepairQTModel)
		{
            string sqlStr="update T_RepairQT set [DocumentID]=@DocumentID,[ItemName]=@ItemName,[Money]=@Money,[Remark]=@Remark where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@DocumentID",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairQTModel.ID;
				_param[1].Value=_T_RepairQTModel.DocumentID;
				_param[2].Value=_T_RepairQTModel.ItemName;
				_param[3].Value=_T_RepairQTModel.Money;
				_param[4].Value=_T_RepairQTModel.Remark;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_RepairQT更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairQTModel">_T_RepairQTModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_RepairQTEntity _T_RepairQTModel)
		{
            string sqlStr="update T_RepairQT set [DocumentID]=@DocumentID,[ItemName]=@ItemName,[Money]=@Money,[Remark]=@Remark where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@DocumentID",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairQTModel.ID;
				_param[1].Value=_T_RepairQTModel.DocumentID;
				_param[2].Value=_T_RepairQTModel.ItemName;
				_param[3].Value=_T_RepairQTModel.Money;
				_param[4].Value=_T_RepairQTModel.Remark;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_RepairQT中的一条记录
		/// </summary>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ID)
		{
			string sqlStr="delete from T_RepairQT where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_RepairQT中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ID)
		{
			string sqlStr="delete from T_RepairQT where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_repairqt 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_repairqt 数据实体</returns>
		public T_RepairQTEntity Populate_T_RepairQTEntity_FromDr(DataRow row)
		{
			T_RepairQTEntity Obj = new T_RepairQTEntity();
			if(row!=null)
			{
				Obj.ID = (( row["ID"])==DBNull.Value)?0:Convert.ToInt32( row["ID"]);
				Obj.DocumentID = (( row["DocumentID"])==DBNull.Value)?0:Convert.ToInt32( row["DocumentID"]);
				Obj.ItemName =  row["ItemName"].ToString();
				Obj.Money = (( row["Money"])==DBNull.Value)?0:Convert.ToDecimal( row["Money"]);
				Obj.Remark =  row["Remark"].ToString();
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  t_repairqt 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_repairqt 数据实体</returns>
		public T_RepairQTEntity Populate_T_RepairQTEntity_FromDr(IDataReader dr)
		{
			T_RepairQTEntity Obj = new T_RepairQTEntity();
			
				Obj.ID = (( dr["ID"])==DBNull.Value)?0:Convert.ToInt32( dr["ID"]);
				Obj.DocumentID = (( dr["DocumentID"])==DBNull.Value)?0:Convert.ToInt32( dr["DocumentID"]);
				Obj.ItemName =  dr["ItemName"].ToString();
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Remark =  dr["Remark"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_RepairQT对象
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>T_RepairQT对象</returns>
		public T_RepairQTEntity Get_T_RepairQTEntity (int iD)
		{
			T_RepairQTEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int)
			};
			_param[0].Value=iD;
			string sqlStr="select * from T_RepairQT with(nolock) where ID=@ID";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_RepairQTEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_RepairQT所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_RepairQTEntity> Get_T_RepairQTAll()
		{
			IList< T_RepairQTEntity> Obj=new List< T_RepairQTEntity>();
			string sqlStr="select * from T_RepairQT";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_RepairQTEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>是/否</returns>
		public bool IsExistT_RepairQT(int iD)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@iD",SqlDbType.Int)
                                  };
            _param[0].Value=iD;
            string sqlStr="select Count(*) from T_RepairQT where ID=@iD";
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
