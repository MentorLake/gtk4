using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkListItemHandle : GObjectHandle
{
}

public static class GtkListItemSignals
{
}

public static class GtkListItemHandleExtensions
{
	public static string GetAccessibleDescription(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_accessible_description(self);
	}

	public static string GetAccessibleLabel(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_accessible_label(self);
	}

	public static bool GetActivatable(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_activatable(self);
	}

	public static GtkWidgetHandle GetChild(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_child(self);
	}

	public static bool GetFocusable(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_focusable(self);
	}

	public static GObjectHandle GetItem(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_item(self);
	}

	public static uint GetPosition(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_position(self);
	}

	public static bool GetSelectable(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_selectable(self);
	}

	public static bool GetSelected(this GtkListItemHandle self)
	{
		return GtkListItemExterns.gtk_list_item_get_selected(self);
	}

	public static GtkListItemHandle SetAccessibleDescription(this GtkListItemHandle self, string description)
	{
		GtkListItemExterns.gtk_list_item_set_accessible_description(self, description);
		return self;
	}

	public static GtkListItemHandle SetAccessibleLabel(this GtkListItemHandle self, string label)
	{
		GtkListItemExterns.gtk_list_item_set_accessible_label(self, label);
		return self;
	}

	public static GtkListItemHandle SetActivatable(this GtkListItemHandle self, bool activatable)
	{
		GtkListItemExterns.gtk_list_item_set_activatable(self, activatable);
		return self;
	}

	public static GtkListItemHandle SetChild(this GtkListItemHandle self, GtkWidgetHandle child)
	{
		GtkListItemExterns.gtk_list_item_set_child(self, child);
		return self;
	}

	public static GtkListItemHandle SetFocusable(this GtkListItemHandle self, bool focusable)
	{
		GtkListItemExterns.gtk_list_item_set_focusable(self, focusable);
		return self;
	}

	public static GtkListItemHandle SetSelectable(this GtkListItemHandle self, bool selectable)
	{
		GtkListItemExterns.gtk_list_item_set_selectable(self, selectable);
		return self;
	}

}

internal class GtkListItemExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_list_item_get_accessible_description(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_list_item_get_accessible_label(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_item_get_activatable(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_list_item_get_child(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_item_get_focusable(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_list_item_get_item(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_list_item_get_position(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_item_get_selectable(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_item_get_selected(GtkListItemHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_item_set_accessible_description(GtkListItemHandle self, string description);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_item_set_accessible_label(GtkListItemHandle self, string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_item_set_activatable(GtkListItemHandle self, bool activatable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_item_set_child(GtkListItemHandle self, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_item_set_focusable(GtkListItemHandle self, bool focusable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_item_set_selectable(GtkListItemHandle self, bool selectable);
}
