// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Appeal.cs
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
	///tb_Appeal数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_AppealEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _appealId;
		///<summary>
		///
		///</summary>
		private int _userId;
		///<summary>
		///申诉内容
		///</summary>
		private string _appealCount = String.Empty;
		///<summary>
		///图片1
		///</summary>
		private string _img1 = String.Empty;
		///<summary>
		///图片2
		///</summary>
		private string _img2 = String.Empty;
		///<summary>
		///图片3
		///</summary>
		private string _img3 = String.Empty;
		///<summary>
		///图片4
		///</summary>
		private string _img4 = String.Empty;
		///<summary>
		///图片5
		///</summary>
		private string _img5 = String.Empty;
		///<summary>
		///状态
		///</summary>
		private int _status;
		///<summary>
		///
		///</summary>
		private DateTime _addTime;
		///<summary>
		///
		///</summary>
		private DateTime _updateTime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_AppealEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_AppealEntity
		(
			int appealId,
			int userId,
			string appealCount,
			string img1,
			string img2,
			string img3,
			string img4,
			string img5,
			int status,
			DateTime addTime,
			DateTime updateTime
		)
		{
			_appealId    = appealId;
			_userId      = userId;
			_appealCount = appealCount;
			_img1        = img1;
			_img2        = img2;
			_img3        = img3;
			_img4        = img4;
			_img5        = img5;
			_status      = status;
			_addTime     = addTime;
			_updateTime  = updateTime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int AppealId
		{
			get {return _appealId;}
			set {_appealId = value;}
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
		///申诉内容
		///</summary>
		[DataMember]
		public string AppealCount
		{
			get {return _appealCount;}
			set {_appealCount = value;}
		}

		///<summary>
		///图片1
		///</summary>
		[DataMember]
		public string Img1
		{
			get {return _img1;}
			set {_img1 = value;}
		}

		///<summary>
		///图片2
		///</summary>
		[DataMember]
		public string Img2
		{
			get {return _img2;}
			set {_img2 = value;}
		}

		///<summary>
		///图片3
		///</summary>
		[DataMember]
		public string Img3
		{
			get {return _img3;}
			set {_img3 = value;}
		}

		///<summary>
		///图片4
		///</summary>
		[DataMember]
		public string Img4
		{
			get {return _img4;}
			set {_img4 = value;}
		}

		///<summary>
		///图片5
		///</summary>
		[DataMember]
		public string Img5
		{
			get {return _img5;}
			set {_img5 = value;}
		}

		///<summary>
		///状态
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
		public DateTime UpdateTime
		{
			get {return _updateTime;}
			set {_updateTime = value;}
		}
	
		#endregion
		
	}
}
