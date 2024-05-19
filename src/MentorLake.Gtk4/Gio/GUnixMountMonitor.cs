namespace MentorLake.Gtk4.Gio;

public class GUnixMountMonitorHandle : GObjectHandle
{
	public static GUnixMountMonitorHandle New()
	{
		return GUnixMountMonitorExterns.g_unix_mount_monitor_new();
	}

	public static GUnixMountMonitorHandle Get()
	{
		return GUnixMountMonitorExterns.g_unix_mount_monitor_get();
	}

}

public static class GUnixMountMonitorSignalExtensions
{

	public static IObservable<GUnixMountMonitorSignalStructs.MountpointsChangedSignal> Signal_MountpointsChanged(this GUnixMountMonitorHandle instance)
	{
		return Observable.Create((IObserver<GUnixMountMonitorSignalStructs.MountpointsChangedSignal> obs) =>
		{
			GUnixMountMonitorSignalDelegates.MountpointsChanged handler = (GUnixMountMonitorHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GUnixMountMonitorSignalStructs.MountpointsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mountpoints_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GUnixMountMonitorSignalStructs.MountsChangedSignal> Signal_MountsChanged(this GUnixMountMonitorHandle instance)
	{
		return Observable.Create((IObserver<GUnixMountMonitorSignalStructs.MountsChangedSignal> obs) =>
		{
			GUnixMountMonitorSignalDelegates.MountsChanged handler = (GUnixMountMonitorHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GUnixMountMonitorSignalStructs.MountsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mounts_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GUnixMountMonitorSignalStructs
{

public struct MountpointsChangedSignal
{
	public GUnixMountMonitorHandle Self;
	public IntPtr UserData;
}

public struct MountsChangedSignal
{
	public GUnixMountMonitorHandle Self;
	public IntPtr UserData;
}
}

public static class GUnixMountMonitorSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountpointsChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GUnixMountMonitorHandle>))] GUnixMountMonitorHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountsChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GUnixMountMonitorHandle>))] GUnixMountMonitorHandle self, IntPtr user_data);
}


public static class GUnixMountMonitorHandleExtensions
{
	public static GUnixMountMonitorHandle SetRateLimit(this GUnixMountMonitorHandle mount_monitor, int limit_msec)
	{
		GUnixMountMonitorExterns.g_unix_mount_monitor_set_rate_limit(mount_monitor, limit_msec);
		return mount_monitor;
	}

}

internal class GUnixMountMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountMonitorHandle g_unix_mount_monitor_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_mount_monitor_set_rate_limit(GUnixMountMonitorHandle mount_monitor, int limit_msec);

	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountMonitorHandle g_unix_mount_monitor_get();

}
