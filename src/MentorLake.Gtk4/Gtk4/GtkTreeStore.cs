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

public class GtkTreeStoreHandle : GObjectHandle
{
	public static GtkTreeStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkTreeStoreExterns.gtk_tree_store_new(n_columns, @__arglist);
	}

	public static GtkTreeStoreHandle Newv(int n_columns, GType[] types)
	{
		return GtkTreeStoreExterns.gtk_tree_store_newv(n_columns, types);
	}

}

public static class GtkTreeStoreHandleExtensions
{
	public static GtkTreeStoreHandle Append(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent)
	{
		GtkTreeStoreExterns.gtk_tree_store_append(tree_store, out iter, parent);
		return tree_store;
	}

	public static GtkTreeStoreHandle Clear(this GtkTreeStoreHandle tree_store)
	{
		GtkTreeStoreExterns.gtk_tree_store_clear(tree_store);
		return tree_store;
	}

	public static GtkTreeStoreHandle Insert(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, int position)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert(tree_store, out iter, parent, position);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertAfter(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_after(tree_store, out iter, parent, sibling);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertBefore(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_before(tree_store, out iter, parent, sibling);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertWithValues(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, int position, IntPtr @__arglist)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_with_values(tree_store, out iter, parent, position, @__arglist);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertWithValuesv(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, int position, int[] columns, GValue[] values, int n_values)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_with_valuesv(tree_store, out iter, parent, position, columns, values, n_values);
		return tree_store;
	}

	public static bool IsAncestor(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle descendant)
	{
		return GtkTreeStoreExterns.gtk_tree_store_is_ancestor(tree_store, iter, descendant);
	}

	public static int IterDepth(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter)
	{
		return GtkTreeStoreExterns.gtk_tree_store_iter_depth(tree_store, iter);
	}

	public static bool IterIsValid(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter)
	{
		return GtkTreeStoreExterns.gtk_tree_store_iter_is_valid(tree_store, iter);
	}

	public static GtkTreeStoreHandle MoveAfter(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position)
	{
		GtkTreeStoreExterns.gtk_tree_store_move_after(tree_store, iter, position);
		return tree_store;
	}

	public static GtkTreeStoreHandle MoveBefore(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position)
	{
		GtkTreeStoreExterns.gtk_tree_store_move_before(tree_store, iter, position);
		return tree_store;
	}

	public static GtkTreeStoreHandle Prepend(this GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent)
	{
		GtkTreeStoreExterns.gtk_tree_store_prepend(tree_store, out iter, parent);
		return tree_store;
	}

	public static bool Remove(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter)
	{
		return GtkTreeStoreExterns.gtk_tree_store_remove(tree_store, iter);
	}

	public static GtkTreeStoreHandle Reorder(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle parent, int[] new_order)
	{
		GtkTreeStoreExterns.gtk_tree_store_reorder(tree_store, parent, new_order);
		return tree_store;
	}

	public static GtkTreeStoreHandle Set(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr @__arglist)
	{
		GtkTreeStoreExterns.gtk_tree_store_set(tree_store, iter, @__arglist);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetColumnTypes(this GtkTreeStoreHandle tree_store, int n_columns, GType[] types)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_column_types(tree_store, n_columns, types);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetValist(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr var_args)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_valist(tree_store, iter, var_args);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetValue(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int column, GValueHandle value)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_value(tree_store, iter, column, value);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetValuesv(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int[] columns, GValue[] values, int n_values)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_valuesv(tree_store, iter, columns, values, n_values);
		return tree_store;
	}

	public static GtkTreeStoreHandle Swap(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle a, GtkTreeIterHandle b)
	{
		GtkTreeStoreExterns.gtk_tree_store_swap(tree_store, a, b);
		return tree_store;
	}

}

internal class GtkTreeStoreExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeStoreHandle gtk_tree_store_new(int n_columns, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeStoreHandle gtk_tree_store_newv(int n_columns, GType[] types);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_append(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_clear(GtkTreeStoreHandle tree_store);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_insert(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_insert_after(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_insert_before(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_insert_with_values(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, int position, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_insert_with_valuesv(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent, int position, int[] columns, GValue[] values, int n_values);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_store_is_ancestor(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle descendant);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_tree_store_iter_depth(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_store_iter_is_valid(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_move_after(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_move_before(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_prepend(GtkTreeStoreHandle tree_store, out GtkTreeIter iter, GtkTreeIterHandle parent);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_store_remove(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_reorder(GtkTreeStoreHandle tree_store, GtkTreeIterHandle parent, int[] new_order);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_set(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_set_column_types(GtkTreeStoreHandle tree_store, int n_columns, GType[] types);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_set_valist(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr var_args);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_set_value(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int column, GValueHandle value);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_set_valuesv(GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int[] columns, GValue[] values, int n_values);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_store_swap(GtkTreeStoreHandle tree_store, GtkTreeIterHandle a, GtkTreeIterHandle b);
}
