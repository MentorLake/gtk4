using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIconThemeAdaptors
{
	public static GdkDisplayHandle GetDisplay(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_display(self);
	}

	public static GtkIconThemeHandle SetSearchPath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_set_search_path(self, path);
		return self;
	}

	public static string[] GetSearchPath(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_search_path(self);
	}

	public static GtkIconThemeHandle AddSearchPath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_add_search_path(self, path);
		return self;
	}

	public static GtkIconThemeHandle SetResourcePath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_set_resource_path(self, path);
		return self;
	}

	public static string[] GetResourcePath(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_resource_path(self);
	}

	public static GtkIconThemeHandle AddResourcePath(this GtkIconThemeHandle self, string path)
	{
		GtkIconThemeExterns.gtk_icon_theme_add_resource_path(self, path);
		return self;
	}

	public static GtkIconThemeHandle SetThemeName(this GtkIconThemeHandle self, string theme_name)
	{
		GtkIconThemeExterns.gtk_icon_theme_set_theme_name(self, theme_name);
		return self;
	}

	public static string GetThemeName(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_theme_name(self);
	}

	public static int HasIcon(this GtkIconThemeHandle self, string icon_name)
	{
		return GtkIconThemeExterns.gtk_icon_theme_has_icon(self, icon_name);
	}

	public static int HasGicon(this GtkIconThemeHandle self, GIconHandle gicon)
	{
		return GtkIconThemeExterns.gtk_icon_theme_has_gicon(self, gicon);
	}

	public static int[] GetIconSizes(this GtkIconThemeHandle self, string icon_name)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_icon_sizes(self, icon_name);
	}

	public static GtkIconPaintableHandle LookupIcon(this GtkIconThemeHandle self, string icon_name, string[] fallbacks, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_icon(self, icon_name, fallbacks, size, scale, direction, flags);
	}

	public static GtkIconPaintableHandle LookupByGicon(this GtkIconThemeHandle self, GIconHandle icon, int size, int scale, GtkTextDirection direction, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_by_gicon(self, icon, size, scale, direction, flags);
	}

	public static string[] GetIconNames(this GtkIconThemeHandle self)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_icon_names(self);
	}
}
