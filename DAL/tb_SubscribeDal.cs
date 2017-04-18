// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Subscribe.cs
// 项目名称：买车网
// 创建时间：2016/9/9
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
    /// 数据层实例化接口类 dbo.tb_Subscribe.
    /// </summary>
    public partial class tb_SubscribeDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_SubscribeDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_SubscribeModel">tb_Subscribe实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_SubscribeEntity _tb_SubscribeModel)
		{
			string sqlStr="insert into tb_Subscribe([UserId],[UnitId],[OrderTime],[OrderContent],[Addtime],[Status],Phone) values(@UserId,@UnitId,@OrderTime,@OrderContent,@Addtime,@Status,@Phone) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@UnitId",SqlDbType.VarChar),
			new SqlParameter("@OrderTime",SqlDbType.DateTime),
			new SqlParameter("@OrderContent",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int),
            new SqlParameter("@Phone",SqlDbType.VarChar)
			};			
			_param[0].Value=_tb_SubscribeModel.UserId;
			_param[1].Value=_tb_SubscribeModel.UnitId;
			_param[2].Value=_tb_SubscribeModel.OrderTime;
			_param[3].Value=_tb_SubscribeModel.OrderContent;
			_param[4].Value=_tb_SubscribeModel.Addtime;
			_param[5].Value=_tb_SubscribeModel.Status;
            _param[6].Value = _tb_SubscribeModel.Phone;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_SubscribeModel">tb_Subscribe实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_SubscribeEntity _tb_SubscribeModel)
		{
            string sqlStr = "insert into tb_Subscribe([UserId],[UnitId],[OrderTime],[OrderContent],[Addtime],[Status],Phone) values(@UserId,@UnitId,@OrderTime,@OrderContent,@Addtime,@Status,@Phone) select @@identity";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@UnitId",SqlDbType.VarChar),
			new SqlParameter("@OrderTime",SqlDbType.DateTime),
			new SqlParameter("@OrderContent",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int),
            new SqlParameter("@Phone",SqlDbType.VarChar)
			};
            _param[0].Value = _tb_SubscribeModel.UserId;
            _param[1].Value = _tb_SubscribeModel.UnitId;
            _param[2].Value = _tb_SubscribeModel.OrderTime;
            _param[3].Value = _tb_SubscribeModel.OrderContent;
            _param[4].Value = _tb_SubscribeModel.Addtime;
            _param[5].Value = _tb_SubscribeModel.Status;
            _param[6].Value = _tb_SubscribeModel.Phone;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Subscribe更新一条记录。
		/// </summary>
		/// <param name="_tb_SubscribeModel">_tb_SubscribeModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_SubscribeEntity _tb_SubscribeModel)
		{
            string sqlStr="update tb_Subscribe set [UserId]=@UserId,[UnitId]=@UnitId,[OrderTime]=@OrderTime,[OrderContent]=@OrderContent,[Addtime]=@Addtime,[Status]=@Status,Phone=@Phone where Id=@Id";
			SqlParameter[] _param={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@UnitId",SqlDbType.VarChar),
				new SqlParameter("@OrderTime",SqlDbType.DateTime),
				new SqlParameter("@OrderContent",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int),
                new SqlParameter("@Phone",SqlDbType.VarChar)
				};				
				_param[0].Value=_tb_SubscribeModel.Id;
				_param[1].Value=_tb_SubscribeModel.UserId;
				_param[2].Value=_tb_SubscribeModel.UnitId;
				_param[3].Value=_tb_SubscribeModel.OrderTime;
				_param[4].Value=_tb_SubscribeModel.OrderContent;
				_param[5].Value=_tb_SubscribeModel.Addtime;
				_param[6].Value=_tb_SubscribeModel.Status;
                _param[7].Value = _tb_SubscribeModel.Phone;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Subscribe更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_SubscribeModel">_tb_SubscribeModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_SubscribeEntity _tb_SubscribeModel)
		{
            string sqlStr = "update tb_Subscribe set [UserId]=@UserId,[UnitId]=@UnitId,[OrderTime]=@OrderTime,[OrderContent]=@OrderContent,[Addtime]=@Addtime,[Status]=@Status,Phone=@Phone where Id=@Id";
            SqlParameter[] _param ={				
				new SqlParameter("@Id",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@UnitId",SqlDbType.VarChar),
				new SqlParameter("@OrderTime",SqlDbType.DateTime),
				new SqlParameter("@OrderContent",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int),
                new SqlParameter("@Phone",SqlDbType.VarChar)
				};
            _param[0].Value = _tb_SubscribeModel.Id;
            _param[1].Value = _tb_SubscribeModel.UserId;
            _param[2].Value = _tb_SubscribeModel.UnitId;
            _param[3].Value = _tb_SubscribeModel.OrderTime;
            _param[4].Value = _tb_SubscribeModel.OrderContent;
            _param[5].Value = _tb_SubscribeModel.Addtime;
            _param[6].Value = _tb_SubscribeModel.Status;
            _param[7].Value = _tb_SubscribeModel.Phone;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Subscribe中的一条记录
		/// </summary>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(int Id)
		{
			string sqlStr="delete from tb_Subscribe where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Subscribe中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="Id">id</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int Id)
		{
			string sqlStr="delete from tb_Subscribe where [Id]=@Id";
			SqlParameter[] _param={			
			new SqlParameter("@Id",SqlDbType.Int),
			
			};			
			_param[0].Value=Id;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_subscribe 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_subscribe 数据实体</returns>
		public tb_SubscribeEntity Populate_tb_SubscribeEntity_FromDr(DataRow row)
		{
			tb_SubscribeEntity Obj = new tb_SubscribeEntity();
			if(row!=null)
			{
				Obj.Id = (( row["Id"])==DBNull.Value)?0:Convert.ToInt32( row["Id"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
                Obj.Phone = row["Phone"].ToString();
				Obj.UnitId =  row["UnitId"].ToString();
				Obj.OrderTime = (( row["OrderTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["OrderTime"]);
				Obj.OrderContent =  row["OrderContent"].ToString();
				Obj.Addtime = (( row["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["Addtime"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_subscribe 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_subscribe 数据实体</returns>
		public tb_SubscribeEntity Populate_tb_SubscribeEntity_FromDr(IDataReader dr)
		{
			tb_SubscribeEntity Obj = new tb_SubscribeEntity();
			
				Obj.Id = (( dr["Id"])==DBNull.Value)?0:Convert.ToInt32( dr["Id"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
                Obj.UnitId = dr["Phone"].ToString();
				Obj.UnitId =  dr["UnitId"].ToString();
				Obj.OrderTime = (( dr["OrderTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["OrderTime"]);
				Obj.OrderContent =  dr["OrderContent"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Subscribe对象
		/// </summary>
		/// <param name="id">id</param>
		/// <returns>tb_Subscribe对象</returns>
		public tb_SubscribeEntity Get_tb_SubscribeEntity (int id)
		{
			tb_SubscribeEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@Id",SqlDbType.Int)
			};
			_param[0].Value=id;
			string sqlStr="select * from tb_Subscribe with(nolock) where Id=@Id";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_SubscribeEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Subscribe所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_SubscribeEntity> Get_tb_SubscribeAll()
		{
			IList< tb_SubscribeEntity> Obj=new List< tb_SubscribeEntity>();
			string sqlStr="select * from tb_Subscribe";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_SubscribeEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Subscribe(int id)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@id",SqlDbType.Int)
                                  };
            _param[0].Value=id;
            string sqlStr="select Count(*) from tb_Subscribe where Id=@id";
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
