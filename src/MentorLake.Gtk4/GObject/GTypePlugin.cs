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

namespace MentorLake.Gtk4.GObject;

public interface GTypePluginHandle
{
}

public static class GTypePluginHandleExtensions
{
	public static GTypePluginHandle CompleteInterfaceInfo(this GTypePluginHandle plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info)
	{
		GTypePluginExterns.g_type_plugin_complete_interface_info(plugin, instance_type, interface_type, info);
		return plugin;
	}

	public static GTypePluginHandle CompleteTypeInfo(this GTypePluginHandle plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table)
	{
		GTypePluginExterns.g_type_plugin_complete_type_info(plugin, g_type, info, value_table);
		return plugin;
	}

	public static GTypePluginHandle Unuse(this GTypePluginHandle plugin)
	{
		GTypePluginExterns.g_type_plugin_unuse(plugin);
		return plugin;
	}

	public static GTypePluginHandle Use(this GTypePluginHandle plugin)
	{
		GTypePluginExterns.g_type_plugin_use(plugin);
		return plugin;
	}

}

internal class GTypePluginExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_complete_interface_info(GTypePluginHandle plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info);
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_complete_type_info(GTypePluginHandle plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table);
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_unuse(GTypePluginHandle plugin);
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_use(GTypePluginHandle plugin);
}
