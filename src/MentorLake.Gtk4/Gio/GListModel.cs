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

public interface GListModelHandle
{
}

public static class GListModelHandleExtensions
{
	public static IntPtr GetItem(this GListModelHandle list, uint position)
	{
		return GListModelExterns.g_list_model_get_item(list, position);
	}

	public static GType GetItemType(this GListModelHandle list)
	{
		return GListModelExterns.g_list_model_get_item_type(list);
	}

	public static uint GetNItems(this GListModelHandle list)
	{
		return GListModelExterns.g_list_model_get_n_items(list);
	}

	public static GObjectHandle GetObject(this GListModelHandle list, uint position)
	{
		return GListModelExterns.g_list_model_get_object(list, position);
	}

	public static GListModelHandle ItemsChanged(this GListModelHandle list, uint position, uint removed, uint added)
	{
		GListModelExterns.g_list_model_items_changed(list, position, removed, added);
		return list;
	}

}

internal class GListModelExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_list_model_get_item(GListModelHandle list, uint position);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_list_model_get_item_type(GListModelHandle list);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_list_model_get_n_items(GListModelHandle list);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_list_model_get_object(GListModelHandle list, uint position);

	[DllImport(Libraries.Gio)]
	internal static extern void g_list_model_items_changed(GListModelHandle list, uint position, uint removed, uint added);

}
