using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='UmidtokenInfo']"
	[global::Android.Runtime.Register ("com/amap/api/location/UmidtokenInfo", DoNotGenerateAcw=true)]
	public partial class UmidtokenInfo : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/UmidtokenInfo", typeof (UmidtokenInfo));
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

		protected UmidtokenInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='UmidtokenInfo']/constructor[@name='UmidtokenInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UmidtokenInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe string Umidtoken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='UmidtokenInfo']/method[@name='getUmidtoken' and count(parameter)=0]"
			[Register ("getUmidtoken", "()Ljava/lang/String;", "GetGetUmidtokenHandler")]
			get {
				const string __id = "getUmidtoken.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='UmidtokenInfo']/method[@name='setLocAble' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLocAble", "(Z)V", "")]
		public static unsafe void SetLocAble (bool p0)
		{
			const string __id = "setLocAble.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='UmidtokenInfo']/method[@name='setUmidtoken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setUmidtoken", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetUmidtoken (global::Android.Content.Context p0, string p1)
		{
			const string __id = "setUmidtoken.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
