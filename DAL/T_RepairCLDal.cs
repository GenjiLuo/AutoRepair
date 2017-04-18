// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairCL.cs
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
    /// 数据层实例化接口类 dbo.T_RepairCL.
    /// </summary>
    public partial class T_RepairCLDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public T_RepairCLDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_T_RepairCLModel">T_RepairCL实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(T_RepairCLEntity _T_RepairCLModel)
		{
			string sqlStr="insert into T_RepairCL([ID],[DocumentID],[ItemName],[AutoBrand],[ItemUnit],[Amount],[Price],[Money],[Remark]) values(@ID,@DocumentID,@ItemName,@AutoBrand,@ItemUnit,@Amount,@Price,@Money,@Remark) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@DocumentID",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@AutoBrand",SqlDbType.VarChar),
			new SqlParameter("@ItemUnit",SqlDbType.VarChar),
			new SqlParameter("@Amount",SqlDbType.Decimal),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairCLModel.ID;
			_param[1].Value=_T_RepairCLModel.DocumentID;
			_param[2].Value=_T_RepairCLModel.ItemName;
			_param[3].Value=_T_RepairCLModel.AutoBrand;
			_param[4].Value=_T_RepairCLModel.ItemUnit;
			_param[5].Value=_T_RepairCLModel.Amount;
			_param[6].Value=_T_RepairCLModel.Price;
			_param[7].Value=_T_RepairCLModel.Money;
			_param[8].Value=_T_RepairCLModel.Remark;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairCLModel">T_RepairCL实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,T_RepairCLEntity _T_RepairCLModel)
		{
			string sqlStr="insert into T_RepairCL([ID],[DocumentID],[ItemName],[AutoBrand],[ItemUnit],[Amount],[Price],[Money],[Remark]) values(@ID,@DocumentID,@ItemName,@AutoBrand,@ItemUnit,@Amount,@Price,@Money,@Remark) select @ID";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int),
			new SqlParameter("@DocumentID",SqlDbType.Int),
			new SqlParameter("@ItemName",SqlDbType.VarChar),
			new SqlParameter("@AutoBrand",SqlDbType.VarChar),
			new SqlParameter("@ItemUnit",SqlDbType.VarChar),
			new SqlParameter("@Amount",SqlDbType.Decimal),
			new SqlParameter("@Price",SqlDbType.Decimal),
			new SqlParameter("@Money",SqlDbType.Decimal),
			new SqlParameter("@Remark",SqlDbType.VarChar)
			};			
			_param[0].Value=_T_RepairCLModel.ID;
			_param[1].Value=_T_RepairCLModel.DocumentID;
			_param[2].Value=_T_RepairCLModel.ItemName;
			_param[3].Value=_T_RepairCLModel.AutoBrand;
			_param[4].Value=_T_RepairCLModel.ItemUnit;
			_param[5].Value=_T_RepairCLModel.Amount;
			_param[6].Value=_T_RepairCLModel.Price;
			_param[7].Value=_T_RepairCLModel.Money;
			_param[8].Value=_T_RepairCLModel.Remark;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表T_RepairCL更新一条记录。
		/// </summary>
		/// <param name="_T_RepairCLModel">_T_RepairCLModel</param>
		/// <returns>影响的行数</returns>
		public int Update(T_RepairCLEntity _T_RepairCLModel)
		{
            string sqlStr="update T_RepairCL set [DocumentID]=@DocumentID,[ItemName]=@ItemName,[AutoBrand]=@AutoBrand,[ItemUnit]=@ItemUnit,[Amount]=@Amount,[Price]=@Price,[Money]=@Money,[Remark]=@Remark where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@DocumentID",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@AutoBrand",SqlDbType.VarChar),
				new SqlParameter("@ItemUnit",SqlDbType.VarChar),
				new SqlParameter("@Amount",SqlDbType.Decimal),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairCLModel.ID;
				_param[1].Value=_T_RepairCLModel.DocumentID;
				_param[2].Value=_T_RepairCLModel.ItemName;
				_param[3].Value=_T_RepairCLModel.AutoBrand;
				_param[4].Value=_T_RepairCLModel.ItemUnit;
				_param[5].Value=_T_RepairCLModel.Amount;
				_param[6].Value=_T_RepairCLModel.Price;
				_param[7].Value=_T_RepairCLModel.Money;
				_param[8].Value=_T_RepairCLModel.Remark;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表T_RepairCL更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_T_RepairCLModel">_T_RepairCLModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,T_RepairCLEntity _T_RepairCLModel)
		{
            string sqlStr="update T_RepairCL set [DocumentID]=@DocumentID,[ItemName]=@ItemName,[AutoBrand]=@AutoBrand,[ItemUnit]=@ItemUnit,[Amount]=@Amount,[Price]=@Price,[Money]=@Money,[Remark]=@Remark where ID=@ID";
			SqlParameter[] _param={				
				new SqlParameter("@ID",SqlDbType.Int),
				new SqlParameter("@DocumentID",SqlDbType.Int),
				new SqlParameter("@ItemName",SqlDbType.VarChar),
				new SqlParameter("@AutoBrand",SqlDbType.VarChar),
				new SqlParameter("@ItemUnit",SqlDbType.VarChar),
				new SqlParameter("@Amount",SqlDbType.Decimal),
				new SqlParameter("@Price",SqlDbType.Decimal),
				new SqlParameter("@Money",SqlDbType.Decimal),
				new SqlParameter("@Remark",SqlDbType.VarChar)
				};				
				_param[0].Value=_T_RepairCLModel.ID;
				_param[1].Value=_T_RepairCLModel.DocumentID;
				_param[2].Value=_T_RepairCLModel.ItemName;
				_param[3].Value=_T_RepairCLModel.AutoBrand;
				_param[4].Value=_T_RepairCLModel.ItemUnit;
				_param[5].Value=_T_RepairCLModel.Amount;
				_param[6].Value=_T_RepairCLModel.Price;
				_param[7].Value=_T_RepairCLModel.Money;
				_param[8].Value=_T_RepairCLModel.Remark;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表T_RepairCL中的一条记录
		/// </summary>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(int ID)
		{
			string sqlStr="delete from T_RepairCL where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表T_RepairCL中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="ID">iD</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int ID)
		{
			string sqlStr="delete from T_RepairCL where [ID]=@ID";
			SqlParameter[] _param={			
			new SqlParameter("@ID",SqlDbType.Int),
			
			};			
			_param[0].Value=ID;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  t_repaircl 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>t_repaircl 数据实体</returns>
		public T_RepairCLEntity Populate_T_RepairCLEntity_FromDr(DataRow row)
		{
			T_RepairCLEntity Obj = new T_RepairCLEntity();
			if(row!=null)
			{
				Obj.ID = (( row["ID"])==DBNull.Value)?0:Convert.ToInt32( row["ID"]);
				Obj.DocumentID = (( row["DocumentID"])==DBNull.Value)?0:Convert.ToInt32( row["DocumentID"]);
				Obj.ItemName =  row["ItemName"].ToString();
				Obj.AutoBrand =  row["AutoBrand"].ToString();
				Obj.ItemUnit =  row["ItemUnit"].ToString();
				Obj.Amount = (( row["Amount"])==DBNull.Value)?0:Convert.ToDecimal( row["Amount"]);
				Obj.Price = (( row["Price"])==DBNull.Value)?0:Convert.ToDecimal( row["Price"]);
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
		/// 得到  t_repaircl 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>t_repaircl 数据实体</returns>
		public T_RepairCLEntity Populate_T_RepairCLEntity_FromDr(IDataReader dr)
		{
			T_RepairCLEntity Obj = new T_RepairCLEntity();
			
				Obj.ID = (( dr["ID"])==DBNull.Value)?0:Convert.ToInt32( dr["ID"]);
				Obj.DocumentID = (( dr["DocumentID"])==DBNull.Value)?0:Convert.ToInt32( dr["DocumentID"]);
				Obj.ItemName =  dr["ItemName"].ToString();
				Obj.AutoBrand =  dr["AutoBrand"].ToString();
				Obj.ItemUnit =  dr["ItemUnit"].ToString();
				Obj.Amount = (( dr["Amount"])==DBNull.Value)?0:Convert.ToDecimal( dr["Amount"]);
				Obj.Price = (( dr["Price"])==DBNull.Value)?0:Convert.ToDecimal( dr["Price"]);
				Obj.Money = (( dr["Money"])==DBNull.Value)?0:Convert.ToDecimal( dr["Money"]);
				Obj.Remark =  dr["Remark"].ToString();
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个T_RepairCL对象
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>T_RepairCL对象</returns>
		public T_RepairCLEntity Get_T_RepairCLEntity (int iD)
		{
			T_RepairCLEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@ID",SqlDbType.Int)
			};
			_param[0].Value=iD;
			string sqlStr="select * from T_RepairCL with(nolock) where ID=@ID";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_T_RepairCLEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表T_RepairCL所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< T_RepairCLEntity> Get_T_RepairCLAll()
		{
			IList< T_RepairCLEntity> Obj=new List< T_RepairCLEntity>();
			string sqlStr="select * from T_RepairCL";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_T_RepairCLEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>是/否</returns>
		public bool IsExistT_RepairCL(int iD)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@iD",SqlDbType.Int)
                                  };
            _param[0].Value=iD;
            string sqlStr="select Count(*) from T_RepairCL where ID=@iD";
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
