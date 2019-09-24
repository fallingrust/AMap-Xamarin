using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/overlay/BusLineOverlay", DoNotGenerateAcw=true)]
	public partial class BusLineOverlay : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/overlay/BusLineOverlay", typeof (BusLineOverlay));
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

		protected BusLineOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBusBitmapDescriptor;
#pragma warning disable 0169
		static Delegate GetGetBusBitmapDescriptorHandler ()
		{
			if (cb_getBusBitmapDescriptor == null)
				cb_getBusBitmapDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBusBitmapDescriptor);
			return cb_getBusBitmapDescriptor;
		}

		static IntPtr n_GetBusBitmapDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BusBitmapDescriptor);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor BusBitmapDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getBusBitmapDescriptor' and count(parameter)=0]"
			[Register ("getBusBitmapDescriptor", "()Lcom/amap/api/maps2d/model/BitmapDescriptor;", "GetGetBusBitmapDescriptorHandler")]
			get {
				const string __id = "getBusBitmapDescriptor.()Lcom/amap/api/maps2d/model/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBusColor;
#pragma warning disable 0169
		static Delegate GetGetBusColorHandler ()
		{
			if (cb_getBusColor == null)
				cb_getBusColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBusColor);
			return cb_getBusColor;
		}

		static int n_GetBusColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BusColor;
		}
#pragma warning restore 0169

		protected virtual unsafe int BusColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getBusColor' and count(parameter)=0]"
			[Register ("getBusColor", "()I", "GetGetBusColorHandler")]
			get {
				const string __id = "getBusColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBuslineWidth;
#pragma warning disable 0169
		static Delegate GetGetBuslineWidthHandler ()
		{
			if (cb_getBuslineWidth == null)
				cb_getBuslineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBuslineWidth);
			return cb_getBuslineWidth;
		}

		static float n_GetBuslineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BuslineWidth;
		}
#pragma warning restore 0169

		protected virtual unsafe float BuslineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getBuslineWidth' and count(parameter)=0]"
			[Register ("getBuslineWidth", "()F", "GetGetBuslineWidthHandler")]
			get {
				const string __id = "getBuslineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getEndBitmapDescriptor;
#pragma warning disable 0169
		static Delegate GetGetEndBitmapDescriptorHandler ()
		{
			if (cb_getEndBitmapDescriptor == null)
				cb_getEndBitmapDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndBitmapDescriptor);
			return cb_getEndBitmapDescriptor;
		}

		static IntPtr n_GetEndBitmapDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndBitmapDescriptor);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor EndBitmapDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getEndBitmapDescriptor' and count(parameter)=0]"
			[Register ("getEndBitmapDescriptor", "()Lcom/amap/api/maps2d/model/BitmapDescriptor;", "GetGetEndBitmapDescriptorHandler")]
			get {
				const string __id = "getEndBitmapDescriptor.()Lcom/amap/api/maps2d/model/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartBitmapDescriptor;
#pragma warning disable 0169
		static Delegate GetGetStartBitmapDescriptorHandler ()
		{
			if (cb_getStartBitmapDescriptor == null)
				cb_getStartBitmapDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartBitmapDescriptor);
			return cb_getStartBitmapDescriptor;
		}

		static IntPtr n_GetStartBitmapDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartBitmapDescriptor);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor StartBitmapDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getStartBitmapDescriptor' and count(parameter)=0]"
			[Register ("getStartBitmapDescriptor", "()Lcom/amap/api/maps2d/model/BitmapDescriptor;", "GetGetStartBitmapDescriptorHandler")]
			get {
				const string __id = "getStartBitmapDescriptor.()Lcom/amap/api/maps2d/model/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddToMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='addToMap' and count(parameter)=0]"
		[Register ("addToMap", "()V", "GetAddToMapHandler")]
		public virtual unsafe void AddToMap ()
		{
			const string __id = "addToMap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBusStationIndex_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
		static Delegate GetGetBusStationIndex_Lcom_amap_api_maps2d_model_Marker_Handler ()
		{
			if (cb_getBusStationIndex_Lcom_amap_api_maps2d_model_Marker_ == null)
				cb_getBusStationIndex_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetBusStationIndex_Lcom_amap_api_maps2d_model_Marker_);
			return cb_getBusStationIndex_Lcom_amap_api_maps2d_model_Marker_;
		}

		static int n_GetBusStationIndex_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetBusStationIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getBusStationIndex' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
		[Register ("getBusStationIndex", "(Lcom/amap/api/maps2d/model/Marker;)I", "GetGetBusStationIndex_Lcom_amap_api_maps2d_model_Marker_Handler")]
		public virtual unsafe int GetBusStationIndex (global::Com.Amap.Api.Maps2d.Model.Marker p0)
		{
			const string __id = "getBusStationIndex.(Lcom/amap/api/maps2d/model/Marker;)I";
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
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetSnippet (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getSnippet' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTitle (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='getTitle' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFromMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='removeFromMap' and count(parameter)=0]"
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
			global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Overlay.BusLineOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.overlay']/class[@name='BusLineOverlay']/method[@name='zoomToSpan' and count(parameter)=0]"
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
