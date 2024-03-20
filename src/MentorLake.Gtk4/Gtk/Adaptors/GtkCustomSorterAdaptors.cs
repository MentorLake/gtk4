using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCustomSorterAdaptors
{
	public static GtkCustomSorterHandle SetSortFunc(this GtkCustomSorterHandle self, GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		GtkCustomSorterExterns.gtk_custom_sorter_set_sort_func(self, sort_func, user_data, user_destroy);
		return self;
	}
}
