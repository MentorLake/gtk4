using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListStoreAdaptors
{
	public static GtkListStoreHandle SetColumnTypes(this GtkListStoreHandle list_store, int n_columns, GTypeHandle types)
	{
		GtkListStoreExterns.gtk_list_store_set_column_types(list_store, n_columns, types);
		return list_store;
	}

	public static GtkListStoreHandle SetValue(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int column, GValueHandle value)
	{
		GtkListStoreExterns.gtk_list_store_set_value(list_store, iter, column, value);
		return list_store;
	}

	public static GtkListStoreHandle Set(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__argList)
	{
		GtkListStoreExterns.gtk_list_store_set(list_store, iter, @__argList);
		return list_store;
	}

	public static GtkListStoreHandle SetValuesv(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int[] columns, GValueHandle values, int n_values)
	{
		GtkListStoreExterns.gtk_list_store_set_valuesv(list_store, iter, columns, values, n_values);
		return list_store;
	}

	public static GtkListStoreHandle SetValist(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__argList)
	{
		GtkListStoreExterns.gtk_list_store_set_valist(list_store, iter, @__argList);
		return list_store;
	}

	public static int Remove(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		return GtkListStoreExterns.gtk_list_store_remove(list_store, iter);
	}

	public static GtkListStoreHandle Insert(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int position)
	{
		GtkListStoreExterns.gtk_list_store_insert(list_store, iter, position);
		return list_store;
	}

	public static GtkListStoreHandle InsertBefore(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, GtkTreeIterHandle sibling)
	{
		GtkListStoreExterns.gtk_list_store_insert_before(list_store, iter, sibling);
		return list_store;
	}

	public static GtkListStoreHandle InsertAfter(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, GtkTreeIterHandle sibling)
	{
		GtkListStoreExterns.gtk_list_store_insert_after(list_store, iter, sibling);
		return list_store;
	}

	public static GtkListStoreHandle InsertWithValues(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int position, IntPtr @__argList)
	{
		GtkListStoreExterns.gtk_list_store_insert_with_values(list_store, iter, position, @__argList);
		return list_store;
	}

	public static GtkListStoreHandle InsertWithValuesv(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int position, int[] columns, GValueHandle values, int n_values)
	{
		GtkListStoreExterns.gtk_list_store_insert_with_valuesv(list_store, iter, position, columns, values, n_values);
		return list_store;
	}

	public static GtkListStoreHandle Prepend(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		GtkListStoreExterns.gtk_list_store_prepend(list_store, iter);
		return list_store;
	}

	public static GtkListStoreHandle Append(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		GtkListStoreExterns.gtk_list_store_append(list_store, iter);
		return list_store;
	}

	public static GtkListStoreHandle Clear(this GtkListStoreHandle list_store)
	{
		GtkListStoreExterns.gtk_list_store_clear(list_store);
		return list_store;
	}

	public static int IterIsValid(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		return GtkListStoreExterns.gtk_list_store_iter_is_valid(list_store, iter);
	}

	public static GtkListStoreHandle Reorder(this GtkListStoreHandle store, int[] new_order)
	{
		GtkListStoreExterns.gtk_list_store_reorder(store, new_order);
		return store;
	}

	public static GtkListStoreHandle Swap(this GtkListStoreHandle store, GtkTreeIterHandle a, GtkTreeIterHandle b)
	{
		GtkListStoreExterns.gtk_list_store_swap(store, a, b);
		return store;
	}

	public static GtkListStoreHandle MoveAfter(this GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position)
	{
		GtkListStoreExterns.gtk_list_store_move_after(store, iter, position);
		return store;
	}

	public static GtkListStoreHandle MoveBefore(this GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position)
	{
		GtkListStoreExterns.gtk_list_store_move_before(store, iter, position);
		return store;
	}

	public static GtkListStoreHandle Newv(int n_columns, GTypeHandle types)
	{
		return GtkListStoreExterns.gtk_list_store_newv(n_columns, types);
	}
}
