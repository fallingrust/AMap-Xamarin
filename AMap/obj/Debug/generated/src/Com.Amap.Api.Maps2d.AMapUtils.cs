using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/AMapUtils", DoNotGenerateAcw=true)]
	public partial class AMapUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='BUS_COMFORT']"
		[Register ("BUS_COMFORT")]
		public const int BusComfort = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='BUS_MONEY_LITTLE']"
		[Register ("BUS_MONEY_LITTLE")]
		public const int BusMoneyLittle = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='BUS_NO_SUBWAY']"
		[Register ("BUS_NO_SUBWAY")]
		public const int BusNoSubway = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='BUS_TIME_FIRST']"
		[Register ("BUS_TIME_FIRST")]
		public const int BusTimeFirst = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='BUS_TRANSFER_LITTLE']"
		[Register ("BUS_TRANSFER_LITTLE")]
		public const int BusTransferLittle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='BUS_WALK_LITTLE']"
		[Register ("BUS_WALK_LITTLE")]
		public const int BusWalkLittle = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_AVOID_CONGESTION']"
		[Register ("DRIVING_AVOID_CONGESTION")]
		public const int DrivingAvoidCongestion = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_DEFAULT']"
		[Register ("DRIVING_DEFAULT")]
		public const int DrivingDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_NO_HIGHWAY']"
		[Register ("DRIVING_NO_HIGHWAY")]
		public const int DrivingNoHighway = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_NO_HIGHWAY_AVOID_CONGESTION']"
		[Register ("DRIVING_NO_HIGHWAY_AVOID_CONGESTION")]
		public const int DrivingNoHighwayAvoidCongestion = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_NO_HIGHWAY_AVOID_SHORT_MONEY']"
		[Register ("DRIVING_NO_HIGHWAY_AVOID_SHORT_MONEY")]
		public const int DrivingNoHighwayAvoidShortMoney = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_NO_HIGHWAY_SAVE_MONEY_AVOID_CONGESTION']"
		[Register ("DRIVING_NO_HIGHWAY_SAVE_MONEY_AVOID_CONGESTION")]
		public const int DrivingNoHighwaySaveMoneyAvoidCongestion = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_SAVE_MONEY']"
		[Register ("DRIVING_SAVE_MONEY")]
		public const int DrivingSaveMoney = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_SAVE_MONEY_AVOID_CONGESTION']"
		[Register ("DRIVING_SAVE_MONEY_AVOID_CONGESTION")]
		public const int DrivingSaveMoneyAvoidCongestion = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/field[@name='DRIVING_SHORT_DISTANCE']"
		[Register ("DRIVING_SHORT_DISTANCE")]
		public const int DrivingShortDistance = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/AMapUtils", typeof (AMapUtils));
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

		protected AMapUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/constructor[@name='AMapUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AMapUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='calculateArea' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.LatLng'] and parameter[2][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("calculateArea", "(Lcom/amap/api/maps2d/model/LatLng;Lcom/amap/api/maps2d/model/LatLng;)F", "")]
		public static unsafe float CalculateArea (global::Com.Amap.Api.Maps2d.Model.LatLng p0, global::Com.Amap.Api.Maps2d.Model.LatLng p1)
		{
			const string __id = "calculateArea.(Lcom/amap/api/maps2d/model/LatLng;Lcom/amap/api/maps2d/model/LatLng;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='calculateLineDistance' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.LatLng'] and parameter[2][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("calculateLineDistance", "(Lcom/amap/api/maps2d/model/LatLng;Lcom/amap/api/maps2d/model/LatLng;)F", "")]
		public static unsafe float CalculateLineDistance (global::Com.Amap.Api.Maps2d.Model.LatLng p0, global::Com.Amap.Api.Maps2d.Model.LatLng p1)
		{
			const string __id = "calculateLineDistance.(Lcom/amap/api/maps2d/model/LatLng;Lcom/amap/api/maps2d/model/LatLng;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='getLatestAMapApp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLatestAMapApp", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetLatestAMapApp (global::Android.Content.Context p0)
		{
			const string __id = "getLatestAMapApp.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='openAMapDrivingRoute' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.RoutePara'] and parameter[2][@type='android.content.Context']]"
		[Register ("openAMapDrivingRoute", "(Lcom/amap/api/maps2d/model/RoutePara;Landroid/content/Context;)V", "")]
		public static unsafe void OpenAMapDrivingRoute (global::Com.Amap.Api.Maps2d.Model.RoutePara p0, global::Android.Content.Context p1)
		{
			const string __id = "openAMapDrivingRoute.(Lcom/amap/api/maps2d/model/RoutePara;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='openAMapNavi' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.NaviPara'] and parameter[2][@type='android.content.Context']]"
		[Register ("openAMapNavi", "(Lcom/amap/api/maps2d/model/NaviPara;Landroid/content/Context;)V", "")]
		public static unsafe void OpenAMapNavi (global::Com.Amap.Api.Maps2d.Model.NaviPara p0, global::Android.Content.Context p1)
		{
			const string __id = "openAMapNavi.(Lcom/amap/api/maps2d/model/NaviPara;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='openAMapPoiNearbySearch' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.PoiPara'] and parameter[2][@type='android.content.Context']]"
		[Register ("openAMapPoiNearbySearch", "(Lcom/amap/api/maps2d/model/PoiPara;Landroid/content/Context;)V", "")]
		public static unsafe void OpenAMapPoiNearbySearch (global::Com.Amap.Api.Maps2d.Model.PoiPara p0, global::Android.Content.Context p1)
		{
			const string __id = "openAMapPoiNearbySearch.(Lcom/amap/api/maps2d/model/PoiPara;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='openAMapTransitRoute' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.RoutePara'] and parameter[2][@type='android.content.Context']]"
		[Register ("openAMapTransitRoute", "(Lcom/amap/api/maps2d/model/RoutePara;Landroid/content/Context;)V", "")]
		public static unsafe void OpenAMapTransitRoute (global::Com.Amap.Api.Maps2d.Model.RoutePara p0, global::Android.Content.Context p1)
		{
			const string __id = "openAMapTransitRoute.(Lcom/amap/api/maps2d/model/RoutePara;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='AMapUtils']/method[@name='openAMapWalkingRoute' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.RoutePara'] and parameter[2][@type='android.content.Context']]"
		[Register ("openAMapWalkingRoute", "(Lcom/amap/api/maps2d/model/RoutePara;Landroid/content/Context;)V", "")]
		public static unsafe void OpenAMapWalkingRoute (global::Com.Amap.Api.Maps2d.Model.RoutePara p0, global::Android.Content.Context p1)
		{
			const string __id = "openAMapWalkingRoute.(Lcom/amap/api/maps2d/model/RoutePara;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
