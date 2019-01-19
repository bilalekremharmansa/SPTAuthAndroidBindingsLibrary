using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/LoginActivity", DoNotGenerateAcw=true)]
	public partial class LoginActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/field[@name='REQUEST_CODE']"
		[Register ("REQUEST_CODE")]
		public const int RequestCode = (int) 1138;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/field[@name='REQUEST_KEY']"
		[Register ("REQUEST_KEY")]
		public const string RequestKey = (string) "request";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/field[@name='RESPONSE_KEY']"
		[Register ("RESPONSE_KEY")]
		public const string ResponseKey = (string) "response";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/LoginActivity", typeof (LoginActivity));
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

		protected LoginActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/constructor[@name='LoginActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoginActivity ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/method[@name='getAuthIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("getAuthIntent", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetAuthIntent (global::Android.App.Activity contextActivity, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request)
		{
			const string __id = "getAuthIntent.(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onClientCancelled;
#pragma warning disable 0169
		static Delegate GetOnClientCancelledHandler ()
		{
			if (cb_onClientCancelled == null)
				cb_onClientCancelled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClientCancelled);
			return cb_onClientCancelled;
		}

		static void n_OnClientCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.LoginActivity __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.LoginActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClientCancelled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/method[@name='onClientCancelled' and count(parameter)=0]"
		[Register ("onClientCancelled", "()V", "GetOnClientCancelledHandler")]
		public virtual unsafe void OnClientCancelled ()
		{
			const string __id = "onClientCancelled.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
#pragma warning disable 0169
		static Delegate GetOnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Handler ()
		{
			if (cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ == null)
				cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_);
			return cb_onClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
		}

		static void n_OnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response)
		{
			global::Com.Spotify.Sdk.Android.Authentication.LoginActivity __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.LoginActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse response = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OnClientComplete (response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='LoginActivity']/method[@name='onClientComplete' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationResponse']]"
		[Register ("onClientComplete", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V", "GetOnClientComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Handler")]
		public virtual unsafe void OnClientComplete (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse response)
		{
			const string __id = "onClientComplete.(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
