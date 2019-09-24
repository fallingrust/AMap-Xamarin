using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']"
	[global::Android.Runtime.Register ("com/amap/api/location/AMapLocation", DoNotGenerateAcw=true)]
	public partial class AMapLocation : global::Android.Locations.Location, global::Android.OS.IParcelable, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='COORD_TYPE_GCJ02']"
		[Register ("COORD_TYPE_GCJ02")]
		public const string CoordTypeGcj02 = (string) "GCJ02";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='COORD_TYPE_WGS84']"
		[Register ("COORD_TYPE_WGS84")]
		public const string CoordTypeWgs84 = (string) "WGS84";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_AIRPLANEMODE_WIFIOFF']"
		[Register ("ERROR_CODE_AIRPLANEMODE_WIFIOFF")]
		public const int ErrorCodeAirplanemodeWifioff = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_AUTH']"
		[Register ("ERROR_CODE_FAILURE_AUTH")]
		public const int ErrorCodeFailureAuth = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_CELL']"
		[Register ("ERROR_CODE_FAILURE_CELL")]
		public const int ErrorCodeFailureCell = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_CONNECTION']"
		[Register ("ERROR_CODE_FAILURE_CONNECTION")]
		public const int ErrorCodeFailureConnection = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_INIT']"
		[Register ("ERROR_CODE_FAILURE_INIT")]
		public const int ErrorCodeFailureInit = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_LOCATION']"
		[Register ("ERROR_CODE_FAILURE_LOCATION")]
		public const int ErrorCodeFailureLocation = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_LOCATION_PARAMETER']"
		[Register ("ERROR_CODE_FAILURE_LOCATION_PARAMETER")]
		public const int ErrorCodeFailureLocationParameter = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_LOCATION_PERMISSION']"
		[Register ("ERROR_CODE_FAILURE_LOCATION_PERMISSION")]
		public const int ErrorCodeFailureLocationPermission = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_NOENOUGHSATELLITES']"
		[Register ("ERROR_CODE_FAILURE_NOENOUGHSATELLITES")]
		public const int ErrorCodeFailureNoenoughsatellites = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_NOWIFIANDAP']"
		[Register ("ERROR_CODE_FAILURE_NOWIFIANDAP")]
		public const int ErrorCodeFailureNowifiandap = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_PARSER']"
		[Register ("ERROR_CODE_FAILURE_PARSER")]
		public const int ErrorCodeFailureParser = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_SIMULATION_LOCATION']"
		[Register ("ERROR_CODE_FAILURE_SIMULATION_LOCATION")]
		public const int ErrorCodeFailureSimulationLocation = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_FAILURE_WIFI_INFO']"
		[Register ("ERROR_CODE_FAILURE_WIFI_INFO")]
		public const int ErrorCodeFailureWifiInfo = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_INVALID_PARAMETER']"
		[Register ("ERROR_CODE_INVALID_PARAMETER")]
		public const int ErrorCodeInvalidParameter = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_NOCGI_WIFIOFF']"
		[Register ("ERROR_CODE_NOCGI_WIFIOFF")]
		public const int ErrorCodeNocgiWifioff = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_SERVICE_FAIL']"
		[Register ("ERROR_CODE_SERVICE_FAIL")]
		public const int ErrorCodeServiceFail = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='ERROR_CODE_UNKNOWN']"
		[Register ("ERROR_CODE_UNKNOWN")]
		public const int ErrorCodeUnknown = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='GPS_ACCURACY_BAD']"
		[Register ("GPS_ACCURACY_BAD")]
		public const int GpsAccuracyBad = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='GPS_ACCURACY_GOOD']"
		[Register ("GPS_ACCURACY_GOOD")]
		public const int GpsAccuracyGood = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='GPS_ACCURACY_UNKNOWN']"
		[Register ("GPS_ACCURACY_UNKNOWN")]
		public const int GpsAccuracyUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_SUCCESS']"
		[Register ("LOCATION_SUCCESS")]
		public const int LocationSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_AMAP']"
		[Register ("LOCATION_TYPE_AMAP")]
		public const int LocationTypeAmap = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_CELL']"
		[Register ("LOCATION_TYPE_CELL")]
		public const int LocationTypeCell = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_FAST']"
		[Register ("LOCATION_TYPE_FAST")]
		[Obsolete ("deprecated")]
		public const int LocationTypeFast = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_FIX_CACHE']"
		[Register ("LOCATION_TYPE_FIX_CACHE")]
		public const int LocationTypeFixCache = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_GPS']"
		[Register ("LOCATION_TYPE_GPS")]
		public const int LocationTypeGps = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_LAST_LOCATION_CACHE']"
		[Register ("LOCATION_TYPE_LAST_LOCATION_CACHE")]
		public const int LocationTypeLastLocationCache = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_OFFLINE']"
		[Register ("LOCATION_TYPE_OFFLINE")]
		public const int LocationTypeOffline = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_SAME_REQ']"
		[Register ("LOCATION_TYPE_SAME_REQ")]
		public const int LocationTypeSameReq = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='LOCATION_TYPE_WIFI']"
		[Register ("LOCATION_TYPE_WIFI")]
		public const int LocationTypeWifi = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='TRUSTED_LEVEL_BAD']"
		[Register ("TRUSTED_LEVEL_BAD")]
		public const int TrustedLevelBad = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='TRUSTED_LEVEL_HIGH']"
		[Register ("TRUSTED_LEVEL_HIGH")]
		public const int TrustedLevelHigh = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='TRUSTED_LEVEL_LOW']"
		[Register ("TRUSTED_LEVEL_LOW")]
		public const int TrustedLevelLow = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='TRUSTED_LEVEL_NORMAL']"
		[Register ("TRUSTED_LEVEL_NORMAL")]
		public const int TrustedLevelNormal = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='a']"
		[Register ("a")]
		protected string A {
			get {
				const string __id = "a.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/field[@name='b']"
		[Register ("b")]
		protected string B {
			get {
				const string __id = "b.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocation", typeof (AMapLocation));
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

		protected AMapLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/constructor[@name='AMapLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register (".ctor", "(Landroid/location/Location;)V", "")]
		public unsafe AMapLocation (global::Android.Locations.Location p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/location/Location;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/constructor[@name='AMapLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AMapLocation (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdCode;
#pragma warning disable 0169
		static Delegate GetGetAdCodeHandler ()
		{
			if (cb_getAdCode == null)
				cb_getAdCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdCode);
			return cb_getAdCode;
		}

		static IntPtr n_GetAdCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdCode);
		}
#pragma warning restore 0169

		static Delegate cb_setAdCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdCode_Ljava_lang_String_Handler ()
		{
			if (cb_setAdCode_Ljava_lang_String_ == null)
				cb_setAdCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdCode_Ljava_lang_String_);
			return cb_setAdCode_Ljava_lang_String_;
		}

		static void n_SetAdCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AdCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getAdCode' and count(parameter)=0]"
			[Register ("getAdCode", "()Ljava/lang/String;", "GetGetAdCodeHandler")]
			get {
				const string __id = "getAdCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setAdCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdCode", "(Ljava/lang/String;)V", "GetSetAdCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAdCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAddress.(Ljava/lang/String;)V";
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

		static Delegate cb_getAoiName;
#pragma warning disable 0169
		static Delegate GetGetAoiNameHandler ()
		{
			if (cb_getAoiName == null)
				cb_getAoiName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAoiName);
			return cb_getAoiName;
		}

		static IntPtr n_GetAoiName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AoiName);
		}
