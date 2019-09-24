using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Fence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']"
	[global::Android.Runtime.Register ("com/amap/api/fence/DistrictItem", DoNotGenerateAcw=true)]
	public partial class DistrictItem : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/fence/DistrictItem", typeof (DistrictItem));
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

		protected DistrictItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/constructor[@name='DistrictItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DistrictItem ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/constructor[@name='DistrictItem' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe DistrictItem (global::Android.OS.Parcel p0)
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

		static Delegate cb_getAdcode;
#pragma warning disable 0169
		static Delegate GetGetAdcodeHandler ()
		{
			if (cb_getAdcode == null)
				cb_getAdcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdcode);
			return cb_getAdcode;
		}

		static IntPtr n_GetAdcode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Adcode);
		}
#pragma warning restore 0169

		static Delegate cb_setAdcode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdcode_Ljava_lang_String_Handler ()
		{
			if (cb_setAdcode_Ljava_lang_String_ == null)
				cb_setAdcode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdcode_Ljava_lang_String_);
			return cb_setAdcode_Ljava_lang_String_;
		}

		static void n_SetAdcode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Adcode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Adcode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='getAdcode' and count(parameter)=0]"
			[Register ("getAdcode", "()Ljava/lang/String;", "GetGetAdcodeHandler")]
			get {
				const string __id = "getAdcode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='setAdcode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdcode", "(Ljava/lang/String;)V", "GetSetAdcode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAdcode.(Ljava/lang/String;)V";
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

		static Delegate cb_getCitycode;
#pragma warning disable 0169
		static Delegate GetGetCitycodeHandler ()
		{
			if (cb_getCitycode == null)
				cb_getCitycode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCitycode);
			return cb_getCitycode;
		}

		static IntPtr n_GetCitycode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Citycode);
		}
#pragma warning restore 0169

		static Delegate cb_setCitycode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCitycode_Ljava_lang_String_Handler ()
		{
			if (cb_setCitycode_Ljava_lang_String_ == null)
				cb_setCitycode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCitycode_Ljava_lang_String_);
			return cb_setCitycode_Ljava_lang_String_;
		}

		static void n_SetCitycode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Citycode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Citycode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='getCitycode' and count(parameter)=0]"
			[Register ("getCitycode", "()Ljava/lang/String;", "GetGetCitycodeHandler")]
			get {
				const string __id = "getCitycode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='setCitycode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCitycode", "(Ljava/lang/String;)V", "GetSetCitycode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCitycode.(Ljava/lang/String;)V";
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='getCreator' and count(parameter)=0]"
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

		static Delegate cb_getDistrictName;
#pragma warning disable 0169
		static Delegate GetGetDistrictNameHandler ()
		{
			if (cb_getDistrictName == null)
				cb_getDistrictName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistrictName);
			return cb_getDistrictName;
		}

		static IntPtr n_GetDistrictName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DistrictName);
		}
#pragma warning restore 0169

		static Delegate cb_setDistrictName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDistrictName_Ljava_lang_String_Handler ()
		{
			if (cb_setDistrictName_Ljava_lang_String_ == null)
				cb_setDistrictName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDistrictName_Ljava_lang_String_);
			return cb_setDistrictName_Ljava_lang_String_;
		}

		static void n_SetDistrictName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DistrictName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DistrictName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='getDistrictName' and count(parameter)=0]"
			[Register ("getDistrictName", "()Ljava/lang/String;", "GetGetDistrictNameHandler")]
			get {
				const string __id = "getDistrictName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='setDistrictName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDistrictName", "(Ljava/lang/String;)V", "GetSetDistrictName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDistrictName.(Ljava/lang/String;)V";
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

		static Delegate cb_getPolyline;
#pragma warning disable 0169
		static Delegate GetGetPolylineHandler ()
		{
			if (cb_getPolyline == null)
				cb_getPolyline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolyline);
			return cb_getPolyline;
		}

		static IntPtr n_GetPolyline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.ToLocalJniHandle (__this.Polyline);
		}
#pragma warning restore 0169

		static Delegate cb_setPolyline_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPolyline_Ljava_util_List_Handler ()
		{
			if (cb_setPolyline_Ljava_util_List_ == null)
				cb_setPolyline_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPolyline_Ljava_util_List_);
			return cb_setPolyline_Ljava_util_List_;
		}

		static void n_SetPolyline_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Polyline = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint> Polyline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='getPolyline' and count(parameter)=0]"
			[Register ("getPolyline", "()Ljava/util/List;", "GetGetPolylineHandler")]
			get {
				const string __id = "getPolyline.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='setPolyline' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amap.api.location.DPoint&gt;']]"
			[Register ("setPolyline", "(Ljava/util/List;)V", "GetSetPolyline_Ljava_util_List_Handler")]
			set {
				const string __id = "setPolyline.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.ToLocalJniHandle (value);
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
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Amap.Api.Fence.DistrictItem __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.DistrictItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='DistrictItem']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
