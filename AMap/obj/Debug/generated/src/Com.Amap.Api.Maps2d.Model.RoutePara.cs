using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/RoutePara", DoNotGenerateAcw=true)]
	public partial class RoutePara : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/RoutePara", typeof (RoutePara));
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

		protected RoutePara (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/constructor[@name='RoutePara' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RoutePara ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDrivingRouteStyle;
#pragma warning disable 0169
		static Delegate GetGetDrivingRouteStyleHandler ()
		{
			if (cb_getDrivingRouteStyle == null)
				cb_getDrivingRouteStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDrivingRouteStyle);
			return cb_getDrivingRouteStyle;
		}

		static int n_GetDrivingRouteStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrivingRouteStyle;
		}
#pragma warning restore 0169

		static Delegate cb_setDrivingRouteStyle_I;
#pragma warning disable 0169
		static Delegate GetSetDrivingRouteStyle_IHandler ()
		{
			if (cb_setDrivingRouteStyle_I == null)
				cb_setDrivingRouteStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDrivingRouteStyle_I);
			return cb_setDrivingRouteStyle_I;
		}

		static void n_SetDrivingRouteStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrivingRouteStyle = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int DrivingRouteStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='getDrivingRouteStyle' and count(parameter)=0]"
			[Register ("getDrivingRouteStyle", "()I", "GetGetDrivingRouteStyleHandler")]
			get {
				const string __id = "getDrivingRouteStyle.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='setDrivingRouteStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrivingRouteStyle", "(I)V", "GetSetDrivingRouteStyle_IHandler")]
			set {
				const string __id = "setDrivingRouteStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEndName;
#pragma warning disable 0169
		static Delegate GetGetEndNameHandler ()
		{
			if (cb_getEndName == null)
				cb_getEndName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndName);
			return cb_getEndName;
		}

		static IntPtr n_GetEndName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EndName);
		}
#pragma warning restore 0169

		static Delegate cb_setEndName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEndName_Ljava_lang_String_Handler ()
		{
			if (cb_setEndName_Ljava_lang_String_ == null)
				cb_setEndName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndName_Ljava_lang_String_);
			return cb_setEndName_Ljava_lang_String_;
		}

		static void n_SetEndName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string EndName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='getEndName' and count(parameter)=0]"
			[Register ("getEndName", "()Ljava/lang/String;", "GetGetEndNameHandler")]
			get {
				const string __id = "getEndName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='setEndName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEndName", "(Ljava/lang/String;)V", "GetSetEndName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEndName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEndPoint;
#pragma warning disable 0169
		static Delegate GetGetEndPointHandler ()
		{
			if (cb_getEndPoint == null)
				cb_getEndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndPoint);
			return cb_getEndPoint;
		}

		static IntPtr n_GetEndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndPoint);
		}
#pragma warning restore 0169

		static Delegate cb_setEndPoint_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetEndPoint_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_setEndPoint_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_setEndPoint_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndPoint_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_setEndPoint_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static void n_SetEndPoint_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndPoint = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.LatLng EndPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='getEndPoint' and count(parameter)=0]"
			[Register ("getEndPoint", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetEndPointHandler")]
			get {
				const string __id = "getEndPoint.()Lcom/amap/api/maps2d/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='setEndPoint' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setEndPoint", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetEndPoint_Lcom_amap_api_maps2d_model_LatLng_Handler")]
			set {
				const string __id = "setEndPoint.(Lcom/amap/api/maps2d/model/LatLng;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartName;
#pragma warning disable 0169
		static Delegate GetGetStartNameHandler ()
		{
			if (cb_getStartName == null)
				cb_getStartName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartName);
			return cb_getStartName;
		}

		static IntPtr n_GetStartName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartName);
		}
#pragma warning restore 0169

		static Delegate cb_setStartName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStartName_Ljava_lang_String_Handler ()
		{
			if (cb_setStartName_Ljava_lang_String_ == null)
				cb_setStartName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartName_Ljava_lang_String_);
			return cb_setStartName_Ljava_lang_String_;
		}

		static void n_SetStartName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string StartName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='getStartName' and count(parameter)=0]"
			[Register ("getStartName", "()Ljava/lang/String;", "GetGetStartNameHandler")]
			get {
				const string __id = "getStartName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='setStartName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStartName", "(Ljava/lang/String;)V", "GetSetStartName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStartName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStartPoint;
#pragma warning disable 0169
		static Delegate GetGetStartPointHandler ()
		{
			if (cb_getStartPoint == null)
				cb_getStartPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartPoint);
			return cb_getStartPoint;
		}

		static IntPtr n_GetStartPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartPoint);
		}
#pragma warning restore 0169

		static Delegate cb_setStartPoint_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetStartPoint_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_setStartPoint_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_setStartPoint_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartPoint_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_setStartPoint_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static void n_SetStartPoint_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartPoint = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.LatLng StartPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='getStartPoint' and count(parameter)=0]"
			[Register ("getStartPoint", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetStartPointHandler")]
			get {
				const string __id = "getStartPoint.()Lcom/amap/api/maps2d/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='setStartPoint' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setStartPoint", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetStartPoint_Lcom_amap_api_maps2d_model_LatLng_Handler")]
			set {
				const string __id = "setStartPoint.(Lcom/amap/api/maps2d/model/LatLng;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransitRouteStyle;
#pragma warning disable 0169
		static Delegate GetGetTransitRouteStyleHandler ()
		{
			if (cb_getTransitRouteStyle == null)
				cb_getTransitRouteStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTransitRouteStyle);
			return cb_getTransitRouteStyle;
		}

		static int n_GetTransitRouteStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransitRouteStyle;
		}
#pragma warning restore 0169

		static Delegate cb_setTransitRouteStyle_I;
#pragma warning disable 0169
		static Delegate GetSetTransitRouteStyle_IHandler ()
		{
			if (cb_setTransitRouteStyle_I == null)
				cb_setTransitRouteStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTransitRouteStyle_I);
			return cb_setTransitRouteStyle_I;
		}

		static void n_SetTransitRouteStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.RoutePara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.RoutePara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransitRouteStyle = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TransitRouteStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='getTransitRouteStyle' and count(parameter)=0]"
			[Register ("getTransitRouteStyle", "()I", "GetGetTransitRouteStyleHandler")]
			get {
				const string __id = "getTransitRouteStyle.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='RoutePara']/method[@name='setTransitRouteStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTransitRouteStyle", "(I)V", "GetSetTransitRouteStyle_IHandler")]
			set {
				const string __id = "setTransitRouteStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
