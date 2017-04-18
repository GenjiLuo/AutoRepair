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
using AutoRepair.Entity;
using Jnwf.Utils.Data;


namespace AutoRepair.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Department.
    /// </summary>
    public partial class tb_DepartmentDataAccessLayer 
    {
        /// <summary>
        /// 根据UserName,返回一个tb_Department对象
        /// </summary>
        /// <param name="departmentId">departmentId</param>
        /// <returns>tb_Department对象</returns>
        public tb_DepartmentEntity Get_tb_DepartmentByUserName(string UserName)
        {
            tb_DepartmentEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserName",SqlDbType.VarChar)
			};
            _param[0].Value = UserName;
            string sqlStr = "select * from tb_Department with(nolock) where UserName=@UserName";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_DepartmentEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 根据UserName和UserPwd,返回一个tb_Department对象
        /// </summary>
        /// <param name="departmentId">departmentId</param>
        /// <returns>tb_Department对象</returns>
        public tb_DepartmentEntity Get_tb_DepartmentByNameAndPwd(string UserName, string UserPwd)
        {
            tb_DepartmentEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UserName",SqlDbType.VarChar),
          	new SqlParameter("@UserPwd",SqlDbType.VarChar)
			};
            _param[0].Value = UserName;
            _param[1].Value = UserPwd;
            string sqlStr = "select * from tb_Department with(nolock) where UserName=@UserName and UserPwd=@UserPwd and Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_DepartmentEntity_FromDr(dr);
                }
            }
            return _obj;
        }

        /// <summary>
        ///根据address,获取
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public IList<tb_DepartmentEntity> Get_tb_DepartmentByAddress(string Address)
        {
            IList<tb_DepartmentEntity> Obj = new List<tb_DepartmentEntity>();
            string sqlStr = "select * from tb_Department where Address like '%" + Address + "%'and  Status=1";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_DepartmentEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        public IList<tb_DepartmentEntity> Gettb_DepartmentBylocationid(int locationid)
        {
            IList<tb_DepartmentEntity> Obj = new List<tb_DepartmentEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@locationid",SqlDbType.Int)
			};
            _param[0].Value = locationid;
            string sqlStr = " select * from tb_Department a inner join tb_Location b on a.LocationId=b.LocationId where Status=1 and a.LocationId=@locationid order by [AddTime] desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_DepartmentEntity_FromDr(dr));
                }
            }
            return Obj;
        }

        public IList<tb_DepartmentEntity> Gettb_DepartmentByLocationParentId(int LocationParentId)
        {
            IList<tb_DepartmentEntity> Obj = new List<tb_DepartmentEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@LocationParentId",SqlDbType.Int)
			};
            _param[0].Value = LocationParentId;
            string sqlStr = "select * from tb_Department a inner join tb_Location b on a.LocationId=b.LocationId where Status=1 and b.LocationParentId=@LocationParentId  order by [AddTime] desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_DepartmentEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 得到数据表tb_Department所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<tb_DepartmentEntity> Get_tb_DepartmentAll()
        {
            IList<tb_DepartmentEntity> Obj = new List<tb_DepartmentEntity>();
            string sqlStr = "  select * from tb_Department a inner join tb_Location b on a.LocationId=b.LocationId where Status=1  order by [AddTime] desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_DepartmentEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
