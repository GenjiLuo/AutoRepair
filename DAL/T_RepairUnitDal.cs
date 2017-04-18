// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairUnit.cs
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
    /// 数据层实例化接口类 dbo.T_RepairUnit.
    /// </summary>
    public partial class T_RepairUnitDataAccessLayer
    {
        #region 构造函数


        /// <summary>
        /// 
        /// </summary>
        public T_RepairUnitDataAccessLayer()
        {
        }
        #endregion

        #region -----------实例化接口函数-----------

        #region 添加更新删除
        /// <summary>
        /// 向数据库中插入一条新记录。
        /// </summary>
        /// <param name="_T_RepairUnitModel">T_RepairUnit实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(T_RepairUnitEntity _T_RepairUnitModel)
        {
            string sqlStr = "insert into T_RepairUnit([UnitID],[UnitName],[LinkMan],[Phone],[Address],[TaxNumber],[ICNumber],[AdminPwd],[Remark],[Area],[UnitState],[UsbKey],[AuthToken],[Lag],[Lat],[Crerating],[Categories],[Range]) values(@UnitID,@UnitName,@LinkMan,@Phone,@Address,@TaxNumber,@ICNumber,@AdminPwd,@Remark,@Area,@UnitState,@UsbKey,@AuthToken,@Lag,@Lat,@Crerating,@Categories,@Range) select @UnitID";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@UnitName",SqlDbType.VarChar),
			new SqlParameter("@LinkMan",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@TaxNumber",SqlDbType.VarChar),
			new SqlParameter("@ICNumber",SqlDbType.VarChar),
			new SqlParameter("@AdminPwd",SqlDbType.VarChar),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@Area",SqlDbType.VarChar),
			new SqlParameter("@UnitState",SqlDbType.VarChar),
			new SqlParameter("@UsbKey",SqlDbType.VarChar),
			new SqlParameter("@AuthToken",SqlDbType.VarChar),
            new SqlParameter("@Lag",SqlDbType.Decimal),
            new SqlParameter("@Lat",SqlDbType.Decimal),
            new SqlParameter("@Crerating",SqlDbType.VarChar),
            new SqlParameter("@Categories",SqlDbType.VarChar),
            new SqlParameter("@Range",SqlDbType.VarChar)
			};
            _param[0].Value = _T_RepairUnitModel.UnitID;
            _param[1].Value = _T_RepairUnitModel.UnitName;
            _param[2].Value = _T_RepairUnitModel.LinkMan;
            _param[3].Value = _T_RepairUnitModel.Phone;
            _param[4].Value = _T_RepairUnitModel.Address;
            _param[5].Value = _T_RepairUnitModel.TaxNumber;
            _param[6].Value = _T_RepairUnitModel.ICNumber;
            _param[7].Value = _T_RepairUnitModel.AdminPwd;
            _param[8].Value = _T_RepairUnitModel.Remark;
            _param[9].Value = _T_RepairUnitModel.Area;
            _param[10].Value = _T_RepairUnitModel.UnitState;
            _param[11].Value = _T_RepairUnitModel.UsbKey;
            _param[12].Value = _T_RepairUnitModel.AuthToken;
            _param[13].Value = _T_RepairUnitModel.Lag;
            _param[14].Value = _T_RepairUnitModel.Lat;
            _param[15].Value = _T_RepairUnitModel.Crerating;
            _param[16].Value = _T_RepairUnitModel.Categories;
            _param[17].Value = _T_RepairUnitModel.Range;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param));
            return res;
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_T_RepairUnitModel">T_RepairUnit实体</param>
        /// <returns>新插入记录的编号</returns>
        public int Insert(SqlTransaction sp, T_RepairUnitEntity _T_RepairUnitModel)
        {
            string sqlStr = "insert into T_RepairUnit([UnitID],[UnitName],[LinkMan],[Phone],[Address],[TaxNumber],[ICNumber],[AdminPwd],[Remark],[Area],[UnitState],[UsbKey],[AuthToken],[Lag],[Lat],[Crerating],[Categories],[Range]) values(@UnitID,@UnitName,@LinkMan,@Phone,@Address,@TaxNumber,@ICNumber,@AdminPwd,@Remark,@Area,@UnitState,@UsbKey,@AuthToken,@Lag,@Lat,@Crerating,@Categories,@Range) select @UnitID";
            int res;
            SqlParameter[] _param ={
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			new SqlParameter("@UnitName",SqlDbType.VarChar),
			new SqlParameter("@LinkMan",SqlDbType.VarChar),
			new SqlParameter("@Phone",SqlDbType.VarChar),
			new SqlParameter("@Address",SqlDbType.VarChar),
			new SqlParameter("@TaxNumber",SqlDbType.VarChar),
			new SqlParameter("@ICNumber",SqlDbType.VarChar),
			new SqlParameter("@AdminPwd",SqlDbType.VarChar),
			new SqlParameter("@Remark",SqlDbType.VarChar),
			new SqlParameter("@Area",SqlDbType.VarChar),
			new SqlParameter("@UnitState",SqlDbType.VarChar),
			new SqlParameter("@UsbKey",SqlDbType.VarChar),
			new SqlParameter("@AuthToken",SqlDbType.VarChar),
            new SqlParameter("@Lag",SqlDbType.Decimal),
            new SqlParameter("@Lat",SqlDbType.Decimal),
            new SqlParameter("@Crerating",SqlDbType.VarChar),
            new SqlParameter("@Categories",SqlDbType.VarChar),
            new SqlParameter("@Range",SqlDbType.VarChar)
			};
            _param[0].Value = _T_RepairUnitModel.UnitID;
            _param[1].Value = _T_RepairUnitModel.UnitName;
            _param[2].Value = _T_RepairUnitModel.LinkMan;
            _param[3].Value = _T_RepairUnitModel.Phone;
            _param[4].Value = _T_RepairUnitModel.Address;
            _param[5].Value = _T_RepairUnitModel.TaxNumber;
            _param[6].Value = _T_RepairUnitModel.ICNumber;
            _param[7].Value = _T_RepairUnitModel.AdminPwd;
            _param[8].Value = _T_RepairUnitModel.Remark;
            _param[9].Value = _T_RepairUnitModel.Area;
            _param[10].Value = _T_RepairUnitModel.UnitState;
            _param[11].Value = _T_RepairUnitModel.UsbKey;
            _param[12].Value = _T_RepairUnitModel.AuthToken;
            _param[13].Value = _T_RepairUnitModel.Lag;
            _param[14].Value = _T_RepairUnitModel.Lat;
            _param[15].Value = _T_RepairUnitModel.Crerating;
            _param[16].Value = _T_RepairUnitModel.Categories;
            _param[17].Value = _T_RepairUnitModel.Range;
            res = Convert.ToInt32(SqlHelper.ExecuteScalar(sp, CommandType.Text, sqlStr, _param));
            return res;
        }


        /// <summary>
        /// 向数据表T_RepairUnit更新一条记录。
        /// </summary>
        /// <param name="_T_RepairUnitModel">_T_RepairUnitModel</param>
        /// <returns>影响的行数</returns>
        public int Update(T_RepairUnitEntity _T_RepairUnitModel)
        {
            string sqlStr = "update T_RepairUnit set [UnitName]=@UnitName,[LinkMan]=@LinkMan,[Phone]=@Phone,[Address]=@Address,[TaxNumber]=@TaxNumber,[ICNumber]=@ICNumber,[AdminPwd]=@AdminPwd,[Remark]=@Remark,[Area]=@Area,[UnitState]=@UnitState,[UsbKey]=@UsbKey,[AuthToken]=@AuthToken,[Lag]=@Lag,[Lat]=@Lat,[Crerating]=@Crerating,[Categories]=@Categories,[Range]=@Range where UnitID=@UnitID";
            SqlParameter[] _param ={				
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@UnitName",SqlDbType.VarChar),
				new SqlParameter("@LinkMan",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@TaxNumber",SqlDbType.VarChar),
				new SqlParameter("@ICNumber",SqlDbType.VarChar),
				new SqlParameter("@AdminPwd",SqlDbType.VarChar),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@Area",SqlDbType.VarChar),
				new SqlParameter("@UnitState",SqlDbType.VarChar),
				new SqlParameter("@UsbKey",SqlDbType.VarChar),
				new SqlParameter("@AuthToken",SqlDbType.VarChar),
                new SqlParameter("@Lag",SqlDbType.Decimal),
                new SqlParameter("@Lat",SqlDbType.Decimal),
                new SqlParameter("@Crerating",SqlDbType.VarChar),
                new SqlParameter("@Categories",SqlDbType.VarChar),
                new SqlParameter("@Range",SqlDbType.VarChar)
				};
            _param[0].Value = _T_RepairUnitModel.UnitID;
            _param[1].Value = _T_RepairUnitModel.UnitName;
            _param[2].Value = _T_RepairUnitModel.LinkMan;
            _param[3].Value = _T_RepairUnitModel.Phone;
            _param[4].Value = _T_RepairUnitModel.Address;
            _param[5].Value = _T_RepairUnitModel.TaxNumber;
            _param[6].Value = _T_RepairUnitModel.ICNumber;
            _param[7].Value = _T_RepairUnitModel.AdminPwd;
            _param[8].Value = _T_RepairUnitModel.Remark;
            _param[9].Value = _T_RepairUnitModel.Area;
            _param[10].Value = _T_RepairUnitModel.UnitState;
            _param[11].Value = _T_RepairUnitModel.UsbKey;
            _param[12].Value = _T_RepairUnitModel.AuthToken;
            _param[13].Value = _T_RepairUnitModel.Lag;
            _param[14].Value = _T_RepairUnitModel.Lat;
            _param[15].Value = _T_RepairUnitModel.Crerating;
            _param[16].Value = _T_RepairUnitModel.Categories;
            _param[17].Value = _T_RepairUnitModel.Range;
            return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 向数据表T_RepairUnit更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="_T_RepairUnitModel">_T_RepairUnitModel</param>
        /// <returns>影响的行数</returns>
        public int Update(SqlTransaction sp, T_RepairUnitEntity _T_RepairUnitModel)
        {
            string sqlStr = "update T_RepairUnit set [UnitName]=@UnitName,[LinkMan]=@LinkMan,[Phone]=@Phone,[Address]=@Address,[TaxNumber]=@TaxNumber,[ICNumber]=@ICNumber,[AdminPwd]=@AdminPwd,[Remark]=@Remark,[Area]=@Area,[UnitState]=@UnitState,[UsbKey]=@UsbKey,[AuthToken]=@AuthToken,[Lag]=@Lag,[Lat]=@Lat,[Crerating]=@Crerating,[Categories]=@Categories,[Range]=@Range where UnitID=@UnitID";
            SqlParameter[] _param ={				
				new SqlParameter("@UnitID",SqlDbType.VarChar),
				new SqlParameter("@UnitName",SqlDbType.VarChar),
				new SqlParameter("@LinkMan",SqlDbType.VarChar),
				new SqlParameter("@Phone",SqlDbType.VarChar),
				new SqlParameter("@Address",SqlDbType.VarChar),
				new SqlParameter("@TaxNumber",SqlDbType.VarChar),
				new SqlParameter("@ICNumber",SqlDbType.VarChar),
				new SqlParameter("@AdminPwd",SqlDbType.VarChar),
				new SqlParameter("@Remark",SqlDbType.VarChar),
				new SqlParameter("@Area",SqlDbType.VarChar),
				new SqlParameter("@UnitState",SqlDbType.VarChar),
				new SqlParameter("@UsbKey",SqlDbType.VarChar),
				new SqlParameter("@AuthToken",SqlDbType.VarChar),
                new SqlParameter("@Lag",SqlDbType.Decimal),
                new SqlParameter("@Lat",SqlDbType.Decimal),
                new SqlParameter("@Crerating",SqlDbType.VarChar),
                new SqlParameter("@Categories",SqlDbType.VarChar),
                new SqlParameter("@Range",SqlDbType.VarChar)
				};
            _param[0].Value = _T_RepairUnitModel.UnitID;
            _param[1].Value = _T_RepairUnitModel.UnitName;
            _param[2].Value = _T_RepairUnitModel.LinkMan;
            _param[3].Value = _T_RepairUnitModel.Phone;
            _param[4].Value = _T_RepairUnitModel.Address;
            _param[5].Value = _T_RepairUnitModel.TaxNumber;
            _param[6].Value = _T_RepairUnitModel.ICNumber;
            _param[7].Value = _T_RepairUnitModel.AdminPwd;
            _param[8].Value = _T_RepairUnitModel.Remark;
            _param[9].Value = _T_RepairUnitModel.Area;
            _param[10].Value = _T_RepairUnitModel.UnitState;
            _param[11].Value = _T_RepairUnitModel.UsbKey;
            _param[12].Value = _T_RepairUnitModel.AuthToken;
            _param[13].Value = _T_RepairUnitModel.Lag;
            _param[14].Value = _T_RepairUnitModel.Lat;
            _param[15].Value = _T_RepairUnitModel.Crerating;
            _param[16].Value = _T_RepairUnitModel.Categories;
            _param[17].Value = _T_RepairUnitModel.Range;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }


        /// <summary>
        /// 删除数据表T_RepairUnit中的一条记录
        /// </summary>
        /// <param name="UnitID">unitID</param>
        /// <returns>影响的行数</returns>
        public int Delete(string UnitID)
        {
            string sqlStr = "delete from T_RepairUnit where [UnitID]=@UnitID";
            SqlParameter[] _param ={			
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			
			};
            _param[0].Value = UnitID;
            return SqlHelper.ExecuteNonQuery(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        }

        /// <summary>
        /// 删除数据表T_RepairUnit中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="UnitID">unitID</param>
        /// <returns>影响的行数</returns>
        public int Delete(SqlTransaction sp, string UnitID)
        {
            string sqlStr = "delete from T_RepairUnit where [UnitID]=@UnitID";
            SqlParameter[] _param ={			
			new SqlParameter("@UnitID",SqlDbType.VarChar),
			
			};
            _param[0].Value = UnitID;
            return SqlHelper.ExecuteNonQuery(sp, CommandType.Text, sqlStr, _param);
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 得到  t_repairunit 数据实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>t_repairunit 数据实体</returns>
        public T_RepairUnitEntity Populate_T_RepairUnitEntity_FromDr(DataRow row)
        {
            T_RepairUnitEntity Obj = new T_RepairUnitEntity();
            if (row != null)
            {
                Obj.UnitID = row["UnitID"].ToString();
                Obj.UnitName = row["UnitName"].ToString();
                Obj.LinkMan = row["LinkMan"].ToString();
                Obj.Phone = row["Phone"].ToString();
                Obj.Address = row["Address"].ToString();
                Obj.TaxNumber = row["TaxNumber"].ToString();
                Obj.ICNumber = row["ICNumber"].ToString();
                Obj.AdminPwd = row["AdminPwd"].ToString();
                Obj.Remark = row["Remark"].ToString();
                Obj.Area = row["Area"].ToString();
                Obj.UnitState = row["UnitState"].ToString();
                Obj.UsbKey = row["UsbKey"].ToString();
                Obj.AuthToken = row["AuthToken"].ToString();
                Obj.Lag = (row["Lag"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["Lag"]);
                Obj.Lat = (row["Lat"] == DBNull.Value) ? 0 : Convert.ToDecimal(row["Lat"]);
                Obj.Crerating = row["Crerating"].ToString();
                Obj.Categories = row["Categories"].ToString();
                Obj.Range = row["Range"].ToString();
            }
            else
            {
                return null;
            }
            return Obj;
        }

        /// <summary>
        /// 得到  t_repairunit 数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>t_repairunit 数据实体</returns>
        public T_RepairUnitEntity Populate_T_RepairUnitEntity_FromDr(IDataReader dr)
        {
            T_RepairUnitEntity Obj = new T_RepairUnitEntity();

            Obj.UnitID = dr["UnitID"].ToString();
            Obj.UnitName = dr["UnitName"].ToString();
            Obj.LinkMan = dr["LinkMan"].ToString();
            Obj.Phone = dr["Phone"].ToString();
            Obj.Address = dr["Address"].ToString();
            Obj.TaxNumber = dr["TaxNumber"].ToString();
            Obj.ICNumber = dr["ICNumber"].ToString();
            Obj.AdminPwd = dr["AdminPwd"].ToString();
            Obj.Remark = dr["Remark"].ToString();
            Obj.Area = dr["Area"].ToString();
            Obj.UnitState = dr["UnitState"].ToString();
            Obj.UsbKey = dr["UsbKey"].ToString();
            Obj.AuthToken = dr["AuthToken"].ToString();
            Obj.Lag = (dr["Lag"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Lag"]);
            Obj.Lat = (dr["Lat"] == DBNull.Value) ? 0 : Convert.ToDecimal(dr["Lat"]);
            Obj.Crerating = dr["Crerating"].ToString();
            Obj.Categories = dr["Categories"].ToString();
            Obj.Range = dr["Range"].ToString();
            return Obj;
        }
        #endregion

        /// <summary>
        /// 根据ID,返回一个T_RepairUnit对象
        /// </summary>
        /// <param name="unitID">unitID</param>
        /// <returns>T_RepairUnit对象</returns>
        public T_RepairUnitEntity Get_T_RepairUnitEntity(string unitID)
        {
            T_RepairUnitEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@UnitID",SqlDbType.VarChar)
			};
            _param[0].Value = unitID;
            string sqlStr = "select * from T_RepairUnit with(nolock) where UnitID=@UnitID";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_T_RepairUnitEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 得到数据表T_RepairUnit所有记录
        /// </summary>
        /// <returns>数据集</returns>
        public IList<T_RepairUnitEntity> Get_T_RepairUnitAll()
        {
            IList<T_RepairUnitEntity> Obj = new List<T_RepairUnitEntity>();
            string sqlStr = "select * from T_RepairUnit";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_T_RepairUnitEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 检测是否存在根据主键
        /// </summary>
        /// <param name="unitID">unitID</param>
        /// <returns>是/否</returns>
        public bool IsExistT_RepairUnit(string unitID)
        {
            SqlParameter[] _param ={
                                      new SqlParameter("@unitID",SqlDbType.VarChar)
                                  };
            _param[0].Value = unitID;
            string sqlStr = "select Count(*) from T_RepairUnit where UnitID=@unitID";
            int a = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param));
            if (a > 0)
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
