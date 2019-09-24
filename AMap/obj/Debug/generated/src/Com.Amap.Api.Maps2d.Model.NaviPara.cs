using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/NaviPara", DoNotGenerateAcw=true)]
	public partial class NaviPara : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_AVOID_CONGESTION']"
		[Register ("DRIVING_AVOID_CONGESTION")]
		[Obsolete ("deprecated")]
		public const int DrivingAvoidCongestion = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_DEFAULT']"
		[Register ("DRIVING_DEFAULT")]
		[Obsolete ("deprecated")]
		public const int DrivingDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_NO_HIGHWAY']"
		[Register ("DRIVING_NO_HIGHWAY")]
		[Obsolete ("deprecated")]
		public const int DrivingNoHighway = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_NO_HIGHWAY_AVOID_CONGESTION']"
		[Register ("DRIVING_NO_HIGHWAY_AVOID_CONGESTION")]
		[Obsolete ("deprecated")]
		public const int DrivingNoHighwayAvoidCongestion = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_NO_HIGHWAY_AVOID_SHORT_MONEY']"
		[Register ("DRIVING_NO_HIGHWAY_AVOID_SHORT_MONEY")]
		[Obsolete ("deprecated")]
		public const int DrivingNoHighwayAvoidShortMoney = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_NO_HIGHWAY_SAVE_MONEY_AVOID_CONGESTION']"
		[Register ("DRIVING_NO_HIGHWAY_SAVE_MONEY_AVOID_CONGESTION")]
		[Obsolete ("deprecated")]
		public const int DrivingNoHighwaySaveMoneyAvoidCongestion = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_SAVE_MONEY']"
		[Register ("DRIVING_SAVE_MONEY")]
		[Obsolete ("deprecated")]
		public const int DrivingSaveMoney = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_SAVE_MONEY_AVOID_CONGESTION']"
		[Register ("DRIVING_SAVE_MONEY_AVOID_CONGESTION")]
		[Obsolete ("deprecated")]
		public const int DrivingSaveMoneyAvoidCongestion = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/field[@name='DRIVING_SHORT_DISTANCE']"
		[Register ("DRIVING_SHORT_DISTANCE")]
		[Obsolete ("deprecated")]
		public const int DrivingShortDistance = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/NaviPara", typeof (NaviPara));
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

		protected NaviPara (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/constructor[@name='NaviPara' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NaviPara ()
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

		static Delegate cb_getNaviStyle;
#pragma warning disable 0169
		static Delegate GetGetNaviStyleHandler ()
		{
			if (cb_getNaviStyle == null)
				cb_getNaviStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNaviStyle);
			return cb_getNaviStyle;
		}

		static int n_GetNaviStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.NaviPara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.NaviPara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NaviStyle;
		}
#pragma warning restore 0169

		static Delegate cb_setNaviStyle_I;
#pragma warning disable 0169
		static Delegate GetSetNaviStyle_IHandler ()
		{
			if (cb_setNaviStyle_I == null)
				cb_setNaviStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNaviStyle_I);
			return cb_setNaviStyle_I;
		}

		static void n_SetNaviStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.NaviPara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.NaviPara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NaviStyle = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int NaviStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/method[@name='getNaviStyle' and count(parameter)=0]"
			[Register ("getNaviStyle", "()I", "GetGetNaviStyleHandler")]
			get {
				const string __id = "getNaviStyle.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/method[@name='setNaviStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNaviStyle", "(I)V", "GetSetNaviStyle_IHandler")]
			set {
				const string __id = "setNaviStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetPoint;
#pragma warning disable 0169
		static Delegate GetGetTargetPointHandler ()
		{
			if (cb_getTargetPoint == null)
				cb_getTargetPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetPoint);
			return cb_getTargetPoint;
		}

		static IntPtr n_GetTargetPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.NaviPara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.NaviPara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetPoint);
		}
#pragma warning restore 0169

		static Delegate cb_setTargetPoint_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetTargetPoint_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_setTargetPoint_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_setTargetPoint_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTargetPoint_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_setTargetPoint_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static void n_SetTargetPoint_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.NaviPara __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.NaviPara> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TargetPoint = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.LatLng TargetPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/method[@name='getTargetPoint' and count(parameter)=0]"
			[Register ("getTargetPoint", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetTargetPointHandler")]
			get {
				const string __id = "getTargetPoint.()Lcom/amap/api/maps2d/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='NaviPara']/method[@name='setTargetPoint' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setTargetPoint", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetTargetPoint_Lcom_amap_api_maps2d_model_LatLng_Handler")]
			set {
				const string __id = "setTargetPoint.(Lcom/amap/api/maps2d/model/LatLng;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
