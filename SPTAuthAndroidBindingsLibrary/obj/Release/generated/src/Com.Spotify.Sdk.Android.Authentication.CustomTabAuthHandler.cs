using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/CustomTabAuthHandler", DoNotGenerateAcw=true)]
	public partial class CustomTabAuthHandler : global::Java.Lang.Object, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/CustomTabAuthHandler", typeof (CustomTabAuthHandler));
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

		protected CustomTabAuthHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/constructor[@name='CustomTabAuthHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomTabAuthHandler ()
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

		static Delegate cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_Handler ()
		{
			if (cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ == null)
				cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_);
			return cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
		}

		static void n_SetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener listener = (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompleteListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/method[@name='setOnCompleteListener' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationHandler.OnCompleteListener']]"
		[Register ("setOnCompleteListener", "(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V", "GetSetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_Handler")]
		public virtual unsafe void SetOnCompleteListener (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener listener)
		{
			const string __id = "setOnCompleteListener.(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_Handler ()
		{
			if (cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == null)
				cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_);
			return cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		}

		static bool n_Start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contextActivity, IntPtr native_request)
		{
			global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity contextActivity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_contextActivity, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (contextActivity, request);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("start", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z", "GetStart_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_Handler")]
		public virtual unsafe bool Start (global::Android.App.Activity contextActivity, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request)
		{
			const string __id = "start.(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.CustomTabAuthHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='CustomTabAuthHandler']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener"
		public event EventHandler Cancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIAuthenticationHandlerOnCompleteListenerImplementor,
						SetOnCompleteListener,
						__h => __h.OnCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.OnCancelHandler -= value);
			}
		}

		public event EventHandler<global::Com.Spotify.Sdk.Android.Authentication.CompleteEventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIAuthenticationHandlerOnCompleteListenerImplementor,
						SetOnCompleteListener,
						__h => __h.OnCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.OnCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Com.Spotify.Sdk.Android.Authentication.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIAuthenticationHandlerOnCompleteListenerImplementor,
						SetOnCompleteListener,
						__h => __h.OnErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener, global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.OnErrorHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCompleteListener;

		global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor __CreateIAuthenticationHandlerOnCompleteListenerImplementor ()
		{
			return new global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerImplementor (this);
		}
#endregion
	}
}
