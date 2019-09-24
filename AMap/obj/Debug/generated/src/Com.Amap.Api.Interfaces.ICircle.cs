using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']"
	[Register ("com/amap/api/interfaces/ICircle", "", "Com.Amap.Api.Interfaces.ICircleInvoker")]
	public partial interface ICircle : global::Com.Amap.Api.Interfaces.IOverlay {

		global::Com.Amap.Api.Maps2d.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetCenterHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setCenter", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetCenter_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] set;
		}

		int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] set;
		}

		double Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()D", "GetGetRadiusHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRadius", "(D)V", "GetSetRadius_DHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] set;
		}

		int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] set;
		}

		float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ICircle']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("contains", "(Lcom/amap/api/maps2d/model/LatLng;)Z", "GetContains_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.ICircleInvoker, AMap")]
		bool Contains (global::Com.Amap.Api.Maps2d.Model.LatLng p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/ICircle", DoNotGenerateAcw=true)]
	internal class ICircleInvoker : global::Java.Lang.Object, ICircle {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/ICircle", typeof (ICircleInvoker));

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

		public static ICircle GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICircle> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.ICircle"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICircleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		static Delegate cb_setCenter_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_setCenter_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_setCenter_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_setCenter_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static void n_SetCenter_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Center = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCenter;
		IntPtr id_setCenter_Lcom_amap_api_maps2d_model_LatLng_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLng Center {
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/amap/api/maps2d/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCenter_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
					id_setCenter_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lcom/amap/api/maps2d/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCenter_Lcom_amap_api_maps2d_model_LatLng_, __args);
			}
		}

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
			return cb_getFillColor;
		}

		static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillColor_IHandler ()
		{
			if (cb_setFillColor_I == null)
				cb_setFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColor_I);
			return cb_setFillColor_I;
		}

		static void n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFillColor;
		IntPtr id_setFillColor_I;
		public unsafe int FillColor {
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor);
			}
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFillColor_I, __args);
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRadius);
			return cb_getRadius;
		}

		static double n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_D;
#pragma warning disable 0169
		static Delegate GetSetRadius_DHandler ()
		{
			if (cb_setRadius_D == null)
				cb_setRadius_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRadius_D);
			return cb_setRadius_D;
		}

		static void n_SetRadius_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRadius;
		IntPtr id_setRadius_D;
		public unsafe double Radius {
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRadius);
			}
			set {
				if (id_setRadius_D == IntPtr.Zero)
					id_setRadius_D = JNIEnv.GetMethodID (class_ref, "setRadius", "(D)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_D, __args);
			}
		}

		static Delegate cb_getStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetStrokeColorHandler ()
		{
			if (cb_getStrokeColor == null)
				cb_getStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeColor);
			return cb_getStrokeColor;
		}

		static int n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeColor;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeColor_IHandler ()
		{
			if (cb_setStrokeColor_I == null)
				cb_setStrokeColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeColor_I);
			return cb_setStrokeColor_I;
		}

		static void n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStrokeColor;
		IntPtr id_setStrokeColor_I;
		public unsafe int StrokeColor {
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeColor);
			}
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeColor_I, __args);
			}
		}

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static float n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_FHandler ()
		{
			if (cb_setStrokeWidth_F == null)
				cb_setStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStrokeWidth_F);
			return cb_setStrokeWidth_F;
		}

		static void n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeWidth = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStrokeWidth;
		IntPtr id_setStrokeWidth_F;
		public unsafe float StrokeWidth {
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeWidth);
			}
			set {
				if (id_setStrokeWidth_F == IntPtr.Zero)
					id_setStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeWidth_F, __args);
			}
		}

		static Delegate cb_contains_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_contains_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_contains_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_contains_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static bool n_Contains_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Lcom_amap_api_maps2d_model_LatLng_;
		public unsafe bool Contains (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			if (id_contains_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
				id_contains_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/amap/api/maps2d/model/LatLng;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lcom_amap_api_maps2d_model_LatLng_, __args);
			return __ret;
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		IntPtr id_setVisible_Z;
		public unsafe bool Visible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisible_Z, __args);
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZIndex);
			return cb_getZIndex;
		}

		static float n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_F;
#pragma warning disable 0169
		static Delegate GetSetZIndex_FHandler ()
		{
			if (cb_setZIndex_F == null)
				cb_setZIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZIndex_F);
			return cb_setZIndex_F;
		}

		static void n_SetZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		IntPtr id_getZIndex;
		IntPtr id_setZIndex_F;
		public unsafe float ZIndex {
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getZIndex);
			}
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZIndex_F, __args);
			}
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
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_equalsRemote_Lcom_amap_api_interfaces_IOverlay_;
#pragma warning disable 0169
		static Delegate GetEqualsRemote_Lcom_amap_api_interfaces_IOverlay_Handler ()
		{
			if (cb_equalsRemote_Lcom_amap_api_interfaces_IOverlay_ == null)
				cb_equalsRemote_Lcom_amap_api_interfaces_IOverlay_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EqualsRemote_Lcom_amap_api_interfaces_IOverlay_);
			return cb_equalsRemote_Lcom_amap_api_interfaces_IOverlay_;
		}

		static bool n_EqualsRemote_Lcom_amap_api_interfaces_IOverlay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Interfaces.IOverlay p0 = (global::Com.Amap.Api.Interfaces.IOverlay)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IOverlay> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsRemote (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equalsRemote_Lcom_amap_api_interfaces_IOverlay_;
		public unsafe bool EqualsRemote (global::Com.Amap.Api.Interfaces.IOverlay p0)
		{
			if (id_equalsRemote_Lcom_amap_api_interfaces_IOverlay_ == IntPtr.Zero)
				id_equalsRemote_Lcom_amap_api_interfaces_IOverlay_ = JNIEnv.GetMethodID (class_ref, "equalsRemote", "(Lcom/amap/api/interfaces/IOverlay;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equalsRemote_Lcom_amap_api_interfaces_IOverlay_, __args);
			return __ret;
		}

		static Delegate cb_hashCodeRemote;
#pragma warning disable 0169
		static Delegate GetHashCodeRemoteHandler ()
		{
			if (cb_hashCodeRemote == null)
				cb_hashCodeRemote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HashCodeRemote);
			return cb_hashCodeRemote;
		}

		static int n_HashCodeRemote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HashCodeRemote ();
		}
#pragma warning restore 0169

		IntPtr id_hashCodeRemote;
		public unsafe int HashCodeRemote ()
		{
			if (id_hashCodeRemote == IntPtr.Zero)
				id_hashCodeRemote = JNIEnv.GetMethodID (class_ref, "hashCodeRemote", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCodeRemote);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ICircle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ICircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
		}

	}

}
