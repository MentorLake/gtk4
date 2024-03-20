using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeListModelAdaptors
{
	public static GListModelHandle GetModel(this GtkTreeListModelHandle self)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_model(self);
	}

	public static int GetPassthrough(this GtkTreeListModelHandle self)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_passthrough(self);
	}

	public static GtkTreeListModelHandle SetAutoexpand(this GtkTreeListModelHandle self, int autoexpand)
	{
		GtkTreeListModelExterns.gtk_tree_list_model_set_autoexpand(self, autoexpand);
		return self;
	}

	public static int GetAutoexpand(this GtkTreeListModelHandle self)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_autoexpand(self);
	}

	public static GtkTreeListRowHandle GetChildRow(this GtkTreeListModelHandle self, uint position)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_child_row(self, position);
	}

	public static GtkTreeListRowHandle GetRow(this GtkTreeListModelHandle self, uint position)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_row(self, position);
	}
}
