// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairQT.cs
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
	///T_RepairQT数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class T_RepairQTEntity
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
		public T_RepairQTEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public T_RepairQTEntity
		(
			int iD,
			int documentID,
			string itemName,
			decimal money,
			string remark
		)
		{
			_iD         = iD;
			_documentID = documentID;
			_itemName   = itemName;
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
