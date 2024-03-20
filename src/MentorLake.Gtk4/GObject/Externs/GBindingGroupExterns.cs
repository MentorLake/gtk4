using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GBindingGroupExterns
{
    [DllImport(Libraries.GObject, EntryPoint = "g_binding_group_dup_source")]
    internal static extern IntPtr g_binding_group_dup_source(this GBindingGroupHandle self);
    [DllImport(Libraries.GObject, EntryPoint = "g_binding_group_set_source")]
    internal static extern void g_binding_group_set_source(this GBindingGroupHandle self, IntPtr source);
    [DllImport(Libraries.GObject, EntryPoint = "g_binding_group_bind")]
    internal static extern void g_binding_group_bind(this GBindingGroupHandle self, string source_property, IntPtr target, string target_property, GBindingFlags flags);
    [DllImport(Libraries.GObject, EntryPoint = "g_binding_group_bind_full")]
    internal static extern void g_binding_group_bind_full(this GBindingGroupHandle self, string source_property, IntPtr target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify user_data_destroy);
    [DllImport(Libraries.GObject, EntryPoint = "g_binding_group_bind_with_closures")]
    internal static extern void g_binding_group_bind_with_closures(this GBindingGroupHandle self, string source_property, IntPtr target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GBindingGroupHandle g_binding_group_new();
}
