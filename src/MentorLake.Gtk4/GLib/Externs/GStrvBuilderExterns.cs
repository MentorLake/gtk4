using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStrvBuilderExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_strv_builder_unref")]
    internal static extern void g_strv_builder_unref(this GStrvBuilderHandle builder);
    [DllImport(Libraries.GLib, EntryPoint = "g_strv_builder_ref")]
    internal static extern GStrvBuilderHandle g_strv_builder_ref(this GStrvBuilderHandle builder);
    [DllImport(Libraries.GLib, EntryPoint = "g_strv_builder_add")]
    internal static extern void g_strv_builder_add(this GStrvBuilderHandle builder, string value);
    [DllImport(Libraries.GLib, EntryPoint = "g_strv_builder_addv")]
    internal static extern void g_strv_builder_addv(this GStrvBuilderHandle builder, string[] value);
    [DllImport(Libraries.GLib, EntryPoint = "g_strv_builder_add_many")]
    internal static extern void g_strv_builder_add_many(this GStrvBuilderHandle builder, IntPtr @__argList);
    [DllImport(Libraries.GLib, EntryPoint = "g_strv_builder_end")]
    internal static extern GStrv g_strv_builder_end(this GStrvBuilderHandle builder);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GStrvBuilderHandle g_strv_builder_new();
}
