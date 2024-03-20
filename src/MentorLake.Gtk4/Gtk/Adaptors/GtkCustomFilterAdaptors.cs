using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCustomFilterAdaptors
{
	public static GtkCustomFilterHandle SetFilterFunc(this GtkCustomFilterHandle self, GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		GtkCustomFilterExterns.gtk_custom_filter_set_filter_func(self, match_func, user_data, user_destroy);
		return self;
	}
}
