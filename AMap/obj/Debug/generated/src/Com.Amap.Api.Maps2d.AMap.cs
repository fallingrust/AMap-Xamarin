using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap", DoNotGenerateAcw=true)]
	public sealed partial class AMap : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/field[@name='CHINESE']"
		[Register ("CHINESE")]
		public const string Chinese = (string) "zh_cn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/field[@name='ENGLISH']"
		[Register ("ENGLISH")]
		public const string English = (string) "en";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/field[@name='MAP_TYPE_NORMAL']"
		[Register ("MAP_TYPE_NORMAL")]
		public const int MapTypeNormal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/field[@name='MAP_TYPE_SATELLITE']"
		[Register ("MAP_TYPE_SATELLITE")]
		public const int MapTypeSatellite = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.CancelableCallback']"
		[Register ("com/amap/api/maps2d/AMap$CancelableCallback", "", "Com.Amap.Api.Maps2d.AMap/ICancelableCallbackInvoker")]
		public partial interface ICancelableCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.CancelableCallback']/method[@name='onCancel' and count(parameter)=0]"
			[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Amap.Api.Maps2d.AMap/ICancelableCallbackInvoker, AMap")]
			void OnCancel ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.CancelableCallback']/method[@name='onFinish' and count(parameter)=0]"
			[Register ("onFinish", "()V", "GetOnFinishHandler:Com.Amap.Api.Maps2d.AMap/ICancelableCallbackInvoker, AMap")]
			void OnFinish ();

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$CancelableCallback", DoNotGenerateAcw=true)]
		internal class ICancelableCallbackInvoker : global::Java.Lang.Object, ICancelableCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$CancelableCallback", typeof (ICancelableCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICancelableCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICancelableCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.CancelableCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICancelableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCancel;
#pragma warning disable 0169
			static Delegate GetOnCancelHandler ()
			{
				if (cb_onCancel == null)
					cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
				return cb_onCancel;
			}

			static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCancel ();
			}
#pragma warning restore 0169

			IntPtr id_onCancel;
			public unsafe void OnCancel ()
			{
				if (id_onCancel == IntPtr.Zero)
					id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
			}

			static Delegate cb_onFinish;
#pragma warning disable 0169
			static Delegate GetOnFinishHandler ()
			{
				if (cb_onFinish == null)
					cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
				return cb_onFinish;
			}

			static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinish ();
			}
