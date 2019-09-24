using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Fence {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceListener']"
	[Register ("com/amap/api/fence/GeoFenceListener", "", "Com.Amap.Api.Fence.IGeoFenceListenerInvoker")]
	public partial interface IGeoFenceListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceListener']/method[@name='onGeoFenceCreateFinished' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.amap.api.fence.GeoFence&gt;'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onGeoFenceCreateFinished", "(Ljava/util/List;ILjava/lang/String;)V", "GetOnGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceListenerInvoker, AMap")]
		void OnGeoFenceCreateFinished (global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> p0, int p1, string p2);

	}

	[global::Android.Runtime.Register ("com/amap/api/fence/GeoFenceListener", DoNotGenerateAcw=true)]
	internal class IGeoFenceListenerInvoker : global::Java.Lang.Object, IGeoFenceListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/fence/GeoFenceListener", typeof (IGeoFenceListenerInvoker));

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

		public static IGeoFenceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeoFenceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.fence.GeoFenceListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeoFenceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_Handler ()
		{
			if (cb_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_ == null)
				cb_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_);
			return cb_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_;
		}

		static void n_OnGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Amap.Api.Fence.IGeoFenceListener __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.GeoFence>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGeoFenceCreateFinished (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_;
		public unsafe void OnGeoFenceCreateFinished (global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> p0, int p1, string p2)
		{
			if (id_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_ == IntPtr.Zero)
				id_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onGeoFenceCreateFinished", "(Ljava/util/List;ILjava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.GeoFence>.ToLocalJniHandle (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGeoFenceCreateFinished_Ljava_util_List_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.amap.api.fence.GeoFenceListener.onGeoFenceCreateFinished
	public partial class GeoFenceEventArgs : global::System.EventArgs {

		public GeoFenceEventArgs (global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> p0, int p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> p0;
		public global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amap/api/fence/GeoFenceListenerImplementor")]
	internal sealed partial class IGeoFenceListenerImplementor : global::Java.Lang.Object, IGeoFenceListener {

		object sender;

		public IGeoFenceListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amap/api/fence/GeoFenceListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<GeoFenceEventArgs> Handler;
#pragma warning restore 0649

		public void OnGeoFenceCreateFinished (global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> p0, int p1, string p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new GeoFenceEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IGeoFenceListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
