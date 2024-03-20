using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentFormatsExterns
{
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_union_deserialize_gtypes")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_union_deserialize_gtypes(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_union_deserialize_mime_types")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_union_deserialize_mime_types(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_ref")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_ref(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_unref")]
    internal static extern void gdk_content_formats_unref(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_print")]
    internal static extern void gdk_content_formats_print(this GdkContentFormatsHandle formats, GStringHandle @string);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_to_string")]
    internal static extern string gdk_content_formats_to_string(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_get_gtypes")]
    internal static extern GTypeHandle gdk_content_formats_get_gtypes(this GdkContentFormatsHandle formats, out nuint n_gtypes);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_get_mime_types")]
    internal static extern string gdk_content_formats_get_mime_types(this GdkContentFormatsHandle formats, out nuint n_mime_types);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_union")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_union(this GdkContentFormatsHandle first, GdkContentFormatsHandle second);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_match")]
    internal static extern int gdk_content_formats_match(this GdkContentFormatsHandle first, GdkContentFormatsHandle second);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_match_gtype")]
    internal static extern GType gdk_content_formats_match_gtype(this GdkContentFormatsHandle first, GdkContentFormatsHandle second);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_match_mime_type")]
    internal static extern string gdk_content_formats_match_mime_type(this GdkContentFormatsHandle first, GdkContentFormatsHandle second);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_contain_gtype")]
    internal static extern int gdk_content_formats_contain_gtype(this GdkContentFormatsHandle formats, GType type);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_contain_mime_type")]
    internal static extern int gdk_content_formats_contain_mime_type(this GdkContentFormatsHandle formats, string mime_type);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_union_serialize_gtypes")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_union_serialize_gtypes(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, EntryPoint = "gdk_content_formats_union_serialize_mime_types")]
    internal static extern GdkContentFormatsHandle gdk_content_formats_union_serialize_mime_types(this GdkContentFormatsHandle formats);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkContentFormatsHandle gdk_content_formats_new(string[] mime_types, uint n_mime_types);
    [DllImport(Libraries.Gdk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GdkContentFormatsHandle gdk_content_formats_new_for_gtype(GType type);
}
