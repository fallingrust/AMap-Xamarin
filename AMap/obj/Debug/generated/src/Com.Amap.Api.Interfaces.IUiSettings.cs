using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']"
	[Register ("com/amap/api/interfaces/IUiSettings", "", "Com.Amap.Api.Interfaces.IUiSettingsInvoker")]
	public partial interface IUiSettings : IJavaObject {

		bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		int LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()I", "GetGetLogoPositionHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogoPosition", "(I)V", "GetSetLogoPosition_IHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		bool MyLocationButtonEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isMyLocationButtonEnabled' and count(parameter)=0]"
			[Register ("isMyLocationButtonEnabled", "()Z", "GetIsMyLocationButtonEnabledHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setMyLocationButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationButtonEnabled", "(Z)V", "GetSetMyLocationButtonEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		bool ScaleControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isScaleControlsEnabled' and count(parameter)=0]"
			[Register ("isScaleControlsEnabled", "()Z", "GetIsScaleControlsEnabledHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setScaleControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleControlsEnabled", "(Z)V", "GetSetScaleControlsEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		bool ZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isZoomControlsEnabled' and count(parameter)=0]"
			[Register ("isZoomControlsEnabled", "()Z", "GetIsZoomControlsEnabledHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setZoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomControlsEnabled", "(Z)V", "GetSetZoomControlsEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		bool ZoomInByScreenCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='isZoomInByScreenCenter' and count(parameter)=0]"
			[Register ("isZoomInByScreenCenter", "()Z", "GetIsZoomInByScreenCenterHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setZoomInByScreenCenter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomInByScreenCenter", "(Z)V", "GetSetZoomInByScreenCenter_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		int ZoomPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='getZoomPosition' and count(parameter)=0]"
			[Register ("getZoomPosition", "()I", "GetGetZoomPositionHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setZoomPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZoomPosition", "(I)V", "GetSetZoomPosition_IHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IUiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "GetSetAllGesturesEnabled_ZHandler:Com.Amap.Api.Interfaces.IUiSettingsInvoker, AMap")]
		void SetAllGesturesEnabled (bool p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IUiSettings", DoNotGenerateAcw=true)]
	internal class IUiSettingsInvoker : global::Java.Lang.Object, IUiSettings {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IUiSettings", typeof (IUiSettingsInvoker));

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

		public static IUiSettings GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUiSettings> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IUiSettings"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUiSettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCompassEnabled;
#pragma warning disable 0169
		static Delegate GetIsCompassEnabledHandler ()
		{
			if (cb_isCompassEnabled == null)
				cb_isCompassEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompassEnabled);
			return cb_isCompassEnabled;
		}

		static bool n_IsCompassEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompassEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setCompassEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetCompassEnabled_ZHandler ()
		{
			if (cb_setCompassEnabled_Z == null)
				cb_setCompassEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCompassEnabled_Z);
			return cb_setCompassEnabled_Z;
		}

		static void n_SetCompassEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompassEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isCompassEnabled;
		IntPtr id_setCompassEnabled_Z;
		public unsafe bool CompassEnabled {
			get {
				if (id_isCompassEnabled == IntPtr.Zero)
					id_isCompassEnabled = JNIEnv.GetMethodID (class_ref, "isCompassEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCompassEnabled);
			}
			set {
				if (id_setCompassEnabled_Z == IntPtr.Zero)
					id_setCompassEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCompassEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCompassEnabled_Z, __args);
			}
		}

		static Delegate cb_getLogoPosition;
#pragma warning disable 0169
		static Delegate GetGetLogoPositionHandler ()
		{
			if (cb_getLogoPosition == null)
				cb_getLogoPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLogoPosition);
			return cb_getLogoPosition;
		}

		static int n_GetLogoPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogoPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setLogoPosition_I;
#pragma warning disable 0169
		static Delegate GetSetLogoPosition_IHandler ()
		{
			if (cb_setLogoPosition_I == null)
				cb_setLogoPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogoPosition_I);
			return cb_setLogoPosition_I;
		}

		static void n_SetLogoPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LogoPosition = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLogoPosition;
		IntPtr id_setLogoPosition_I;
		public unsafe int LogoPosition {
			get {
				if (id_getLogoPosition == IntPtr.Zero)
					id_getLogoPosition = JNIEnv.GetMethodID (class_ref, "getLogoPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLogoPosition);
			}
			set {
				if (id_setLogoPosition_I == IntPtr.Zero)
					id_setLogoPosition_I = JNIEnv.GetMethodID (class_ref, "setLogoPosition", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogoPosition_I, __args);
			}
		}

		static Delegate cb_isMyLocationButtonEnabled;
#pragma warning disable 0169
		static Delegate GetIsMyLocationButtonEnabledHandler ()
		{
			if (cb_isMyLocationButtonEnabled == null)
				cb_isMyLocationButtonEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMyLocationButtonEnabled);
			return cb_isMyLocationButtonEnabled;
		}

		static bool n_IsMyLocationButtonEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MyLocationButtonEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setMyLocationButtonEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetMyLocationButtonEnabled_ZHandler ()
		{
			if (cb_setMyLocationButtonEnabled_Z == null)
				cb_setMyLocationButtonEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMyLocationButtonEnabled_Z);
			return cb_setMyLocationButtonEnabled_Z;
		}

		static void n_SetMyLocationButtonEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MyLocationButtonEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isMyLocationButtonEnabled;
		IntPtr id_setMyLocationButtonEnabled_Z;
		public unsafe bool MyLocationButtonEnabled {
			get {
				if (id_isMyLocationButtonEnabled == IntPtr.Zero)
					id_isMyLocationButtonEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationButtonEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMyLocationButtonEnabled);
			}
			set {
				if (id_setMyLocationButtonEnabled_Z == IntPtr.Zero)
					id_setMyLocationButtonEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationButtonEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationButtonEnabled_Z, __args);
			}
		}

		static Delegate cb_isScaleControlsEnabled;
#pragma warning disable 0169
		static Delegate GetIsScaleControlsEnabledHandler ()
		{
			if (cb_isScaleControlsEnabled == null)
				cb_isScaleControlsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScaleControlsEnabled);
			return cb_isScaleControlsEnabled;
		}

		static bool n_IsScaleControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleControlsEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setScaleControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleControlsEnabled_ZHandler ()
		{
			if (cb_setScaleControlsEnabled_Z == null)
				cb_setScaleControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleControlsEnabled_Z);
			return cb_setScaleControlsEnabled_Z;
		}

		static void n_SetScaleControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleControlsEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isScaleControlsEnabled;
		IntPtr id_setScaleControlsEnabled_Z;
		public unsafe bool ScaleControlsEnabled {
			get {
				if (id_isScaleControlsEnabled == IntPtr.Zero)
					id_isScaleControlsEnabled = JNIEnv.GetMethodID (class_ref, "isScaleControlsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isScaleControlsEnabled);
			}
			set {
				if (id_setScaleControlsEnabled_Z == IntPtr.Zero)
					id_setScaleControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScaleControlsEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleControlsEnabled_Z, __args);
			}
		}

		static Delegate cb_isScrollGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetIsScrollGesturesEnabledHandler ()
		{
			if (cb_isScrollGesturesEnabled == null)
				cb_isScrollGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScrollGesturesEnabled);
			return cb_isScrollGesturesEnabled;
		}

		static bool n_IsScrollGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollGesturesEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setScrollGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScrollGesturesEnabled_ZHandler ()
		{
			if (cb_setScrollGesturesEnabled_Z == null)
				cb_setScrollGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScrollGesturesEnabled_Z);
			return cb_setScrollGesturesEnabled_Z;
		}

		static void n_SetScrollGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollGesturesEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isScrollGesturesEnabled;
		IntPtr id_setScrollGesturesEnabled_Z;
		public unsafe bool ScrollGesturesEnabled {
			get {
				if (id_isScrollGesturesEnabled == IntPtr.Zero)
					id_isScrollGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isScrollGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isScrollGesturesEnabled);
			}
			set {
				if (id_setScrollGesturesEnabled_Z == IntPtr.Zero)
					id_setScrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScrollGesturesEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScrollGesturesEnabled_Z, __args);
			}
		}

		static Delegate cb_isZoomControlsEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomControlsEnabledHandler ()
		{
			if (cb_isZoomControlsEnabled == null)
				cb_isZoomControlsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomControlsEnabled);
			return cb_isZoomControlsEnabled;
		}

		static bool n_IsZoomControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomControlsEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomControlsEnabled_ZHandler ()
		{
			if (cb_setZoomControlsEnabled_Z == null)
				cb_setZoomControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomControlsEnabled_Z);
			return cb_setZoomControlsEnabled_Z;
		}

		static void n_SetZoomControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomControlsEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isZoomControlsEnabled;
		IntPtr id_setZoomControlsEnabled_Z;
		public unsafe bool ZoomControlsEnabled {
			get {
				if (id_isZoomControlsEnabled == IntPtr.Zero)
					id_isZoomControlsEnabled = JNIEnv.GetMethodID (class_ref, "isZoomControlsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isZoomControlsEnabled);
			}
			set {
				if (id_setZoomControlsEnabled_Z == IntPtr.Zero)
					id_setZoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomControlsEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomControlsEnabled_Z, __args);
			}
		}

		static Delegate cb_isZoomGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomGesturesEnabledHandler ()
		{
			if (cb_isZoomGesturesEnabled == null)
				cb_isZoomGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomGesturesEnabled);
			return cb_isZoomGesturesEnabled;
		}

		static bool n_IsZoomGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomGesturesEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomGesturesEnabled_ZHandler ()
		{
			if (cb_setZoomGesturesEnabled_Z == null)
				cb_setZoomGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomGesturesEnabled_Z);
			return cb_setZoomGesturesEnabled_Z;
		}

		static void n_SetZoomGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomGesturesEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isZoomGesturesEnabled;
		IntPtr id_setZoomGesturesEnabled_Z;
		public unsafe bool ZoomGesturesEnabled {
			get {
				if (id_isZoomGesturesEnabled == IntPtr.Zero)
					id_isZoomGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isZoomGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isZoomGesturesEnabled);
			}
			set {
				if (id_setZoomGesturesEnabled_Z == IntPtr.Zero)
					id_setZoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomGesturesEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomGesturesEnabled_Z, __args);
			}
		}

		static Delegate cb_isZoomInByScreenCenter;
