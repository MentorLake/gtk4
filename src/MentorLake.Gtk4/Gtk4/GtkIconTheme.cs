using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

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

public class GtkIconThemeSignal
{
	public string Value { get; set; }
	public GtkIconThemeSignal(string value) => Value = value;
}

public static class GtkIconThemeSignals
{
	public static GtkIconThemeSignal Changed = new("changed");
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

	public static GtkIconThemeHandle Connect(this GtkIconThemeHandle instance, GtkIconThemeSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
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
