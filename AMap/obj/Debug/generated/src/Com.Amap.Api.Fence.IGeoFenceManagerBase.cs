using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Fence {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']"
	[Register ("com/amap/api/fence/GeoFenceManagerBase", "", "Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker")]
	public partial interface IGeoFenceManagerBase : IJavaObject {

		global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> AllGeoFence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='getAllGeoFence' and count(parameter)=0]"
			[Register ("getAllGeoFence", "()Ljava/util/List;", "GetGetAllGeoFenceHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")] get;
		}

		bool IsPause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='isPause' and count(parameter)=0]"
			[Register ("isPause", "()Z", "GetIsPauseHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='addDistrictGeoFence' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addDistrictGeoFence", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void AddDistrictGeoFence (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='addKeywordGeoFence' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("addKeywordGeoFence", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "GetAddKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void AddKeywordGeoFence (string p0, string p1, string p2, int p3, string p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='addNearbyGeoFence' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.amap.api.location.DPoint'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register ("addNearbyGeoFence", "(Ljava/lang/String;Ljava/lang/String;Lcom/amap/api/location/DPoint;FILjava/lang/String;)V", "GetAddNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void AddNearbyGeoFence (string p0, string p1, global::Com.Amap.Api.Location.DPoint p2, float p3, int p4, string p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='addPolygonGeoFence' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.amap.api.location.DPoint&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("addPolygonGeoFence", "(Ljava/util/List;Ljava/lang/String;)V", "GetAddPolygonGeoFence_Ljava_util_List_Ljava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void AddPolygonGeoFence (global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint> p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='addRoundGeoFence' and count(parameter)=3 and parameter[1][@type='com.amap.api.location.DPoint'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.String']]"
		[Register ("addRoundGeoFence", "(Lcom/amap/api/location/DPoint;FLjava/lang/String;)V", "GetAddRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void AddRoundGeoFence (global::Com.Amap.Api.Location.DPoint p0, float p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='createPendingIntent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createPendingIntent", "(Ljava/lang/String;)Landroid/app/PendingIntent;", "GetCreatePendingIntent_Ljava_lang_String_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		global::Android.App.PendingIntent CreatePendingIntent (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='pauseGeoFence' and count(parameter)=0]"
		[Register ("pauseGeoFence", "()V", "GetPauseGeoFenceHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void PauseGeoFence ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='removeGeoFence' and count(parameter)=0]"
		[Register ("removeGeoFence", "()V", "GetRemoveGeoFenceHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void RemoveGeoFence ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='removeGeoFence' and count(parameter)=1 and parameter[1][@type='com.amap.api.fence.GeoFence']]"
		[Register ("removeGeoFence", "(Lcom/amap/api/fence/GeoFence;)Z", "GetRemoveGeoFence_Lcom_amap_api_fence_GeoFence_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		bool RemoveGeoFence (global::Com.Amap.Api.Fence.GeoFence p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='resumeGeoFence' and count(parameter)=0]"
		[Register ("resumeGeoFence", "()V", "GetResumeGeoFenceHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void ResumeGeoFence ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='setActivateAction' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setActivateAction", "(I)V", "GetSetActivateAction_IHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void SetActivateAction (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='setGeoFenceAble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setGeoFenceAble", "(Ljava/lang/String;Z)V", "GetSetGeoFenceAble_Ljava_lang_String_ZHandler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void SetGeoFenceAble (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.fence']/interface[@name='GeoFenceManagerBase']/method[@name='setGeoFenceListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.fence.GeoFenceListener']]"
		[Register ("setGeoFenceListener", "(Lcom/amap/api/fence/GeoFenceListener;)V", "GetSetGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_Handler:Com.Amap.Api.Fence.IGeoFenceManagerBaseInvoker, AMap")]
		void SetGeoFenceListener (global::Com.Amap.Api.Fence.IGeoFenceListener p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/fence/GeoFenceManagerBase", DoNotGenerateAcw=true)]
	internal class IGeoFenceManagerBaseInvoker : global::Java.Lang.Object, IGeoFenceManagerBase {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/fence/GeoFenceManagerBase", typeof (IGeoFenceManagerBaseInvoker));

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

		public static IGeoFenceManagerBase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeoFenceManagerBase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.fence.GeoFenceManagerBase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeoFenceManagerBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.GeoFence>.ToLocalJniHandle (__this.AllGeoFence);
		}
#pragma warning restore 0169

		IntPtr id_getAllGeoFence;
		public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Fence.GeoFence> AllGeoFence {
			get {
				if (id_getAllGeoFence == IntPtr.Zero)
					id_getAllGeoFence = JNIEnv.GetMethodID (class_ref, "getAllGeoFence", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amap.Api.Fence.GeoFence>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllGeoFence), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPause;
		}
#pragma warning restore 0169

		IntPtr id_isPause;
		public unsafe bool IsPause {
			get {
				if (id_isPause == IntPtr.Zero)
					id_isPause = JNIEnv.GetMethodID (class_ref, "isPause", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPause);
			}
		}

		static Delegate cb_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_);
			return cb_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddDistrictGeoFence (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void AddDistrictGeoFence (string p0, string p1)
		{
			if (id_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addDistrictGeoFence", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addDistrictGeoFence_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_);
			return cb_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_AddKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.AddKeywordGeoFence (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		public unsafe void AddKeywordGeoFence (string p0, string p1, string p2, int p3, string p4)
		{
			if (id_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addKeywordGeoFence", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addKeywordGeoFence_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_Handler ()
		{
			if (cb_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ == null)
				cb_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, int, IntPtr>) n_AddNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_);
			return cb_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_;
		}

		static void n_AddNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, int p4, IntPtr native_p5)
		{
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.DPoint p2 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.AddNearbyGeoFence (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_;
		public unsafe void AddNearbyGeoFence (string p0, string p1, global::Com.Amap.Api.Location.DPoint p2, float p3, int p4, string p5)
		{
			if (id_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ == IntPtr.Zero)
				id_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addNearbyGeoFence", "(Ljava/lang/String;Ljava/lang/String;Lcom/amap/api/location/DPoint;FILjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNearbyGeoFence_Ljava_lang_String_Ljava_lang_String_Lcom_amap_api_location_DPoint_FILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p5);
		}

		static Delegate cb_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPolygonGeoFence_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_ == null)
				cb_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolygonGeoFence_Ljava_util_List_Ljava_lang_String_);
			return cb_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_;
		}

		static void n_AddPolygonGeoFence_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddPolygonGeoFence (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_;
		public unsafe void AddPolygonGeoFence (global::System.Collections.Generic.IList<global::Com.Amap.Api.Location.DPoint> p0, string p1)
		{
			if (id_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPolygonGeoFence", "(Ljava/util/List;Ljava/lang/String;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amap.Api.Location.DPoint>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPolygonGeoFence_Ljava_util_List_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_Handler ()
		{
			if (cb_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ == null)
				cb_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_AddRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_);
			return cb_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_;
		}

		static void n_AddRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2)
		{
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.DPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddRoundGeoFence (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_;
		public unsafe void AddRoundGeoFence (global::Com.Amap.Api.Location.DPoint p0, float p1, string p2)
		{
			if (id_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ == IntPtr.Zero)
				id_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addRoundGeoFence", "(Lcom/amap/api/location/DPoint;FLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRoundGeoFence_Lcom_amap_api_location_DPoint_FLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePendingIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createPendingIntent_Ljava_lang_String_;
		public unsafe global::Android.App.PendingIntent CreatePendingIntent (string p0)
		{
			if (id_createPendingIntent_Ljava_lang_String_ == IntPtr.Zero)
				id_createPendingIntent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createPendingIntent", "(Ljava/lang/String;)Landroid/app/PendingIntent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.App.PendingIntent __ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPendingIntent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseGeoFence ();
		}
#pragma warning restore 0169

		IntPtr id_pauseGeoFence;
		public unsafe void PauseGeoFence ()
		{
			if (id_pauseGeoFence == IntPtr.Zero)
				id_pauseGeoFence = JNIEnv.GetMethodID (class_ref, "pauseGeoFence", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseGeoFence);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveGeoFence ();
		}
#pragma warning restore 0169

		IntPtr id_removeGeoFence;
		public unsafe void RemoveGeoFence ()
		{
			if (id_removeGeoFence == IntPtr.Zero)
				id_removeGeoFence = JNIEnv.GetMethodID (class_ref, "removeGeoFence", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeGeoFence);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Fence.GeoFence p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.GeoFence> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveGeoFence (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeGeoFence_Lcom_amap_api_fence_GeoFence_;
		public unsafe bool RemoveGeoFence (global::Com.Amap.Api.Fence.GeoFence p0)
		{
			if (id_removeGeoFence_Lcom_amap_api_fence_GeoFence_ == IntPtr.Zero)
				id_removeGeoFence_Lcom_amap_api_fence_GeoFence_ = JNIEnv.GetMethodID (class_ref, "removeGeoFence", "(Lcom/amap/api/fence/GeoFence;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeGeoFence_Lcom_amap_api_fence_GeoFence_, __args);
			return __ret;
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeGeoFence ();
		}
#pragma warning restore 0169

		IntPtr id_resumeGeoFence;
		public unsafe void ResumeGeoFence ()
		{
			if (id_resumeGeoFence == IntPtr.Zero)
				id_resumeGeoFence = JNIEnv.GetMethodID (class_ref, "resumeGeoFence", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeGeoFence);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActivateAction (p0);
		}
#pragma warning restore 0169

		IntPtr id_setActivateAction_I;
		public unsafe void SetActivateAction (int p0)
		{
			if (id_setActivateAction_I == IntPtr.Zero)
				id_setActivateAction_I = JNIEnv.GetMethodID (class_ref, "setActivateAction", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivateAction_I, __args);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGeoFenceAble (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setGeoFenceAble_Ljava_lang_String_Z;
		public unsafe void SetGeoFenceAble (string p0, bool p1)
		{
			if (id_setGeoFenceAble_Ljava_lang_String_Z == IntPtr.Zero)
				id_setGeoFenceAble_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setGeoFenceAble", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGeoFenceAble_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Amap.Api.Fence.IGeoFenceManagerBase __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceManagerBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Fence.IGeoFenceListener p0 = (global::Com.Amap.Api.Fence.IGeoFenceListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Fence.IGeoFenceListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGeoFenceListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_;
		public unsafe void SetGeoFenceListener (global::Com.Amap.Api.Fence.IGeoFenceListener p0)
		{
			if (id_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_ == IntPtr.Zero)
				id_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_ = JNIEnv.GetMethodID (class_ref, "setGeoFenceListener", "(Lcom/amap/api/fence/GeoFenceListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGeoFenceListener_Lcom_amap_api_fence_GeoFenceListener_, __args);
		}

	}

}
