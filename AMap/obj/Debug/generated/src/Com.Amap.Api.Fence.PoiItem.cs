using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Fence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']"
	[global::Android.Runtime.Register ("com/amap/api/fence/PoiItem", DoNotGenerateAcw=true)]
	public partial class PoiItem : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/fence/PoiItem", typeof (PoiItem));
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

		protected PoiItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/constructor[@name='PoiItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PoiItem ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/constructor[@name='PoiItem' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe PoiItem (global::Android.OS.Parcel p0)
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getAdname;
#pragma warning disable 0169
		static Delegate GetGetAdnameHandler ()
		{
			if (cb_getAdname == null)
				cb_getAdname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdname);
			return cb_getAdname;
		}

		static IntPtr n_GetAdname (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Adname);
		}
#pragma warning restore 0169

		static Delegate cb_setAdname_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdname_Ljava_lang_String_Handler ()
		{
			if (cb_setAdname_Ljava_lang_String_ == null)
				cb_setAdname_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdname_Ljava_lang_String_);
			return cb_setAdname_Ljava_lang_String_;
		}

		static void n_SetAdname_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Adname = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Adname {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getAdname' and count(parameter)=0]"
			[Register ("getAdname", "()Ljava/lang/String;", "GetGetAdnameHandler")]
			get {
				const string __id = "getAdname.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setAdname' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdname", "(Ljava/lang/String;)V", "GetSetAdname_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAdname.(Ljava/lang/String;)V";
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.City = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler")]
			get {
				const string __id = "getCity.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		public static unsafe global::Android.OS.IParcelableCreator Creator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getCreator' and count(parameter)=0]"
			[Register ("getCreator", "()Landroid/os/Parcelable$Creator;", "GetGetCreatorHandler")]
			get {
				const string __id = "getCreator.()Landroid/os/Parcelable$Creator;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static void n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				const string __id = "setLatitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongitude_DHandler ()
		{
			if (cb_setLongitude_D == null)
				cb_setLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitude_D);
			return cb_setLongitude_D;
		}

		static void n_SetLongitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				const string __id = "getLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler")]
			set {
				const string __id = "setLongitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPoiId;
#pragma warning disable 0169
		static Delegate GetGetPoiIdHandler ()
		{
			if (cb_getPoiId == null)
				cb_getPoiId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiId);
			return cb_getPoiId;
		}

		static IntPtr n_GetPoiId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PoiId);
		}
#pragma warning restore 0169

		static Delegate cb_setPoiId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPoiId_Ljava_lang_String_Handler ()
		{
			if (cb_setPoiId_Ljava_lang_String_ == null)
				cb_setPoiId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoiId_Ljava_lang_String_);
			return cb_setPoiId_Ljava_lang_String_;
		}

		static void n_SetPoiId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoiId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PoiId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getPoiId' and count(parameter)=0]"
			[Register ("getPoiId", "()Ljava/lang/String;", "GetGetPoiIdHandler")]
			get {
				const string __id = "getPoiId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setPoiId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPoiId", "(Ljava/lang/String;)V", "GetSetPoiId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPoiId.(Ljava/lang/String;)V";
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoiName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PoiName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getPoiName' and count(parameter)=0]"
			[Register ("getPoiName", "()Ljava/lang/String;", "GetGetPoiNameHandler")]
			get {
				const string __id = "getPoiName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setPoiName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPoiType;
#pragma warning disable 0169
		static Delegate GetGetPoiTypeHandler ()
		{
			if (cb_getPoiType == null)
				cb_getPoiType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoiType);
			return cb_getPoiType;
		}

		static IntPtr n_GetPoiType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PoiType);
		}
#pragma warning restore 0169

		static Delegate cb_setPoiType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPoiType_Ljava_lang_String_Handler ()
		{
			if (cb_setPoiType_Ljava_lang_String_ == null)
				cb_setPoiType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoiType_Ljava_lang_String_);
			return cb_setPoiType_Ljava_lang_String_;
		}

		static void n_SetPoiType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PoiType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string PoiType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getPoiType' and count(parameter)=0]"
			[Register ("getPoiType", "()Ljava/lang/String;", "GetGetPoiTypeHandler")]
			get {
				const string __id = "getPoiType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setPoiType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPoiType", "(Ljava/lang/String;)V", "GetSetPoiType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPoiType.(Ljava/lang/String;)V";
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Province = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler")]
			get {
				const string __id = "getProvince.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setProvince' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTel;
#pragma warning disable 0169
		static Delegate GetGetTelHandler ()
		{
			if (cb_getTel == null)
				cb_getTel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTel);
			return cb_getTel;
		}

		static IntPtr n_GetTel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tel);
		}
#pragma warning restore 0169

		static Delegate cb_setTel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTel_Ljava_lang_String_Handler ()
		{
			if (cb_setTel_Ljava_lang_String_ == null)
				cb_setTel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTel_Ljava_lang_String_);
			return cb_setTel_Ljava_lang_String_;
		}

		static void n_SetTel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Tel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getTel' and count(parameter)=0]"
			[Register ("getTel", "()Ljava/lang/String;", "GetGetTelHandler")]
			get {
				const string __id = "getTel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setTel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTel", "(Ljava/lang/String;)V", "GetSetTel_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTel.(Ljava/lang/String;)V";
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

		static Delegate cb_getTypeCode;
#pragma warning disable 0169
		static Delegate GetGetTypeCodeHandler ()
		{
			if (cb_getTypeCode == null)
				cb_getTypeCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeCode);
			return cb_getTypeCode;
		}

		static IntPtr n_GetTypeCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TypeCode);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTypeCode_Ljava_lang_String_Handler ()
		{
			if (cb_setTypeCode_Ljava_lang_String_ == null)
				cb_setTypeCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTypeCode_Ljava_lang_String_);
			return cb_setTypeCode_Ljava_lang_String_;
		}

		static void n_SetTypeCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TypeCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TypeCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='getTypeCode' and count(parameter)=0]"
			[Register ("getTypeCode", "()Ljava/lang/String;", "GetGetTypeCodeHandler")]
			get {
				const string __id = "getTypeCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='setTypeCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTypeCode", "(Ljava/lang/String;)V", "GetSetTypeCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTypeCode.(Ljava/lang/String;)V";
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Amap.Api.Fence.PoiItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.PoiItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='PoiItem']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