#pragma warning restore 0169

		static Delegate cb_setAoiName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAoiName_Ljava_lang_String_Handler ()
		{
			if (cb_setAoiName_Ljava_lang_String_ == null)
				cb_setAoiName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAoiName_Ljava_lang_String_);
			return cb_setAoiName_Ljava_lang_String_;
		}

		static void n_SetAoiName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AoiName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AoiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getAoiName' and count(parameter)=0]"
			[Register ("getAoiName", "()Ljava/lang/String;", "GetGetAoiNameHandler")]
			get {
				const string __id = "getAoiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setAoiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAoiName", "(Ljava/lang/String;)V", "GetSetAoiName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAoiName.(Ljava/lang/String;)V";
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

		static Delegate cb_getBuildingId;
#pragma warning disable 0169
		static Delegate GetGetBuildingIdHandler ()
		{
			if (cb_getBuildingId == null)
				cb_getBuildingId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuildingId);
			return cb_getBuildingId;
		}

		static IntPtr n_GetBuildingId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BuildingId);
		}
#pragma warning restore 0169

		static Delegate cb_setBuildingId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBuildingId_Ljava_lang_String_Handler ()
		{
			if (cb_setBuildingId_Ljava_lang_String_ == null)
				cb_setBuildingId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBuildingId_Ljava_lang_String_);
			return cb_setBuildingId_Ljava_lang_String_;
		}

		static void n_SetBuildingId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BuildingId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string BuildingId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getBuildingId' and count(parameter)=0]"
			[Register ("getBuildingId", "()Ljava/lang/String;", "GetGetBuildingIdHandler")]
			get {
				const string __id = "getBuildingId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setBuildingId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuildingId", "(Ljava/lang/String;)V", "GetSetBuildingId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBuildingId.(Ljava/lang/String;)V";
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

		static Delegate cb_getCity;
#pragma warning disable 0169
		static Delegate GetGetCityHandler ()
		{
			if (cb_getCity == null)
				cb_getCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCity);
			return cb_getCity;
		}

		static IntPtr n_GetCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.City);
		}
