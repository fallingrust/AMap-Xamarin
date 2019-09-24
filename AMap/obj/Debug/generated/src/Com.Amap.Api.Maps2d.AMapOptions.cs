using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/AMapOptions", DoNotGenerateAcw=true)]
	public partial class AMapOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Com.Amap.Api.Maps2d.AMapOptionsCreator Creator {
			get {
				const string __id = "CREATOR.Lcom/amap/api/maps2d/AMapOptionsCreator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptionsCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/field[@name='LOGO_POSITION_BOTTOM_CENTER']"
		[Register ("LOGO_POSITION_BOTTOM_CENTER")]
		public const int LogoPositionBottomCenter = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/field[@name='LOGO_POSITION_BOTTOM_LEFT']"
		[Register ("LOGO_POSITION_BOTTOM_LEFT")]
		public const int LogoPositionBottomLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/field[@name='LOGO_POSITION_BOTTOM_RIGHT']"
		[Register ("LOGO_POSITION_BOTTOM_RIGHT")]
		public const int LogoPositionBottomRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/field[@name='ZOOM_POSITION_RIGHT_BUTTOM']"
		[Register ("ZOOM_POSITION_RIGHT_BUTTOM")]
		public const int ZoomPositionRightButtom = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/field[@name='ZOOM_POSITION_RIGHT_CENTER']"
		[Register ("ZOOM_POSITION_RIGHT_CENTER")]
		public const int ZoomPositionRightCenter = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/AMapOptions", typeof (AMapOptions));
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

		protected AMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/constructor[@name='AMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AMapOptions ()
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

		static Delegate cb_getCamera;
#pragma warning disable 0169
		static Delegate GetGetCameraHandler ()
		{
			if (cb_getCamera == null)
				cb_getCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCamera);
			return cb_getCamera;
		}

		static IntPtr n_GetCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Camera);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition Camera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getCamera' and count(parameter)=0]"
			[Register ("getCamera", "()Lcom/amap/api/maps2d/model/CameraPosition;", "GetGetCameraHandler")]
			get {
				const string __id = "getCamera.()Lcom/amap/api/maps2d/model/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCompassEnabled;
#pragma warning disable 0169
		static Delegate GetGetCompassEnabledHandler ()
		{
			if (cb_getCompassEnabled == null)
				cb_getCompassEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompassEnabled);
			return cb_getCompassEnabled;
		}

		static IntPtr n_GetCompassEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompassEnabled);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getCompassEnabled' and count(parameter)=0]"
			[Register ("getCompassEnabled", "()Ljava/lang/Boolean;", "GetGetCompassEnabledHandler")]
			get {
				const string __id = "getCompassEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogoPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()I", "GetGetLogoPositionHandler")]
			get {
				const string __id = "getLogoPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMapType;
#pragma warning disable 0169
		static Delegate GetGetMapTypeHandler ()
		{
			if (cb_getMapType == null)
				cb_getMapType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapType);
			return cb_getMapType;
		}

		static int n_GetMapType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapType;
		}
