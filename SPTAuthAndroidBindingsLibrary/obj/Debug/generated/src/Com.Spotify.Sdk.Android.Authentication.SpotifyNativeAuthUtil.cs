using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/SpotifyNativeAuthUtil", DoNotGenerateAcw=true)]
	public partial class SpotifyNativeAuthUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/SpotifyNativeAuthUtil", typeof (SpotifyNativeAuthUtil));
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

		protected SpotifyNativeAuthUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']/constructor[@name='SpotifyNativeAuthUtil' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", "")]
		public unsafe SpotifyNativeAuthUtil (global::Android.App.Activity contextActivity, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startAuthActivity;
#pragma warning disable 0169
		static Delegate GetStartAuthActivityHandler ()
		{
			if (cb_startAuthActivity == null)
				cb_startAuthActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartAuthActivity);
			return cb_startAuthActivity;
		}

		static bool n_StartAuthActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartAuthActivity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']/method[@name='startAuthActivity' and count(parameter)=0]"
		[Register ("startAuthActivity", "()Z", "GetStartAuthActivityHandler")]
		public virtual unsafe bool StartAuthActivity ()
		{
			const string __id = "startAuthActivity.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopAuthActivity;
#pragma warning disable 0169
		static Delegate GetStopAuthActivityHandler ()
		{
			if (cb_stopAuthActivity == null)
				cb_stopAuthActivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAuthActivity);
			return cb_stopAuthActivity;
		}

		static void n_StopAuthActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.SpotifyNativeAuthUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAuthActivity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='SpotifyNativeAuthUtil']/method[@name='stopAuthActivity' and count(parameter)=0]"
		[Register ("stopAuthActivity", "()V", "GetStopAuthActivityHandler")]
		public virtual unsafe void StopAuthActivity ()
		{
			const string __id = "stopAuthActivity.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
