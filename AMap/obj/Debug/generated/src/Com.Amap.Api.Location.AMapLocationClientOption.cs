using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']"
	[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationClientOption", DoNotGenerateAcw=true)]
	public partial class AMapLocationClientOption : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Java.Lang.ICloneable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationMode']"
		[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationClientOption$AMapLocationMode", DoNotGenerateAcw=true)]
		public sealed partial class AMapLocationMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationMode']/field[@name='Battery_Saving']"
			[Register ("Battery_Saving")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode BatterySaving {
				get {
					const string __id = "Battery_Saving.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationMode']/field[@name='Device_Sensors']"
			[Register ("Device_Sensors")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode DeviceSensors {
				get {
					const string __id = "Device_Sensors.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationMode']/field[@name='Hight_Accuracy']"
			[Register ("Hight_Accuracy")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode HightAccuracy {
				get {
					const string __id = "Hight_Accuracy.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationClientOption$AMapLocationMode", typeof (AMapLocationMode));
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

			internal AMapLocationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode[] Values ()
			{
				const string __id = "values.()[Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationProtocol']"
		[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationClientOption$AMapLocationProtocol", DoNotGenerateAcw=true)]
		public sealed partial class AMapLocationProtocol : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationProtocol']/field[@name='HTTP']"
			[Register ("HTTP")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol Http {
				get {
					const string __id = "HTTP.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationProtocol']/field[@name='HTTPS']"
			[Register ("HTTPS")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol Https {
				get {
					const string __id = "HTTPS.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationClientOption$AMapLocationProtocol", typeof (AMapLocationProtocol));
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

			internal AMapLocationProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationProtocol']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationProtocol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationProtocol']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol[] Values ()
			{
				const string __id = "values.()[Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationPurpose']"
		[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationClientOption$AMapLocationPurpose", DoNotGenerateAcw=true)]
		public sealed partial class AMapLocationPurpose : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationPurpose']/field[@name='SignIn']"
			[Register ("SignIn")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose SignIn {
				get {
					const string __id = "SignIn.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationPurpose']/field[@name='Sport']"
			[Register ("Sport")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose Sport {
				get {
					const string __id = "Sport.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationPurpose']/field[@name='Transport']"
			[Register ("Transport")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose Transport {
				get {
					const string __id = "Transport.Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationClientOption$AMapLocationPurpose", typeof (AMapLocationPurpose));
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

			internal AMapLocationPurpose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationPurpose']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.AMapLocationPurpose']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose[] Values ()
			{
				const string __id = "values.()[Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.GeoLanguage']"
		[global::Android.Runtime.Register ("com/amap/api/location/AMapLocationClientOption$GeoLanguage", DoNotGenerateAcw=true)]
		public sealed partial class GeoLanguage : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.GeoLanguage']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage Default {
				get {
					const string __id = "DEFAULT.Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.GeoLanguage']/field[@name='EN']"
			[Register ("EN")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage En {
				get {
					const string __id = "EN.Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.GeoLanguage']/field[@name='ZH']"
			[Register ("ZH")]
			public static global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage Zh {
				get {
					const string __id = "ZH.Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationClientOption$GeoLanguage", typeof (GeoLanguage));
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

			internal GeoLanguage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.GeoLanguage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption.GeoLanguage']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;", "")]
			public static unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage[] Values ()
			{
				const string __id = "values.()[Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/AMapLocationClientOption", typeof (AMapLocationClientOption));
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

		protected AMapLocationClientOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/constructor[@name='AMapLocationClientOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AMapLocationClientOption ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/constructor[@name='AMapLocationClientOption' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe AMapLocationClientOption (global::Android.OS.Parcel p0)
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

		public static unsafe string APIKEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getAPIKEY' and count(parameter)=0]"
			[Register ("getAPIKEY", "()Ljava/lang/String;", "GetGetAPIKEYHandler")]
			get {
				const string __id = "getAPIKEY.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceModeDistanceFilter;
#pragma warning disable 0169
		static Delegate GetGetDeviceModeDistanceFilterHandler ()
		{
			if (cb_getDeviceModeDistanceFilter == null)
				cb_getDeviceModeDistanceFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDeviceModeDistanceFilter);
			return cb_getDeviceModeDistanceFilter;
		}

		static float n_GetDeviceModeDistanceFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceModeDistanceFilter;
		}
#pragma warning restore 0169

		public virtual unsafe float DeviceModeDistanceFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getDeviceModeDistanceFilter' and count(parameter)=0]"
			[Register ("getDeviceModeDistanceFilter", "()F", "GetGetDeviceModeDistanceFilterHandler")]
			get {
				const string __id = "getDeviceModeDistanceFilter.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool DownloadCoordinateConvertLibrary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isDownloadCoordinateConvertLibrary' and count(parameter)=0]"
			[Register ("isDownloadCoordinateConvertLibrary", "()Z", "GetIsDownloadCoordinateConvertLibraryHandler")]
			get {
				const string __id = "isDownloadCoordinateConvertLibrary.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setDownloadCoordinateConvertLibrary' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDownloadCoordinateConvertLibrary", "(Z)V", "GetSetDownloadCoordinateConvertLibrary_ZHandler")]
			set {
				const string __id = "setDownloadCoordinateConvertLibrary.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGpsFirstTimeout;
#pragma warning disable 0169
		static Delegate GetGetGpsFirstTimeoutHandler ()
		{
			if (cb_getGpsFirstTimeout == null)
				cb_getGpsFirstTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetGpsFirstTimeout);
			return cb_getGpsFirstTimeout;
		}

		static long n_GetGpsFirstTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GpsFirstTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe long GpsFirstTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getGpsFirstTimeout' and count(parameter)=0]"
			[Register ("getGpsFirstTimeout", "()J", "GetGetGpsFirstTimeoutHandler")]
			get {
				const string __id = "getGpsFirstTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHttpTimeOut;
#pragma warning disable 0169
		static Delegate GetGetHttpTimeOutHandler ()
		{
			if (cb_getHttpTimeOut == null)
				cb_getHttpTimeOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHttpTimeOut);
			return cb_getHttpTimeOut;
		}

		static long n_GetHttpTimeOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpTimeOut;
		}
#pragma warning restore 0169

		public virtual unsafe long HttpTimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getHttpTimeOut' and count(parameter)=0]"
			[Register ("getHttpTimeOut", "()J", "GetGetHttpTimeOutHandler")]
			get {
				const string __id = "getHttpTimeOut.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
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
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		public virtual unsafe long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getInterval' and count(parameter)=0]"
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

		static Delegate cb_isGpsFirst;
#pragma warning disable 0169
		static Delegate GetIsGpsFirstHandler ()
		{
			if (cb_isGpsFirst == null)
				cb_isGpsFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGpsFirst);
			return cb_isGpsFirst;
		}

		static bool n_IsGpsFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGpsFirst;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsGpsFirst {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isGpsFirst' and count(parameter)=0]"
			[Register ("isGpsFirst", "()Z", "GetIsGpsFirstHandler")]
			get {
				const string __id = "isGpsFirst.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isKillProcess;
#pragma warning disable 0169
		static Delegate GetIsKillProcessHandler ()
		{
			if (cb_isKillProcess == null)
				cb_isKillProcess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKillProcess);
			return cb_isKillProcess;
		}

		static bool n_IsKillProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKillProcess;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsKillProcess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isKillProcess' and count(parameter)=0]"
			[Register ("isKillProcess", "()Z", "GetIsKillProcessHandler")]
			get {
				const string __id = "isKillProcess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLocationCacheEnable;
#pragma warning disable 0169
		static Delegate GetIsLocationCacheEnableHandler ()
		{
			if (cb_isLocationCacheEnable == null)
				cb_isLocationCacheEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocationCacheEnable);
			return cb_isLocationCacheEnable;
		}

		static bool n_IsLocationCacheEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocationCacheEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLocationCacheEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isLocationCacheEnable' and count(parameter)=0]"
			[Register ("isLocationCacheEnable", "()Z", "GetIsLocationCacheEnableHandler")]
			get {
				const string __id = "isLocationCacheEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isMockEnable;
#pragma warning disable 0169
		static Delegate GetIsMockEnableHandler ()
		{
			if (cb_isMockEnable == null)
				cb_isMockEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMockEnable);
			return cb_isMockEnable;
		}

		static bool n_IsMockEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMockEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMockEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isMockEnable' and count(parameter)=0]"
			[Register ("isMockEnable", "()Z", "GetIsMockEnableHandler")]
			get {
				const string __id = "isMockEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNeedAddress;
#pragma warning disable 0169
		static Delegate GetIsNeedAddressHandler ()
		{
			if (cb_isNeedAddress == null)
				cb_isNeedAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedAddress);
			return cb_isNeedAddress;
		}

		static bool n_IsNeedAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedAddress;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isNeedAddress' and count(parameter)=0]"
			[Register ("isNeedAddress", "()Z", "GetIsNeedAddressHandler")]
			get {
				const string __id = "isNeedAddress.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOffset;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isOffset' and count(parameter)=0]"
			[Register ("isOffset", "()Z", "GetIsOffsetHandler")]
			get {
				const string __id = "isOffset.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isOnceLocation;
#pragma warning disable 0169
		static Delegate GetIsOnceLocationHandler ()
		{
			if (cb_isOnceLocation == null)
				cb_isOnceLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnceLocation);
			return cb_isOnceLocation;
		}

		static bool n_IsOnceLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnceLocation;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOnceLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isOnceLocation' and count(parameter)=0]"
			[Register ("isOnceLocation", "()Z", "GetIsOnceLocationHandler")]
			get {
				const string __id = "isOnceLocation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isOnceLocationLatest;
#pragma warning disable 0169
		static Delegate GetIsOnceLocationLatestHandler ()
		{
			if (cb_isOnceLocationLatest == null)
				cb_isOnceLocationLatest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnceLocationLatest);
			return cb_isOnceLocationLatest;
		}

		static bool n_IsOnceLocationLatest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnceLocationLatest;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOnceLocationLatest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isOnceLocationLatest' and count(parameter)=0]"
			[Register ("isOnceLocationLatest", "()Z", "GetIsOnceLocationLatestHandler")]
			get {
				const string __id = "isOnceLocationLatest.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isSensorEnable;
#pragma warning disable 0169
		static Delegate GetIsSensorEnableHandler ()
		{
			if (cb_isSensorEnable == null)
				cb_isSensorEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSensorEnable);
			return cb_isSensorEnable;
		}

		static bool n_IsSensorEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSensorEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSensorEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isSensorEnable' and count(parameter)=0]"
			[Register ("isSensorEnable", "()Z", "GetIsSensorEnableHandler")]
			get {
				const string __id = "isSensorEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isWifiActiveScan;
#pragma warning disable 0169
		static Delegate GetIsWifiActiveScanHandler ()
		{
			if (cb_isWifiActiveScan == null)
				cb_isWifiActiveScan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWifiActiveScan);
			return cb_isWifiActiveScan;
		}

		static bool n_IsWifiActiveScan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWifiActiveScan;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool IsWifiActiveScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isWifiActiveScan' and count(parameter)=0]"
			[Register ("isWifiActiveScan", "()Z", "GetIsWifiActiveScanHandler")]
			get {
				const string __id = "isWifiActiveScan.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isWifiScan;
#pragma warning disable 0169
		static Delegate GetIsWifiScanHandler ()
		{
			if (cb_isWifiScan == null)
				cb_isWifiScan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWifiScan);
			return cb_isWifiScan;
		}

		static bool n_IsWifiScan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWifiScan;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWifiScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isWifiScan' and count(parameter)=0]"
			[Register ("isWifiScan", "()Z", "GetIsWifiScanHandler")]
			get {
				const string __id = "isWifiScan.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastLocationLifeCycle;
#pragma warning disable 0169
		static Delegate GetGetLastLocationLifeCycleHandler ()
		{
			if (cb_getLastLocationLifeCycle == null)
				cb_getLastLocationLifeCycle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastLocationLifeCycle);
			return cb_getLastLocationLifeCycle;
		}

		static long n_GetLastLocationLifeCycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastLocationLifeCycle;
		}
#pragma warning restore 0169

		public virtual unsafe long LastLocationLifeCycle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getLastLocationLifeCycle' and count(parameter)=0]"
			[Register ("getLastLocationLifeCycle", "()J", "GetGetLastLocationLifeCycleHandler")]
			get {
				const string __id = "getLastLocationLifeCycle.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocationMode;
#pragma warning disable 0169
		static Delegate GetGetLocationModeHandler ()
		{
			if (cb_getLocationMode == null)
				cb_getLocationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationMode);
			return cb_getLocationMode;
		}

		static IntPtr n_GetLocationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode LocationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getLocationMode' and count(parameter)=0]"
			[Register ("getLocationMode", "()Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;", "GetGetLocationModeHandler")]
			get {
				const string __id = "getLocationMode.()Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol LocationProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getLocationProtocol' and count(parameter)=0]"
			[Register ("getLocationProtocol", "()Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;", "GetGetLocationProtocolHandler")]
			get {
				const string __id = "getLocationProtocol.()Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setLocationProtocol' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption.AMapLocationProtocol']]"
			[Register ("setLocationProtocol", "(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;)V", "GetSetLocationProtocol_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationProtocol_Handler")]
			set {
				const string __id = "setLocationProtocol.(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationProtocol;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationPurpose;
#pragma warning disable 0169
		static Delegate GetGetLocationPurposeHandler ()
		{
			if (cb_getLocationPurpose == null)
				cb_getLocationPurpose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationPurpose);
			return cb_getLocationPurpose;
		}

		static IntPtr n_GetLocationPurpose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationPurpose);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose LocationPurpose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getLocationPurpose' and count(parameter)=0]"
			[Register ("getLocationPurpose", "()Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;", "GetGetLocationPurposeHandler")]
			get {
				const string __id = "getLocationPurpose.()Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool OpenAlwaysScanWifi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='isOpenAlwaysScanWifi' and count(parameter)=0]"
			[Register ("isOpenAlwaysScanWifi", "()Z", "GetIsOpenAlwaysScanWifiHandler")]
			get {
				const string __id = "isOpenAlwaysScanWifi.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setOpenAlwaysScanWifi' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOpenAlwaysScanWifi", "(Z)V", "GetSetOpenAlwaysScanWifi_ZHandler")]
			set {
				const string __id = "setOpenAlwaysScanWifi.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public unsafe long ScanWifiInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getScanWifiInterval' and count(parameter)=0]"
			[Register ("getScanWifiInterval", "()J", "GetGetScanWifiIntervalHandler")]
			get {
				const string __id = "getScanWifiInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setScanWifiInterval' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setScanWifiInterval", "(J)V", "GetSetScanWifiInterval_JHandler")]
			set {
				const string __id = "setScanWifiInterval.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
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
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/amap/api/location/AMapLocationClientOption;", "GetCloneHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption Clone ()
		{
			const string __id = "clone.()Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getGeoLanguage;
#pragma warning disable 0169
		static Delegate GetGetGeoLanguageHandler ()
		{
			if (cb_getGeoLanguage == null)
				cb_getGeoLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoLanguage);
			return cb_getGeoLanguage;
		}

		static IntPtr n_GetGeoLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGeoLanguage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='getGeoLanguage' and count(parameter)=0]"
		[Register ("getGeoLanguage", "()Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;", "GetGetGeoLanguageHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage GetGeoLanguage ()
		{
			const string __id = "getGeoLanguage.()Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDeviceModeDistanceFilter_F;
#pragma warning disable 0169
		static Delegate GetSetDeviceModeDistanceFilter_FHandler ()
		{
			if (cb_setDeviceModeDistanceFilter_F == null)
				cb_setDeviceModeDistanceFilter_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetDeviceModeDistanceFilter_F);
			return cb_setDeviceModeDistanceFilter_F;
		}

		static IntPtr n_SetDeviceModeDistanceFilter_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDeviceModeDistanceFilter (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setDeviceModeDistanceFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDeviceModeDistanceFilter", "(F)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetDeviceModeDistanceFilter_FHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetDeviceModeDistanceFilter (float p0)
		{
			const string __id = "setDeviceModeDistanceFilter.(F)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_;
#pragma warning disable 0169
		static Delegate GetSetGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_Handler ()
		{
			if (cb_setGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_ == null)
				cb_setGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_);
			return cb_setGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_;
		}

		static IntPtr n_SetGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGeoLanguage (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setGeoLanguage' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption.GeoLanguage']]"
		[Register ("setGeoLanguage", "(Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetGeoLanguage_Lcom_amap_api_location_AMapLocationClientOption_GeoLanguage_Handler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetGeoLanguage (global::Com.Amap.Api.Location.AMapLocationClientOption.GeoLanguage p0)
		{
			const string __id = "setGeoLanguage.(Lcom/amap/api/location/AMapLocationClientOption$GeoLanguage;)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setGpsFirst_Z;
#pragma warning disable 0169
		static Delegate GetSetGpsFirst_ZHandler ()
		{
			if (cb_setGpsFirst_Z == null)
				cb_setGpsFirst_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetGpsFirst_Z);
			return cb_setGpsFirst_Z;
		}

		static IntPtr n_SetGpsFirst_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetGpsFirst (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setGpsFirst' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setGpsFirst", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetGpsFirst_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetGpsFirst (bool p0)
		{
			const string __id = "setGpsFirst.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setGpsFirstTimeout_J;
#pragma warning disable 0169
		static Delegate GetSetGpsFirstTimeout_JHandler ()
		{
			if (cb_setGpsFirstTimeout_J == null)
				cb_setGpsFirstTimeout_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetGpsFirstTimeout_J);
			return cb_setGpsFirstTimeout_J;
		}

		static IntPtr n_SetGpsFirstTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetGpsFirstTimeout (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setGpsFirstTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setGpsFirstTimeout", "(J)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetGpsFirstTimeout_JHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetGpsFirstTimeout (long p0)
		{
			const string __id = "setGpsFirstTimeout.(J)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHttpTimeOut_J;
#pragma warning disable 0169
		static Delegate GetSetHttpTimeOut_JHandler ()
		{
			if (cb_setHttpTimeOut_J == null)
				cb_setHttpTimeOut_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetHttpTimeOut_J);
			return cb_setHttpTimeOut_J;
		}

		static IntPtr n_SetHttpTimeOut_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHttpTimeOut (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setHttpTimeOut' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setHttpTimeOut", "(J)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetHttpTimeOut_JHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetHttpTimeOut (long p0)
		{
			const string __id = "setHttpTimeOut.(J)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setInterval_J;
#pragma warning disable 0169
		static Delegate GetSetInterval_JHandler ()
		{
			if (cb_setInterval_J == null)
				cb_setInterval_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetInterval_J);
			return cb_setInterval_J;
		}

		static IntPtr n_SetInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetInterval (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInterval", "(J)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetInterval_JHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetInterval (long p0)
		{
			const string __id = "setInterval.(J)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setKillProcess_Z;
#pragma warning disable 0169
		static Delegate GetSetKillProcess_ZHandler ()
		{
			if (cb_setKillProcess_Z == null)
				cb_setKillProcess_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetKillProcess_Z);
			return cb_setKillProcess_Z;
		}

		static IntPtr n_SetKillProcess_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetKillProcess (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setKillProcess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKillProcess", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetKillProcess_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetKillProcess (bool p0)
		{
			const string __id = "setKillProcess.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLastLocationLifeCycle_J;
#pragma warning disable 0169
		static Delegate GetSetLastLocationLifeCycle_JHandler ()
		{
			if (cb_setLastLocationLifeCycle_J == null)
				cb_setLastLocationLifeCycle_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetLastLocationLifeCycle_J);
			return cb_setLastLocationLifeCycle_J;
		}

		static IntPtr n_SetLastLocationLifeCycle_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLastLocationLifeCycle (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setLastLocationLifeCycle' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLastLocationLifeCycle", "(J)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetLastLocationLifeCycle_JHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetLastLocationLifeCycle (long p0)
		{
			const string __id = "setLastLocationLifeCycle.(J)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationCacheEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetLocationCacheEnable_ZHandler ()
		{
			if (cb_setLocationCacheEnable_Z == null)
				cb_setLocationCacheEnable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetLocationCacheEnable_Z);
			return cb_setLocationCacheEnable_Z;
		}

		static IntPtr n_SetLocationCacheEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLocationCacheEnable (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setLocationCacheEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLocationCacheEnable", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetLocationCacheEnable_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetLocationCacheEnable (bool p0)
		{
			const string __id = "setLocationCacheEnable.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_;
#pragma warning disable 0169
		static Delegate GetSetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_Handler ()
		{
			if (cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_ == null)
				cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_);
			return cb_setLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_;
		}

		static IntPtr n_SetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocationMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setLocationMode' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption.AMapLocationMode']]"
		[Register ("setLocationMode", "(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetLocationMode_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationMode_Handler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetLocationMode (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationMode p0)
		{
			const string __id = "setLocationMode.(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationMode;)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_;
#pragma warning disable 0169
		static Delegate GetSetLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_Handler ()
		{
			if (cb_setLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_ == null)
				cb_setLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_);
			return cb_setLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_;
		}

		static IntPtr n_SetLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocationPurpose (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setLocationPurpose' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.AMapLocationClientOption.AMapLocationPurpose']]"
		[Register ("setLocationPurpose", "(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetLocationPurpose_Lcom_amap_api_location_AMapLocationClientOption_AMapLocationPurpose_Handler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetLocationPurpose (global::Com.Amap.Api.Location.AMapLocationClientOption.AMapLocationPurpose p0)
		{
			const string __id = "setLocationPurpose.(Lcom/amap/api/location/AMapLocationClientOption$AMapLocationPurpose;)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMockEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetMockEnable_ZHandler ()
		{
			if (cb_setMockEnable_Z == null)
				cb_setMockEnable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetMockEnable_Z);
			return cb_setMockEnable_Z;
		}

		static IntPtr n_SetMockEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMockEnable (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setMockEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMockEnable", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetMockEnable_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetMockEnable (bool p0)
		{
			const string __id = "setMockEnable.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNeedAddress_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedAddress_ZHandler ()
		{
			if (cb_setNeedAddress_Z == null)
				cb_setNeedAddress_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetNeedAddress_Z);
			return cb_setNeedAddress_Z;
		}

		static IntPtr n_SetNeedAddress_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNeedAddress (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setNeedAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedAddress", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetNeedAddress_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetNeedAddress (bool p0)
		{
			const string __id = "setNeedAddress.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOffset_Z;
#pragma warning disable 0169
		static Delegate GetSetOffset_ZHandler ()
		{
			if (cb_setOffset_Z == null)
				cb_setOffset_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetOffset_Z);
			return cb_setOffset_Z;
		}

		static IntPtr n_SetOffset_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOffset (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOffset", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetOffset_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetOffset (bool p0)
		{
			const string __id = "setOffset.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnceLocation_Z;
#pragma warning disable 0169
		static Delegate GetSetOnceLocation_ZHandler ()
		{
			if (cb_setOnceLocation_Z == null)
				cb_setOnceLocation_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetOnceLocation_Z);
			return cb_setOnceLocation_Z;
		}

		static IntPtr n_SetOnceLocation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOnceLocation (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setOnceLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOnceLocation", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetOnceLocation_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetOnceLocation (bool p0)
		{
			const string __id = "setOnceLocation.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOnceLocationLatest_Z;
#pragma warning disable 0169
		static Delegate GetSetOnceLocationLatest_ZHandler ()
		{
			if (cb_setOnceLocationLatest_Z == null)
				cb_setOnceLocationLatest_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetOnceLocationLatest_Z);
			return cb_setOnceLocationLatest_Z;
		}

		static IntPtr n_SetOnceLocationLatest_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOnceLocationLatest (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setOnceLocationLatest' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOnceLocationLatest", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetOnceLocationLatest_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetOnceLocationLatest (bool p0)
		{
			const string __id = "setOnceLocationLatest.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSensorEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetSensorEnable_ZHandler ()
		{
			if (cb_setSensorEnable_Z == null)
				cb_setSensorEnable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetSensorEnable_Z);
			return cb_setSensorEnable_Z;
		}

		static IntPtr n_SetSensorEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSensorEnable (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setSensorEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSensorEnable", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetSensorEnable_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetSensorEnable (bool p0)
		{
			const string __id = "setSensorEnable.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setWifiActiveScan_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiActiveScan_ZHandler ()
		{
			if (cb_setWifiActiveScan_Z == null)
				cb_setWifiActiveScan_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWifiActiveScan_Z);
			return cb_setWifiActiveScan_Z;
		}

		static IntPtr n_SetWifiActiveScan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetWifiActiveScan (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setWifiActiveScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setWifiActiveScan", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetWifiActiveScan_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetWifiActiveScan (bool p0)
		{
			const string __id = "setWifiActiveScan.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setWifiScan_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiScan_ZHandler ()
		{
			if (cb_setWifiScan_Z == null)
				cb_setWifiScan_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWifiScan_Z);
			return cb_setWifiScan_Z;
		}

		static IntPtr n_SetWifiScan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetWifiScan (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='setWifiScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWifiScan", "(Z)Lcom/amap/api/location/AMapLocationClientOption;", "GetSetWifiScan_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.AMapLocationClientOption SetWifiScan (bool p0)
		{
			const string __id = "setWifiScan.(Z)Lcom/amap/api/location/AMapLocationClientOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amap.Api.Location.AMapLocationClientOption __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.AMapLocationClientOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='AMapLocationClientOption']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
