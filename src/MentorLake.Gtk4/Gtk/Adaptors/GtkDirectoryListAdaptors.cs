using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkDirectoryListAdaptors
{
	public static GtkDirectoryListHandle SetFile(this GtkDirectoryListHandle self, GFileHandle file)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_file(self, file);
		return self;
	}

	public static GFileHandle GetFile(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_file(self);
	}

	public static GtkDirectoryListHandle SetAttributes(this GtkDirectoryListHandle self, string attributes)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_attributes(self, attributes);
		return self;
	}

	public static string GetAttributes(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_attributes(self);
	}

	public static GtkDirectoryListHandle SetIoPriority(this GtkDirectoryListHandle self, int io_priority)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_io_priority(self, io_priority);
		return self;
	}

	public static int GetIoPriority(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_io_priority(self);
	}

	public static int IsLoading(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_is_loading(self);
	}

	public static GErrorHandle GetError(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_error(self);
	}

	public static GtkDirectoryListHandle SetMonitored(this GtkDirectoryListHandle self, int monitored)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_monitored(self, monitored);
		return self;
	}

	public static int GetMonitored(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_monitored(self);
	}
}
