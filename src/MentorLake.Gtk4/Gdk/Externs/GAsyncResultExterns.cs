using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GAsyncResultExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserialize_finish")]
	internal static extern int gdk_content_deserialize_finish(this GAsyncResultHandle result, GValueHandle value, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serialize_finish")]
	internal static extern int gdk_content_serialize_finish(this GAsyncResultHandle result, out GErrorHandle error);
}
