using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBookmarkListAdaptors
{
	public static string GetFilename(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_get_filename(self);
	}

	public static GtkBookmarkListHandle SetAttributes(this GtkBookmarkListHandle self, string attributes)
	{
		GtkBookmarkListExterns.gtk_bookmark_list_set_attributes(self, attributes);
		return self;
	}

	public static string GetAttributes(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_get_attributes(self);
	}

	public static GtkBookmarkListHandle SetIoPriority(this GtkBookmarkListHandle self, int io_priority)
	{
		GtkBookmarkListExterns.gtk_bookmark_list_set_io_priority(self, io_priority);
		return self;
	}

	public static int GetIoPriority(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_get_io_priority(self);
	}

	public static int IsLoading(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_is_loading(self);
	}
}
