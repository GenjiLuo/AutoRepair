using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;

namespace AutoRepair.Entity
{
    /// <summary>
    ///wx_OpenInfo数据实体
    /// </summary>
    [Serializable]
    [DataContract]
    public class wx_OpenInfoEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _id;
        ///<summary>
        ///
        ///</summary>
        private string _access_token = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private int _expires_in;
        ///<summary>
        ///
        ///</summary>
        private string _refresh_token = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _openid = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _scope = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private DateTime _addTime;
        ///<summary>
        ///
        ///</summary>
        private DateTime _updateTime;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public wx_OpenInfoEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public wx_OpenInfoEntity
        (
            int id,
            string access_token,
            int expires_in,
            string refresh_token,
            string openid,
            string scope,
            DateTime addTime,
            DateTime updateTime
        )
        {
            _id = id;
            _access_token = access_token;
            _expires_in = expires_in;
            _refresh_token = refresh_token;
            _openid = openid;
            _scope = scope;
            _addTime = addTime;
            _updateTime = updateTime;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string access_token
        {
            get { return _access_token; }
            set { _access_token = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public int expires_in
        {
            get { return _expires_in; }
            set { _expires_in = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string refresh_token
        {
            get { return _refresh_token; }
            set { _refresh_token = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string openid
        {
            get { return _openid; }
            set { _openid = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string scope
        {
            get { return _scope; }
            set { _scope = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public DateTime UpdateTime
        {
            get { return _updateTime; }
            set { _updateTime = value; }
        }

        #endregion

    }
}
