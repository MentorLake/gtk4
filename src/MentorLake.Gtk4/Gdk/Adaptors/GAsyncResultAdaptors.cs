using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GAsyncResultAdaptors
{
    public static int GdkContentDeserializeFinish(this GAsyncResultHandle result, GValueHandle value, out GErrorHandle error)
    {
        return GAsyncResultExterns.gdk_content_deserialize_finish(result, value, out error);
    }

    public static int GdkContentSerializeFinish(this GAsyncResultHandle result, out GErrorHandle error)
    {
        return GAsyncResultExterns.gdk_content_serialize_finish(result, out error);
    }
}
