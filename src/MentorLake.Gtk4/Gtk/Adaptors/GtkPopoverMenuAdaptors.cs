using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPopoverMenuAdaptors
{
	public static GtkPopoverMenuHandle SetMenuModel(this GtkPopoverMenuHandle popover, GMenuModelHandle model)
	{
		GtkPopoverMenuExterns.gtk_popover_menu_set_menu_model(popover, model);
		return popover;
	}

	public static GMenuModelHandle GetMenuModel(this GtkPopoverMenuHandle popover)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_get_menu_model(popover);
	}

	public static int AddChild(this GtkPopoverMenuHandle popover, GtkWidgetHandle child, string id)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_add_child(popover, child, id);
	}

	public static int RemoveChild(this GtkPopoverMenuHandle popover, GtkWidgetHandle child)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_remove_child(popover, child);
	}

	public static GtkPopoverMenuHandle NewFromModelFull(GMenuModelHandle model, GtkPopoverMenuFlags flags)
	{
		return GtkPopoverMenuExterns.gtk_popover_menu_new_from_model_full(model, flags);
	}
}
