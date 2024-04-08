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

public class GtkTreeExpanderHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkTreeExpanderHandle New()
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_new();
	}

}

public static class GtkTreeExpanderHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_child(self);
	}

	public static bool GetHideExpander(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_hide_expander(self);
	}

	public static bool GetIndentForDepth(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_indent_for_depth(self);
	}

	public static bool GetIndentForIcon(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_indent_for_icon(self);
	}

	public static GObjectHandle GetItem(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_item(self);
	}

	public static GtkTreeListRowHandle GetListRow(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_list_row(self);
	}

	public static GtkTreeExpanderHandle SetChild(this GtkTreeExpanderHandle self, GtkWidgetHandle child)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_child(self, child);
		return self;
	}

	public static GtkTreeExpanderHandle SetHideExpander(this GtkTreeExpanderHandle self, bool hide_expander)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_hide_expander(self, hide_expander);
		return self;
	}

	public static GtkTreeExpanderHandle SetIndentForDepth(this GtkTreeExpanderHandle self, bool indent_for_depth)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_indent_for_depth(self, indent_for_depth);
		return self;
	}

	public static GtkTreeExpanderHandle SetIndentForIcon(this GtkTreeExpanderHandle self, bool indent_for_icon)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_indent_for_icon(self, indent_for_icon);
		return self;
	}

	public static GtkTreeExpanderHandle SetListRow(this GtkTreeExpanderHandle self, GtkTreeListRowHandle list_row)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_list_row(self, list_row);
		return self;
	}

}

internal class GtkTreeExpanderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeExpanderHandle gtk_tree_expander_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_tree_expander_get_child(GtkTreeExpanderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_expander_get_hide_expander(GtkTreeExpanderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_expander_get_indent_for_depth(GtkTreeExpanderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_expander_get_indent_for_icon(GtkTreeExpanderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_tree_expander_get_item(GtkTreeExpanderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowHandle gtk_tree_expander_get_list_row(GtkTreeExpanderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_expander_set_child(GtkTreeExpanderHandle self, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_expander_set_hide_expander(GtkTreeExpanderHandle self, bool hide_expander);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_expander_set_indent_for_depth(GtkTreeExpanderHandle self, bool indent_for_depth);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_expander_set_indent_for_icon(GtkTreeExpanderHandle self, bool indent_for_icon);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_expander_set_list_row(GtkTreeExpanderHandle self, GtkTreeListRowHandle list_row);
}
