using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Fence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']"
	[global::Android.Runtime.Register ("com/amap/api/fence/GeoFence", DoNotGenerateAcw=true)]
	public partial class GeoFence : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ADDGEOFENCE_SUCCESS']"
		[Register ("ADDGEOFENCE_SUCCESS")]
		public const int AddgeofenceSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='BUNDLE_KEY_CUSTOMID']"
		[Register ("BUNDLE_KEY_CUSTOMID")]
		public const string BundleKeyCustomid = (string) "customId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='BUNDLE_KEY_FENCE']"
		[Register ("BUNDLE_KEY_FENCE")]
		public const string BundleKeyFence = (string) "fence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='BUNDLE_KEY_FENCEID']"
		[Register ("BUNDLE_KEY_FENCEID")]
		public const string BundleKeyFenceid = (string) "fenceid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='BUNDLE_KEY_FENCESTATUS']"
		[Register ("BUNDLE_KEY_FENCESTATUS")]
		public const string BundleKeyFencestatus = (string) "event";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='BUNDLE_KEY_LOCERRORCODE']"
		[Register ("BUNDLE_KEY_LOCERRORCODE")]
		public const string BundleKeyLocerrorcode = (string) "location_errorcode";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_CODE_EXISTS']"
		[Register ("ERROR_CODE_EXISTS")]
		public const int ErrorCodeExists = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_CODE_FAILURE_AUTH']"
		[Register ("ERROR_CODE_FAILURE_AUTH")]
		public const int ErrorCodeFailureAuth = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_CODE_FAILURE_CONNECTION']"
		[Register ("ERROR_CODE_FAILURE_CONNECTION")]
		public const int ErrorCodeFailureConnection = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_CODE_FAILURE_PARSER']"
		[Register ("ERROR_CODE_FAILURE_PARSER")]
		public const int ErrorCodeFailureParser = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_CODE_INVALID_PARAMETER']"
		[Register ("ERROR_CODE_INVALID_PARAMETER")]
		public const int ErrorCodeInvalidParameter = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_CODE_UNKNOWN']"
		[Register ("ERROR_CODE_UNKNOWN")]
		public const int ErrorCodeUnknown = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='ERROR_NO_VALIDFENCE']"
		[Register ("ERROR_NO_VALIDFENCE")]
		public const int ErrorNoValidfence = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='STATUS_IN']"
		[Register ("STATUS_IN")]
		public const int StatusIn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='STATUS_LOCFAIL']"
		[Register ("STATUS_LOCFAIL")]
		public const int StatusLocfail = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='STATUS_OUT']"
		[Register ("STATUS_OUT")]
		public const int StatusOut = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='STATUS_STAYED']"
		[Register ("STATUS_STAYED")]
		public const int StatusStayed = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='STATUS_UNKNOWN']"
		[Register ("STATUS_UNKNOWN")]
		public const int StatusUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='TYPE_AMAPPOI']"
		[Register ("TYPE_AMAPPOI")]
		public const int TypeAmappoi = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='TYPE_DISTRICT']"
		[Register ("TYPE_DISTRICT")]
		public const int TypeDistrict = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='TYPE_POLYGON']"
		[Register ("TYPE_POLYGON")]
		public const int TypePolygon = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/field[@name='TYPE_ROUND']"
		[Register ("TYPE_ROUND")]
		public const int TypeRound = (int) 0;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/fence/GeoFence", typeof (GeoFence));
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

		protected GeoFence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/constructor[@name='GeoFence' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeoFence ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/constructor[@name='GeoFence' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe GeoFence (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

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

		static Delegate cb_isAble;
#pragma warning disable 0169
		static Delegate GetIsAbleHandler ()
		{
			if (cb_isAble == null)
				cb_isAble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAble);
			return cb_isAble;
		}

		static bool n_IsAble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Able;
		}
#pragma warning restore 0169

		static Delegate cb_setAble_Z;
#pragma warning disable 0169
		static Delegate GetSetAble_ZHandler ()
		{
			if (cb_setAble_Z == null)
				cb_setAble_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAble_Z);
			return cb_setAble_Z;
		}

		static void n_SetAble_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Able = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool Able {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='isAble' and count(parameter)=0]"
			[Register ("isAble", "()Z", "GetIsAbleHandler")]
			get {
				const string __id = "isAble.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setAble' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAble", "(Z)V", "GetSetAble_ZHandler")]
			set {
				const string __id = "setAble.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getActivatesAction;
#pragma warning disable 0169
		static Delegate GetGetActivatesActionHandler ()
		{
			if (cb_getActivatesAction == null)
				cb_getActivatesAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActivatesAction);
			return cb_getActivatesAction;
		}

		static int n_GetActivatesAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActivatesAction;
		}
