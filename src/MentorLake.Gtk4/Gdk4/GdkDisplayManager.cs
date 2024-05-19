namespace MentorLake.Gtk4.Gdk4;

public class GdkDisplayManagerHandle : GObjectHandle
{
	public static GdkDisplayManagerHandle Get()
	{
		return GdkDisplayManagerExterns.gdk_display_manager_get();
	}

}

public static class GdkDisplayManagerSignalExtensions
{

	public static IObservable<GdkDisplayManagerSignalStructs.DisplayOpenedSignal> Signal_DisplayOpened(this GdkDisplayManagerHandle instance)
	{
		return Observable.Create((IObserver<GdkDisplayManagerSignalStructs.DisplayOpenedSignal> obs) =>
		{
			GdkDisplayManagerSignalDelegates.DisplayOpened handler = (GdkDisplayManagerHandle self, GdkDisplayHandle display, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkDisplayManagerSignalStructs.DisplayOpenedSignal()
				{
					Self = self, Display = display, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "display_opened", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkDisplayManagerSignalStructs
{

public struct DisplayOpenedSignal
{
	public GdkDisplayManagerHandle Self;
	public GdkDisplayHandle Display;
	public IntPtr UserData;
}
}

public static class GdkDisplayManagerSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DisplayOpened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayManagerHandle>))] GdkDisplayManagerHandle self, GdkDisplayHandle display, IntPtr user_data);
}


public static class GdkDisplayManagerHandleExtensions
{
	public static GdkDisplayHandle GetDefaultDisplay(this GdkDisplayManagerHandle manager)
	{
		return GdkDisplayManagerExterns.gdk_display_manager_get_default_display(manager);
	}

	public static GSListHandle ListDisplays(this GdkDisplayManagerHandle manager)
	{
		return GdkDisplayManagerExterns.gdk_display_manager_list_displays(manager);
	}

	public static GdkDisplayHandle OpenDisplay(this GdkDisplayManagerHandle manager, string name)
	{
		return GdkDisplayManagerExterns.gdk_display_manager_open_display(manager, name);
	}

	public static GdkDisplayManagerHandle SetDefaultDisplay(this GdkDisplayManagerHandle manager, GdkDisplayHandle display)
	{
		GdkDisplayManagerExterns.gdk_display_manager_set_default_display(manager, display);
		return manager;
	}

}

internal class GdkDisplayManagerExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_display_manager_get_default_display(GdkDisplayManagerHandle manager);

	[DllImport(Libraries.Gdk4)]
	internal static extern GSListHandle gdk_display_manager_list_displays(GdkDisplayManagerHandle manager);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_display_manager_open_display(GdkDisplayManagerHandle manager, string name);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_manager_set_default_display(GdkDisplayManagerHandle manager, GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayManagerHandle gdk_display_manager_get();

}
