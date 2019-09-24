using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/MyLocationStyle", DoNotGenerateAcw=true)]
	public partial class MyLocationStyle : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Com.Amap.Api.Maps2d.Model.MyLocationStyleCreator Creator {
			get {
				const string __id = "CREATOR.Lcom/amap/api/maps2d/model/MyLocationStyleCreator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyleCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='ERROR_CODE']"
		[Register ("ERROR_CODE")]
		public const string ErrorCode = (string) "errorCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='ERROR_INFO']"
		[Register ("ERROR_INFO")]
		public const string ErrorInfo = (string) "errorInfo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='LOCATION_TYPE']"
		[Register ("LOCATION_TYPE")]
		public const string LocationType = (string) "locationType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='LOCATION_TYPE_FOLLOW']"
		[Register ("LOCATION_TYPE_FOLLOW")]
		public const int LocationTypeFollow = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='LOCATION_TYPE_FOLLOW_NO_CENTER']"
		[Register ("LOCATION_TYPE_FOLLOW_NO_CENTER")]
		public const int LocationTypeFollowNoCenter = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='LOCATION_TYPE_LOCATE']"
		[Register ("LOCATION_TYPE_LOCATE")]
		public const int LocationTypeLocate = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/field[@name='LOCATION_TYPE_SHOW']"
		[Register ("LOCATION_TYPE_SHOW")]
		public const int LocationTypeShow = (int) 0;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/MyLocationStyle", typeof (MyLocationStyle));
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

		protected MyLocationStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/constructor[@name='MyLocationStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MyLocationStyle ()
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

		static Delegate cb_getAnchorU;
#pragma warning disable 0169
		static Delegate GetGetAnchorUHandler ()
		{
			if (cb_getAnchorU == null)
				cb_getAnchorU = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAnchorU);
			return cb_getAnchorU;
		}

		static float n_GetAnchorU (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnchorU;
		}
#pragma warning restore 0169

		public virtual unsafe float AnchorU {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getAnchorU' and count(parameter)=0]"
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				const string __id = "getAnchorU.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAnchorV;
#pragma warning disable 0169
		static Delegate GetGetAnchorVHandler ()
		{
			if (cb_getAnchorV == null)
				cb_getAnchorV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAnchorV);
			return cb_getAnchorV;
		}

		static float n_GetAnchorV (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnchorV;
		}
#pragma warning restore 0169

		public virtual unsafe float AnchorV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getAnchorV' and count(parameter)=0]"
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				const string __id = "getAnchorV.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInterval;
#pragma warning disable 0169
		static Delegate GetGetIntervalHandler ()
		{
			if (cb_getInterval == null)
				cb_getInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInterval);
			return cb_getInterval;
		}

		static long n_GetInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		public virtual unsafe long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()J", "GetGetIntervalHandler")]
			get {
				const string __id = "getInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isMyLocationShowing;
#pragma warning disable 0169
		static Delegate GetIsMyLocationShowingHandler ()
		{
			if (cb_isMyLocationShowing == null)
				cb_isMyLocationShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMyLocationShowing);
			return cb_isMyLocationShowing;
		}

		static bool n_IsMyLocationShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMyLocationShowing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMyLocationShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='isMyLocationShowing' and count(parameter)=0]"
			[Register ("isMyLocationShowing", "()Z", "GetIsMyLocationShowingHandler")]
			get {
				const string __id = "isMyLocationShowing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMyLocationIcon;
#pragma warning disable 0169
		static Delegate GetGetMyLocationIconHandler ()
		{
			if (cb_getMyLocationIcon == null)
				cb_getMyLocationIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMyLocationIcon);
			return cb_getMyLocationIcon;
		}

		static IntPtr n_GetMyLocationIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyLocationIcon);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor MyLocationIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getMyLocationIcon' and count(parameter)=0]"
			[Register ("getMyLocationIcon", "()Lcom/amap/api/maps2d/model/BitmapDescriptor;", "GetGetMyLocationIconHandler")]
			get {
				const string __id = "getMyLocationIcon.()Lcom/amap/api/maps2d/model/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMyLocationType;
#pragma warning disable 0169
		static Delegate GetGetMyLocationTypeHandler ()
		{
			if (cb_getMyLocationType == null)
				cb_getMyLocationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMyLocationType);
			return cb_getMyLocationType;
		}

		static int n_GetMyLocationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MyLocationType;
		}
#pragma warning restore 0169

		public virtual unsafe int MyLocationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getMyLocationType' and count(parameter)=0]"
			[Register ("getMyLocationType", "()I", "GetGetMyLocationTypeHandler")]
			get {
				const string __id = "getMyLocationType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRadiusFillColor;
#pragma warning disable 0169
		static Delegate GetGetRadiusFillColorHandler ()
		{
			if (cb_getRadiusFillColor == null)
				cb_getRadiusFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadiusFillColor);
			return cb_getRadiusFillColor;
		}

		static int n_GetRadiusFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RadiusFillColor;
		}
