using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentFormatsBuilderExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_ref")]
    internal static extern GdkContentFormatsBuilderHandle gdk_content_formats_builder_ref(this GdkContentFormatsBuilderHandle builder);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_unref")]
    internal static extern void gdk_content_formats_builder_unref(this GdkContentFormatsBuilderHandle builder);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_free_to_formats")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_builder_free_to_formats(this GdkContentFormatsBuilderHandle builder);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_to_formats")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_builder_to_formats(this GdkContentFormatsBuilderHandle builder);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_add_formats")]
    internal static extern void gdk_content_formats_builder_add_formats(this GdkContentFormatsBuilderHandle builder, GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_add_mime_type")]
    internal static extern void gdk_content_formats_builder_add_mime_type(this GdkContentFormatsBuilderHandle builder, string mime_type);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_builder_add_gtype")]
    internal static extern void gdk_content_formats_builder_add_gtype(this GdkContentFormatsBuilderHandle builder, GType type);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkContentFormatsBuilderHandle gdk_content_formats_builder_new();
}
