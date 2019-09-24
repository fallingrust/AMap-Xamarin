using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']"
	[Register ("com/amap/api/interfaces/IMapFragmentDelegate", "", "Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker")]
	public partial interface IMapFragmentDelegate : IJavaObject {

		bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")] get;
		}

		global::Com.Amap.Api.Interfaces.IAMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/amap/api/interfaces/IAMap;", "GetGetMapHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnCreate (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onCreateView' and count(parameter)=3 and parameter[1][@type='android.view.LayoutInflater'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;", "GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		global::Android.Views.View OnCreateView (global::Android.Views.LayoutInflater p0, global::Android.Views.ViewGroup p1, global::Android.OS.Bundle p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnDestroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onDestroyView' and count(parameter)=0]"
		[Register ("onDestroyView", "()V", "GetOnDestroyViewHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnDestroyView ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onInflate' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.amap.api.maps2d.AMapOptions'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onInflate", "(Landroid/app/Activity;Lcom/amap/api/maps2d/AMapOptions;Landroid/os/Bundle;)V", "GetOnInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_Handler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnInflate (global::Android.App.Activity p0, global::Com.Amap.Api.Maps2d.AMapOptions p1, global::Android.OS.Bundle p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onLowMemory' and count(parameter)=0]"
		[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnLowMemory ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnResume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void OnSaveInstanceState (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void SetContext (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMapFragmentDelegate']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMapOptions']]"
		[Register ("setOptions", "(Lcom/amap/api/maps2d/AMapOptions;)V", "GetSetOptions_Lcom_amap_api_maps2d_AMapOptions_Handler:Com.Amap.Api.Interfaces.IMapFragmentDelegateInvoker, AMap")]
		void SetOptions (global::Com.Amap.Api.Maps2d.AMapOptions p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IMapFragmentDelegate", DoNotGenerateAcw=true)]
	internal class IMapFragmentDelegateInvoker : global::Java.Lang.Object, IMapFragmentDelegate {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IMapFragmentDelegate", typeof (IMapFragmentDelegateInvoker));

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

		public static IMapFragmentDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapFragmentDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IMapFragmentDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapFragmentDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		IntPtr id_isReady;
		public unsafe bool IsReady {
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReady);
			}
		}

		static Delegate cb_getMap;
#pragma warning disable 0169
		static Delegate GetGetMapHandler ()
		{
			if (cb_getMap == null)
				cb_getMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap);
			return cb_getMap;
		}

		static IntPtr n_GetMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map);
		}
#pragma warning restore 0169

		IntPtr id_getMap;
		public unsafe global::Com.Amap.Api.Interfaces.IAMap Map {
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Lcom/amap/api/interfaces/IAMap;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreate_Landroid_os_Bundle_;
		public unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ == null)
				cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_);
			return cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
		}

		static IntPtr n_OnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.LayoutInflater p0 = global::Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
		public unsafe global::Android.Views.View OnCreateView (global::Android.Views.LayoutInflater p0, global::Android.Views.ViewGroup p1, global::Android.OS.Bundle p2)
		{
			if (id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDestroyView;
#pragma warning disable 0169
		static Delegate GetOnDestroyViewHandler ()
		{
			if (cb_onDestroyView == null)
				cb_onDestroyView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroyView);
			return cb_onDestroyView;
		}

		static void n_OnDestroyView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroyView ();
		}
#pragma warning restore 0169

		IntPtr id_onDestroyView;
		public unsafe void OnDestroyView ()
		{
			if (id_onDestroyView == IntPtr.Zero)
				id_onDestroyView = JNIEnv.GetMethodID (class_ref, "onDestroyView", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroyView);
		}

		static Delegate cb_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_Handler ()
		{
			if (cb_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_ == null)
				cb_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_);
			return cb_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_;
		}

		static void n_OnInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMapOptions p1 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnInflate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_;
		public unsafe void OnInflate (global::Android.App.Activity p0, global::Com.Amap.Api.Maps2d.AMapOptions p1, global::Android.OS.Bundle p2)
		{
			if (id_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onInflate", "(Landroid/app/Activity;Lcom/amap/api/maps2d/AMapOptions;Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInflate_Landroid_app_Activity_Lcom_amap_api_maps2d_AMapOptions_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_onLowMemory;
#pragma warning disable 0169
		static Delegate GetOnLowMemoryHandler ()
		{
			if (cb_onLowMemory == null)
				cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
			return cb_onLowMemory;
		}

		static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLowMemory ();
		}
#pragma warning restore 0169

		IntPtr id_onLowMemory;
		public unsafe void OnLowMemory ()
		{
			if (id_onLowMemory == IntPtr.Zero)
				id_onLowMemory = JNIEnv.GetMethodID (class_ref, "onLowMemory", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLowMemory);
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		IntPtr id_onPause;
		public unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		IntPtr id_onResume;
		public unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		public unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (p0);
		}
#pragma warning restore 0169

		IntPtr id_setContext_Landroid_content_Context_;
		public unsafe void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
		}

		static Delegate cb_setOptions_Lcom_amap_api_maps2d_AMapOptions_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Lcom_amap_api_maps2d_AMapOptions_Handler ()
		{
			if (cb_setOptions_Lcom_amap_api_maps2d_AMapOptions_ == null)
				cb_setOptions_Lcom_amap_api_maps2d_AMapOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptions_Lcom_amap_api_maps2d_AMapOptions_);
			return cb_setOptions_Lcom_amap_api_maps2d_AMapOptions_;
		}

		static void n_SetOptions_Lcom_amap_api_maps2d_AMapOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMapFragmentDelegate __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMapOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOptions_Lcom_amap_api_maps2d_AMapOptions_;
		public unsafe void SetOptions (global::Com.Amap.Api.Maps2d.AMapOptions p0)
		{
			if (id_setOptions_Lcom_amap_api_maps2d_AMapOptions_ == IntPtr.Zero)
				id_setOptions_Lcom_amap_api_maps2d_AMapOptions_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Lcom/amap/api/maps2d/AMapOptions;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Lcom_amap_api_maps2d_AMapOptions_, __args);
		}

	}

}
