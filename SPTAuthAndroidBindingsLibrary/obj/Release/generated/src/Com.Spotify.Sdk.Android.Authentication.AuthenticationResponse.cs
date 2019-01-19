using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse", DoNotGenerateAcw=true)]
	public partial class AuthenticationResponse : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationResponse$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/constructor[@name='AuthenticationResponse.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse Build ()
			{
				const string __id = "build.()Lcom/spotify/sdk/android/authentication/AuthenticationResponse;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
			{
				if (cb_setAccessToken_Ljava_lang_String_ == null)
					cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
				return cb_setAccessToken_Ljava_lang_String_;
			}

			static IntPtr n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccessToken (accessToken));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetAccessToken_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetAccessToken (string accessToken)
			{
				const string __id = "setAccessToken.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;";
				IntPtr native_accessToken = JNIEnv.NewString (accessToken);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_accessToken);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_accessToken);
				}
			}

			static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCode_Ljava_lang_String_Handler ()
			{
				if (cb_setCode_Ljava_lang_String_ == null)
					cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCode_Ljava_lang_String_);
				return cb_setCode_Ljava_lang_String_;
			}

			static IntPtr n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_code)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string code = JNIEnv.GetString (native_code, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCode (code));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetCode (string code)
			{
				const string __id = "setCode.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;";
				IntPtr native_code = JNIEnv.NewString (code);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_code);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_code);
				}
			}

			static Delegate cb_setError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetError_Ljava_lang_String_Handler ()
			{
				if (cb_setError_Ljava_lang_String_ == null)
					cb_setError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetError_Ljava_lang_String_);
				return cb_setError_Ljava_lang_String_;
			}

			static IntPtr n_SetError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string error = JNIEnv.GetString (native_error, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetError (error));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setError", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetError_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetError (string error)
			{
				const string __id = "setError.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;";
				IntPtr native_error = JNIEnv.NewString (error);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_error);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_error);
				}
			}

			static Delegate cb_setExpiresIn_I;
#pragma warning disable 0169
			static Delegate GetSetExpiresIn_IHandler ()
			{
				if (cb_setExpiresIn_I == null)
					cb_setExpiresIn_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetExpiresIn_I);
				return cb_setExpiresIn_I;
			}

			static IntPtr n_SetExpiresIn_I (IntPtr jnienv, IntPtr native__this, int expiresIn)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetExpiresIn (expiresIn));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setExpiresIn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setExpiresIn", "(I)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetExpiresIn_IHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetExpiresIn (int expiresIn)
			{
				const string __id = "setExpiresIn.(I)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (expiresIn);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetState (state));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setState", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetState_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetState (string state)
			{
				const string __id = "setState.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;";
				IntPtr native_state = JNIEnv.NewString (state);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_state);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_state);
				}
			}

			static Delegate cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_;
#pragma warning disable 0169
			static Delegate GetSetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Handler ()
			{
				if (cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ == null)
					cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_);
				return cb_setType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_;
			}

			static IntPtr n_SetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
			{
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type type = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (native_type, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (type));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Builder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationResponse.Type']]"
			[Register ("setType", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;", "GetSetType_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Type_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder SetType (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type type)
			{
				const string __id = "setType.(Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse$QueryParams", DoNotGenerateAcw=true)]
		public sealed partial class QueryParams : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='ACCESS_TOKEN']"
			[Register ("ACCESS_TOKEN")]
			public const string AccessToken = (string) "access_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='CODE']"
			[Register ("CODE")]
			public const string Code = (string) "code";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const string Error = (string) "error";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='EXPIRES_IN']"
			[Register ("EXPIRES_IN")]
			public const string ExpiresIn = (string) "expires_in";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.QueryParams']/field[@name='STATE']"
			[Register ("STATE")]
			public const string State = (string) "state";
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationResponse$QueryParams", typeof (QueryParams));
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationResponse$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='CODE']"
			[Register ("CODE")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Code {
				get {
					const string __id = "CODE.Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='EMPTY']"
			[Register ("EMPTY")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Empty {
				get {
					const string __id = "EMPTY.Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Error {
				get {
					const string __id = "ERROR.Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='TOKEN']"
			[Register ("TOKEN")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Token {
				get {
					const string __id = "TOKEN.Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationResponse$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;", "")]
			public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;", "")]
			public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type[] Values ()
			{
				const string __id = "values.()[Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationResponse", typeof (AuthenticationResponse));
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

		protected AuthenticationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/constructor[@name='AuthenticationResponse' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe AuthenticationResponse (global::Android.OS.Parcel source)
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

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				const string __id = "getCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static int n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		public virtual unsafe int ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()I", "GetGetExpiresInHandler")]
			get {
				const string __id = "getExpiresIn.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getState' and count(parameter)=0]"
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='fromUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("fromUri", "(Landroid/net/Uri;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse FromUri (global::Android.Net.Uri uri)
		{
			const string __id = "fromUri.(Landroid/net/Uri;)Lcom/spotify/sdk/android/authentication/AuthenticationResponse;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type GetType ()
		{
			const string __id = "getType.()Lcom/spotify/sdk/android/authentication/AuthenticationResponse$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/class[@name='AuthenticationResponse']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
