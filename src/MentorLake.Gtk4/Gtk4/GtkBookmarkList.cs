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

public class GtkBookmarkListHandle : GObjectHandle, GListModelHandle
{
	public static GtkBookmarkListHandle New(string filename, string attributes)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_new(filename, attributes);
	}

}

public static class GtkBookmarkListHandleExtensions
{
	public static string GetAttributes(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_get_attributes(self);
	}

	public static string GetFilename(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_get_filename(self);
	}

	public static int GetIoPriority(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_get_io_priority(self);
	}

	public static bool IsLoading(this GtkBookmarkListHandle self)
	{
		return GtkBookmarkListExterns.gtk_bookmark_list_is_loading(self);
	}

	public static GtkBookmarkListHandle SetAttributes(this GtkBookmarkListHandle self, string attributes)
	{
		GtkBookmarkListExterns.gtk_bookmark_list_set_attributes(self, attributes);
		return self;
	}

	public static GtkBookmarkListHandle SetIoPriority(this GtkBookmarkListHandle self, int io_priority)
	{
		GtkBookmarkListExterns.gtk_bookmark_list_set_io_priority(self, io_priority);
		return self;
	}

}

internal class GtkBookmarkListExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBookmarkListHandle gtk_bookmark_list_new(string filename, string attributes);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_bookmark_list_get_attributes(GtkBookmarkListHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_bookmark_list_get_filename(GtkBookmarkListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_bookmark_list_get_io_priority(GtkBookmarkListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_bookmark_list_is_loading(GtkBookmarkListHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_bookmark_list_set_attributes(GtkBookmarkListHandle self, string attributes);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_bookmark_list_set_io_priority(GtkBookmarkListHandle self, int io_priority);

}
