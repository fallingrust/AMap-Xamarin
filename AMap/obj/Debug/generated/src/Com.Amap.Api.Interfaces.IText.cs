using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']"
	[Register ("com/amap/api/interfaces/IText", "", "Com.Amap.Api.Interfaces.ITextInvoker")]
	public partial interface IText : IJavaObject {

		int AddIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getAddIndex' and count(parameter)=0]"
			[Register ("getAddIndex", "()I", "GetGetAddIndexHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setAddIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAddIndex", "(I)V", "GetSetAddIndex_IHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		int AlignX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getAlignX' and count(parameter)=0]"
			[Register ("getAlignX", "()I", "GetGetAlignXHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
		}

		int AlignY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getAlignY' and count(parameter)=0]"
			[Register ("getAlignY", "()I", "GetGetAlignYHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
		}

		int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBackgroundColor", "(I)V", "GetSetBackgroundColor_IHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		int FonrColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getFonrColor' and count(parameter)=0]"
			[Register ("getFonrColor", "()I", "GetGetFonrColorHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
		}

		int FontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getFontSize' and count(parameter)=0]"
			[Register ("getFontSize", "()I", "GetGetFontSizeHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setFontSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFontSize", "(I)V", "GetSetFontSize_IHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		global::Java.Lang.Object Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setObject", "(Ljava/lang/Object;)V", "GetSetObject_Ljava_lang_Object_Handler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		global::Com.Amap.Api.Maps2d.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetPositionHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
			[Register ("setPosition", "(Lcom/amap/api/maps2d/model/LatLng;)V", "GetSetPosition_Lcom_amap_api_maps2d_model_LatLng_Handler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		float Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setRotate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotate", "(F)V", "GetSetRotate_FHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")]
		void Draw (global::Android.Graphics.Canvas p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")]
		void Remove ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setAlign' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setAlign", "(II)V", "GetSetAlign_IIHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")]
		void SetAlign (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IText']/method[@name='setFontColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFontColor", "(I)V", "GetSetFontColor_IHandler:Com.Amap.Api.Interfaces.ITextInvoker, AMap")]
		void SetFontColor (int p0);

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IText", DoNotGenerateAcw=true)]
	internal class ITextInvoker : global::Java.Lang.Object, IText {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IText", typeof (ITextInvoker));

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

		public static IText GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IText> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IText"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAddIndex;
#pragma warning disable 0169
		static Delegate GetGetAddIndexHandler ()
		{
			if (cb_getAddIndex == null)
				cb_getAddIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAddIndex);
			return cb_getAddIndex;
		}

		static int n_GetAddIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AddIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setAddIndex_I;
#pragma warning disable 0169
		static Delegate GetSetAddIndex_IHandler ()
		{
			if (cb_setAddIndex_I == null)
				cb_setAddIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAddIndex_I);
			return cb_setAddIndex_I;
		}

		static void n_SetAddIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddIndex = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAddIndex;
		IntPtr id_setAddIndex_I;
		public unsafe int AddIndex {
			get {
				if (id_getAddIndex == IntPtr.Zero)
					id_getAddIndex = JNIEnv.GetMethodID (class_ref, "getAddIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAddIndex);
			}
			set {
				if (id_setAddIndex_I == IntPtr.Zero)
					id_setAddIndex_I = JNIEnv.GetMethodID (class_ref, "setAddIndex", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddIndex_I, __args);
			}
		}

		static Delegate cb_getAlignX;
#pragma warning disable 0169
		static Delegate GetGetAlignXHandler ()
		{
			if (cb_getAlignX == null)
				cb_getAlignX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlignX);
			return cb_getAlignX;
		}

		static int n_GetAlignX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlignX;
		}
#pragma warning restore 0169

		IntPtr id_getAlignX;
		public unsafe int AlignX {
			get {
				if (id_getAlignX == IntPtr.Zero)
					id_getAlignX = JNIEnv.GetMethodID (class_ref, "getAlignX", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlignX);
			}
		}

		static Delegate cb_getAlignY;
#pragma warning disable 0169
		static Delegate GetGetAlignYHandler ()
		{
			if (cb_getAlignY == null)
				cb_getAlignY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlignY);
			return cb_getAlignY;
		}

		static int n_GetAlignY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlignY;
		}
#pragma warning restore 0169

		IntPtr id_getAlignY;
		public unsafe int AlignY {
			get {
				if (id_getAlignY == IntPtr.Zero)
					id_getAlignY = JNIEnv.GetMethodID (class_ref, "getAlignY", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlignY);
			}
		}

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_IHandler ()
		{
			if (cb_setBackgroundColor_I == null)
				cb_setBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundColor_I);
			return cb_setBackgroundColor_I;
		}

		static void n_SetBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBackgroundColor;
		IntPtr id_setBackgroundColor_I;
		public unsafe int BackgroundColor {
			get {
				if (id_getBackgroundColor == IntPtr.Zero)
					id_getBackgroundColor = JNIEnv.GetMethodID (class_ref, "getBackgroundColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundColor);
			}
			set {
				if (id_setBackgroundColor_I == IntPtr.Zero)
					id_setBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setBackgroundColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundColor_I, __args);
			}
		}

		static Delegate cb_getFonrColor;
#pragma warning disable 0169
		static Delegate GetGetFonrColorHandler ()
		{
			if (cb_getFonrColor == null)
				cb_getFonrColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFonrColor);
			return cb_getFonrColor;
		}

		static int n_GetFonrColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FonrColor;
		}
#pragma warning restore 0169

		IntPtr id_getFonrColor;
		public unsafe int FonrColor {
			get {
				if (id_getFonrColor == IntPtr.Zero)
					id_getFonrColor = JNIEnv.GetMethodID (class_ref, "getFonrColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFonrColor);
			}
		}

		static Delegate cb_getFontSize;
#pragma warning disable 0169
		static Delegate GetGetFontSizeHandler ()
		{
			if (cb_getFontSize == null)
				cb_getFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFontSize);
			return cb_getFontSize;
		}

		static int n_GetFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setFontSize_I;
#pragma warning disable 0169
		static Delegate GetSetFontSize_IHandler ()
		{
			if (cb_setFontSize_I == null)
				cb_setFontSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFontSize_I);
			return cb_setFontSize_I;
		}

		static void n_SetFontSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FontSize = p0;
		}
#pragma warning restore 0169

		IntPtr id_getFontSize;
		IntPtr id_setFontSize_I;
		public unsafe int FontSize {
			get {
				if (id_getFontSize == IntPtr.Zero)
					id_getFontSize = JNIEnv.GetMethodID (class_ref, "getFontSize", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFontSize);
			}
			set {
				if (id_setFontSize_I == IntPtr.Zero)
					id_setFontSize_I = JNIEnv.GetMethodID (class_ref, "setFontSize", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontSize_I, __args);
			}
		}

		static Delegate cb_getObject;
#pragma warning disable 0169
		static Delegate GetGetObjectHandler ()
		{
			if (cb_getObject == null)
				cb_getObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObject);
			return cb_getObject;
		}

		static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Object);
		}
