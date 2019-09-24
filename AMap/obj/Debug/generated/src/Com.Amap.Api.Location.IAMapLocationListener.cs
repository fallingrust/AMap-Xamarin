using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.location']/interface[@name='AMapLocationListener']"
	[Register ("com/amap/api/location/AMapLocationListener", "", "Com.Amap.Api.Location.IAMapLocationListenerInvoker")]
	public partial interface IAMapLocationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/interface[@name='AMapLocationListener']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocation']]"
		[Register ("onLocationChanged", "(Lcom/amap/api/location/AMapLocation;)V", "GetOnLocationChanged_Lcom_amap_api_location_AMapLocation_Handler:Com.Amap.Api.Location.IAMapLocationListenerInvoker, AMap")]
		void OnLocationChanged (global::Com.Amap.Api.Location.AMapLocation p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationListener", DoNotGenerateAcw=true)]
	internal class IAMapLocationListenerInvoker : global::Java.Lang.Object, IAMapLocationListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/location/AMapLocationListener", typeof (IAMapLocationListenerInvoker));

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

		public static IAMapLocationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAMapLocationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.location.AMapLocationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAMapLocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationChanged_Lcom_amap_api_location_AMapLocation_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Lcom_amap_api_location_AMapLocation_Handler ()
		{
			if (cb_onLocationChanged_Lcom_amap_api_location_AMapLocation_ == null)
				cb_onLocationChanged_Lcom_amap_api_location_AMapLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Lcom_amap_api_location_AMapLocation_);
			return cb_onLocationChanged_Lcom_amap_api_location_AMapLocation_;
		}

		static void n_OnLocationChanged_Lcom_amap_api_location_AMapLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.IAMapLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.IAMapLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Lcom_amap_api_location_AMapLocation_;
		public unsafe void OnLocationChanged (global::Com.Amap.Api.Location.AMapLocation p0)
		{
			if (id_onLocationChanged_Lcom_amap_api_location_AMapLocation_ == IntPtr.Zero)
				id_onLocationChanged_Lcom_amap_api_location_AMapLocation_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Lcom/amap/api/location/AMapLocation;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Lcom_amap_api_location_AMapLocation_, __args);
		}

	}

	// event args for com.amap.api.location.AMapLocationListener.onLocationChanged
	public partial class AMapLocationEventArgs : global::System.EventArgs {

		public AMapLocationEventArgs (global::Com.Amap.Api.Location.AMapLocation p0)
		{
			this.p0 = p0;
		}

		global::Com.Amap.Api.Location.AMapLocation p0;
		public global::Com.Amap.Api.Location.AMapLocation P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amap/api/location/AMapLocationListenerImplementor")]
	internal sealed partial class IAMapLocationListenerImplementor : global::Java.Lang.Object, IAMapLocationListener {

		object sender;

		public IAMapLocationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/location/AMapLocationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AMapLocationEventArgs> Handler;
#pragma warning restore 0649

		public void OnLocationChanged (global::Com.Amap.Api.Location.AMapLocation p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AMapLocationEventArgs (p0));
		}

		internal static bool __IsEmpty (IAMapLocationListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
