using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pixbuf;
public static class GAsyncResultAdaptors
{
    public static int GdkPixbufSaveToStreamFinish(this GAsyncResultHandle async_result, out GErrorHandle error)
    {
        return GAsyncResultExterns.gdk_pixbuf_save_to_stream_finish(async_result, out error);
    }

    public static GdkPixbufAnimationHandle GdkPixbufAnimationNewFromStreamFinish(this GAsyncResultHandle async_result, out GErrorHandle error)
    {
        return GAsyncResultExterns.gdk_pixbuf_animation_new_from_stream_finish(async_result, out error);
    }

    public static GdkPixbufFormatHandle GdkPixbufGetFileInfoFinish(this GAsyncResultHandle async_result, out int width, out int height, out GErrorHandle error)
    {
        return GAsyncResultExterns.gdk_pixbuf_get_file_info_finish(async_result, out width, out height, out error);
    }
}
