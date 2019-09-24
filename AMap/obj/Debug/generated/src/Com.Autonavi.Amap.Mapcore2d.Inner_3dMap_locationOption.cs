using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Autonavi.Amap.Mapcore2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']"
	[global::Android.Runtime.Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationOption", DoNotGenerateAcw=true)]
	public partial class Inner_3dMap_locationOption : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']"
		[global::Android.Runtime.Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode", DoNotGenerateAcw=true)]
		public sealed partial class Inner_3dMap_Enum_LocationMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']/field[@name='Battery_Saving']"
			[Register ("Battery_Saving")]
			public static global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode BatterySaving {
				get {
					const string __id = "Battery_Saving.Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']/field[@name='Device_Sensors']"
			[Register ("Device_Sensors")]
			public static global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode DeviceSensors {
				get {
					const string __id = "Device_Sensors.Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']/field[@name='Hight_Accuracy']"
			[Register ("Hight_Accuracy")]
			public static global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode HightAccuracy {
				get {
					const string __id = "Hight_Accuracy.Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode", typeof (Inner_3dMap_Enum_LocationMode));
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

			internal Inner_3dMap_Enum_LocationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;", "")]
			public static unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;", "")]
			public static unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode[] Values ()
			{
				const string __id = "values.()[Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']"
		[global::Android.Runtime.Register ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol", DoNotGenerateAcw=true)]
		public sealed partial class Inner_3dMap_Enum_LocationProtocol : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']/field[@name='HTTP']"
			[Register ("HTTP")]
			public static global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol Http {
				get {
					const string __id = "HTTP.Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']/field[@name='HTTPS']"
			[Register ("HTTPS")]
			public static global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol Https {
				get {
					const string __id = "HTTPS.Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol", typeof (Inner_3dMap_Enum_LocationProtocol));
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

			internal Inner_3dMap_Enum_LocationProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']/method[@name='getValue' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;", "")]
			public static unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;", "")]
			public static unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol[] Values ()
			{
				const string __id = "values.()[Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/autonavi/amap/mapcore2d/Inner_3dMap_locationOption", typeof (Inner_3dMap_locationOption));
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

		protected Inner_3dMap_locationOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/constructor[@name='Inner_3dMap_locationOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Inner_3dMap_locationOption ()
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

		public static unsafe string APIKEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='getAPIKEY' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpTimeOut;
		}
#pragma warning restore 0169

		static Delegate cb_setHttpTimeOut_J;
#pragma warning disable 0169
		static Delegate GetSetHttpTimeOut_JHandler ()
		{
			if (cb_setHttpTimeOut_J == null)
				cb_setHttpTimeOut_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetHttpTimeOut_J);
			return cb_setHttpTimeOut_J;
		}

		static void n_SetHttpTimeOut_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HttpTimeOut = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long HttpTimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='getHttpTimeOut' and count(parameter)=0]"
			[Register ("getHttpTimeOut", "()J", "GetGetHttpTimeOutHandler")]
			get {
				const string __id = "getHttpTimeOut.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setHttpTimeOut' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setHttpTimeOut", "(J)V", "GetSetHttpTimeOut_JHandler")]
			set {
				const string __id = "setHttpTimeOut.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		public virtual unsafe long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='getInterval' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGpsFirst;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsGpsFirst {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isGpsFirst' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKillProcess;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsKillProcess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isKillProcess' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedAddress;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isNeedAddress' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOffset;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isOffset' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnceLocation;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOnceLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isOnceLocation' and count(parameter)=0]"
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationCacheEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationCacheEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetLocationCacheEnable_ZHandler ()
		{
			if (cb_setLocationCacheEnable_Z == null)
				cb_setLocationCacheEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLocationCacheEnable_Z);
			return cb_setLocationCacheEnable_Z;
		}

		static void n_SetLocationCacheEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationCacheEnable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool LocationCacheEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isLocationCacheEnable' and count(parameter)=0]"
			[Register ("isLocationCacheEnable", "()Z", "GetIsLocationCacheEnableHandler")]
			get {
				const string __id = "isLocationCacheEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setLocationCacheEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocationCacheEnable", "(Z)V", "GetSetLocationCacheEnable_ZHandler")]
			set {
				const string __id = "setLocationCacheEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode LocationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='getLocationMode' and count(parameter)=0]"
			[Register ("getLocationMode", "()Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;", "GetGetLocationModeHandler")]
			get {
				const string __id = "getLocationMode.()Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol LocationProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='getLocationProtocol' and count(parameter)=0]"
			[Register ("getLocationProtocol", "()Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;", "GetGetLocationProtocolHandler")]
			get {
				const string __id = "getLocationProtocol.()Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setLocationProtocol' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationProtocol']]"
			[Register ("setLocationProtocol", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;)V", "GetSetLocationProtocol_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationProtocol_Handler")]
			set {
				const string __id = "setLocationProtocol.(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationProtocol;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MockEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setMockEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetMockEnable_ZHandler ()
		{
			if (cb_setMockEnable_Z == null)
				cb_setMockEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMockEnable_Z);
			return cb_setMockEnable_Z;
		}

		static void n_SetMockEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MockEnable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool MockEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isMockEnable' and count(parameter)=0]"
			[Register ("isMockEnable", "()Z", "GetIsMockEnableHandler")]
			get {
				const string __id = "isMockEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setMockEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMockEnable", "(Z)V", "GetSetMockEnable_ZHandler")]
			set {
				const string __id = "setMockEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnceLocationLatest;
		}
#pragma warning restore 0169

		static Delegate cb_setOnceLocationLatest_Z;
#pragma warning disable 0169
		static Delegate GetSetOnceLocationLatest_ZHandler ()
		{
			if (cb_setOnceLocationLatest_Z == null)
				cb_setOnceLocationLatest_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOnceLocationLatest_Z);
			return cb_setOnceLocationLatest_Z;
		}

		static void n_SetOnceLocationLatest_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnceLocationLatest = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool OnceLocationLatest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isOnceLocationLatest' and count(parameter)=0]"
			[Register ("isOnceLocationLatest", "()Z", "GetIsOnceLocationLatestHandler")]
			get {
				const string __id = "isOnceLocationLatest.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setOnceLocationLatest' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOnceLocationLatest", "(Z)V", "GetSetOnceLocationLatest_ZHandler")]
			set {
				const string __id = "setOnceLocationLatest.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SensorEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setSensorEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetSensorEnable_ZHandler ()
		{
			if (cb_setSensorEnable_Z == null)
				cb_setSensorEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSensorEnable_Z);
			return cb_setSensorEnable_Z;
		}

		static void n_SetSensorEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SensorEnable = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool SensorEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isSensorEnable' and count(parameter)=0]"
			[Register ("isSensorEnable", "()Z", "GetIsSensorEnableHandler")]
			get {
				const string __id = "isSensorEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setSensorEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSensorEnable", "(Z)V", "GetSetSensorEnable_ZHandler")]
			set {
				const string __id = "setSensorEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WifiActiveScan;
		}
#pragma warning restore 0169

		static Delegate cb_setWifiActiveScan_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiActiveScan_ZHandler ()
		{
			if (cb_setWifiActiveScan_Z == null)
				cb_setWifiActiveScan_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWifiActiveScan_Z);
			return cb_setWifiActiveScan_Z;
		}

		static void n_SetWifiActiveScan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WifiActiveScan = p0;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool WifiActiveScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isWifiActiveScan' and count(parameter)=0]"
			[Register ("isWifiActiveScan", "()Z", "GetIsWifiActiveScanHandler")]
			get {
				const string __id = "isWifiActiveScan.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setWifiActiveScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWifiActiveScan", "(Z)V", "GetSetWifiActiveScan_ZHandler")]
			set {
				const string __id = "setWifiActiveScan.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WifiScan;
		}
#pragma warning restore 0169

		static Delegate cb_setWifiScan_Z;
#pragma warning disable 0169
		static Delegate GetSetWifiScan_ZHandler ()
		{
			if (cb_setWifiScan_Z == null)
				cb_setWifiScan_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWifiScan_Z);
			return cb_setWifiScan_Z;
		}

		static void n_SetWifiScan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WifiScan = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool WifiScan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='isWifiScan' and count(parameter)=0]"
			[Register ("isWifiScan", "()Z", "GetIsWifiScanHandler")]
			get {
				const string __id = "isWifiScan.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setWifiScan' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWifiScan", "(Z)V", "GetSetWifiScan_ZHandler")]
			set {
				const string __id = "setWifiScan.(Z)V";
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetCloneHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption Clone ()
		{
			const string __id = "clone.()Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetGpsFirst (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setGpsFirst' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setGpsFirst", "(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetGpsFirst_ZHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetGpsFirst (bool p0)
		{
			const string __id = "setGpsFirst.(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetInterval (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInterval", "(J)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetInterval_JHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetInterval (long p0)
		{
			const string __id = "setInterval.(J)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetKillProcess (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setKillProcess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKillProcess", "(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetKillProcess_ZHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetKillProcess (bool p0)
		{
			const string __id = "setKillProcess.(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_;
#pragma warning disable 0169
		static Delegate GetSetLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_Handler ()
		{
			if (cb_setLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_ == null)
				cb_setLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_);
			return cb_setLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_;
		}

		static IntPtr n_SetLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode p0 = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocationMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setLocationMode' and count(parameter)=1 and parameter[1][@type='com.autonavi.amap.mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode']]"
		[Register ("setLocationMode", "(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetLocationMode_Lcom_autonavi_amap_mapcore2d_Inner_3dMap_locationOption_Inner_3dMap_Enum_LocationMode_Handler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetLocationMode (global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption.Inner_3dMap_Enum_LocationMode p0)
		{
			const string __id = "setLocationMode.(Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption$Inner_3dMap_Enum_LocationMode;)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNeedAddress (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setNeedAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedAddress", "(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetNeedAddress_ZHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetNeedAddress (bool p0)
		{
			const string __id = "setNeedAddress.(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOffset (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOffset", "(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetOffset_ZHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetOffset (bool p0)
		{
			const string __id = "setOffset.(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption __this = global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOnceLocation (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.autonavi.amap.mapcore2d']/class[@name='Inner_3dMap_locationOption']/method[@name='setOnceLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOnceLocation", "(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;", "GetSetOnceLocation_ZHandler")]
		public virtual unsafe global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption SetOnceLocation (bool p0)
		{
			const string __id = "setOnceLocation.(Z)Lcom/autonavi/amap/mapcore2d/Inner_3dMap_locationOption;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Autonavi.Amap.Mapcore2d.Inner_3dMap_locationOption> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
