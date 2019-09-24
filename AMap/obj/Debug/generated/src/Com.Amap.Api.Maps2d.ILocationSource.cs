using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='LocationSource.OnLocationChangedListener']"
	[Register ("com/amap/api/maps2d/LocationSource$OnLocationChangedListener", "", "Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListenerInvoker")]
	public partial interface ILocationSourceOnLocationChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='LocationSource.OnLocationChangedListener']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler:Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListenerInvoker, AMap")]
		void OnLocationChanged (global::Android.Locations.Location p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/maps2d/LocationSource$OnLocationChangedListener", DoNotGenerateAcw=true)]
	internal class ILocationSourceOnLocationChangedListenerInvoker : global::Java.Lang.Object, ILocationSourceOnLocationChangedListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/LocationSource$OnLocationChangedListener", typeof (ILocationSourceOnLocationChangedListenerInvoker));

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

		public static ILocationSourceOnLocationChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationSourceOnLocationChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.LocationSource.OnLocationChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationSourceOnLocationChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Landroid_location_Location_;
		public unsafe void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Landroid_location_Location_, __args);
		}

	}

	// event args for com.amap.api.maps2d.LocationSource.OnLocationChangedListener.onLocationChanged
	public partial class LocationSourceOnLocationChangedEventArgs : global::System.EventArgs {

		public LocationSourceOnLocationChangedEventArgs (global::Android.Locations.Location p0)
		{
			this.p0 = p0;
		}

		global::Android.Locations.Location p0;
		public global::Android.Locations.Location P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/LocationSource_OnLocationChangedListenerImplementor")]
	internal sealed partial class ILocationSourceOnLocationChangedListenerImplementor : global::Java.Lang.Object, ILocationSourceOnLocationChangedListener {

		object sender;

		public ILocationSourceOnLocationChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/LocationSource_OnLocationChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LocationSourceOnLocationChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnLocationChanged (global::Android.Locations.Location p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LocationSourceOnLocationChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (ILocationSourceOnLocationChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='LocationSource']"
	[Register ("com/amap/api/maps2d/LocationSource", "", "Com.Amap.Api.Maps2d.ILocationSourceInvoker")]
	public partial interface ILocationSource : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='LocationSource']/method[@name='activate' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.LocationSource.OnLocationChangedListener']]"
		[Register ("activate", "(Lcom/amap/api/maps2d/LocationSource$OnLocationChangedListener;)V", "GetActivate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_Handler:Com.Amap.Api.Maps2d.ILocationSourceInvoker, AMap")]
		void Activate (global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='LocationSource']/method[@name='deactivate' and count(parameter)=0]"
		[Register ("deactivate", "()V", "GetDeactivateHandler:Com.Amap.Api.Maps2d.ILocationSourceInvoker, AMap")]
		void Deactivate ();

	}

	[global::Android.Runtime.Register ("com/amap/api/maps2d/LocationSource", DoNotGenerateAcw=true)]
	internal class ILocationSourceInvoker : global::Java.Lang.Object, ILocationSource {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/LocationSource", typeof (ILocationSourceInvoker));

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

		public static ILocationSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.LocationSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_;
#pragma warning disable 0169
		static Delegate GetActivate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_Handler ()
		{
			if (cb_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_ == null)
				cb_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_);
			return cb_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_;
		}

		static void n_Activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.ILocationSource __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.ILocationSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener p0 = (global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Activate (p0);
		}
#pragma warning restore 0169

		IntPtr id_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_;
		public unsafe void Activate (global::Com.Amap.Api.Maps2d.ILocationSourceOnLocationChangedListener p0)
		{
			if (id_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_ == IntPtr.Zero)
				id_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_ = JNIEnv.GetMethodID (class_ref, "activate", "(Lcom/amap/api/maps2d/LocationSource$OnLocationChangedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_activate_Lcom_amap_api_maps2d_LocationSource_OnLocationChangedListener_, __args);
		}

		static Delegate cb_deactivate;
#pragma warning disable 0169
		static Delegate GetDeactivateHandler ()
		{
			if (cb_deactivate == null)
				cb_deactivate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deactivate);
			return cb_deactivate;
		}

		static void n_Deactivate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.ILocationSource __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.ILocationSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		IntPtr id_deactivate;
		public unsafe void Deactivate ()
		{
			if (id_deactivate == IntPtr.Zero)
				id_deactivate = JNIEnv.GetMethodID (class_ref, "deactivate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deactivate);
		}

	}

}
