using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentSerializerAdaptors
{
    public static string GetMimeType(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_mime_type(serializer);
    }

    public static GType GetGtype(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_gtype(serializer);
    }

    public static GValueHandle GetValue(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_value(serializer);
    }

    public static GOutputStreamHandle GetOutputStream(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_output_stream(serializer);
    }

    public static int GetPriority(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_priority(serializer);
    }

    public static GCancellableHandle GetCancellable(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_cancellable(serializer);
    }

    public static IntPtr GetUserData(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_user_data(serializer);
    }

    public static GdkContentSerializerHandle SetTaskData(this GdkContentSerializerHandle serializer, IntPtr data, GDestroyNotify notify)
    {
        GdkContentSerializerExterns.gdk_content_serializer_set_task_data(serializer, data, notify);
        return serializer;
    }

    public static IntPtr GetTaskData(this GdkContentSerializerHandle serializer)
    {
        return GdkContentSerializerExterns.gdk_content_serializer_get_task_data(serializer);
    }

    public static GdkContentSerializerHandle ReturnSuccess(this GdkContentSerializerHandle serializer)
    {
        GdkContentSerializerExterns.gdk_content_serializer_return_success(serializer);
        return serializer;
    }

    public static GdkContentSerializerHandle ReturnError(this GdkContentSerializerHandle serializer, GErrorHandle error)
    {
        GdkContentSerializerExterns.gdk_content_serializer_return_error(serializer, error);
        return serializer;
    }
}
