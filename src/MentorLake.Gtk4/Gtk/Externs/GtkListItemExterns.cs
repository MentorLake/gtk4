using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkListItemExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_get_item")]
	internal static extern IntPtr gtk_list_item_get_item(this GtkListItemHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_get_position")]
	internal static extern uint gtk_list_item_get_position(this GtkListItemHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_get_selected")]
	internal static extern int gtk_list_item_get_selected(this GtkListItemHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_get_selectable")]
	internal static extern int gtk_list_item_get_selectable(this GtkListItemHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_set_selectable")]
	internal static extern void gtk_list_item_set_selectable(this GtkListItemHandle self, int selectable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_get_activatable")]
	internal static extern int gtk_list_item_get_activatable(this GtkListItemHandle self);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_set_activatable")]
	internal static extern void gtk_list_item_set_activatable(this GtkListItemHandle self, int activatable);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_set_child")]
	internal static extern void gtk_list_item_set_child(this GtkListItemHandle self, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_list_item_get_child")]
	internal static extern GtkWidgetHandle gtk_list_item_get_child(this GtkListItemHandle self);
}
