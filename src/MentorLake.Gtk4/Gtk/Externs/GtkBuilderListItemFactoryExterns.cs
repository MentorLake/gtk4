using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;

public static class GtkBuilderListItemFactoryExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_list_item_factory_get_bytes")]
	internal static extern GBytesHandle gtk_builder_list_item_factory_get_bytes(this GtkBuilderListItemFactoryHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_list_item_factory_get_resource")]
	internal static extern string gtk_builder_list_item_factory_get_resource(this GtkBuilderListItemFactoryHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_builder_list_item_factory_get_scope")]
	internal static extern GtkBuilderScopeHandle gtk_builder_list_item_factory_get_scope(this GtkBuilderListItemFactoryHandle self);
}
