using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/CameraUpdateFactory", DoNotGenerateAcw=true)]
	public sealed partial class CameraUpdateFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/CameraUpdateFactory", typeof (CameraUpdateFactory));
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

		internal CameraUpdateFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/constructor[@name='CameraUpdateFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CameraUpdateFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='changeLatLng' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("changeLatLng", "(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ChangeLatLng (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			const string __id = "changeLatLng.(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='newCameraPosition' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CameraPosition']]"
		[Register ("newCameraPosition", "(Lcom/amap/api/maps2d/model/CameraPosition;)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate NewCameraPosition (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
		{
			const string __id = "newCameraPosition.(Lcom/amap/api/maps2d/model/CameraPosition;)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='newLatLng' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("newLatLng", "(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate NewLatLng (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			const string __id = "newLatLng.(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.LatLngBounds'] and parameter[2][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/amap/api/maps2d/model/LatLngBounds;I)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate NewLatLngBounds (global::Com.Amap.Api.Maps2d.Model.LatLngBounds p0, int p1)
		{
			const string __id = "newLatLngBounds.(Lcom/amap/api/maps2d/model/LatLngBounds;I)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=4 and parameter[1][@type='com.amap.api.maps2d.model.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/amap/api/maps2d/model/LatLngBounds;III)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate NewLatLngBounds (global::Com.Amap.Api.Maps2d.Model.LatLngBounds p0, int p1, int p2, int p3)
		{
			const string __id = "newLatLngBounds.(Lcom/amap/api/maps2d/model/LatLngBounds;III)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='newLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("newLatLngZoom", "(Lcom/amap/api/maps2d/model/LatLng;F)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate NewLatLngZoom (global::Com.Amap.Api.Maps2d.Model.LatLng p0, float p1)
		{
			const string __id = "newLatLngZoom.(Lcom/amap/api/maps2d/model/LatLng;F)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("scrollBy", "(FF)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ScrollBy (float p0, float p1)
		{
			const string __id = "scrollBy.(FF)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='zoomBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomBy", "(F)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ZoomBy (float p0)
		{
			const string __id = "zoomBy.(F)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='zoomBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("zoomBy", "(FLandroid/graphics/Point;)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ZoomBy (float p0, global::Android.Graphics.Point p1)
		{
			const string __id = "zoomBy.(FLandroid/graphics/Point;)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ZoomIn ()
		{
			const string __id = "zoomIn.()Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ZoomOut ()
		{
			const string __id = "zoomOut.()Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='CameraUpdateFactory']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomTo", "(F)Lcom/amap/api/maps2d/CameraUpdate;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.CameraUpdate ZoomTo (float p0)
		{
			const string __id = "zoomTo.(F)Lcom/amap/api/maps2d/CameraUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
