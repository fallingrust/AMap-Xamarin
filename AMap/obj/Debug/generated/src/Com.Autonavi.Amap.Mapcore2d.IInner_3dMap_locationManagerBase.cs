using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Autonavi.Amap.Mapcore2d {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']"
	[Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationManagerBase", "", "Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker")]
	public partial interface IInner_3dMap_locationManagerBase : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker, AMap")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']/method[@name='setLocationListener' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore2d.Inner_3dMap_locationListener']]"
		[Register ("setLocationListener", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationListener;)V", "GetSetLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_Handler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker, AMap")]
		void SetLocationListener (global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']/method[@name='setLocationOption' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore2d.Inner_3dMap_locationOption']]"
		[Register ("setLocationOption", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;)V", "GetSetLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Handler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker, AMap")]
		void SetLocationOption (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']/method[@name='startLocation' and count(parameter)=0]"
		[Register ("startLocation", "()V", "GetStartLocationHandler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker, AMap")]
		void StartLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']/method[@name='stopLocation' and count(parameter)=0]"
		[Register ("stopLocation", "()V", "GetStopLocationHandler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker, AMap")]
		void StopLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationManagerBase']/method[@name='unRegisterLocationListener' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore2d.Inner_3dMap_locationListener']]"
		[Register ("unRegisterLocationListener", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationListener;)V", "GetUnRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_Handler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBaseInvoker, AMap")]
		void UnRegisterLocationListener (global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener p0);

	}

	[global::Android.Runtime.Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationManagerBase", DoNotGenerateAcw=true)]
	internal class IInner_3dMap_locationManagerBaseInvoker : global::Java.Lang.Object, IInner_3dMap_locationManagerBase {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationManagerBase", typeof (IInner_3dMap_locationManagerBaseInvoker));

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

		public static IInner_3dMap_locationManagerBase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInner_3dMap_locationManagerBase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.autonavi.amap.mapcore2d.Inner_3dMap_locationManagerBase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInner_3dMap_locationManagerBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate cb_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_;
#pragma warning disable 0169
		static Delegate GetSetLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_Handler ()
		{
			if (cb_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ == null)
				cb_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_);
			return cb_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_;
		}

		static void n_SetLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener p0 = (global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener)global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_;
		public unsafe void SetLocationListener (global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener p0)
		{
			if (id_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ == IntPtr.Zero)
				id_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ = JNIEnv.GetMethodID (class_ref, "setLocationListener", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_, __args);
		}

		static Delegate cb_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_;
#pragma warning disable 0169
		static Delegate GetSetLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Handler ()
		{
			if (cb_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_ == null)
				cb_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_);
			return cb_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_;
		}

		static void n_SetLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption p0 = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationOption (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_;
		public unsafe void SetLocationOption (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption p0)
		{
			if (id_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_ == IntPtr.Zero)
				id_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_ = JNIEnv.GetMethodID (class_ref, "setLocationOption", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationOption_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_;
#pragma warning disable 0169
		static Delegate GetUnRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_Handler ()
		{
			if (cb_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ == null)
				cb_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_);
			return cb_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_;
		}

		static void n_UnRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener p0 = (global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener)global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterLocationListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_;
		public unsafe void UnRegisterLocationListener (global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener p0)
		{
			if (id_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ == IntPtr.Zero)
				id_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_ = JNIEnv.GetMethodID (class_ref, "unRegisterLocationListener", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterLocationListener_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationListener_, __args);
		}

	}

}
