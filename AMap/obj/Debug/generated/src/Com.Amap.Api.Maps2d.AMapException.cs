using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/AMapException", DoNotGenerateAcw=true)]
	public partial class AMapException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='AMAP_NOT_SUPPORT']"
		[Register ("AMAP_NOT_SUPPORT")]
		public const string AmapNotSupport = (string) "\u79fb\u52a8\u8bbe\u5907\u4e0a\u672a\u5b89\u88c5\u9ad8\u5fb7\u5730\u56fe\u6216\u9ad8\u5fb7\u5730\u56fe\u7248\u672c\u8f83\u65e7";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='AMAP_NOT_SUPPORT_NAVI']"
		[Register ("AMAP_NOT_SUPPORT_NAVI")]
		public const string AmapNotSupportNavi = (string) "\u79fb\u52a8\u8bbe\u5907\u4e0a\u672a\u5b89\u88c5\u9ad8\u5fb7\u5730\u56fe\u6216\u9ad8\u5fb7\u5730\u56fe\u7248\u672c\u8f83\u65e7";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_CONNECTION']"
		[Register ("ERROR_CONNECTION")]
		public const string ErrorConnection = (string) "http\u8fde\u63a5\u5931\u8d25 - ConnectionException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_FAILURE_AUTH']"
		[Register ("ERROR_FAILURE_AUTH")]
		public const string ErrorFailureAuth = (string) "key\u9274\u6743\u5931\u8d25";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_ILLEGAL_VALUE']"
		[Register ("ERROR_ILLEGAL_VALUE")]
		public const string ErrorIllegalValue = (string) "\u975e\u6cd5\u5750\u6807\u503c";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_INVALID_PARAMETER']"
		[Register ("ERROR_INVALID_PARAMETER")]
		public const string ErrorInvalidParameter = (string) "\u65e0\u6548\u7684\u53c2\u6570 - IllegalArgumentException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_IO']"
		[Register ("ERROR_IO")]
		public const string ErrorIo = (string) "IO \u64cd\u4f5c\u5f02\u5e38 - IOException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_NULL_PARAMETER']"
		[Register ("ERROR_NULL_PARAMETER")]
		public const string ErrorNullParameter = (string) "\u7a7a\u6307\u9488\u5f02\u5e38 - NullPointException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_PROTOCOL']"
		[Register ("ERROR_PROTOCOL")]
		public const string ErrorProtocol = (string) "\u534f\u8bae\u89e3\u6790\u9519\u8bef - ProtocolException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_SOCKET']"
		[Register ("ERROR_SOCKET")]
		public const string ErrorSocket = (string) "socket \u8fde\u63a5\u5f02\u5e38 - SocketException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_SOCKE_TIME_OUT']"
		[Register ("ERROR_SOCKE_TIME_OUT")]
		public const string ErrorSockeTimeOut = (string) "socket \u8fde\u63a5\u8d85\u65f6 - SocketTimeoutException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_UNKNOWN']"
		[Register ("ERROR_UNKNOWN")]
		public const string ErrorUnknown = (string) "\u672a\u77e5\u7684\u9519\u8bef";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_UNKNOW_HOST']"
		[Register ("ERROR_UNKNOW_HOST")]
		public const string ErrorUnknowHost = (string) "\u672a\u77e5\u4e3b\u673a - UnKnowHostException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_UNKNOW_SERVICE']"
		[Register ("ERROR_UNKNOW_SERVICE")]
		public const string ErrorUnknowService = (string) "\u670d\u52a1\u5668\u8fde\u63a5\u5931\u8d25 - UnknownServiceException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ERROR_URL']"
		[Register ("ERROR_URL")]
		public const string ErrorUrl = (string) "url\u5f02\u5e38 - MalformedURLException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ILLEGAL_AMAP_ARGUMENT']"
		[Register ("ILLEGAL_AMAP_ARGUMENT")]
		public const string IllegalAmapArgument = (string) "\u975e\u6cd5\u5bfc\u822a\u53c2\u6570";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/field[@name='ILLEGAL_NAVI_ARGUMENT']"
		[Register ("ILLEGAL_NAVI_ARGUMENT")]
		public const string IllegalNaviArgument = (string) "\u975e\u6cd5\u5bfc\u822a\u53c2\u6570";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/AMapException", typeof (AMapException));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected AMapException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/constructor[@name='AMapException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AMapException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/constructor[@name='AMapException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AMapException (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getErrorMessage;
#pragma warning disable 0169
		static Delegate GetGetErrorMessageHandler ()
		{
			if (cb_getErrorMessage == null)
				cb_getErrorMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorMessage);
			return cb_getErrorMessage;
		}

		static IntPtr n_GetErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapException __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapException']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				const string __id = "getErrorMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
