// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairDocument.cs
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
	///T_RepairDocument数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_RepairDocumentEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _iD;
		///<summary>
		///
		///</summary>
		private string _cardKey = String.Empty;
		///<summary>
		///工单号码
		///</summary>
		private string _repairNumber = String.Empty;
		///<summary>
		///车主单位
		///</summary>
		private string _autoUnit = String.Empty;
		///<summary>
		///送修人
		///</summary>
		private string _repairMan = String.Empty;
		///<summary>
		///
		///</summary>
		private string _plateNumber = String.Empty;
		///<summary>
		///厂牌型号
		///</summary>
		private string _autoBrand = String.Empty;
		///<summary>
		///
		///</summary>
		private string _vIN = String.Empty;
		///<summary>
		///
		///</summary>
		private string _engineNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _chassisNumber = String.Empty;
		///<summary>
		///
		///</summary>
		private string _carColor = String.Empty;
		///<summary>
		///
		///</summary>
		private string _plateColor = String.Empty;
		///<summary>
		///
		///</summary>
		private string _autoType = String.Empty;
		///<summary>
		///维修类别
		///</summary>
		private string _repairSort = String.Empty;
		///<summary>
		///
		///</summary>
		private string _waiter = String.Empty;
		///<summary>
		///
		///</summary>
		private string _checkMan = String.Empty;
		///<summary>
		///进厂日期
		///</summary>
		private DateTime _signDate;
		///<summary>
		///
		///</summary>
		private DateTime _finishDate;
		///<summary>
		///合同编号
		///</summary>
		private string _contractNumber = String.Empty;
		///<summary>
		///合格证号
		///</summary>
		private string _certificateNumber = String.Empty;
		///<summary>
		///出厂里程
		///</summary>
		private string _mileage = String.Empty;
		///<summary>
		///
		///</summary>
		private string _oil = String.Empty;
		///<summary>
		///托修方电话
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///承修方编号
		///</summary>
		private string _unitID = String.Empty;
		///<summary>
		///承修方名字
		///</summary>
		private string _unitName = String.Empty;
		///<summary>
		///承修方电话
		///</summary>
		private string _unitPhone = String.Empty;
		///<summary>
		///承修方地址
		///</summary>
		private string _unitAddress = String.Empty;
		///<summary>
		///承修方邮箱
		///</summary>
		private string _email = String.Empty;
		///<summary>
		///开户银行
		///</summary>
		private string _bankName = String.Empty;
		///<summary>
		///银行帐号
		///</summary>
		private string _bankID = String.Empty;
		///<summary>
		///维修诊断费
		///</summary>
		private decimal _zDF;
		///<summary>
		///检测费
		///</summary>
		private decimal _jCF;
		///<summary>
		///工时费
		///</summary>
		private decimal _gSF;
		///<summary>
		///材料费
		///</summary>
		private decimal _cLF;
		///<summary>
		///加工费
		///</summary>
		private decimal _jGF;
		///<summary>
		///其它费用
		///</summary>
		private decimal _qTF;
		///<summary>
		///合计金额
		///</summary>
		private decimal _totalMoney;
		///<summary>
		///备注
		///</summary>
		private string _remark = String.Empty;
		///<summary>
		///
		///</summary>
		private string _checkResult = String.Empty;
		///<summary>
		///
		///</summary>
		private string _hGZH = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _uploadTime;
		///<summary>
		///质保里程
		///</summary>
		private string _zBLC = String.Empty;
		///<summary>
		///质保日期
		///</summary>
		private string _zBRQ = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_RepairDocumentEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_RepairDocumentEntity
		(
			int iD,
			string cardKey,
			string repairNumber,
			string autoUnit,
			string repairMan,
			string plateNumber,
			string autoBrand,
			string vIN,
			string engineNumber,
			string chassisNumber,
			string carColor,
			string plateColor,
			string autoType,
			string repairSort,
			string waiter,
			string checkMan,
			DateTime signDate,
			DateTime finishDate,
			string contractNumber,
			string certificateNumber,
			string mileage,
			string oil,
			string phone,
			string unitID,
			string unitName,
			string unitPhone,
			string unitAddress,
			string email,
			string bankName,
			string bankID,
			decimal zDF,
			decimal jCF,
			decimal gSF,
			decimal cLF,
			decimal jGF,
			decimal qTF,
			decimal totalMoney,
			string remark,
			string checkResult,
			string hGZH,
			DateTime uploadTime,
			string zBLC,
			string zBRQ
		)
		{
			_iD                = iD;
			_cardKey           = cardKey;
			_repairNumber      = repairNumber;
			_autoUnit          = autoUnit;
			_repairMan         = repairMan;
			_plateNumber       = plateNumber;
			_autoBrand         = autoBrand;
			_vIN               = vIN;
			_engineNumber      = engineNumber;
			_chassisNumber     = chassisNumber;
			_carColor          = carColor;
			_plateColor        = plateColor;
			_autoType          = autoType;
			_repairSort        = repairSort;
			_waiter            = waiter;
			_checkMan          = checkMan;
			_signDate          = signDate;
			_finishDate        = finishDate;
			_contractNumber    = contractNumber;
			_certificateNumber = certificateNumber;
			_mileage           = mileage;
			_oil               = oil;
			_phone             = phone;
			_unitID            = unitID;
			_unitName          = unitName;
			_unitPhone         = unitPhone;
			_unitAddress       = unitAddress;
			_email             = email;
			_bankName          = bankName;
			_bankID            = bankID;
			_zDF               = zDF;
			_jCF               = jCF;
			_gSF               = gSF;
			_cLF               = cLF;
			_jGF               = jGF;
			_qTF               = qTF;
			_totalMoney        = totalMoney;
			_remark            = remark;
			_checkResult       = checkResult;
			_hGZH              = hGZH;
			_uploadTime        = uploadTime;
			_zBLC              = zBLC;
			_zBRQ              = zBRQ;
			
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
		public string CardKey
		{
			get {return _cardKey;}
			set {_cardKey = value;}
		}

		///<summary>
		///工单号码
		///</summary>
		[DataMember]
		public string RepairNumber
		{
			get {return _repairNumber;}
			set {_repairNumber = value;}
		}

		///<summary>
		///车主单位
		///</summary>
		[DataMember]
		public string AutoUnit
		{
			get {return _autoUnit;}
			set {_autoUnit = value;}
		}

		///<summary>
		///送修人
		///</summary>
		[DataMember]
		public string RepairMan
		{
			get {return _repairMan;}
			set {_repairMan = value;}
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
		///厂牌型号
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
		public string VIN
		{
			get {return _vIN;}
			set {_vIN = value;}
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
		public string ChassisNumber
		{
			get {return _chassisNumber;}
			set {_chassisNumber = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CarColor
		{
			get {return _carColor;}
			set {_carColor = value;}
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
		public string AutoType
		{
			get {return _autoType;}
			set {_autoType = value;}
		}

		///<summary>
		///维修类别
		///</summary>
		[DataMember]
		public string RepairSort
		{
			get {return _repairSort;}
			set {_repairSort = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Waiter
		{
			get {return _waiter;}
			set {_waiter = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CheckMan
		{
			get {return _checkMan;}
			set {_checkMan = value;}
		}

		///<summary>
		///进厂日期
		///</summary>
		[DataMember]
		public DateTime SignDate
		{
			get {return _signDate;}
			set {_signDate = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime FinishDate
		{
			get {return _finishDate;}
			set {_finishDate = value;}
		}

		///<summary>
		///合同编号
		///</summary>
		[DataMember]
		public string ContractNumber
		{
			get {return _contractNumber;}
			set {_contractNumber = value;}
		}

		///<summary>
		///合格证号
		///</summary>
		[DataMember]
		public string CertificateNumber
		{
			get {return _certificateNumber;}
			set {_certificateNumber = value;}
		}

		///<summary>
		///出厂里程
		///</summary>
		[DataMember]
		public string Mileage
		{
			get {return _mileage;}
			set {_mileage = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string Oil
		{
			get {return _oil;}
			set {_oil = value;}
		}

		///<summary>
		///托修方电话
		///</summary>
		[DataMember]
		public string Phone
		{
			get {return _phone;}
			set {_phone = value;}
		}

		///<summary>
		///承修方编号
		///</summary>
		[DataMember]
		public string UnitID
		{
			get {return _unitID;}
			set {_unitID = value;}
		}

		///<summary>
		///承修方名字
		///</summary>
		[DataMember]
		public string UnitName
		{
			get {return _unitName;}
			set {_unitName = value;}
		}

		///<summary>
		///承修方电话
		///</summary>
		[DataMember]
		public string UnitPhone
		{
			get {return _unitPhone;}
			set {_unitPhone = value;}
		}

		///<summary>
		///承修方地址
		///</summary>
		[DataMember]
		public string UnitAddress
		{
			get {return _unitAddress;}
			set {_unitAddress = value;}
		}

		///<summary>
		///承修方邮箱
		///</summary>
		[DataMember]
		public string Email
		{
			get {return _email;}
			set {_email = value;}
		}

		///<summary>
		///开户银行
		///</summary>
		[DataMember]
		public string BankName
		{
			get {return _bankName;}
			set {_bankName = value;}
		}

		///<summary>
		///银行帐号
		///</summary>
		[DataMember]
		public string BankID
		{
			get {return _bankID;}
			set {_bankID = value;}
		}

		///<summary>
		///维修诊断费
		///</summary>
		[DataMember]
		public decimal ZDF
		{
			get {return _zDF;}
			set {_zDF = value;}
		}

		///<summary>
		///检测费
		///</summary>
		[DataMember]
		public decimal JCF
		{
			get {return _jCF;}
			set {_jCF = value;}
		}

		///<summary>
		///工时费
		///</summary>
		[DataMember]
		public decimal GSF
		{
			get {return _gSF;}
			set {_gSF = value;}
		}

		///<summary>
		///材料费
		///</summary>
		[DataMember]
		public decimal CLF
		{
			get {return _cLF;}
			set {_cLF = value;}
		}

		///<summary>
		///加工费
		///</summary>
		[DataMember]
		public decimal JGF
		{
			get {return _jGF;}
			set {_jGF = value;}
		}

		///<summary>
		///其它费用
		///</summary>
		[DataMember]
		public decimal QTF
		{
			get {return _qTF;}
			set {_qTF = value;}
		}

		///<summary>
		///合计金额
		///</summary>
		[DataMember]
		public decimal TotalMoney
		{
			get {return _totalMoney;}
			set {_totalMoney = value;}
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
		///
		///</summary>
		[DataMember]
		public string CheckResult
		{
			get {return _checkResult;}
			set {_checkResult = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string HGZH
		{
			get {return _hGZH;}
			set {_hGZH = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime UploadTime
		{
			get {return _uploadTime;}
			set {_uploadTime = value;}
		}

		///<summary>
		///质保里程
		///</summary>
		[DataMember]
		public string ZBLC
		{
			get {return _zBLC;}
			set {_zBLC = value;}
		}

		///<summary>
		///质保日期
		///</summary>
		[DataMember]
		public string ZBRQ
		{
			get {return _zBRQ;}
			set {_zBRQ = value;}
		}
	
		#endregion
		
	}
}