#pragma warning restore 0169

		static Delegate cb_setActivatesAction_I;
#pragma warning disable 0169
		static Delegate GetSetActivatesAction_IHandler ()
		{
			if (cb_setActivatesAction_I == null)
				cb_setActivatesAction_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActivatesAction_I);
			return cb_setActivatesAction_I;
		}

		static void n_SetActivatesAction_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActivatesAction = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ActivatesAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getActivatesAction' and count(parameter)=0]"
			[Register ("getActivatesAction", "()I", "GetGetActivatesActionHandler")]
			get {
				const string __id = "getActivatesAction.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setActivatesAction' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setActivatesAction", "(I)V", "GetSetActivatesAction_IHandler")]
			set {
				const string __id = "setActivatesAction.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
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
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		static Delegate cb_setCenter_Lcom_amap_api_location_DPoint_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lcom_amap_api_location_DPoint_Handler ()
		{
			if (cb_setCenter_Lcom_amap_api_location_DPoint_ == null)
				cb_setCenter_Lcom_amap_api_location_DPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lcom_amap_api_location_DPoint_);
			return cb_setCenter_Lcom_amap_api_location_DPoint_;
		}

		static void n_SetCenter_Lcom_amap_api_location_DPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.DPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Center = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Location.DPoint Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/amap/api/location/DPoint;", "GetGetCenterHandler")]
			get {
				const string __id = "getCenter.()Lcom/amap/api/location/DPoint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.DPoint']]"
			[Register ("setCenter", "(Lcom/amap/api/location/DPoint;)V", "GetSetCenter_Lcom_amap_api_location_DPoint_Handler")]
			set {
				const string __id = "setCenter.(Lcom/amap/api/location/DPoint;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentLocation;
#pragma warning disable 0169
		static Delegate GetGetCurrentLocationHandler ()
		{
			if (cb_getCurrentLocation == null)
				cb_getCurrentLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentLocation);
			return cb_getCurrentLocation;
		}

		static IntPtr n_GetCurrentLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentLocation);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentLocation_Lcom_amap_api_location_AMapLocation_;
#pragma warning disable 0169
		static Delegate GetSetCurrentLocation_Lcom_amap_api_location_AMapLocation_Handler ()
		{
			if (cb_setCurrentLocation_Lcom_amap_api_location_AMapLocation_ == null)
				cb_setCurrentLocation_Lcom_amap_api_location_AMapLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentLocation_Lcom_amap_api_location_AMapLocation_);
			return cb_setCurrentLocation_Lcom_amap_api_location_AMapLocation_;
		}

		static void n_SetCurrentLocation_Lcom_amap_api_location_AMapLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurrentLocation = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Location.AMapLocation CurrentLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getCurrentLocation' and count(parameter)=0]"
			[Register ("getCurrentLocation", "()Lcom/amap/api/location/AMapLocation;", "GetGetCurrentLocationHandler")]
			get {
				const string __id = "getCurrentLocation.()Lcom/amap/api/location/AMapLocation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setCurrentLocation' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocation']]"
			[Register ("setCurrentLocation", "(Lcom/amap/api/location/AMapLocation;)V", "GetSetCurrentLocation_Lcom_amap_api_location_AMapLocation_Handler")]
			set {
				const string __id = "setCurrentLocation.(Lcom/amap/api/location/AMapLocation;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomId;
#pragma warning disable 0169
		static Delegate GetGetCustomIdHandler ()
		{
			if (cb_getCustomId == null)
				cb_getCustomId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomId);
			return cb_getCustomId;
		}

		static IntPtr n_GetCustomId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomId);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomId_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomId_Ljava_lang_String_ == null)
				cb_setCustomId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomId_Ljava_lang_String_);
			return cb_setCustomId_Ljava_lang_String_;
		}

		static void n_SetCustomId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CustomId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getCustomId' and count(parameter)=0]"
			[Register ("getCustomId", "()Ljava/lang/String;", "GetGetCustomIdHandler")]
			get {
				const string __id = "getCustomId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setCustomId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomId", "(Ljava/lang/String;)V", "GetSetCustomId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCustomId.(Ljava/lang/String;)V";
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

		static Delegate cb_getDistrictItemList;
#pragma warning disable 0169
		static Delegate GetGetDistrictItemListHandler ()
		{
			if (cb_getDistrictItemList == null)
				cb_getDistrictItemList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistrictItemList);
			return cb_getDistrictItemList;
		}

		static IntPtr n_GetDistrictItemList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.DistrictItem>.ToLocalJniHandle (__this.DistrictItemList);
		}