#pragma warning restore 0169

		static Delegate cb_setCity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCity_Ljava_lang_String_Handler ()
		{
			if (cb_setCity_Ljava_lang_String_ == null)
				cb_setCity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCity_Ljava_lang_String_);
			return cb_setCity_Ljava_lang_String_;
		}

		static void n_SetCity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.City = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler")]
			get {
				const string __id = "getCity.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCity", "(Ljava/lang/String;)V", "GetSetCity_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCity.(Ljava/lang/String;)V";
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

		static Delegate cb_getCityCode;
#pragma warning disable 0169
		static Delegate GetGetCityCodeHandler ()
		{
			if (cb_getCityCode == null)
				cb_getCityCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityCode);
			return cb_getCityCode;
		}

		static IntPtr n_GetCityCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCityCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCityCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCityCode_Ljava_lang_String_ == null)
				cb_setCityCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCityCode_Ljava_lang_String_);
			return cb_setCityCode_Ljava_lang_String_;
		}

		static void n_SetCityCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CityCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CityCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getCityCode' and count(parameter)=0]"
			[Register ("getCityCode", "()Ljava/lang/String;", "GetGetCityCodeHandler")]
			get {
				const string __id = "getCityCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setCityCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCityCode", "(Ljava/lang/String;)V", "GetSetCityCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCityCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getConScenario;
#pragma warning disable 0169
		static Delegate GetGetConScenarioHandler ()
		{
			if (cb_getConScenario == null)
				cb_getConScenario = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConScenario);
			return cb_getConScenario;
		}

		static int n_GetConScenario (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConScenario;
		}
#pragma warning restore 0169

		static Delegate cb_setConScenario_I;
#pragma warning disable 0169
		static Delegate GetSetConScenario_IHandler ()
		{
			if (cb_setConScenario_I == null)
				cb_setConScenario_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConScenario_I);
			return cb_setConScenario_I;
		}

		static void n_SetConScenario_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConScenario = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ConScenario {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getConScenario' and count(parameter)=0]"
			[Register ("getConScenario", "()I", "GetGetConScenarioHandler")]
			get {
				const string __id = "getConScenario.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setConScenario' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConScenario", "(I)V", "GetSetConScenario_IHandler")]
			set {
				const string __id = "setConScenario.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCoordType;
#pragma warning disable 0169
		static Delegate GetGetCoordTypeHandler ()
		{
			if (cb_getCoordType == null)
				cb_getCoordType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCoordType);
			return cb_getCoordType;
		}

		static IntPtr n_GetCoordType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CoordType);
		}
