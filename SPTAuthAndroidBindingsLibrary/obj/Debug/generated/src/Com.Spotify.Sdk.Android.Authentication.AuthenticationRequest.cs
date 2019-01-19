using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationRequest", DoNotGenerateAcw=true)]
	public partial class AuthenticationRequest : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationRequest$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationRequest$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/constructor[@name='AuthenticationRequest.Builder' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationResponse.Type'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;Ljava/lang/String;)V", "")]
			public unsafe Builder (string clientId, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type responseType, string redirectUri)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientId = JNIEnv.NewString (clientId);
				IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_clientId);
					__args [1] = new JniArgumentValue ((responseType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) responseType).Handle);
					__args [2] = new JniArgumentValue (native_redirectUri);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientId);
					JNIEnv.DeleteLocalRef (native_redirectUri);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/sdk/android/authentication/AuthenticationRequest;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest Build ()
			{
				const string __id = "build.()Lcom/spotify/sdk/android/authentication/AuthenticationRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCampaign_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCampaign_Ljava_lang_String_Handler ()
			{
				if (cb_setCampaign_Ljava_lang_String_ == null)
					cb_setCampaign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCampaign_Ljava_lang_String_);
				return cb_setCampaign_Ljava_lang_String_;
			}

			static IntPtr n_SetCampaign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_campaign)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string campaign = JNIEnv.GetString (native_campaign, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCampaign (campaign));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setCampaign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCampaign", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetCampaign_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetCampaign (string campaign)
			{
				const string __id = "setCampaign.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;";
				IntPtr native_campaign = JNIEnv.NewString (campaign);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_campaign);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_campaign);
				}
			}

			static Delegate cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCustomParam_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomParam_Ljava_lang_String_Ljava_lang_String_);
				return cb_setCustomParam_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_SetCustomParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomParam (key, value));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setCustomParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setCustomParam", "(Ljava/lang/String;Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetCustomParam_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetCustomParam (string key, string value)
			{
				const string __id = "setCustomParam.(Ljava/lang/String;Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;";
				IntPtr native_key = JNIEnv.NewString (key);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_key);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_setScopes_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetScopes_arrayLjava_lang_String_Handler ()
			{
				if (cb_setScopes_arrayLjava_lang_String_ == null)
					cb_setScopes_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetScopes_arrayLjava_lang_String_);
				return cb_setScopes_arrayLjava_lang_String_;
			}

			static IntPtr n_SetScopes_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scopes)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] scopes = (string[]) JNIEnv.GetArray (native_scopes, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetScopes (scopes));
				if (scopes != null)
					JNIEnv.CopyArray (scopes, native_scopes);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setScopes' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
			[Register ("setScopes", "([Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetScopes_arrayLjava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetScopes (string[] scopes)
			{
				const string __id = "setScopes.([Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;";
				IntPtr native_scopes = JNIEnv.NewArray (scopes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scopes);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (scopes != null) {
						JNIEnv.CopyArray (native_scopes, scopes);
						JNIEnv.DeleteLocalRef (native_scopes);
					}
				}
			}

			static Delegate cb_setShowDialog_Z;
#pragma warning disable 0169
			static Delegate GetSetShowDialog_ZHandler ()
			{
				if (cb_setShowDialog_Z == null)
					cb_setShowDialog_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShowDialog_Z);
				return cb_setShowDialog_Z;
			}

			static IntPtr n_SetShowDialog_Z (IntPtr jnienv, IntPtr native__this, bool showDialog)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShowDialog (showDialog));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setShowDialog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowDialog", "(Z)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetShowDialog_ZHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetShowDialog (bool showDialog)
			{
				const string __id = "setShowDialog.(Z)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (showDialog);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetState_Ljava_lang_String_Handler ()
			{
				if (cb_setState_Ljava_lang_String_ == null)
					cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetState_Ljava_lang_String_);
				return cb_setState_Ljava_lang_String_;
			}

			static IntPtr n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetState (state));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.Builder']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;", "GetSetState_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder SetState (string state)
			{
				const string __id = "setState.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationRequest$Builder;";
				IntPtr native_state = JNIEnv.NewString (state);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_state);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_state);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationRequest$QueryParams", DoNotGenerateAcw=true)]
		public sealed partial class QueryParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='CLIENT_ID']"
			[Register ("CLIENT_ID")]
			public const string ClientId = (string) "client_id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='REDIRECT_URI']"
			[Register ("REDIRECT_URI")]
			public const string RedirectUri = (string) "redirect_uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='RESPONSE_TYPE']"
			[Register ("RESPONSE_TYPE")]
			public const string ResponseType = (string) "response_type";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='SCOPE']"
			[Register ("SCOPE")]
			public const string Scope = (string) "scope";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='SHOW_DIALOG']"
			[Register ("SHOW_DIALOG")]
			public const string ShowDialog = (string) "show_dialog";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='STATE']"
			[Register ("STATE")]
			public const string State = (string) "state";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='UTM_CAMPAIGN']"
			[Register ("UTM_CAMPAIGN")]
			public const string UtmCampaign = (string) "utm_campaign";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='UTM_MEDIUM']"
			[Register ("UTM_MEDIUM")]
			public const string UtmMedium = (string) "utm_medium";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest.QueryParams']/field[@name='UTM_SOURCE']"
			[Register ("UTM_SOURCE")]
			public const string UtmSource = (string) "utm_source";
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationRequest$QueryParams", typeof (QueryParams));
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationRequest", typeof (AuthenticationRequest));
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

		protected AuthenticationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/constructor[@name='AuthenticationRequest' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe AuthenticationRequest (global::Android.OS.Parcel source)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCampaign;
#pragma warning disable 0169
		static Delegate GetGetCampaignHandler ()
		{
			if (cb_getCampaign == null)
				cb_getCampaign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaign);
			return cb_getCampaign;
		}

		static IntPtr n_GetCampaign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Campaign);
		}
