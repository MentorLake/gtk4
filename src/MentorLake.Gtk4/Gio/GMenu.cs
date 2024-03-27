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

public class GMenuHandle : GMenuModelHandle
{
	public static GMenuHandle New()
	{
		return GMenuExterns.g_menu_new();
	}
}

public static class GMenuSignals
{
}

public static class GMenuHandleExtensions
{
	public static GMenuHandle Append(this GMenuHandle menu, string label, string detailed_action)
	{
		GMenuExterns.g_menu_append(menu, label, detailed_action);
		return menu;
	}

	public static GMenuHandle AppendItem(this GMenuHandle menu, GMenuItemHandle item)
	{
		GMenuExterns.g_menu_append_item(menu, item);
		return menu;
	}

	public static GMenuHandle AppendSection(this GMenuHandle menu, string label, GMenuModelHandle section)
	{
		GMenuExterns.g_menu_append_section(menu, label, section);
		return menu;
	}

	public static GMenuHandle AppendSubmenu(this GMenuHandle menu, string label, GMenuModelHandle submenu)
	{
		GMenuExterns.g_menu_append_submenu(menu, label, submenu);
		return menu;
	}

	public static GMenuHandle Freeze(this GMenuHandle menu)
	{
		GMenuExterns.g_menu_freeze(menu);
		return menu;
	}

	public static GMenuHandle Insert(this GMenuHandle menu, int position, string label, string detailed_action)
	{
		GMenuExterns.g_menu_insert(menu, position, label, detailed_action);
		return menu;
	}

	public static GMenuHandle InsertItem(this GMenuHandle menu, int position, GMenuItemHandle item)
	{
		GMenuExterns.g_menu_insert_item(menu, position, item);
		return menu;
	}

	public static GMenuHandle InsertSection(this GMenuHandle menu, int position, string label, GMenuModelHandle section)
	{
		GMenuExterns.g_menu_insert_section(menu, position, label, section);
		return menu;
	}

	public static GMenuHandle InsertSubmenu(this GMenuHandle menu, int position, string label, GMenuModelHandle submenu)
	{
		GMenuExterns.g_menu_insert_submenu(menu, position, label, submenu);
		return menu;
	}

	public static GMenuHandle Prepend(this GMenuHandle menu, string label, string detailed_action)
	{
		GMenuExterns.g_menu_prepend(menu, label, detailed_action);
		return menu;
	}

	public static GMenuHandle PrependItem(this GMenuHandle menu, GMenuItemHandle item)
	{
		GMenuExterns.g_menu_prepend_item(menu, item);
		return menu;
	}

	public static GMenuHandle PrependSection(this GMenuHandle menu, string label, GMenuModelHandle section)
	{
		GMenuExterns.g_menu_prepend_section(menu, label, section);
		return menu;
	}

	public static GMenuHandle PrependSubmenu(this GMenuHandle menu, string label, GMenuModelHandle submenu)
	{
		GMenuExterns.g_menu_prepend_submenu(menu, label, submenu);
		return menu;
	}

	public static GMenuHandle Remove(this GMenuHandle menu, int position)
	{
		GMenuExterns.g_menu_remove(menu, position);
		return menu;
	}

	public static GMenuHandle RemoveAll(this GMenuHandle menu)
	{
		GMenuExterns.g_menu_remove_all(menu);
		return menu;
	}

}

internal class GMenuExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append(GMenuHandle menu, string label, string detailed_action);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append_item(GMenuHandle menu, GMenuItemHandle item);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append_section(GMenuHandle menu, string label, GMenuModelHandle section);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_append_submenu(GMenuHandle menu, string label, GMenuModelHandle submenu);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_freeze(GMenuHandle menu);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert(GMenuHandle menu, int position, string label, string detailed_action);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert_item(GMenuHandle menu, int position, GMenuItemHandle item);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert_section(GMenuHandle menu, int position, string label, GMenuModelHandle section);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_insert_submenu(GMenuHandle menu, int position, string label, GMenuModelHandle submenu);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend(GMenuHandle menu, string label, string detailed_action);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend_item(GMenuHandle menu, GMenuItemHandle item);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend_section(GMenuHandle menu, string label, GMenuModelHandle section);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_prepend_submenu(GMenuHandle menu, string label, GMenuModelHandle submenu);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_remove(GMenuHandle menu, int position);
	[DllImport(Libraries.Gio)]
	internal static extern void g_menu_remove_all(GMenuHandle menu);
	[DllImport(Libraries.Gio)]
	internal static extern GMenuHandle g_menu_new();
}
