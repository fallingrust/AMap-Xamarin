using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/BitmapDescriptorFactory", DoNotGenerateAcw=true)]
	public sealed partial class BitmapDescriptorFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_AZURE']"
		[Register ("HUE_AZURE")]
		public const float HueAzure = (float) 210;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_BLUE']"
		[Register ("HUE_BLUE")]
		public const float HueBlue = (float) 240;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_CYAN']"
		[Register ("HUE_CYAN")]
		public const float HueCyan = (float) 180;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_GREEN']"
		[Register ("HUE_GREEN")]
		public const float HueGreen = (float) 120;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_MAGENTA']"
		[Register ("HUE_MAGENTA")]
		public const float HueMagenta = (float) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_ORANGE']"
		[Register ("HUE_ORANGE")]
		public const float HueOrange = (float) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_RED']"
		[Register ("HUE_RED")]
		public const float HueRed = (float) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_ROSE']"
		[Register ("HUE_ROSE")]
		public const float HueRose = (float) 330;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_VIOLET']"
		[Register ("HUE_VIOLET")]
		public const float HueViolet = (float) 270;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/field[@name='HUE_YELLOW']"
		[Register ("HUE_YELLOW")]
		public const float HueYellow = (float) 60;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/BitmapDescriptorFactory", typeof (BitmapDescriptorFactory));
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

		internal BitmapDescriptorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/constructor[@name='BitmapDescriptorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapDescriptorFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='defaultMarker' and count(parameter)=0]"
		[Register ("defaultMarker", "()Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor DefaultMarker ()
		{
			const string __id = "defaultMarker.()Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='defaultMarker' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("defaultMarker", "(F)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor DefaultMarker (float p0)
		{
			const string __id = "defaultMarker.(F)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor FromAsset (string p0)
		{
			const string __id = "fromAsset.(Ljava/lang/String;)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor FromBitmap (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "fromBitmap.(Landroid/graphics/Bitmap;)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor FromFile (string p0)
		{
			const string __id = "fromFile.(Ljava/lang/String;)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor FromPath (string p0)
		{
			const string __id = "fromPath.(Ljava/lang/String;)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor FromResource (int p0)
		{
			const string __id = "fromResource.(I)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("fromView", "(Landroid/view/View;)Lcom/amap/api/maps2d/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor FromView (global::Android.Views.View p0)
		{
			const string __id = "fromView.(Landroid/view/View;)Lcom/amap/api/maps2d/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
