// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Evaluate.cs
// 项目名称：买车网
// 创建时间：2016/9/9
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace AutoRepair.Entity
{
	/// <summary>
	///tb_Evaluate数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_EvaluateEntity
	{
		#region 变量定义
		///<summary>
		///Id
		///</summary>
		private int _assessId;
		///<summary>
		///维修记录Id
		///</summary>
		private int _recordsId;
		///<summary>
		///承修方编号
		///</summary>
		private string _unitID = String.Empty;
		///<summary>
		///评价内容
		///</summary>
		private string _assessCount = String.Empty;
		///<summary>
		///维修速度
		///</summary>
		private int _speed;
		///<summary>
		///服务态度
		///</summary>
		private int _attitude;
		///<summary>
		///维修质量
		///</summary>
		private int _quality;
		///<summary>
		///1.评价 2.追评
		///</summary>
		private int _type;
		///<summary>
		///
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addTime;
		///<summary>
		///
		///</summary>
		private string _assessCount2 = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addTime2;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_EvaluateEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_EvaluateEntity
		(
			int assessId,
			int recordsId,
			string unitID,
			string assessCount,
			int speed,
			int attitude,
			int quality,
			int type,
			int status,
			DateTime addTime,
			string assessCount2,
			DateTime addTime2
		)
		{
			_assessId     = assessId;
			_recordsId    = recordsId;
			_unitID       = unitID;
			_assessCount  = assessCount;
			_speed        = speed;
			_attitude     = attitude;
			_quality      = quality;
			_type         = type;
			_status       = status;
			_addTime      = addTime;
			_assessCount2 = assessCount2;
			_addTime2     = addTime2;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///Id
		///</summary>
		[DataMember]
		public int AssessId
		{
			get {return _assessId;}
			set {_assessId = value;}
		}

		///<summary>
		///维修记录Id
		///</summary>
		[DataMember]
		public int RecordsId
		{
			get {return _recordsId;}
			set {_recordsId = value;}
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
		///评价内容
		///</summary>
		[DataMember]
		public string AssessCount
		{
			get {return _assessCount;}
			set {_assessCount = value;}
		}

		///<summary>
		///维修速度
		///</summary>
		[DataMember]
		public int Speed
		{
			get {return _speed;}
			set {_speed = value;}
		}

		///<summary>
		///服务态度
		///</summary>
		[DataMember]
		public int Attitude
		{
			get {return _attitude;}
			set {_attitude = value;}
		}

		///<summary>
		///维修质量
		///</summary>
		[DataMember]
		public int Quality
		{
			get {return _quality;}
			set {_quality = value;}
		}

		///<summary>
		///1.评价 2.追评
		///</summary>
		[DataMember]
		public int Type
		{
			get {return _type;}
			set {_type = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public int Status
		{
			get {return _status;}
			set {_status = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime AddTime
		{
			get {return _addTime;}
			set {_addTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string AssessCount2
		{
			get {return _assessCount2;}
			set {_assessCount2 = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime AddTime2
		{
			get {return _addTime2;}
			set {_addTime2 = value;}
		}
	
		#endregion
		
	}
}