#pragma warning restore 0169

		public virtual unsafe int RadiusFillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getRadiusFillColor' and count(parameter)=0]"
			[Register ("getRadiusFillColor", "()I", "GetGetRadiusFillColorHandler")]
			get {
				const string __id = "getRadiusFillColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeColor;
		}
#pragma warning restore 0169

		public virtual unsafe int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				const string __id = "getStrokeColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				const string __id = "getStrokeWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_anchor_FF;
#pragma warning disable 0169
		static Delegate GetAnchor_FFHandler ()
		{
			if (cb_anchor_FF == null)
				cb_anchor_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_Anchor_FF);
			return cb_anchor_FF;
		}

		static IntPtr n_Anchor_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Anchor (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetAnchor_FFHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle Anchor (float p0, float p1)
		{
			const string __id = "anchor.(FF)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_interval_J;
#pragma warning disable 0169
		static Delegate GetInvokeInterval_JHandler ()
		{
			if (cb_interval_J == null)
				cb_interval_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_InvokeInterval_J);
			return cb_interval_J;
		}

		static IntPtr n_InvokeInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeInterval (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='interval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("interval", "(J)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetInvokeInterval_JHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle InvokeInterval (long p0)
		{
			const string __id = "interval.(J)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_myLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
#pragma warning disable 0169
		static Delegate GetInvokeMyLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_Handler ()
		{
			if (cb_myLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ == null)
				cb_myLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeMyLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_);
			return cb_myLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_;
		}

		static IntPtr n_InvokeMyLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeMyLocationIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='myLocationIcon' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.BitmapDescriptor']]"
		[Register ("myLocationIcon", "(Lcom/amap/api/maps2d/model/BitmapDescriptor;)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetInvokeMyLocationIcon_Lcom_amap_api_maps2d_model_BitmapDescriptor_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle InvokeMyLocationIcon (global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor p0)
		{
			const string __id = "myLocationIcon.(Lcom/amap/api/maps2d/model/BitmapDescriptor;)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_myLocationType_I;
#pragma warning disable 0169
		static Delegate GetInvokeMyLocationType_IHandler ()
		{
			if (cb_myLocationType_I == null)
				cb_myLocationType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeMyLocationType_I);
			return cb_myLocationType_I;
		}

		static IntPtr n_InvokeMyLocationType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeMyLocationType (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='myLocationType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("myLocationType", "(I)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetInvokeMyLocationType_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle InvokeMyLocationType (int p0)
		{
			const string __id = "myLocationType.(I)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_radiusFillColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeRadiusFillColor_IHandler ()
		{
			if (cb_radiusFillColor_I == null)
				cb_radiusFillColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeRadiusFillColor_I);
			return cb_radiusFillColor_I;
		}

		static IntPtr n_InvokeRadiusFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeRadiusFillColor (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='radiusFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radiusFillColor", "(I)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetInvokeRadiusFillColor_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle InvokeRadiusFillColor (int p0)
		{
			const string __id = "radiusFillColor.(I)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showMyLocation_Z;
#pragma warning disable 0169
		static Delegate GetShowMyLocation_ZHandler ()
		{
			if (cb_showMyLocation_Z == null)
				cb_showMyLocation_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowMyLocation_Z);
			return cb_showMyLocation_Z;
		}

		static IntPtr n_ShowMyLocation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowMyLocation (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='showMyLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMyLocation", "(Z)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetShowMyLocation_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle ShowMyLocation (bool p0)
		{
			const string __id = "showMyLocation.(Z)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_strokeColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeStrokeColor_IHandler ()
		{
			if (cb_strokeColor_I == null)
				cb_strokeColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeStrokeColor_I);
			return cb_strokeColor_I;
		}

		static IntPtr n_InvokeStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeStrokeColor (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='strokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("strokeColor", "(I)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetInvokeStrokeColor_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle InvokeStrokeColor (int p0)
		{
			const string __id = "strokeColor.(I)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_strokeWidth_F;
#pragma warning disable 0169
		static Delegate GetInvokeStrokeWidth_FHandler ()
		{
			if (cb_strokeWidth_F == null)
				cb_strokeWidth_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_InvokeStrokeWidth_F);
			return cb_strokeWidth_F;
		}

		static IntPtr n_InvokeStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeStrokeWidth (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='strokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("strokeWidth", "(F)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetInvokeStrokeWidth_FHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.MyLocationStyle InvokeStrokeWidth (float p0)
		{
			const string __id = "strokeWidth.(F)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyle']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

	}
}
