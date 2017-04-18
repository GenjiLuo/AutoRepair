// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairCL.cs
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
	///T_RepairCL数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_RepairCLEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _iD;
		///<summary>
		///
		///</summary>
		private int _documentID;
		///<summary>
		///
		///</summary>
		private string _itemName = String.Empty;
		///<summary>
		///
		///</summary>
		private string _autoBrand = String.Empty;
		///<summary>
		///
		///</summary>
		private string _itemUnit = String.Empty;
		///<summary>
		///
		///</summary>
		private decimal _amount;
		///<summary>
		///
		///</summary>
		private decimal _price;
		///<summary>
		///
		///</summary>
		private decimal _money;
		///<summary>
		///
		///</summary>
		private string _remark = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_RepairCLEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_RepairCLEntity
		(
			int iD,
			int documentID,
			string itemName,
			string autoBrand,
			string itemUnit,
			decimal amount,
			decimal price,
			decimal money,
			string remark
		)
		{
			_iD         = iD;
			_documentID = documentID;
			_itemName   = itemName;
			_autoBrand  = autoBrand;
			_itemUnit   = itemUnit;
			_amount     = amount;
			_price      = price;
			_money      = money;
			_remark     = remark;
			
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
		public int DocumentID
		{
			get {return _documentID;}
			set {_documentID = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string ItemName
		{
			get {return _itemName;}
			set {_itemName = value;}
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
		public string ItemUnit
		{
			get {return _itemUnit;}
			set {_itemUnit = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Amount
		{
			get {return _amount;}
			set {_amount = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Price
		{
			get {return _price;}
			set {_price = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public decimal Money
		{
			get {return _money;}
			set {_money = value;}
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
	
		#endregion
		
	}
}
