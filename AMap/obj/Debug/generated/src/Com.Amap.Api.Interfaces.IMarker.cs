using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']"
	[Register ("com/amap/api/interfaces/IMarker", "", "Com.Amap.Api.Interfaces.IMarkerInvoker")]
	public partial interface IMarker : IJavaObject {

		bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> Icons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getIcons' and count(parameter)=0]"
			[Register ("getIcons", "()Ljava/util/ArrayList;", "GetGetIconsHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setIcons' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.amap.api.maps2d.model.BitmapDescriptor&gt;']]"
			[Register ("setIcons", "(Ljava/util/ArrayList;)V", "GetSetIcons_Ljava_util_ArrayList_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
		}

		bool IsInfoWindowShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='isInfoWindowShown' and count(parameter)=0]"
			[Register ("isInfoWindowShown", "()Z", "GetIsInfoWindowShownHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
		}

		bool IsViewMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='isViewMode' and count(parameter)=0]"
			[Register ("isViewMode", "()Z", "GetIsViewModeHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
		}

		global::Java.Lang.Object Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setObject", "(Ljava/lang/Object;)V", "GetSetObject_Ljava_lang_Object_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		int Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()I", "GetGetPeriodHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPeriod", "(I)V", "GetSetPeriod_IHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		global::Com.Amap.Api.Maps2d.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetPositionHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setPosition", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetPosition_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		global::Com.Amap.Api.Maps2d.Model.LatLng RealPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getRealPosition' and count(parameter)=0]"
			[Register ("getRealPosition", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetRealPositionHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
		}

		string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
		}

		float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='equalsRemote' and count(parameter)=1 and parameter[1][@type='com.amap.api.interfaces.IMarker']]"
		[Register ("equalsRemote", "(Lcom/amap/api/interfaces/IMarker;)Z", "GetEqualsRemote_Lcom_amap_api_interfaces_IMarker_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		bool EqualsRemote (global::Com.Amap.Api.Interfaces.IMarker p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='hashCodeRemote' and count(parameter)=0]"
		[Register ("hashCodeRemote", "()I", "GetHashCodeRemoteHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		int HashCodeRemote ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "GetHideInfoWindowHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void HideInfoWindow ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()Z", "GetRemoveHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		bool Remove ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "GetSetAnchor_FFHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void SetAnchor (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.BitmapDescriptor']]"
		[Register ("setIcon", "(Lcom/amap/api/maps2d/model/BitmapDescriptor;)V", "GetSetIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_Handler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void SetIcon (global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setPositionByPixels' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setPositionByPixels", "(II)V", "GetSetPositionByPixels_IIHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void SetPositionByPixels (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='setRotateAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotateAngle", "(F)V", "GetSetRotateAngle_FHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void SetRotateAngle (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IMarker']/method[@name='showInfoWindow' and count(parameter)=0]"
		[Register ("showInfoWindow", "()V", "GetShowInfoWindowHandler:Com.Amap.Api.Interfaces.IMarkerInvoker, AMap")]
		void ShowInfoWindow ();

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IMarker", DoNotGenerateAcw=true)]
	internal class IMarkerInvoker : global::Java.Lang.Object, IMarker {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IMarker", typeof (IMarkerInvoker));

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

		public static IMarker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMarker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IMarker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMarkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isDraggable;
#pragma warning disable 0169
		static Delegate GetIsDraggableHandler ()
		{
			if (cb_isDraggable == null)
				cb_isDraggable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDraggable);
			return cb_isDraggable;
		}

		static bool n_IsDraggable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Draggable;
		}
#pragma warning restore 0169

		static Delegate cb_setDraggable_Z;
#pragma warning disable 0169
		static Delegate GetSetDraggable_ZHandler ()
		{
			if (cb_setDraggable_Z == null)
				cb_setDraggable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDraggable_Z);
			return cb_setDraggable_Z;
		}

		static void n_SetDraggable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draggable = p0;
		}
#pragma warning restore 0169

		IntPtr id_isDraggable;
		IntPtr id_setDraggable_Z;
		public unsafe bool Draggable {
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDraggable);
			}
			set {
				if (id_setDraggable_Z == IntPtr.Zero)
					id_setDraggable_Z = JNIEnv.GetMethodID (class_ref, "setDraggable", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDraggable_Z, __args);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
			}
		}

		static Delegate cb_getIcons;
#pragma warning disable 0169
		static Delegate GetGetIconsHandler ()
		{
			if (cb_getIcons == null)
				cb_getIcons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcons);
			return cb_getIcons;
		}

		static IntPtr n_GetIcons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor>.ToLocalJniHandle (__this.Icons);
		}
#pragma warning restore 0169

		static Delegate cb_setIcons_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetIcons_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setIcons_Ljava_util_ArrayList_ == null)
				cb_setIcons_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcons_Ljava_util_ArrayList_);
			return cb_setIcons_Ljava_util_ArrayList_;
		}

		static void n_SetIcons_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Icons = p0;
		}
