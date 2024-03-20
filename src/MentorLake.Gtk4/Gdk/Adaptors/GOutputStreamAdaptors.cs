using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GOutputStreamAdaptors
{
    public static GOutputStreamHandle GdkContentSerializeAsync(this GOutputStreamHandle stream, string mime_type, GValueHandle value, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GOutputStreamExterns.gdk_content_serialize_async(stream, mime_type, value, io_priority, cancellable, callback, user_data);
        return stream;
    }
}
