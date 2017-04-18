// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
// 项目名称：买车网
// 创建时间：2016/8/29
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace AutoRepair.Entity
{
	/// <summary>
	///tb_Users数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_UsersEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///
		///</summary>
		private string _pwd = String.Empty;
		///<summary>
		///
		///</summary>
		private string _realName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _mail = String.Empty;
		///<summary>
		///
		///</summary>
		private int _locationId;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
        private string _idCard; 
        private int _identityType;
        private string _openID; 
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_UsersEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_UsersEntity
		(
			int userId,
			string phone,
			string pwd,
			string realName,
			string mail,
			int locationId,
			DateTime addtime,
            string idCard,
            int identityType,
            string openID
		)
		{
			_userId     = userId;
			_phone      = phone;
			_pwd        = pwd;
			_realName   = realName;
			_mail       = mail;
			_locationId = locationId;
			_addtime    = addtime;
            _idCard = idCard;
            _identityType = identityType;
            _openID = openID;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int UserId
		{
			get {return _userId;}
			set {_userId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Phone
		{
			get {return _phone;}
			set {_phone = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Pwd
		{
			get {return _pwd;}
			set {_pwd = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string RealName
		{
			get {return _realName;}
			set {_realName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Mail
		{
			get {return _mail;}
			set {_mail = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int LocationId
		{
			get {return _locationId;}
			set {_locationId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Addtime
		{
			get {return _addtime;}
			set {_addtime = value;}
		}
        [DataMember]
        public string IdCard
        {
            get { return _idCard; }
            set { _idCard = value; }
        }
        [DataMember]
        public int IdentityType
        {
            get { return _identityType; }
            set { _identityType = value; }
        }
        [DataMember]
        public string OpenID
        {
            get { return _openID; }
            set { _openID = value; }
        }
		#endregion
		
	}
}
