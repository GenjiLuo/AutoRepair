// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Cars.cs
// 项目名称：买车网
// 创建时间：2016/9/8
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
    /// 数据层实例化接口类 dbo.tb_Cars.
    /// </summary>
    public partial class tb_CarsDataAccessLayer 
    {
		#region 构造函数


		/// <summary>
		/// 
		/// </summary>
		public tb_CarsDataAccessLayer()
		{
		}
		#endregion

        #region -----------实例化接口函数-----------
		
		#region 添加更新删除
		/// <summary>
		/// 向数据库中插入一条新记录。
		/// </summary>
		/// <param name="_tb_CarsModel">tb_Cars实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(tb_CarsEntity _tb_CarsModel)
		{
			string sqlStr="insert into tb_Cars([UserId],[CarType],[CarNum],[CarFrameNum],[Addtime],[Status]) values(@UserId,@CarType,@CarNum,@CarFrameNum,@Addtime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@CarType",SqlDbType.Int),
			new SqlParameter("@CarNum",SqlDbType.VarChar),
			new SqlParameter("@CarFrameNum",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_CarsModel.UserId;
			_param[1].Value=_tb_CarsModel.CarType;
			_param[2].Value=_tb_CarsModel.CarNum;
			_param[3].Value=_tb_CarsModel.CarFrameNum;
			_param[4].Value=_tb_CarsModel.Addtime;
			_param[5].Value=_tb_CarsModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param));
			return res;
		}
		/// <summary>
		/// 向数据库中插入一条新记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_CarsModel">tb_Cars实体</param>
		/// <returns>新插入记录的编号</returns>
		public int Insert(SqlTransaction sp,tb_CarsEntity _tb_CarsModel)
		{
			string sqlStr="insert into tb_Cars([UserId],[CarType],[CarNum],[CarFrameNum],[Addtime],[Status]) values(@UserId,@CarType,@CarNum,@CarFrameNum,@Addtime,@Status) select @@identity";
			int res;
			SqlParameter[] _param={
			new SqlParameter("@UserId",SqlDbType.Int),
			new SqlParameter("@CarType",SqlDbType.Int),
			new SqlParameter("@CarNum",SqlDbType.VarChar),
			new SqlParameter("@CarFrameNum",SqlDbType.VarChar),
			new SqlParameter("@Addtime",SqlDbType.DateTime),
			new SqlParameter("@Status",SqlDbType.Int)
			};			
			_param[0].Value=_tb_CarsModel.UserId;
			_param[1].Value=_tb_CarsModel.CarType;
			_param[2].Value=_tb_CarsModel.CarNum;
			_param[3].Value=_tb_CarsModel.CarFrameNum;
			_param[4].Value=_tb_CarsModel.Addtime;
			_param[5].Value=_tb_CarsModel.Status;
			res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp,CommandType.Text,sqlStr,_param));
			return res;
		}


		/// <summary>
		/// 向数据表tb_Cars更新一条记录。
		/// </summary>
		/// <param name="_tb_CarsModel">_tb_CarsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(tb_CarsEntity _tb_CarsModel)
		{
            string sqlStr="update tb_Cars set [UserId]=@UserId,[CarType]=@CarType,[CarNum]=@CarNum,[CarFrameNum]=@CarFrameNum,[Addtime]=@Addtime,[Status]=@Status where CarId=@CarId";
			SqlParameter[] _param={				
				new SqlParameter("@CarId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@CarType",SqlDbType.Int),
				new SqlParameter("@CarNum",SqlDbType.VarChar),
				new SqlParameter("@CarFrameNum",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_CarsModel.CarId;
				_param[1].Value=_tb_CarsModel.UserId;
				_param[2].Value=_tb_CarsModel.CarType;
				_param[3].Value=_tb_CarsModel.CarNum;
				_param[4].Value=_tb_CarsModel.CarFrameNum;
				_param[5].Value=_tb_CarsModel.Addtime;
				_param[6].Value=_tb_CarsModel.Status;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		/// <summary>
		/// 向数据表tb_Cars更新一条记录。带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
		/// <param name="_tb_CarsModel">_tb_CarsModel</param>
		/// <returns>影响的行数</returns>
		public int Update(SqlTransaction sp,tb_CarsEntity _tb_CarsModel)
		{
            string sqlStr="update tb_Cars set [UserId]=@UserId,[CarType]=@CarType,[CarNum]=@CarNum,[CarFrameNum]=@CarFrameNum,[Addtime]=@Addtime,[Status]=@Status where CarId=@CarId";
			SqlParameter[] _param={				
				new SqlParameter("@CarId",SqlDbType.Int),
				new SqlParameter("@UserId",SqlDbType.Int),
				new SqlParameter("@CarType",SqlDbType.Int),
				new SqlParameter("@CarNum",SqlDbType.VarChar),
				new SqlParameter("@CarFrameNum",SqlDbType.VarChar),
				new SqlParameter("@Addtime",SqlDbType.DateTime),
				new SqlParameter("@Status",SqlDbType.Int)
				};				
				_param[0].Value=_tb_CarsModel.CarId;
				_param[1].Value=_tb_CarsModel.UserId;
				_param[2].Value=_tb_CarsModel.CarType;
				_param[3].Value=_tb_CarsModel.CarNum;
				_param[4].Value=_tb_CarsModel.CarFrameNum;
				_param[5].Value=_tb_CarsModel.Addtime;
				_param[6].Value=_tb_CarsModel.Status;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}		
		
		
		/// <summary>
		/// 删除数据表tb_Cars中的一条记录
		/// </summary>
	    /// <param name="CarId">carId</param>
		/// <returns>影响的行数</returns>
		public int Delete(int CarId)
		{
			string sqlStr="delete from tb_Cars where [CarId]=@CarId";
			SqlParameter[] _param={			
			new SqlParameter("@CarId",SqlDbType.Int),
			
			};			
			_param[0].Value=CarId;
			return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param);
		}
		
		/// <summary>
		/// 删除数据表tb_Cars中的一条记录,带事务
		/// </summary>
		/// <param name="sp">事务对象</param>
	    /// <param name="CarId">carId</param>
		/// <returns>影响的行数</returns>
		public int Delete(SqlTransaction sp,int CarId)
		{
			string sqlStr="delete from tb_Cars where [CarId]=@CarId";
			SqlParameter[] _param={			
			new SqlParameter("@CarId",SqlDbType.Int),
			
			};			
			_param[0].Value=CarId;
			return SqlHelper.ExecuteNonQuery(sp,CommandType.Text,sqlStr,_param);
		}
		#endregion
		
		#region 数据实体
		/// <summary>
		/// 得到  tb_cars 数据实体
		/// </summary>
		/// <param name="row">row</param>
		/// <returns>tb_cars 数据实体</returns>
		public tb_CarsEntity Populate_tb_CarsEntity_FromDr(DataRow row)
		{
			tb_CarsEntity Obj = new tb_CarsEntity();
			if(row!=null)
			{
				Obj.CarId = (( row["CarId"])==DBNull.Value)?0:Convert.ToInt32( row["CarId"]);
				Obj.UserId = (( row["UserId"])==DBNull.Value)?0:Convert.ToInt32( row["UserId"]);
				Obj.CarType = (( row["CarType"])==DBNull.Value)?0:Convert.ToInt32( row["CarType"]);
				Obj.CarNum =  row["CarNum"].ToString();
				Obj.CarFrameNum =  row["CarFrameNum"].ToString();
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
		/// 得到  tb_cars 数据实体
		/// </summary>
		/// <param name="dr">dr</param>
		/// <returns>tb_cars 数据实体</returns>
		public tb_CarsEntity Populate_tb_CarsEntity_FromDr(IDataReader dr)
		{
			tb_CarsEntity Obj = new tb_CarsEntity();
			
				Obj.CarId = (( dr["CarId"])==DBNull.Value)?0:Convert.ToInt32( dr["CarId"]);
				Obj.UserId = (( dr["UserId"])==DBNull.Value)?0:Convert.ToInt32( dr["UserId"]);
				Obj.CarType = (( dr["CarType"])==DBNull.Value)?0:Convert.ToInt32( dr["CarType"]);
				Obj.CarNum =  dr["CarNum"].ToString();
				Obj.CarFrameNum =  dr["CarFrameNum"].ToString();
				Obj.Addtime = (( dr["Addtime"])==DBNull.Value)?Convert.ToDateTime("1900-1-1"):Convert.ToDateTime( dr["Addtime"]);
				Obj.Status = (( dr["Status"])==DBNull.Value)?0:Convert.ToInt32( dr["Status"]);
			
			return Obj;
		}
		#endregion
		
		/// <summary>
		/// 根据ID,返回一个tb_Cars对象
		/// </summary>
		/// <param name="carId">carId</param>
		/// <returns>tb_Cars对象</returns>
		public tb_CarsEntity Get_tb_CarsEntity (int carId)
		{
			tb_CarsEntity _obj=null;
			SqlParameter[] _param={
			new SqlParameter("@CarId",SqlDbType.Int)
			};
			_param[0].Value=carId;
			string sqlStr="select * from tb_Cars with(nolock) where CarId=@CarId";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr,_param))
			{
				while(dr.Read())
				{
            		_obj=Populate_tb_CarsEntity_FromDr(dr);
				}
			}
			return _obj;
		}
		/// <summary>
		/// 得到数据表tb_Cars所有记录
		/// </summary>
		/// <returns>数据集</returns>
		public IList< tb_CarsEntity> Get_tb_CarsAll()
		{
			IList< tb_CarsEntity> Obj=new List< tb_CarsEntity>();
			string sqlStr="select * from tb_Cars";
			using(SqlDataReader dr=SqlHelper.ExecuteReader(WebConfig.AutoRepairRW,CommandType.Text,sqlStr))
			{
				while(dr.Read())
				{
					Obj.Add(Populate_tb_CarsEntity_FromDr(dr));
				}
			}
			return Obj;
		}
		/// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="carId">carId</param>
        /// <returns>是/否</returns>
		public bool IsExisttb_Cars(int carId)
		{
			SqlParameter[] _param={
                                      new SqlParameter("@carId",SqlDbType.Int)
                                  };
            _param[0].Value=carId;
            string sqlStr="select Count(*) from tb_Cars where CarId=@carId";
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
