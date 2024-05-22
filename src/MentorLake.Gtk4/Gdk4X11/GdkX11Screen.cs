namespace MentorLake.Gtk4.Gdk4X11;

public class GdkX11ScreenHandle : GObjectHandle
{
}

public static class GdkX11ScreenSignalExtensions
{

	public static IObservable<GdkX11ScreenSignalStructs.WindowManagerChangedSignal> Signal_WindowManagerChanged(this GdkX11ScreenHandle instance)
	{
		return Observable.Create((IObserver<GdkX11ScreenSignalStructs.WindowManagerChangedSignal> obs) =>
		{
			GdkX11ScreenSignalDelegates.window_manager_changed handler = (GdkX11ScreenHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkX11ScreenSignalStructs.WindowManagerChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "window_manager_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkX11ScreenSignalStructs
{

public struct WindowManagerChangedSignal
{
	public GdkX11ScreenHandle Self;
	public IntPtr UserData;
}
}

public static class GdkX11ScreenSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void window_manager_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkX11ScreenHandle>))] GdkX11ScreenHandle self, IntPtr user_data);

}


public static class GdkX11ScreenHandleExtensions
{
	public static uint GetCurrentDesktop(this GdkX11ScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_current_desktop(screen);
	}

	public static ulong GetMonitorOutput(this GdkX11ScreenHandle screen, int monitor_num)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_monitor_output(screen, monitor_num);
	}

	public static uint GetNumberOfDesktops(this GdkX11ScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_number_of_desktops(screen);
	}

	public static int GetScreenNumber(this GdkX11ScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_screen_number(screen);
	}

	public static string GetWindowManagerName(this GdkX11ScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_window_manager_name(screen);
	}

	public static IntPtr GetXscreen(this GdkX11ScreenHandle screen)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_get_xscreen(screen);
	}

	public static bool SupportsNetWmHint(this GdkX11ScreenHandle screen, string property_name)
	{
		return GdkX11ScreenExterns.gdk_x11_screen_supports_net_wm_hint(screen, property_name);
	}

}

internal class GdkX11ScreenExterns
{
	[DllImport(Libraries.Gdk4X11)]
	internal static extern uint gdk_x11_screen_get_current_desktop(GdkX11ScreenHandle screen);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern ulong gdk_x11_screen_get_monitor_output(GdkX11ScreenHandle screen, int monitor_num);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern uint gdk_x11_screen_get_number_of_desktops(GdkX11ScreenHandle screen);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern int gdk_x11_screen_get_screen_number(GdkX11ScreenHandle screen);

	[DllImport(Libraries.Gdk4X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_screen_get_window_manager_name(GdkX11ScreenHandle screen);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_screen_get_xscreen(GdkX11ScreenHandle screen);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern bool gdk_x11_screen_supports_net_wm_hint(GdkX11ScreenHandle screen, string property_name);

}