#pragma warning restore 0169

		static Delegate cb_setCoordType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCoordType_Ljava_lang_String_Handler ()
		{
			if (cb_setCoordType_Ljava_lang_String_ == null)
				cb_setCoordType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCoordType_Ljava_lang_String_);
			return cb_setCoordType_Ljava_lang_String_;
		}

		static void n_SetCoordType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CoordType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CoordType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getCoordType' and count(parameter)=0]"
			[Register ("getCoordType", "()Ljava/lang/String;", "GetGetCoordTypeHandler")]
			get {
				const string __id = "getCoordType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setCoordType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCoordType", "(Ljava/lang/String;)V", "GetSetCoordType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCoordType.(Ljava/lang/String;)V";
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

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static Delegate cb_setCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setCountry_Ljava_lang_String_ == null)
				cb_setCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountry_Ljava_lang_String_);
			return cb_setCountry_Ljava_lang_String_;
		}

		static void n_SetCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Country = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountry", "(Ljava/lang/String;)V", "GetSetCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDescription.(Ljava/lang/String;)V";
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

		static Delegate cb_getDistrict;
#pragma warning disable 0169
		static Delegate GetGetDistrictHandler ()
		{
			if (cb_getDistrict == null)
				cb_getDistrict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistrict);
			return cb_getDistrict;
		}

		static IntPtr n_GetDistrict (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.District);
		}
#pragma warning restore 0169

		static Delegate cb_setDistrict_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDistrict_Ljava_lang_String_Handler ()
		{
			if (cb_setDistrict_Ljava_lang_String_ == null)
				cb_setDistrict_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDistrict_Ljava_lang_String_);
			return cb_setDistrict_Ljava_lang_String_;
		}

		static void n_SetDistrict_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.District = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string District {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getDistrict' and count(parameter)=0]"
			[Register ("getDistrict", "()Ljava/lang/String;", "GetGetDistrictHandler")]
			get {
				const string __id = "getDistrict.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setDistrict' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDistrict", "(Ljava/lang/String;)V", "GetSetDistrict_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDistrict.(Ljava/lang/String;)V";
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

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCode_I;
#pragma warning disable 0169
		static Delegate GetSetErrorCode_IHandler ()
		{
			if (cb_setErrorCode_I == null)
				cb_setErrorCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetErrorCode_I);
			return cb_setErrorCode_I;
		}

		static void n_SetErrorCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				const string __id = "getErrorCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setErrorCode", "(I)V", "GetSetErrorCode_IHandler")]
			set {
				const string __id = "setErrorCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorInfo;
#pragma warning disable 0169
		static Delegate GetGetErrorInfoHandler ()
		{
			if (cb_getErrorInfo == null)
				cb_getErrorInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorInfo);
			return cb_getErrorInfo;
		}

		static IntPtr n_GetErrorInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetErrorInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setErrorInfo_Ljava_lang_String_ == null)
				cb_setErrorInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorInfo_Ljava_lang_String_);
			return cb_setErrorInfo_Ljava_lang_String_;
		}

		static void n_SetErrorInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorInfo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ErrorInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getErrorInfo' and count(parameter)=0]"
			[Register ("getErrorInfo", "()Ljava/lang/String;", "GetGetErrorInfoHandler")]
			get {
				const string __id = "getErrorInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setErrorInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setErrorInfo", "(Ljava/lang/String;)V", "GetSetErrorInfo_Ljava_lang_String_Handler")]
			set {
				const string __id = "setErrorInfo.(Ljava/lang/String;)V";
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

		static Delegate cb_isFixLastLocation;
#pragma warning disable 0169
		static Delegate GetIsFixLastLocationHandler ()
		{
			if (cb_isFixLastLocation == null)
				cb_isFixLastLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFixLastLocation);
			return cb_isFixLastLocation;
		}

		static bool n_IsFixLastLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FixLastLocation;
		}
#pragma warning restore 0169

		static Delegate cb_setFixLastLocation_Z;
