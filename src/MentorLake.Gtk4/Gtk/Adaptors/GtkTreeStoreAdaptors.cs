using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeStoreAdaptors
{
	public static GtkTreeStoreHandle SetColumnTypes(this GtkTreeStoreHandle tree_store, int n_columns, GTypeHandle types)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_column_types(tree_store, n_columns, types);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetValue(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int column, GValueHandle value)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_value(tree_store, iter, column, value);
		return tree_store;
	}

	public static GtkTreeStoreHandle Set(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr @__argList)
	{
		GtkTreeStoreExterns.gtk_tree_store_set(tree_store, iter, @__argList);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetValuesv(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, int[] columns, GValueHandle values, int n_values)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_valuesv(tree_store, iter, columns, values, n_values);
		return tree_store;
	}

	public static GtkTreeStoreHandle SetValist(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, IntPtr @__argList)
	{
		GtkTreeStoreExterns.gtk_tree_store_set_valist(tree_store, iter, @__argList);
		return tree_store;
	}

	public static int Remove(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter)
	{
		return GtkTreeStoreExterns.gtk_tree_store_remove(tree_store, iter);
	}

	public static GtkTreeStoreHandle Insert(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int position)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert(tree_store, iter, parent, position);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertBefore(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_before(tree_store, iter, parent, sibling);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertAfter(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, GtkTreeIterHandle sibling)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_after(tree_store, iter, parent, sibling);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertWithValues(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int position, IntPtr @__argList)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_with_values(tree_store, iter, parent, position, @__argList);
		return tree_store;
	}

	public static GtkTreeStoreHandle InsertWithValuesv(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent, int position, int[] columns, GValueHandle values, int n_values)
	{
		GtkTreeStoreExterns.gtk_tree_store_insert_with_valuesv(tree_store, iter, parent, position, columns, values, n_values);
		return tree_store;
	}

	public static GtkTreeStoreHandle Prepend(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent)
	{
		GtkTreeStoreExterns.gtk_tree_store_prepend(tree_store, iter, parent);
		return tree_store;
	}

	public static GtkTreeStoreHandle Append(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle parent)
	{
		GtkTreeStoreExterns.gtk_tree_store_append(tree_store, iter, parent);
		return tree_store;
	}

	public static int IsAncestor(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle descendant)
	{
		return GtkTreeStoreExterns.gtk_tree_store_is_ancestor(tree_store, iter, descendant);
	}

	public static int IterDepth(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter)
	{
		return GtkTreeStoreExterns.gtk_tree_store_iter_depth(tree_store, iter);
	}

	public static GtkTreeStoreHandle Clear(this GtkTreeStoreHandle tree_store)
	{
		GtkTreeStoreExterns.gtk_tree_store_clear(tree_store);
		return tree_store;
	}

	public static int IterIsValid(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter)
	{
		return GtkTreeStoreExterns.gtk_tree_store_iter_is_valid(tree_store, iter);
	}

	public static GtkTreeStoreHandle Reorder(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle parent, int[] new_order)
	{
		GtkTreeStoreExterns.gtk_tree_store_reorder(tree_store, parent, new_order);
		return tree_store;
	}

	public static GtkTreeStoreHandle Swap(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle a, GtkTreeIterHandle b)
	{
		GtkTreeStoreExterns.gtk_tree_store_swap(tree_store, a, b);
		return tree_store;
	}

	public static GtkTreeStoreHandle MoveBefore(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position)
	{
		GtkTreeStoreExterns.gtk_tree_store_move_before(tree_store, iter, position);
		return tree_store;
	}

	public static GtkTreeStoreHandle MoveAfter(this GtkTreeStoreHandle tree_store, GtkTreeIterHandle iter, GtkTreeIterHandle position)
	{
		GtkTreeStoreExterns.gtk_tree_store_move_after(tree_store, iter, position);
		return tree_store;
	}

	public static GtkTreeStoreHandle Newv(int n_columns, GTypeHandle types)
	{
		return GtkTreeStoreExterns.gtk_tree_store_newv(n_columns, types);
	}
}
