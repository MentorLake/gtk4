using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentProviderExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_ref_formats")]
    internal static extern GdkContentFormatsHandle gdk_content_provider_ref_formats(this GdkContentProviderHandle provider);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_ref_storable_formats")]
    internal static extern GdkContentFormatsHandle gdk_content_provider_ref_storable_formats(this GdkContentProviderHandle provider);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_content_changed")]
    internal static extern void gdk_content_provider_content_changed(this GdkContentProviderHandle provider);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_write_mime_type_async")]
    internal static extern void gdk_content_provider_write_mime_type_async(this GdkContentProviderHandle provider, string mime_type, GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_write_mime_type_finish")]
    internal static extern int gdk_content_provider_write_mime_type_finish(this GdkContentProviderHandle provider, GAsyncResultHandle result, out GErrorHandle error);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_get_value")]
    internal static extern int gdk_content_provider_get_value(this GdkContentProviderHandle provider, GValueHandle value, out GErrorHandle error);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_provider_new_union")]
    internal static extern GdkContentProviderHandle gdk_content_provider_new_union(GdkContentProviderHandle[] providers, nuint n_providers);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkContentProviderHandle gdk_content_provider_new_for_value(GValueHandle value);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkContentProviderHandle gdk_content_provider_new_typed(GType type, IntPtr @__arglist);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkContentProviderHandle gdk_content_provider_new_for_bytes(string mime_type, GBytesHandle bytes);
}
