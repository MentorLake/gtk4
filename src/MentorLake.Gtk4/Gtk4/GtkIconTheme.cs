namespace MentorLake.Gtk4.Gtk4;

public class GtkIconThemeHandle : GObjectHandle
{
	public static GtkIconThemeHandle New()
	{
		return GtkIconThemeExterns.gtk_icon_theme_new();
	}

	public static GtkIconThemeHandle GetForDisplay(GdkDisplayHandle display)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_for_display(display);
	}

}

public static class GtkIconThemeSignalExtensions
{

	public static IObservable<GtkIconThemeSignalStructs.ChangedSignal> Signal_Changed(this GtkIconThemeHandle instance)
	{
		return Observable.Create((IObserver<GtkIconThemeSignalStructs.ChangedSignal> obs) =>
		{
			GtkIconThemeSignalDelegates.Changed handler = (GtkIconThemeHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconThemeSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
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

public static class GtkIconThemeSignalStructs
{

public struct ChangedSignal
{
	public GtkIconThemeHandle Self;
	public IntPtr UserData;
}
}

public static class GtkIconThemeSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconThemeHandle>))] GtkIconThemeHandle self, IntPtr user_data);
}


public static class GtkIconThemeHandleExtensions
{
	public static GtkIconThemeHandle AddResourcePath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_add_resource_path(self, path);
		return self;
	}

	public static GtkIconThemeHandle AddSearchPath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_add_search_path(self, path);
		return self;
	}

	public static GdkDisplayHandle GetDisplay(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_display(self);
	}

	public static string[] GetIconNames(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_icon_names(self);
	}

	public static int[] GetIconSizes(this GtkIconThemeHandle self, string icon_name)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_icon_sizes(self, icon_name);
	}

	public static string[] GetResourcePath(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_resource_path(self);
	}

	public static string[] GetSearchPath(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_search_path(self);
	}

	public static string GetThemeName(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_theme_name(self);
	}

	public static bool HasGicon(this GtkIconThemeHandle self, GIconHandle gicon)
	{
		return GtkIconThemeExterns.gtk_icon_theme_has_gicon(self, gicon);
	}

	public static bool HasIcon(this GtkIconThemeHandle self, string icon_name)
	{
		return GtkIconThemeExterns.gtk_icon_theme_has_icon(self, icon_name);
	}

	public static GtkIconPaintableHandle LookupByGicon(this GtkIconThemeHandle self, GIconHandle icon, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_by_gicon(self, icon, size, scale, direction, flags);
	}

	public static GtkIconPaintableHandle LookupIcon(this GtkIconThemeHandle self, string icon_name, string[] fallbacks, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_icon(self, icon_name, fallbacks, size, scale, direction, flags);
	}

	public static GtkIconThemeHandle SetResourcePath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_set_resource_path(self, path);
		return self;
	}

	public static GtkIconThemeHandle SetSearchPath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_set_search_path(self, path);
		return self;
	}

	public static GtkIconThemeHandle SetThemeName(this GtkIconThemeHandle self, string theme_name)
	{
		GtkIconThemeExterns.gtk_icon_theme_set_theme_name(self, theme_name);
		return self;
	}

}

internal class GtkIconThemeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIconThemeHandle gtk_icon_theme_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_icon_theme_add_resource_path(GtkIconThemeHandle self, string path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_icon_theme_add_search_path(GtkIconThemeHandle self, string path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDisplayHandle gtk_icon_theme_get_display(GtkIconThemeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_icon_theme_get_icon_names(GtkIconThemeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int[] gtk_icon_theme_get_icon_sizes(GtkIconThemeHandle self, string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_icon_theme_get_resource_path(GtkIconThemeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern string[] gtk_icon_theme_get_search_path(GtkIconThemeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_icon_theme_get_theme_name(GtkIconThemeHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_icon_theme_has_gicon(GtkIconThemeHandle self, GIconHandle gicon);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_icon_theme_has_icon(GtkIconThemeHandle self, string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIconPaintableHandle gtk_icon_theme_lookup_by_gicon(GtkIconThemeHandle self, GIconHandle icon, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIconPaintableHandle gtk_icon_theme_lookup_icon(GtkIconThemeHandle self, string icon_name, string[] fallbacks, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_icon_theme_set_resource_path(GtkIconThemeHandle self, string path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_icon_theme_set_search_path(GtkIconThemeHandle self, string path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_icon_theme_set_theme_name(GtkIconThemeHandle self, string theme_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIconThemeHandle gtk_icon_theme_get_for_display(GdkDisplayHandle display);

}