#pragma warning restore 0169

		static Delegate cb_setDistrictItemList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDistrictItemList_Ljava_util_List_Handler ()
		{
			if (cb_setDistrictItemList_Ljava_util_List_ == null)
				cb_setDistrictItemList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDistrictItemList_Ljava_util_List_);
			return cb_setDistrictItemList_Ljava_util_List_;
		}

		static void n_SetDistrictItemList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.DistrictItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DistrictItemList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.DistrictItem> DistrictItemList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getDistrictItemList' and count(parameter)=0]"
			[Register ("getDistrictItemList", "()Ljava/util/List;", "GetGetDistrictItemListHandler")]
			get {
				const string __id = "getDistrictItemList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.DistrictItem>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setDistrictItemList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amap.api.fence.DistrictItem&gt;']]"
			[Register ("setDistrictItemList", "(Ljava/util/List;)V", "GetSetDistrictItemList_Ljava_util_List_Handler")]
			set {
				const string __id = "setDistrictItemList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.DistrictItem>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEnterTime;
#pragma warning disable 0169
		static Delegate GetGetEnterTimeHandler ()
		{
			if (cb_getEnterTime == null)
				cb_getEnterTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEnterTime);
			return cb_getEnterTime;
		}

		static long n_GetEnterTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnterTime;
		}
#pragma warning restore 0169

		static Delegate cb_setEnterTime_J;
#pragma warning disable 0169
		static Delegate GetSetEnterTime_JHandler ()
		{
			if (cb_setEnterTime_J == null)
				cb_setEnterTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetEnterTime_J);
			return cb_setEnterTime_J;
		}

		static void n_SetEnterTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnterTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long EnterTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getEnterTime' and count(parameter)=0]"
			[Register ("getEnterTime", "()J", "GetGetEnterTimeHandler")]
			get {
				const string __id = "getEnterTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setEnterTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setEnterTime", "(J)V", "GetSetEnterTime_JHandler")]
			set {
				const string __id = "setEnterTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpiration;
#pragma warning disable 0169
		static Delegate GetGetExpirationHandler ()
		{
			if (cb_getExpiration == null)
				cb_getExpiration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiration);
			return cb_getExpiration;
		}

		static long n_GetExpiration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Expiration;
		}
#pragma warning restore 0169

		static Delegate cb_setExpiration_J;
#pragma warning disable 0169
		static Delegate GetSetExpiration_JHandler ()
		{
			if (cb_setExpiration_J == null)
				cb_setExpiration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpiration_J);
			return cb_setExpiration_J;
		}

		static void n_SetExpiration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expiration = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long Expiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getExpiration' and count(parameter)=0]"
			[Register ("getExpiration", "()J", "GetGetExpirationHandler")]
			get {
				const string __id = "getExpiration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setExpiration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExpiration", "(J)V", "GetSetExpiration_JHandler")]
			set {
				const string __id = "setExpiration.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFenceId;
#pragma warning disable 0169
		static Delegate GetGetFenceIdHandler ()
		{
			if (cb_getFenceId == null)
				cb_getFenceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFenceId);
			return cb_getFenceId;
		}

		static IntPtr n_GetFenceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FenceId);
		}
