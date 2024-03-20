using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuilderListItemFactoryAdaptors
{
    public static GBytesHandle GetBytes(this GtkBuilderListItemFactoryHandle self)
    {
        return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_get_bytes(self);
    }

    public static string GetResource(this GtkBuilderListItemFactoryHandle self)
    {
        return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_get_resource(self);
    }

    public static GtkBuilderScopeHandle GetScope(this GtkBuilderListItemFactoryHandle self)
    {
        return GtkBuilderListItemFactoryExterns.gtk_builder_list_item_factory_get_scope(self);
    }
}