#pragma warning disable 0169
		static Delegate GetIsZoomInByScreenCenterHandler ()
		{
			if (cb_isZoomInByScreenCenter == null)
				cb_isZoomInByScreenCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomInByScreenCenter);
			return cb_isZoomInByScreenCenter;
		}

		static bool n_IsZoomInByScreenCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomInByScreenCenter;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomInByScreenCenter_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomInByScreenCenter_ZHandler ()
		{
			if (cb_setZoomInByScreenCenter_Z == null)
				cb_setZoomInByScreenCenter_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomInByScreenCenter_Z);
			return cb_setZoomInByScreenCenter_Z;
		}

		static void n_SetZoomInByScreenCenter_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomInByScreenCenter = p0;
		}
#pragma warning restore 0169

		IntPtr id_isZoomInByScreenCenter;
		IntPtr id_setZoomInByScreenCenter_Z;
		public unsafe bool ZoomInByScreenCenter {
			get {
				if (id_isZoomInByScreenCenter == IntPtr.Zero)
					id_isZoomInByScreenCenter = JNIEnv.GetMethodID (class_ref, "isZoomInByScreenCenter", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isZoomInByScreenCenter);
			}
			set {
				if (id_setZoomInByScreenCenter_Z == IntPtr.Zero)
					id_setZoomInByScreenCenter_Z = JNIEnv.GetMethodID (class_ref, "setZoomInByScreenCenter", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomInByScreenCenter_Z, __args);
			}
		}

		static Delegate cb_getZoomPosition;
