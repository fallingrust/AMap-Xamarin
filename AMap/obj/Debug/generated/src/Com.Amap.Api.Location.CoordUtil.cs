using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordUtil']"
	[global::Android.Runtime.Register ("com/amap/api/location/CoordUtil", DoNotGenerateAcw=true)]
	public partial class CoordUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/CoordUtil", typeof (CoordUtil));
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

		protected CoordUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordUtil']/constructor[@name='CoordUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordUtil ()
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

		public static unsafe bool LoadedSo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordUtil']/method[@name='isLoadedSo' and count(parameter)=0]"
			[Register ("isLoadedSo", "()Z", "GetIsLoadedSoHandler")]
			get {
				const string __id = "isLoadedSo.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordUtil']/method[@name='setLoadedSo' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLoadedSo", "(Z)V", "GetSetLoadedSo_ZHandler")]
			set {
				const string __id = "setLoadedSo.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordUtil']/method[@name='convertToGcj' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("convertToGcj", "([D[D)I", "")]
		public static unsafe int ConvertToGcj (double[] p0, double[] p1)
		{
			const string __id = "convertToGcj.([D[D)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
