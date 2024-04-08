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

public class GtkListStoreHandle : GObjectHandle, GtkBuildableHandle, GtkTreeDragDestHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static GtkListStoreHandle New(int n_columns, IntPtr @__arglist)
	{
		return GtkListStoreExterns.gtk_list_store_new(n_columns, @__arglist);
	}

	public static GtkListStoreHandle Newv(int n_columns, GType[] types)
	{
		return GtkListStoreExterns.gtk_list_store_newv(n_columns, types);
	}

}

public static class GtkListStoreHandleExtensions
{
	public static GtkListStoreHandle Append(this GtkListStoreHandle list_store, out GtkTreeIter iter)
	{
		GtkListStoreExterns.gtk_list_store_append(list_store, out iter);
		return list_store;
	}

	public static GtkListStoreHandle Clear(this GtkListStoreHandle list_store)
	{
		GtkListStoreExterns.gtk_list_store_clear(list_store);
		return list_store;
	}

	public static GtkListStoreHandle Insert(this GtkListStoreHandle list_store, out GtkTreeIter iter, int position)
	{
		GtkListStoreExterns.gtk_list_store_insert(list_store, out iter, position);
		return list_store;
	}

	public static GtkListStoreHandle InsertAfter(this GtkListStoreHandle list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling)
	{
		GtkListStoreExterns.gtk_list_store_insert_after(list_store, out iter, sibling);
		return list_store;
	}

	public static GtkListStoreHandle InsertBefore(this GtkListStoreHandle list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling)
	{
		GtkListStoreExterns.gtk_list_store_insert_before(list_store, out iter, sibling);
		return list_store;
	}

	public static GtkListStoreHandle InsertWithValues(this GtkListStoreHandle list_store, out GtkTreeIter iter, int position, IntPtr @__arglist)
	{
		GtkListStoreExterns.gtk_list_store_insert_with_values(list_store, out iter, position, @__arglist);
		return list_store;
	}

	public static GtkListStoreHandle InsertWithValuesv(this GtkListStoreHandle list_store, out GtkTreeIter iter, int position, int[] columns, GValue[] values, int n_values)
	{
		GtkListStoreExterns.gtk_list_store_insert_with_valuesv(list_store, out iter, position, columns, values, n_values);
		return list_store;
	}

	public static bool IterIsValid(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		return GtkListStoreExterns.gtk_list_store_iter_is_valid(list_store, iter);
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

	public static GtkListStoreHandle Prepend(this GtkListStoreHandle list_store, out GtkTreeIter iter)
	{
		GtkListStoreExterns.gtk_list_store_prepend(list_store, out iter);
		return list_store;
	}

	public static bool Remove(this GtkListStoreHandle list_store, GtkTreeIterHandle iter)
	{
		return GtkListStoreExterns.gtk_list_store_remove(list_store, iter);
	}

	public static GtkListStoreHandle Reorder(this GtkListStoreHandle store, int[] new_order)
	{
		GtkListStoreExterns.gtk_list_store_reorder(store, new_order);
		return store;
	}

	public static GtkListStoreHandle Set(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__arglist)
	{
		GtkListStoreExterns.gtk_list_store_set(list_store, iter, @__arglist);
		return list_store;
	}

	public static GtkListStoreHandle SetColumnTypes(this GtkListStoreHandle list_store, int n_columns, GType[] types)
	{
		GtkListStoreExterns.gtk_list_store_set_column_types(list_store, n_columns, types);
		return list_store;
	}

	public static GtkListStoreHandle SetValist(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr var_args)
	{
		GtkListStoreExterns.gtk_list_store_set_valist(list_store, iter, var_args);
		return list_store;
	}

	public static GtkListStoreHandle SetValue(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int column, GValueHandle value)
	{
		GtkListStoreExterns.gtk_list_store_set_value(list_store, iter, column, value);
		return list_store;
	}

	public static GtkListStoreHandle SetValuesv(this GtkListStoreHandle list_store, GtkTreeIterHandle iter, int[] columns, GValue[] values, int n_values)
	{
		GtkListStoreExterns.gtk_list_store_set_valuesv(list_store, iter, columns, values, n_values);
		return list_store;
	}

	public static GtkListStoreHandle Swap(this GtkListStoreHandle store, GtkTreeIterHandle a, GtkTreeIterHandle b)
	{
		GtkListStoreExterns.gtk_list_store_swap(store, a, b);
		return store;
	}

}

internal class GtkListStoreExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListStoreHandle gtk_list_store_new(int n_columns, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListStoreHandle gtk_list_store_newv(int n_columns, GType[] types);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_append(GtkListStoreHandle list_store, out GtkTreeIter iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_clear(GtkListStoreHandle list_store);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_insert(GtkListStoreHandle list_store, out GtkTreeIter iter, int position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_insert_after(GtkListStoreHandle list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_insert_before(GtkListStoreHandle list_store, out GtkTreeIter iter, GtkTreeIterHandle sibling);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_insert_with_values(GtkListStoreHandle list_store, out GtkTreeIter iter, int position, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_insert_with_valuesv(GtkListStoreHandle list_store, out GtkTreeIter iter, int position, int[] columns, GValue[] values, int n_values);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_store_iter_is_valid(GtkListStoreHandle list_store, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_move_after(GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_move_before(GtkListStoreHandle store, GtkTreeIterHandle iter, GtkTreeIterHandle position);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_prepend(GtkListStoreHandle list_store, out GtkTreeIter iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_store_remove(GtkListStoreHandle list_store, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_reorder(GtkListStoreHandle store, int[] new_order);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_set(GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_set_column_types(GtkListStoreHandle list_store, int n_columns, GType[] types);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_set_valist(GtkListStoreHandle list_store, GtkTreeIterHandle iter, IntPtr var_args);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_set_value(GtkListStoreHandle list_store, GtkTreeIterHandle iter, int column, GValueHandle value);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_set_valuesv(GtkListStoreHandle list_store, GtkTreeIterHandle iter, int[] columns, GValue[] values, int n_values);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_store_swap(GtkListStoreHandle store, GtkTreeIterHandle a, GtkTreeIterHandle b);
}
