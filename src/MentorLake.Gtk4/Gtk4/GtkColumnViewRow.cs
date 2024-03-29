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

public class GtkColumnViewRowHandle : GObjectHandle
{
}

public static class GtkColumnViewRowHandleExtensions
{
	public static string GetAccessibleDescription(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_accessible_description(self);
	}

	public static string GetAccessibleLabel(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_accessible_label(self);
	}

	public static bool GetActivatable(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_activatable(self);
	}

	public static bool GetFocusable(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_focusable(self);
	}

	public static GObjectHandle GetItem(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_item(self);
	}

	public static uint GetPosition(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_position(self);
	}

	public static bool GetSelectable(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_selectable(self);
	}

	public static bool GetSelected(this GtkColumnViewRowHandle self)
	{
		return GtkColumnViewRowExterns.gtk_column_view_row_get_selected(self);
	}

	public static GtkColumnViewRowHandle SetAccessibleDescription(this GtkColumnViewRowHandle self, string description)
	{
		GtkColumnViewRowExterns.gtk_column_view_row_set_accessible_description(self, description);
		return self;
	}

	public static GtkColumnViewRowHandle SetAccessibleLabel(this GtkColumnViewRowHandle self, string label)
	{
		GtkColumnViewRowExterns.gtk_column_view_row_set_accessible_label(self, label);
		return self;
	}

	public static GtkColumnViewRowHandle SetActivatable(this GtkColumnViewRowHandle self, bool activatable)
	{
		GtkColumnViewRowExterns.gtk_column_view_row_set_activatable(self, activatable);
		return self;
	}

	public static GtkColumnViewRowHandle SetFocusable(this GtkColumnViewRowHandle self, bool focusable)
	{
		GtkColumnViewRowExterns.gtk_column_view_row_set_focusable(self, focusable);
		return self;
	}

	public static GtkColumnViewRowHandle SetSelectable(this GtkColumnViewRowHandle self, bool selectable)
	{
		GtkColumnViewRowExterns.gtk_column_view_row_set_selectable(self, selectable);
		return self;
	}

}

internal class GtkColumnViewRowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_column_view_row_get_accessible_description(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_column_view_row_get_accessible_label(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_row_get_activatable(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_row_get_focusable(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_column_view_row_get_item(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_column_view_row_get_position(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_row_get_selectable(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_column_view_row_get_selected(GtkColumnViewRowHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_row_set_accessible_description(GtkColumnViewRowHandle self, string description);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_row_set_accessible_label(GtkColumnViewRowHandle self, string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_row_set_activatable(GtkColumnViewRowHandle self, bool activatable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_row_set_focusable(GtkColumnViewRowHandle self, bool focusable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_column_view_row_set_selectable(GtkColumnViewRowHandle self, bool selectable);
}
