using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdate']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/CameraUpdate", DoNotGenerateAcw=true)]
	public sealed partial class CameraUpdate : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/CameraUpdate", typeof (CameraUpdate));
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

		internal CameraUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdate']/constructor[@name='CameraUpdate' and count(parameter)=1 and parameter[1][@type='com.amap.api.interfaces.MapCameraMessage']]"
		[Register (".ctor", "(Lcom/amap/api/interfaces/MapCameraMessage;)V", "")]
		public unsafe CameraUpdate (global::Com.Amap.Api.Interfaces.MapCameraMessage p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/amap/api/interfaces/MapCameraMessage;)V";

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

		public unsafe global::Com.Amap.Api.Interfaces.MapCameraMessage CameraUpdateFactoryDelegate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdate']/method[@name='getCameraUpdateFactoryDelegate' and count(parameter)=0]"
			[Register ("getCameraUpdateFactoryDelegate", "()Lcom/amap/api/interfaces/MapCameraMessage;", "GetGetCameraUpdateFactoryDelegateHandler")]
			get {
				const string __id = "getCameraUpdateFactoryDelegate.()Lcom/amap/api/interfaces/MapCameraMessage;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
