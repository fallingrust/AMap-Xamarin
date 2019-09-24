using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']"
	[Register ("com/amap/api/interfaces/IPolyline", "", "Com.Amap.Api.Interfaces.IPolylineInvoker")]
	public partial interface IPolyline : global::Com.Amap.Api.Interfaces.IOverlay {

		int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] set;
		}

		bool DottedLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='isDottedLine' and count(parameter)=0]"
			[Register ("isDottedLine", "()Z", "GetIsDottedLineHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='setDottedLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDottedLine", "(Z)V", "GetSetDottedLine_ZHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] set;
		}

		bool Geodesic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='isGeodesic' and count(parameter)=0]"
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='setGeodesic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGeodesic", "(Z)V", "GetSetGeodesic_ZHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] set;
		}

		global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amap.api.maps2d.model.LatLng&gt;']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] set;
		}

		float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IPolyline']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWidth", "(F)V", "GetSetWidth_FHandler:Com.Amap.Api.Interfaces.IPolylineInvoker, AMap")] set;
		}

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IPolyline", DoNotGenerateAcw=true)]
	internal class IPolylineInvoker : global::Java.Lang.Object, IPolyline {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IPolyline", typeof (IPolylineInvoker));

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

		public static IPolyline GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPolyline> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IPolyline"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPolylineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		IntPtr id_getColor;
		IntPtr id_setColor_I;
		public unsafe int Color {
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
			}
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_I, __args);
			}
		}

		static Delegate cb_isDottedLine;
#pragma warning disable 0169
		static Delegate GetIsDottedLineHandler ()
		{
			if (cb_isDottedLine == null)
				cb_isDottedLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDottedLine);
			return cb_isDottedLine;
		}

		static bool n_IsDottedLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DottedLine;
		}
#pragma warning restore 0169

		static Delegate cb_setDottedLine_Z;
#pragma warning disable 0169
		static Delegate GetSetDottedLine_ZHandler ()
		{
			if (cb_setDottedLine_Z == null)
				cb_setDottedLine_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDottedLine_Z);
			return cb_setDottedLine_Z;
		}

		static void n_SetDottedLine_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DottedLine = p0;
		}
#pragma warning restore 0169

		IntPtr id_isDottedLine;
		IntPtr id_setDottedLine_Z;
		public unsafe bool DottedLine {
			get {
				if (id_isDottedLine == IntPtr.Zero)
					id_isDottedLine = JNIEnv.GetMethodID (class_ref, "isDottedLine", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDottedLine);
			}
			set {
				if (id_setDottedLine_Z == IntPtr.Zero)
					id_setDottedLine_Z = JNIEnv.GetMethodID (class_ref, "setDottedLine", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDottedLine_Z, __args);
			}
		}

		static Delegate cb_isGeodesic;
#pragma warning disable 0169
		static Delegate GetIsGeodesicHandler ()
		{
			if (cb_isGeodesic == null)
				cb_isGeodesic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGeodesic);
			return cb_isGeodesic;
		}

		static bool n_IsGeodesic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Geodesic;
		}
#pragma warning restore 0169

		static Delegate cb_setGeodesic_Z;
#pragma warning disable 0169
		static Delegate GetSetGeodesic_ZHandler ()
		{
			if (cb_setGeodesic_Z == null)
				cb_setGeodesic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGeodesic_Z);
			return cb_setGeodesic_Z;
		}

		static void n_SetGeodesic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Geodesic = p0;
		}
#pragma warning restore 0169

		IntPtr id_isGeodesic;
		IntPtr id_setGeodesic_Z;
		public unsafe bool Geodesic {
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGeodesic);
			}
			set {
				if (id_setGeodesic_Z == IntPtr.Zero)
					id_setGeodesic_Z = JNIEnv.GetMethodID (class_ref, "setGeodesic", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGeodesic_Z, __args);
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.LatLng>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static Delegate cb_setPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoints_Ljava_util_List_Handler ()
		{
			if (cb_setPoints_Ljava_util_List_ == null)
				cb_setPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoints_Ljava_util_List_);
			return cb_setPoints_Ljava_util_List_;
		}

		static void n_SetPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Points = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPoints;
		IntPtr id_setPoints_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.LatLng> Points {
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.LatLng>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoints_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_F;
#pragma warning disable 0169
		static Delegate GetSetWidth_FHandler ()
		{
			if (cb_setWidth_F == null)
				cb_setWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWidth_F);
			return cb_setWidth_F;
		}

		static void n_SetWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		IntPtr id_setWidth_F;
		public unsafe float Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
			}
			set {
				if (id_setWidth_F == IntPtr.Zero)
					id_setWidth_F = JNIEnv.GetMethodID (class_ref, "setWidth", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_F, __args);
			}
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IPolyline __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IPolyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
