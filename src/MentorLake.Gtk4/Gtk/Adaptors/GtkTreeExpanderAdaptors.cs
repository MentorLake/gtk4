using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeExpanderAdaptors
{
	public static GtkWidgetHandle GetChild(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_child(self);
	}

	public static GtkTreeExpanderHandle SetChild(this GtkTreeExpanderHandle self, GtkWidgetHandle child)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_child(self, child);
		return self;
	}

	public static IntPtr GetItem(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_item(self);
	}

	public static GtkTreeListRowHandle GetListRow(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_list_row(self);
	}

	public static GtkTreeExpanderHandle SetListRow(this GtkTreeExpanderHandle self, GtkTreeListRowHandle list_row)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_list_row(self, list_row);
		return self;
	}

	public static int GetIndentForIcon(this GtkTreeExpanderHandle self)
	{
		return GtkTreeExpanderExterns.gtk_tree_expander_get_indent_for_icon(self);
	}

	public static GtkTreeExpanderHandle SetIndentForIcon(this GtkTreeExpanderHandle self, int indent_for_icon)
	{
		GtkTreeExpanderExterns.gtk_tree_expander_set_indent_for_icon(self, indent_for_icon);
		return self;
	}
}
