using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']"
	[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationQualityReport", DoNotGenerateAcw=true)]
	public partial class AMapLocationQualityReport : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/field[@name='GPS_STATUS_MODE_SAVING']"
		[Register ("GPS_STATUS_MODE_SAVING")]
		public const int GpsStatusModeSaving = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/field[@name='GPS_STATUS_NOGPSPERMISSION']"
		[Register ("GPS_STATUS_NOGPSPERMISSION")]
		public const int GpsStatusNogpspermission = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/field[@name='GPS_STATUS_NOGPSPROVIDER']"
		[Register ("GPS_STATUS_NOGPSPROVIDER")]
		public const int GpsStatusNogpsprovider = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/field[@name='GPS_STATUS_OFF']"
		[Register ("GPS_STATUS_OFF")]
		public const int GpsStatusOff = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/field[@name='GPS_STATUS_OK']"
		[Register ("GPS_STATUS_OK")]
		public const int GpsStatusOk = (int) 0;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationQualityReport", typeof (AMapLocationQualityReport));
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

		protected AMapLocationQualityReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/constructor[@name='AMapLocationQualityReport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AMapLocationQualityReport ()
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

		static Delegate cb_getAdviseMessage;
#pragma warning disable 0169
		static Delegate GetGetAdviseMessageHandler ()
		{
			if (cb_getAdviseMessage == null)
				cb_getAdviseMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdviseMessage);
			return cb_getAdviseMessage;
		}

		static IntPtr n_GetAdviseMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdviseMessage);
		}
#pragma warning restore 0169

		public virtual unsafe string AdviseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='getAdviseMessage' and count(parameter)=0]"
			[Register ("getAdviseMessage", "()Ljava/lang/String;", "GetGetAdviseMessageHandler")]
			get {
				const string __id = "getAdviseMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGPSSatellites;
#pragma warning disable 0169
		static Delegate GetGetGPSSatellitesHandler ()
		{
			if (cb_getGPSSatellites == null)
				cb_getGPSSatellites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGPSSatellites);
			return cb_getGPSSatellites;
		}

		static int n_GetGPSSatellites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GPSSatellites;
		}
#pragma warning restore 0169

		static Delegate cb_setGPSSatellites_I;
#pragma warning disable 0169
		static Delegate GetSetGPSSatellites_IHandler ()
		{
			if (cb_setGPSSatellites_I == null)
				cb_setGPSSatellites_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGPSSatellites_I);
			return cb_setGPSSatellites_I;
		}

		static void n_SetGPSSatellites_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GPSSatellites = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int GPSSatellites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='getGPSSatellites' and count(parameter)=0]"
			[Register ("getGPSSatellites", "()I", "GetGetGPSSatellitesHandler")]
			get {
				const string __id = "getGPSSatellites.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setGPSSatellites' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGPSSatellites", "(I)V", "GetSetGPSSatellites_IHandler")]
			set {
				const string __id = "setGPSSatellites.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGPSStatus;
#pragma warning disable 0169
		static Delegate GetGetGPSStatusHandler ()
		{
			if (cb_getGPSStatus == null)
				cb_getGPSStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGPSStatus);
			return cb_getGPSStatus;
		}

		static int n_GetGPSStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GPSStatus;
		}
#pragma warning restore 0169

		public virtual unsafe int GPSStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='getGPSStatus' and count(parameter)=0]"
			[Register ("getGPSStatus", "()I", "GetGetGPSStatusHandler")]
			get {
				const string __id = "getGPSStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isInstalledHighDangerMockApp;
#pragma warning disable 0169
		static Delegate GetIsInstalledHighDangerMockAppHandler ()
		{
			if (cb_isInstalledHighDangerMockApp == null)
				cb_isInstalledHighDangerMockApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInstalledHighDangerMockApp);
			return cb_isInstalledHighDangerMockApp;
		}

		static bool n_IsInstalledHighDangerMockApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInstalledHighDangerMockApp;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInstalledHighDangerMockApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='isInstalledHighDangerMockApp' and count(parameter)=0]"
			[Register ("isInstalledHighDangerMockApp", "()Z", "GetIsInstalledHighDangerMockAppHandler")]
			get {
				const string __id = "isInstalledHighDangerMockApp.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNetUseTime;
#pragma warning disable 0169
		static Delegate GetGetNetUseTimeHandler ()
		{
			if (cb_getNetUseTime == null)
				cb_getNetUseTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNetUseTime);
			return cb_getNetUseTime;
		}

		static long n_GetNetUseTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetUseTime;
		}