#pragma warning restore 0169

		public virtual unsafe string Campaign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getCampaign' and count(parameter)=0]"
			[Register ("getCampaign", "()Ljava/lang/String;", "GetGetCampaignHandler")]
			get {
				const string __id = "getCampaign.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				const string __id = "getClientId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				const string __id = "getRedirectUri.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseType;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeHandler ()
		{
			if (cb_getResponseType == null)
				cb_getResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseType);
			return cb_getResponseType;
		}

		static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseType);
		}
#pragma warning restore 0169

		public virtual unsafe string ResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getResponseType' and count(parameter)=0]"
			[Register ("getResponseType", "()Ljava/lang/String;", "GetGetResponseTypeHandler")]
			get {
				const string __id = "getResponseType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getCustomParam_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCustomParam_Ljava_lang_String_Handler ()
		{
			if (cb_getCustomParam_Ljava_lang_String_ == null)
				cb_getCustomParam_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCustomParam_Ljava_lang_String_);
			return cb_getCustomParam_Ljava_lang_String_;
		}

		static IntPtr n_GetCustomParam_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetCustomParam (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getCustomParam' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCustomParam", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetCustomParam_Ljava_lang_String_Handler")]
		public virtual unsafe string GetCustomParam (string key)
		{
			const string __id = "getCustomParam.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetScopes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='getScopes' and count(parameter)=0]"
		[Register ("getScopes", "()[Ljava/lang/String;", "GetGetScopesHandler")]
		public virtual unsafe string[] GetScopes ()
		{
			const string __id = "getScopes.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_toUri;
#pragma warning disable 0169
		static Delegate GetToUriHandler ()
		{
			if (cb_toUri == null)
				cb_toUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUri);
			return cb_toUri;
		}

		static IntPtr n_ToUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToUri ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='toUri' and count(parameter)=0]"
		[Register ("toUri", "()Landroid/net/Uri;", "GetToUriHandler")]
		public virtual unsafe global::Android.Net.Uri ToUri ()
		{
			const string __id = "toUri.()Landroid/net/Uri;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationRequest']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
