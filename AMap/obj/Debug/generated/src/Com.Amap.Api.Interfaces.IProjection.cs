using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IProjection']"
	[Register ("com/amap/api/interfaces/IProjection", "", "Com.Amap.Api.Interfaces.IProjectionInvoker")]
	public partial interface IProjection : IJavaObject {

		global::Com.Amap.Api.Maps2d.Model.VisibleRegion VisibleRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IProjection']/method[@name='getVisibleRegion' and count(parameter)=0]"
			[Register ("getVisibleRegion", "()Lcom/amap/api/maps2d/model/VisibleRegion;", "GetGetVisibleRegionHandler:Com.Amap.Api.Interfaces.IProjectionInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IProjection']/method[@name='fromScreenLocation' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("fromScreenLocation", "(Landroid/graphics/Point;)Lcom/amap/api/maps2d/model/LatLng;", "GetFromScreenLocation_Landroid_graphics_Point_Handler:Com.Amap.Api.Interfaces.IProjectionInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IProjection']/method[@name='toMapLocation' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("toMapLocation", "(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/PointF;", "GetToMapLocation_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.IProjectionInvoker, AMap")]
		global::Android.Graphics.PointF ToMapLocation (global::Com.Amap.Api.Maps2d.Model.LatLng p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IProjection']/method[@name='toScreenLocation' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("toScreenLocation", "(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/Point;", "GetToScreenLocation_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.IProjectionInvoker, AMap")]
		global::Android.Graphics.Point ToScreenLocation (global::Com.Amap.Api.Maps2d.Model.LatLng p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IProjection", DoNotGenerateAcw=true)]
	internal class IProjectionInvoker : global::Java.Lang.Object, IProjection {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IProjection", typeof (IProjectionInvoker));

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

		public static IProjection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProjection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IProjection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProjectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getVisibleRegion;
#pragma warning disable 0169
		static Delegate GetGetVisibleRegionHandler ()
		{
			if (cb_getVisibleRegion == null)
				cb_getVisibleRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibleRegion);
			return cb_getVisibleRegion;
		}

		static IntPtr n_GetVisibleRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IProjection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRegion);
		}
#pragma warning restore 0169

		IntPtr id_getVisibleRegion;
		public unsafe global::Com.Amap.Api.Maps2d.Model.VisibleRegion VisibleRegion {
			get {
				if (id_getVisibleRegion == IntPtr.Zero)
					id_getVisibleRegion = JNIEnv.GetMethodID (class_ref, "getVisibleRegion", "()Lcom/amap/api/maps2d/model/VisibleRegion;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.VisibleRegion> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVisibleRegion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_fromScreenLocation_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetFromScreenLocation_Landroid_graphics_Point_Handler ()
		{
			if (cb_fromScreenLocation_Landroid_graphics_Point_ == null)
				cb_fromScreenLocation_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromScreenLocation_Landroid_graphics_Point_);
			return cb_fromScreenLocation_Landroid_graphics_Point_;
		}

		static IntPtr n_FromScreenLocation_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IProjection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_fromScreenLocation_Landroid_graphics_Point_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0)
		{
			if (id_fromScreenLocation_Landroid_graphics_Point_ == IntPtr.Zero)
				id_fromScreenLocation_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "fromScreenLocation", "(Landroid/graphics/Point;)Lcom/amap/api/maps2d/model/LatLng;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.LatLng __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromScreenLocation_Landroid_graphics_Point_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetToMapLocation_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToMapLocation_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static IntPtr n_ToMapLocation_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IProjection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToMapLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_;
		public unsafe global::Android.Graphics.PointF ToMapLocation (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			if (id_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
				id_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "toMapLocation", "(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/PointF;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Android.Graphics.PointF __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toMapLocation_Lcom_amap_api_maps2d_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetToScreenLocation_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToScreenLocation_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static IntPtr n_ToScreenLocation_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IProjection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_;
		public unsafe global::Android.Graphics.Point ToScreenLocation (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			if (id_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
				id_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "toScreenLocation", "(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/Point;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toScreenLocation_Lcom_amap_api_maps2d_model_LatLng_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