#pragma warning restore 0169

		public virtual unsafe int MapType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getMapType' and count(parameter)=0]"
			[Register ("getMapType", "()I", "GetGetMapTypeHandler")]
			get {
				const string __id = "getMapType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScaleControlsEnabled;
#pragma warning disable 0169
		static Delegate GetGetScaleControlsEnabledHandler ()
		{
			if (cb_getScaleControlsEnabled == null)
				cb_getScaleControlsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleControlsEnabled);
			return cb_getScaleControlsEnabled;
		}

		static IntPtr n_GetScaleControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleControlsEnabled);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ScaleControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getScaleControlsEnabled' and count(parameter)=0]"
			[Register ("getScaleControlsEnabled", "()Ljava/lang/Boolean;", "GetGetScaleControlsEnabledHandler")]
			get {
				const string __id = "getScaleControlsEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScrollGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetScrollGesturesEnabledHandler ()
		{
			if (cb_getScrollGesturesEnabled == null)
				cb_getScrollGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScrollGesturesEnabled);
			return cb_getScrollGesturesEnabled;
		}

		static IntPtr n_GetScrollGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScrollGesturesEnabled);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("getScrollGesturesEnabled", "()Ljava/lang/Boolean;", "GetGetScrollGesturesEnabledHandler")]
			get {
				const string __id = "getScrollGesturesEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZOrderOnTop;
#pragma warning disable 0169
		static Delegate GetGetZOrderOnTopHandler ()
		{
			if (cb_getZOrderOnTop == null)
				cb_getZOrderOnTop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZOrderOnTop);
			return cb_getZOrderOnTop;
		}

		static IntPtr n_GetZOrderOnTop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZOrderOnTop);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ZOrderOnTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getZOrderOnTop' and count(parameter)=0]"
			[Register ("getZOrderOnTop", "()Ljava/lang/Boolean;", "GetGetZOrderOnTopHandler")]
			get {
				const string __id = "getZOrderOnTop.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZoomControlsEnabled;
#pragma warning disable 0169
		static Delegate GetGetZoomControlsEnabledHandler ()
		{
			if (cb_getZoomControlsEnabled == null)
				cb_getZoomControlsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoomControlsEnabled);
			return cb_getZoomControlsEnabled;
		}

		static IntPtr n_GetZoomControlsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoomControlsEnabled);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getZoomControlsEnabled' and count(parameter)=0]"
			[Register ("getZoomControlsEnabled", "()Ljava/lang/Boolean;", "GetGetZoomControlsEnabledHandler")]
			get {
				const string __id = "getZoomControlsEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZoomGesturesEnabled;
#pragma warning disable 0169
		static Delegate GetGetZoomGesturesEnabledHandler ()
		{
			if (cb_getZoomGesturesEnabled == null)
				cb_getZoomGesturesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoomGesturesEnabled);
			return cb_getZoomGesturesEnabled;
		}

		static IntPtr n_GetZoomGesturesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoomGesturesEnabled);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Boolean ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='getZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("getZoomGesturesEnabled", "()Ljava/lang/Boolean;", "GetGetZoomGesturesEnabledHandler")]
			get {
				const string __id = "getZoomGesturesEnabled.()Ljava/lang/Boolean;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_camera_Lcom_amap_api_maps2d_model_CameraPosition_;
#pragma warning disable 0169
		static Delegate GetInvokeCamera_Lcom_amap_api_maps2d_model_CameraPosition_Handler ()
		{
			if (cb_camera_Lcom_amap_api_maps2d_model_CameraPosition_ == null)
				cb_camera_Lcom_amap_api_maps2d_model_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeCamera_Lcom_amap_api_maps2d_model_CameraPosition_);
			return cb_camera_Lcom_amap_api_maps2d_model_CameraPosition_;
		}

		static IntPtr n_InvokeCamera_Lcom_amap_api_maps2d_model_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeCamera (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='camera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CameraPosition']]"
		[Register ("camera", "(Lcom/amap/api/maps2d/model/CameraPosition;)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeCamera_Lcom_amap_api_maps2d_model_CameraPosition_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeCamera (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
		{
			const string __id = "camera.(Lcom/amap/api/maps2d/model/CameraPosition;)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compassEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeCompassEnabled_ZHandler ()
		{
			if (cb_compassEnabled_Z == null)
				cb_compassEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeCompassEnabled_Z);
			return cb_compassEnabled_Z;
		}

		static IntPtr n_InvokeCompassEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeCompassEnabled (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='compassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassEnabled", "(Z)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeCompassEnabled_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeCompassEnabled (bool p0)
		{
			const string __id = "compassEnabled.(Z)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_logoPosition_I;
#pragma warning disable 0169
		static Delegate GetInvokeLogoPosition_IHandler ()
		{
			if (cb_logoPosition_I == null)
				cb_logoPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeLogoPosition_I);
			return cb_logoPosition_I;
		}

		static IntPtr n_InvokeLogoPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeLogoPosition (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='logoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("logoPosition", "(I)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeLogoPosition_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeLogoPosition (int p0)
		{
			const string __id = "logoPosition.(I)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapType_I;
#pragma warning disable 0169
		static Delegate GetInvokeMapType_IHandler ()
		{
			if (cb_mapType_I == null)
				cb_mapType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeMapType_I);
			return cb_mapType_I;
		}

		static IntPtr n_InvokeMapType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeMapType (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='mapType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mapType", "(I)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeMapType_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeMapType (int p0)
		{
			const string __id = "mapType.(I)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scaleControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeScaleControlsEnabled_ZHandler ()
		{
			if (cb_scaleControlsEnabled_Z == null)
				cb_scaleControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeScaleControlsEnabled_Z);
			return cb_scaleControlsEnabled_Z;
		}

		static IntPtr n_InvokeScaleControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeScaleControlsEnabled (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='scaleControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scaleControlsEnabled", "(Z)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeScaleControlsEnabled_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeScaleControlsEnabled (bool p0)
		{
			const string __id = "scaleControlsEnabled.(Z)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scrollGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeScrollGesturesEnabled_ZHandler ()
		{
			if (cb_scrollGesturesEnabled_Z == null)
				cb_scrollGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeScrollGesturesEnabled_Z);
			return cb_scrollGesturesEnabled_Z;
		}

		static IntPtr n_InvokeScrollGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeScrollGesturesEnabled (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='scrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollGesturesEnabled", "(Z)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeScrollGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeScrollGesturesEnabled (bool p0)
		{
			const string __id = "scrollGesturesEnabled.(Z)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zOrderOnTop_Z;
#pragma warning disable 0169
		static Delegate GetInvokeZOrderOnTop_ZHandler ()
		{
			if (cb_zOrderOnTop_Z == null)
				cb_zOrderOnTop_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeZOrderOnTop_Z);
			return cb_zOrderOnTop_Z;
		}

		static IntPtr n_InvokeZOrderOnTop_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeZOrderOnTop (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='zOrderOnTop' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zOrderOnTop", "(Z)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeZOrderOnTop_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeZOrderOnTop (bool p0)
		{
			const string __id = "zOrderOnTop.(Z)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_zoomControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeZoomControlsEnabled_ZHandler ()
		{
			if (cb_zoomControlsEnabled_Z == null)
				cb_zoomControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeZoomControlsEnabled_Z);
			return cb_zoomControlsEnabled_Z;
		}

		static IntPtr n_InvokeZoomControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeZoomControlsEnabled (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='zoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomControlsEnabled", "(Z)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeZoomControlsEnabled_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeZoomControlsEnabled (bool p0)
		{
			const string __id = "zoomControlsEnabled.(Z)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_zoomGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetInvokeZoomGesturesEnabled_ZHandler ()
		{
			if (cb_zoomGesturesEnabled_Z == null)
				cb_zoomGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_InvokeZoomGesturesEnabled_Z);
			return cb_zoomGesturesEnabled_Z;
		}

		static IntPtr n_InvokeZoomGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.AMapOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeZoomGesturesEnabled (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapOptions']/method[@name='zoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomGesturesEnabled", "(Z)Lcom/amap/api/maps2d/AMapOptions;", "GetInvokeZoomGesturesEnabled_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.AMapOptions InvokeZoomGesturesEnabled (bool p0)
		{
			const string __id = "zoomGesturesEnabled.(Z)Lcom/amap/api/maps2d/AMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
