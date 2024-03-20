using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuilderScopeAdaptors
{
	public static GtkListItemFactoryHandle GtkBuilderListItemFactoryNewFromBytes(this GtkBuilderScopeHandle scope, GBytesHandle bytes)
	{
		return GtkBuilderScopeExterns.gtk_builder_list_item_factory_new_from_bytes(scope, bytes);
	}

	public static GtkListItemFactoryHandle GtkBuilderListItemFactoryNewFromResource(this GtkBuilderScopeHandle scope, string resource_path)
	{
		return GtkBuilderScopeExterns.gtk_builder_list_item_factory_new_from_resource(scope, resource_path);
	}
}
