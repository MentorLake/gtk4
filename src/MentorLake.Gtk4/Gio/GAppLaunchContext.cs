namespace MentorLake.Gtk4.Gio;

public class GAppLaunchContextHandle : GObjectHandle
{
	public static GAppLaunchContextHandle New()
	{
		return GAppLaunchContextExterns.g_app_launch_context_new();
	}

}

public static class GAppLaunchContextSignalExtensions
{

	public static IObservable<GAppLaunchContextSignalStructs.LaunchFailedSignal> Signal_LaunchFailed(this GAppLaunchContextHandle instance)
	{
		return Observable.Create((IObserver<GAppLaunchContextSignalStructs.LaunchFailedSignal> obs) =>
		{
			GAppLaunchContextSignalDelegates.LaunchFailed handler = (GAppLaunchContextHandle self, string startup_notify_id, IntPtr user_data) =>
			{
				

				var signalStruct = new GAppLaunchContextSignalStructs.LaunchFailedSignal()
				{
					Self = self, StartupNotifyId = startup_notify_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "launch_failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GAppLaunchContextSignalStructs.LaunchStartedSignal> Signal_LaunchStarted(this GAppLaunchContextHandle instance)
	{
		return Observable.Create((IObserver<GAppLaunchContextSignalStructs.LaunchStartedSignal> obs) =>
		{
			GAppLaunchContextSignalDelegates.LaunchStarted handler = (GAppLaunchContextHandle self, GAppInfoHandle info, GVariantHandle platform_data, IntPtr user_data) =>
			{
				

				var signalStruct = new GAppLaunchContextSignalStructs.LaunchStartedSignal()
				{
					Self = self, Info = info, PlatformData = platform_data, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "launch_started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GAppLaunchContextSignalStructs.LaunchedSignal> Signal_Launched(this GAppLaunchContextHandle instance)
	{
		return Observable.Create((IObserver<GAppLaunchContextSignalStructs.LaunchedSignal> obs) =>
		{
			GAppLaunchContextSignalDelegates.Launched handler = (GAppLaunchContextHandle self, GAppInfoHandle info, GVariantHandle platform_data, IntPtr user_data) =>
			{
				

				var signalStruct = new GAppLaunchContextSignalStructs.LaunchedSignal()
				{
					Self = self, Info = info, PlatformData = platform_data, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "launched", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GAppLaunchContextSignalStructs
{

public struct LaunchFailedSignal
{
	public GAppLaunchContextHandle Self;
	public string StartupNotifyId;
	public IntPtr UserData;
}

public struct LaunchStartedSignal
{
	public GAppLaunchContextHandle Self;
	public GAppInfoHandle Info;
	public GVariantHandle PlatformData;
	public IntPtr UserData;
}

public struct LaunchedSignal
{
	public GAppLaunchContextHandle Self;
	public GAppInfoHandle Info;
	public GVariantHandle PlatformData;
	public IntPtr UserData;
}
}

public static class GAppLaunchContextSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void LaunchFailed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GAppLaunchContextHandle>))] GAppLaunchContextHandle self, string startup_notify_id, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void LaunchStarted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GAppLaunchContextHandle>))] GAppLaunchContextHandle self, GAppInfoHandle info, GVariantHandle platform_data, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Launched([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GAppLaunchContextHandle>))] GAppLaunchContextHandle self, GAppInfoHandle info, GVariantHandle platform_data, IntPtr user_data);
}


public static class GAppLaunchContextHandleExtensions
{
	public static string GetDisplay(this GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files)
	{
		return GAppLaunchContextExterns.g_app_launch_context_get_display(context, info, files);
	}

	public static string[] GetEnvironment(this GAppLaunchContextHandle context)
	{
		return GAppLaunchContextExterns.g_app_launch_context_get_environment(context);
	}

	public static string GetStartupNotifyId(this GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files)
	{
		return GAppLaunchContextExterns.g_app_launch_context_get_startup_notify_id(context, info, files);
	}

	public static GAppLaunchContextHandle LaunchFailed(this GAppLaunchContextHandle context, string startup_notify_id)
	{
		GAppLaunchContextExterns.g_app_launch_context_launch_failed(context, startup_notify_id);
		return context;
	}

	public static GAppLaunchContextHandle Setenv(this GAppLaunchContextHandle context, string variable, string value)
	{
		GAppLaunchContextExterns.g_app_launch_context_setenv(context, variable, value);
		return context;
	}

	public static GAppLaunchContextHandle Unsetenv(this GAppLaunchContextHandle context, string variable)
	{
		GAppLaunchContextExterns.g_app_launch_context_unsetenv(context, variable);
		return context;
	}

}

internal class GAppLaunchContextExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GAppLaunchContextHandle g_app_launch_context_new();

	[DllImport(Libraries.Gio)]
	internal static extern string g_app_launch_context_get_display(GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_app_launch_context_get_environment(GAppLaunchContextHandle context);

	[DllImport(Libraries.Gio)]
	internal static extern string g_app_launch_context_get_startup_notify_id(GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files);

	[DllImport(Libraries.Gio)]
	internal static extern void g_app_launch_context_launch_failed(GAppLaunchContextHandle context, string startup_notify_id);

	[DllImport(Libraries.Gio)]
	internal static extern void g_app_launch_context_setenv(GAppLaunchContextHandle context, string variable, string value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_app_launch_context_unsetenv(GAppLaunchContextHandle context, string variable);

}
