using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GOutputStreamExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_content_serialize_async")]
	internal static extern void gdk_content_serialize_async(this GOutputStreamHandle stream, string mime_type, GValueHandle value, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
}
