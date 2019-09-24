using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/TileOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class TileOverlayOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/TileOverlayOptions", typeof (TileOverlayOptions));
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

		internal TileOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/constructor[@name='TileOverlayOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TileOverlayOptions ()
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

		public unsafe string DiskCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getDiskCacheDir' and count(parameter)=0]"
			[Register ("getDiskCacheDir", "()Ljava/lang/String;", "GetGetDiskCacheDirHandler")]
			get {
				const string __id = "getDiskCacheDir.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool DiskCacheEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getDiskCacheEnabled' and count(parameter)=0]"
			[Register ("getDiskCacheEnabled", "()Z", "GetGetDiskCacheEnabledHandler")]
			get {
				const string __id = "getDiskCacheEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int DiskCacheSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getDiskCacheSize' and count(parameter)=0]"
			[Register ("getDiskCacheSize", "()I", "GetGetDiskCacheSizeHandler")]
			get {
				const string __id = "getDiskCacheSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int MemCacheSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getMemCacheSize' and count(parameter)=0]"
			[Register ("getMemCacheSize", "()I", "GetGetMemCacheSizeHandler")]
			get {
				const string __id = "getMemCacheSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool MemoryCacheEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getMemoryCacheEnabled' and count(parameter)=0]"
			[Register ("getMemoryCacheEnabled", "()Z", "GetGetMemoryCacheEnabledHandler")]
			get {
				const string __id = "getMemoryCacheEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Amap.Api.Maps2d.Model.ITileProvider TileProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getTileProvider' and count(parameter)=0]"
			[Register ("getTileProvider", "()Lcom/amap/api/maps2d/model/TileProvider;", "GetGetTileProviderHandler")]
			get {
				const string __id = "getTileProvider.()Lcom/amap/api/maps2d/model/TileProvider;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.ITileProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='diskCacheDir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("diskCacheDir", "(Ljava/lang/String;)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeDiskCacheDir (string p0)
		{
			const string __id = "diskCacheDir.(Ljava/lang/String;)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='diskCacheEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("diskCacheEnabled", "(Z)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeDiskCacheEnabled (bool p0)
		{
			const string __id = "diskCacheEnabled.(Z)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='diskCacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("diskCacheSize", "(I)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeDiskCacheSize (int p0)
		{
			const string __id = "diskCacheSize.(I)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='memCacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("memCacheSize", "(I)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeMemCacheSize (int p0)
		{
			const string __id = "memCacheSize.(I)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='memoryCacheEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("memoryCacheEnabled", "(Z)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeMemoryCacheEnabled (bool p0)
		{
			const string __id = "memoryCacheEnabled.(Z)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='tileProvider' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.TileProvider']]"
		[Register ("tileProvider", "(Lcom/amap/api/maps2d/model/TileProvider;)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeTileProvider (global::Com.Amap.Api.Maps2d.Model.ITileProvider p0)
		{
			const string __id = "tileProvider.(Lcom/amap/api/maps2d/model/TileProvider;)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TileOverlayOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/amap/api/maps2d/model/TileOverlayOptions;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions InvokeZIndex (float p0)
		{
			const string __id = "zIndex.(F)Lcom/amap/api/maps2d/model/TileOverlayOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
