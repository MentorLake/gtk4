using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDropAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GdkDropHandle self)
    {
        return GdkDropExterns.gdk_drop_get_display(self);
    }

    public static GdkDeviceHandle GetDevice(this GdkDropHandle self)
    {
        return GdkDropExterns.gdk_drop_get_device(self);
    }

    public static GdkSurfaceHandle GetSurface(this GdkDropHandle self)
    {
        return GdkDropExterns.gdk_drop_get_surface(self);
    }

    public static GdkContentFormatsHandle GetFormats(this GdkDropHandle self)
    {
        return GdkDropExterns.gdk_drop_get_formats(self);
    }

    public static GdkDragAction GetActions(this GdkDropHandle self)
    {
        return GdkDropExterns.gdk_drop_get_actions(self);
    }

    public static GdkDragHandle GetDrag(this GdkDropHandle self)
    {
        return GdkDropExterns.gdk_drop_get_drag(self);
    }

    public static GdkDropHandle Status(this GdkDropHandle self, GdkDragAction actions, GdkDragAction preferred)
    {
        GdkDropExterns.gdk_drop_status(self, actions, preferred);
        return self;
    }

    public static GdkDropHandle Finish(this GdkDropHandle self, GdkDragAction action)
    {
        GdkDropExterns.gdk_drop_finish(self, action);
        return self;
    }

    public static GdkDropHandle ReadAsync(this GdkDropHandle self, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkDropExterns.gdk_drop_read_async(self, mime_types, io_priority, cancellable, callback, user_data);
        return self;
    }

    public static GInputStreamHandle ReadFinish(this GdkDropHandle self, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error)
    {
        return GdkDropExterns.gdk_drop_read_finish(self, result, out out_mime_type, out error);
    }

    public static GdkDropHandle ReadValueAsync(this GdkDropHandle self, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkDropExterns.gdk_drop_read_value_async(self, type, io_priority, cancellable, callback, user_data);
        return self;
    }

    public static GValueHandle ReadValueFinish(this GdkDropHandle self, GAsyncResultHandle result, out GErrorHandle error)
    {
        return GdkDropExterns.gdk_drop_read_value_finish(self, result, out error);
    }
}
