using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Spotify.Sdk.Android.Authentication {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler.OnCompleteListener']"
	[Register ("com/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener", "", "Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerInvoker")]
	public partial interface IAuthenticationHandlerOnCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler.OnCompleteListener']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerInvoker, SPTAuthAndroidBindingsLibrary")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler.OnCompleteListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationResponse']]"
		[Register ("onComplete", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V", "GetOnComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Handler:Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerInvoker, SPTAuthAndroidBindingsLibrary")]
		void OnComplete (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler.OnCompleteListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListenerInvoker, SPTAuthAndroidBindingsLibrary")]
		void OnError (global::Java.Lang.Throwable p0);

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener", DoNotGenerateAcw=true)]
	internal class IAuthenticationHandlerOnCompleteListenerInvoker : global::Java.Lang.Object, IAuthenticationHandlerOnCompleteListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener", typeof (IAuthenticationHandlerOnCompleteListenerInvoker));

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

		public static IAuthenticationHandlerOnCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticationHandlerOnCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.authentication.AuthenticationHandler.OnCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticationHandlerOnCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
		}

		static Delegate cb_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_Handler ()
		{
			if (cb_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ == null)
				cb_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_);
			return cb_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
		}

		static void n_OnComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_;
		public unsafe void OnComplete (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0)
		{
			if (id_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ == IntPtr.Zero)
				id_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/spotify/sdk/android/authentication/AuthenticationResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcom_spotify_sdk_android_authentication_AuthenticationResponse_, __args);
		}

		static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
			return cb_onError_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
		}

	}

	// event args for com.spotify.sdk.android.authentication.AuthenticationHandler.OnCompleteListener.onComplete
	public partial class CompleteEventArgs : global::System.EventArgs {

		public CompleteEventArgs (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0)
		{
			this.p0 = p0;
		}

		global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0;
		public global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse P0 {
			get { return p0; }
		}
	}

	// event args for com.spotify.sdk.android.authentication.AuthenticationHandler.OnCompleteListener.onError
	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Java.Lang.Throwable p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Throwable p0;
		public global::Java.Lang.Throwable P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/spotify/sdk/android/authentication/AuthenticationHandler_OnCompleteListenerImplementor")]
	internal sealed partial class IAuthenticationHandlerOnCompleteListenerImplementor : global::Java.Lang.Object, IAuthenticationHandlerOnCompleteListener {

		object sender;

		public IAuthenticationHandlerOnCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/spotify/sdk/android/authentication/AuthenticationHandler_OnCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnCancelHandler;
#pragma warning restore 0649

		public void OnCancel ()
		{
			var __h = OnCancelHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<CompleteEventArgs> OnCompleteHandler;
#pragma warning restore 0649

		public void OnComplete (global::Com.Spotify.Sdk.Android.Authentication.AuthenticationResponse p0)
		{
			var __h = OnCompleteHandler;
			if (__h != null)
				__h (sender, new CompleteEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Java.Lang.Throwable p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IAuthenticationHandlerOnCompleteListenerImplementor value)
		{
			return value.OnCancelHandler == null && value.OnCompleteHandler == null && value.OnErrorHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler']"
	[Register ("com/spotify/sdk/android/authentication/AuthenticationHandler", "", "Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerInvoker")]
	public partial interface IAuthenticationHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler']/method[@name='setOnCompleteListener' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.authentication.AuthenticationHandler.OnCompleteListener']]"
		[Register ("setOnCompleteListener", "(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V", "GetSetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_Handler:Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerInvoker, SPTAuthAndroidBindingsLibrary")]
		void SetOnCompleteListener (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.spotify.sdk.android.authentication.AuthenticationRequest']]"
		[Register ("start", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z", "GetStart_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_Handler:Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerInvoker, SPTAuthAndroidBindingsLibrary")]
		bool Start (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.authentication']/interface[@name='AuthenticationHandler']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerInvoker, SPTAuthAndroidBindingsLibrary")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/authentication/AuthenticationHandler", DoNotGenerateAcw=true)]
	internal class IAuthenticationHandlerInvoker : global::Java.Lang.Object, IAuthenticationHandler {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/spotify/sdk/android/authentication/AuthenticationHandler", typeof (IAuthenticationHandlerInvoker));

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

		public static IAuthenticationHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthenticationHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.authentication.AuthenticationHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthenticationHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_Handler ()
		{
			if (cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ == null)
				cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_);
			return cb_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
		}

		static void n_SetOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener p0 = (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompleteListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_;
		public unsafe void SetOnCompleteListener (global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandlerOnCompleteListener p0)
		{
			if (id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ == IntPtr.Zero)
				id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompleteListener", "(Lcom/spotify/sdk/android/authentication/AuthenticationHandler$OnCompleteListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompleteListener_Lcom_spotify_sdk_android_authentication_AuthenticationHandler_OnCompleteListener_, __args);
		}

		static Delegate cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
#pragma warning disable 0169
		static Delegate GetStart_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_Handler ()
		{
			if (cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == null)
				cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_);
			return cb_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		}

		static bool n_Start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Start (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_;
		public unsafe bool Start (global::Android.App.Activity p0, global::Com.Spotify.Sdk.Android.Authentication.AuthenticationRequest p1)
		{
			if (id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ == IntPtr.Zero)
				id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_ = JNIEnv.GetMethodID (class_ref, "start", "(Landroid/app/Activity;Lcom/spotify/sdk/android/authentication/AuthenticationRequest;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_start_Landroid_app_Activity_Lcom_spotify_sdk_android_authentication_AuthenticationRequest_, __args);
			return __ret;
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
			global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Authentication.IAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
