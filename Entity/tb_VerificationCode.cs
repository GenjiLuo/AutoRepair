// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_VerificationCode.cs
// 项目名称：买车网
// 创建时间：2016/8/29
// 负责人：杨晓光
// ===================================================================
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ComponentModel;
namespace AutoRepair.Entity
{
	/// <summary>
	///tb_VerificationCode数据实体
	/// </summary>
	[Serializable]
	[DataContract]
	public class tb_VerificationCodeEntity
	{
		#region 变量定义
		///<summary>
		///
		///</summary>
		private int _verificationId;
		///<summary>
		///
		///</summary>
		private string _phone = String.Empty;
		///<summary>
		///
		///</summary>
		private string _code = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime _addtime;
		///<summary>
		///
		///</summary>
		private DateTime _outtime;
		#endregion
		
		#region 构造函数

		///<summary>
		///
		///</summary>
		public tb_VerificationCodeEntity()
		{
		}
		///<summary>
		///
		///</summary>
		public tb_VerificationCodeEntity
		(
			int verificationId,
			string phone,
			string code,
			DateTime addtime,
			DateTime outtime
		)
		{
			_verificationId = verificationId;
			_phone          = phone;
			_code           = code;
			_addtime        = addtime;
			_outtime        = outtime;
			
		}
		#endregion
		
		#region 公共属性

		
		///<summary>
		///
		///</summary>
		[DataMember]
		public int VerificationId
		{
			get {return _verificationId;}
			set {_verificationId = value;}
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
		public string Code
		{
			get {return _code;}
			set {_code = value;}
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
		public DateTime Outtime
		{
			get {return _outtime;}
			set {_outtime = value;}
		}
	
		#endregion
		
	}
}
