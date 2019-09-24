using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']"
	[global::Android.Runtime.Register ("com/amap/api/interfaces/MapCameraMessage", DoNotGenerateAcw=true)]
	public abstract partial class MapCameraMessage : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='amount']"
		[Register ("amount")]
		public float Amount {
			get {
				const string __id = "amount.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "amount.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='bounds']"
		[Register ("bounds")]
		public global::Com.Amap.Api.Maps2d.Model.LatLngBounds Bounds {
			get {
				const string __id = "bounds.Lcom/amap/api/maps2d/model/LatLngBounds;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLngBounds> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bounds.Lcom/amap/api/maps2d/model/LatLngBounds;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='cameraPosition']"
		[Register ("cameraPosition")]
		public global::Com.Amap.Api.Maps2d.Model.CameraPosition CameraPosition {
			get {
				const string __id = "cameraPosition.Lcom/amap/api/maps2d/model/CameraPosition;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cameraPosition.Lcom/amap/api/maps2d/model/CameraPosition;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='focus']"
		[Register ("focus")]
		public global::Android.Graphics.Point Focus {
			get {
				const string __id = "focus.Landroid/graphics/Point;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "focus.Landroid/graphics/Point;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='isChangeFinished']"
		[Register ("isChangeFinished")]
		public bool IsChangeFinished {
			get {
				const string __id = "isChangeFinished.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isChangeFinished.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='nowType']"
		[Register ("nowType")]
		public global::Com.Amap.Api.Interfaces.MapCameraMessage.Type NowType {
			get {
				const string __id = "nowType.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nowType.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='padding']"
		[Register ("padding")]
		public int Padding {
			get {
				const string __id = "padding.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "padding.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				const string __id = "width.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "width.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='xPixel']"
		[Register ("xPixel")]
		public float XPixel {
			get {
				const string __id = "xPixel.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "xPixel.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='yPixel']"
		[Register ("yPixel")]
		public float YPixel {
			get {
				const string __id = "yPixel.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "yPixel.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/field[@name='zoom']"
		[Register ("zoom")]
		public float Zoom {
			get {
				const string __id = "zoom.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "zoom.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']"
		[global::Android.Runtime.Register ("com/amap/api/interfaces/MapCameraMessage$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='changeCenter']"
			[Register ("changeCenter")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ChangeCenter {
				get {
					const string __id = "changeCenter.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='changeGeoCenterZoom']"
			[Register ("changeGeoCenterZoom")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ChangeGeoCenterZoom {
				get {
					const string __id = "changeGeoCenterZoom.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='changeGeoCenterZoomTiltBearing']"
			[Register ("changeGeoCenterZoomTiltBearing")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ChangeGeoCenterZoomTiltBearing {
				get {
					const string __id = "changeGeoCenterZoomTiltBearing.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='newCameraPosition']"
			[Register ("newCameraPosition")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type NewCameraPosition {
				get {
					const string __id = "newCameraPosition.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='newLatLngBounds']"
			[Register ("newLatLngBounds")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type NewLatLngBounds {
				get {
					const string __id = "newLatLngBounds.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='newLatLngBoundsWithSize']"
			[Register ("newLatLngBoundsWithSize")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type NewLatLngBoundsWithSize {
				get {
					const string __id = "newLatLngBoundsWithSize.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='none']"
			[Register ("none")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type None {
				get {
					const string __id = "none.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='scrollBy']"
			[Register ("scrollBy")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ScrollBy {
				get {
					const string __id = "scrollBy.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='zoomBy']"
			[Register ("zoomBy")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ZoomBy {
				get {
					const string __id = "zoomBy.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='zoomIn']"
			[Register ("zoomIn")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ZoomIn {
				get {
					const string __id = "zoomIn.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='zoomOut']"
			[Register ("zoomOut")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ZoomOut {
				get {
					const string __id = "zoomOut.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/field[@name='zoomTo']"
			[Register ("zoomTo")]
			public static global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ZoomTo {
				get {
					const string __id = "zoomTo.Lcom/amap/api/interfaces/MapCameraMessage$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/interfaces/MapCameraMessage$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/amap/api/interfaces/MapCameraMessage$Type;", "")]
			public static unsafe global::Com.Amap.Api.Interfaces.MapCameraMessage.Type ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/amap/api/interfaces/MapCameraMessage$Type;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.MapCameraMessage.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/amap/api/interfaces/MapCameraMessage$Type;", "")]
			public static unsafe global::Com.Amap.Api.Interfaces.MapCameraMessage.Type[] Values ()
			{
				const string __id = "values.()[Lcom/amap/api/interfaces/MapCameraMessage$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Amap.Api.Interfaces.MapCameraMessage.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Amap.Api.Interfaces.MapCameraMessage.Type));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/interfaces/MapCameraMessage", typeof (MapCameraMessage));
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

		protected MapCameraMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.interfaces']/class[@name='MapCameraMessage']/constructor[@name='MapCameraMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapCameraMessage ()
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

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/MapCameraMessage", DoNotGenerateAcw=true)]
	internal partial class MapCameraMessageInvoker : MapCameraMessage {

		public MapCameraMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/MapCameraMessage", typeof (MapCameraMessageInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
