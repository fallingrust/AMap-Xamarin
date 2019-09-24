using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']"
	[Register ("com/amap/api/interfaces/ITileOverlay", "", "Com.Amap.Api.Interfaces.ITileOverlayInvoker")]
	public partial interface ITileOverlay : IJavaObject {

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")] get;
		}

		bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")] set;
		}

		float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='clearTileCache' and count(parameter)=0]"
		[Register ("clearTileCache", "()V", "GetClearTileCacheHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")]
		void ClearTileCache ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='equalsRemote' and count(parameter)=1 and parameter[1][@type='com.amap.api.interfaces.ITileOverlay']]"
		[Register ("equalsRemote", "(Lcom/amap/api/interfaces/ITileOverlay;)Z", "GetEqualsRemote_Lcom_amap_api_interfaces_ITileOverlay_Handler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")]
		bool EqualsRemote (global::Com.Amap.Api.Interfaces.ITileOverlay p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='hashCodeRemote' and count(parameter)=0]"
		[Register ("hashCodeRemote", "()I", "GetHashCodeRemoteHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")]
		int HashCodeRemote ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='ITileOverlay']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler:Com.Amap.Api.Interfaces.ITileOverlayInvoker, AMap")]
		void Remove ();

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/ITileOverlay", DoNotGenerateAcw=true)]
	internal class ITileOverlayInvoker : global::Java.Lang.Object, ITileOverlay {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/ITileOverlay", typeof (ITileOverlayInvoker));

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

		public static ITileOverlay GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITileOverlay> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.ITileOverlay"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITileOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		IntPtr id_setVisible_Z;
		public unsafe bool Visible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisible_Z, __args);
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZIndex);
			return cb_getZIndex;
		}

		static float n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_F;
#pragma warning disable 0169
		static Delegate GetSetZIndex_FHandler ()
		{
			if (cb_setZIndex_F == null)
				cb_setZIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZIndex_F);
			return cb_setZIndex_F;
		}

		static void n_SetZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		IntPtr id_getZIndex;
		IntPtr id_setZIndex_F;
		public unsafe float ZIndex {
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getZIndex);
			}
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZIndex_F, __args);
			}
		}

		static Delegate cb_clearTileCache;
#pragma warning disable 0169
		static Delegate GetClearTileCacheHandler ()
		{
			if (cb_clearTileCache == null)
				cb_clearTileCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearTileCache);
			return cb_clearTileCache;
		}

		static void n_ClearTileCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearTileCache ();
		}
#pragma warning restore 0169

		IntPtr id_clearTileCache;
		public unsafe void ClearTileCache ()
		{
			if (id_clearTileCache == IntPtr.Zero)
				id_clearTileCache = JNIEnv.GetMethodID (class_ref, "clearTileCache", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearTileCache);
		}

		static Delegate cb_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_;
#pragma warning disable 0169
		static Delegate GetEqualsRemote_Lcom_amap_api_interfaces_ITileOverlay_Handler ()
		{
			if (cb_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_ == null)
				cb_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EqualsRemote_Lcom_amap_api_interfaces_ITileOverlay_);
			return cb_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_;
		}

		static bool n_EqualsRemote_Lcom_amap_api_interfaces_ITileOverlay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Interfaces.ITileOverlay p0 = (global::Com.Amap.Api.Interfaces.ITileOverlay)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualsRemote (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_;
		public unsafe bool EqualsRemote (global::Com.Amap.Api.Interfaces.ITileOverlay p0)
		{
			if (id_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_ == IntPtr.Zero)
				id_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_ = JNIEnv.GetMethodID (class_ref, "equalsRemote", "(Lcom/amap/api/interfaces/ITileOverlay;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equalsRemote_Lcom_amap_api_interfaces_ITileOverlay_, __args);
			return __ret;
		}

		static Delegate cb_hashCodeRemote;
#pragma warning disable 0169
		static Delegate GetHashCodeRemoteHandler ()
		{
			if (cb_hashCodeRemote == null)
				cb_hashCodeRemote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HashCodeRemote);
			return cb_hashCodeRemote;
		}

		static int n_HashCodeRemote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HashCodeRemote ();
		}
#pragma warning restore 0169

		IntPtr id_hashCodeRemote;
		public unsafe int HashCodeRemote ()
		{
			if (id_hashCodeRemote == IntPtr.Zero)
				id_hashCodeRemote = JNIEnv.GetMethodID (class_ref, "hashCodeRemote", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCodeRemote);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.ITileOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.ITileOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
		}

	}

}
