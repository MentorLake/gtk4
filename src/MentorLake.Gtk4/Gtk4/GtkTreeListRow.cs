using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkTreeListRowHandle : GObjectHandle
{
}

public static class GtkTreeListRowHandleExtensions
{
	public static GtkTreeListRowHandle GetChildRow(this GtkTreeListRowHandle self, uint position)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_child_row(self, position);
	}

	public static GListModelHandle GetChildren(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_children(self);
	}

	public static uint GetDepth(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_depth(self);
	}

	public static bool GetExpanded(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_expanded(self);
	}

	public static GObjectHandle GetItem(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_item(self);
	}

	public static GtkTreeListRowHandle GetParent(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_parent(self);
	}

	public static uint GetPosition(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_get_position(self);
	}

	public static bool IsExpandable(this GtkTreeListRowHandle self)
	{
		return GtkTreeListRowExterns.gtk_tree_list_row_is_expandable(self);
	}

	public static GtkTreeListRowHandle SetExpanded(this GtkTreeListRowHandle self, bool expanded)
	{
		GtkTreeListRowExterns.gtk_tree_list_row_set_expanded(self, expanded);
		return self;
	}

}

internal class GtkTreeListRowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowHandle gtk_tree_list_row_get_child_row(GtkTreeListRowHandle self, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_tree_list_row_get_children(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_tree_list_row_get_depth(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_list_row_get_expanded(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_tree_list_row_get_item(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowHandle gtk_tree_list_row_get_parent(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_tree_list_row_get_position(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_list_row_is_expandable(GtkTreeListRowHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_list_row_set_expanded(GtkTreeListRowHandle self, bool expanded);

}
