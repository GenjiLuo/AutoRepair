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
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace AutoRepair.Entity
{
	/// <summary>
	///T_RepairUnit数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_RepairUnitEntity
	{
		#region 变量定义
		///<summary>
		///企业代码手动生成
		///</summary>
		private string _unitID;
		///<summary>
		///单位名称
		///</summary>
		private string _unitName = String.Empty;
		///<summary>
		///负责人
		///</summary>
		private string _linkMan = String.Empty;
		///<summary>
		///电话
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///地址
		///</summary>
		private string _address = String.Empty;
		///<summary>
		///税号
		///</summary>
		private string _taxNumber = String.Empty;
		///<summary>
		///工商执照
		///</summary>
		private string _iCNumber = String.Empty;
		///<summary>
		///管理密码
		///</summary>
		private string _adminPwd = String.Empty;
		///<summary>
		///备注
		///</summary>
		private string _remark = String.Empty;
		///<summary>
		///所在地区
		///</summary>
		private string _area = String.Empty;
		///<summary>
		///状态正常 失效
		///</summary>
		private string _unitState = String.Empty;
		///<summary>
		///
		///</summary>
		private string _usbKey = String.Empty;
		///<summary>
		///
		///</summary>
		private string _authToken = String.Empty;
        private decimal _lag;
        private decimal _lat;
        ///<summary>
        ///
        ///</summary>
        private string _crerating = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _categories = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _range = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_RepairUnitEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_RepairUnitEntity
		(
			string unitID,
			string unitName,
			string linkMan,
			string phone,
			string address,
			string taxNumber,
			string iCNumber,
			string adminPwd,
			string remark,
			string area,
			string unitState,
			string usbKey,
			string authToken,
            decimal lag,
            decimal lat,
            string crerating,
            string categories,
            string range
		)
		{
			_unitID    = unitID;
			_unitName  = unitName;
			_linkMan   = linkMan;
			_phone     = phone;
			_address   = address;
			_taxNumber = taxNumber;
			_iCNumber  = iCNumber;
			_adminPwd  = adminPwd;
			_remark    = remark;
			_area      = area;
			_unitState = unitState;
			_usbKey    = usbKey;
			_authToken = authToken;
            _lag = lag;
            _lat = lat;
            _crerating = crerating;
            _categories = categories;
            _range = range;
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///企业代码手动生成
		///</summary>
		[DataMember]
		public string UnitID
		{
			get {return _unitID;}
			set {_unitID = value;}
		}

		///<summary>
		///单位名称
		///</summary>
		[DataMember]
		public string UnitName
		{
			get {return _unitName;}
			set {_unitName = value;}
		}

		///<summary>
		///负责人
		///</summary>
		[DataMember]
		public string LinkMan
		{
			get {return _linkMan;}
			set {_linkMan = value;}
		}

		///<summary>
		///电话
		///</summary>
		[DataMember]
		public string Phone
		{
			get {return _phone;}
			set {_phone = value;}
		}

		///<summary>
		///地址
		///</summary>
		[DataMember]
		public string Address
		{
			get {return _address;}
			set {_address = value;}
		}

		///<summary>
		///税号
		///</summary>
		[DataMember]
		public string TaxNumber
		{
			get {return _taxNumber;}
			set {_taxNumber = value;}
		}

		///<summary>
		///工商执照
		///</summary>
		[DataMember]
		public string ICNumber
		{
			get {return _iCNumber;}
			set {_iCNumber = value;}
		}

		///<summary>
		///管理密码
		///</summary>
		[DataMember]
		public string AdminPwd
		{
			get {return _adminPwd;}
			set {_adminPwd = value;}
		}

		///<summary>
		///备注
		///</summary>
		[DataMember]
		public string Remark
		{
			get {return _remark;}
			set {_remark = value;}
		}

		///<summary>
		///所在地区
		///</summary>
		[DataMember]
		public string Area
		{
			get {return _area;}
			set {_area = value;}
		}

		///<summary>
		///状态正常 失效
		///</summary>
		[DataMember]
		public string UnitState
		{
			get {return _unitState;}
			set {_unitState = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string UsbKey
		{
			get {return _usbKey;}
			set {_usbKey = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AuthToken
		{
			get {return _authToken;}
			set {_authToken = value;}
		}
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public decimal Lag
        {
            get { return _lag; }
            set { _lag = value; }
        }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public decimal Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        ///<summary>
        ///
        ///</summary>
        public string Crerating
        {
            get { return _crerating; }
            set { _crerating = value; }
        }
        ///<summary>
        ///
        ///</summary>
        public string Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
        ///<summary>
        ///
        ///</summary>
        public string Range
        {
            get { return _range; }
            set { _range = value; }
        }
		#endregion
		
	}
}
