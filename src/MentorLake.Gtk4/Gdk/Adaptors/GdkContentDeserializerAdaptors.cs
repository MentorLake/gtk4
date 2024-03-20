using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentDeserializerAdaptors
{
    public static string GetMimeType(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_mime_type(deserializer);
    }

    public static GType GetGtype(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_gtype(deserializer);
    }

    public static GValueHandle GetValue(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_value(deserializer);
    }

    public static GInputStreamHandle GetInputStream(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_input_stream(deserializer);
    }

    public static int GetPriority(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_priority(deserializer);
    }

    public static GCancellableHandle GetCancellable(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_cancellable(deserializer);
    }

    public static IntPtr GetUserData(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_user_data(deserializer);
    }

    public static GdkContentDeserializerHandle SetTaskData(this GdkContentDeserializerHandle deserializer, IntPtr data, GDestroyNotify notify)
    {
        GdkContentDeserializerExterns.gdk_content_deserializer_set_task_data(deserializer, data, notify);
        return deserializer;
    }

    public static IntPtr GetTaskData(this GdkContentDeserializerHandle deserializer)
    {
        return GdkContentDeserializerExterns.gdk_content_deserializer_get_task_data(deserializer);
    }

    public static GdkContentDeserializerHandle ReturnSuccess(this GdkContentDeserializerHandle deserializer)
    {
        GdkContentDeserializerExterns.gdk_content_deserializer_return_success(deserializer);
        return deserializer;
    }

    public static GdkContentDeserializerHandle ReturnError(this GdkContentDeserializerHandle deserializer, GErrorHandle error)
    {
        GdkContentDeserializerExterns.gdk_content_deserializer_return_error(deserializer, error);
        return deserializer;
    }
}