#pragma warning restore 0169

		static Delegate cb_setFenceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFenceId_Ljava_lang_String_Handler ()
		{
			if (cb_setFenceId_Ljava_lang_String_ == null)
				cb_setFenceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFenceId_Ljava_lang_String_);
			return cb_setFenceId_Ljava_lang_String_;
		}

		static void n_SetFenceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FenceId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string FenceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getFenceId' and count(parameter)=0]"
			[Register ("getFenceId", "()Ljava/lang/String;", "GetGetFenceIdHandler")]
			get {
				const string __id = "getFenceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setFenceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFenceId", "(Ljava/lang/String;)V", "GetSetFenceId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFenceId.(Ljava/lang/String;)V";
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

		static Delegate cb_getMaxDis2Center;
#pragma warning disable 0169
		static Delegate GetGetMaxDis2CenterHandler ()
		{
			if (cb_getMaxDis2Center == null)
				cb_getMaxDis2Center = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxDis2Center);
			return cb_getMaxDis2Center;
		}

		static float n_GetMaxDis2Center (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDis2Center;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxDis2Center_F;
#pragma warning disable 0169
		static Delegate GetSetMaxDis2Center_FHandler ()
		{
			if (cb_setMaxDis2Center_F == null)
				cb_setMaxDis2Center_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxDis2Center_F);
			return cb_setMaxDis2Center_F;
		}

		static void n_SetMaxDis2Center_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxDis2Center = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxDis2Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getMaxDis2Center' and count(parameter)=0]"
			[Register ("getMaxDis2Center", "()F", "GetGetMaxDis2CenterHandler")]
			get {
				const string __id = "getMaxDis2Center.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setMaxDis2Center' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxDis2Center", "(F)V", "GetSetMaxDis2Center_FHandler")]
			set {
				const string __id = "setMaxDis2Center.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinDis2Center;
#pragma warning disable 0169
		static Delegate GetGetMinDis2CenterHandler ()
		{
			if (cb_getMinDis2Center == null)
				cb_getMinDis2Center = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinDis2Center);
			return cb_getMinDis2Center;
		}

		static float n_GetMinDis2Center (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDis2Center;
		}
#pragma warning restore 0169

		static Delegate cb_setMinDis2Center_F;
#pragma warning disable 0169
		static Delegate GetSetMinDis2Center_FHandler ()
		{
			if (cb_setMinDis2Center_F == null)
				cb_setMinDis2Center_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinDis2Center_F);
			return cb_setMinDis2Center_F;
		}

		static void n_SetMinDis2Center_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinDis2Center = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float MinDis2Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getMinDis2Center' and count(parameter)=0]"
			[Register ("getMinDis2Center", "()F", "GetGetMinDis2CenterHandler")]
			get {
				const string __id = "getMinDis2Center.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setMinDis2Center' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinDis2Center", "(F)V", "GetSetMinDis2Center_FHandler")]
			set {
				const string __id = "setMinDis2Center.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPendingIntent;
#pragma warning disable 0169
		static Delegate GetGetPendingIntentHandler ()
		{
			if (cb_getPendingIntent == null)
				cb_getPendingIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingIntent);
			return cb_getPendingIntent;
		}

		static IntPtr n_GetPendingIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PendingIntent);
		}
#pragma warning restore 0169

		static Delegate cb_setPendingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetPendingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setPendingIntent_Landroid_app_PendingIntent_ == null)
				cb_setPendingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPendingIntent_Landroid_app_PendingIntent_);
			return cb_setPendingIntent_Landroid_app_PendingIntent_;
		}

		static void n_SetPendingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PendingIntent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.PendingIntent PendingIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getPendingIntent' and count(parameter)=0]"
			[Register ("getPendingIntent", "()Landroid/app/PendingIntent;", "GetGetPendingIntentHandler")]
			get {
				const string __id = "getPendingIntent.()Landroid/app/PendingIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setPendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
			[Register ("setPendingIntent", "(Landroid/app/PendingIntent;)V", "GetSetPendingIntent_Landroid_app_PendingIntent_Handler")]
			set {
				const string __id = "setPendingIntent.(Landroid/app/PendingIntent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPendingIntentAction;
#pragma warning disable 0169
		static Delegate GetGetPendingIntentActionHandler ()
		{
			if (cb_getPendingIntentAction == null)
				cb_getPendingIntentAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingIntentAction);
			return cb_getPendingIntentAction;
		}

		static IntPtr n_GetPendingIntentAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PendingIntentAction);
		}
