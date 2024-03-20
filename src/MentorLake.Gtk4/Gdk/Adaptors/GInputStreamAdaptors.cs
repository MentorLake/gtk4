using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GInputStreamAdaptors
{
    public static GInputStreamHandle GdkContentDeserializeAsync(this GInputStreamHandle stream, string mime_type, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GInputStreamExterns.gdk_content_deserialize_async(stream, mime_type, type, io_priority, cancellable, callback, user_data);
        return stream;
    }
}
