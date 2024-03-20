using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuilderScopeExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_list_item_factory_new_from_bytes")]
    internal static extern GtkListItemFactoryHandle gtk_builder_list_item_factory_new_from_bytes(this GtkBuilderScopeHandle scope, GBytesHandle bytes);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_list_item_factory_new_from_resource")]
    internal static extern GtkListItemFactoryHandle gtk_builder_list_item_factory_new_from_resource(this GtkBuilderScopeHandle scope, string resource_path);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkBuilderScopeHandle gtk_builder_cscope_new();
}
