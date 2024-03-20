using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListItemAdaptors
{
    public static IntPtr GetItem(this GtkListItemHandle self)
    {
        return GtkListItemExterns.gtk_list_item_get_item(self);
    }

    public static uint GetPosition(this GtkListItemHandle self)
    {
        return GtkListItemExterns.gtk_list_item_get_position(self);
    }

    public static int GetSelected(this GtkListItemHandle self)
    {
        return GtkListItemExterns.gtk_list_item_get_selected(self);
    }

    public static int GetSelectable(this GtkListItemHandle self)
    {
        return GtkListItemExterns.gtk_list_item_get_selectable(self);
    }

    public static GtkListItemHandle SetSelectable(this GtkListItemHandle self, int selectable)
    {
        GtkListItemExterns.gtk_list_item_set_selectable(self, selectable);
        return self;
    }

    public static int GetActivatable(this GtkListItemHandle self)
    {
        return GtkListItemExterns.gtk_list_item_get_activatable(self);
    }

    public static GtkListItemHandle SetActivatable(this GtkListItemHandle self, int activatable)
    {
        GtkListItemExterns.gtk_list_item_set_activatable(self, activatable);
        return self;
    }

    public static GtkListItemHandle SetChild(this GtkListItemHandle self, GtkWidgetHandle child)
    {
        GtkListItemExterns.gtk_list_item_set_child(self, child);
        return self;
    }

    public static GtkWidgetHandle GetChild(this GtkListItemHandle self)
    {
        return GtkListItemExterns.gtk_list_item_get_child(self);
    }
}