#pragma warning disable 0169
		static Delegate GetSetFixLastLocation_ZHandler ()
		{
			if (cb_setFixLastLocation_Z == null)
				cb_setFixLastLocation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFixLastLocation_Z);
			return cb_setFixLastLocation_Z;
		}

		static void n_SetFixLastLocation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FixLastLocation = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool FixLastLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='isFixLastLocation' and count(parameter)=0]"
			[Register ("isFixLastLocation", "()Z", "GetIsFixLastLocationHandler")]
			get {
				const string __id = "isFixLastLocation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setFixLastLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFixLastLocation", "(Z)V", "GetSetFixLastLocation_ZHandler")]
			set {
				const string __id = "setFixLastLocation.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFloor;
#pragma warning disable 0169
		static Delegate GetGetFloorHandler ()
		{
			if (cb_getFloor == null)
				cb_getFloor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFloor);
			return cb_getFloor;
		}

		static IntPtr n_GetFloor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Floor);
		}
#pragma warning restore 0169

		static Delegate cb_setFloor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFloor_Ljava_lang_String_Handler ()
		{
			if (cb_setFloor_Ljava_lang_String_ == null)
				cb_setFloor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFloor_Ljava_lang_String_);
			return cb_setFloor_Ljava_lang_String_;
		}

		static void n_SetFloor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Floor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Floor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getFloor' and count(parameter)=0]"
			[Register ("getFloor", "()Ljava/lang/String;", "GetGetFloorHandler")]
			get {
				const string __id = "getFloor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setFloor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFloor", "(Ljava/lang/String;)V", "GetSetFloor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFloor.(Ljava/lang/String;)V";
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

		static Delegate cb_getGpsAccuracyStatus;
#pragma warning disable 0169
		static Delegate GetGetGpsAccuracyStatusHandler ()
		{
			if (cb_getGpsAccuracyStatus == null)
				cb_getGpsAccuracyStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGpsAccuracyStatus);
			return cb_getGpsAccuracyStatus;
		}

		static int n_GetGpsAccuracyStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GpsAccuracyStatus;
		}
#pragma warning restore 0169

		static Delegate cb_setGpsAccuracyStatus_I;
#pragma warning disable 0169
		static Delegate GetSetGpsAccuracyStatus_IHandler ()
		{
			if (cb_setGpsAccuracyStatus_I == null)
				cb_setGpsAccuracyStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGpsAccuracyStatus_I);
			return cb_setGpsAccuracyStatus_I;
		}

		static void n_SetGpsAccuracyStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GpsAccuracyStatus = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int GpsAccuracyStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getGpsAccuracyStatus' and count(parameter)=0]"
			[Register ("getGpsAccuracyStatus", "()I", "GetGetGpsAccuracyStatusHandler")]
			get {
				const string __id = "getGpsAccuracyStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setGpsAccuracyStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGpsAccuracyStatus", "(I)V", "GetSetGpsAccuracyStatus_IHandler")]
			set {
				const string __id = "setGpsAccuracyStatus.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationDetail;
#pragma warning disable 0169
		static Delegate GetGetLocationDetailHandler ()
		{
			if (cb_getLocationDetail == null)
				cb_getLocationDetail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationDetail);
			return cb_getLocationDetail;
		}

		static IntPtr n_GetLocationDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocationDetail);
		}
#pragma warning restore 0169

		static Delegate cb_setLocationDetail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocationDetail_Ljava_lang_String_Handler ()
		{
			if (cb_setLocationDetail_Ljava_lang_String_ == null)
				cb_setLocationDetail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationDetail_Ljava_lang_String_);
			return cb_setLocationDetail_Ljava_lang_String_;
		}

		static void n_SetLocationDetail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocationDetail = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string LocationDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getLocationDetail' and count(parameter)=0]"
			[Register ("getLocationDetail", "()Ljava/lang/String;", "GetGetLocationDetailHandler")]
			get {
				const string __id = "getLocationDetail.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setLocationDetail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocationDetail", "(Ljava/lang/String;)V", "GetSetLocationDetail_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLocationDetail.(Ljava/lang/String;)V";
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

		static Delegate cb_getLocationQualityReport;
#pragma warning disable 0169
		static Delegate GetGetLocationQualityReportHandler ()
		{
			if (cb_getLocationQualityReport == null)
				cb_getLocationQualityReport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationQualityReport);
			return cb_getLocationQualityReport;
		}

		static IntPtr n_GetLocationQualityReport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationQualityReport);
		}
