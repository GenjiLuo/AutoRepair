// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Cars.cs
// 项目名称：买车网
// 创建时间：2016/9/8
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace AutoRepair.Entity
{
	/// <summary>
	///tb_Cars数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_CarsEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _carId;
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///
		///</summary>
		private int _carType;
		///<summary>
		///
		///</summary>
		private string _carNum = String.Empty;
		///<summary>
		///
		///</summary>
		private string _carFrameNum = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private int _status;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_CarsEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_CarsEntity
		(
			int carId,
			int userId,
			int carType,
			string carNum,
			string carFrameNum,
			DateTime addtime,
			int status
		)
		{
			_carId       = carId;
			_userId      = userId;
			_carType     = carType;
			_carNum      = carNum;
			_carFrameNum = carFrameNum;
			_addtime     = addtime;
			_status      = status;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int CarId
		{
			get {return _carId;}
			set {_carId = value;}
		}

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
		public int CarType
		{
			get {return _carType;}
			set {_carType = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CarNum
		{
			get {return _carNum;}
			set {_carNum = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string CarFrameNum
		{
			get {return _carFrameNum;}
			set {_carFrameNum = value;}
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
		public int Status
		{
			get {return _status;}
			set {_status = value;}
		}
	
		#endregion
		
	}
}
