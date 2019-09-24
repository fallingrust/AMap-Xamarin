using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Fence {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']"
	[global::Android.Runtime.Register ("com/amap/api/fence/GeoFenceClient", DoNotGenerateAcw=true)]
	public partial class GeoFenceClient : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/field[@name='GEOFENCE_IN']"
		[Register ("GEOFENCE_IN")]
		public const int GeofenceIn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/field[@name='GEOFENCE_OUT']"
		[Register ("GEOFENCE_OUT")]
		public const int GeofenceOut = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/field[@name='GEOFENCE_STAYED']"
		[Register ("GEOFENCE_STAYED")]
		public const int GeofenceStayed = (int) 4;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/fence/GeoFenceClient", typeof (GeoFenceClient));
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

		protected GeoFenceClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/constructor[@name='GeoFenceClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GeoFenceClient (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

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

		static Delegate cb_getAllGeoFence;
#pragma warning disable 0169
		static Delegate GetGetAllGeoFenceHandler ()
		{
			if (cb_getAllGeoFence == null)
				cb_getAllGeoFence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllGeoFence);
			return cb_getAllGeoFence;
		}

		static IntPtr n_GetAllGeoFence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.GeoFence>.ToLocalJniHandle (__this.AllGeoFence);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> AllGeoFence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='getAllGeoFence' and count(parameter)=0]"
			[Register ("getAllGeoFence", "()Ljava/util/List;", "GetGetAllGeoFenceHandler")]
			get {
				const string __id = "getAllGeoFence.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.GeoFence>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPause;
#pragma warning disable 0169
		static Delegate GetIsPauseHandler ()
		{
			if (cb_isPause == null)
				cb_isPause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPause);
			return cb_isPause;
		}

		static bool n_IsPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPause;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='isPause' and count(parameter)=0]"
			[Register ("isPause", "()Z", "GetIsPauseHandler")]
			get {
				const string __id = "isPause.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_Handler ()
		{
			if (cb_addGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ == null)
				cb_addGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_AddGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_);
			return cb_addGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_;
		}

		static void n_AddGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.DPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddGeoFence (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='addGeoFence' and count(parameter)=3 and parameter[1][@type='com.amap.api.location.DPoint'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.String']]"
		[Register ("addGeoFence", "(Lcom/amap/api/location/DPoint;FLjava/lang/String;)V", "GetAddGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_Handler")]
		public virtual unsafe void AddGeoFence (global::Com.Amap.Api.Location.DPoint p0, float p1, string p2)
		{
			const string __id = "addGeoFence.(Lcom/amap/api/location/DPoint;FLjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGeoFence_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGeoFence_Ljava_lang_String_Ljava_lang_String_);
			return cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddGeoFence_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddGeoFence (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='addGeoFence' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addGeoFence", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddGeoFence_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddGeoFence (string p0, string p1)
		{
			const string __id = "addGeoFence.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_Handler ()
		{
			if (cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ == null)
				cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, int, IntPtr>) n_AddGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_);
			return cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_;
		}

		static void n_AddGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, int p4, IntPtr native_p5)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.DPoint p2 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.AddGeoFence (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='addGeoFence' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.amap.api.location.DPoint'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register ("addGeoFence", "(Ljava/lang/String;Ljava/lang/String;Lcom/amap/api/location/DPoint;FILjava/lang/String;)V", "GetAddGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_Handler")]
		public virtual unsafe void AddGeoFence (string p0, string p1, global::Com.Amap.Api.Location.DPoint p2, float p3, int p4, string p5)
		{
			const string __id = "addGeoFence.(Ljava/lang/String;Ljava/lang/String;Lcom/amap/api/location/DPoint;FILjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_);
			return cb_addGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_AddGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.AddGeoFence (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='addGeoFence' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("addGeoFence", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "GetAddGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe void AddGeoFence (string p0, string p1, string p2, int p3, string p4)
		{
			const string __id = "addGeoFence.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_addGeoFence_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddGeoFence_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_addGeoFence_Ljava_util_List_Ljava_lang_String_ == null)
				cb_addGeoFence_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGeoFence_Ljava_util_List_Ljava_lang_String_);
			return cb_addGeoFence_Ljava_util_List_Ljava_lang_String_;
		}

		static void n_AddGeoFence_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddGeoFence (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='addGeoFence' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.amap.api.location.DPoint&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("addGeoFence", "(Ljava/util/List;Ljava/lang/String;)V", "GetAddGeoFence_Ljava_util_List_Ljava_lang_String_Handler")]
		public virtual unsafe void AddGeoFence (global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint> p0, string p1)
		{
			const string __id = "addGeoFence.(Ljava/util/List;Ljava/lang/String;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_createPendingIntent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreatePendingIntent_Ljava_lang_String_Handler ()
		{
			if (cb_createPendingIntent_Ljava_lang_String_ == null)
				cb_createPendingIntent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePendingIntent_Ljava_lang_String_);
			return cb_createPendingIntent_Ljava_lang_String_;
		}

		static IntPtr n_CreatePendingIntent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePendingIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='createPendingIntent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createPendingIntent", "(Ljava/lang/String;)Landroid/app/PendingIntent;", "GetCreatePendingIntent_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.App.PendingIntent CreatePendingIntent (string p0)
		{
			const string __id = "createPendingIntent.(Ljava/lang/String;)Landroid/app/PendingIntent;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pauseGeoFence;
#pragma warning disable 0169
		static Delegate GetPauseGeoFenceHandler ()
		{
			if (cb_pauseGeoFence == null)
				cb_pauseGeoFence = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseGeoFence);
			return cb_pauseGeoFence;
		}

		static void n_PauseGeoFence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseGeoFence ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='pauseGeoFence' and count(parameter)=0]"
		[Register ("pauseGeoFence", "()V", "GetPauseGeoFenceHandler")]
		public virtual unsafe void PauseGeoFence ()
		{
			const string __id = "pauseGeoFence.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeGeoFence;
#pragma warning disable 0169
		static Delegate GetRemoveGeoFenceHandler ()
		{
			if (cb_removeGeoFence == null)
				cb_removeGeoFence = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveGeoFence);
			return cb_removeGeoFence;
		}

		static void n_RemoveGeoFence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGeoFence ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='removeGeoFence' and count(parameter)=0]"
		[Register ("removeGeoFence", "()V", "GetRemoveGeoFenceHandler")]
		public virtual unsafe void RemoveGeoFence ()
		{
			const string __id = "removeGeoFence.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeGeoFence_Lcom_amap_api_fence_GeoFence_;
#pragma warning disable 0169
		static Delegate GetRemoveGeoFence_Lcom_amap_api_fence_GeoFence_Handler ()
		{
			if (cb_removeGeoFence_Lcom_amap_api_fence_GeoFence_ == null)
				cb_removeGeoFence_Lcom_amap_api_fence_GeoFence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveGeoFence_Lcom_amap_api_fence_GeoFence_);
			return cb_removeGeoFence_Lcom_amap_api_fence_GeoFence_;
		}

		static bool n_RemoveGeoFence_Lcom_amap_api_fence_GeoFence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Fence.GeoFence p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveGeoFence (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='removeGeoFence' and count(parameter)=1 and parameter[1][@type='com.amap.api.fence.GeoFence']]"
		[Register ("removeGeoFence", "(Lcom/amap/api/fence/GeoFence;)Z", "GetRemoveGeoFence_Lcom_amap_api_fence_GeoFence_Handler")]
		public virtual unsafe bool RemoveGeoFence (global::Com.Amap.Api.Fence.GeoFence p0)
		{
			const string __id = "removeGeoFence.(Lcom/amap/api/fence/GeoFence;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resumeGeoFence;
#pragma warning disable 0169
		static Delegate GetResumeGeoFenceHandler ()
		{
			if (cb_resumeGeoFence == null)
				cb_resumeGeoFence = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeGeoFence);
			return cb_resumeGeoFence;
		}

		static void n_ResumeGeoFence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeGeoFence ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='resumeGeoFence' and count(parameter)=0]"
		[Register ("resumeGeoFence", "()V", "GetResumeGeoFenceHandler")]
		public virtual unsafe void ResumeGeoFence ()
		{
			const string __id = "resumeGeoFence.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setActivateAction_I;
#pragma warning disable 0169
		static Delegate GetSetActivateAction_IHandler ()
		{
			if (cb_setActivateAction_I == null)
				cb_setActivateAction_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActivateAction_I);
			return cb_setActivateAction_I;
		}

		static void n_SetActivateAction_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActivateAction (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='setActivateAction' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActivateAction", "(I)V", "GetSetActivateAction_IHandler")]
		public virtual unsafe void SetActivateAction (int p0)
		{
			const string __id = "setActivateAction.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setGeoFenceAble_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetGeoFenceAble_Ljava_lang_String_ZHandler ()
		{
			if (cb_setGeoFenceAble_Ljava_lang_String_Z == null)
				cb_setGeoFenceAble_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetGeoFenceAble_Ljava_lang_String_Z);
			return cb_setGeoFenceAble_Ljava_lang_String_Z;
		}

		static void n_SetGeoFenceAble_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGeoFenceAble (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='setGeoFenceAble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setGeoFenceAble", "(Ljava/lang/String;Z)V", "GetSetGeoFenceAble_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetGeoFenceAble (string p0, bool p1)
		{
			const string __id = "setGeoFenceAble.(Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_;
#pragma warning disable 0169
		static Delegate GetSetGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_Handler ()
		{
			if (cb_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_ == null)
				cb_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_);
			return cb_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_;
		}

		static void n_SetGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Fence.GeoFenceClient __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFenceClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Fence.IGeoFenceListener p0 = (global::Com.Amap.Api.Fence.IGeoFenceListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGeoFenceListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/class[@name='GeoFenceClient']/method[@name='setGeoFenceListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.fence.GeoFenceListener']]"
		[Register ("setGeoFenceListener", "(Lcom/amap/api/fence/GeoFenceListener;)V", "GetSetGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_Handler")]
		public virtual unsafe void SetGeoFenceListener (global::Com.Amap.Api.Fence.IGeoFenceListener p0)
		{
			const string __id = "setGeoFenceListener.(Lcom/amap/api/fence/GeoFenceListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Amap.Api.Fence.IGeoFenceListener"
		public event EventHandler<global::Com.Amap.Api.Fence.GeoFenceEventArgs> GeoFence {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Amap.Api.Fence.IGeoFenceListener, global::Com.Amap.Api.Fence.IGeoFenceListenerImplementor>(
						ref weak_implementor_SetGeoFenceListener,
						__CreateIGeoFenceListenerImplementor,
						SetGeoFenceListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Amap.Api.Fence.IGeoFenceListener, global::Com.Amap.Api.Fence.IGeoFenceListenerImplementor>(
						ref weak_implementor_SetGeoFenceListener,
						global::Com.Amap.Api.Fence.IGeoFenceListenerImplementor.__IsEmpty,
						__v => SetGeoFenceListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetGeoFenceListener;

		global::Com.Amap.Api.Fence.IGeoFenceListenerImplementor __CreateIGeoFenceListenerImplementor ()
		{
			return new global::Com.Amap.Api.Fence.IGeoFenceListenerImplementor (this);
		}
#endregion
	}
}
