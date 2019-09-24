using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Autonavi.Amap.Mapcore2d {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationListener']"
	[Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationListener", "", "Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListenerInvoker")]
	public partial interface IInner_3dMap_locationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/interface[@name='Inner_3dMap_locationListener']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore2d.Inner_3dMap_location']]"
		[Register ("onLocationChanged", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_location;)V", "GetOnLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_Handler:Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListenerInvoker, AMap")]
		void OnLocationChanged (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location p0);

	}

	[global::Android.Runtime.Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationListener", DoNotGenerateAcw=true)]
	internal class IInner_3dMap_locationListenerInvoker : global::Java.Lang.Object, IInner_3dMap_locationListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationListener", typeof (IInner_3dMap_locationListenerInvoker));

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

		public static IInner_3dMap_locationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInner_3dMap_locationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.autonavi.amap.mapcore2d.Inner_3dMap_locationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInner_3dMap_locationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_Handler ()
		{
			if (cb_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_ == null)
				cb_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_);
			return cb_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_;
		}

		static void n_OnLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.IInner_3dMap_locationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location p0 = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_;
		public unsafe void OnLocationChanged (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location p0)
		{
			if (id_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_ == IntPtr.Zero)
				id_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_location;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_location_, __args);
		}

	}

	// event args for com.autonavi.amap.mapcore2d.Inner_3dMap_locationListener.onLocationChanged
	public partial class Inner_3dMap_locationEventArgs : global::System.EventArgs {

		public Inner_3dMap_locationEventArgs (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location p0)
		{
			this.p0 = p0;
		}

		global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location p0;
		public global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/autonavi/amap/mapcore2d/Inner_3dMap_locationListenerImplementor")]
	internal sealed partial class IInner_3dMap_locationListenerImplementor : global::Java.Lang.Object, IInner_3dMap_locationListener {

		object sender;

		public IInner_3dMap_locationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/autonavi/amap/mapcore2d/Inner_3dMap_locationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<Inner_3dMap_locationEventArgs> Handler;
#pragma warning restore 0649

		public void OnLocationChanged (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_location p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new Inner_3dMap_locationEventArgs (p0));
		}

		internal static bool __IsEmpty (IInner_3dMap_locationListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