#pragma warning restore 0169

		IntPtr id_getIcons;
		IntPtr id_setIcons_Ljava_util_ArrayList_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> Icons {
			get {
				if (id_getIcons == IntPtr.Zero)
					id_getIcons = JNIEnv.GetMethodID (class_ref, "getIcons", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcons), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setIcons_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_setIcons_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setIcons", "(Ljava/util/ArrayList;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcons_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_isInfoWindowShown;
#pragma warning disable 0169
		static Delegate GetIsInfoWindowShownHandler ()
		{
			if (cb_isInfoWindowShown == null)
				cb_isInfoWindowShown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInfoWindowShown);
			return cb_isInfoWindowShown;
		}

		static bool n_IsInfoWindowShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfoWindowShown;
		}
#pragma warning restore 0169

		IntPtr id_isInfoWindowShown;
		public unsafe bool IsInfoWindowShown {
			get {
				if (id_isInfoWindowShown == IntPtr.Zero)
					id_isInfoWindowShown = JNIEnv.GetMethodID (class_ref, "isInfoWindowShown", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInfoWindowShown);
			}
		}

		static Delegate cb_isViewMode;
#pragma warning disable 0169
		static Delegate GetIsViewModeHandler ()
		{
			if (cb_isViewMode == null)
				cb_isViewMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsViewMode);
			return cb_isViewMode;
		}

		static bool n_IsViewMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsViewMode;
		}
#pragma warning restore 0169

		IntPtr id_isViewMode;
		public unsafe bool IsViewMode {
			get {
				if (id_isViewMode == IntPtr.Zero)
					id_isViewMode = JNIEnv.GetMethodID (class_ref, "isViewMode", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewMode);
			}
		}

		static Delegate cb_getObject;
#pragma warning disable 0169
		static Delegate GetGetObjectHandler ()
		{
			if (cb_getObject == null)
				cb_getObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObject);
			return cb_getObject;
		}

		static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Object);
		}
#pragma warning restore 0169

		static Delegate cb_setObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setObject_Ljava_lang_Object_ == null)
				cb_setObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObject_Ljava_lang_Object_);
			return cb_setObject_Ljava_lang_Object_;
		}

		static void n_SetObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Object = p0;
		}
#pragma warning restore 0169

		IntPtr id_getObject;
		IntPtr id_setObject_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Object {
			get {
				if (id_getObject == IntPtr.Zero)
					id_getObject = JNIEnv.GetMethodID (class_ref, "getObject", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setObject_Ljava_lang_Object_ == IntPtr.Zero)
					id_setObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setObject", "(Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setObject_Ljava_lang_Object_, __args);
			}
		}

		static Delegate cb_getPeriod;
#pragma warning disable 0169
		static Delegate GetGetPeriodHandler ()
		{
			if (cb_getPeriod == null)
				cb_getPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPeriod);
			return cb_getPeriod;
		}

		static int n_GetPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Period;
		}
#pragma warning restore 0169

		static Delegate cb_setPeriod_I;
#pragma warning disable 0169
		static Delegate GetSetPeriod_IHandler ()
		{
			if (cb_setPeriod_I == null)
				cb_setPeriod_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPeriod_I);
			return cb_setPeriod_I;
		}

		static void n_SetPeriod_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Period = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPeriod;
		IntPtr id_setPeriod_I;
		public unsafe int Period {
			get {
				if (id_getPeriod == IntPtr.Zero)
					id_getPeriod = JNIEnv.GetMethodID (class_ref, "getPeriod", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPeriod);
			}
			set {
				if (id_setPeriod_I == IntPtr.Zero)
					id_setPeriod_I = JNIEnv.GetMethodID (class_ref, "setPeriod", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPeriod_I, __args);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getRealPosition;
#pragma warning disable 0169
		static Delegate GetGetRealPositionHandler ()
		{
			if (cb_getRealPosition == null)
				cb_getRealPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRealPosition);
			return cb_getRealPosition;
		}

		static IntPtr n_GetRealPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RealPosition);
		}
#pragma warning restore 0169

		IntPtr id_getRealPosition;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLng RealPosition {
			get {
				if (id_getRealPosition == IntPtr.Zero)
					id_getRealPosition = JNIEnv.GetMethodID (class_ref, "getRealPosition", "()Lcom/amap/api/maps2d/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRealPosition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSnippet;
#pragma warning disable 0169
		static Delegate GetGetSnippetHandler ()
		{
			if (cb_getSnippet == null)
				cb_getSnippet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSnippet);
			return cb_getSnippet;
		}

		static IntPtr n_GetSnippet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Snippet);
		}
