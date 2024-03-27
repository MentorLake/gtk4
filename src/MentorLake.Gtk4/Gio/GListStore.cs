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

namespace MentorLake.Gtk4.Gio;

public class GListStoreHandle : GObjectHandle
{
	public static GListStoreHandle New(GType item_type)
	{
		return GListStoreExterns.g_list_store_new(item_type);
	}
}

public static class GListStoreSignals
{
}

public static class GListStoreHandleExtensions
{
	public static GListStoreHandle Append(this GListStoreHandle store, GObjectHandle item)
	{
		GListStoreExterns.g_list_store_append(store, item);
		return store;
	}

	public static bool Find(this GListStoreHandle store, GObjectHandle item, out uint position)
	{
		return GListStoreExterns.g_list_store_find(store, item, out position);
	}

	public static bool FindWithEqualFunc(this GListStoreHandle store, GObjectHandle item, GEqualFunc equal_func, out uint position)
	{
		return GListStoreExterns.g_list_store_find_with_equal_func(store, item, equal_func, out position);
	}

	public static bool FindWithEqualFuncFull(this GListStoreHandle store, GObjectHandle item, GEqualFuncFull equal_func, IntPtr user_data, out uint position)
	{
		return GListStoreExterns.g_list_store_find_with_equal_func_full(store, item, equal_func, user_data, out position);
	}

	public static GListStoreHandle Insert(this GListStoreHandle store, uint position, GObjectHandle item)
	{
		GListStoreExterns.g_list_store_insert(store, position, item);
		return store;
	}

	public static uint InsertSorted(this GListStoreHandle store, GObjectHandle item, GCompareDataFunc compare_func, IntPtr user_data)
	{
		return GListStoreExterns.g_list_store_insert_sorted(store, item, compare_func, user_data);
	}

	public static GListStoreHandle Remove(this GListStoreHandle store, uint position)
	{
		GListStoreExterns.g_list_store_remove(store, position);
		return store;
	}

	public static GListStoreHandle RemoveAll(this GListStoreHandle store)
	{
		GListStoreExterns.g_list_store_remove_all(store);
		return store;
	}

	public static GListStoreHandle Sort(this GListStoreHandle store, GCompareDataFunc compare_func, IntPtr user_data)
	{
		GListStoreExterns.g_list_store_sort(store, compare_func, user_data);
		return store;
	}

	public static GListStoreHandle Splice(this GListStoreHandle store, uint position, uint n_removals, IntPtr[] additions, uint n_additions)
	{
		GListStoreExterns.g_list_store_splice(store, position, n_removals, additions, n_additions);
		return store;
	}

}

internal class GListStoreExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_list_store_append(GListStoreHandle store, GObjectHandle item);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_list_store_find(GListStoreHandle store, GObjectHandle item, out uint position);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_list_store_find_with_equal_func(GListStoreHandle store, GObjectHandle item, GEqualFunc equal_func, out uint position);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_list_store_find_with_equal_func_full(GListStoreHandle store, GObjectHandle item, GEqualFuncFull equal_func, IntPtr user_data, out uint position);
	[DllImport(Libraries.Gio)]
	internal static extern void g_list_store_insert(GListStoreHandle store, uint position, GObjectHandle item);
	[DllImport(Libraries.Gio)]
	internal static extern uint g_list_store_insert_sorted(GListStoreHandle store, GObjectHandle item, GCompareDataFunc compare_func, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern void g_list_store_remove(GListStoreHandle store, uint position);
	[DllImport(Libraries.Gio)]
	internal static extern void g_list_store_remove_all(GListStoreHandle store);
	[DllImport(Libraries.Gio)]
	internal static extern void g_list_store_sort(GListStoreHandle store, GCompareDataFunc compare_func, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern void g_list_store_splice(GListStoreHandle store, uint position, uint n_removals, IntPtr[] additions, uint n_additions);
	[DllImport(Libraries.Gio)]
	internal static extern GListStoreHandle g_list_store_new(GType item_type);
}
