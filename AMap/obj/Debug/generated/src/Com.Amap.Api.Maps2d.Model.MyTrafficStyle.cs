using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/MyTrafficStyle", DoNotGenerateAcw=true)]
	public partial class MyTrafficStyle : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/MyTrafficStyle", typeof (MyTrafficStyle));
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

		protected MyTrafficStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/constructor[@name='MyTrafficStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MyTrafficStyle ()
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

		static Delegate cb_getCongestedColor;
#pragma warning disable 0169
		static Delegate GetGetCongestedColorHandler ()
		{
			if (cb_getCongestedColor == null)
				cb_getCongestedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCongestedColor);
			return cb_getCongestedColor;
		}

		static int n_GetCongestedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CongestedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setCongestedColor_I;
#pragma warning disable 0169
		static Delegate GetSetCongestedColor_IHandler ()
		{
			if (cb_setCongestedColor_I == null)
				cb_setCongestedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCongestedColor_I);
			return cb_setCongestedColor_I;
		}

		static void n_SetCongestedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CongestedColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CongestedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='getCongestedColor' and count(parameter)=0]"
			[Register ("getCongestedColor", "()I", "GetGetCongestedColorHandler")]
			get {
				const string __id = "getCongestedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='setCongestedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCongestedColor", "(I)V", "GetSetCongestedColor_IHandler")]
			set {
				const string __id = "setCongestedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSeriousCongestedColor;
#pragma warning disable 0169
		static Delegate GetGetSeriousCongestedColorHandler ()
		{
			if (cb_getSeriousCongestedColor == null)
				cb_getSeriousCongestedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeriousCongestedColor);
			return cb_getSeriousCongestedColor;
		}

		static int n_GetSeriousCongestedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeriousCongestedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSeriousCongestedColor_I;
#pragma warning disable 0169
		static Delegate GetSetSeriousCongestedColor_IHandler ()
		{
			if (cb_setSeriousCongestedColor_I == null)
				cb_setSeriousCongestedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSeriousCongestedColor_I);
			return cb_setSeriousCongestedColor_I;
		}

		static void n_SetSeriousCongestedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeriousCongestedColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SeriousCongestedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='getSeriousCongestedColor' and count(parameter)=0]"
			[Register ("getSeriousCongestedColor", "()I", "GetGetSeriousCongestedColorHandler")]
			get {
				const string __id = "getSeriousCongestedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='setSeriousCongestedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSeriousCongestedColor", "(I)V", "GetSetSeriousCongestedColor_IHandler")]
			set {
				const string __id = "setSeriousCongestedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSlowColor;
#pragma warning disable 0169
		static Delegate GetGetSlowColorHandler ()
		{
			if (cb_getSlowColor == null)
				cb_getSlowColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSlowColor);
			return cb_getSlowColor;
		}

		static int n_GetSlowColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SlowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSlowColor_I;
#pragma warning disable 0169
		static Delegate GetSetSlowColor_IHandler ()
		{
			if (cb_setSlowColor_I == null)
				cb_setSlowColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSlowColor_I);
			return cb_setSlowColor_I;
		}

		static void n_SetSlowColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlowColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SlowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='getSlowColor' and count(parameter)=0]"
			[Register ("getSlowColor", "()I", "GetGetSlowColorHandler")]
			get {
				const string __id = "getSlowColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='setSlowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSlowColor", "(I)V", "GetSetSlowColor_IHandler")]
			set {
				const string __id = "setSlowColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSmoothColor;
#pragma warning disable 0169
		static Delegate GetGetSmoothColorHandler ()
		{
			if (cb_getSmoothColor == null)
				cb_getSmoothColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSmoothColor);
			return cb_getSmoothColor;
		}

		static int n_GetSmoothColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmoothColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSmoothColor_I;
#pragma warning disable 0169
		static Delegate GetSetSmoothColor_IHandler ()
		{
			if (cb_setSmoothColor_I == null)
				cb_setSmoothColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSmoothColor_I);
			return cb_setSmoothColor_I;
		}

		static void n_SetSmoothColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyTrafficStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SmoothColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='getSmoothColor' and count(parameter)=0]"
			[Register ("getSmoothColor", "()I", "GetGetSmoothColorHandler")]
			get {
				const string __id = "getSmoothColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='MyTrafficStyle']/method[@name='setSmoothColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSmoothColor", "(I)V", "GetSetSmoothColor_IHandler")]
			set {
				const string __id = "setSmoothColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
