// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairGS.cs
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
	///T_RepairGS数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_RepairGSEntity
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
		private decimal _workTime;
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
		///<summary>
		///
		///</summary>
		private string _repairMan = String.Empty;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public T_RepairGSEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_RepairGSEntity
		(
			int iD,
			int documentID,
			string itemName,
			decimal workTime,
			decimal price,
			decimal money,
			string remark,
			string repairMan
		)
		{
			_iD         = iD;
			_documentID = documentID;
			_itemName   = itemName;
			_workTime   = workTime;
			_price      = price;
			_money      = money;
			_remark     = remark;
			_repairMan  = repairMan;
			
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
		public decimal WorkTime
		{
			get {return _workTime;}
			set {_workTime = value;}
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

		///<summary>
		///
		///</summary>
		[DataMember]
		public string RepairMan
		{
			get {return _repairMan;}
			set {_repairMan = value;}
		}
	
		#endregion
		
	}
}
