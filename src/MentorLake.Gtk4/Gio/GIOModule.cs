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

public class GIOModuleHandle : GTypeModuleHandle, GTypePluginHandle
{
	public static GIOModuleHandle GIoModuleNew(string filename)
	{
		return GIOModuleExterns.g_io_module_new(filename);
	}

	public static string[] GIoModuleQuery()
	{
		return GIOModuleExterns.g_io_module_query();
	}

}

public static class GIOModuleHandleExtensions
{
	public static GIOModuleHandle GIoModuleLoad(this GIOModuleHandle module)
	{
		GIOModuleExterns.g_io_module_load(module);
		return module;
	}

	public static GIOModuleHandle GIoModuleUnload(this GIOModuleHandle module)
	{
		GIOModuleExterns.g_io_module_unload(module);
		return module;
	}

}

internal class GIOModuleExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GIOModuleHandle g_io_module_new(string filename);
	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_load(GIOModuleHandle module);
	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_unload(GIOModuleHandle module);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_io_module_query();
}