#pragma warning restore 0169

		static Delegate cb_setPendingIntentAction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPendingIntentAction_Ljava_lang_String_Handler ()
		{
			if (cb_setPendingIntentAction_Ljava_lang_String_ == null)
				cb_setPendingIntentAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPendingIntentAction_Ljava_lang_String_);
			return cb_setPendingIntentAction_Ljava_lang_String_;
		}

		static void n_SetPendingIntentAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PendingIntentAction = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PendingIntentAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getPendingIntentAction' and count(parameter)=0]"
			[Register ("getPendingIntentAction", "()Ljava/lang/String;", "GetGetPendingIntentActionHandler")]
			get {
				const string __id = "getPendingIntentAction.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setPendingIntentAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPendingIntentAction", "(Ljava/lang/String;)V", "GetSetPendingIntentAction_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPendingIntentAction.(Ljava/lang/String;)V";
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

		static Delegate cb_getPoiItem;
#pragma warning disable 0169
		static Delegate GetGetPoiItemHandler ()
		{
			if (cb_getPoiItem == null)
				cb_getPoiItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiItem);
			return cb_getPoiItem;
		}

		static IntPtr n_GetPoiItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PoiItem);
		}
#pragma warning restore 0169

		static Delegate cb_setPoiItem_Lcom_amap_api_fence_PoiItem_;
#pragma warning disable 0169
		static Delegate GetSetPoiItem_Lcom_amap_api_fence_PoiItem_Handler ()
		{
			if (cb_setPoiItem_Lcom_amap_api_fence_PoiItem_ == null)
				cb_setPoiItem_Lcom_amap_api_fence_PoiItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoiItem_Lcom_amap_api_fence_PoiItem_);
			return cb_setPoiItem_Lcom_amap_api_fence_PoiItem_;
		}

		static void n_SetPoiItem_Lcom_amap_api_fence_PoiItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Fence.PoiItem p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoiItem = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Fence.PoiItem PoiItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getPoiItem' and count(parameter)=0]"
			[Register ("getPoiItem", "()Lcom/amap/api/fence/PoiItem;", "GetGetPoiItemHandler")]
			get {
				const string __id = "getPoiItem.()Lcom/amap/api/fence/PoiItem;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setPoiItem' and count(parameter)=1 and parameter[1][@type='com.amap.api.fence.PoiItem']]"
			[Register ("setPoiItem", "(Lcom/amap/api/fence/PoiItem;)V", "GetSetPoiItem_Lcom_amap_api_fence_PoiItem_Handler")]
			set {
				const string __id = "setPoiItem.(Lcom/amap/api/fence/PoiItem;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPointList;
#pragma warning disable 0169
		static Delegate GetGetPointListHandler ()
		{
			if (cb_getPointList == null)
				cb_getPointList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointList);
			return cb_getPointList;
		}

		static IntPtr n_GetPointList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint>>.ToLocalJniHandle (__this.PointList);
		}
#pragma warning restore 0169

		static Delegate cb_setPointList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPointList_Ljava_util_List_Handler ()
		{
			if (cb_setPointList_Ljava_util_List_ == null)
				cb_setPointList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPointList_Ljava_util_List_);
			return cb_setPointList_Ljava_util_List_;
		}

		static void n_SetPointList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PointList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint>> PointList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getPointList' and count(parameter)=0]"
			[Register ("getPointList", "()Ljava/util/List;", "GetGetPointListHandler")]
			get {
				const string __id = "getPointList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setPointList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.List&lt;com.amap.api.location.DPoint&gt;&gt;']]"
			[Register ("setPointList", "(Ljava/util/List;)V", "GetSetPointList_Ljava_util_List_Handler")]
			set {
				const string __id = "setPointList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint>>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRadius);
			return cb_getRadius;
		}

		static float n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_F;
#pragma warning disable 0169
		static Delegate GetSetRadius_FHandler ()
		{
			if (cb_setRadius_F == null)
				cb_setRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRadius_F);
			return cb_setRadius_F;
		}

		static void n_SetRadius_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
			set {
				const string __id = "setRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_I;
#pragma warning disable 0169
		static Delegate GetSetStatus_IHandler ()
		{
			if (cb_setStatus_I == null)
				cb_setStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatus_I);
			return cb_setStatus_I;
		}

		static void n_SetStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatus", "(I)V", "GetSetStatus_IHandler")]
			set {
				const string __id = "setStatus.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)V", "GetSetType_IHandler")]
			set {
				const string __id = "setType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Amap.Api.Fence.GeoFence __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFence']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
