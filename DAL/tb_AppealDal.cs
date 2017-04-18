// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Appeal.cs
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
    /// 数据层实例化接口类 dbo.tb_Appeal.
    /// </summary>
    public partial class tb_AppealDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_AppealDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_AppealModel">tb_Appeal实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_AppealEntity _tb_AppealModel)
		{
			string sqlStr="insert into tb_Appeal([UserId],[AppealCount],[Img1],[Img2],[Img3],[Img4],[Img5],[Status],[AddTime],[UpdateTime]) values(@UserId,@AppealCount,@Img1,@Img2,@Img3,@Img4,@Img5,@Status,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@AppealCount",SqlDbType.VarChar),
			new SqlParameter("@Img1",SqlDbType.VarChar),
			new SqlParameter("@Img2",SqlDbType.VarChar),
			new SqlParameter("@Img3",SqlDbType.VarChar),
			new SqlParameter("@Img4",SqlDbType.VarChar),
			new SqlParameter("@Img5",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_AppealModel.UserId;
			_param[1].Value=_tb_AppealModel.AppealCount;
			_param[2].Value=_tb_AppealModel.Img1;
			_param[3].Value=_tb_AppealModel.Img2;
			_param[4].Value=_tb_AppealModel.Img3;
			_param[5].Value=_tb_AppealModel.Img4;
			_param[6].Value=_tb_AppealModel.Img5;
			_param[7].Value=_tb_AppealModel.Status;
			_param[8].Value=_tb_AppealModel.AddTime;
			_param[9].Value=_tb_AppealModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_AppealModel">tb_Appeal实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_AppealEntity _tb_AppealModel)
		{
			string sqlStr="insert into tb_Appeal([UserId],[AppealCount],[Img1],[Img2],[Img3],[Img4],[Img5],[Status],[AddTime],[UpdateTime]) values(@UserId,@AppealCount,@Img1,@Img2,@Img3,@Img4,@Img5,@Status,@AddTime,@UpdateTime) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@AppealCount",SqlDbType.VarChar),
			new SqlParameter("@Img1",SqlDbType.VarChar),
			new SqlParameter("@Img2",SqlDbType.VarChar),
			new SqlParameter("@Img3",SqlDbType.VarChar),
			new SqlParameter("@Img4",SqlDbType.VarChar),
			new SqlParameter("@Img5",SqlDbType.VarChar),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@UpdateTime",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_AppealModel.UserId;
			_param[1].Value=_tb_AppealModel.AppealCount;
			_param[2].Value=_tb_AppealModel.Img1;
			_param[3].Value=_tb_AppealModel.Img2;
			_param[4].Value=_tb_AppealModel.Img3;
			_param[5].Value=_tb_AppealModel.Img4;
			_param[6].Value=_tb_AppealModel.Img5;
			_param[7].Value=_tb_AppealModel.Status;
			_param[8].Value=_tb_AppealModel.AddTime;
			_param[9].Value=_tb_AppealModel.UpdateTime;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Appeal更新一条记录。
		/// </summary>
		/// <param name="_tb_AppealModel">_tb_AppealModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_AppealEntity _tb_AppealModel)
		{
            string sqlStr="update tb_Appeal set [UserId]=@UserId,[AppealCount]=@AppealCount,[Img1]=@Img1,[Img2]=@Img2,[Img3]=@Img3,[Img4]=@Img4,[Img5]=@Img5,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where AppealId=@AppealId";
			SqlParameter[] _param={				
				new SqlParameter("@AppealId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@AppealCount",SqlDbType.VarChar),
				new SqlParameter("@Img1",SqlDbType.VarChar),
				new SqlParameter("@Img2",SqlDbType.VarChar),
				new SqlParameter("@Img3",SqlDbType.VarChar),
				new SqlParameter("@Img4",SqlDbType.VarChar),
				new SqlParameter("@Img5",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_AppealModel.AppealId;
				_param[1].Value=_tb_AppealModel.UserId;
				_param[2].Value=_tb_AppealModel.AppealCount;
				_param[3].Value=_tb_AppealModel.Img1;
				_param[4].Value=_tb_AppealModel.Img2;
				_param[5].Value=_tb_AppealModel.Img3;
				_param[6].Value=_tb_AppealModel.Img4;
				_param[7].Value=_tb_AppealModel.Img5;
				_param[8].Value=_tb_AppealModel.Status;
				_param[9].Value=_tb_AppealModel.AddTime;
				_param[10].Value=_tb_AppealModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Appeal更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_AppealModel">_tb_AppealModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_AppealEntity _tb_AppealModel)
		{
            string sqlStr="update tb_Appeal set [UserId]=@UserId,[AppealCount]=@AppealCount,[Img1]=@Img1,[Img2]=@Img2,[Img3]=@Img3,[Img4]=@Img4,[Img5]=@Img5,[Status]=@Status,[AddTime]=@AddTime,[UpdateTime]=@UpdateTime where AppealId=@AppealId";
			SqlParameter[] _param={				
				new SqlParameter("@AppealId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@AppealCount",SqlDbType.VarChar),
				new SqlParameter("@Img1",SqlDbType.VarChar),
				new SqlParameter("@Img2",SqlDbType.VarChar),
				new SqlParameter("@Img3",SqlDbType.VarChar),
				new SqlParameter("@Img4",SqlDbType.VarChar),
				new SqlParameter("@Img5",SqlDbType.VarChar),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@UpdateTime",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_AppealModel.AppealId;
				_param[1].Value=_tb_AppealModel.UserId;
				_param[2].Value=_tb_AppealModel.AppealCount;
				_param[3].Value=_tb_AppealModel.Img1;
				_param[4].Value=_tb_AppealModel.Img2;
				_param[5].Value=_tb_AppealModel.Img3;
				_param[6].Value=_tb_AppealModel.Img4;
				_param[7].Value=_tb_AppealModel.Img5;
				_param[8].Value=_tb_AppealModel.Status;
				_param[9].Value=_tb_AppealModel.AddTime;
				_param[10].Value=_tb_AppealModel.UpdateTime;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Appeal中的一条记录
		/// </summary>
	    /// <param name="AppealId">appealId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int AppealId)
		{
			string sqlStr="delete from tb_Appeal where [AppealId]=@AppealId";
			SqlParameter[] _param={			
			new SqlParameter("@AppealId",SqlDbType.Int),
			
			};			
			_param[0].Value=AppealId;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Appeal中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="AppealId">appealId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int AppealId)
		{
			string sqlStr="delete from tb_Appeal where [AppealId]=@AppealId";
			SqlParameter[] _param={			
			new SqlParameter("@AppealId",SqlDbType.Int),
			
			};			
			_param[0].Value=AppealId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_appeal 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_appeal 数据实体</returns>
		public tb_AppealEntity Populate_tb_AppealEntity_FromDr(DataRow row)
		{
			tb_AppealEntity Obj = new tb_AppealEntity();
			if(row!=null)
			{
				Obj.AppealId = (( row["AppealId"])==DBNull.Value)?0:Convert.ToInt32( row["AppealId"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.AppealCount =  row["AppealCount"].ToString();
				Obj.Img1 =  row["Img1"].ToString();
				Obj.Img2 =  row["Img2"].ToString();
				Obj.Img3 =  row["Img3"].ToString();
				Obj.Img4 =  row["Img4"].ToString();
				Obj.Img5 =  row["Img5"].ToString();
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.UpdateTime = (( row["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["UpdateTime"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_appeal 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_appeal 数据实体</returns>
		public tb_AppealEntity Populate_tb_AppealEntity_FromDr(IDataReader dr)
		{
			tb_AppealEntity Obj = new tb_AppealEntity();
			
				Obj.AppealId = (( dr["AppealId"])==DBNull.Value)?0:Convert.ToInt32( dr["AppealId"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.AppealCount =  dr["AppealCount"].ToString();
				Obj.Img1 =  dr["Img1"].ToString();
				Obj.Img2 =  dr["Img2"].ToString();
				Obj.Img3 =  dr["Img3"].ToString();
				Obj.Img4 =  dr["Img4"].ToString();
				Obj.Img5 =  dr["Img5"].ToString();
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.UpdateTime = (( dr["UpdateTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["UpdateTime"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Appeal对象
		/// </summary>
		/// <param name="appealId">appealId</param>
		/// <returns>tb_Appeal对象</returns>
		public tb_AppealEntity Get_tb_AppealEntity (int appealId)
		{
			tb_AppealEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@AppealId",SqlDbType.Int)
			};
			_param[0].Value=appealId;
			string sqlStr="select * from tb_Appeal with(nolock) where AppealId=@AppealId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_AppealEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Appeal所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_AppealEntity> Get_tb_AppealAll()
		{
			IList< tb_AppealEntity> Obj=new List< tb_AppealEntity>();
			string sqlStr="select * from tb_Appeal";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_AppealEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="appealId">appealId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Appeal(int appealId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@appealId",SqlDbType.Int)
                                  };
            _param[0].Value=appealId;
            string sqlStr="select Count(*) from tb_Appeal where AppealId=@appealId";
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
