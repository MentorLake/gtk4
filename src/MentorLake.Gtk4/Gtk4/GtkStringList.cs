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

public class GtkStringListHandle : GObjectHandle, GListModelHandle, GtkBuildableHandle
{
	public static GtkStringListHandle New(string strings)
	{
		return GtkStringListExterns.gtk_string_list_new(strings);
	}

}

public static class GtkStringListHandleExtensions
{
	public static GtkStringListHandle Append(this GtkStringListHandle self, string @string)
	{
		GtkStringListExterns.gtk_string_list_append(self, @string);
		return self;
	}

	public static string GetString(this GtkStringListHandle self, uint position)
	{
		return GtkStringListExterns.gtk_string_list_get_string(self, position);
	}

	public static GtkStringListHandle Remove(this GtkStringListHandle self, uint position)
	{
		GtkStringListExterns.gtk_string_list_remove(self, position);
		return self;
	}

	public static GtkStringListHandle Splice(this GtkStringListHandle self, uint position, uint n_removals, string additions)
	{
		GtkStringListExterns.gtk_string_list_splice(self, position, n_removals, additions);
		return self;
	}

	public static GtkStringListHandle Take(this GtkStringListHandle self, string @string)
	{
		GtkStringListExterns.gtk_string_list_take(self, @string);
		return self;
	}

}

internal class GtkStringListExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStringListHandle gtk_string_list_new(string strings);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_list_append(GtkStringListHandle self, string @string);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_string_list_get_string(GtkStringListHandle self, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_list_remove(GtkStringListHandle self, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_list_splice(GtkStringListHandle self, uint position, uint n_removals, string additions);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_list_take(GtkStringListHandle self, string @string);

}
