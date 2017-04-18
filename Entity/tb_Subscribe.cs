// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Subscribe.cs
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
	///tb_Subscribe数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_SubscribeEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _id;
		///<summary>
		///
		///</summary>
        private int _userId;
        ///<summary>
        ///
        ///</summary>
        private string _phone;
		///<summary>
		///
		///</summary>
		private string _unitId = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _orderTime;
		///<summary>
		///
		///</summary>
		private string _orderContent = String.Empty;
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
		public tb_SubscribeEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_SubscribeEntity
		(
			int id,
			int userId,
            string phone,
			string unitId,
			DateTime orderTime,
			string orderContent,
			DateTime addtime,
			int status
		)
		{
			_id           = id;
			_userId       = userId;
            _phone        = phone;
			_unitId       = unitId;
			_orderTime    = orderTime;
			_orderContent = orderContent;
			_addtime      = addtime;
			_status       = status;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int Id
		{
			get {return _id;}
			set {_id = value;}
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
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
		///<summary>
		///
		///</summary>
		[DataMember]
		public string UnitId
		{
			get {return _unitId;}
			set {_unitId = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public DateTime OrderTime
		{
			get {return _orderTime;}
			set {_orderTime = value;}
		}

		///<summary>
		///
		///</summary>
		[DataMember]
		public string OrderContent
		{
			get {return _orderContent;}
			set {_orderContent = value;}
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
