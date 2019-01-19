using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationClient", DoNotGenerateAcw=true)]
	public partial class AuthenticationClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationClient$QueryParams", DoNotGenerateAcw=true)]
		public sealed partial class QueryParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='ID']"
			[Register ("ID")]
			public const string Id = (string) "id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='REFERRER']"
			[Register ("REFERRER")]
			public const string Referrer = (string) "referrer";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='UTM_CAMPAIGN']"
			[Register ("UTM_CAMPAIGN")]
			public const string UtmCampaign = (string) "utm_campaign";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='UTM_MEDIUM']"
			[Register ("UTM_MEDIUM")]
			public const string UtmMedium = (string) "utm_medium";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient.QueryParams']/field[@name='UTM_SOURCE']"
			[Register ("UTM_SOURCE")]
			public const string UtmSource = (string) "utm_source";
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationClient$QueryParams", typeof (QueryParams));
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

			internal QueryParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationClient", typeof (AuthenticationClient));
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

		protected AuthenticationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/constructor[@name='AuthenticationClient' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe AuthenticationClient (global::Android.App.Activity activity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='createLoginActivityIntent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("createLoginActivityIntent", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateLoginActivityIntent (global::Android.App.Activity contextActivity, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request)
		{
			const string __id = "createLoginActivityIntent.(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='getResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("getResponse", "(ILandroid/content/Intent;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse GetResponse (int resultCode, global::Android.Content.Intent intent)
		{
			const string __id = "getResponse.(ILandroid/content/Intent;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resultCode);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='isAvailable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("isAvailable", "(Landroid/content/Context;Landroid/content/Intent;)Z", "")]
		public static unsafe bool IsAvailable (global::Android.Content.Context ctx, global::Android.Content.Intent intent)
		{
			const string __id = "isAvailable.(Landroid/content/Context;Landroid/content/Intent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openDownloadSpotifyActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("openDownloadSpotifyActivity", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OpenDownloadSpotifyActivity (global::Android.App.Activity contextActivity)
		{
			const string __id = "openDownloadSpotifyActivity.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openDownloadSpotifyActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("openDownloadSpotifyActivity", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public static unsafe void OpenDownloadSpotifyActivity (global::Android.App.Activity contextActivity, string campaign)
		{
			const string __id = "openDownloadSpotifyActivity.(Landroid/app/Activity;Ljava/lang/String;)V";
			IntPtr native_campaign = JNIEnv.NewString (campaign);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue (native_campaign);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_campaign);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openLoginActivity' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("openLoginActivity", "(Landroid/app/Activity;ILcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", "")]
		public static unsafe void OpenLoginActivity (global::Android.App.Activity contextActivity, int requestCode, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request)
		{
			const string __id = "openLoginActivity.(Landroid/app/Activity;ILcom/spotify/sdk/android/authentication/AuthenticationRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue (requestCode);
				__args [2] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='openLoginInBrowser' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("openLoginInBrowser", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V", "")]
		public static unsafe void OpenLoginInBrowser (global::Android.App.Activity contextActivity, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest request)
		{
			const string __id = "openLoginInBrowser.(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationClient']/method[@name='stopLoginActivity' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("stopLoginActivity", "(Landroid/app/Activity;I)V", "")]
		public static unsafe void StopLoginActivity (global::Android.App.Activity contextActivity, int requestCode)
		{
			const string __id = "stopLoginActivity.(Landroid/app/Activity;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((contextActivity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contextActivity).Handle);
				__args [1] = new JniArgumentValue (requestCode);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