#pragma warning restore 0169

		static Delegate cb_setLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_;
#pragma warning disable 0169
		static Delegate GetSetLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_Handler ()
		{
			if (cb_setLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_ == null)
				cb_setLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_);
			return cb_setLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_;
		}

		static void n_SetLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationQualityReport p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocationQualityReport = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationQualityReport LocationQualityReport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getLocationQualityReport' and count(parameter)=0]"
			[Register ("getLocationQualityReport", "()Lcom/amap/api/location/AMapLocationQualityReport;", "GetGetLocationQualityReportHandler")]
			get {
				const string __id = "getLocationQualityReport.()Lcom/amap/api/location/AMapLocationQualityReport;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationQualityReport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setLocationQualityReport' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationQualityReport']]"
			[Register ("setLocationQualityReport", "(Lcom/amap/api/location/AMapLocationQualityReport;)V", "GetSetLocationQualityReport_Lcom_amap_api_location_AMapLocationQualityReport_Handler")]
			set {
				const string __id = "setLocationQualityReport.(Lcom/amap/api/location/AMapLocationQualityReport;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationType;
#pragma warning disable 0169
		static Delegate GetGetLocationTypeHandler ()
		{
			if (cb_getLocationType == null)
				cb_getLocationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocationType);
			return cb_getLocationType;
		}

		static int n_GetLocationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationType;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationType_I;
#pragma warning disable 0169
		static Delegate GetSetLocationType_IHandler ()
		{
			if (cb_setLocationType_I == null)
				cb_setLocationType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLocationType_I);
			return cb_setLocationType_I;
		}

		static void n_SetLocationType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int LocationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getLocationType' and count(parameter)=0]"
			[Register ("getLocationType", "()I", "GetGetLocationTypeHandler")]
			get {
				const string __id = "getLocationType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setLocationType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocationType", "(I)V", "GetSetLocationType_IHandler")]
			set {
				const string __id = "setLocationType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isMock;
#pragma warning disable 0169
		static Delegate GetIsMockHandler ()
		{
			if (cb_isMock == null)
				cb_isMock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMock);
			return cb_isMock;
		}

		static bool n_IsMock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mock;
		}
#pragma warning restore 0169

		static Delegate cb_setMock_Z;
#pragma warning disable 0169
		static Delegate GetSetMock_ZHandler ()
		{
			if (cb_setMock_Z == null)
				cb_setMock_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMock_Z);
			return cb_setMock_Z;
		}

		static void n_SetMock_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mock = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool Mock {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='isMock' and count(parameter)=0]"
			[Register ("isMock", "()Z", "GetIsMockHandler")]
			get {
				const string __id = "isMock.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setMock' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMock", "(Z)V", "GetSetMock_ZHandler")]
			set {
				const string __id = "setMock.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOffset;
#pragma warning disable 0169
		static Delegate GetIsOffsetHandler ()
		{
			if (cb_isOffset == null)
				cb_isOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOffset);
			return cb_isOffset;
		}

		static bool n_IsOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_Z;
#pragma warning disable 0169
		static Delegate GetSetOffset_ZHandler ()
		{
			if (cb_setOffset_Z == null)
				cb_setOffset_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOffset_Z);
			return cb_setOffset_Z;
		}

		static void n_SetOffset_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offset = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='isOffset' and count(parameter)=0]"
			[Register ("isOffset", "()Z", "GetIsOffsetHandler")]
			get {
				const string __id = "isOffset.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOffset", "(Z)V", "GetSetOffset_ZHandler")]
			set {
				const string __id = "setOffset.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPoiName;
#pragma warning disable 0169
		static Delegate GetGetPoiNameHandler ()
		{
			if (cb_getPoiName == null)
				cb_getPoiName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiName);
			return cb_getPoiName;
		}

		static IntPtr n_GetPoiName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PoiName);
		}
