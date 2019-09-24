using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/overlay/PoiOverlay", DoNotGenerateAcw=true)]
	public partial class PoiOverlay : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/overlay/PoiOverlay", typeof (PoiOverlay));
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

		protected PoiOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addToMap;
#pragma warning disable 0169
		static Delegate GetAddToMapHandler ()
		{
			if (cb_addToMap == null)
				cb_addToMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddToMap);
			return cb_addToMap;
		}

		static void n_AddToMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddToMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='addToMap' and count(parameter)=0]"
		[Register ("addToMap", "()V", "GetAddToMapHandler")]
		public virtual unsafe void AddToMap ()
		{
			const string __id = "addToMap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBitmapDescriptor_I;
#pragma warning disable 0169
		static Delegate GetGetBitmapDescriptor_IHandler ()
		{
			if (cb_getBitmapDescriptor_I == null)
				cb_getBitmapDescriptor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBitmapDescriptor_I);
			return cb_getBitmapDescriptor_I;
		}

		static IntPtr n_GetBitmapDescriptor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBitmapDescriptor (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='getBitmapDescriptor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBitmapDescriptor", "(I)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "GetGetBitmapDescriptor_IHandler")]
		protected virtual unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor GetBitmapDescriptor (int p0)
		{
			const string __id = "getBitmapDescriptor.(I)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPoiIndex_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
		static Delegate GetGetPoiIndex_Lcom_amap_api_maps2d_model_Marker_Handler ()
		{
			if (cb_getPoiIndex_Lcom_amap_api_maps2d_model_Marker_ == null)
				cb_getPoiIndex_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetPoiIndex_Lcom_amap_api_maps2d_model_Marker_);
			return cb_getPoiIndex_Lcom_amap_api_maps2d_model_Marker_;
		}

		static int n_GetPoiIndex_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPoiIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='getPoiIndex' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
		[Register ("getPoiIndex", "(Lcom/amap/api/maps2d/model/Marker;)I", "GetGetPoiIndex_Lcom_amap_api_maps2d_model_Marker_Handler")]
		public virtual unsafe int GetPoiIndex (global::Com.Amap.Api.Maps2d.Model.Marker p0)
		{
			const string __id = "getPoiIndex.(Lcom/amap/api/maps2d/model/Marker;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getSnippet_I;
#pragma warning disable 0169
		static Delegate GetGetSnippet_IHandler ()
		{
			if (cb_getSnippet_I == null)
				cb_getSnippet_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSnippet_I);
			return cb_getSnippet_I;
		}

		static IntPtr n_GetSnippet_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetSnippet (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='getSnippet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSnippet", "(I)Ljava/lang/String;", "GetGetSnippet_IHandler")]
		protected virtual unsafe string GetSnippet (int p0)
		{
			const string __id = "getSnippet.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTitle_I;
#pragma warning disable 0169
		static Delegate GetGetTitle_IHandler ()
		{
			if (cb_getTitle_I == null)
				cb_getTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTitle_I);
			return cb_getTitle_I;
		}

		static IntPtr n_GetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTitle (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='getTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitle", "(I)Ljava/lang/String;", "GetGetTitle_IHandler")]
		protected virtual unsafe string GetTitle (int p0)
		{
			const string __id = "getTitle.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeFromMap;
#pragma warning disable 0169
		static Delegate GetRemoveFromMapHandler ()
		{
			if (cb_removeFromMap == null)
				cb_removeFromMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveFromMap);
			return cb_removeFromMap;
		}

		static void n_RemoveFromMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFromMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='removeFromMap' and count(parameter)=0]"
		[Register ("removeFromMap", "()V", "GetRemoveFromMapHandler")]
		public virtual unsafe void RemoveFromMap ()
		{
			const string __id = "removeFromMap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomToSpan;
#pragma warning disable 0169
		static Delegate GetZoomToSpanHandler ()
		{
			if (cb_zoomToSpan == null)
				cb_zoomToSpan = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomToSpan);
			return cb_zoomToSpan;
		}

		static void n_ZoomToSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.PoiOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='PoiOverlay']/method[@name='zoomToSpan' and count(parameter)=0]"
		[Register ("zoomToSpan", "()V", "GetZoomToSpanHandler")]
		public virtual unsafe void ZoomToSpan ()
		{
			const string __id = "zoomToSpan.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
