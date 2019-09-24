using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Maps2d {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/amap/api/maps2d/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/amap/api/maps2d/UiSettings", typeof (UiSettings));
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

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/constructor[@name='UiSettings' and count(parameter)=1 and parameter[1][@type='com.amap.api.interfaces.IUiSettings']]"
		[Register (".ctor", "(Lcom/amap/api/interfaces/IUiSettings;)V", "")]
		public unsafe UiSettings (global::Com.Amap.Api.Interfaces.IUiSettings p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/amap/api/interfaces/IUiSettings;)V";

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

		public unsafe bool CompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler")]
			get {
				const string __id = "isCompassEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCompassEnabled", "(Z)V", "GetSetCompassEnabled_ZHandler")]
			set {
				const string __id = "setCompassEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()I", "GetGetLogoPositionHandler")]
			get {
				const string __id = "getLogoPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogoPosition", "(I)V", "GetSetLogoPosition_IHandler")]
			set {
				const string __id = "setLogoPosition.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool MyLocationButtonEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='isMyLocationButtonEnabled' and count(parameter)=0]"
			[Register ("isMyLocationButtonEnabled", "()Z", "GetIsMyLocationButtonEnabledHandler")]
			get {
				const string __id = "isMyLocationButtonEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setMyLocationButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationButtonEnabled", "(Z)V", "GetSetMyLocationButtonEnabled_ZHandler")]
			set {
				const string __id = "setMyLocationButtonEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ScaleControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='isScaleControlsEnabled' and count(parameter)=0]"
			[Register ("isScaleControlsEnabled", "()Z", "GetIsScaleControlsEnabledHandler")]
			get {
				const string __id = "isScaleControlsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setScaleControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleControlsEnabled", "(Z)V", "GetSetScaleControlsEnabled_ZHandler")]
			set {
				const string __id = "setScaleControlsEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				const string __id = "isScrollGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
			set {
				const string __id = "setScrollGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ZoomControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='isZoomControlsEnabled' and count(parameter)=0]"
			[Register ("isZoomControlsEnabled", "()Z", "GetIsZoomControlsEnabledHandler")]
			get {
				const string __id = "isZoomControlsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setZoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomControlsEnabled", "(Z)V", "GetSetZoomControlsEnabled_ZHandler")]
			set {
				const string __id = "setZoomControlsEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				const string __id = "isZoomGesturesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setZoomGesturesEnabled", "(Z)V", "GetSetZoomGesturesEnabled_ZHandler")]
			set {
				const string __id = "setZoomGesturesEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int ZoomPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='getZoomPosition' and count(parameter)=0]"
			[Register ("getZoomPosition", "()I", "GetGetZoomPositionHandler")]
			get {
				const string __id = "getZoomPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setZoomPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZoomPosition", "(I)V", "GetSetZoomPosition_IHandler")]
			set {
				const string __id = "setZoomPosition.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		public unsafe void SetAllGesturesEnabled (bool p0)
		{
			const string __id = "setAllGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.maps2d']/class[@name='UiSettings']/method[@name='setZoomInByScreenCenter' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZoomInByScreenCenter", "(Z)V", "")]
		public unsafe void SetZoomInByScreenCenter (bool p0)
		{
			const string __id = "setZoomInByScreenCenter.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
