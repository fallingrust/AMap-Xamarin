using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/UrlTileProvider", DoNotGenerateAcw=true)]
	public abstract partial class UrlTileProvider : global::Java.Lang.Object, global::Com.Amap.Api.Maps2d.Model.ITileProvider {


		public static class InterfaceConsts {

			// The following are fields from: com.amap.api.maps2d.model.TileProvider


			// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/interface[@name='TileProvider']/field[@name='NO_TILE']"
			[Register ("NO_TILE")]
			public static global::Com.Amap.Api.Maps2d.Model.Tile NoTile {
				get {
					const string __id = "NO_TILE.Lcom/amap/api/maps2d/model/Tile;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Tile> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/UrlTileProvider", typeof (UrlTileProvider));
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

		protected UrlTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']/constructor[@name='UrlTileProvider' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe UrlTileProvider (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getTileHeight;
#pragma warning disable 0169
		static Delegate GetGetTileHeightHandler ()
		{
			if (cb_getTileHeight == null)
				cb_getTileHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTileHeight);
			return cb_getTileHeight;
		}

		static int n_GetTileHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int TileHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']/method[@name='getTileHeight' and count(parameter)=0]"
			[Register ("getTileHeight", "()I", "GetGetTileHeightHandler")]
			get {
				const string __id = "getTileHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTileWidth;
#pragma warning disable 0169
		static Delegate GetGetTileWidthHandler ()
		{
			if (cb_getTileWidth == null)
				cb_getTileWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTileWidth);
			return cb_getTileWidth;
		}

		static int n_GetTileWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int TileWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']/method[@name='getTileWidth' and count(parameter)=0]"
			[Register ("getTileWidth", "()I", "GetGetTileWidthHandler")]
			get {
				const string __id = "getTileWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']/method[@name='getTile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTile", "(III)Lcom/amap/api/maps2d/model/Tile;", "")]
		public unsafe global::Com.Amap.Api.Maps2d.Model.Tile GetTile (int p0, int p1, int p2)
		{
			const string __id = "getTile.(III)Lcom/amap/api/maps2d/model/Tile;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Tile> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTileUrl_III;
#pragma warning disable 0169
		static Delegate GetGetTileUrl_IIIHandler ()
		{
			if (cb_getTileUrl_III == null)
				cb_getTileUrl_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetTileUrl_III);
			return cb_getTileUrl_III;
		}

		static IntPtr n_GetTileUrl_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Amap.Api.Maps2d.Model.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTileUrl (p0, p1, p2));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTileUrl", "(III)Ljava/net/URL;", "GetGetTileUrl_IIIHandler")]
		public abstract global::Java.Net.URL GetTileUrl (int p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/UrlTileProvider", DoNotGenerateAcw=true)]
	internal partial class UrlTileProviderInvoker : UrlTileProvider {

		public UrlTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/model/UrlTileProvider", typeof (UrlTileProviderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTileUrl", "(III)Ljava/net/URL;", "GetGetTileUrl_IIIHandler")]
		public override unsafe global::Java.Net.URL GetTileUrl (int p0, int p1, int p2)
		{
			const string __id = "getTileUrl.(III)Ljava/net/URL;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