#pragma warning restore 0169

		static Delegate cb_setSnippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_setSnippet_Ljava_lang_String_ == null)
				cb_setSnippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSnippet_Ljava_lang_String_);
			return cb_setSnippet_Ljava_lang_String_;
		}

		static void n_SetSnippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Snippet = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSnippet;
		IntPtr id_setSnippet_Ljava_lang_String_;
		public unsafe string Snippet {
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSnippet_Ljava_lang_String_ == IntPtr.Zero)
					id_setSnippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSnippet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSnippet_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		IntPtr id_setTitle_Ljava_lang_String_;
		public unsafe string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public unsafe int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_equalsRemote_Lcom_amap_api_interfaces_IMarker_;
#pragma warning disable 0169
		static Delegate GetEqualsRemote_Lcom_amap_api_interfaces_IMarker_Handler ()
		{
			if (cb_equalsRemote_Lcom_amap_api_interfaces_IMarker_ == null)
				cb_equalsRemote_Lcom_amap_api_interfaces_IMarker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EqualsRemote_Lcom_amap_api_interfaces_IMarker_);
			return cb_equalsRemote_Lcom_amap_api_interfaces_IMarker_;
		}

		static bool n_EqualsRemote_Lcom_amap_api_interfaces_IMarker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Interfaces.IMarker p0 = (global::Com.Amap.Api.Interfaces.IMarker)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsRemote (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equalsRemote_Lcom_amap_api_interfaces_IMarker_;
		public unsafe bool EqualsRemote (global::Com.Amap.Api.Interfaces.IMarker p0)
		{
			if (id_equalsRemote_Lcom_amap_api_interfaces_IMarker_ == IntPtr.Zero)
				id_equalsRemote_Lcom_amap_api_interfaces_IMarker_ = JNIEnv.GetMethodID (class_ref, "equalsRemote", "(Lcom/amap/api/interfaces/IMarker;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equalsRemote_Lcom_amap_api_interfaces_IMarker_, __args);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_hideInfoWindow;
#pragma warning disable 0169
		static Delegate GetHideInfoWindowHandler ()
		{
			if (cb_hideInfoWindow == null)
				cb_hideInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInfoWindow);
			return cb_hideInfoWindow;
		}

		static void n_HideInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInfoWindow ();
		}
#pragma warning restore 0169

		IntPtr id_hideInfoWindow;
		public unsafe void HideInfoWindow ()
		{
			if (id_hideInfoWindow == IntPtr.Zero)
				id_hideInfoWindow = JNIEnv.GetMethodID (class_ref, "hideInfoWindow", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideInfoWindow);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Remove);
			return cb_remove;
		}

		static bool n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remove ();
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public unsafe bool Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove);
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
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_Handler ()
		{
			if (cb_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ == null)
				cb_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_);
			return cb_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
		}

		static void n_SetIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		IntPtr id_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
		public unsafe void SetIcon (global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0)
		{
			if (id_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ == IntPtr.Zero)
				id_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Lcom/amap/api/maps2d/model/BitmapDescriptor;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_, __args);
		}

		static Delegate cb_setPositionByPixels_II;
#pragma warning disable 0169
		static Delegate GetSetPositionByPixels_IIHandler ()
		{
			if (cb_setPositionByPixels_II == null)
				cb_setPositionByPixels_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetPositionByPixels_II);
			return cb_setPositionByPixels_II;
		}

		static void n_SetPositionByPixels_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPositionByPixels (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPositionByPixels_II;
		public unsafe void SetPositionByPixels (int p0, int p1)
		{
			if (id_setPositionByPixels_II == IntPtr.Zero)
				id_setPositionByPixels_II = JNIEnv.GetMethodID (class_ref, "setPositionByPixels", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPositionByPixels_II, __args);
		}

		static Delegate cb_setRotateAngle_F;
#pragma warning disable 0169
		static Delegate GetSetRotateAngle_FHandler ()
		{
			if (cb_setRotateAngle_F == null)
				cb_setRotateAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotateAngle_F);
			return cb_setRotateAngle_F;
		}

		static void n_SetRotateAngle_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotateAngle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRotateAngle_F;
		public unsafe void SetRotateAngle (float p0)
		{
			if (id_setRotateAngle_F == IntPtr.Zero)
				id_setRotateAngle_F = JNIEnv.GetMethodID (class_ref, "setRotateAngle", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotateAngle_F, __args);
		}

		static Delegate cb_showInfoWindow;
#pragma warning disable 0169
		static Delegate GetShowInfoWindowHandler ()
		{
			if (cb_showInfoWindow == null)
				cb_showInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInfoWindow);
			return cb_showInfoWindow;
		}

		static void n_ShowInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IMarker __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInfoWindow ();
		}
#pragma warning restore 0169

		IntPtr id_showInfoWindow;
		public unsafe void ShowInfoWindow ()
		{
			if (id_showInfoWindow == IntPtr.Zero)
				id_showInfoWindow = JNIEnv.GetMethodID (class_ref, "showInfoWindow", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showInfoWindow);
		}

	}

}
