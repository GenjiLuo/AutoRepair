using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Jnwf.Utils.Data;



/// <summary>
/// DAL 的摘要说明
/// </summary>
public class DAL
{
    #region Model

    /// <summary>
    /// 主菜单
    /// </summary>
    public class tb_MenuEntity
    {
        public tb_MenuEntity() { }
        private int _id;
        private int _parentid;
        private string _menuname;
        private string _url;
        private int _type;
        public tb_MenuEntity(int id, int parentid,
            string menuname, string url, int type)
        {
            id = this._id;
            parentid = this._parentid;
            menuname = this._menuname;
            url = this._url;
            type = this._type;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ParentId
        {
            get { return _parentid; }
            set { _parentid = value; }
        }
        public string Menuname
        {
            get { return _menuname; }
            set { _menuname = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        /// <summary>
        /// 1：文章 2：列表
        /// </summary>
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
    /// <summary>
    /// 文章
    /// </summary>
    public class tb_articleEntity
    {
        public tb_articleEntity() { }
        private int _id;
        private string _title;
        private string _author;
        private string _content;
        private int _status;
        private DateTime _addtime;
        private DateTime _updatetime;
        public tb_articleEntity(int id, string title, string author, string content, int status, DateTime addtime, DateTime updatetime)
        {
            id = this._id;
            title = this._title;
            author = this._author;
            content = this._content;
            status = this._status;
            addtime = this._addtime;
            updatetime = this._updatetime;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime AddTime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
        public DateTime UpdateTiem
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class tb_Menu_articleEntity
    {
        public tb_Menu_articleEntity() { }
        private int _id;
        private int _menuid;
        private int _articleid;
        private DateTime _addtime;
        public tb_Menu_articleEntity(int id, int menuid, int articleid, DateTime addtime)
        {
            id = this._id;
            menuid = this._menuid;
            articleid = this._articleid;
            addtime = this._addtime;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int MenuId
        {
            get { return _menuid; }
            set { _menuid = value; }
        }
        public int articleId
        {
            get { return _articleid; }
            set { _articleid = value; }
        }
        public DateTime AddTime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }
    }
    #endregion

    #region DAL
    public DAL(){}
    #region 文章内容
    public static tb_articleEntity Populate_tb_articleEntity_FromDr(IDataReader dr)
    {
        tb_articleEntity Obj = new tb_articleEntity();
            Obj.Id = ((dr["id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]);
            Obj.Title = dr["title"].ToString();
            Obj.Author = dr["author"].ToString();
            Obj.Content = dr["content"].ToString();
            Obj.Status = ((dr["status"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["status"]);
            Obj.AddTime = ((dr["addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["addtime"]);
            Obj.UpdateTiem = ((dr["updatetime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["updatetime"]);
         return Obj;
    }
    public static int Insertarticle(tb_articleEntity _tb_article)
    {
        string sqlStr = "  insert into tb_article([Title],[Author],[Content],[Status],[Addtime],[Updatetime]) values(@Title,@Author,@Content,@Status,@Addtime,@Updatetime) select @@identity";
        int res;
        SqlParameter[] _param = {
              new SqlParameter("@Title",SqlDbType.VarChar),
              new SqlParameter("@Author",SqlDbType.VarChar),
              new SqlParameter("@Content",SqlDbType.VarChar),
              new SqlParameter("@Status",SqlDbType.Int),
              new SqlParameter("@Addtime",SqlDbType.DateTime),
              new SqlParameter("@Updatetime",SqlDbType.DateTime)
          };
        _param[0].Value = _tb_article.Title;
        _param[1].Value = _tb_article.Author;
        _param[2].Value = _tb_article.Content;
        _param[3].Value = _tb_article.Status;
        _param[4].Value = _tb_article.AddTime;
        _param[5].Value = _tb_article.UpdateTiem;
        res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.ExamRW, CommandType.Text, sqlStr, _param));
        return res;
    }
    public static int Deletearticle(int id)
    {
        string sqlStr = "delete from tb_article where id = @Id";
        SqlParameter[] _param = {
                  new SqlParameter("@Id",SqlDbType.Int)
           };
        _param[0].Value = id;
        return SqlHelper.ExecuteNonQuery(WebConfig.ExamRW, CommandType.Text, sqlStr, _param);
    }
    public static int Updatearticle(tb_articleEntity _tb_article)
    {
        string sqlStr = "update tb_article set [Title] = @Title,[Author] = @Author,[Content] = @Content,[Status] = @Status,[Addtime] = @Addtime,[Updatetime] = @Addtime where id = @Id";
        SqlParameter[] _param = {
              new SqlParameter("@Title",SqlDbType.VarChar),
              new SqlParameter("@Author",SqlDbType.VarChar),
              new SqlParameter("@Content",SqlDbType.VarChar),
              new SqlParameter("@Status",SqlDbType.Int),
              new SqlParameter("@Addtime",SqlDbType.DateTime),
              new SqlParameter("@Updatetime",SqlDbType.DateTime),
              new SqlParameter("@id",SqlDbType.Int)
          };
        _param[0].Value = _tb_article.Title;
        _param[1].Value = _tb_article.Author;
        _param[2].Value = _tb_article.Content;
        _param[3].Value = _tb_article.Status;
        _param[4].Value = _tb_article.AddTime;
        _param[5].Value = _tb_article.UpdateTiem;
        _param[6].Value = _tb_article.Id;
        return SqlHelper.ExecuteNonQuery(WebConfig.ExamRW, CommandType.Text, sqlStr, _param);
    }
    public static tb_articleEntity Get_tb_articleEntity(int id)
    {
        tb_articleEntity _obj = null;
        SqlParameter[] _param = {
                new SqlParameter("@Id",SqlDbType.Int)
           };
        _param[0].Value = id;
        string sqlStr = "SELECT * FROM [sharecms].[dbo].[tb_article]  with(nolock)  where id = @Id ";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr, _param))
        {
            while (dr.Read())
            {
                _obj = Populate_tb_articleEntity_FromDr(dr);
            }
        }
        return _obj;
    }
    public static tb_articleEntity GetarticleEntityByTitle(string title)
    {
        tb_articleEntity _obj = null;
        SqlParameter[] _param = {
                new SqlParameter("@Title",SqlDbType.VarChar)
           };
        _param[0].Value = title;
        string sqlStr = "SELECT * FROM [sharecms].[dbo].[tb_article]  with(nolock)  where [Title] = @Title ";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr, _param))
        {
            while (dr.Read())
            {
                _obj = Populate_tb_articleEntity_FromDr(dr);
            }
        }
        return _obj;
    }
    public static IList<tb_articleEntity> Get_tb_articleList()
    {
        IList<tb_articleEntity> Obj = new List<tb_articleEntity>();
        string sqlStr = "SELECT * FROM tb_article where status = 1 order by  addtime desc";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr))
        {
            while (dr.Read())
            {
                Obj.Add(Populate_tb_articleEntity_FromDr(dr));
            }
        }
        return Obj;
    }
    /// <summary>
    /// 新的分页获取数据
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="fieldName"></param>
    /// <param name="pageSize"></param>
    /// <param name="currentPage"></param>
    /// <param name="sortField">排序字段和排序方向,如:SortA DESC；此字段为""时,默认按主键倒序排</param>
    /// <param name="condition"></param>
    /// <param name="primaryKey"></param>
    /// <param name="totalCount">查询到的总记录数</param>  
    /// <returns></returns>
    public static DataSet GetDataByPage(
        string tableName,
        string primaryKey,
        string sortField,
        int currentPage,
        int pageSize,
        string fieldName,
        string condition,

        out int totalCount
        )
    {
        SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@viewName", SqlDbType.NVarChar),
                new SqlParameter("@keyName", SqlDbType.NVarChar),
                new SqlParameter("@orderString", SqlDbType.NVarChar),
                new SqlParameter("@pageNo", SqlDbType.Int),
                new SqlParameter("@pageSize", SqlDbType.Int),
                new SqlParameter("@fieldName", SqlDbType.NVarChar),
                new SqlParameter("@whereString", SqlDbType.NVarChar),
                new SqlParameter("@recordTotal", SqlDbType.Int)
            };
        paras[0].Value = tableName;
        paras[1].Value = primaryKey;
        paras[2].Value = sortField;
        paras[3].Value = currentPage;
        paras[4].Value = pageSize;
        paras[5].Value = fieldName;
        paras[6].Value = condition;

        paras[7].Direction = ParameterDirection.Output;

        DataSet ds = new DataSet();
        ds = Jnwf.Utils.Data.SqlHelper.ExecuteDataset(WebConfig.ExamRW, CommandType.StoredProcedure, "P_GridViewPager", paras);

        totalCount = Convert.ToInt32(paras[7].Value);

        return ds;
    }

    #endregion

    #region 菜单设置
    public static tb_MenuEntity Populate_tb_MenuEntity_FromDr(IDataReader dr)
    {
        tb_MenuEntity Obj = new tb_MenuEntity();
            Obj.Id = ((dr["id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]);
            Obj.ParentId = ((dr["parentid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["parentid"]);
            Obj.Menuname = dr["menuname"].ToString();
            Obj.Url = dr["url"].ToString();
            Obj.Type = ((dr["type"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["type"]);
        return Obj;
    }
    public static int InsertMenu(tb_MenuEntity _tb_MenuEntity)
    {
        string sqlStr = "insert into tb_Menu([parentid],[menuname],[url],[type]) values(@ParentId,@MenuName,@Url,@Type) select @@identity";
        int res;
        SqlParameter[] _param = {
              new SqlParameter("@ParentId",SqlDbType.Int),
              new SqlParameter("@MenuName",SqlDbType.VarChar),
              new SqlParameter("@Url",SqlDbType.VarChar),
              new SqlParameter("@Type",SqlDbType.Int)
          };
        _param[0].Value = _tb_MenuEntity.ParentId;
        _param[1].Value = _tb_MenuEntity.Menuname;
        _param[2].Value = _tb_MenuEntity.Url;
        _param[3].Value = _tb_MenuEntity.Type;
        res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.ExamRW, CommandType.Text, sqlStr, _param));
        return res;
    }
    public static int DeleteMenu(int id)
    {
        string sqlStr = "delete from tb_Menu where id = @Id";
        SqlParameter[] _param = {
                  new SqlParameter("@Id",SqlDbType.Int)
           };
        _param[0].Value = id;
        return SqlHelper.ExecuteNonQuery(WebConfig.ExamRW, CommandType.Text, sqlStr, _param);
    }
    public static int UpdateMenu(tb_MenuEntity _tb_Menu)
    {
        string sqlStr = "update tb_Menu set [parentid] = @ParentId,[menuname] = @MenuName,[url] = @Url,[type] = @Type where id = @Id";
        SqlParameter[] _param = {
              new SqlParameter("@ParentId",SqlDbType.Int),
              new SqlParameter("@MenuName",SqlDbType.VarChar),
              new SqlParameter("@Url",SqlDbType.VarChar),
              new SqlParameter("@Type",SqlDbType.Int),
              new SqlParameter("@Id",SqlDbType.Int)
          };
        _param[0].Value = _tb_Menu.ParentId;
        _param[1].Value = _tb_Menu.Menuname;
        _param[2].Value = _tb_Menu.Url;
        _param[3].Value = _tb_Menu.Type;
        _param[4].Value = _tb_Menu.Id;
        return SqlHelper.ExecuteNonQuery(WebConfig.ExamRW, CommandType.Text, sqlStr, _param);
    }
    public static tb_MenuEntity Get_tb_MenuEntity(int id)
    {
        tb_MenuEntity _obj = null;
        SqlParameter[] _param = {
                new SqlParameter("@Id",SqlDbType.Int)
           };
        _param[0].Value = id;
        string sqlStr = "SELECT * FROM tb_Menu  with(nolock)  where id = @Id ";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr, _param))
        {
            while (dr.Read())
            {
                _obj = Populate_tb_MenuEntity_FromDr(dr);
            }
        }
        return _obj;
    }
    public static IList<tb_MenuEntity> GetMenuListByParentId(int parentId)
    {
        IList<tb_MenuEntity> Obj = new List<tb_MenuEntity>();
        SqlParameter[] _param = {
                new SqlParameter("@ParentId",SqlDbType.Int)
           };
        _param[0].Value = parentId;
        string sqlStr = "SELECT * FROM tb_Menu  with(nolock)  where parentid = @ParentId";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr, _param))
        {
            while(dr.Read())
            {
                Obj.Add(Populate_tb_MenuEntity_FromDr(dr));
            }
        }
        return Obj;
    }
    public static IList<tb_MenuEntity> Get_tb_MenuList()
    {
        IList<tb_MenuEntity> Obj = new List<tb_MenuEntity>();
        string sqlStr = "SELECT * FROM tb_Menu";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr))
        {
            while (dr.Read())
            {
                Obj.Add(Populate_tb_MenuEntity_FromDr(dr));
            }
        }
        return Obj;
    }
    #endregion

    #region 文章菜单
    public static tb_Menu_articleEntity Populate_tb_Menu_articleEntity_FromDr(IDataReader dr)
    {
        tb_Menu_articleEntity Obj = new tb_Menu_articleEntity();
            Obj.Id = ((dr["id"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["id"]);
            Obj.MenuId = ((dr["menuid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["menuid"]);
            Obj.articleId = ((dr["articleid"]) == DBNull.Value) ? 0 : Convert.ToInt32(dr["articleid"]);
            Obj.AddTime = ((dr["addtime"]) == DBNull.Value) ? Convert.ToDateTime("1900-1-1") : Convert.ToDateTime(dr["addtime"]);
        return Obj;
    }
    public static int InsertMenu_articleEntity(tb_Menu_articleEntity _tb_Menu_articleEntity)
    {
        string sqlStr = "insert into tb_Menu_article([menuid],[articleid],[addtime]) values(@MenuId,@articleId,@Addtime) select @@identity";
        int res;
        SqlParameter[] _param = {
              new SqlParameter("@MenuId",SqlDbType.Int),
              new SqlParameter("@articleId",SqlDbType.Int),
              new SqlParameter("@Addtime",SqlDbType.DateTime)
          };
        _param[0].Value = _tb_Menu_articleEntity.MenuId;
        _param[1].Value = _tb_Menu_articleEntity.articleId;
        _param[2].Value = _tb_Menu_articleEntity.AddTime;
        res = Convert.ToInt32(SqlHelper.ExecuteScalar(WebConfig.ExamRW, CommandType.Text, sqlStr, _param));
        return res;
    }
    public static int DeleteMenu_articleEntity(int id)
    {
        string sqlStr = "delete from tb_Menu_article where id = @Id";
        SqlParameter[] _param = {
                  new SqlParameter("@Id",SqlDbType.Int)
           };
        _param[0].Value = id;
        return SqlHelper.ExecuteNonQuery(WebConfig.ExamRW, CommandType.Text, sqlStr, _param);
    }
    public static int UpdateMenu_article(tb_Menu_articleEntity _tb_Menu_article)
    {
        string sqlStr = "update tb_Menu_article set [menuid] = @MenuId,[articleid] = @articleId,[addtime] = @AddTime where id = @Id";
        SqlParameter[] _param = {
              new SqlParameter("@MenuId",SqlDbType.Int),
              new SqlParameter("@articleId",SqlDbType.Int),
              new SqlParameter("@AddTime",SqlDbType.DateTime),
              new SqlParameter("@Id",SqlDbType.Int)
          };
        _param[0].Value = _tb_Menu_article.MenuId;
        _param[1].Value = _tb_Menu_article.articleId;
        _param[2].Value = _tb_Menu_article.AddTime;
        _param[3].Value = _tb_Menu_article.Id;
        return SqlHelper.ExecuteNonQuery(WebConfig.ExamRW, CommandType.Text, sqlStr, _param);
    }
    public static tb_Menu_articleEntity Get_tb_Menu_articleEntity(int id)
    {
        tb_Menu_articleEntity _obj = null;
        SqlParameter[] _param = {
                new SqlParameter("@Id",SqlDbType.Int)
           };
        _param[0].Value = id;
        string sqlStr = "SELECT * FROM tb_Menu_article  with(nolock)  where id = @Id ";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr, _param))
        {
            while (dr.Read())
            {
                _obj = Populate_tb_Menu_articleEntity_FromDr(dr);
            }
        }
        return _obj;
    }
    public static IList<tb_Menu_articleEntity> GetMenuArticleListByMenuId(int menuId)
    {
        IList<tb_Menu_articleEntity> list = new List<tb_Menu_articleEntity>();
        SqlParameter[] _param = { new SqlParameter("@MenuId", SqlDbType.Int) };
        _param[0].Value = menuId;
        string sqlStr="select * from tb_Menu_Article with(nolock) where menuid = @MenuId";
        using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.ExamRW, CommandType.Text, sqlStr, _param))
        {
            while (dr.Read())
            {
                list.Add(Populate_tb_Menu_articleEntity_FromDr(dr));
            }
        }
        return list;
    }
    #endregion
    #endregion
}
public class BLL
{
    #region 文章
    public static int Isenterarticle(DAL.tb_articleEntity tb_articleEntity)
    {
        return DAL.Insertarticle(tb_articleEntity);
    }
    public static int Detearticle(int id)
    {
        return DAL.Deletearticle(id);
    }
    public static int Updatearticle(DAL.tb_articleEntity tb_articleEntity)
    {
        return DAL.Updatearticle(tb_articleEntity);
    }
    public static DAL.tb_articleEntity Get_tb_articleEntity(int id)
    {
        return DAL.Get_tb_articleEntity(id);
    }
    public static IList<DAL.tb_articleEntity> Get_tb_articleList()
    {
        return DAL.Get_tb_articleList();
    }
    public static DAL.tb_articleEntity GetArticleEntityByTitle(string title)
    {
        return DAL.GetarticleEntityByTitle(title);
    }
    /// <summary>
    /// 分页
    /// </summary>
    /// <param name="pagesize"></param>
    /// <param name="currentindex"></param>
    /// <param name="condition"></param>
    /// <param name="allcount"></param>
    /// <returns></returns>
    public static DataSet GetList(int pagesize, int currentindex, string condition, out int allcount)
    {
        return DAL.GetDataByPage("tb_Article", "Id", "Addtime desc", currentindex, pagesize, "*", condition, out allcount);
    }
    #endregion

    #region 菜单
    public static int InsertMenu(DAL.tb_MenuEntity tb_MenuEntity)
    {
        return DAL.InsertMenu(tb_MenuEntity);
    }
    public static int DeteMenu(int id)
    {
        return DAL.DeleteMenu(id);
    }
    public static int UpdateMenu(DAL.tb_MenuEntity tb_MenuEntity)
    {
        return DAL.UpdateMenu(tb_MenuEntity);
    }
    public static DAL.tb_MenuEntity Get_tb_MenuEntity(int id)
    {
        return DAL.Get_tb_MenuEntity(id);
    }
    public static IList<DAL.tb_MenuEntity> GetMenuListByParentId(int parentId)
    {
        return DAL.GetMenuListByParentId(parentId);
    }
    public static IList<DAL.tb_MenuEntity> Get_tb_MenuList()
    {
        return DAL.Get_tb_MenuList();
    }
    #endregion

    #region 菜单文章
    public static int InsertMenu_articleEntity(DAL.tb_Menu_articleEntity tb_Menu_articleEntity)
    {
        return DAL.InsertMenu_articleEntity(tb_Menu_articleEntity);
    }
    public static int DeleteMenu_articleEntity(int id)
    {
        return DAL.DeleteMenu_articleEntity(id);
    }
    public static int UpdateMenu_article(DAL.tb_Menu_articleEntity tb_Menu_articleEntity)
    {
        return DAL.UpdateMenu_article(tb_Menu_articleEntity);
    }
    public static DAL.tb_Menu_articleEntity Get_tb_Menu_articleEntity(int id)
    {
        return DAL.Get_tb_Menu_articleEntity(id);
    }
    public static IList<DAL.tb_Menu_articleEntity> GetMenuArticleListByMenuId(int menuId)
    {
        return DAL.GetMenuArticleListByMenuId(menuId);
    } 
    #endregion
}