using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='Projection']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/Projection", DoNotGenerateAcw=true)]
	public partial class Projection : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/Projection", typeof (Projection));
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

		protected Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='Projection']/constructor[@name='Projection' and count(parameter)=1 and parameter[1][@type='com.amap.api.interfaces.IProjection']]"
		[Register (".ctor", "(Lcom/amap/api/interfaces/IProjection;)V", "")]
		public unsafe Projection (global::Com.Amap.Api.Interfaces.IProjection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/amap/api/interfaces/IProjection;)V";

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
			global::Com.Amap.Api.Maps2d.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRegion);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.VisibleRegion VisibleRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='Projection']/method[@name='getVisibleRegion' and count(parameter)=0]"
			[Register ("getVisibleRegion", "()Lcom/amap/api/maps2d/model/VisibleRegion;", "GetGetVisibleRegionHandler")]
			get {
				const string __id = "getVisibleRegion.()Lcom/amap/api/maps2d/model/VisibleRegion;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.VisibleRegion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='Projection']/method[@name='fromScreenLocation' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("fromScreenLocation", "(Landroid/graphics/Point;)Lcom/amap/api/maps2d/model/LatLng;", "GetFromScreenLocation_Landroid_graphics_Point_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0)
		{
			const string __id = "fromScreenLocation.(Landroid/graphics/Point;)Lcom/amap/api/maps2d/model/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Amap.Api.Maps2d.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToMapLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='Projection']/method[@name='toMapLocation' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("toMapLocation", "(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/PointF;", "GetToMapLocation_Lcom_amap_api_maps2d_model_LatLng_Handler")]
		public virtual unsafe global::Android.Graphics.PointF ToMapLocation (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			const string __id = "toMapLocation.(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/PointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Amap.Api.Maps2d.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='Projection']/method[@name='toScreenLocation' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("toScreenLocation", "(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/Point;", "GetToScreenLocation_Lcom_amap_api_maps2d_model_LatLng_Handler")]
		public virtual unsafe global::Android.Graphics.Point ToScreenLocation (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			const string __id = "toScreenLocation.(Lcom/amap/api/maps2d/model/LatLng;)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
