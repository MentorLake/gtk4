using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class GInputStreamExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_deserialize_async")]
	internal static extern void gdk_content_deserialize_async(this GInputStreamHandle stream, string mime_type, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
}
