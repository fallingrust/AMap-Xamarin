using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']"
	[Register ("com/amap/api/interfaces/IGroundOverlay", "", "Com.Amap.Api.Interfaces.IGroundOverlayInvoker")]
	public partial interface IGroundOverlay : IJavaObject {

		float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBearing", "(F)V", "GetSetBearing_FHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] set;
		}

		global::Com.Amap.Api.Maps2d.Model.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/amap/api/maps2d/model/LatLngBounds;", "GetGetBoundsHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] get;
		}

		float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] get;
		}

		global::Com.Amap.Api.Maps2d.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetPositionHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setPosition", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetPosition_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] set;
		}

		float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setTransparency' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTransparency", "(F)V", "GetSetTransparency_FHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] set;
		}

		float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "GetSetAnchor_FFHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")]
		void SetAnchor (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setDimensions' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDimensions", "(F)V", "GetSetDimensions_FHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")]
		void SetDimensions (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setDimensions", "(FF)V", "GetSetDimensions_FFHandler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")]
		void SetDimensions (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.BitmapDescriptor']]"
		[Register ("setImage", "(Lcom/amap/api/maps2d/model/BitmapDescriptor;)V", "GetSetImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_Handler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")]
		void SetImage (global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IGroundOverlay']/method[@name='setPositionFromBounds' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLngBounds']]"
		[Register ("setPositionFromBounds", "(Lcom/amap/api/maps2d/model/LatLngBounds;)V", "GetSetPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_Handler:Com.Amap.Api.Interfaces.IGroundOverlayInvoker, AMap")]
		void SetPositionFromBounds (global::Com.Amap.Api.Maps2d.Model.LatLngBounds p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IGroundOverlay", DoNotGenerateAcw=true)]
	internal class IGroundOverlayInvoker : global::Java.Lang.Object, IGroundOverlay {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IGroundOverlay", typeof (IGroundOverlayInvoker));

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

		public static IGroundOverlay GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGroundOverlay> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IGroundOverlay"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGroundOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBearing;
#pragma warning disable 0169
		static Delegate GetGetBearingHandler ()
		{
			if (cb_getBearing == null)
				cb_getBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBearing);
			return cb_getBearing;
		}

		static float n_GetBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bearing;
		}
#pragma warning restore 0169

		static Delegate cb_setBearing_F;
#pragma warning disable 0169
		static Delegate GetSetBearing_FHandler ()
		{
			if (cb_setBearing_F == null)
				cb_setBearing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBearing_F);
			return cb_setBearing_F;
		}

		static void n_SetBearing_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bearing = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBearing;
		IntPtr id_setBearing_F;
		public unsafe float Bearing {
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getBearing);
			}
			set {
				if (id_setBearing_F == IntPtr.Zero)
					id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBearing_F, __args);
			}
		}

		static Delegate cb_getBounds;
#pragma warning disable 0169
		static Delegate GetGetBoundsHandler ()
		{
			if (cb_getBounds == null)
				cb_getBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBounds);
			return cb_getBounds;
		}

		static IntPtr n_GetBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bounds);
		}
#pragma warning restore 0169

		IntPtr id_getBounds;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLngBounds Bounds {
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/amap/api/maps2d/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLngBounds> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHeight);
			return cb_getHeight;
		}

		static float n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe float Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static void n_SetPosition_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Position = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPosition;
		IntPtr id_setPosition_Lcom_amap_api_maps2d_model_LatLng_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLng Position {
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/amap/api/maps2d/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPosition_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/amap/api/maps2d/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_amap_api_maps2d_model_LatLng_, __args);
			}
		}

		static Delegate cb_getTransparency;
#pragma warning disable 0169
		static Delegate GetGetTransparencyHandler ()
		{
			if (cb_getTransparency == null)
				cb_getTransparency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTransparency);
			return cb_getTransparency;
		}

		static float n_GetTransparency (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Transparency;
		}
#pragma warning restore 0169

		static Delegate cb_setTransparency_F;
#pragma warning disable 0169
		static Delegate GetSetTransparency_FHandler ()
		{
			if (cb_setTransparency_F == null)
				cb_setTransparency_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTransparency_F);
			return cb_setTransparency_F;
		}

		static void n_SetTransparency_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Transparency = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTransparency;
		IntPtr id_setTransparency_F;
		public unsafe float Transparency {
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getTransparency);
			}
			set {
				if (id_setTransparency_F == IntPtr.Zero)
					id_setTransparency_F = JNIEnv.GetMethodID (class_ref, "setTransparency", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransparency_F, __args);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public unsafe float Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
			}
		}

		static Delegate cb_setAnchor_FF;
#pragma warning disable 0169
		static Delegate GetSetAnchor_FFHandler ()
		{
			if (cb_setAnchor_FF == null)
				cb_setAnchor_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetAnchor_FF);
			return cb_setAnchor_FF;
		}

		static void n_SetAnchor_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnchor (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setAnchor_FF;
		public unsafe void SetAnchor (float p0, float p1)
		{
			if (id_setAnchor_FF == IntPtr.Zero)
				id_setAnchor_FF = JNIEnv.GetMethodID (class_ref, "setAnchor", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnchor_FF, __args);
		}

		static Delegate cb_setDimensions_F;
#pragma warning disable 0169
		static Delegate GetSetDimensions_FHandler ()
		{
			if (cb_setDimensions_F == null)
				cb_setDimensions_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDimensions_F);
			return cb_setDimensions_F;
		}

		static void n_SetDimensions_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDimensions (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDimensions_F;
		public unsafe void SetDimensions (float p0)
		{
			if (id_setDimensions_F == IntPtr.Zero)
				id_setDimensions_F = JNIEnv.GetMethodID (class_ref, "setDimensions", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDimensions_F, __args);
		}

		static Delegate cb_setDimensions_FF;
#pragma warning disable 0169
		static Delegate GetSetDimensions_FFHandler ()
		{
			if (cb_setDimensions_FF == null)
				cb_setDimensions_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetDimensions_FF);
			return cb_setDimensions_FF;
		}

		static void n_SetDimensions_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDimensions (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setDimensions_FF;
		public unsafe void SetDimensions (float p0, float p1)
		{
			if (id_setDimensions_FF == IntPtr.Zero)
				id_setDimensions_FF = JNIEnv.GetMethodID (class_ref, "setDimensions", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDimensions_FF, __args);
		}

		static Delegate cb_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_Handler ()
		{
			if (cb_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_ == null)
				cb_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_);
			return cb_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
		}

		static void n_SetImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (p0);
		}
#pragma warning restore 0169

		IntPtr id_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
		public unsafe void SetImage (global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0)
		{
			if (id_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_ == IntPtr.Zero)
				id_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/amap/api/maps2d/model/BitmapDescriptor;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_amap_api_maps2d_model_BitmapDescriptor_, __args);
		}

		static Delegate cb_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetSetPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_Handler ()
		{
			if (cb_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_ == null)
				cb_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_);
			return cb_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_;
		}

		static void n_SetPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IGroundOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IGroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPositionFromBounds (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_;
		public unsafe void SetPositionFromBounds (global::Com.Amap.Api.Maps2d.Model.LatLngBounds p0)
		{
			if (id_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_ == IntPtr.Zero)
				id_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "setPositionFromBounds", "(Lcom/amap/api/maps2d/model/LatLngBounds;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPositionFromBounds_Lcom_amap_api_maps2d_model_LatLngBounds_, __args);
		}

	}

}