#pragma warning restore 0169

		static Delegate cb_setObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setObject_Ljava_lang_Object_ == null)
				cb_setObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObject_Ljava_lang_Object_);
			return cb_setObject_Ljava_lang_Object_;
		}

		static void n_SetObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Object = p0;
		}
#pragma warning restore 0169

		IntPtr id_getObject;
		IntPtr id_setObject_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Object {
			get {
				if (id_getObject == IntPtr.Zero)
					id_getObject = JNIEnv.GetMethodID (class_ref, "getObject", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setObject_Ljava_lang_Object_ == IntPtr.Zero)
					id_setObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setObject", "(Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setObject_Ljava_lang_Object_, __args);
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_setPosition_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static void n_SetPosition_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Position = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPosition;
		IntPtr id_setPosition_Lcom_amap_api_maps2d_model_LatLng_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLng Position {
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/amap/api/maps2d/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPosition_Lcom_amap_api_maps2d_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_amap_api_maps2d_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/amap/api/maps2d/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_amap_api_maps2d_model_LatLng_, __args);
			}
		}

		static Delegate cb_getRotate;
#pragma warning disable 0169
		static Delegate GetGetRotateHandler ()
		{
			if (cb_getRotate == null)
				cb_getRotate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRotate);
			return cb_getRotate;
		}

		static float n_GetRotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rotate;
		}
#pragma warning restore 0169

		static Delegate cb_setRotate_F;
#pragma warning disable 0169
		static Delegate GetSetRotate_FHandler ()
		{
			if (cb_setRotate_F == null)
				cb_setRotate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotate_F);
			return cb_setRotate_F;
		}

		static void n_SetRotate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rotate = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRotate;
		IntPtr id_setRotate_F;
		public unsafe float Rotate {
			get {
				if (id_getRotate == IntPtr.Zero)
					id_getRotate = JNIEnv.GetMethodID (class_ref, "getRotate", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getRotate);
			}
			set {
				if (id_setRotate_F == IntPtr.Zero)
					id_setRotate_F = JNIEnv.GetMethodID (class_ref, "setRotate", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotate_F, __args);
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Text = p0;
		}
#pragma warning restore 0169

		IntPtr id_getText;
		IntPtr id_setText_Ljava_lang_String_;
		public unsafe string Text {
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
					id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTypeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Typeface = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTypeface;
		IntPtr id_setTypeface_Landroid_graphics_Typeface_;
		public unsafe global::Android.Graphics.Typeface Typeface {
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_, __args);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		IntPtr id_setVisible_Z;
		public unsafe bool Visible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisible_Z, __args);
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZIndex);
			return cb_getZIndex;
		}

		static float n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_F;
#pragma warning disable 0169
		static Delegate GetSetZIndex_FHandler ()
		{
			if (cb_setZIndex_F == null)
				cb_setZIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZIndex_F);
			return cb_setZIndex_F;
		}

		static void n_SetZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		IntPtr id_getZIndex;
		IntPtr id_setZIndex_F;
		public unsafe float ZIndex {
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getZIndex);
			}
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZIndex_F, __args);
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		IntPtr id_draw_Landroid_graphics_Canvas_;
		public unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_, __args);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		IntPtr id_remove;
		public unsafe void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove);
		}

		static Delegate cb_setAlign_II;
#pragma warning disable 0169
		static Delegate GetSetAlign_IIHandler ()
		{
			if (cb_setAlign_II == null)
				cb_setAlign_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetAlign_II);
			return cb_setAlign_II;
		}

		static void n_SetAlign_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlign (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setAlign_II;
		public unsafe void SetAlign (int p0, int p1)
		{
			if (id_setAlign_II == IntPtr.Zero)
				id_setAlign_II = JNIEnv.GetMethodID (class_ref, "setAlign", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlign_II, __args);
		}

		static Delegate cb_setFontColor_I;
#pragma warning disable 0169
		static Delegate GetSetFontColor_IHandler ()
		{
			if (cb_setFontColor_I == null)
				cb_setFontColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFontColor_I);
			return cb_setFontColor_I;
		}

		static void n_SetFontColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IText __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFontColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setFontColor_I;
		public unsafe void SetFontColor (int p0)
		{
			if (id_setFontColor_I == IntPtr.Zero)
				id_setFontColor_I = JNIEnv.GetMethodID (class_ref, "setFontColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFontColor_I, __args);
		}

	}

}
