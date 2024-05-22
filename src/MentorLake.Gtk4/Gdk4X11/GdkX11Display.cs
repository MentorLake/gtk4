namespace MentorLake.Gtk4.Gdk4X11;

public class GdkX11DisplayHandle : GdkDisplayHandle
{
	public static GdkDisplayHandle Open(string display_name)
	{
		return GdkX11DisplayExterns.gdk_x11_display_open(display_name);
	}

	public static void SetProgramClass(GdkDisplayHandle display, string program_class)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_program_class(display, program_class);
	}

}

public static class GdkX11DisplaySignalExtensions
{

	public static IObservable<GdkX11DisplaySignalStructs.XeventSignal> Signal_Xevent(this GdkX11DisplayHandle instance)
	{
		return Observable.Create((IObserver<GdkX11DisplaySignalStructs.XeventSignal> obs) =>
		{
			GdkX11DisplaySignalDelegates.xevent handler = (GdkX11DisplayHandle self, IntPtr xevent, IntPtr user_data) =>
			{
				

				var signalStruct = new GdkX11DisplaySignalStructs.XeventSignal()
				{
					Self = self, Xevent = xevent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "xevent", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GdkX11DisplaySignalStructs
{

public struct XeventSignal
{
	public GdkX11DisplayHandle Self;
	public IntPtr Xevent;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GdkX11DisplaySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool xevent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkX11DisplayHandle>))] GdkX11DisplayHandle self, IntPtr xevent, IntPtr user_data);

}


public static class GdkX11DisplayHandleExtensions
{
	public static GdkX11DisplayHandle BroadcastStartupMessage(this GdkX11DisplayHandle display, string message_type, IntPtr @__arglist)
	{
		GdkX11DisplayExterns.gdk_x11_display_broadcast_startup_message(display, message_type, @__arglist);
		return display;
	}

	public static int ErrorTrapPop(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_error_trap_pop(display);
	}

	public static GdkX11DisplayHandle ErrorTrapPopIgnored(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_error_trap_pop_ignored(display);
		return display;
	}

	public static GdkX11DisplayHandle ErrorTrapPush(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_error_trap_push(display);
		return display;
	}

	public static GdkSurfaceHandle GetDefaultGroup(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_default_group(display);
	}

	public static IntPtr GetEglDisplay(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_egl_display(display);
	}

	public static bool GetEglVersion(this GdkX11DisplayHandle display, out int major, out int minor)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_egl_version(display, out major, out minor);
	}

	public static bool GetGlxVersion(this GdkX11DisplayHandle display, out int major, out int minor)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_glx_version(display, out major, out minor);
	}

	public static GdkMonitorHandle GetPrimaryMonitor(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_primary_monitor(display);
	}

	public static GdkX11ScreenHandle GetScreen(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_screen(display);
	}

	public static string GetStartupNotificationId(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_startup_notification_id(display);
	}

	public static uint GetUserTime(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_user_time(display);
	}

	public static IntPtr GetXcursor(this GdkX11DisplayHandle display, GdkCursorHandle cursor)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_xcursor(display, cursor);
	}

	public static IntPtr GetXdisplay(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_xdisplay(display);
	}

	public static IntPtr GetXrootwindow(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_xrootwindow(display);
	}

	public static IntPtr GetXscreen(this GdkX11DisplayHandle display)
	{
		return GdkX11DisplayExterns.gdk_x11_display_get_xscreen(display);
	}

	public static GdkX11DisplayHandle Grab(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_grab(display);
		return display;
	}

	public static GdkX11DisplayHandle SetCursorTheme(this GdkX11DisplayHandle display, string theme, int size)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_cursor_theme(display, theme, size);
		return display;
	}

	public static GdkX11DisplayHandle SetStartupNotificationId(this GdkX11DisplayHandle display, string startup_id)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_startup_notification_id(display, startup_id);
		return display;
	}

	public static GdkX11DisplayHandle SetSurfaceScale(this GdkX11DisplayHandle display, int scale)
	{
		GdkX11DisplayExterns.gdk_x11_display_set_surface_scale(display, scale);
		return display;
	}

	public static int StringToCompoundText(this GdkX11DisplayHandle display, string str, out string encoding, out int format, out string ctext, out int length)
	{
		return GdkX11DisplayExterns.gdk_x11_display_string_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

	public static int TextPropertyToTextList(this GdkX11DisplayHandle display, string encoding, int format, string text, int length, ref string[] list)
	{
		return GdkX11DisplayExterns.gdk_x11_display_text_property_to_text_list(display, encoding, format, text, length, ref list);
	}

	public static GdkX11DisplayHandle Ungrab(this GdkX11DisplayHandle display)
	{
		GdkX11DisplayExterns.gdk_x11_display_ungrab(display);
		return display;
	}

	public static bool Utf8ToCompoundText(this GdkX11DisplayHandle display, string str, out string encoding, out int format, out string ctext, out int length)
	{
		return GdkX11DisplayExterns.gdk_x11_display_utf8_to_compound_text(display, str, out encoding, out format, out ctext, out length);
	}

}

internal class GdkX11DisplayExterns
{
	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_broadcast_startup_message(GdkDisplayHandle display, string message_type, IntPtr @__arglist);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern int gdk_x11_display_error_trap_pop(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_error_trap_pop_ignored(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_error_trap_push(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkSurfaceHandle gdk_x11_display_get_default_group(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_display_get_egl_display(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern bool gdk_x11_display_get_egl_version(GdkDisplayHandle display, out int major, out int minor);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern bool gdk_x11_display_get_glx_version(GdkDisplayHandle display, out int major, out int minor);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkMonitorHandle gdk_x11_display_get_primary_monitor(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkX11ScreenHandle gdk_x11_display_get_screen(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_x11_display_get_startup_notification_id(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern uint gdk_x11_display_get_user_time(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_display_get_xcursor(GdkDisplayHandle display, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_display_get_xdisplay(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_display_get_xrootwindow(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern IntPtr gdk_x11_display_get_xscreen(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_grab(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_set_cursor_theme(GdkDisplayHandle display, string theme, int size);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_set_startup_notification_id(GdkDisplayHandle display, string startup_id);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_set_surface_scale(GdkDisplayHandle display, int scale);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern int gdk_x11_display_string_to_compound_text(GdkDisplayHandle display, string str, out string encoding, out int format, out string ctext, out int length);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern int gdk_x11_display_text_property_to_text_list(GdkDisplayHandle display, string encoding, int format, string text, int length, ref string[] list);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_ungrab(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern bool gdk_x11_display_utf8_to_compound_text(GdkDisplayHandle display, string str, out string encoding, out int format, out string ctext, out int length);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkDisplayHandle gdk_x11_display_open(string display_name);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_display_set_program_class(GdkDisplayHandle display, string program_class);

}
