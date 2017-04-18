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
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace AutoRepair.Entity
{
	/// <summary>
	///tb_Department数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_DepartmentEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _departmentId;
		///<summary>
		///
		///</summary>
		private string _name = String.Empty;
		///<summary>
		///
		///</summary>
		private string _address = String.Empty;
		///<summary>
		///
		///</summary>
		private int _locationId;
		///<summary>
		///
		///</summary>
		private string _contacts = String.Empty;
		///<summary>
		///
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///
		///</summary>
		private string _userName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _userPwd = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _updatetime;
        ///<summary>
        ///
        ///</summary>
        private string _locationName =String.Empty;
        /// <summary>
        /// 
        /// </summary>
        private int _status;
        /// <summary>
        /// 
        /// </summary>
        private string _permissionNum;

        
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_DepartmentEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_DepartmentEntity
		(
			int departmentId,
			string name,
			string address,
			int locationId,
			string contacts,
			string phone,
			string userName,
			string userPwd,
			DateTime addtime,
			DateTime updatetime,
            string locationName,
            int status,
            string permissionNum
		)
		{
			_departmentId = departmentId;
			_name         = name;
			_address      = address;
			_locationId   = locationId;
			_contacts     = contacts;
			_phone        = phone;
			_userName     = userName;
			_userPwd      = userPwd;
			_addtime      = addtime;
			_updatetime   = updatetime;
            _locationName = locationName;
            _status = status;
            _permissionNum = permissionNum;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int DepartmentId
		{
			get {return _departmentId;}
			set {_departmentId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Name
		{
			get {return _name;}
			set {_name = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Address
		{
			get {return _address;}
			set {_address = value;}
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
		public string Contacts
		{
			get {return _contacts;}
			set {_contacts = value;}
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
		public string UserName
		{
			get {return _userName;}
			set {_userName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string UserPwd
		{
			get {return _userPwd;}
			set {_userPwd = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime Updatetime
		{
			get {return _updatetime;}
			set {_updatetime = value;}
		}
        /// <summary>
        /// 
        /// </summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
        /// <summary>
        /// 许可编号
        /// </summary>
        public string PermissionNum
        {
            get { return _permissionNum; }
            set { _permissionNum = value; }
        }
		#endregion
		
	}
}
