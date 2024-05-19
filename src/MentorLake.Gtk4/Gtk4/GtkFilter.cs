namespace MentorLake.Gtk4.Gtk4;

public class GtkFilterHandle : GObjectHandle
{
}

public static class GtkFilterSignalExtensions
{

	public static IObservable<GtkFilterSignalStructs.ChangedSignal> Signal_Changed(this GtkFilterHandle instance)
	{
		return Observable.Create((IObserver<GtkFilterSignalStructs.ChangedSignal> obs) =>
		{
			GtkFilterSignalDelegates.Changed handler = (GtkFilterHandle self, GtkFilterChange change, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFilterSignalStructs.ChangedSignal()
				{
					Self = self, Change = change, UserData = user_data
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

public static class GtkFilterSignalStructs
{

public struct ChangedSignal
{
	public GtkFilterHandle Self;
	public GtkFilterChange Change;
	public IntPtr UserData;
}
}

public static class GtkFilterSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFilterHandle>))] GtkFilterHandle self, GtkFilterChange change, IntPtr user_data);
}


public static class GtkFilterHandleExtensions
{
	public static GtkFilterHandle Changed(this GtkFilterHandle self, GtkFilterChange change)
	{
		GtkFilterExterns.gtk_filter_changed(self, change);
		return self;
	}

	public static GtkFilterMatch GetStrictness(this GtkFilterHandle self)
	{
		return GtkFilterExterns.gtk_filter_get_strictness(self);
	}

	public static bool Match(this GtkFilterHandle self, GObjectHandle item)
	{
		return GtkFilterExterns.gtk_filter_match(self, item);
	}

}

internal class GtkFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_filter_changed(GtkFilterHandle self, GtkFilterChange change);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFilterMatch gtk_filter_get_strictness(GtkFilterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_filter_match(GtkFilterHandle self, GObjectHandle item);

}