#pragma warning restore 0169

		static Delegate cb_setPoiName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPoiName_Ljava_lang_String_Handler ()
		{
			if (cb_setPoiName_Ljava_lang_String_ == null)
				cb_setPoiName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoiName_Ljava_lang_String_);
			return cb_setPoiName_Ljava_lang_String_;
		}

		static void n_SetPoiName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoiName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PoiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getPoiName' and count(parameter)=0]"
			[Register ("getPoiName", "()Ljava/lang/String;", "GetGetPoiNameHandler")]
			get {
				const string __id = "getPoiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setPoiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPoiName", "(Ljava/lang/String;)V", "GetSetPoiName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPoiName.(Ljava/lang/String;)V";
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

		static Delegate cb_getProvince;
#pragma warning disable 0169
		static Delegate GetGetProvinceHandler ()
		{
			if (cb_getProvince == null)
				cb_getProvince = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvince);
			return cb_getProvince;
		}

		static IntPtr n_GetProvince (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Province);
		}
#pragma warning restore 0169

		static Delegate cb_setProvince_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProvince_Ljava_lang_String_Handler ()
		{
			if (cb_setProvince_Ljava_lang_String_ == null)
				cb_setProvince_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProvince_Ljava_lang_String_);
			return cb_setProvince_Ljava_lang_String_;
		}

		static void n_SetProvince_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Province = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler")]
			get {
				const string __id = "getProvince.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setProvince' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProvince", "(Ljava/lang/String;)V", "GetSetProvince_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProvince.(Ljava/lang/String;)V";
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

		static Delegate cb_getRoad;
#pragma warning disable 0169
		static Delegate GetGetRoadHandler ()
		{
			if (cb_getRoad == null)
				cb_getRoad = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoad);
			return cb_getRoad;
		}

		static IntPtr n_GetRoad (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Road);
		}
#pragma warning restore 0169

		static Delegate cb_setRoad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRoad_Ljava_lang_String_Handler ()
		{
			if (cb_setRoad_Ljava_lang_String_ == null)
				cb_setRoad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRoad_Ljava_lang_String_);
			return cb_setRoad_Ljava_lang_String_;
		}

		static void n_SetRoad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Road = p0;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string Road {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getRoad' and count(parameter)=0]"
			[Register ("getRoad", "()Ljava/lang/String;", "GetGetRoadHandler")]
			get {
				const string __id = "getRoad.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setRoad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRoad", "(Ljava/lang/String;)V", "GetSetRoad_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRoad.(Ljava/lang/String;)V";
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

		static Delegate cb_getSatellites;
#pragma warning disable 0169
		static Delegate GetGetSatellitesHandler ()
		{
			if (cb_getSatellites == null)
				cb_getSatellites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSatellites);
			return cb_getSatellites;
		}

		static int n_GetSatellites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Satellites;
		}
#pragma warning restore 0169

		static Delegate cb_setSatellites_I;
#pragma warning disable 0169
		static Delegate GetSetSatellites_IHandler ()
		{
			if (cb_setSatellites_I == null)
				cb_setSatellites_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSatellites_I);
			return cb_setSatellites_I;
		}

		static void n_SetSatellites_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Satellites = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Satellites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getSatellites' and count(parameter)=0]"
			[Register ("getSatellites", "()I", "GetGetSatellitesHandler")]
			get {
				const string __id = "getSatellites.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setSatellites' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSatellites", "(I)V", "GetSetSatellites_IHandler")]
			set {
				const string __id = "setSatellites.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStreet;
#pragma warning disable 0169
		static Delegate GetGetStreetHandler ()
		{
			if (cb_getStreet == null)
				cb_getStreet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreet);
			return cb_getStreet;
		}

		static IntPtr n_GetStreet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Street);
		}
