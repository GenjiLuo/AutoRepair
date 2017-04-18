// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Evaluate.cs
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
    /// 数据层实例化接口类 dbo.tb_Evaluate.
    /// </summary>
    public partial class tb_EvaluateDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_EvaluateDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_EvaluateModel">tb_Evaluate实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_EvaluateEntity _tb_EvaluateModel)
		{
			string sqlStr="insert into tb_Evaluate([RecordsId],[UnitID],[AssessCount],[Speed],[Attitude],[Quality],[Type],[Status],[AddTime],[AssessCount2],[AddTime2]) values(@RecordsId,@UnitID,@AssessCount,@Speed,@Attitude,@Quality,@Type,@Status,@AddTime,@AssessCount2,@AddTime2) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@RecordsId",SqlDbType.Int),
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@AssessCount",SqlDbType.VarChar),
			new SqlParameter("@Speed",SqlDbType.Int),
			new SqlParameter("@Attitude",SqlDbType.Int),
			new SqlParameter("@Quality",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@AssessCount2",SqlDbType.VarChar),
			new SqlParameter("@AddTime2",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_EvaluateModel.RecordsId;
			_param[1].Value=_tb_EvaluateModel.UnitID;
			_param[2].Value=_tb_EvaluateModel.AssessCount;
			_param[3].Value=_tb_EvaluateModel.Speed;
			_param[4].Value=_tb_EvaluateModel.Attitude;
			_param[5].Value=_tb_EvaluateModel.Quality;
			_param[6].Value=_tb_EvaluateModel.Type;
			_param[7].Value=_tb_EvaluateModel.Status;
			_param[8].Value=_tb_EvaluateModel.AddTime;
			_param[9].Value=_tb_EvaluateModel.AssessCount2;
			_param[10].Value=_tb_EvaluateModel.AddTime2;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_EvaluateModel">tb_Evaluate实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_EvaluateEntity _tb_EvaluateModel)
		{
			string sqlStr="insert into tb_Evaluate([RecordsId],[UnitID],[AssessCount],[Speed],[Attitude],[Quality],[Type],[Status],[AddTime],[AssessCount2],[AddTime2]) values(@RecordsId,@UnitID,@AssessCount,@Speed,@Attitude,@Quality,@Type,@Status,@AddTime,@AssessCount2,@AddTime2) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@RecordsId",SqlDbType.Int),
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@AssessCount",SqlDbType.VarChar),
			new SqlParameter("@Speed",SqlDbType.Int),
			new SqlParameter("@Attitude",SqlDbType.Int),
			new SqlParameter("@Quality",SqlDbType.Int),
			new SqlParameter("@Type",SqlDbType.Int),
			new SqlParameter("@Status",SqlDbType.Int),
			new SqlParameter("@AddTime",SqlDbType.DateTime),
			new SqlParameter("@AssessCount2",SqlDbType.VarChar),
			new SqlParameter("@AddTime2",SqlDbType.DateTime)
			};			
			_param[0].Value=_tb_EvaluateModel.RecordsId;
			_param[1].Value=_tb_EvaluateModel.UnitID;
			_param[2].Value=_tb_EvaluateModel.AssessCount;
			_param[3].Value=_tb_EvaluateModel.Speed;
			_param[4].Value=_tb_EvaluateModel.Attitude;
			_param[5].Value=_tb_EvaluateModel.Quality;
			_param[6].Value=_tb_EvaluateModel.Type;
			_param[7].Value=_tb_EvaluateModel.Status;
			_param[8].Value=_tb_EvaluateModel.AddTime;
			_param[9].Value=_tb_EvaluateModel.AssessCount2;
			_param[10].Value=_tb_EvaluateModel.AddTime2;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Evaluate更新一条记录。
		/// </summary>
		/// <param name="_tb_EvaluateModel">_tb_EvaluateModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_EvaluateEntity _tb_EvaluateModel)
		{
            string sqlStr="update tb_Evaluate set [RecordsId]=@RecordsId,[UnitID]=@UnitID,[AssessCount]=@AssessCount,[Speed]=@Speed,[Attitude]=@Attitude,[Quality]=@Quality,[Type]=@Type,[Status]=@Status,[AddTime]=@AddTime,[AssessCount2]=@AssessCount2,[AddTime2]=@AddTime2 where AssessId=@AssessId";
			SqlParameter[] _param={				
				new SqlParameter("@AssessId",SqlDbType.Int),
				new SqlParameter("@RecordsId",SqlDbType.Int),
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@AssessCount",SqlDbType.VarChar),
				new SqlParameter("@Speed",SqlDbType.Int),
				new SqlParameter("@Attitude",SqlDbType.Int),
				new SqlParameter("@Quality",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@AssessCount2",SqlDbType.VarChar),
				new SqlParameter("@AddTime2",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_EvaluateModel.AssessId;
				_param[1].Value=_tb_EvaluateModel.RecordsId;
				_param[2].Value=_tb_EvaluateModel.UnitID;
				_param[3].Value=_tb_EvaluateModel.AssessCount;
				_param[4].Value=_tb_EvaluateModel.Speed;
				_param[5].Value=_tb_EvaluateModel.Attitude;
				_param[6].Value=_tb_EvaluateModel.Quality;
				_param[7].Value=_tb_EvaluateModel.Type;
				_param[8].Value=_tb_EvaluateModel.Status;
				_param[9].Value=_tb_EvaluateModel.AddTime;
				_param[10].Value=_tb_EvaluateModel.AssessCount2;
				_param[11].Value=_tb_EvaluateModel.AddTime2;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Evaluate更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_EvaluateModel">_tb_EvaluateModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_EvaluateEntity _tb_EvaluateModel)
		{
            string sqlStr="update tb_Evaluate set [RecordsId]=@RecordsId,[UnitID]=@UnitID,[AssessCount]=@AssessCount,[Speed]=@Speed,[Attitude]=@Attitude,[Quality]=@Quality,[Type]=@Type,[Status]=@Status,[AddTime]=@AddTime,[AssessCount2]=@AssessCount2,[AddTime2]=@AddTime2 where AssessId=@AssessId";
			SqlParameter[] _param={				
				new SqlParameter("@AssessId",SqlDbType.Int),
				new SqlParameter("@RecordsId",SqlDbType.Int),
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@AssessCount",SqlDbType.VarChar),
				new SqlParameter("@Speed",SqlDbType.Int),
				new SqlParameter("@Attitude",SqlDbType.Int),
				new SqlParameter("@Quality",SqlDbType.Int),
				new SqlParameter("@Type",SqlDbType.Int),
				new SqlParameter("@Status",SqlDbType.Int),
				new SqlParameter("@AddTime",SqlDbType.DateTime),
				new SqlParameter("@AssessCount2",SqlDbType.VarChar),
				new SqlParameter("@AddTime2",SqlDbType.DateTime)
				};				
				_param[0].Value=_tb_EvaluateModel.AssessId;
				_param[1].Value=_tb_EvaluateModel.RecordsId;
				_param[2].Value=_tb_EvaluateModel.UnitID;
				_param[3].Value=_tb_EvaluateModel.AssessCount;
				_param[4].Value=_tb_EvaluateModel.Speed;
				_param[5].Value=_tb_EvaluateModel.Attitude;
				_param[6].Value=_tb_EvaluateModel.Quality;
				_param[7].Value=_tb_EvaluateModel.Type;
				_param[8].Value=_tb_EvaluateModel.Status;
				_param[9].Value=_tb_EvaluateModel.AddTime;
				_param[10].Value=_tb_EvaluateModel.AssessCount2;
				_param[11].Value=_tb_EvaluateModel.AddTime2;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Evaluate中的一条记录
		/// </summary>
	    /// <param name="AssessId">assessId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int AssessId)
		{
			string sqlStr="delete from tb_Evaluate where [AssessId]=@AssessId";
			SqlParameter[] _param={			
			new SqlParameter("@AssessId",SqlDbType.Int),
			
			};			
			_param[0].Value=AssessId;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Evaluate中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="AssessId">assessId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int AssessId)
		{
			string sqlStr="delete from tb_Evaluate where [AssessId]=@AssessId";
			SqlParameter[] _param={			
			new SqlParameter("@AssessId",SqlDbType.Int),
			
			};			
			_param[0].Value=AssessId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_evaluate 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_evaluate 数据实体</returns>
		public tb_EvaluateEntity Populate_tb_EvaluateEntity_FromDr(DataRow row)
		{
			tb_EvaluateEntity Obj = new tb_EvaluateEntity();
			if(row!=null)
			{
				Obj.AssessId = (( row["AssessId"])==DBNull.Value)?0:Convert.ToInt32( row["AssessId"]);
				Obj.RecordsId = (( row["RecordsId"])==DBNull.Value)?0:Convert.ToInt32( row["RecordsId"]);
				Obj.UnitID =  row["UnitID"].ToString();
				Obj.AssessCount =  row["AssessCount"].ToString();
				Obj.Speed = (( row["Speed"])==DBNull.Value)?0:Convert.ToInt32( row["Speed"]);
				Obj.Attitude = (( row["Attitude"])==DBNull.Value)?0:Convert.ToInt32( row["Attitude"]);
				Obj.Quality = (( row["Quality"])==DBNull.Value)?0:Convert.ToInt32( row["Quality"]);
				Obj.Type = (( row["Type"])==DBNull.Value)?0:Convert.ToInt32( row["Type"]);
				Obj.Status = (( row["Status"])==DBNull.Value)?0:Convert.ToInt32( row["Status"]);
				Obj.AddTime = (( row["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime"]);
				Obj.AssessCount2 =  row["AssessCount2"].ToString();
				Obj.AddTime2 = (( row["AddTime2"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( row["AddTime2"]);
			}
			else
			{
				return null;
			}
			return Obj;
		}
		
        /// <summary>
		/// 得到  tb_evaluate 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_evaluate 数据实体</returns>
		public tb_EvaluateEntity Populate_tb_EvaluateEntity_FromDr(IDataReader dr)
		{
			tb_EvaluateEntity Obj = new tb_EvaluateEntity();
			
				Obj.AssessId = (( dr["AssessId"])==DBNull.Value)?0:Convert.ToInt32( dr["AssessId"]);
				Obj.RecordsId = (( dr["RecordsId"])==DBNull.Value)?0:Convert.ToInt32( dr["RecordsId"]);
				Obj.UnitID =  dr["UnitID"].ToString();
				Obj.AssessCount =  dr["AssessCount"].ToString();
				Obj.Speed = (( dr["Speed"])==DBNull.Value)?0:Convert.ToInt32( dr["Speed"]);
				Obj.Attitude = (( dr["Attitude"])==DBNull.Value)?0:Convert.ToInt32( dr["Attitude"]);
				Obj.Quality = (( dr["Quality"])==DBNull.Value)?0:Convert.ToInt32( dr["Quality"]);
				Obj.Type = (( dr["Type"])==DBNull.Value)?0:Convert.ToInt32( dr["Type"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
				Obj.AddTime = (( dr["AddTime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime"]);
				Obj.AssessCount2 =  dr["AssessCount2"].ToString();
				Obj.AddTime2 = (( dr["AddTime2"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["AddTime2"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Evaluate对象
		/// </summary>
		/// <param name="assessId">assessId</param>
		/// <returns>tb_Evaluate对象</returns>
		public tb_EvaluateEntity Get_tb_EvaluateEntity (int assessId)
		{
			tb_EvaluateEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@AssessId",SqlDbType.Int)
			};
			_param[0].Value=assessId;
			string sqlStr="select * from tb_Evaluate with(nolock) where AssessId=@AssessId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_EvaluateEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Evaluate所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_EvaluateEntity> Get_tb_EvaluateAll()
		{
			IList< tb_EvaluateEntity> Obj=new List< tb_EvaluateEntity>();
			string sqlStr="select * from tb_Evaluate";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_EvaluateEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="assessId">assessId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Evaluate(int assessId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@assessId",SqlDbType.Int)
                                  };
            _param[0].Value=assessId;
            string sqlStr="select Count(*) from tb_Evaluate where AssessId=@assessId";
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
