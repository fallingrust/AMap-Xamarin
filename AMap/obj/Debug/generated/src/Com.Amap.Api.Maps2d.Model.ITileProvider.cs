using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	[Register ("com/amap/api/maps2d/model/TileProvider", DoNotGenerateAcw=true)]
	public abstract class TileProvider : Java.Lang.Object {

		internal TileProvider ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/interface[@name='TileProvider']/field[@name='NO_TILE']"
		[Register ("NO_TILE")]
		public static global::Com.Amap.Api.Maps2d.Model.Tile NoTile {
			get {
				const string __id = "NO_TILE.Lcom/amap/api/maps2d/model/Tile;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Tile> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		new static JniPeerMembers _members = new JniPeerMembers ("com/amap/api/maps2d/model/TileProvider", typeof (TileProvider));
	}

	[Register ("com/amap/api/maps2d/model/TileProvider", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'TileProvider' type. This type will be removed in a future release.")]
	public abstract class TileProviderConsts : TileProvider {

		private TileProviderConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.maps2d.model']/interface[@name='TileProvider']"
	[Register ("com/amap/api/maps2d/model/TileProvider", "", "Com.Amap.Api.Maps2d.Model.ITileProviderInvoker")]
	public partial interface ITileProvider : IJavaObject {

		int TileHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/interface[@name='TileProvider']/method[@name='getTileHeight' and count(parameter)=0]"
			[Register ("getTileHeight", "()I", "GetGetTileHeightHandler:Com.Amap.Api.Maps2d.Model.ITileProviderInvoker, AMap")] get;
		}

		int TileWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/interface[@name='TileProvider']/method[@name='getTileWidth' and count(parameter)=0]"
			[Register ("getTileWidth", "()I", "GetGetTileWidthHandler:Com.Amap.Api.Maps2d.Model.ITileProviderInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/interface[@name='TileProvider']/method[@name='getTile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTile", "(III)Lcom/amap/api/maps2d/model/Tile;", "GetGetTile_IIIHandler:Com.Amap.Api.Maps2d.Model.ITileProviderInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.Tile GetTile (int p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/TileProvider", DoNotGenerateAcw=true)]
	internal class ITileProviderInvoker : global::Java.Lang.Object, ITileProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/maps2d/model/TileProvider", typeof (ITileProviderInvoker));

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

		public static ITileProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITileProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.maps2d.model.TileProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Amap.Api.Maps2d.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileHeight;
		}
#pragma warning restore 0169

		IntPtr id_getTileHeight;
		public unsafe int TileHeight {
			get {
				if (id_getTileHeight == IntPtr.Zero)
					id_getTileHeight = JNIEnv.GetMethodID (class_ref, "getTileHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTileHeight);
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
			global::Com.Amap.Api.Maps2d.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileWidth;
		}
#pragma warning restore 0169

		IntPtr id_getTileWidth;
		public unsafe int TileWidth {
			get {
				if (id_getTileWidth == IntPtr.Zero)
					id_getTileWidth = JNIEnv.GetMethodID (class_ref, "getTileWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTileWidth);
			}
		}

		static Delegate cb_getTile_III;
#pragma warning disable 0169
		static Delegate GetGetTile_IIIHandler ()
		{
			if (cb_getTile_III == null)
				cb_getTile_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetTile_III);
			return cb_getTile_III;
		}

		static IntPtr n_GetTile_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Amap.Api.Maps2d.Model.ITileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.ITileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTile (p0, p1, p2));
		}
#pragma warning restore 0169

		IntPtr id_getTile_III;
		public unsafe global::Com.Amap.Api.Maps2d.Model.Tile GetTile (int p0, int p1, int p2)
		{
			if (id_getTile_III == IntPtr.Zero)
				id_getTile_III = JNIEnv.GetMethodID (class_ref, "getTile", "(III)Lcom/amap/api/maps2d/model/Tile;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Tile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTile_III, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
