// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_AutoInfo.cs
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
	///T_AutoInfo数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_AutoInfoEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _iD;
		///<summary>
		///
		///</summary>
		private string _plateNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _plateColor = String.Empty;
		///<summary>
		///
		///</summary>
		private string _vIN = String.Empty;
		///<summary>
		///
		///</summary>
		private string _autoBrand = String.Empty;
		///<summary>
		///
		///</summary>
		private string _autoType = String.Empty;
		///<summary>
		///
		///</summary>
		private string _autoNature = String.Empty;
		///<summary>
		///
		///</summary>
		private string _unitName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _linkMan = String.Empty;
		///<summary>
		///
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///
		///</summary>
		private string _engineNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _autoColor = String.Empty;
		///<summary>
		///
		///</summary>
		private string _chassisNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _remark = String.Empty;
		///<summary>
		///
		///</summary>
		private string _cardNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _unitID = String.Empty;
		///<summary>
		///
		///</summary>
		private string _businessInsuranceCompany = String.Empty;
		///<summary>
		///
		///</summary>
		private string _businessInsuranceNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _businessInsuranceDate;
		///<summary>
		///
		///</summary>
		private string _enforceInsuranceCompany = String.Empty;
		///<summary>
		///
		///</summary>
		private string _enforceInsuranceNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _enforceInsuranceDate;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_AutoInfoEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_AutoInfoEntity
		(
			int iD,
			string plateNumber,
			string plateColor,
			string vIN,
			string autoBrand,
			string autoType,
			string autoNature,
			string unitName,
			string linkMan,
			string phone,
			string engineNumber,
			string autoColor,
			string chassisNumber,
			string remark,
			string cardNumber,
			string unitID,
			string businessInsuranceCompany,
			string businessInsuranceNumber,
			DateTime businessInsuranceDate,
			string enforceInsuranceCompany,
			string enforceInsuranceNumber,
			DateTime enforceInsuranceDate
		)
		{
			_iD                       = iD;
			_plateNumber              = plateNumber;
			_plateColor               = plateColor;
			_vIN                      = vIN;
			_autoBrand                = autoBrand;
			_autoType                 = autoType;
			_autoNature               = autoNature;
			_unitName                 = unitName;
			_linkMan                  = linkMan;
			_phone                    = phone;
			_engineNumber             = engineNumber;
			_autoColor                = autoColor;
			_chassisNumber            = chassisNumber;
			_remark                   = remark;
			_cardNumber               = cardNumber;
			_unitID                   = unitID;
			_businessInsuranceCompany = businessInsuranceCompany;
			_businessInsuranceNumber  = businessInsuranceNumber;
			_businessInsuranceDate    = businessInsuranceDate;
			_enforceInsuranceCompany  = enforceInsuranceCompany;
			_enforceInsuranceNumber   = enforceInsuranceNumber;
			_enforceInsuranceDate     = enforceInsuranceDate;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int ID
		{
			get {return _iD;}
			set {_iD = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string PlateNumber
		{
			get {return _plateNumber;}
			set {_plateNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string PlateColor
		{
			get {return _plateColor;}
			set {_plateColor = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string VIN
		{
			get {return _vIN;}
			set {_vIN = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AutoBrand
		{
			get {return _autoBrand;}
			set {_autoBrand = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AutoType
		{
			get {return _autoType;}
			set {_autoType = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AutoNature
		{
			get {return _autoNature;}
			set {_autoNature = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string UnitName
		{
			get {return _unitName;}
			set {_unitName = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string LinkMan
		{
			get {return _linkMan;}
			set {_linkMan = value;}
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
		public string EngineNumber
		{
			get {return _engineNumber;}
			set {_engineNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AutoColor
		{
			get {return _autoColor;}
			set {_autoColor = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ChassisNumber
		{
			get {return _chassisNumber;}
			set {_chassisNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Remark
		{
			get {return _remark;}
			set {_remark = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CardNumber
		{
			get {return _cardNumber;}
			set {_cardNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string UnitID
		{
			get {return _unitID;}
			set {_unitID = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BusinessInsuranceCompany
		{
			get {return _businessInsuranceCompany;}
			set {_businessInsuranceCompany = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string BusinessInsuranceNumber
		{
			get {return _businessInsuranceNumber;}
			set {_businessInsuranceNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime BusinessInsuranceDate
		{
			get {return _businessInsuranceDate;}
			set {_businessInsuranceDate = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string EnforceInsuranceCompany
		{
			get {return _enforceInsuranceCompany;}
			set {_enforceInsuranceCompany = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string EnforceInsuranceNumber
		{
			get {return _enforceInsuranceNumber;}
			set {_enforceInsuranceNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime EnforceInsuranceDate
		{
			get {return _enforceInsuranceDate;}
			set {_enforceInsuranceDate = value;}
		}
	
		#endregion
		
	}
}
