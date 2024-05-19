namespace MentorLake.Gtk4.Gtk4;

public class GtkCustomSorterHandle : GtkSorterHandle
{
	public static GtkCustomSorterHandle New(GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkCustomSorterExterns.gtk_custom_sorter_new(sort_func, user_data, user_destroy);
	}

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
	internal static extern GtkCustomSorterHandle gtk_custom_sorter_new(GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_custom_sorter_set_sort_func(GtkCustomSorterHandle self, GCompareDataFunc sort_func, IntPtr user_data, GDestroyNotify user_destroy);

}
