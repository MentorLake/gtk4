namespace MentorLake.Gtk4.Gio;

public class GFileMonitorHandle : GObjectHandle
{
}

public static class GFileMonitorSignalExtensions
{

	public static IObservable<GFileMonitorSignalStructs.ChangedSignal> Signal_Changed(this GFileMonitorHandle instance)
	{
		return Observable.Create((IObserver<GFileMonitorSignalStructs.ChangedSignal> obs) =>
		{
			GFileMonitorSignalDelegates.changed handler = (GFileMonitorHandle self, GFileHandle file, GFileHandle other_file, GFileMonitorEvent event_type, IntPtr user_data) =>
			{


				var signalStruct = new GFileMonitorSignalStructs.ChangedSignal()
				{
					Self = self, File = file, OtherFile = other_file, EventType = event_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GFileMonitorSignalStructs
{

public struct ChangedSignal
{
	public GFileMonitorHandle Self;
	public GFileHandle File;
	public GFileHandle OtherFile;
	public GFileMonitorEvent EventType;
	public IntPtr UserData;
}
}

public static class GFileMonitorSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileMonitorHandle>))] GFileMonitorHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileHandleImpl>))] GFileHandle file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileHandleImpl>))] GFileHandle other_file, GFileMonitorEvent event_type, IntPtr user_data);

}


public static class GFileMonitorHandleExtensions
{
	public static bool Cancel(this GFileMonitorHandle monitor)
	{
		return GFileMonitorExterns.g_file_monitor_cancel(monitor);
	}

	public static GFileMonitorHandle EmitEvent(this GFileMonitorHandle monitor, GFileHandle child, GFileHandle other_file, GFileMonitorEvent event_type)
	{
		GFileMonitorExterns.g_file_monitor_emit_event(monitor, child, other_file, event_type);
		return monitor;
	}

	public static bool IsCancelled(this GFileMonitorHandle monitor)
	{
		return GFileMonitorExterns.g_file_monitor_is_cancelled(monitor);
	}

	public static GFileMonitorHandle SetRateLimit(this GFileMonitorHandle monitor, int limit_msecs)
	{
		GFileMonitorExterns.g_file_monitor_set_rate_limit(monitor, limit_msecs);
		return monitor;
	}

}

internal class GFileMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_monitor_cancel(GFileMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_monitor_emit_event(GFileMonitorHandle monitor, GFileHandle child, GFileHandle other_file, GFileMonitorEvent event_type);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_monitor_is_cancelled(GFileMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_monitor_set_rate_limit(GFileMonitorHandle monitor, int limit_msecs);

}
