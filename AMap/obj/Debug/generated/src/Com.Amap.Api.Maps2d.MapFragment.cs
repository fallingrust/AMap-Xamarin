using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='MapFragment']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/MapFragment", DoNotGenerateAcw=true)]
	public partial class MapFragment : global::Android.App.Fragment {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/MapFragment", typeof (MapFragment));
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

		protected MapFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='MapFragment']/constructor[@name='MapFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapFragment ()
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

		static Delegate cb_getMap;
#pragma warning disable 0169
		static Delegate GetGetMapHandler ()
		{
			if (cb_getMap == null)
				cb_getMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap);
			return cb_getMap;
		}

		static IntPtr n_GetMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.MapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.MapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.AMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='MapFragment']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/amap/api/maps2d/AMap;", "GetGetMapHandler")]
			get {
				const string __id = "getMap.()Lcom/amap/api/maps2d/AMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapFragmentDelegate;
#pragma warning disable 0169
		static Delegate GetGetMapFragmentDelegateHandler ()
		{
			if (cb_getMapFragmentDelegate == null)
				cb_getMapFragmentDelegate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapFragmentDelegate);
			return cb_getMapFragmentDelegate;
		}

		static IntPtr n_GetMapFragmentDelegate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.MapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.MapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapFragmentDelegate);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Amap.Api.Interfaces.IMapFragmentDelegate MapFragmentDelegate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='MapFragment']/method[@name='getMapFragmentDelegate' and count(parameter)=0]"
			[Register ("getMapFragmentDelegate", "()Lcom/amap/api/interfaces/IMapFragmentDelegate;", "GetGetMapFragmentDelegateHandler")]
			get {
				const string __id = "getMapFragmentDelegate.()Lcom/amap/api/interfaces/IMapFragmentDelegate;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IMapFragmentDelegate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='MapFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/amap/api/maps2d/MapFragment;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.MapFragment NewInstance ()
		{
			const string __id = "newInstance.()Lcom/amap/api/maps2d/MapFragment;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.MapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='MapFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMapOptions']]"
		[Register ("newInstance", "(Lcom/amap/api/maps2d/AMapOptions;)Lcom/amap/api/maps2d/MapFragment;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.MapFragment NewInstance (global::Com.Amap.Api.Maps2d.AMapOptions p0)
		{
			const string __id = "newInstance.(Lcom/amap/api/maps2d/AMapOptions;)Lcom/amap/api/maps2d/MapFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.MapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
