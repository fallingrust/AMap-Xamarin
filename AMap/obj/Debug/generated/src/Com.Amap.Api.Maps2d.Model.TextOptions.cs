using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/model/TextOptions", DoNotGenerateAcw=true)]
	public partial class TextOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Com.Amap.Api.Maps2d.Model.TextOptionsCreator Creator {
			get {
				const string __id = "CREATOR.Lcom/amap/api/maps2d/model/TextOptionsCreator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptionsCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/model/TextOptions", typeof (TextOptions));
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

		protected TextOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/constructor[@name='TextOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextOptions ()
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlignX;
		}
#pragma warning restore 0169

		public virtual unsafe int AlignX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getAlignX' and count(parameter)=0]"
			[Register ("getAlignX", "()I", "GetGetAlignXHandler")]
			get {
				const string __id = "getAlignX.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlignY;
		}
#pragma warning restore 0169

		public virtual unsafe int AlignY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getAlignY' and count(parameter)=0]"
			[Register ("getAlignY", "()I", "GetGetAlignYHandler")]
			get {
				const string __id = "getAlignY.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				const string __id = "getBackgroundColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFontColor;
#pragma warning disable 0169
		static Delegate GetGetFontColorHandler ()
		{
			if (cb_getFontColor == null)
				cb_getFontColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFontColor);
			return cb_getFontColor;
		}

		static int n_GetFontColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FontColor;
		}
#pragma warning restore 0169

		public virtual unsafe int FontColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getFontColor' and count(parameter)=0]"
			[Register ("getFontColor", "()I", "GetGetFontColorHandler")]
			get {
				const string __id = "getFontColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FontSize;
		}
#pragma warning restore 0169

		public virtual unsafe int FontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getFontSize' and count(parameter)=0]"
			[Register ("getFontSize", "()I", "GetGetFontSizeHandler")]
			get {
				const string __id = "getFontSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVisible;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Object);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Object {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getObject' and count(parameter)=0]"
			[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler")]
			get {
				const string __id = "getObject.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/amap/api/maps2d/model/LatLng;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/amap/api/maps2d/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rotate;
		}
#pragma warning restore 0169

		public virtual unsafe float Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler")]
			get {
				const string __id = "getRotate.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				const string __id = "getTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		public virtual unsafe float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_align_II;
#pragma warning disable 0169
		static Delegate GetAlign_IIHandler ()
		{
			if (cb_align_II == null)
				cb_align_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Align_II);
			return cb_align_II;
		}

		static IntPtr n_Align_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Align (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='align' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("align", "(II)Lcom/amap/api/maps2d/model/TextOptions;", "GetAlign_IIHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions Align (int p0, int p1)
		{
			const string __id = "align.(II)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_backgroundColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeBackgroundColor_IHandler ()
		{
			if (cb_backgroundColor_I == null)
				cb_backgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeBackgroundColor_I);
			return cb_backgroundColor_I;
		}

		static IntPtr n_InvokeBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeBackgroundColor (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='backgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("backgroundColor", "(I)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeBackgroundColor (int p0)
		{
			const string __id = "backgroundColor.(I)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_fontColor_I;
#pragma warning disable 0169
		static Delegate GetInvokeFontColor_IHandler ()
		{
			if (cb_fontColor_I == null)
				cb_fontColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeFontColor_I);
			return cb_fontColor_I;
		}

		static IntPtr n_InvokeFontColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeFontColor (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='fontColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fontColor", "(I)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeFontColor_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeFontColor (int p0)
		{
			const string __id = "fontColor.(I)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fontSize_I;
#pragma warning disable 0169
		static Delegate GetInvokeFontSize_IHandler ()
		{
			if (cb_fontSize_I == null)
				cb_fontSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InvokeFontSize_I);
			return cb_fontSize_I;
		}

		static IntPtr n_InvokeFontSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeFontSize (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='fontSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fontSize", "(I)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeFontSize_IHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeFontSize (int p0)
		{
			const string __id = "fontSize.(I)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_position_Lcom_amap_api_maps2d_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetInvokePosition_Lcom_amap_api_maps2d_model_LatLng_Handler ()
		{
			if (cb_position_Lcom_amap_api_maps2d_model_LatLng_ == null)
				cb_position_Lcom_amap_api_maps2d_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokePosition_Lcom_amap_api_maps2d_model_LatLng_);
			return cb_position_Lcom_amap_api_maps2d_model_LatLng_;
		}

		static IntPtr n_InvokePosition_Lcom_amap_api_maps2d_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokePosition (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.LatLng']]"
		[Register ("position", "(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokePosition_Lcom_amap_api_maps2d_model_LatLng_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokePosition (global::Com.Amap.Api.Maps2d.Model.LatLng p0)
		{
			const string __id = "position.(Lcom/amap/api/maps2d/model/LatLng;)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotate_F;
#pragma warning disable 0169
		static Delegate GetInvokeRotate_FHandler ()
		{
			if (cb_rotate_F == null)
				cb_rotate_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_InvokeRotate_F);
			return cb_rotate_F;
		}

		static IntPtr n_InvokeRotate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeRotate (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotate", "(F)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeRotate_FHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeRotate (float p0)
		{
			const string __id = "rotate.(F)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setObject_Ljava_lang_Object_ == null)
				cb_setObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetObject_Ljava_lang_Object_);
			return cb_setObject_Ljava_lang_Object_;
		}

		static IntPtr n_SetObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetObject (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='setObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setObject", "(Ljava/lang/Object;)Lcom/amap/api/maps2d/model/TextOptions;", "GetSetObject_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions SetObject (global::Java.Lang.Object p0)
		{
			const string __id = "setObject.(Ljava/lang/Object;)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_text_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeText_Ljava_lang_String_Handler ()
		{
			if (cb_text_Ljava_lang_String_ == null)
				cb_text_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeText_Ljava_lang_String_);
			return cb_text_Ljava_lang_String_;
		}

		static IntPtr n_InvokeText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeText (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='text' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("text", "(Ljava/lang/String;)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeText (string p0)
		{
			const string __id = "text.(Ljava/lang/String;)Lcom/amap/api/maps2d/model/TextOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_typeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetInvokeTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_typeface_Landroid_graphics_Typeface_ == null)
				cb_typeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeTypeface_Landroid_graphics_Typeface_);
			return cb_typeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_InvokeTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='typeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("typeface", "(Landroid/graphics/Typeface;)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeTypeface (global::Android.Graphics.Typeface p0)
		{
			const string __id = "typeface.(Landroid/graphics/Typeface;)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_visible_Z;
#pragma warning disable 0169
		static Delegate GetVisible_ZHandler ()
		{
			if (cb_visible_Z == null)
				cb_visible_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Visible_Z);
			return cb_visible_Z;
		}

		static IntPtr n_Visible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Visible (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/amap/api/maps2d/model/TextOptions;", "GetVisible_ZHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zIndex_F;
#pragma warning disable 0169
		static Delegate GetInvokeZIndex_FHandler ()
		{
			if (cb_zIndex_F == null)
				cb_zIndex_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_InvokeZIndex_F);
			return cb_zIndex_F;
		}

		static IntPtr n_InvokeZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Maps2d.Model.TextOptions __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeZIndex (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d.model']/class[@name='TextOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/amap/api/maps2d/model/TextOptions;", "GetInvokeZIndex_FHandler")]
		public virtual unsafe global::Com.Amap.Api.Maps2d.Model.TextOptions InvokeZIndex (float p0)
		{
			const string __id = "zIndex.(F)Lcom/amap/api/maps2d/model/TextOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
