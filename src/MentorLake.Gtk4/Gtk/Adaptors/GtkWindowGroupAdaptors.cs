using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWindowGroupAdaptors
{
	public static GtkWindowGroupHandle AddWindow(this GtkWindowGroupHandle window_group, GtkWindowHandle window)
	{
		GtkWindowGroupExterns.gtk_window_group_add_window(window_group, window);
		return window_group;
	}

	public static GtkWindowGroupHandle RemoveWindow(this GtkWindowGroupHandle window_group, GtkWindowHandle window)
	{
		GtkWindowGroupExterns.gtk_window_group_remove_window(window_group, window);
		return window_group;
	}

	public static GListHandle ListWindows(this GtkWindowGroupHandle window_group)
	{
		return GtkWindowGroupExterns.gtk_window_group_list_windows(window_group);
	}
}
