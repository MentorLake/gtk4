using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkDirectoryListHandle : GObjectHandle, GListModelHandle
{
	public static GtkDirectoryListHandle New(string attributes, GFileHandle file)
	{
		return GtkDirectoryListExterns.gtk_directory_list_new(attributes, file);
	}

}

public static class GtkDirectoryListHandleExtensions
{
	public static string GetAttributes(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_attributes(self);
	}

	public static GErrorHandle GetError(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_error(self);
	}

	public static GFileHandle GetFile(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_file(self);
	}

	public static int GetIoPriority(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_io_priority(self);
	}

	public static bool GetMonitored(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_get_monitored(self);
	}

	public static bool IsLoading(this GtkDirectoryListHandle self)
	{
		return GtkDirectoryListExterns.gtk_directory_list_is_loading(self);
	}

	public static GtkDirectoryListHandle SetAttributes(this GtkDirectoryListHandle self, string attributes)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_attributes(self, attributes);
		return self;
	}

	public static GtkDirectoryListHandle SetFile(this GtkDirectoryListHandle self, GFileHandle file)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_file(self, file);
		return self;
	}

	public static GtkDirectoryListHandle SetIoPriority(this GtkDirectoryListHandle self, int io_priority)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_io_priority(self, io_priority);
		return self;
	}

	public static GtkDirectoryListHandle SetMonitored(this GtkDirectoryListHandle self, bool monitored)
	{
		GtkDirectoryListExterns.gtk_directory_list_set_monitored(self, monitored);
		return self;
	}

}

internal class GtkDirectoryListExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDirectoryListHandle gtk_directory_list_new(string attributes, GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_directory_list_get_attributes(GtkDirectoryListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GErrorHandle gtk_directory_list_get_error(GtkDirectoryListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_directory_list_get_file(GtkDirectoryListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_directory_list_get_io_priority(GtkDirectoryListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_directory_list_get_monitored(GtkDirectoryListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_directory_list_is_loading(GtkDirectoryListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_directory_list_set_attributes(GtkDirectoryListHandle self, string attributes);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_directory_list_set_file(GtkDirectoryListHandle self, GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_directory_list_set_io_priority(GtkDirectoryListHandle self, int io_priority);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_directory_list_set_monitored(GtkDirectoryListHandle self, bool monitored);

}
