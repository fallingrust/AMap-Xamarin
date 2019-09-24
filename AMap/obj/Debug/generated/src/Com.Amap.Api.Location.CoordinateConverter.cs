using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']"
	[global::Android.Runtime.Register ("com/amap/api/location/CoordinateConverter", DoNotGenerateAcw=true)]
	public partial class CoordinateConverter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']"
		[global::Android.Runtime.Register ("com/amap/api/location/CoordinateConverter$CoordType", DoNotGenerateAcw=true)]
		public sealed partial class CoordType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='ALIYUN']"
			[Register ("ALIYUN")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Aliyun {
				get {
					const string __id = "ALIYUN.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='BAIDU']"
			[Register ("BAIDU")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Baidu {
				get {
					const string __id = "BAIDU.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='GOOGLE']"
			[Register ("GOOGLE")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Google {
				get {
					const string __id = "GOOGLE.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='GPS']"
			[Register ("GPS")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Gps {
				get {
					const string __id = "GPS.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='MAPABC']"
			[Register ("MAPABC")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Mapabc {
				get {
					const string __id = "MAPABC.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='MAPBAR']"
			[Register ("MAPBAR")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Mapbar {
				get {
					const string __id = "MAPBAR.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/field[@name='SOSOMAP']"
			[Register ("SOSOMAP")]
			public static global::Com.Amap.Api.Location.CoordinateConverter.CoordType Sosomap {
				get {
					const string __id = "SOSOMAP.Lcom/amap/api/location/CoordinateConverter$CoordType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/CoordinateConverter$CoordType", typeof (CoordType));
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

			internal CoordType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amap/api/location/CoordinateConverter$CoordType;", "")]
			public static unsafe global::Com.Amap.Api.Location.CoordinateConverter.CoordType ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/amap/api/location/CoordinateConverter$CoordType;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter.CoordType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amap/api/location/CoordinateConverter$CoordType;", "")]
			public static unsafe global::Com.Amap.Api.Location.CoordinateConverter.CoordType[] Values ()
			{
				const string __id = "values.()[Lcom/amap/api/location/CoordinateConverter$CoordType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Amap.Api.Location.CoordinateConverter.CoordType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Location.CoordinateConverter.CoordType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/location/CoordinateConverter", typeof (CoordinateConverter));
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

		protected CoordinateConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']/constructor[@name='CoordinateConverter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CoordinateConverter (global::Android.Content.Context p0)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']/method[@name='calculateLineDistance' and count(parameter)=2 and parameter[1][@type='com.amap.api.location.DPoint'] and parameter[2][@type='com.amap.api.location.DPoint']]"
		[Register ("calculateLineDistance", "(Lcom/amap/api/location/DPoint;Lcom/amap/api/location/DPoint;)F", "")]
		public static unsafe float CalculateLineDistance (global::Com.Amap.Api.Location.DPoint p0, global::Com.Amap.Api.Location.DPoint p1)
		{
			const string __id = "calculateLineDistance.(Lcom/amap/api/location/DPoint;Lcom/amap/api/location/DPoint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_convert;
#pragma warning disable 0169
		static Delegate GetConvertHandler ()
		{
			if (cb_convert == null)
				cb_convert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Convert);
			return cb_convert;
		}

		static IntPtr n_Convert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Location.CoordinateConverter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Convert ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']/method[@name='convert' and count(parameter)=0]"
		[Register ("convert", "()Lcom/amap/api/location/DPoint;", "GetConvertHandler")]
		public virtual unsafe global::Com.Amap.Api.Location.DPoint Convert ()
		{
			const string __id = "convert.()Lcom/amap/api/location/DPoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_coord_Lcom_amap_api_location_DPoint_;
#pragma warning disable 0169
		static Delegate GetCoord_Lcom_amap_api_location_DPoint_Handler ()
		{
			if (cb_coord_Lcom_amap_api_location_DPoint_ == null)
				cb_coord_Lcom_amap_api_location_DPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Coord_Lcom_amap_api_location_DPoint_);
			return cb_coord_Lcom_amap_api_location_DPoint_;
		}

		static IntPtr n_Coord_Lcom_amap_api_location_DPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.CoordinateConverter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.DPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.DPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Coord (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']/method[@name='coord' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.DPoint']]"
		[Register ("coord", "(Lcom/amap/api/location/DPoint;)Lcom/amap/api/location/CoordinateConverter;", "GetCoord_Lcom_amap_api_location_DPoint_Handler")]
		public virtual unsafe global::Com.Amap.Api.Location.CoordinateConverter Coord (global::Com.Amap.Api.Location.DPoint p0)
		{
			const string __id = "coord.(Lcom/amap/api/location/DPoint;)Lcom/amap/api/location/CoordinateConverter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_from_Lcom_amap_api_location_CoordinateConverter_CoordType_;
#pragma warning disable 0169
		static Delegate GetFrom_Lcom_amap_api_location_CoordinateConverter_CoordType_Handler ()
		{
			if (cb_from_Lcom_amap_api_location_CoordinateConverter_CoordType_ == null)
				cb_from_Lcom_amap_api_location_CoordinateConverter_CoordType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_From_Lcom_amap_api_location_CoordinateConverter_CoordType_);
			return cb_from_Lcom_amap_api_location_CoordinateConverter_CoordType_;
		}

		static IntPtr n_From_Lcom_amap_api_location_CoordinateConverter_CoordType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Location.CoordinateConverter __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Location.CoordinateConverter.CoordType p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter.CoordType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']/method[@name='from' and count(parameter)=1 and parameter[1][@type='com.amap.api.location.CoordinateConverter.CoordType']]"
		[Register ("from", "(Lcom/amap/api/location/CoordinateConverter$CoordType;)Lcom/amap/api/location/CoordinateConverter;", "GetFrom_Lcom_amap_api_location_CoordinateConverter_CoordType_Handler")]
		public virtual unsafe global::Com.Amap.Api.Location.CoordinateConverter From (global::Com.Amap.Api.Location.CoordinateConverter.CoordType p0)
		{
			const string __id = "from.(Lcom/amap/api/location/CoordinateConverter$CoordType;)Lcom/amap/api/location/CoordinateConverter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Location.CoordinateConverter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.location']/class[@name='CoordinateConverter']/method[@name='isAMapDataAvailable' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("isAMapDataAvailable", "(DD)Z", "")]
		public static unsafe bool IsAMapDataAvailable (double p0, double p1)
		{
			const string __id = "isAMapDataAvailable.(DD)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