#pragma warning restore 0169

		static Delegate cb_setStreet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreet_Ljava_lang_String_Handler ()
		{
			if (cb_setStreet_Ljava_lang_String_ == null)
				cb_setStreet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreet_Ljava_lang_String_);
			return cb_setStreet_Ljava_lang_String_;
		}

		static void n_SetStreet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Street = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler")]
			get {
				const string __id = "getStreet.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setStreet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreet", "(Ljava/lang/String;)V", "GetSetStreet_Ljava_lang_String_Handler")]
			set {
				const string __id = "setStreet.(Ljava/lang/String;)V";
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

		static Delegate cb_getStreetNum;
#pragma warning disable 0169
		static Delegate GetGetStreetNumHandler ()
		{
			if (cb_getStreetNum == null)
				cb_getStreetNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetNum);
			return cb_getStreetNum;
		}

		static IntPtr n_GetStreetNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetNum);
		}
#pragma warning restore 0169

		public virtual unsafe string StreetNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getStreetNum' and count(parameter)=0]"
			[Register ("getStreetNum", "()Ljava/lang/String;", "GetGetStreetNumHandler")]
			get {
				const string __id = "getStreetNum.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrustedLevel;
#pragma warning disable 0169
		static Delegate GetGetTrustedLevelHandler ()
		{
			if (cb_getTrustedLevel == null)
				cb_getTrustedLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrustedLevel);
			return cb_getTrustedLevel;
		}

		static int n_GetTrustedLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrustedLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setTrustedLevel_I;
#pragma warning disable 0169
		static Delegate GetSetTrustedLevel_IHandler ()
		{
			if (cb_setTrustedLevel_I == null)
				cb_setTrustedLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTrustedLevel_I);
			return cb_setTrustedLevel_I;
		}

		static void n_SetTrustedLevel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrustedLevel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TrustedLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='getTrustedLevel' and count(parameter)=0]"
			[Register ("getTrustedLevel", "()I", "GetGetTrustedLevelHandler")]
			get {
				const string __id = "getTrustedLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setTrustedLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTrustedLevel", "(I)V", "GetSetTrustedLevel_IHandler")]
			set {
				const string __id = "setTrustedLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/amap/api/location/AMapLocation;", "GetCloneHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocation Clone ()
		{
			const string __id = "clone.()Lcom/amap/api/location/AMapLocation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setNumber_Ljava_lang_String_ == null)
				cb_setNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNumber_Ljava_lang_String_);
			return cb_setNumber_Ljava_lang_String_;
		}

		static void n_SetNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNumber (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='setNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNumber", "(Ljava/lang/String;)V", "GetSetNumber_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNumber (string p0)
		{
			const string __id = "setNumber.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toJson_I;
#pragma warning disable 0169
		static Delegate GetToJson_IHandler ()
		{
			if (cb_toJson_I == null)
				cb_toJson_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ToJson_I);
			return cb_toJson_I;
		}

		static IntPtr n_ToJson_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toJson", "(I)Lorg/json/JSONObject;", "GetToJson_IHandler")]
		public virtual unsafe global::Org.Json.JSONObject ToJson (int p0)
		{
			const string __id = "toJson.(I)Lorg/json/JSONObject;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toStr;
#pragma warning disable 0169
		static Delegate GetToStrHandler ()
		{
			if (cb_toStr == null)
				cb_toStr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToStr);
			return cb_toStr;
		}

		static IntPtr n_ToStr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToStr ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='toStr' and count(parameter)=0]"
		[Register ("toStr", "()Ljava/lang/String;", "GetToStrHandler")]
		public virtual unsafe string ToStr ()
		{
			const string __id = "toStr.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toStr_I;
#pragma warning disable 0169
		static Delegate GetToStr_IHandler ()
		{
			if (cb_toStr_I == null)
				cb_toStr_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ToStr_I);
			return cb_toStr_I;
		}

		static IntPtr n_ToStr_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Location.AMapLocation __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToStr (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocation']/method[@name='toStr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toStr", "(I)Ljava/lang/String;", "GetToStr_IHandler")]
		public virtual unsafe string ToStr (int p0)
		{
			const string __id = "toStr.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
