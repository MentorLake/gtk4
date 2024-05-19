namespace MentorLake.Gtk4.Gtk4;

public class GtkCustomFilterHandle : GtkFilterHandle
{
	public static GtkCustomFilterHandle New(GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkCustomFilterExterns.gtk_custom_filter_new(match_func, user_data, user_destroy);
	}

}

public static class GtkCustomFilterHandleExtensions
{
	public static GtkCustomFilterHandle SetFilterFunc(this GtkCustomFilterHandle self, GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		GtkCustomFilterExterns.gtk_custom_filter_set_filter_func(self, match_func, user_data, user_destroy);
		return self;
	}

}

internal class GtkCustomFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCustomFilterHandle gtk_custom_filter_new(GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_custom_filter_set_filter_func(GtkCustomFilterHandle self, GtkCustomFilterFunc match_func, IntPtr user_data, GDestroyNotify user_destroy);

}
