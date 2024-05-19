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

public class GtkStringObjectHandle : GObjectHandle
{
	public static GtkStringObjectHandle New(string @string)
	{
		return GtkStringObjectExterns.gtk_string_object_new(@string);
	}

}

public static class GtkStringObjectHandleExtensions
{
	public static string GetString(this GtkStringObjectHandle self)
	{
		return GtkStringObjectExterns.gtk_string_object_get_string(self);
	}

}

internal class GtkStringObjectExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStringObjectHandle gtk_string_object_new(string @string);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_string_object_get_string(GtkStringObjectHandle self);

}
