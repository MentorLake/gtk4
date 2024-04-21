using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public class GdkClipboardHandle : GObjectHandle
{
}

public class GdkClipboardSignal
{
	public string Value { get; set; }
	public GdkClipboardSignal(string value) => Value = value;
}

public static class GdkClipboardSignals
{
	public static GdkClipboardSignal Changed = new("BindingTransform.MethodDeclaration");
}

public static class GdkClipboardHandleExtensions
{
	public static GdkContentProviderHandle GetContent(this GdkClipboardHandle clipboard)
	{
		return GdkClipboardExterns.gdk_clipboard_get_content(clipboard);
	}

	public static GdkDisplayHandle GetDisplay(this GdkClipboardHandle clipboard)
	{
		return GdkClipboardExterns.gdk_clipboard_get_display(clipboard);
	}

	public static GdkContentFormatsHandle GetFormats(this GdkClipboardHandle clipboard)
	{
		return GdkClipboardExterns.gdk_clipboard_get_formats(clipboard);
	}

	public static bool IsLocal(this GdkClipboardHandle clipboard)
	{
		return GdkClipboardExterns.gdk_clipboard_is_local(clipboard);
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

	public static GdkClipboardHandle ReadTextAsync(this GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkClipboardExterns.gdk_clipboard_read_text_async(clipboard, cancellable, callback, user_data);
		return clipboard;
	}

	public static string ReadTextFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GdkClipboardExterns.gdk_clipboard_read_text_finish(clipboard, result, out error);
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

	public static GdkClipboardHandle ReadValueAsync(this GdkClipboardHandle clipboard, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkClipboardExterns.gdk_clipboard_read_value_async(clipboard, type, io_priority, cancellable, callback, user_data);
		return clipboard;
	}

	public static GValueHandle ReadValueFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GdkClipboardExterns.gdk_clipboard_read_value_finish(clipboard, result, out error);
	}

	public static GdkClipboardHandle Set(this GdkClipboardHandle clipboard, GType type, IntPtr @__arglist)
	{
		GdkClipboardExterns.gdk_clipboard_set(clipboard, type, @__arglist);
		return clipboard;
	}

	public static bool SetContent(this GdkClipboardHandle clipboard, GdkContentProviderHandle provider)
	{
		return GdkClipboardExterns.gdk_clipboard_set_content(clipboard, provider);
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

	public static GdkClipboardHandle SetValist(this GdkClipboardHandle clipboard, GType type, IntPtr args)
	{
		GdkClipboardExterns.gdk_clipboard_set_valist(clipboard, type, args);
		return clipboard;
	}

	public static GdkClipboardHandle SetValue(this GdkClipboardHandle clipboard, GValueHandle value)
	{
		GdkClipboardExterns.gdk_clipboard_set_value(clipboard, value);
		return clipboard;
	}

	public static GdkClipboardHandle StoreAsync(this GdkClipboardHandle clipboard, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GdkClipboardExterns.gdk_clipboard_store_async(clipboard, io_priority, cancellable, callback, user_data);
		return clipboard;
	}

	public static bool StoreFinish(this GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GdkClipboardExterns.gdk_clipboard_store_finish(clipboard, result, out error);
	}

	public static GdkClipboardHandle Signal_Changed(this GdkClipboardHandle instance, GdkClipboardDelegates.Changed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkClipboardDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkClipboardHandle>))] GdkClipboardHandle self, IntPtr user_data);
}

internal class GdkClipboardExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentProviderHandle gdk_clipboard_get_content(GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_clipboard_get_display(GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_clipboard_get_formats(GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_clipboard_is_local(GdkClipboardHandle clipboard);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_read_async(GdkClipboardHandle clipboard, string[] mime_types, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GInputStreamHandle gdk_clipboard_read_finish(GdkClipboardHandle clipboard, GAsyncResultHandle result, out string out_mime_type, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_read_text_async(GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_clipboard_read_text_finish(GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_read_texture_async(GdkClipboardHandle clipboard, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_clipboard_read_texture_finish(GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_read_value_async(GdkClipboardHandle clipboard, GType type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GValueHandle gdk_clipboard_read_value_finish(GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_set(GdkClipboardHandle clipboard, GType type, IntPtr @__arglist);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_clipboard_set_content(GdkClipboardHandle clipboard, GdkContentProviderHandle provider);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_set_text(GdkClipboardHandle clipboard, string text);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_set_texture(GdkClipboardHandle clipboard, GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_set_valist(GdkClipboardHandle clipboard, GType type, IntPtr args);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_set_value(GdkClipboardHandle clipboard, GValueHandle value);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_clipboard_store_async(GdkClipboardHandle clipboard, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_clipboard_store_finish(GdkClipboardHandle clipboard, GAsyncResultHandle result, out GErrorHandle error);

}
