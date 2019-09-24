using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']"
	[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationClient", DoNotGenerateAcw=true)]
	public partial class AMapLocationClient : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationClient", typeof (AMapLocationClient));
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

		protected AMapLocationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/constructor[@name='AMapLocationClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AMapLocationClient (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/constructor[@name='AMapLocationClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public unsafe AMapLocationClient (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/content/Intent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				const string __id = "isStarted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastKnownLocation;
#pragma warning disable 0169
		static Delegate GetGetLastKnownLocationHandler ()
		{
			if (cb_getLastKnownLocation == null)
				cb_getLastKnownLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastKnownLocation);
			return cb_getLastKnownLocation;
		}

		static IntPtr n_GetLastKnownLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastKnownLocation);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Location.AMapLocation LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Lcom/amap/api/location/AMapLocation;", "GetGetLastKnownLocationHandler")]
			get {
				const string __id = "getLastKnownLocation.()Lcom/amap/api/location/AMapLocation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_disableBackgroundLocation_Z;
#pragma warning disable 0169
		static Delegate GetDisableBackgroundLocation_ZHandler ()
		{
			if (cb_disableBackgroundLocation_Z == null)
				cb_disableBackgroundLocation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DisableBackgroundLocation_Z);
			return cb_disableBackgroundLocation_Z;
		}

		static void n_DisableBackgroundLocation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableBackgroundLocation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='disableBackgroundLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableBackgroundLocation", "(Z)V", "GetDisableBackgroundLocation_ZHandler")]
		public virtual unsafe void DisableBackgroundLocation (bool p0)
		{
			const string __id = "disableBackgroundLocation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_enableBackgroundLocation_ILandroid_app_Notification_;
#pragma warning disable 0169
		static Delegate GetEnableBackgroundLocation_ILandroid_app_Notification_Handler ()
		{
			if (cb_enableBackgroundLocation_ILandroid_app_Notification_ == null)
				cb_enableBackgroundLocation_ILandroid_app_Notification_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_EnableBackgroundLocation_ILandroid_app_Notification_);
			return cb_enableBackgroundLocation_ILandroid_app_Notification_;
		}

		static void n_EnableBackgroundLocation_ILandroid_app_Notification_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Notification p1 = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnableBackgroundLocation (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='enableBackgroundLocation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Notification']]"
		[Register ("enableBackgroundLocation", "(ILandroid/app/Notification;)V", "GetEnableBackgroundLocation_ILandroid_app_Notification_Handler")]
		public virtual unsafe void EnableBackgroundLocation (int p0, global::Android.App.Notification p1)
		{
			const string __id = "enableBackgroundLocation.(ILandroid/app/Notification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='getDeviceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceId (global::Android.Content.Context p0)
		{
			const string __id = "getDeviceId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='setApiKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApiKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetApiKey (string p0)
		{
			const string __id = "setApiKey.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLocationListener_Lcom_amap_api_location_AMapLocationListener_;
#pragma warning disable 0169
		static Delegate GetSetLocationListener_Lcom_amap_api_location_AMapLocationListener_Handler ()
		{
			if (cb_setLocationListener_Lcom_amap_api_location_AMapLocationListener_ == null)
				cb_setLocationListener_Lcom_amap_api_location_AMapLocationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationListener_Lcom_amap_api_location_AMapLocationListener_);
			return cb_setLocationListener_Lcom_amap_api_location_AMapLocationListener_;
		}

		static void n_SetLocationListener_Lcom_amap_api_location_AMapLocationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.IAMapLocationListener p0 = (global::Com.Amap.Api.Location.IAMapLocationListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.IAMapLocationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='setLocationListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationListener']]"
		[Register ("setLocationListener", "(Lcom/amap/api/location/AMapLocationListener;)V", "GetSetLocationListener_Lcom_amap_api_location_AMapLocationListener_Handler")]
		public virtual unsafe void SetLocationListener (global::Com.Amap.Api.Location.IAMapLocationListener p0)
		{
			const string __id = "setLocationListener.(Lcom/amap/api/location/AMapLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_;
#pragma warning disable 0169
		static Delegate GetSetLocationOption_Lcom_amap_api_location_AMapLocationClientOption_Handler ()
		{
			if (cb_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_ == null)
				cb_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationOption_Lcom_amap_api_location_AMapLocationClientOption_);
			return cb_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_;
		}

		static void n_SetLocationOption_Lcom_amap_api_location_AMapLocationClientOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationClientOption p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationOption (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='setLocationOption' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption']]"
		[Register ("setLocationOption", "(Lcom/amap/api/location/AMapLocationClientOption;)V", "GetSetLocationOption_Lcom_amap_api_location_AMapLocationClientOption_Handler")]
		public virtual unsafe void SetLocationOption (global::Com.Amap.Api.Location.AMapLocationClientOption p0)
		{
			const string __id = "setLocationOption.(Lcom/amap/api/location/AMapLocationClientOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startAssistantLocation;
#pragma warning disable 0169
		static Delegate GetStartAssistantLocationHandler ()
		{
			if (cb_startAssistantLocation == null)
				cb_startAssistantLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartAssistantLocation);
			return cb_startAssistantLocation;
		}

		static void n_StartAssistantLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAssistantLocation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='startAssistantLocation' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("startAssistantLocation", "()V", "GetStartAssistantLocationHandler")]
		public virtual unsafe void StartAssistantLocation ()
		{
			const string __id = "startAssistantLocation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startAssistantLocation_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetStartAssistantLocation_Landroid_webkit_WebView_Handler ()
		{
			if (cb_startAssistantLocation_Landroid_webkit_WebView_ == null)
				cb_startAssistantLocation_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartAssistantLocation_Landroid_webkit_WebView_);
			return cb_startAssistantLocation_Landroid_webkit_WebView_;
		}

		static void n_StartAssistantLocation_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartAssistantLocation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='startAssistantLocation' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("startAssistantLocation", "(Landroid/webkit/WebView;)V", "GetStartAssistantLocation_Landroid_webkit_WebView_Handler")]
		public virtual unsafe void StartAssistantLocation (global::Android.Webkit.WebView p0)
		{
			const string __id = "startAssistantLocation.(Landroid/webkit/WebView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startLocation;
#pragma warning disable 0169
		static Delegate GetStartLocationHandler ()
		{
			if (cb_startLocation == null)
				cb_startLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartLocation);
			return cb_startLocation;
		}

		static void n_StartLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartLocation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='startLocation' and count(parameter)=0]"
		[Register ("startLocation", "()V", "GetStartLocationHandler")]
		public virtual unsafe void StartLocation ()
		{
			const string __id = "startLocation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopAssistantLocation;
#pragma warning disable 0169
		static Delegate GetStopAssistantLocationHandler ()
		{
			if (cb_stopAssistantLocation == null)
				cb_stopAssistantLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAssistantLocation);
			return cb_stopAssistantLocation;
		}

		static void n_StopAssistantLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAssistantLocation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='stopAssistantLocation' and count(parameter)=0]"
		[Register ("stopAssistantLocation", "()V", "GetStopAssistantLocationHandler")]
		public virtual unsafe void StopAssistantLocation ()
		{
			const string __id = "stopAssistantLocation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopLocation;
#pragma warning disable 0169
		static Delegate GetStopLocationHandler ()
		{
			if (cb_stopLocation == null)
				cb_stopLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocation);
			return cb_stopLocation;
		}

		static void n_StopLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='stopLocation' and count(parameter)=0]"
		[Register ("stopLocation", "()V", "GetStopLocationHandler")]
		public virtual unsafe void StopLocation ()
		{
			const string __id = "stopLocation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_;
#pragma warning disable 0169
		static Delegate GetUnRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_Handler ()
		{
			if (cb_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_ == null)
				cb_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_);
			return cb_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_;
		}

		static void n_UnRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.IAMapLocationListener p0 = (global::Com.Amap.Api.Location.IAMapLocationListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.IAMapLocationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterLocationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClient']/method[@name='unRegisterLocationListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationListener']]"
		[Register ("unRegisterLocationListener", "(Lcom/amap/api/location/AMapLocationListener;)V", "GetUnRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_Handler")]
		public virtual unsafe void UnRegisterLocationListener (global::Com.Amap.Api.Location.IAMapLocationListener p0)
		{
			const string __id = "unRegisterLocationListener.(Lcom/amap/api/location/AMapLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Amap.Api.Location.IAMapLocationListener"
		public event EventHandler<global::Com.Amap.Api.Location.AMapLocationEventArgs> Location {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Location.IAMapLocationListener, global::Com.Amap.Api.Location.IAMapLocationListenerImplementor>(
						ref weak_implementor_SetLocationListener,
						__CreateIAMapLocationListenerImplementor,
						SetLocationListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Location.IAMapLocationListener, global::Com.Amap.Api.Location.IAMapLocationListenerImplementor>(
						ref weak_implementor_SetLocationListener,
						global::Com.Amap.Api.Location.IAMapLocationListenerImplementor.__IsEmpty,
						__v => SetLocationListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetLocationListener;

		global::Com.Amap.Api.Location.IAMapLocationListenerImplementor __CreateIAMapLocationListenerImplementor ()
		{
			return new global::Com.Amap.Api.Location.IAMapLocationListenerImplementor (this);
		}
#endregion
	}
}
