using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Amap.Api.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']"
	[Register ("com/amap/api/interfaces/IAMap", "", "Com.Amap.Api.Interfaces.IAMapInvoker")]
	public partial interface IAMap : IJavaObject {

		global::Com.Amap.Api.Maps2d.Projection AMapProjection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getAMapProjection' and count(parameter)=0]"
			[Register ("getAMapProjection", "()Lcom/amap/api/maps2d/Projection;", "GetGetAMapProjectionHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		global::Com.Amap.Api.Maps2d.UiSettings AMapUiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getAMapUiSettings' and count(parameter)=0]"
			[Register ("getAMapUiSettings", "()Lcom/amap/api/maps2d/UiSettings;", "GetGetAMapUiSettingsHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		global::Com.Amap.Api.Maps2d.Model.CameraPosition CameraPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getCameraPosition' and count(parameter)=0]"
			[Register ("getCameraPosition", "()Lcom/amap/api/maps2d/model/CameraPosition;", "GetGetCameraPositionHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		int LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()I", "GetGetLogoPositionHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLogoPosition", "(I)V", "GetSetLogoPosition_IHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] set;
		}

		global::Android.OS.Handler MainHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMainHandler' and count(parameter)=0]"
			[Register ("getMainHandler", "()Landroid/os/Handler;", "GetGetMainHandlerHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		global::Com.Amap.Api.Maps2d.Model.LatLngBounds MapBounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMapBounds' and count(parameter)=0]"
			[Register ("getMapBounds", "()Lcom/amap/api/maps2d/model/LatLngBounds;", "GetGetMapBoundsHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		int MapHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMapHeight' and count(parameter)=0]"
			[Register ("getMapHeight", "()I", "GetGetMapHeightHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.Marker> MapScreenMarkers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMapScreenMarkers' and count(parameter)=0]"
			[Register ("getMapScreenMarkers", "()Ljava/util/List;", "GetGetMapScreenMarkersHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		int MapType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMapType' and count(parameter)=0]"
			[Register ("getMapType", "()I", "GetGetMapTypeHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setMapType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMapType", "(I)V", "GetSetMapType_IHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] set;
		}

		int MapWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMapWidth' and count(parameter)=0]"
			[Register ("getMapWidth", "()I", "GetGetMapWidthHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		float MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()F", "GetGetMaxZoomLevelHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		float MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()F", "GetGetMinZoomLevelHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		global::Android.Locations.Location MyLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMyLocation' and count(parameter)=0]"
			[Register ("getMyLocation", "()Landroid/location/Location;", "GetGetMyLocationHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		bool MyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setMyLocationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] set;
		}

		global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener OnCameraChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getOnCameraChangeListener' and count(parameter)=0]"
			[Register ("getOnCameraChangeListener", "()Lcom/amap/api/maps2d/AMap$OnCameraChangeListener;", "GetGetOnCameraChangeListenerHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnCameraChangeListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnCameraChangeListener']]"
			[Register ("setOnCameraChangeListener", "(Lcom/amap/api/maps2d/AMap$OnCameraChangeListener;)V", "GetSetOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] set;
		}

		float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getScalePerPixel' and count(parameter)=0]"
			[Register ("getScalePerPixel", "()F", "GetGetScalePerPixelHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		bool TrafficEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='isTrafficEnabled' and count(parameter)=0]"
			[Register ("isTrafficEnabled", "()Z", "GetIsTrafficEnabledHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setTrafficEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrafficEnabled", "(Z)V", "GetSetTrafficEnabled_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] set;
		}

		global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		float ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()F", "GetGetZoomLevelHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='AMapInvalidate' and count(parameter)=0]"
		[Register ("AMapInvalidate", "()V", "GetAMapInvalidateHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void AMapInvalidate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.CircleOptions']]"
		[Register ("addCircle", "(Lcom/amap/api/maps2d/model/CircleOptions;)Lcom/amap/api/maps2d/model/Circle;", "GetAddCircle_Lcom_amap_api_maps2d_model_CircleOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.Circle AddCircle (global::Com.Amap.Api.Maps2d.Model.CircleOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.GroundOverlayOptions']]"
		[Register ("addGroundOverlay", "(Lcom/amap/api/maps2d/model/GroundOverlayOptions;)Lcom/amap/api/maps2d/model/GroundOverlay;", "GetAddGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.GroundOverlay AddGroundOverlay (global::Com.Amap.Api.Maps2d.Model.GroundOverlayOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.MarkerOptions']]"
		[Register ("addMarker", "(Lcom/amap/api/maps2d/model/MarkerOptions;)Lcom/amap/api/maps2d/model/Marker;", "GetAddMarker_Lcom_amap_api_maps2d_model_MarkerOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.Marker AddMarker (global::Com.Amap.Api.Maps2d.Model.MarkerOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.PolygonOptions']]"
		[Register ("addPolygon", "(Lcom/amap/api/maps2d/model/PolygonOptions;)Lcom/amap/api/maps2d/model/Polygon;", "GetAddPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.Polygon AddPolygon (global::Com.Amap.Api.Maps2d.Model.PolygonOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.PolylineOptions']]"
		[Register ("addPolyline", "(Lcom/amap/api/maps2d/model/PolylineOptions;)Lcom/amap/api/maps2d/model/Polyline;", "GetAddPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.Polyline AddPolyline (global::Com.Amap.Api.Maps2d.Model.PolylineOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addText' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.TextOptions']]"
		[Register ("addText", "(Lcom/amap/api/maps2d/model/TextOptions;)Lcom/amap/api/maps2d/model/Text;", "GetAddText_Lcom_amap_api_maps2d_model_TextOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.Text AddText (global::Com.Amap.Api.Maps2d.Model.TextOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='addTileOverlay' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.TileOverlayOptions']]"
		[Register ("addTileOverlay", "(Lcom/amap/api/maps2d/model/TileOverlayOptions;)Lcom/amap/api/maps2d/model/TileOverlay;", "GetAddTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		global::Com.Amap.Api.Maps2d.Model.TileOverlay AddTileOverlay (global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='animateCamera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate']]"
		[Register ("animateCamera", "(Lcom/amap/api/maps2d/CameraUpdate;)V", "GetAnimateCamera_Lcom_amap_api_maps2d_CameraUpdate_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void AnimateCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='animateCameraWithCallback' and count(parameter)=2 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate'] and parameter[2][@type='com.amap.api.maps2d.AMap.CancelableCallback']]"
		[Register ("animateCameraWithCallback", "(Lcom/amap/api/maps2d/CameraUpdate;Lcom/amap/api/maps2d/AMap$CancelableCallback;)V", "GetAnimateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void AnimateCameraWithCallback (global::Com.Amap.Api.Maps2d.CameraUpdate p0, global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='animateCameraWithDurationAndCallback' and count(parameter)=3 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate'] and parameter[2][@type='long'] and parameter[3][@type='com.amap.api.maps2d.AMap.CancelableCallback']]"
		[Register ("animateCameraWithDurationAndCallback", "(Lcom/amap/api/maps2d/CameraUpdate;JLcom/amap/api/maps2d/AMap$CancelableCallback;)V", "GetAnimateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void AnimateCameraWithDurationAndCallback (global::Com.Amap.Api.Maps2d.CameraUpdate p0, long p1, global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='getMapScreenShot' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapScreenShotListener']]"
		[Register ("getMapScreenShot", "(Lcom/amap/api/maps2d/AMap$OnMapScreenShotListener;)V", "GetGetMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void GetMapScreenShot (global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.CameraUpdate']]"
		[Register ("moveCamera", "(Lcom/amap/api/maps2d/CameraUpdate;)V", "GetMoveCamera_Lcom_amap_api_maps2d_CameraUpdate_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void MoveCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void OnPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void OnResume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='redrawInfoWindow' and count(parameter)=0]"
		[Register ("redrawInfoWindow", "()V", "GetRedrawInfoWindowHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void RedrawInfoWindow ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='removeGLOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeGLOverlay", "(Ljava/lang/String;)Z", "GetRemoveGLOverlay_Ljava_lang_String_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		bool RemoveGLOverlay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='removeMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMarker", "(Ljava/lang/String;)Z", "GetRemoveMarker_Ljava_lang_String_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		bool RemoveMarker (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='removecache' and count(parameter)=0]"
		[Register ("removecache", "()V", "GetRemovecacheHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void Removecache ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='removecache' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnCacheRemoveListener']]"
		[Register ("removecache", "(Lcom/amap/api/maps2d/AMap$OnCacheRemoveListener;)V", "GetRemovecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void Removecache (global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setInfoWindowAdapter' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.InfoWindowAdapter']]"
		[Register ("setInfoWindowAdapter", "(Lcom/amap/api/maps2d/AMap$InfoWindowAdapter;)V", "GetSetInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetInfoWindowAdapter (global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setLocationSource' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.LocationSource']]"
		[Register ("setLocationSource", "(Lcom/amap/api/maps2d/LocationSource;)V", "GetSetLocationSource_Lcom_amap_api_maps2d_LocationSource_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetLocationSource (global::Com.Amap.Api.Maps2d.ILocationSource p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setMapLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMapLanguage", "(Ljava/lang/String;)V", "GetSetMapLanguage_Ljava_lang_String_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetMapLanguage (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setMyLocationRotateAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMyLocationRotateAngle", "(F)V", "GetSetMyLocationRotateAngle_FHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetMyLocationRotateAngle (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setMyLocationStyle' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.model.MyLocationStyle']]"
		[Register ("setMyLocationStyle", "(Lcom/amap/api/maps2d/model/MyLocationStyle;)V", "GetSetMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetMyLocationStyle (global::Com.Amap.Api.Maps2d.Model.MyLocationStyle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setMyLocationType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMyLocationType", "(I)V", "GetSetMyLocationType_IHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetMyLocationType (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnInfoWindowClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnInfoWindowClickListener']]"
		[Register ("setOnInfoWindowClickListener", "(Lcom/amap/api/maps2d/AMap$OnInfoWindowClickListener;)V", "GetSetOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnInfoWindowClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapClickListener']]"
		[Register ("setOnMapClickListener", "(Lcom/amap/api/maps2d/AMap$OnMapClickListener;)V", "GetSetOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMapClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapLongClickListener']]"
		[Register ("setOnMapLongClickListener", "(Lcom/amap/api/maps2d/AMap$OnMapLongClickListener;)V", "GetSetOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMapLongClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMapTouchListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapTouchListener']]"
		[Register ("setOnMapTouchListener", "(Lcom/amap/api/maps2d/AMap$OnMapTouchListener;)V", "GetSetOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMapTouchListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMaploadedListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMapLoadedListener']]"
		[Register ("setOnMaploadedListener", "(Lcom/amap/api/maps2d/AMap$OnMapLoadedListener;)V", "GetSetOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMaploadedListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMarkerClickListener']]"
		[Register ("setOnMarkerClickListener", "(Lcom/amap/api/maps2d/AMap$OnMarkerClickListener;)V", "GetSetOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMarkerClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMarkerDragListener']]"
		[Register ("setOnMarkerDragListener", "(Lcom/amap/api/maps2d/AMap$OnMarkerDragListener;)V", "GetSetOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMarkerDragListener (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setOnMyLocationChangeListener' and count(parameter)=1 and parameter[1][@type='com.amap.api.maps2d.AMap.OnMyLocationChangeListener']]"
		[Register ("setOnMyLocationChangeListener", "(Lcom/amap/api/maps2d/AMap$OnMyLocationChangeListener;)V", "GetSetOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetOnMyLocationChangeListener (global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setZOrderOnTop' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZOrderOnTop", "(Z)V", "GetSetZOrderOnTop_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetZOrderOnTop (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='setZoomPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoomPosition", "(I)V", "GetSetZoomPosition_IHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void SetZoomPosition (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='showCompassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showCompassEnabled", "(Z)V", "GetShowCompassEnabled_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void ShowCompassEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='showMyLocationButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMyLocationButtonEnabled", "(Z)V", "GetShowMyLocationButtonEnabled_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void ShowMyLocationButtonEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='showMyLocationOverlay' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("showMyLocationOverlay", "(Landroid/location/Location;)V", "GetShowMyLocationOverlay_Landroid_location_Location_Handler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void ShowMyLocationOverlay (global::Android.Locations.Location p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='showScaleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showScaleEnabled", "(Z)V", "GetShowScaleEnabled_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void ShowScaleEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='showZoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showZoomControlsEnabled", "(Z)V", "GetShowZoomControlsEnabled_ZHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void ShowZoomControlsEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amap.api.interfaces']/interface[@name='IAMap']/method[@name='stopAnimation' and count(parameter)=0]"
		[Register ("stopAnimation", "()V", "GetStopAnimationHandler:Com.Amap.Api.Interfaces.IAMapInvoker, AMap")]
		void StopAnimation ();

	}

	[global::Android.Runtime.Register ("com/amap/api/interfaces/IAMap", DoNotGenerateAcw=true)]
	internal class IAMapInvoker : global::Java.Lang.Object, IAMap {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/amap/api/interfaces/IAMap", typeof (IAMapInvoker));

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

		public static IAMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amap.api.interfaces.IAMap"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAMapProjection;
#pragma warning disable 0169
		static Delegate GetGetAMapProjectionHandler ()
		{
			if (cb_getAMapProjection == null)
				cb_getAMapProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAMapProjection);
			return cb_getAMapProjection;
		}

		static IntPtr n_GetAMapProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AMapProjection);
		}
#pragma warning restore 0169

		IntPtr id_getAMapProjection;
		public unsafe global::Com.Amap.Api.Maps2d.Projection AMapProjection {
			get {
				if (id_getAMapProjection == IntPtr.Zero)
					id_getAMapProjection = JNIEnv.GetMethodID (class_ref, "getAMapProjection", "()Lcom/amap/api/maps2d/Projection;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Projection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAMapProjection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAMapUiSettings;
#pragma warning disable 0169
		static Delegate GetGetAMapUiSettingsHandler ()
		{
			if (cb_getAMapUiSettings == null)
				cb_getAMapUiSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAMapUiSettings);
			return cb_getAMapUiSettings;
		}

		static IntPtr n_GetAMapUiSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AMapUiSettings);
		}
#pragma warning restore 0169

		IntPtr id_getAMapUiSettings;
		public unsafe global::Com.Amap.Api.Maps2d.UiSettings AMapUiSettings {
			get {
				if (id_getAMapUiSettings == IntPtr.Zero)
					id_getAMapUiSettings = JNIEnv.GetMethodID (class_ref, "getAMapUiSettings", "()Lcom/amap/api/maps2d/UiSettings;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.UiSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAMapUiSettings), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCameraPosition;
#pragma warning disable 0169
		static Delegate GetGetCameraPositionHandler ()
		{
			if (cb_getCameraPosition == null)
				cb_getCameraPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraPosition);
			return cb_getCameraPosition;
		}

		static IntPtr n_GetCameraPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CameraPosition);
		}
#pragma warning restore 0169

		IntPtr id_getCameraPosition;
		public unsafe global::Com.Amap.Api.Maps2d.Model.CameraPosition CameraPosition {
			get {
				if (id_getCameraPosition == IntPtr.Zero)
					id_getCameraPosition = JNIEnv.GetMethodID (class_ref, "getCameraPosition", "()Lcom/amap/api/maps2d/model/CameraPosition;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CameraPosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraPosition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLogoPosition;
#pragma warning disable 0169
		static Delegate GetGetLogoPositionHandler ()
		{
			if (cb_getLogoPosition == null)
				cb_getLogoPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLogoPosition);
			return cb_getLogoPosition;
		}

		static int n_GetLogoPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogoPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setLogoPosition_I;
#pragma warning disable 0169
		static Delegate GetSetLogoPosition_IHandler ()
		{
			if (cb_setLogoPosition_I == null)
				cb_setLogoPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogoPosition_I);
			return cb_setLogoPosition_I;
		}

		static void n_SetLogoPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LogoPosition = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLogoPosition;
		IntPtr id_setLogoPosition_I;
		public unsafe int LogoPosition {
			get {
				if (id_getLogoPosition == IntPtr.Zero)
					id_getLogoPosition = JNIEnv.GetMethodID (class_ref, "getLogoPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLogoPosition);
			}
			set {
				if (id_setLogoPosition_I == IntPtr.Zero)
					id_setLogoPosition_I = JNIEnv.GetMethodID (class_ref, "setLogoPosition", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogoPosition_I, __args);
			}
		}

		static Delegate cb_getMainHandler;
#pragma warning disable 0169
		static Delegate GetGetMainHandlerHandler ()
		{
			if (cb_getMainHandler == null)
				cb_getMainHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainHandler);
			return cb_getMainHandler;
		}

		static IntPtr n_GetMainHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MainHandler);
		}
#pragma warning restore 0169

		IntPtr id_getMainHandler;
		public unsafe global::Android.OS.Handler MainHandler {
			get {
				if (id_getMainHandler == IntPtr.Zero)
					id_getMainHandler = JNIEnv.GetMethodID (class_ref, "getMainHandler", "()Landroid/os/Handler;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMainHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMapBounds;
#pragma warning disable 0169
		static Delegate GetGetMapBoundsHandler ()
		{
			if (cb_getMapBounds == null)
				cb_getMapBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapBounds);
			return cb_getMapBounds;
		}

		static IntPtr n_GetMapBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapBounds);
		}
#pragma warning restore 0169

		IntPtr id_getMapBounds;
		public unsafe global::Com.Amap.Api.Maps2d.Model.LatLngBounds MapBounds {
			get {
				if (id_getMapBounds == IntPtr.Zero)
					id_getMapBounds = JNIEnv.GetMethodID (class_ref, "getMapBounds", "()Lcom/amap/api/maps2d/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.LatLngBounds> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMapHeight;
#pragma warning disable 0169
		static Delegate GetGetMapHeightHandler ()
		{
			if (cb_getMapHeight == null)
				cb_getMapHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapHeight);
			return cb_getMapHeight;
		}

		static int n_GetMapHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapHeight;
		}
#pragma warning restore 0169

		IntPtr id_getMapHeight;
		public unsafe int MapHeight {
			get {
				if (id_getMapHeight == IntPtr.Zero)
					id_getMapHeight = JNIEnv.GetMethodID (class_ref, "getMapHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapHeight);
			}
		}

		static Delegate cb_getMapScreenMarkers;
#pragma warning disable 0169
		static Delegate GetGetMapScreenMarkersHandler ()
		{
			if (cb_getMapScreenMarkers == null)
				cb_getMapScreenMarkers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapScreenMarkers);
			return cb_getMapScreenMarkers;
		}

		static IntPtr n_GetMapScreenMarkers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.Marker>.ToLocalJniHandle (__this.MapScreenMarkers);
		}
#pragma warning restore 0169

		IntPtr id_getMapScreenMarkers;
		public unsafe global::System.Collections.Generic.IList<global::Com.Amap.Api.Maps2d.Model.Marker> MapScreenMarkers {
			get {
				if (id_getMapScreenMarkers == IntPtr.Zero)
					id_getMapScreenMarkers = JNIEnv.GetMethodID (class_ref, "getMapScreenMarkers", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amap.Api.Maps2d.Model.Marker>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapScreenMarkers), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMapType;
#pragma warning disable 0169
		static Delegate GetGetMapTypeHandler ()
		{
			if (cb_getMapType == null)
				cb_getMapType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapType);
			return cb_getMapType;
		}

		static int n_GetMapType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapType;
		}
#pragma warning restore 0169

		static Delegate cb_setMapType_I;
#pragma warning disable 0169
		static Delegate GetSetMapType_IHandler ()
		{
			if (cb_setMapType_I == null)
				cb_setMapType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMapType_I);
			return cb_setMapType_I;
		}

		static void n_SetMapType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MapType = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMapType;
		IntPtr id_setMapType_I;
		public unsafe int MapType {
			get {
				if (id_getMapType == IntPtr.Zero)
					id_getMapType = JNIEnv.GetMethodID (class_ref, "getMapType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapType);
			}
			set {
				if (id_setMapType_I == IntPtr.Zero)
					id_setMapType_I = JNIEnv.GetMethodID (class_ref, "setMapType", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapType_I, __args);
			}
		}

		static Delegate cb_getMapWidth;
#pragma warning disable 0169
		static Delegate GetGetMapWidthHandler ()
		{
			if (cb_getMapWidth == null)
				cb_getMapWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapWidth);
			return cb_getMapWidth;
		}

		static int n_GetMapWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapWidth;
		}
#pragma warning restore 0169

		IntPtr id_getMapWidth;
		public unsafe int MapWidth {
			get {
				if (id_getMapWidth == IntPtr.Zero)
					id_getMapWidth = JNIEnv.GetMethodID (class_ref, "getMapWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapWidth);
			}
		}

		static Delegate cb_getMaxZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomLevelHandler ()
		{
			if (cb_getMaxZoomLevel == null)
				cb_getMaxZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxZoomLevel);
			return cb_getMaxZoomLevel;
		}

		static float n_GetMaxZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMaxZoomLevel;
		public unsafe float MaxZoomLevel {
			get {
				if (id_getMaxZoomLevel == IntPtr.Zero)
					id_getMaxZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaxZoomLevel", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMaxZoomLevel);
			}
		}

		static Delegate cb_getMinZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMinZoomLevelHandler ()
		{
			if (cb_getMinZoomLevel == null)
				cb_getMinZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinZoomLevel);
			return cb_getMinZoomLevel;
		}

		static float n_GetMinZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMinZoomLevel;
		public unsafe float MinZoomLevel {
			get {
				if (id_getMinZoomLevel == IntPtr.Zero)
					id_getMinZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinZoomLevel", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMinZoomLevel);
			}
		}

		static Delegate cb_getMyLocation;
#pragma warning disable 0169
		static Delegate GetGetMyLocationHandler ()
		{
			if (cb_getMyLocation == null)
				cb_getMyLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMyLocation);
			return cb_getMyLocation;
		}

		static IntPtr n_GetMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyLocation);
		}
#pragma warning restore 0169

		IntPtr id_getMyLocation;
		public unsafe global::Android.Locations.Location MyLocation {
			get {
				if (id_getMyLocation == IntPtr.Zero)
					id_getMyLocation = JNIEnv.GetMethodID (class_ref, "getMyLocation", "()Landroid/location/Location;");
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMyLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isMyLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsMyLocationEnabledHandler ()
		{
			if (cb_isMyLocationEnabled == null)
				cb_isMyLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMyLocationEnabled);
			return cb_isMyLocationEnabled;
		}

		static bool n_IsMyLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MyLocationEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setMyLocationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetMyLocationEnabled_ZHandler ()
		{
			if (cb_setMyLocationEnabled_Z == null)
				cb_setMyLocationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMyLocationEnabled_Z);
			return cb_setMyLocationEnabled_Z;
		}

		static void n_SetMyLocationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MyLocationEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isMyLocationEnabled;
		IntPtr id_setMyLocationEnabled_Z;
		public unsafe bool MyLocationEnabled {
			get {
				if (id_isMyLocationEnabled == IntPtr.Zero)
					id_isMyLocationEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMyLocationEnabled);
			}
			set {
				if (id_setMyLocationEnabled_Z == IntPtr.Zero)
					id_setMyLocationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationEnabled_Z, __args);
			}
		}

		static Delegate cb_getOnCameraChangeListener;
#pragma warning disable 0169
		static Delegate GetGetOnCameraChangeListenerHandler ()
		{
			if (cb_getOnCameraChangeListener == null)
				cb_getOnCameraChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnCameraChangeListener);
			return cb_getOnCameraChangeListener;
		}

		static IntPtr n_GetOnCameraChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCameraChangeListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_Handler ()
		{
			if (cb_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_ == null)
				cb_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_);
			return cb_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_;
		}

		static void n_SetOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraChangeListener = p0;
		}
#pragma warning restore 0169

		IntPtr id_getOnCameraChangeListener;
		IntPtr id_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_;
		public unsafe global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener OnCameraChangeListener {
			get {
				if (id_getOnCameraChangeListener == IntPtr.Zero)
					id_getOnCameraChangeListener = JNIEnv.GetMethodID (class_ref, "getOnCameraChangeListener", "()Lcom/amap/api/maps2d/AMap$OnCameraChangeListener;");
				return global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnCameraChangeListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnCameraChangeListener), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_ == IntPtr.Zero)
					id_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnCameraChangeListener", "(Lcom/amap/api/maps2d/AMap$OnCameraChangeListener;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCameraChangeListener_Lcom_amap_api_maps2d_AMap_OnCameraChangeListener_, __args);
			}
		}

		static Delegate cb_getScalePerPixel;
#pragma warning disable 0169
		static Delegate GetGetScalePerPixelHandler ()
		{
			if (cb_getScalePerPixel == null)
				cb_getScalePerPixel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScalePerPixel);
			return cb_getScalePerPixel;
		}

		static float n_GetScalePerPixel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalePerPixel;
		}
#pragma warning restore 0169

		IntPtr id_getScalePerPixel;
		public unsafe float ScalePerPixel {
			get {
				if (id_getScalePerPixel == IntPtr.Zero)
					id_getScalePerPixel = JNIEnv.GetMethodID (class_ref, "getScalePerPixel", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getScalePerPixel);
			}
		}

		static Delegate cb_isTrafficEnabled;
#pragma warning disable 0169
		static Delegate GetIsTrafficEnabledHandler ()
		{
			if (cb_isTrafficEnabled == null)
				cb_isTrafficEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTrafficEnabled);
			return cb_isTrafficEnabled;
		}

		static bool n_IsTrafficEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrafficEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTrafficEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTrafficEnabled_ZHandler ()
		{
			if (cb_setTrafficEnabled_Z == null)
				cb_setTrafficEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTrafficEnabled_Z);
			return cb_setTrafficEnabled_Z;
		}

		static void n_SetTrafficEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrafficEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isTrafficEnabled;
		IntPtr id_setTrafficEnabled_Z;
		public unsafe bool TrafficEnabled {
			get {
				if (id_isTrafficEnabled == IntPtr.Zero)
					id_isTrafficEnabled = JNIEnv.GetMethodID (class_ref, "isTrafficEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTrafficEnabled);
			}
			set {
				if (id_setTrafficEnabled_Z == IntPtr.Zero)
					id_setTrafficEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTrafficEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrafficEnabled_Z, __args);
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		IntPtr id_getView;
		public unsafe global::Android.Views.View View {
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static float n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getZoomLevel;
		public unsafe float ZoomLevel {
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getZoomLevel);
			}
		}

		static Delegate cb_AMapInvalidate;
#pragma warning disable 0169
		static Delegate GetAMapInvalidateHandler ()
		{
			if (cb_AMapInvalidate == null)
				cb_AMapInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AMapInvalidate);
			return cb_AMapInvalidate;
		}

		static void n_AMapInvalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AMapInvalidate ();
		}
#pragma warning restore 0169

		IntPtr id_AMapInvalidate;
		public unsafe void AMapInvalidate ()
		{
			if (id_AMapInvalidate == IntPtr.Zero)
				id_AMapInvalidate = JNIEnv.GetMethodID (class_ref, "AMapInvalidate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_AMapInvalidate);
		}

		static Delegate cb_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_;
#pragma warning disable 0169
		static Delegate GetAddCircle_Lcom_amap_api_maps2d_model_CircleOptions_Handler ()
		{
			if (cb_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_ == null)
				cb_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCircle_Lcom_amap_api_maps2d_model_CircleOptions_);
			return cb_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_;
		}

		static IntPtr n_AddCircle_Lcom_amap_api_maps2d_model_CircleOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.CircleOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.CircleOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCircle (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.Circle AddCircle (global::Com.Amap.Api.Maps2d.Model.CircleOptions p0)
		{
			if (id_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_ == IntPtr.Zero)
				id_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_ = JNIEnv.GetMethodID (class_ref, "addCircle", "(Lcom/amap/api/maps2d/model/CircleOptions;)Lcom/amap/api/maps2d/model/Circle;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.Circle __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Circle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCircle_Lcom_amap_api_maps2d_model_CircleOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_Handler ()
		{
			if (cb_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_ == null)
				cb_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_);
			return cb_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_;
		}

		static IntPtr n_AddGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.GroundOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.GroundOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddGroundOverlay (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.GroundOverlay AddGroundOverlay (global::Com.Amap.Api.Maps2d.Model.GroundOverlayOptions p0)
		{
			if (id_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_ == IntPtr.Zero)
				id_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addGroundOverlay", "(Lcom/amap/api/maps2d/model/GroundOverlayOptions;)Lcom/amap/api/maps2d/model/GroundOverlay;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.GroundOverlay __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.GroundOverlay> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addGroundOverlay_Lcom_amap_api_maps2d_model_GroundOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_;
#pragma warning disable 0169
		static Delegate GetAddMarker_Lcom_amap_api_maps2d_model_MarkerOptions_Handler ()
		{
			if (cb_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_ == null)
				cb_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMarker_Lcom_amap_api_maps2d_model_MarkerOptions_);
			return cb_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_;
		}

		static IntPtr n_AddMarker_Lcom_amap_api_maps2d_model_MarkerOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.MarkerOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MarkerOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMarker (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.Marker AddMarker (global::Com.Amap.Api.Maps2d.Model.MarkerOptions p0)
		{
			if (id_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_ == IntPtr.Zero)
				id_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_ = JNIEnv.GetMethodID (class_ref, "addMarker", "(Lcom/amap/api/maps2d/model/MarkerOptions;)Lcom/amap/api/maps2d/model/Marker;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.Marker __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Marker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMarker_Lcom_amap_api_maps2d_model_MarkerOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_;
#pragma warning disable 0169
		static Delegate GetAddPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_Handler ()
		{
			if (cb_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_ == null)
				cb_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_);
			return cb_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_;
		}

		static IntPtr n_AddPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.PolygonOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.PolygonOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolygon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.Polygon AddPolygon (global::Com.Amap.Api.Maps2d.Model.PolygonOptions p0)
		{
			if (id_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_ == IntPtr.Zero)
				id_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_ = JNIEnv.GetMethodID (class_ref, "addPolygon", "(Lcom/amap/api/maps2d/model/PolygonOptions;)Lcom/amap/api/maps2d/model/Polygon;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.Polygon __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Polygon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPolygon_Lcom_amap_api_maps2d_model_PolygonOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_;
#pragma warning disable 0169
		static Delegate GetAddPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_Handler ()
		{
			if (cb_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_ == null)
				cb_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_);
			return cb_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_;
		}

		static IntPtr n_AddPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.PolylineOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.PolylineOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolyline (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.Polyline AddPolyline (global::Com.Amap.Api.Maps2d.Model.PolylineOptions p0)
		{
			if (id_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_ == IntPtr.Zero)
				id_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_ = JNIEnv.GetMethodID (class_ref, "addPolyline", "(Lcom/amap/api/maps2d/model/PolylineOptions;)Lcom/amap/api/maps2d/model/Polyline;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.Polyline __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Polyline> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addPolyline_Lcom_amap_api_maps2d_model_PolylineOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addText_Lcom_amap_api_maps2d_model_TextOptions_;
#pragma warning disable 0169
		static Delegate GetAddText_Lcom_amap_api_maps2d_model_TextOptions_Handler ()
		{
			if (cb_addText_Lcom_amap_api_maps2d_model_TextOptions_ == null)
				cb_addText_Lcom_amap_api_maps2d_model_TextOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddText_Lcom_amap_api_maps2d_model_TextOptions_);
			return cb_addText_Lcom_amap_api_maps2d_model_TextOptions_;
		}

		static IntPtr n_AddText_Lcom_amap_api_maps2d_model_TextOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.TextOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TextOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddText (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addText_Lcom_amap_api_maps2d_model_TextOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.Text AddText (global::Com.Amap.Api.Maps2d.Model.TextOptions p0)
		{
			if (id_addText_Lcom_amap_api_maps2d_model_TextOptions_ == IntPtr.Zero)
				id_addText_Lcom_amap_api_maps2d_model_TextOptions_ = JNIEnv.GetMethodID (class_ref, "addText", "(Lcom/amap/api/maps2d/model/TextOptions;)Lcom/amap/api/maps2d/model/Text;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.Text __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.Text> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addText_Lcom_amap_api_maps2d_model_TextOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_Handler ()
		{
			if (cb_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_ == null)
				cb_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_);
			return cb_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_;
		}

		static IntPtr n_AddTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTileOverlay (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_;
		public unsafe global::Com.Amap.Api.Maps2d.Model.TileOverlay AddTileOverlay (global::Com.Amap.Api.Maps2d.Model.TileOverlayOptions p0)
		{
			if (id_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_ == IntPtr.Zero)
				id_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addTileOverlay", "(Lcom/amap/api/maps2d/model/TileOverlayOptions;)Lcom/amap/api/maps2d/model/TileOverlay;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Amap.Api.Maps2d.Model.TileOverlay __ret = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.TileOverlay> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addTileOverlay_Lcom_amap_api_maps2d_model_TileOverlayOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_;
#pragma warning disable 0169
		static Delegate GetAnimateCamera_Lcom_amap_api_maps2d_CameraUpdate_Handler ()
		{
			if (cb_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_ == null)
				cb_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnimateCamera_Lcom_amap_api_maps2d_CameraUpdate_);
			return cb_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_;
		}

		static void n_AnimateCamera_Lcom_amap_api_maps2d_CameraUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnimateCamera (p0);
		}
#pragma warning restore 0169

		IntPtr id_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_;
		public unsafe void AnimateCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0)
		{
			if (id_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_ == IntPtr.Zero)
				id_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_ = JNIEnv.GetMethodID (class_ref, "animateCamera", "(Lcom/amap/api/maps2d/CameraUpdate;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateCamera_Lcom_amap_api_maps2d_CameraUpdate_, __args);
		}

		static Delegate cb_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetAnimateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_Handler ()
		{
			if (cb_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_ == null)
				cb_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AnimateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_);
			return cb_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_;
		}

		static void n_AnimateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p1 = (global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnimateCameraWithCallback (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_;
		public unsafe void AnimateCameraWithCallback (global::Com.Amap.Api.Maps2d.CameraUpdate p0, global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p1)
		{
			if (id_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_ == IntPtr.Zero)
				id_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_ = JNIEnv.GetMethodID (class_ref, "animateCameraWithCallback", "(Lcom/amap/api/maps2d/CameraUpdate;Lcom/amap/api/maps2d/AMap$CancelableCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateCameraWithCallback_Lcom_amap_api_maps2d_CameraUpdate_Lcom_amap_api_maps2d_AMap_CancelableCallback_, __args);
		}

		static Delegate cb_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetAnimateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_Handler ()
		{
			if (cb_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_ == null)
				cb_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_AnimateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_);
			return cb_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_;
		}

		static void n_AnimateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p2 = (global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AnimateCameraWithDurationAndCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_;
		public unsafe void AnimateCameraWithDurationAndCallback (global::Com.Amap.Api.Maps2d.CameraUpdate p0, long p1, global::Com.Amap.Api.Maps2d.AMap.ICancelableCallback p2)
		{
			if (id_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_ == IntPtr.Zero)
				id_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_ = JNIEnv.GetMethodID (class_ref, "animateCameraWithDurationAndCallback", "(Lcom/amap/api/maps2d/CameraUpdate;JLcom/amap/api/maps2d/AMap$CancelableCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_animateCameraWithDurationAndCallback_Lcom_amap_api_maps2d_CameraUpdate_JLcom_amap_api_maps2d_AMap_CancelableCallback_, __args);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate cb_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_;
#pragma warning disable 0169
		static Delegate GetGetMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_Handler ()
		{
			if (cb_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_ == null)
				cb_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_);
			return cb_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_;
		}

		static void n_GetMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetMapScreenShot (p0);
		}
#pragma warning restore 0169

		IntPtr id_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_;
		public unsafe void GetMapScreenShot (global::Com.Amap.Api.Maps2d.AMap.IOnMapScreenShotListener p0)
		{
			if (id_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_ == IntPtr.Zero)
				id_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_ = JNIEnv.GetMethodID (class_ref, "getMapScreenShot", "(Lcom/amap/api/maps2d/AMap$OnMapScreenShotListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getMapScreenShot_Lcom_amap_api_maps2d_AMap_OnMapScreenShotListener_, __args);
		}

		static Delegate cb_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_;
#pragma warning disable 0169
		static Delegate GetMoveCamera_Lcom_amap_api_maps2d_CameraUpdate_Handler ()
		{
			if (cb_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_ == null)
				cb_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MoveCamera_Lcom_amap_api_maps2d_CameraUpdate_);
			return cb_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_;
		}

		static void n_MoveCamera_Lcom_amap_api_maps2d_CameraUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveCamera (p0);
		}
#pragma warning restore 0169

		IntPtr id_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_;
		public unsafe void MoveCamera (global::Com.Amap.Api.Maps2d.CameraUpdate p0)
		{
			if (id_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_ == IntPtr.Zero)
				id_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_ = JNIEnv.GetMethodID (class_ref, "moveCamera", "(Lcom/amap/api/maps2d/CameraUpdate;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveCamera_Lcom_amap_api_maps2d_CameraUpdate_, __args);
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		IntPtr id_onPause;
		public unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		IntPtr id_onResume;
		public unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
		}

		static Delegate cb_redrawInfoWindow;
#pragma warning disable 0169
		static Delegate GetRedrawInfoWindowHandler ()
		{
			if (cb_redrawInfoWindow == null)
				cb_redrawInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RedrawInfoWindow);
			return cb_redrawInfoWindow;
		}

		static void n_RedrawInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RedrawInfoWindow ();
		}
#pragma warning restore 0169

		IntPtr id_redrawInfoWindow;
		public unsafe void RedrawInfoWindow ()
		{
			if (id_redrawInfoWindow == IntPtr.Zero)
				id_redrawInfoWindow = JNIEnv.GetMethodID (class_ref, "redrawInfoWindow", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_redrawInfoWindow);
		}

		static Delegate cb_removeGLOverlay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveGLOverlay_Ljava_lang_String_Handler ()
		{
			if (cb_removeGLOverlay_Ljava_lang_String_ == null)
				cb_removeGLOverlay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveGLOverlay_Ljava_lang_String_);
			return cb_removeGLOverlay_Ljava_lang_String_;
		}

		static bool n_RemoveGLOverlay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveGLOverlay (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeGLOverlay_Ljava_lang_String_;
		public unsafe bool RemoveGLOverlay (string p0)
		{
			if (id_removeGLOverlay_Ljava_lang_String_ == IntPtr.Zero)
				id_removeGLOverlay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeGLOverlay", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeGLOverlay_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMarker_Ljava_lang_String_Handler ()
		{
			if (cb_removeMarker_Ljava_lang_String_ == null)
				cb_removeMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveMarker_Ljava_lang_String_);
			return cb_removeMarker_Ljava_lang_String_;
		}

		static bool n_RemoveMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveMarker (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeMarker_Ljava_lang_String_;
		public unsafe bool RemoveMarker (string p0)
		{
			if (id_removeMarker_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMarker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMarker", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeMarker_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removecache;
#pragma warning disable 0169
		static Delegate GetRemovecacheHandler ()
		{
			if (cb_removecache == null)
				cb_removecache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Removecache);
			return cb_removecache;
		}

		static void n_Removecache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Removecache ();
		}
#pragma warning restore 0169

		IntPtr id_removecache;
		public unsafe void Removecache ()
		{
			if (id_removecache == IntPtr.Zero)
				id_removecache = JNIEnv.GetMethodID (class_ref, "removecache", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removecache);
		}

		static Delegate cb_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_;
#pragma warning disable 0169
		static Delegate GetRemovecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_Handler ()
		{
			if (cb_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_ == null)
				cb_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_);
			return cb_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_;
		}

		static void n_Removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Removecache (p0);
		}
#pragma warning restore 0169

		IntPtr id_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_;
		public unsafe void Removecache (global::Com.Amap.Api.Maps2d.AMap.IOnCacheRemoveListener p0)
		{
			if (id_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_ == IntPtr.Zero)
				id_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_ = JNIEnv.GetMethodID (class_ref, "removecache", "(Lcom/amap/api/maps2d/AMap$OnCacheRemoveListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removecache_Lcom_amap_api_maps2d_AMap_OnCacheRemoveListener_, __args);
		}

		static Delegate cb_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_;
#pragma warning disable 0169
		static Delegate GetSetInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_Handler ()
		{
			if (cb_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_ == null)
				cb_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_);
			return cb_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_;
		}

		static void n_SetInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter p0 = (global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInfoWindowAdapter (p0);
		}
#pragma warning restore 0169

		IntPtr id_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_;
		public unsafe void SetInfoWindowAdapter (global::Com.Amap.Api.Maps2d.AMap.IInfoWindowAdapter p0)
		{
			if (id_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_ == IntPtr.Zero)
				id_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_ = JNIEnv.GetMethodID (class_ref, "setInfoWindowAdapter", "(Lcom/amap/api/maps2d/AMap$InfoWindowAdapter;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInfoWindowAdapter_Lcom_amap_api_maps2d_AMap_InfoWindowAdapter_, __args);
		}

		static Delegate cb_setLocationSource_Lcom_amap_api_maps2d_LocationSource_;
#pragma warning disable 0169
		static Delegate GetSetLocationSource_Lcom_amap_api_maps2d_LocationSource_Handler ()
		{
			if (cb_setLocationSource_Lcom_amap_api_maps2d_LocationSource_ == null)
				cb_setLocationSource_Lcom_amap_api_maps2d_LocationSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationSource_Lcom_amap_api_maps2d_LocationSource_);
			return cb_setLocationSource_Lcom_amap_api_maps2d_LocationSource_;
		}

		static void n_SetLocationSource_Lcom_amap_api_maps2d_LocationSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.ILocationSource p0 = (global::Com.Amap.Api.Maps2d.ILocationSource)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.ILocationSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocationSource (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLocationSource_Lcom_amap_api_maps2d_LocationSource_;
		public unsafe void SetLocationSource (global::Com.Amap.Api.Maps2d.ILocationSource p0)
		{
			if (id_setLocationSource_Lcom_amap_api_maps2d_LocationSource_ == IntPtr.Zero)
				id_setLocationSource_Lcom_amap_api_maps2d_LocationSource_ = JNIEnv.GetMethodID (class_ref, "setLocationSource", "(Lcom/amap/api/maps2d/LocationSource;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationSource_Lcom_amap_api_maps2d_LocationSource_, __args);
		}

		static Delegate cb_setMapLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMapLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_setMapLanguage_Ljava_lang_String_ == null)
				cb_setMapLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapLanguage_Ljava_lang_String_);
			return cb_setMapLanguage_Ljava_lang_String_;
		}

		static void n_SetMapLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMapLanguage (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMapLanguage_Ljava_lang_String_;
		public unsafe void SetMapLanguage (string p0)
		{
			if (id_setMapLanguage_Ljava_lang_String_ == IntPtr.Zero)
				id_setMapLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMapLanguage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapLanguage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setMyLocationRotateAngle_F;
#pragma warning disable 0169
		static Delegate GetSetMyLocationRotateAngle_FHandler ()
		{
			if (cb_setMyLocationRotateAngle_F == null)
				cb_setMyLocationRotateAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMyLocationRotateAngle_F);
			return cb_setMyLocationRotateAngle_F;
		}

		static void n_SetMyLocationRotateAngle_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMyLocationRotateAngle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMyLocationRotateAngle_F;
		public unsafe void SetMyLocationRotateAngle (float p0)
		{
			if (id_setMyLocationRotateAngle_F == IntPtr.Zero)
				id_setMyLocationRotateAngle_F = JNIEnv.GetMethodID (class_ref, "setMyLocationRotateAngle", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationRotateAngle_F, __args);
		}

		static Delegate cb_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_;
#pragma warning disable 0169
		static Delegate GetSetMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_Handler ()
		{
			if (cb_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_ == null)
				cb_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_);
			return cb_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_;
		}

		static void n_SetMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.Model.MyLocationStyle p0 = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.Model.MyLocationStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMyLocationStyle (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_;
		public unsafe void SetMyLocationStyle (global::Com.Amap.Api.Maps2d.Model.MyLocationStyle p0)
		{
			if (id_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_ == IntPtr.Zero)
				id_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_ = JNIEnv.GetMethodID (class_ref, "setMyLocationStyle", "(Lcom/amap/api/maps2d/model/MyLocationStyle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationStyle_Lcom_amap_api_maps2d_model_MyLocationStyle_, __args);
		}

		static Delegate cb_setMyLocationType_I;
#pragma warning disable 0169
		static Delegate GetSetMyLocationType_IHandler ()
		{
			if (cb_setMyLocationType_I == null)
				cb_setMyLocationType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMyLocationType_I);
			return cb_setMyLocationType_I;
		}

		static void n_SetMyLocationType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMyLocationType (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMyLocationType_I;
		public unsafe void SetMyLocationType (int p0)
		{
			if (id_setMyLocationType_I == IntPtr.Zero)
				id_setMyLocationType_I = JNIEnv.GetMethodID (class_ref, "setMyLocationType", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMyLocationType_I, __args);
		}

		static Delegate cb_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_Handler ()
		{
			if (cb_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_ == null)
				cb_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_);
			return cb_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_;
		}

		static void n_SetOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoWindowClickListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_;
		public unsafe void SetOnInfoWindowClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnInfoWindowClickListener p0)
		{
			if (id_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_ == IntPtr.Zero)
				id_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoWindowClickListener", "(Lcom/amap/api/maps2d/AMap$OnInfoWindowClickListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnInfoWindowClickListener_Lcom_amap_api_maps2d_AMap_OnInfoWindowClickListener_, __args);
		}

		static Delegate cb_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_Handler ()
		{
			if (cb_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_ == null)
				cb_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_);
			return cb_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_;
		}

		static void n_SetOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapClickListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_;
		public unsafe void SetOnMapClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapClickListener p0)
		{
			if (id_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_ == IntPtr.Zero)
				id_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapClickListener", "(Lcom/amap/api/maps2d/AMap$OnMapClickListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapClickListener_Lcom_amap_api_maps2d_AMap_OnMapClickListener_, __args);
		}

		static Delegate cb_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_Handler ()
		{
			if (cb_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_ == null)
				cb_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_);
			return cb_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_;
		}

		static void n_SetOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLongClickListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_;
		public unsafe void SetOnMapLongClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapLongClickListener p0)
		{
			if (id_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_ == IntPtr.Zero)
				id_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapLongClickListener", "(Lcom/amap/api/maps2d/AMap$OnMapLongClickListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapLongClickListener_Lcom_amap_api_maps2d_AMap_OnMapLongClickListener_, __args);
		}

		static Delegate cb_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_Handler ()
		{
			if (cb_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_ == null)
				cb_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_);
			return cb_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_;
		}

		static void n_SetOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapTouchListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_;
		public unsafe void SetOnMapTouchListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapTouchListener p0)
		{
			if (id_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_ == IntPtr.Zero)
				id_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapTouchListener", "(Lcom/amap/api/maps2d/AMap$OnMapTouchListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMapTouchListener_Lcom_amap_api_maps2d_AMap_OnMapTouchListener_, __args);
		}

		static Delegate cb_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_Handler ()
		{
			if (cb_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_ == null)
				cb_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_);
			return cb_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_;
		}

		static void n_SetOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMaploadedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_;
		public unsafe void SetOnMaploadedListener (global::Com.Amap.Api.Maps2d.AMap.IOnMapLoadedListener p0)
		{
			if (id_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_ == IntPtr.Zero)
				id_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_ = JNIEnv.GetMethodID (class_ref, "setOnMaploadedListener", "(Lcom/amap/api/maps2d/AMap$OnMapLoadedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMaploadedListener_Lcom_amap_api_maps2d_AMap_OnMapLoadedListener_, __args);
		}

		static Delegate cb_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_Handler ()
		{
			if (cb_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_ == null)
				cb_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_);
			return cb_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_;
		}

		static void n_SetOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerClickListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_;
		public unsafe void SetOnMarkerClickListener (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerClickListener p0)
		{
			if (id_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_ == IntPtr.Zero)
				id_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerClickListener", "(Lcom/amap/api/maps2d/AMap$OnMarkerClickListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMarkerClickListener_Lcom_amap_api_maps2d_AMap_OnMarkerClickListener_, __args);
		}

		static Delegate cb_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_Handler ()
		{
			if (cb_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_ == null)
				cb_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_);
			return cb_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_;
		}

		static void n_SetOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerDragListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_;
		public unsafe void SetOnMarkerDragListener (global::Com.Amap.Api.Maps2d.AMap.IOnMarkerDragListener p0)
		{
			if (id_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_ == IntPtr.Zero)
				id_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerDragListener", "(Lcom/amap/api/maps2d/AMap$OnMarkerDragListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMarkerDragListener_Lcom_amap_api_maps2d_AMap_OnMarkerDragListener_, __args);
		}

		static Delegate cb_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_Handler ()
		{
			if (cb_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_ == null)
				cb_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_);
			return cb_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_;
		}

		static void n_SetOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener p0 = (global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener)global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMyLocationChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_;
		public unsafe void SetOnMyLocationChangeListener (global::Com.Amap.Api.Maps2d.AMap.IOnMyLocationChangeListener p0)
		{
			if (id_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_ == IntPtr.Zero)
				id_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnMyLocationChangeListener", "(Lcom/amap/api/maps2d/AMap$OnMyLocationChangeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMyLocationChangeListener_Lcom_amap_api_maps2d_AMap_OnMyLocationChangeListener_, __args);
		}

		static Delegate cb_setZOrderOnTop_Z;
#pragma warning disable 0169
		static Delegate GetSetZOrderOnTop_ZHandler ()
		{
			if (cb_setZOrderOnTop_Z == null)
				cb_setZOrderOnTop_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZOrderOnTop_Z);
			return cb_setZOrderOnTop_Z;
		}

		static void n_SetZOrderOnTop_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZOrderOnTop (p0);
		}
#pragma warning restore 0169

		IntPtr id_setZOrderOnTop_Z;
		public unsafe void SetZOrderOnTop (bool p0)
		{
			if (id_setZOrderOnTop_Z == IntPtr.Zero)
				id_setZOrderOnTop_Z = JNIEnv.GetMethodID (class_ref, "setZOrderOnTop", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZOrderOnTop_Z, __args);
		}

		static Delegate cb_setZoomPosition_I;
#pragma warning disable 0169
		static Delegate GetSetZoomPosition_IHandler ()
		{
			if (cb_setZoomPosition_I == null)
				cb_setZoomPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoomPosition_I);
			return cb_setZoomPosition_I;
		}

		static void n_SetZoomPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_setZoomPosition_I;
		public unsafe void SetZoomPosition (int p0)
		{
			if (id_setZoomPosition_I == IntPtr.Zero)
				id_setZoomPosition_I = JNIEnv.GetMethodID (class_ref, "setZoomPosition", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoomPosition_I, __args);
		}

		static Delegate cb_showCompassEnabled_Z;
#pragma warning disable 0169
		static Delegate GetShowCompassEnabled_ZHandler ()
		{
			if (cb_showCompassEnabled_Z == null)
				cb_showCompassEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowCompassEnabled_Z);
			return cb_showCompassEnabled_Z;
		}

		static void n_ShowCompassEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCompassEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_showCompassEnabled_Z;
		public unsafe void ShowCompassEnabled (bool p0)
		{
			if (id_showCompassEnabled_Z == IntPtr.Zero)
				id_showCompassEnabled_Z = JNIEnv.GetMethodID (class_ref, "showCompassEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showCompassEnabled_Z, __args);
		}

		static Delegate cb_showMyLocationButtonEnabled_Z;
#pragma warning disable 0169
		static Delegate GetShowMyLocationButtonEnabled_ZHandler ()
		{
			if (cb_showMyLocationButtonEnabled_Z == null)
				cb_showMyLocationButtonEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowMyLocationButtonEnabled_Z);
			return cb_showMyLocationButtonEnabled_Z;
		}

		static void n_ShowMyLocationButtonEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowMyLocationButtonEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_showMyLocationButtonEnabled_Z;
		public unsafe void ShowMyLocationButtonEnabled (bool p0)
		{
			if (id_showMyLocationButtonEnabled_Z == IntPtr.Zero)
				id_showMyLocationButtonEnabled_Z = JNIEnv.GetMethodID (class_ref, "showMyLocationButtonEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showMyLocationButtonEnabled_Z, __args);
		}

		static Delegate cb_showMyLocationOverlay_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetShowMyLocationOverlay_Landroid_location_Location_Handler ()
		{
			if (cb_showMyLocationOverlay_Landroid_location_Location_ == null)
				cb_showMyLocationOverlay_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowMyLocationOverlay_Landroid_location_Location_);
			return cb_showMyLocationOverlay_Landroid_location_Location_;
		}

		static void n_ShowMyLocationOverlay_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowMyLocationOverlay (p0);
		}
#pragma warning restore 0169

		IntPtr id_showMyLocationOverlay_Landroid_location_Location_;
		public unsafe void ShowMyLocationOverlay (global::Android.Locations.Location p0)
		{
			if (id_showMyLocationOverlay_Landroid_location_Location_ == IntPtr.Zero)
				id_showMyLocationOverlay_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "showMyLocationOverlay", "(Landroid/location/Location;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showMyLocationOverlay_Landroid_location_Location_, __args);
		}

		static Delegate cb_showScaleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetShowScaleEnabled_ZHandler ()
		{
			if (cb_showScaleEnabled_Z == null)
				cb_showScaleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowScaleEnabled_Z);
			return cb_showScaleEnabled_Z;
		}

		static void n_ShowScaleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowScaleEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_showScaleEnabled_Z;
		public unsafe void ShowScaleEnabled (bool p0)
		{
			if (id_showScaleEnabled_Z == IntPtr.Zero)
				id_showScaleEnabled_Z = JNIEnv.GetMethodID (class_ref, "showScaleEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showScaleEnabled_Z, __args);
		}

		static Delegate cb_showZoomControlsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetShowZoomControlsEnabled_ZHandler ()
		{
			if (cb_showZoomControlsEnabled_Z == null)
				cb_showZoomControlsEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowZoomControlsEnabled_Z);
			return cb_showZoomControlsEnabled_Z;
		}

		static void n_ShowZoomControlsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowZoomControlsEnabled (p0);
		}
#pragma warning restore 0169

		IntPtr id_showZoomControlsEnabled_Z;
		public unsafe void ShowZoomControlsEnabled (bool p0)
		{
			if (id_showZoomControlsEnabled_Z == IntPtr.Zero)
				id_showZoomControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "showZoomControlsEnabled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showZoomControlsEnabled_Z, __args);
		}

		static Delegate cb_stopAnimation;
#pragma warning disable 0169
		static Delegate GetStopAnimationHandler ()
		{
			if (cb_stopAnimation == null)
				cb_stopAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAnimation);
			return cb_stopAnimation;
		}

		static void n_StopAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amap.Api.Interfaces.IAMap __this = global::Java.Lang.Object.GetObject<global::Com.Amap.Api.Interfaces.IAMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		IntPtr id_stopAnimation;
		public unsafe void StopAnimation ()
		{
			if (id_stopAnimation == IntPtr.Zero)
				id_stopAnimation = JNIEnv.GetMethodID (class_ref, "stopAnimation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAnimation);
		}

	}

}
