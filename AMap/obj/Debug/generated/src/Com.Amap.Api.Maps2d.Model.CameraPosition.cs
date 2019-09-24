using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/CameraPosition", DoNotGenerateAcw=true)]
	public sealed partial class CameraPosition : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/field[@name='bearing']"
		[Register ("bearing")]
		public float Bearing {
			get {
				const string __id = "bearing.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "bearing.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/field[@name='isAbroad']"
		[Register ("isAbroad")]
		public bool IsAbroad {
			get {
				const string __id = "isAbroad.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isAbroad.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/field[@name='target']"
		[Register ("target")]
		public global::Com.Amap.Api.Maps2d.Model.LatLng Target {
			get {
				const string __id = "target.Lcom/amap/api/maps2d/model/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "target.Lcom/amap/api/maps2d/model/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/field[@name='tilt']"
		[Register ("tilt")]
		public float Tilt {
			get {
				const string __id = "tilt.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "tilt.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/field[@name='zoom']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']"
		[global::Android.Runtime.Register ("com/amap/api/maps2d/model/CameraPosition$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/CameraPosition$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CameraPosition']]"
			[Register (".ctor", "(Lcom/amap/api/maps2d/model/CameraPosition;)V", "")]
			public unsafe Builder (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/amap/api/maps2d/model/CameraPosition;)V";

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/method[@name='bearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("bearing", "(F)Lcom/amap/api/maps2d/model/CameraPosition$Builder;", "")]
			public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder Bearing (float p0)
			{
				const string __id = "bearing.(F)Lcom/amap/api/maps2d/model/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/amap/api/maps2d/model/CameraPosition;", "")]
			public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition Build ()
			{
				const string __id = "build.()Lcom/amap/api/maps2d/model/CameraPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/method[@name='target' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("target", "(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/model/CameraPosition$Builder;", "")]
			public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder Target (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
			{
				const string __id = "target.(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/model/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/method[@name='tilt' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("tilt", "(F)Lcom/amap/api/maps2d/model/CameraPosition$Builder;", "")]
			public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder Tilt (float p0)
			{
				const string __id = "tilt.(F)Lcom/amap/api/maps2d/model/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition.Builder']/method[@name='zoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("zoom", "(F)Lcom/amap/api/maps2d/model/CameraPosition$Builder;", "")]
			public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder Zoom (float p0)
			{
				const string __id = "zoom.(F)Lcom/amap/api/maps2d/model/CameraPosition$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/CameraPosition", typeof (CameraPosition));
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

		internal CameraPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/constructor[@name='CameraPosition' and count(parameter)=4 and parameter[1][@type='com.amap.api.maps2d.model.LatLng'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(Lcom/amap/api/maps2d/model/LatLng;FFF)V", "")]
		public unsafe CameraPosition (global::Com.Amap.Api.Maps2d.Model.LatLng p0, float p1, float p2, float p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/amap/api/maps2d/model/LatLng;FFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/amap/api/maps2d/model/CameraPosition$Builder;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lcom/amap/api/maps2d/model/CameraPosition$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CameraPosition']]"
		[Register ("builder", "(Lcom/amap/api/maps2d/model/CameraPosition;)Lcom/amap/api/maps2d/model/CameraPosition$Builder;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder InvokeBuilder (global::Com.Amap.Api.Maps2d.Model.CameraPosition p0)
		{
			const string __id = "builder.(Lcom/amap/api/maps2d/model/CameraPosition;)Lcom/amap/api/maps2d/model/CameraPosition$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='fromLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("fromLatLngZoom", "(Lcom/amap/api/maps2d/model/LatLng;F)Lcom/amap/api/maps2d/model/CameraPosition;", "")]
		public static unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition FromLatLngZoom (global::Com.Amap.Api.Maps2d.Model.LatLng p0, float p1)
		{
			const string __id = "fromLatLngZoom.(Lcom/amap/api/maps2d/model/LatLng;F)Lcom/amap/api/maps2d/model/CameraPosition;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='CameraPosition']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
