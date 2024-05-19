namespace MentorLake.Gtk4.Gtk4;

public class GtkWindowGroupHandle : GObjectHandle
{
	public static GtkWindowGroupHandle New()
	{
		return GtkWindowGroupExterns.gtk_window_group_new();
	}

}

public static class GtkWindowGroupHandleExtensions
{
	public static GtkWindowGroupHandle AddWindow(this GtkWindowGroupHandle window_group, GtkWindowHandle window)
	{
		GtkWindowGroupExterns.gtk_window_group_add_window(window_group, window);
		return window_group;
	}

	public static GListHandle ListWindows(this GtkWindowGroupHandle window_group)
	{
		return GtkWindowGroupExterns.gtk_window_group_list_windows(window_group);
	}

	public static GtkWindowGroupHandle RemoveWindow(this GtkWindowGroupHandle window_group, GtkWindowHandle window)
	{
		GtkWindowGroupExterns.gtk_window_group_remove_window(window_group, window);
		return window_group;
	}

}

internal class GtkWindowGroupExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowGroupHandle gtk_window_group_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_group_add_window(GtkWindowGroupHandle window_group, GtkWindowHandle window);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_window_group_list_windows(GtkWindowGroupHandle window_group);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_group_remove_window(GtkWindowGroupHandle window_group, GtkWindowHandle window);

}
