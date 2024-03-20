using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkClipboardAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GdkClipboardHandle clipboard)
    {
        return GdkClipboardExterns.gdk_clipboard_get_display(clipboard);
    }

    public static GdkContentFormatsHandle GetFormats(this GdkClipboardHandle clipboard)
    {
        return GdkClipboardExterns.gdk_clipboard_get_formats(clipboard);
    }

    public static int IsLocal(this GdkClipboardHandle clipboard)
    {
        return GdkClipboardExterns.gdk_clipboard_is_local(clipboard);
    }

    public static GdkContentProviderHandle GetContent(this GdkClipboardHandle clipboard)
    {
        return GdkClipboardExterns.gdk_clipboard_get_content(clipboard);
    }

    public static GdkClipboardHandle StoreAsync(this GdkClipboardHandle clipboard, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkClipboardExterns.gdk_clipboard_store_async(clipboard, io_priority, cancellable, callback, user_data);
        return clipboard;
    }

    public static int StoreFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
    {
        return GdkClipboardExterns.gdk_clipboard_store_finish(clipboard, result, out error);
    }

    public static GdkClipboardHandle ReadAsync(this GdkClipboardHandle clipboard, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkClipboardExterns.gdk_clipboard_read_async(clipboard, mime_types, io_priority, cancellable, callback, user_data);
        return clipboard;
    }

    public static GInputStreamHandle ReadFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error)
    {
        return GdkClipboardExterns.gdk_clipboard_read_finish(clipboard, result, out out_mime_type, out error);
    }

    public static GdkClipboardHandle ReadValueAsync(this GdkClipboardHandle clipboard, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkClipboardExterns.gdk_clipboard_read_value_async(clipboard, type, io_priority, cancellable, callback, user_data);
        return clipboard;
    }

    public static GValueHandle ReadValueFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
    {
        return GdkClipboardExterns.gdk_clipboard_read_value_finish(clipboard, result, out error);
    }

    public static GdkClipboardHandle ReadTextureAsync(this GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkClipboardExterns.gdk_clipboard_read_texture_async(clipboard, cancellable, callback, user_data);
        return clipboard;
    }

    public static GdkTextureHandle ReadTextureFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
    {
        return GdkClipboardExterns.gdk_clipboard_read_texture_finish(clipboard, result, out error);
    }

    public static GdkClipboardHandle ReadTextAsync(this GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
    {
        GdkClipboardExterns.gdk_clipboard_read_text_async(clipboard, cancellable, callback, user_data);
        return clipboard;
    }

    public static string ReadTextFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
    {
        return GdkClipboardExterns.gdk_clipboard_read_text_finish(clipboard, result, out error);
    }

    public static int SetContent(this GdkClipboardHandle clipboard, GdkContentProviderHandle provider)
    {
        return GdkClipboardExterns.gdk_clipboard_set_content(clipboard, provider);
    }

    public static GdkClipboardHandle Set(this GdkClipboardHandle clipboard, GType type, IntPtr @__argList)
    {
        GdkClipboardExterns.gdk_clipboard_set(clipboard, type, @__argList);
        return clipboard;
    }

    public static GdkClipboardHandle SetValist(this GdkClipboardHandle clipboard, GType type, IntPtr @__argList)
    {
        GdkClipboardExterns.gdk_clipboard_set_valist(clipboard, type, @__argList);
        return clipboard;
    }

    public static GdkClipboardHandle SetValue(this GdkClipboardHandle clipboard, GValueHandle value)
    {
        GdkClipboardExterns.gdk_clipboard_set_value(clipboard, value);
        return clipboard;
    }

    public static GdkClipboardHandle SetText(this GdkClipboardHandle clipboard, string text)
    {
        GdkClipboardExterns.gdk_clipboard_set_text(clipboard, text);
        return clipboard;
    }

    public static GdkClipboardHandle SetTexture(this GdkClipboardHandle clipboard, GdkTextureHandle texture)
    {
        GdkClipboardExterns.gdk_clipboard_set_texture(clipboard, texture);
        return clipboard;
    }
}
