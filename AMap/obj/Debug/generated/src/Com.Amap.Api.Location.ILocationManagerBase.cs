using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']"
	[Register ("com/amap/api/location/LocationManagerBase", "", "Com.Amap.Api.Location.ILocationManagerBaseInvoker")]
	public partial interface ILocationManagerBase : IJavaObject {

		bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")] get;
		}

		global::Com.Amap.Api.Location.AMapLocation LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Lcom/amap/api/location/AMapLocation;", "GetGetLastKnownLocationHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='disableBackgroundLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableBackgroundLocation", "(Z)V", "GetDisableBackgroundLocation_ZHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void DisableBackgroundLocation (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='enableBackgroundLocation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Notification']]"
		[Register ("enableBackgroundLocation", "(ILandroid/app/Notification;)V", "GetEnableBackgroundLocation_ILandroid_app_Notification_Handler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void EnableBackgroundLocation (int p0, global::Android.App.Notification p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void OnDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='setLocationListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationListener']]"
		[Register ("setLocationListener", "(Lcom/amap/api/location/AMapLocationListener;)V", "GetSetLocationListener_Lcom_amap_api_location_AMapLocationListener_Handler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void SetLocationListener (global::Com.Amap.Api.Location.IAMapLocationListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='setLocationOption' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption']]"
		[Register ("setLocationOption", "(Lcom/amap/api/location/AMapLocationClientOption;)V", "GetSetLocationOption_Lcom_amap_api_location_AMapLocationClientOption_Handler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void SetLocationOption (global::Com.Amap.Api.Location.AMapLocationClientOption p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='startAssistantLocation' and count(parameter)=0]"
		[Register ("startAssistantLocation", "()V", "GetStartAssistantLocationHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void StartAssistantLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='startAssistantLocation' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("startAssistantLocation", "(Landroid/webkit/WebView;)V", "GetStartAssistantLocation_Landroid_webkit_WebView_Handler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void StartAssistantLocation (global::Android.Webkit.WebView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='startLocation' and count(parameter)=0]"
		[Register ("startLocation", "()V", "GetStartLocationHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void StartLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='stopAssistantLocation' and count(parameter)=0]"
		[Register ("stopAssistantLocation", "()V", "GetStopAssistantLocationHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void StopAssistantLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='stopLocation' and count(parameter)=0]"
		[Register ("stopLocation", "()V", "GetStopLocationHandler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void StopLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='LocationManagerBase']/method[@name='unRegisterLocationListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationListener']]"
		[Register ("unRegisterLocationListener", "(Lcom/amap/api/location/AMapLocationListener;)V", "GetUnRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_Handler:Com.Amap.Api.Location.ILocationManagerBaseInvoker, AMap")]
		void UnRegisterLocationListener (global::Com.Amap.Api.Location.IAMapLocationListener p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/location/LocationManagerBase", DoNotGenerateAcw=true)]
	internal class ILocationManagerBaseInvoker : global::Java.Lang.Object, ILocationManagerBase {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/location/LocationManagerBase", typeof (ILocationManagerBaseInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ILocationManagerBase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationManagerBase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.location.LocationManagerBase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationManagerBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		IntPtr id_isStarted;
		public unsafe bool IsStarted {
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStarted);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastKnownLocation);
		}
#pragma warning restore 0169

		IntPtr id_getLastKnownLocation;
		public unsafe global::Com.Amap.Api.Location.AMapLocation LastKnownLocation {
			get {
				if (id_getLastKnownLocation == IntPtr.Zero)
					id_getLastKnownLocation = JNIEnv.GetMethodID (class_ref, "getLastKnownLocation", "()Lcom/amap/api/location/AMapLocation;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastKnownLocation), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableBackgroundLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_disableBackgroundLocation_Z;
		public unsafe void DisableBackgroundLocation (bool p0)
		{
			if (id_disableBackgroundLocation_Z == IntPtr.Zero)
				id_disableBackgroundLocation_Z = JNIEnv.GetMethodID (class_ref, "disableBackgroundLocation", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableBackgroundLocation_Z, __args);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Notification p1 = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnableBackgroundLocation (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_enableBackgroundLocation_ILandroid_app_Notification_;
		public unsafe void EnableBackgroundLocation (int p0, global::Android.App.Notification p1)
		{
			if (id_enableBackgroundLocation_ILandroid_app_Notification_ == IntPtr.Zero)
				id_enableBackgroundLocation_ILandroid_app_Notification_ = JNIEnv.GetMethodID (class_ref, "enableBackgroundLocation", "(ILandroid/app/Notification;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableBackgroundLocation_ILandroid_app_Notification_, __args);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroy;
		public unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.IAMapLocationListener p0 = (global::Com.Amap.Api.Location.IAMapLocationListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.IAMapLocationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLocationListener_Lcom_amap_api_location_AMapLocationListener_;
		public unsafe void SetLocationListener (global::Com.Amap.Api.Location.IAMapLocationListener p0)
		{
			if (id_setLocationListener_Lcom_amap_api_location_AMapLocationListener_ == IntPtr.Zero)
				id_setLocationListener_Lcom_amap_api_location_AMapLocationListener_ = JNIEnv.GetMethodID (class_ref, "setLocationListener", "(Lcom/amap/api/location/AMapLocationListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationListener_Lcom_amap_api_location_AMapLocationListener_, __args);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationClientOption p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationOption (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_;
		public unsafe void SetLocationOption (global::Com.Amap.Api.Location.AMapLocationClientOption p0)
		{
			if (id_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_ == IntPtr.Zero)
				id_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_ = JNIEnv.GetMethodID (class_ref, "setLocationOption", "(Lcom/amap/api/location/AMapLocationClientOption;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationOption_Lcom_amap_api_location_AMapLocationClientOption_, __args);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAssistantLocation ();
		}
#pragma warning restore 0169

		IntPtr id_startAssistantLocation;
		public unsafe void StartAssistantLocation ()
		{
			if (id_startAssistantLocation == IntPtr.Zero)
				id_startAssistantLocation = JNIEnv.GetMethodID (class_ref, "startAssistantLocation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAssistantLocation);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView p0 = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartAssistantLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_startAssistantLocation_Landroid_webkit_WebView_;
		public unsafe void StartAssistantLocation (global::Android.Webkit.WebView p0)
		{
			if (id_startAssistantLocation_Landroid_webkit_WebView_ == IntPtr.Zero)
				id_startAssistantLocation_Landroid_webkit_WebView_ = JNIEnv.GetMethodID (class_ref, "startAssistantLocation", "(Landroid/webkit/WebView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAssistantLocation_Landroid_webkit_WebView_, __args);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartLocation ();
		}
#pragma warning restore 0169

		IntPtr id_startLocation;
		public unsafe void StartLocation ()
		{
			if (id_startLocation == IntPtr.Zero)
				id_startLocation = JNIEnv.GetMethodID (class_ref, "startLocation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startLocation);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAssistantLocation ();
		}
#pragma warning restore 0169

		IntPtr id_stopAssistantLocation;
		public unsafe void StopAssistantLocation ()
		{
			if (id_stopAssistantLocation == IntPtr.Zero)
				id_stopAssistantLocation = JNIEnv.GetMethodID (class_ref, "stopAssistantLocation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAssistantLocation);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocation ();
		}
#pragma warning restore 0169

		IntPtr id_stopLocation;
		public unsafe void StopLocation ()
		{
			if (id_stopLocation == IntPtr.Zero)
				id_stopLocation = JNIEnv.GetMethodID (class_ref, "stopLocation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopLocation);
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
			global::Com.Amap.Api.Location.ILocationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.ILocationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.IAMapLocationListener p0 = (global::Com.Amap.Api.Location.IAMapLocationListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.IAMapLocationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterLocationListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_;
		public unsafe void UnRegisterLocationListener (global::Com.Amap.Api.Location.IAMapLocationListener p0)
		{
			if (id_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_ == IntPtr.Zero)
				id_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_ = JNIEnv.GetMethodID (class_ref, "unRegisterLocationListener", "(Lcom/amap/api/location/AMapLocationListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterLocationListener_Lcom_amap_api_location_AMapLocationListener_, __args);
		}

	}

}
