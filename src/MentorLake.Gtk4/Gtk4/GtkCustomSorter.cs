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

public class GtkCustomSorterHandle : GtkSorterHandle
{
	public static GtkCustomSorterHandle New(GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkCustomSorterExterns.gtk_custom_sorter_new(sort_func, user_data, user_destroy);
	}
}

public static class GtkCustomSorterSignals
{
}

public static class GtkCustomSorterHandleExtensions
{
	public static GtkCustomSorterHandle SetSortFunc(this GtkCustomSorterHandle self, GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		GtkCustomSorterExterns.gtk_custom_sorter_set_sort_func(self, sort_func, user_data, user_destroy);
		return self;
	}

}

internal class GtkCustomSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_custom_sorter_set_sort_func(GtkCustomSorterHandle self, GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCustomSorterHandle gtk_custom_sorter_new(GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy);
}
