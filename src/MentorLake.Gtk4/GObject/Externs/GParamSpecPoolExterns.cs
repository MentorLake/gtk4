using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GParamSpecPoolExterns
{
    [DllImport(Libraries.GObject, EntryPoint = "g_param_spec_pool_insert")]
    internal static extern void g_param_spec_pool_insert(this GParamSpecPoolHandle pool, GParamSpecHandle pspec, GType owner_type);
    [DllImport(Libraries.GObject, EntryPoint = "g_param_spec_pool_remove")]
    internal static extern void g_param_spec_pool_remove(this GParamSpecPoolHandle pool, GParamSpecHandle pspec);
    [DllImport(Libraries.GObject, EntryPoint = "g_param_spec_pool_lookup")]
    internal static extern GParamSpecHandle g_param_spec_pool_lookup(this GParamSpecPoolHandle pool, string param_name, GType owner_type, int walk_ancestors);
    [DllImport(Libraries.GObject, EntryPoint = "g_param_spec_pool_list_owned")]
    internal static extern GListHandle g_param_spec_pool_list_owned(this GParamSpecPoolHandle pool, GType owner_type);
    [DllImport(Libraries.GObject, EntryPoint = "g_param_spec_pool_list")]
    internal static extern GParamSpecHandle[] g_param_spec_pool_list(this GParamSpecPoolHandle pool, GType owner_type, out uint n_pspecs_p);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GParamSpecPoolHandle g_param_spec_pool_new(int type_prefixing);
}
