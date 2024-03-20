using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GdkClipboardExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_get_display")]
	internal static extern GdkDisplayHandle gdk_clipboard_get_display(this GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_get_formats")]
	internal static extern GdkContentFormatsHandle gdk_clipboard_get_formats(this GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_is_local")]
	internal static extern int gdk_clipboard_is_local(this GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_get_content")]
	internal static extern GdkContentProviderHandle gdk_clipboard_get_content(this GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_store_async")]
	internal static extern void gdk_clipboard_store_async(this GdkClipboardHandle clipboard, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_store_finish")]
	internal static extern int gdk_clipboard_store_finish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_async")]
	internal static extern void gdk_clipboard_read_async(this GdkClipboardHandle clipboard, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_finish")]
	internal static extern GInputStreamHandle gdk_clipboard_read_finish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_value_async")]
	internal static extern void gdk_clipboard_read_value_async(this GdkClipboardHandle clipboard, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_value_finish")]
	internal static extern GValueHandle gdk_clipboard_read_value_finish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_texture_async")]
	internal static extern void gdk_clipboard_read_texture_async(this GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_texture_finish")]
	internal static extern GdkTextureHandle gdk_clipboard_read_texture_finish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_text_async")]
	internal static extern void gdk_clipboard_read_text_async(this GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_read_text_finish")]
	internal static extern string gdk_clipboard_read_text_finish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_set_content")]
	internal static extern int gdk_clipboard_set_content(this GdkClipboardHandle clipboard, GdkContentProviderHandle provider);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_set")]
	internal static extern void gdk_clipboard_set(this GdkClipboardHandle clipboard, GType type, IntPtr @__argList);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_set_valist")]
	internal static extern void gdk_clipboard_set_valist(this GdkClipboardHandle clipboard, GType type, IntPtr @__argList);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_set_value")]
	internal static extern void gdk_clipboard_set_value(this GdkClipboardHandle clipboard, GValueHandle value);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_set_text")]
	internal static extern void gdk_clipboard_set_text(this GdkClipboardHandle clipboard, string text);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_clipboard_set_texture")]
	internal static extern void gdk_clipboard_set_texture(this GdkClipboardHandle clipboard, GdkTextureHandle texture);
}
