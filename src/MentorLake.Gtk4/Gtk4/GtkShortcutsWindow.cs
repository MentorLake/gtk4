namespace MentorLake.Gtk4.Gtk4;

public class GtkShortcutsWindowHandle : GtkWindowHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
}

public static class GtkShortcutsWindowSignalExtensions
{

	public static IObservable<GtkShortcutsWindowSignalStructs.CloseSignal> Signal_Close(this GtkShortcutsWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowSignalStructs.CloseSignal> obs) =>
		{
			GtkShortcutsWindowSignalDelegates.Close handler = (GtkShortcutsWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkShortcutsWindowSignalStructs.SearchSignal> Signal_Search(this GtkShortcutsWindowHandle instance)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowSignalStructs.SearchSignal> obs) =>
		{
			GtkShortcutsWindowSignalDelegates.Search handler = (GtkShortcutsWindowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowSignalStructs.SearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkShortcutsWindowSignalStructs
{

public struct CloseSignal
{
	public GtkShortcutsWindowHandle Self;
	public IntPtr UserData;
}

public struct SearchSignal
{
	public GtkShortcutsWindowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkShortcutsWindowSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsWindowHandle>))] GtkShortcutsWindowHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsWindowHandle>))] GtkShortcutsWindowHandle self, IntPtr user_data);
}


public static class GtkShortcutsWindowHandleExtensions
{
	public static GtkShortcutsWindowHandle AddSection(this GtkShortcutsWindowHandle self, GtkShortcutsSectionHandle section)
	{
		GtkShortcutsWindowExterns.gtk_shortcuts_window_add_section(self, section);
		return self;
	}

}

internal class GtkShortcutsWindowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_window_add_section(GtkShortcutsWindowHandle self, GtkShortcutsSectionHandle section);

}