#pragma warning disable 0169
		static Delegate GetGetZoomPositionHandler ()
		{
			if (cb_getZoomPosition == null)
				cb_getZoomPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomPosition);
			return cb_getZoomPosition;
		}

		static int n_GetZoomPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomPosition_I;
#pragma warning disable 0169
		static Delegate GetSetZoomPosition_IHandler ()
		{
			if (cb_setZoomPosition_I == null)
				cb_setZoomPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoomPosition_I);
			return cb_setZoomPosition_I;
		}

		static void n_SetZoomPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomPosition = p0;
		}
#pragma warning restore 0169

		IntPtr id_getZoomPosition;
		IntPtr id_setZoomPosition_I;
		public unsafe int ZoomPosition {
			get {
				if (id_getZoomPosition == IntPtr.Zero)
					id_getZoomPosition = JNIEnv.GetMethodID (class_ref, "getZoomPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getZoomPosition);
			}
			set {
				if (id_setZoomPosition_I == IntPtr.Zero)
					id_setZoomPosition_I = JNIEnv.GetMethodID (class_ref, "setZoomPosition", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomPosition_I, __args);
			}
		}

		static Delegate cb_setAllGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAllGesturesEnabled_ZHandler ()
		{
			if (cb_setAllGesturesEnabled_Z == null)
				cb_setAllGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllGesturesEnabled_Z);
			return cb_setAllGesturesEnabled_Z;
		}

		static void n_SetAllGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IUiSettings __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IUiSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllGesturesEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAllGesturesEnabled_Z;
		public unsafe void SetAllGesturesEnabled (bool p0)
		{
			if (id_setAllGesturesEnabled_Z == IntPtr.Zero)
				id_setAllGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAllGesturesEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllGesturesEnabled_Z, __args);
		}

	}

}
