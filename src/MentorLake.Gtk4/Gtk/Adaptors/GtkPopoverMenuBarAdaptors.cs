using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPopoverMenuBarAdaptors
{
	public static GtkPopoverMenuBarHandle SetMenuModel(this GtkPopoverMenuBarHandle bar, GMenuModelHandle model)
	{
		GtkPopoverMenuBarExterns.gtk_popover_menu_bar_set_menu_model(bar, model);
		return bar;
	}

	public static GMenuModelHandle GetMenuModel(this GtkPopoverMenuBarHandle bar)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_get_menu_model(bar);
	}

	public static int AddChild(this GtkPopoverMenuBarHandle bar, GtkWidgetHandle child, string id)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_add_child(bar, child, id);
	}

	public static int RemoveChild(this GtkPopoverMenuBarHandle bar, GtkWidgetHandle child)
	{
		return GtkPopoverMenuBarExterns.gtk_popover_menu_bar_remove_child(bar, child);
	}
}
