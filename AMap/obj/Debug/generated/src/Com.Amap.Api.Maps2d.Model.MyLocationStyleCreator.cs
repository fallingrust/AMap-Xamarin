using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyleCreator']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/MyLocationStyleCreator", DoNotGenerateAcw=true)]
	public partial class MyLocationStyleCreator : global::Java.Lang.Object, global::Android.OS.IParcelableCreator {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/MyLocationStyleCreator", typeof (MyLocationStyleCreator));
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

		protected MyLocationStyleCreator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyleCreator']/constructor[@name='MyLocationStyleCreator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MyLocationStyleCreator ()
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

		static Delegate cb_createFromParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetCreateFromParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_createFromParcel_Landroid_os_Parcel_ == null)
				cb_createFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateFromParcel_Landroid_os_Parcel_);
			return cb_createFromParcel_Landroid_os_Parcel_;
		}

		static IntPtr n_CreateFromParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyleCreator __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyleCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFromParcel (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyleCreator']/method[@name='createFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createFromParcel", "(Landroid/os/Parcel;)Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetCreateFromParcel_Landroid_os_Parcel_Handler")]
		public virtual unsafe global::Java.Lang.Object CreateFromParcel (global::Android.OS.Parcel p0)
		{
			const string __id = "createFromParcel.(Landroid/os/Parcel;)Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newArray_I;
#pragma warning disable 0169
		static Delegate GetNewArray_IHandler ()
		{
			if (cb_newArray_I == null)
				cb_newArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NewArray_I);
			return cb_newArray_I;
		}

		static IntPtr n_NewArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyleCreator __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyleCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.NewArray (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyLocationStyleCreator']/method[@name='newArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newArray", "(I)[Lcom/amap/api/maps2d/model/MyLocationStyle;", "GetNewArray_IHandler")]
		public virtual unsafe global::Java.Lang.Object[] NewArray (int p0)
		{
			const string __id = "newArray.(I)[Lcom/amap/api/maps2d/model/MyLocationStyle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Com.Amap.Api.Maps2d.Model.MyLocationStyle[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Maps2d.Model.MyLocationStyle));
			} finally {
			}
		}

	}
}