#pragma warning restore 0169

		static Delegate cb_setNetUseTime_J;
#pragma warning disable 0169
		static Delegate GetSetNetUseTime_JHandler ()
		{
			if (cb_setNetUseTime_J == null)
				cb_setNetUseTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetNetUseTime_J);
			return cb_setNetUseTime_J;
		}

		static void n_SetNetUseTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetUseTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long NetUseTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='getNetUseTime' and count(parameter)=0]"
			[Register ("getNetUseTime", "()J", "GetGetNetUseTimeHandler")]
			get {
				const string __id = "getNetUseTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setNetUseTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setNetUseTime", "(J)V", "GetSetNetUseTime_JHandler")]
			set {
				const string __id = "setNetUseTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkType;
#pragma warning disable 0169
		static Delegate GetGetNetworkTypeHandler ()
		{
			if (cb_getNetworkType == null)
				cb_getNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkType);
			return cb_getNetworkType;
		}

		static IntPtr n_GetNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NetworkType);
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNetworkType_Ljava_lang_String_Handler ()
		{
			if (cb_setNetworkType_Ljava_lang_String_ == null)
				cb_setNetworkType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkType_Ljava_lang_String_);
			return cb_setNetworkType_Ljava_lang_String_;
		}

		static void n_SetNetworkType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string NetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='getNetworkType' and count(parameter)=0]"
			[Register ("getNetworkType", "()Ljava/lang/String;", "GetGetNetworkTypeHandler")]
			get {
				const string __id = "getNetworkType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setNetworkType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkType", "(Ljava/lang/String;)V", "GetSetNetworkType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNetworkType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isWifiAble;
#pragma warning disable 0169
		static Delegate GetIsWifiAbleHandler ()
		{
			if (cb_isWifiAble == null)
				cb_isWifiAble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWifiAble);
			return cb_isWifiAble;
		}

		static bool n_IsWifiAble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WifiAble;
		}
#pragma warning restore 0169

		static Delegate cb_setWifiAble_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiAble_ZHandler ()
		{
			if (cb_setWifiAble_Z == null)
				cb_setWifiAble_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWifiAble_Z);
			return cb_setWifiAble_Z;
		}

		static void n_SetWifiAble_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WifiAble = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool WifiAble {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='isWifiAble' and count(parameter)=0]"
			[Register ("isWifiAble", "()Z", "GetIsWifiAbleHandler")]
			get {
				const string __id = "isWifiAble.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setWifiAble' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWifiAble", "(Z)V", "GetSetWifiAble_ZHandler")]
			set {
				const string __id = "setWifiAble.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setGpsStatus_I;
#pragma warning disable 0169
		static Delegate GetSetGpsStatus_IHandler ()
		{
			if (cb_setGpsStatus_I == null)
				cb_setGpsStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGpsStatus_I);
			return cb_setGpsStatus_I;
		}

		static void n_SetGpsStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGpsStatus (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setGpsStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGpsStatus", "(I)V", "GetSetGpsStatus_IHandler")]
		public virtual unsafe void SetGpsStatus (int p0)
		{
			const string __id = "setGpsStatus.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInstallHighDangerMockApp_Z;
#pragma warning disable 0169
		static Delegate GetSetInstallHighDangerMockApp_ZHandler ()
		{
			if (cb_setInstallHighDangerMockApp_Z == null)
				cb_setInstallHighDangerMockApp_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInstallHighDangerMockApp_Z);
			return cb_setInstallHighDangerMockApp_Z;
		}

		static void n_SetInstallHighDangerMockApp_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInstallHighDangerMockApp (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setInstallHighDangerMockApp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInstallHighDangerMockApp", "(Z)V", "GetSetInstallHighDangerMockApp_ZHandler")]
		public virtual unsafe void SetInstallHighDangerMockApp (bool p0)
		{
			const string __id = "setInstallHighDangerMockApp.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_;
#pragma warning disable 0169
		static Delegate GetSetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_Handler ()
		{
			if (cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_ == null)
				cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_);
			return cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_;
		}

		static void n_SetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationQualityReport __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationQualityReport']/method[@name='setLocationMode' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption.AMapLocationMode']]"
		[Register ("setLocationMode", "(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;)V", "GetSetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_Handler")]
		public virtual unsafe void SetLocationMode (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode p0)
		{
			const string __id = "setLocationMode.(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