#pragma warning restore 0169

			IntPtr id_onFinish;
			public unsafe void OnFinish ()
			{
				if (id_onFinish == IntPtr.Zero)
					id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinish);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.InfoWindowAdapter']"
		[Register ("com/amap/api/maps2d/AMap$InfoWindowAdapter", "", "Com.Amap.Api.Maps2d.AMap/IInfoWindowAdapterInvoker")]
		public partial interface IInfoWindowAdapter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.InfoWindowAdapter']/method[@name='getInfoContents' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("getInfoContents", "(Lcom/amap/api/maps2d/model/Marker;)Landroid/view/View;", "GetGetInfoContents_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IInfoWindowAdapterInvoker, AMap")]
			global::Android.Views.View GetInfoContents (global::Com.Amap.Api.Maps2d.Model.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.InfoWindowAdapter']/method[@name='getInfoWindow' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("getInfoWindow", "(Lcom/amap/api/maps2d/model/Marker;)Landroid/view/View;", "GetGetInfoWindow_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IInfoWindowAdapterInvoker, AMap")]
			global::Android.Views.View GetInfoWindow (global::Com.Amap.Api.Maps2d.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$InfoWindowAdapter", DoNotGenerateAcw=true)]
		internal class IInfoWindowAdapterInvoker : global::Java.Lang.Object, IInfoWindowAdapter {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$InfoWindowAdapter", typeof (IInfoWindowAdapterInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IInfoWindowAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInfoWindowAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.InfoWindowAdapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInfoWindowAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getInfoContents_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetGetInfoContents_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_getInfoContents_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_getInfoContents_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInfoContents_Lcom_amap_api_maps2d_model_Marker_);
				return cb_getInfoContents_Lcom_amap_api_maps2d_model_Marker_;
			}

			static IntPtr n_GetInfoContents_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInfoContents (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getInfoContents_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe global::Android.Views.View GetInfoContents (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_getInfoContents_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_getInfoContents_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "getInfoContents", "(Lcom/amap/api/maps2d/model/Marker;)Landroid/view/View;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoContents_Lcom_amap_api_maps2d_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetGetInfoWindow_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInfoWindow_Lcom_amap_api_maps2d_model_Marker_);
				return cb_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_;
			}

			static IntPtr n_GetInfoWindow_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInfoWindow (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe global::Android.Views.View GetInfoWindow (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "getInfoWindow", "(Lcom/amap/api/maps2d/model/Marker;)Landroid/view/View;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoWindow_Lcom_amap_api_maps2d_model_Marker_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnCacheRemoveListener']"
		[Register ("com/amap/api/maps2d/AMap$OnCacheRemoveListener", "", "Com.Amap.Api.Maps2d.AMap/IOnCacheRemoveListenerInvoker")]
		public partial interface IOnCacheRemoveListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnCacheRemoveListener']/method[@name='onRemoveCacheFinish' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onRemoveCacheFinish", "(Z)V", "GetOnRemoveCacheFinish_ZHandler:Com.Amap.Api.Maps2d.AMap/IOnCacheRemoveListenerInvoker, AMap")]
			void OnRemoveCacheFinish (bool p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnCacheRemoveListener", DoNotGenerateAcw=true)]
		internal class IOnCacheRemoveListenerInvoker : global::Java.Lang.Object, IOnCacheRemoveListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnCacheRemoveListener", typeof (IOnCacheRemoveListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnCacheRemoveListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCacheRemoveListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnCacheRemoveListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCacheRemoveListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRemoveCacheFinish_Z;
#pragma warning disable 0169
			static Delegate GetOnRemoveCacheFinish_ZHandler ()
			{
				if (cb_onRemoveCacheFinish_Z == null)
					cb_onRemoveCacheFinish_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnRemoveCacheFinish_Z);
				return cb_onRemoveCacheFinish_Z;
			}

			static void n_OnRemoveCacheFinish_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoveCacheFinish (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRemoveCacheFinish_Z;
			public unsafe void OnRemoveCacheFinish (bool p0)
			{
				if (id_onRemoveCacheFinish_Z == IntPtr.Zero)
					id_onRemoveCacheFinish_Z = JNIEnv.GetMethodID (class_ref, "onRemoveCacheFinish", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoveCacheFinish_Z, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnCacheRemoveListener.onRemoveCacheFinish
		public partial class CacheRemoveEventArgs : global::System.EventArgs {

			public CacheRemoveEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnCacheRemoveListenerImplementor")]
		internal sealed partial class IOnCacheRemoveListenerImplementor : global::Java.Lang.Object, IOnCacheRemoveListener {

			object sender;

			public IOnCacheRemoveListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnCacheRemoveListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CacheRemoveEventArgs> Handler;
#pragma warning restore 0649

			public void OnRemoveCacheFinish (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CacheRemoveEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCacheRemoveListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnCameraChangeListener']"
		[Register ("com/amap/api/maps2d/AMap$OnCameraChangeListener", "", "Com.Amap.Api.Maps2d.AMap/IOnCameraChangeListenerInvoker")]
		public partial interface IOnCameraChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnCameraChangeListener']/method[@name='onCameraChange' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CameraPosition']]"
			[Register ("onCameraChange", "(Lcom/amap/api/maps2d/model/CameraPosition;)V", "GetOnCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_Handler:Com.Amap.Api.Maps2d.AMap/IOnCameraChangeListenerInvoker, AMap")]
			void OnCameraChange (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnCameraChangeListener']/method[@name='onCameraChangeFinish' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CameraPosition']]"
			[Register ("onCameraChangeFinish", "(Lcom/amap/api/maps2d/model/CameraPosition;)V", "GetOnCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_Handler:Com.Amap.Api.Maps2d.AMap/IOnCameraChangeListenerInvoker, AMap")]
			void OnCameraChangeFinish (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnCameraChangeListener", DoNotGenerateAcw=true)]
		internal class IOnCameraChangeListenerInvoker : global::Java.Lang.Object, IOnCameraChangeListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnCameraChangeListener", typeof (IOnCameraChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnCameraChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCameraChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnCameraChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCameraChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_;
#pragma warning disable 0169
			static Delegate GetOnCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_Handler ()
			{
				if (cb_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_ == null)
					cb_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_);
				return cb_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_;
			}

			static void n_OnCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_;
			public unsafe void OnCameraChange (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
			{
				if (id_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_ == IntPtr.Zero)
					id_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "onCameraChange", "(Lcom/amap/api/maps2d/model/CameraPosition;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraChange_Lcom_amap_api_maps2d_model_CameraPosition_, __args);
			}

			static Delegate cb_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_;
#pragma warning disable 0169
			static Delegate GetOnCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_Handler ()
			{
				if (cb_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_ == null)
					cb_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_);
				return cb_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_;
			}

			static void n_OnCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraChangeFinish (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_;
			public unsafe void OnCameraChangeFinish (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
			{
				if (id_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_ == IntPtr.Zero)
					id_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "onCameraChangeFinish", "(Lcom/amap/api/maps2d/model/CameraPosition;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraChangeFinish_Lcom_amap_api_maps2d_model_CameraPosition_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnCameraChangeListener.onCameraChange
		public partial class CameraChangeEventArgs : global::System.EventArgs {

			public CameraChangeEventArgs (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.CameraPosition p0;
			public global::Com.Amap.Api.Maps2d.Model.CameraPosition P0 {
				get { return p0; }
			}
		}

		// event args for com.amap.api.maps2d.AMap.OnCameraChangeListener.onCameraChangeFinish
		public partial class CameraChangeFinishEventArgs : global::System.EventArgs {

			public CameraChangeFinishEventArgs (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.CameraPosition p0;
			public global::Com.Amap.Api.Maps2d.Model.CameraPosition P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnCameraChangeListenerImplementor")]
		internal sealed partial class IOnCameraChangeListenerImplementor : global::Java.Lang.Object, IOnCameraChangeListener {

			object sender;

			public IOnCameraChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnCameraChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraChangeEventArgs> OnCameraChangeHandler;
#pragma warning restore 0649

			public void OnCameraChange (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
			{
				var __h = OnCameraChangeHandler;
				if (__h != null)
					__h (sender, new CameraChangeEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<CameraChangeFinishEventArgs> OnCameraChangeFinishHandler;
#pragma warning restore 0649

			public void OnCameraChangeFinish (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
			{
				var __h = OnCameraChangeFinishHandler;
				if (__h != null)
					__h (sender, new CameraChangeFinishEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCameraChangeListenerImplementor value)
			{
				return value.OnCameraChangeHandler == null && value.OnCameraChangeFinishHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnInfoWindowClickListener']"
		[Register ("com/amap/api/maps2d/AMap$OnInfoWindowClickListener", "", "Com.Amap.Api.Maps2d.AMap/IOnInfoWindowClickListenerInvoker")]
		public partial interface IOnInfoWindowClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnInfoWindowClickListener']/method[@name='onInfoWindowClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("onInfoWindowClick", "(Lcom/amap/api/maps2d/model/Marker;)V", "GetOnInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IOnInfoWindowClickListenerInvoker, AMap")]
			void OnInfoWindowClick (global::Com.Amap.Api.Maps2d.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnInfoWindowClickListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnInfoWindowClickListener", typeof (IOnInfoWindowClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnInfoWindowClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnInfoWindowClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_);
				return cb_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_;
			}

			static void n_OnInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe void OnInfoWindowClick (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowClick", "(Lcom/amap/api/maps2d/model/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInfoWindowClick_Lcom_amap_api_maps2d_model_Marker_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnInfoWindowClickListener.onInfoWindowClick
		public partial class InfoWindowClickEventArgs : global::System.EventArgs {

			public InfoWindowClickEventArgs (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.Marker p0;
			public global::Com.Amap.Api.Maps2d.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnInfoWindowClickListenerImplementor")]
		internal sealed partial class IOnInfoWindowClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowClickListener {

			object sender;

			public IOnInfoWindowClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnInfoWindowClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoWindowClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnInfoWindowClick (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InfoWindowClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnInfoWindowClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapClickListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMapClickListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMapClickListenerInvoker")]
		public partial interface IOnMapClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapClickListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("onMapClick", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetOnMapClick_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Maps2d.AMap/IOnMapClickListenerInvoker, AMap")]
			void OnMapClick (global::Com.Amap.Api.Maps2d.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMapClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMapClickListener", typeof (IOnMapClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMapClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapClick_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapClick_Lcom_amap_api_maps2d_model_LatLng_Handler ()
			{
				if (cb_onMapClick_Lcom_amap_api_maps2d_model_LatLng_ == null)
					cb_onMapClick_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapClick_Lcom_amap_api_maps2d_model_LatLng_);
				return cb_onMapClick_Lcom_amap_api_maps2d_model_LatLng_;
			}

			static void n_OnMapClick_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapClick_Lcom_amap_api_maps2d_model_LatLng_;
			public unsafe void OnMapClick (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				if (id_onMapClick_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
					id_onMapClick_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/amap/api/maps2d/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapClick_Lcom_amap_api_maps2d_model_LatLng_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMapClickListener.onMapClick
		public partial class MapClickEventArgs : global::System.EventArgs {

			public MapClickEventArgs (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.LatLng p0;
			public global::Com.Amap.Api.Maps2d.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMapClickListenerImplementor")]
		internal sealed partial class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener {

			object sender;

			public IOnMapClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMapClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapClick (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapLoadedListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMapLoadedListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMapLoadedListenerInvoker")]
		public partial interface IOnMapLoadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapLoadedListener']/method[@name='onMapLoaded' and count(parameter)=0]"
			[Register ("onMapLoaded", "()V", "GetOnMapLoadedHandler:Com.Amap.Api.Maps2d.AMap/IOnMapLoadedListenerInvoker, AMap")]
			void OnMapLoaded ();

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMapLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnMapLoadedListenerInvoker : global::Java.Lang.Object, IOnMapLoadedListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMapLoadedListener", typeof (IOnMapLoadedListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMapLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLoaded;
#pragma warning disable 0169
			static Delegate GetOnMapLoadedHandler ()
			{
				if (cb_onMapLoaded == null)
					cb_onMapLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMapLoaded);
				return cb_onMapLoaded;
			}

			static void n_OnMapLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onMapLoaded;
			public unsafe void OnMapLoaded ()
			{
				if (id_onMapLoaded == IntPtr.Zero)
					id_onMapLoaded = JNIEnv.GetMethodID (class_ref, "onMapLoaded", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapLoaded);
			}

		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMapLoadedListenerImplementor")]
		internal sealed partial class IOnMapLoadedListenerImplementor : global::Java.Lang.Object, IOnMapLoadedListener {

			object sender;

			public IOnMapLoadedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMapLoadedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnMapLoaded ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnMapLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapLongClickListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMapLongClickListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMapLongClickListenerInvoker")]
		public partial interface IOnMapLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapLongClickListener']/method[@name='onMapLongClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("onMapLongClick", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetOnMapLongClick_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Maps2d.AMap/IOnMapLongClickListenerInvoker, AMap")]
			void OnMapLongClick (global::Com.Amap.Api.Maps2d.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMapLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMapLongClickListener", typeof (IOnMapLongClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMapLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapLongClick_Lcom_amap_api_maps2d_model_LatLng_Handler ()
			{
				if (cb_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_ == null)
					cb_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapLongClick_Lcom_amap_api_maps2d_model_LatLng_);
				return cb_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_;
			}

			static void n_OnMapLongClick_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLongClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_;
			public unsafe void OnMapLongClick (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				if (id_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
					id_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongClick", "(Lcom/amap/api/maps2d/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapLongClick_Lcom_amap_api_maps2d_model_LatLng_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMapLongClickListener.onMapLongClick
		public partial class MapLongClickEventArgs : global::System.EventArgs {

			public MapLongClickEventArgs (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.LatLng p0;
			public global::Com.Amap.Api.Maps2d.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMapLongClickListenerImplementor")]
		internal sealed partial class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener {

			object sender;

			public IOnMapLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMapLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapLongClick (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapLongClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapScreenShotListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMapScreenShotListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMapScreenShotListenerInvoker")]
		public partial interface IOnMapScreenShotListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapScreenShotListener']/method[@name='onMapScreenShot' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("onMapScreenShot", "(Landroid/graphics/Bitmap;)V", "GetOnMapScreenShot_Landroid_graphics_Bitmap_Handler:Com.Amap.Api.Maps2d.AMap/IOnMapScreenShotListenerInvoker, AMap")]
			void OnMapScreenShot (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMapScreenShotListener", DoNotGenerateAcw=true)]
		internal class IOnMapScreenShotListenerInvoker : global::Java.Lang.Object, IOnMapScreenShotListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMapScreenShotListener", typeof (IOnMapScreenShotListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapScreenShotListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapScreenShotListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMapScreenShotListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapScreenShotListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapScreenShot_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnMapScreenShot_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onMapScreenShot_Landroid_graphics_Bitmap_ == null)
					cb_onMapScreenShot_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapScreenShot_Landroid_graphics_Bitmap_);
				return cb_onMapScreenShot_Landroid_graphics_Bitmap_;
			}

			static void n_OnMapScreenShot_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapScreenShot (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapScreenShot_Landroid_graphics_Bitmap_;
			public unsafe void OnMapScreenShot (global::Android.Graphics.Bitmap p0)
			{
				if (id_onMapScreenShot_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onMapScreenShot_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onMapScreenShot", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapScreenShot_Landroid_graphics_Bitmap_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMapScreenShotListener.onMapScreenShot
		public partial class MapScreenShotEventArgs : global::System.EventArgs {

			public MapScreenShotEventArgs (global::Android.Graphics.Bitmap p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.Bitmap p0;
			public global::Android.Graphics.Bitmap P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMapScreenShotListenerImplementor")]
		internal sealed partial class IOnMapScreenShotListenerImplementor : global::Java.Lang.Object, IOnMapScreenShotListener {

			object sender;

			public IOnMapScreenShotListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMapScreenShotListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapScreenShotEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapScreenShot (global::Android.Graphics.Bitmap p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapScreenShotEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapScreenShotListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapTouchListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMapTouchListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMapTouchListenerInvoker")]
		public partial interface IOnMapTouchListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMapTouchListener']/method[@name='onTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/MotionEvent;)V", "GetOnTouch_Landroid_view_MotionEvent_Handler:Com.Amap.Api.Maps2d.AMap/IOnMapTouchListenerInvoker, AMap")]
			void OnTouch (global::Android.Views.MotionEvent p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMapTouchListener", DoNotGenerateAcw=true)]
		internal class IOnMapTouchListenerInvoker : global::Java.Lang.Object, IOnMapTouchListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMapTouchListener", typeof (IOnMapTouchListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapTouchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapTouchListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMapTouchListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTouch_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_MotionEvent_;
			}

			static void n_OnTouch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTouch (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTouch_Landroid_view_MotionEvent_;
			public unsafe void OnTouch (global::Android.Views.MotionEvent p0)
			{
				if (id_onTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/MotionEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_MotionEvent_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMapTouchListener.onTouch
		public partial class MapTouchEventArgs : global::System.EventArgs {

			public MapTouchEventArgs (global::Android.Views.MotionEvent p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.MotionEvent p0;
			public global::Android.Views.MotionEvent P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMapTouchListenerImplementor")]
		internal sealed partial class IOnMapTouchListenerImplementor : global::Java.Lang.Object, IOnMapTouchListener {

			object sender;

			public IOnMapTouchListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMapTouchListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapTouchEventArgs> Handler;
#pragma warning restore 0649

			public void OnTouch (global::Android.Views.MotionEvent p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapTouchEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapTouchListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMarkerClickListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMarkerClickListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("onMarkerClick", "(Lcom/amap/api/maps2d/model/Marker;)Z", "GetOnMarkerClick_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IOnMarkerClickListenerInvoker, AMap")]
			bool OnMarkerClick (global::Com.Amap.Api.Maps2d.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMarkerClickListener", typeof (IOnMarkerClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_amap_api_maps2d_model_Marker_);
				return cb_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_;
			}

			static bool n_OnMarkerClick_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe bool OnMarkerClick (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/amap/api/maps2d/model/Marker;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerClick_Lcom_amap_api_maps2d_model_Marker_, __args);
				return __ret;
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMarkerClickListener.onMarkerClick
		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Amap.Api.Maps2d.Model.Marker p0;
			public global::Com.Amap.Api.Maps2d.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMarkerClickListenerImplementor")]
		internal sealed partial class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMarkerClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMarkerDragListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMarkerDragListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMarkerDragListenerInvoker")]
		public partial interface IOnMarkerDragListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMarkerDragListener']/method[@name='onMarkerDrag' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("onMarkerDrag", "(Lcom/amap/api/maps2d/model/Marker;)V", "GetOnMarkerDrag_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IOnMarkerDragListenerInvoker, AMap")]
			void OnMarkerDrag (global::Com.Amap.Api.Maps2d.Model.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMarkerDragListener']/method[@name='onMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("onMarkerDragEnd", "(Lcom/amap/api/maps2d/model/Marker;)V", "GetOnMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IOnMarkerDragListenerInvoker, AMap")]
			void OnMarkerDragEnd (global::Com.Amap.Api.Maps2d.Model.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMarkerDragListener']/method[@name='onMarkerDragStart' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.Marker']]"
			[Register ("onMarkerDragStart", "(Lcom/amap/api/maps2d/model/Marker;)V", "GetOnMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_Handler:Com.Amap.Api.Maps2d.AMap/IOnMarkerDragListenerInvoker, AMap")]
			void OnMarkerDragStart (global::Com.Amap.Api.Maps2d.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMarkerDragListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMarkerDragListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMarkerDragListener", typeof (IOnMarkerDragListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMarkerDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerDragListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMarkerDragListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDrag_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDrag_Lcom_amap_api_maps2d_model_Marker_);
				return cb_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_;
			}

			static void n_OnMarkerDrag_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDrag (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe void OnMarkerDrag (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDrag", "(Lcom/amap/api/maps2d/model/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDrag_Lcom_amap_api_maps2d_model_Marker_, __args);
			}

			static Delegate cb_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_);
				return cb_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_;
			}

			static void n_OnMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe void OnMarkerDragEnd (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragEnd", "(Lcom/amap/api/maps2d/model/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDragEnd_Lcom_amap_api_maps2d_model_Marker_, __args);
			}

			static Delegate cb_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_Handler ()
			{
				if (cb_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_ == null)
					cb_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_);
				return cb_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_;
			}

			static void n_OnMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Amap.Api.Maps2d.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_;
			public unsafe void OnMarkerDragStart (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				if (id_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_ == IntPtr.Zero)
					id_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragStart", "(Lcom/amap/api/maps2d/model/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDragStart_Lcom_amap_api_maps2d_model_Marker_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMarkerDragListener.onMarkerDrag
		public partial class MarkerDragEventArgs : global::System.EventArgs {

			public MarkerDragEventArgs (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.Marker p0;
			public global::Com.Amap.Api.Maps2d.Model.Marker P0 {
				get { return p0; }
			}
		}

		// event args for com.amap.api.maps2d.AMap.OnMarkerDragListener.onMarkerDragEnd
		public partial class MarkerDragEndEventArgs : global::System.EventArgs {

			public MarkerDragEndEventArgs (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.Marker p0;
			public global::Com.Amap.Api.Maps2d.Model.Marker P0 {
				get { return p0; }
			}
		}

		// event args for com.amap.api.maps2d.AMap.OnMarkerDragListener.onMarkerDragStart
		public partial class MarkerDragStartEventArgs : global::System.EventArgs {

			public MarkerDragStartEventArgs (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Amap.Api.Maps2d.Model.Marker p0;
			public global::Com.Amap.Api.Maps2d.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMarkerDragListenerImplementor")]
		internal sealed partial class IOnMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMarkerDragListener {

			object sender;

			public IOnMarkerDragListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMarkerDragListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

			public void OnMarkerDrag (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				var __h = OnMarkerDragHandler;
				if (__h != null)
					__h (sender, new MarkerDragEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

			public void OnMarkerDragEnd (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				var __h = OnMarkerDragEndHandler;
				if (__h != null)
					__h (sender, new MarkerDragEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

			public void OnMarkerDragStart (global::Com.Amap.Api.Maps2d.Model.Marker p0)
			{
				var __h = OnMarkerDragStartHandler;
				if (__h != null)
					__h (sender, new MarkerDragStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMarkerDragListenerImplementor value)
			{
				return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMyLocationChangeListener']"
		[Register ("com/amap/api/maps2d/AMap$OnMyLocationChangeListener", "", "Com.Amap.Api.Maps2d.AMap/IOnMyLocationChangeListenerInvoker")]
		public partial interface IOnMyLocationChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/interface[@name='AMap.OnMyLocationChangeListener']/method[@name='onMyLocationChange' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("onMyLocationChange", "(Landroid/location/Location;)V", "GetOnMyLocationChange_Landroid_location_Location_Handler:Com.Amap.Api.Maps2d.AMap/IOnMyLocationChangeListenerInvoker, AMap")]
			void OnMyLocationChange (global::Android.Locations.Location p0);

		}

		[global::Android.Runtime.Register ("com/amap/api/maps2d/AMap$OnMyLocationChangeListener", DoNotGenerateAcw=true)]
		internal class IOnMyLocationChangeListenerInvoker : global::Java.Lang.Object, IOnMyLocationChangeListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/AMap$OnMyLocationChangeListener", typeof (IOnMyLocationChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMyLocationChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMyLocationChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.AMap.OnMyLocationChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMyLocationChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMyLocationChange_Landroid_location_Location_;
#pragma warning disable 0169
			static Delegate GetOnMyLocationChange_Landroid_location_Location_Handler ()
			{
				if (cb_onMyLocationChange_Landroid_location_Location_ == null)
					cb_onMyLocationChange_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMyLocationChange_Landroid_location_Location_);
				return cb_onMyLocationChange_Landroid_location_Location_;
			}

			static void n_OnMyLocationChange_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMyLocationChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMyLocationChange_Landroid_location_Location_;
			public unsafe void OnMyLocationChange (global::Android.Locations.Location p0)
			{
				if (id_onMyLocationChange_Landroid_location_Location_ == IntPtr.Zero)
					id_onMyLocationChange_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onMyLocationChange", "(Landroid/location/Location;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMyLocationChange_Landroid_location_Location_, __args);
			}

		}

		// event args for com.amap.api.maps2d.AMap.OnMyLocationChangeListener.onMyLocationChange
		public partial class MyLocationChangeEventArgs : global::System.EventArgs {

			public MyLocationChangeEventArgs (global::Android.Locations.Location p0)
			{
				this.p0 = p0;
			}

			global::Android.Locations.Location p0;
			public global::Android.Locations.Location P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/amap/api/maps2d/AMap_OnMyLocationChangeListenerImplementor")]
		internal sealed partial class IOnMyLocationChangeListenerImplementor : global::Java.Lang.Object, IOnMyLocationChangeListener {

			object sender;

			public IOnMyLocationChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/maps2d/AMap_OnMyLocationChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MyLocationChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnMyLocationChange (global::Android.Locations.Location p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MyLocationChangeEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMyLocationChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/AMap", typeof (AMap));
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

		internal AMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition CameraPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getCameraPosition' and count(parameter)=0]"
			[Register ("getCameraPosition", "()Lcom/amap/api/maps2d/model/CameraPosition;", "GetGetCameraPositionHandler")]
			get {
				const string __id = "getCameraPosition.()Lcom/amap/api/maps2d/model/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.Marker> MapScreenMarkers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getMapScreenMarkers' and count(parameter)=0]"
			[Register ("getMapScreenMarkers", "()Ljava/util/List;", "GetGetMapScreenMarkersHandler")]
			get {
				const string __id = "getMapScreenMarkers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.Marker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int MapType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getMapType' and count(parameter)=0]"
			[Register ("getMapType", "()I", "GetGetMapTypeHandler")]
			get {
				const string __id = "getMapType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setMapType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMapType", "(I)V", "GetSetMapType_IHandler")]
			set {
				const string __id = "setMapType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()F", "GetGetMaxZoomLevelHandler")]
			get {
				const string __id = "getMaxZoomLevel.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()F", "GetGetMinZoomLevelHandler")]
			get {
				const string __id = "getMinZoomLevel.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Locations.Location MyLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getMyLocation' and count(parameter)=0]"
			[Register ("getMyLocation", "()Landroid/location/Location;", "GetGetMyLocationHandler")]
			get {
				const string __id = "getMyLocation.()Landroid/location/Location;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool MyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler")]
			get {
				const string __id = "isMyLocationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setMyLocationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler")]
			set {
				const string __id = "setMyLocationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Amap.Api.Maps2d.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lcom/amap/api/maps2d/Projection;", "GetGetProjectionHandler")]
			get {
				const string __id = "getProjection.()Lcom/amap/api/maps2d/Projection;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getScalePerPixel' and count(parameter)=0]"
			[Register ("getScalePerPixel", "()F", "GetGetScalePerPixelHandler")]
			get {
				const string __id = "getScalePerPixel.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool TrafficEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='isTrafficEnabled' and count(parameter)=0]"
			[Register ("isTrafficEnabled", "()Z", "GetIsTrafficEnabledHandler")]
			get {
				const string __id = "isTrafficEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setTrafficEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrafficEnabled", "(Z)V", "GetSetTrafficEnabled_ZHandler")]
			set {
				const string __id = "setTrafficEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Amap.Api.Maps2d.UiSettings UiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getUiSettings' and count(parameter)=0]"
			[Register ("getUiSettings", "()Lcom/amap/api/maps2d/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				const string __id = "getUiSettings.()Lcom/amap/api/maps2d/UiSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.UiSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public static unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CircleOptions']]"
		[Register ("addCircle", "(Lcom/amap/api/maps2d/model/CircleOptions;)Lcom/amap/api/maps2d/model/Circle;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.Circle AddCircle (global::Com.Amap.Api.Maps2d.Model.CircleOptions p0)
		{
			const string __id = "addCircle.(Lcom/amap/api/maps2d/model/CircleOptions;)Lcom/amap/api/maps2d/model/Circle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Circle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.GroundOverlayOptions']]"
		[Register ("addGroundOverlay", "(Lcom/amap/api/maps2d/model/GroundOverlayOptions;)Lcom/amap/api/maps2d/model/GroundOverlay;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.GroundOverlay AddGroundOverlay (global::Com.Amap.Api.Maps2d.Model.GroundOverlayOptions p0)
		{
			const string __id = "addGroundOverlay.(Lcom/amap/api/maps2d/model/GroundOverlayOptions;)Lcom/amap/api/maps2d/model/GroundOverlay;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.GroundOverlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.MarkerOptions']]"
		[Register ("addMarker", "(Lcom/amap/api/maps2d/model/MarkerOptions;)Lcom/amap/api/maps2d/model/Marker;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.Marker AddMarker (global::Com.Amap.Api.Maps2d.Model.MarkerOptions p0)
		{
			const string __id = "addMarker.(Lcom/amap/api/maps2d/model/MarkerOptions;)Lcom/amap/api/maps2d/model/Marker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.PolygonOptions']]"
		[Register ("addPolygon", "(Lcom/amap/api/maps2d/model/PolygonOptions;)Lcom/amap/api/maps2d/model/Polygon;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.Polygon AddPolygon (global::Com.Amap.Api.Maps2d.Model.PolygonOptions p0)
		{
			const string __id = "addPolygon.(Lcom/amap/api/maps2d/model/PolygonOptions;)Lcom/amap/api/maps2d/model/Polygon;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Polygon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.PolylineOptions']]"
		[Register ("addPolyline", "(Lcom/amap/api/maps2d/model/PolylineOptions;)Lcom/amap/api/maps2d/model/Polyline;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.Polyline AddPolyline (global::Com.Amap.Api.Maps2d.Model.PolylineOptions p0)
		{
			const string __id = "addPolyline.(Lcom/amap/api/maps2d/model/PolylineOptions;)Lcom/amap/api/maps2d/model/Polyline;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Polyline> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addText' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.TextOptions']]"
		[Register ("addText", "(Lcom/amap/api/maps2d/model/TextOptions;)Lcom/amap/api/maps2d/model/Text;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.Text AddText (global::Com.Amap.Api.Maps2d.Model.TextOptions p0)
		{
			const string __id = "addText.(Lcom/amap/api/maps2d/model/TextOptions;)Lcom/amap/api/maps2d/model/Text;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Text> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='addTileOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.TileOverlayOptions']]"
		[Register ("addTileOverlay", "(Lcom/amap/api/maps2d/model/TileOverlayOptions;)Lcom/amap/api/maps2d/model/TileOverlay;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlay AddTileOverlay (global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions p0)
		{
			const string __id = "addTileOverlay.(Lcom/amap/api/maps2d/model/TileOverlayOptions;)Lcom/amap/api/maps2d/model/TileOverlay;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='animateCamera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate']]"
		[Register ("animateCamera", "(Lcom/amap/api/maps2d/CameraUpdate;)V", "")]
		public unsafe void AnimateCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0)
		{
			const string __id = "animateCamera.(Lcom/amap/api/maps2d/CameraUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='animateCamera' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate'] and parameter[2][@type='com.amap.api.maps2d.AMap.CancelableCallback']]"
		[Register ("animateCamera", "(Lcom/amap/api/maps2d/CameraUpdate;Lcom/amap/api/maps2d/AMap$CancelableCallback;)V", "")]
		public unsafe void AnimateCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0, global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p1)
		{
			const string __id = "animateCamera.(Lcom/amap/api/maps2d/CameraUpdate;Lcom/amap/api/maps2d/AMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='animateCamera' and count(parameter)=3 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate'] and parameter[2][@type='long'] and parameter[3][@type='com.amap.api.maps2d.AMap.CancelableCallback']]"
		[Register ("animateCamera", "(Lcom/amap/api/maps2d/CameraUpdate;JLcom/amap/api/maps2d/AMap$CancelableCallback;)V", "")]
		public unsafe void AnimateCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0, long p1, global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p2)
		{
			const string __id = "animateCamera.(Lcom/amap/api/maps2d/CameraUpdate;JLcom/amap/api/maps2d/AMap$CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='getMapScreenShot' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapScreenShotListener']]"
		[Register ("getMapScreenShot", "(Lcom/amap/api/maps2d/AMap$OnMapScreenShotListener;)V", "")]
		public unsafe void GetMapScreenShot (global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener p0)
		{
			const string __id = "getMapScreenShot.(Lcom/amap/api/maps2d/AMap$OnMapScreenShotListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "")]
		public unsafe void Invalidate ()
		{
			const string __id = "invalidate.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate']]"
		[Register ("moveCamera", "(Lcom/amap/api/maps2d/CameraUpdate;)V", "")]
		public unsafe void MoveCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0)
		{
			const string __id = "moveCamera.(Lcom/amap/api/maps2d/CameraUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='postInvalidate' and count(parameter)=0]"
		[Register ("postInvalidate", "()V", "")]
		public unsafe void PostInvalidate ()
		{
			const string __id = "postInvalidate.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='removecache' and count(parameter)=0]"
		[Register ("removecache", "()V", "")]
		public unsafe void Removecache ()
		{
			const string __id = "removecache.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='removecache' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnCacheRemoveListener']]"
		[Register ("removecache", "(Lcom/amap/api/maps2d/AMap$OnCacheRemoveListener;)V", "")]
		public unsafe void Removecache (global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener p0)
		{
			const string __id = "removecache.(Lcom/amap/api/maps2d/AMap$OnCacheRemoveListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setInfoWindowAdapter' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.InfoWindowAdapter']]"
		[Register ("setInfoWindowAdapter", "(Lcom/amap/api/maps2d/AMap$InfoWindowAdapter;)V", "")]
		public unsafe void SetInfoWindowAdapter (global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter p0)
		{
			const string __id = "setInfoWindowAdapter.(Lcom/amap/api/maps2d/AMap$InfoWindowAdapter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setLocationSource' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.LocationSource']]"
		[Register ("setLocationSource", "(Lcom/amap/api/maps2d/LocationSource;)V", "")]
		public unsafe void SetLocationSource (global::Com.Amap.Api.Maps2d.ILocationSource p0)
		{
			const string __id = "setLocationSource.(Lcom/amap/api/maps2d/LocationSource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setMapLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMapLanguage", "(Ljava/lang/String;)V", "")]
		public unsafe void SetMapLanguage (string p0)
		{
			const string __id = "setMapLanguage.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setMyLocationRotateAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMyLocationRotateAngle", "(F)V", "")]
		public unsafe void SetMyLocationRotateAngle (float p0)
		{
			const string __id = "setMyLocationRotateAngle.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setMyLocationStyle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.MyLocationStyle']]"
		[Register ("setMyLocationStyle", "(Lcom/amap/api/maps2d/model/MyLocationStyle;)V", "")]
		public unsafe void SetMyLocationStyle (global::Com.Amap.Api.Maps2d.Model.MyLocationStyle p0)
		{
			const string __id = "setMyLocationStyle.(Lcom/amap/api/maps2d/model/MyLocationStyle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setMyLocationType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setMyLocationType", "(I)V", "")]
		public unsafe void SetMyLocationType (int p0)
		{
			const string __id = "setMyLocationType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnCameraChangeListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnCameraChangeListener']]"
		[Register ("setOnCameraChangeListener", "(Lcom/amap/api/maps2d/AMap$OnCameraChangeListener;)V", "")]
		public unsafe void SetOnCameraChangeListener (global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener p0)
		{
			const string __id = "setOnCameraChangeListener.(Lcom/amap/api/maps2d/AMap$OnCameraChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnInfoWindowClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnInfoWindowClickListener']]"
		[Register ("setOnInfoWindowClickListener", "(Lcom/amap/api/maps2d/AMap$OnInfoWindowClickListener;)V", "")]
		public unsafe void SetOnInfoWindowClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener p0)
		{
			const string __id = "setOnInfoWindowClickListener.(Lcom/amap/api/maps2d/AMap$OnInfoWindowClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapClickListener']]"
		[Register ("setOnMapClickListener", "(Lcom/amap/api/maps2d/AMap$OnMapClickListener;)V", "")]
		public unsafe void SetOnMapClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener p0)
		{
			const string __id = "setOnMapClickListener.(Lcom/amap/api/maps2d/AMap$OnMapClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMapLoadedListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapLoadedListener']]"
		[Register ("setOnMapLoadedListener", "(Lcom/amap/api/maps2d/AMap$OnMapLoadedListener;)V", "")]
		public unsafe void SetOnMapLoadedListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener p0)
		{
			const string __id = "setOnMapLoadedListener.(Lcom/amap/api/maps2d/AMap$OnMapLoadedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapLongClickListener']]"
		[Register ("setOnMapLongClickListener", "(Lcom/amap/api/maps2d/AMap$OnMapLongClickListener;)V", "")]
		public unsafe void SetOnMapLongClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener p0)
		{
			const string __id = "setOnMapLongClickListener.(Lcom/amap/api/maps2d/AMap$OnMapLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMapTouchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapTouchListener']]"
		[Register ("setOnMapTouchListener", "(Lcom/amap/api/maps2d/AMap$OnMapTouchListener;)V", "")]
		public unsafe void SetOnMapTouchListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener p0)
		{
			const string __id = "setOnMapTouchListener.(Lcom/amap/api/maps2d/AMap$OnMapTouchListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMarkerClickListener']]"
		[Register ("setOnMarkerClickListener", "(Lcom/amap/api/maps2d/AMap$OnMarkerClickListener;)V", "")]
		public unsafe void SetOnMarkerClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener p0)
		{
			const string __id = "setOnMarkerClickListener.(Lcom/amap/api/maps2d/AMap$OnMarkerClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMarkerDragListener']]"
		[Register ("setOnMarkerDragListener", "(Lcom/amap/api/maps2d/AMap$OnMarkerDragListener;)V", "")]
		public unsafe void SetOnMarkerDragListener (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener p0)
		{
			const string __id = "setOnMarkerDragListener.(Lcom/amap/api/maps2d/AMap$OnMarkerDragListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='setOnMyLocationChangeListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMyLocationChangeListener']]"
		[Register ("setOnMyLocationChangeListener", "(Lcom/amap/api/maps2d/AMap$OnMyLocationChangeListener;)V", "")]
		public unsafe void SetOnMyLocationChangeListener (global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener p0)
		{
			const string __id = "setOnMyLocationChangeListener.(Lcom/amap/api/maps2d/AMap$OnMyLocationChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMap']/method[@name='stopAnimation' and count(parameter)=0]"
		[Register ("stopAnimation", "()V", "")]
		public unsafe void StopAnimation ()
		{
			const string __id = "stopAnimation.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.CameraChangeEventArgs> CameraChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnCameraChangeListener,
						__CreateIOnCameraChangeListenerImplementor,
						SetOnCameraChangeListener,
						__h => __h.OnCameraChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnCameraChangeListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor.__IsEmpty,
						__v => SetOnCameraChangeListener (null),
						__h => __h.OnCameraChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.CameraChangeFinishEventArgs> CameraChangeFinish {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnCameraChangeListener,
						__CreateIOnCameraChangeListenerImplementor,
						SetOnCameraChangeListener,
						__h => __h.OnCameraChangeFinishHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener, global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnCameraChangeListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor.__IsEmpty,
						__v => SetOnCameraChangeListener (null),
						__h => __h.OnCameraChangeFinishHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCameraChangeListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor __CreateIOnCameraChangeListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.InfoWindowClickEventArgs> InfoWindowClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						__CreateIOnInfoWindowClickListenerImplementor,
						SetOnInfoWindowClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListenerImplementor.__IsEmpty,
						__v => SetOnInfoWindowClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInfoWindowClickListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListenerImplementor __CreateIOnInfoWindowClickListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMapClickListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapClickListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener"
		public event EventHandler MapLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListenerImplementor>(
						ref weak_implementor_SetOnMapLoadedListener,
						__CreateIOnMapLoadedListenerImplementor,
						SetOnMapLoadedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListenerImplementor>(
						ref weak_implementor_SetOnMapLoadedListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListenerImplementor.__IsEmpty,
						__v => SetOnMapLoadedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLoadedListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListenerImplementor __CreateIOnMapLoadedListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MapLongClickEventArgs> MapLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						__CreateIOnMapLongClickListenerImplementor,
						SetOnMapLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						__v => SetOnMapLongClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLongClickListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MapTouchEventArgs> MapTouch {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListenerImplementor>(
						ref weak_implementor_SetOnMapTouchListener,
						__CreateIOnMapTouchListenerImplementor,
						SetOnMapTouchListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener, global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListenerImplementor>(
						ref weak_implementor_SetOnMapTouchListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListenerImplementor.__IsEmpty,
						__v => SetOnMapTouchListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapTouchListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListenerImplementor __CreateIOnMapTouchListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener, global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDragListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor __CreateIOnMarkerDragListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener"
		public event EventHandler<global::Com.Amap.Api.Maps2d.AMap.MyLocationChangeEventArgs> MyLocationChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener, global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListenerImplementor>(
						ref weak_implementor_SetOnMyLocationChangeListener,
						__CreateIOnMyLocationChangeListenerImplementor,
						SetOnMyLocationChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener, global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListenerImplementor>(
						ref weak_implementor_SetOnMyLocationChangeListener,
						global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListenerImplementor.__IsEmpty,
						__v => SetOnMyLocationChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMyLocationChangeListener;

		global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListenerImplementor __CreateIOnMyLocationChangeListenerImplementor ()
		{
			return new global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListenerImplementor (this);
		}
#endregion
	}
}
