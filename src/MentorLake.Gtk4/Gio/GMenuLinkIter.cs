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

public class GMenuLinkIterHandle : GObjectHandle
{
}

public static class GMenuLinkIterSignals
{
}

public static class GMenuLinkIterHandleExtensions
{
	public static string GetName(this GMenuLinkIterHandle iter)
	{
		return GMenuLinkIterExterns.g_menu_link_iter_get_name(iter);
	}

	public static bool GetNext(this GMenuLinkIterHandle iter, out string out_link, out GMenuModelHandle value)
	{
		return GMenuLinkIterExterns.g_menu_link_iter_get_next(iter, out out_link, out value);
	}

	public static GMenuModelHandle GetValue(this GMenuLinkIterHandle iter)
	{
		return GMenuLinkIterExterns.g_menu_link_iter_get_value(iter);
	}

	public static bool Next(this GMenuLinkIterHandle iter)
	{
		return GMenuLinkIterExterns.g_menu_link_iter_next(iter);
	}

}

internal class GMenuLinkIterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_menu_link_iter_get_name(GMenuLinkIterHandle iter);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_link_iter_get_next(GMenuLinkIterHandle iter, out string out_link, out GMenuModelHandle value);
	[DllImport(Libraries.Gio)]
	internal static extern GMenuModelHandle g_menu_link_iter_get_value(GMenuLinkIterHandle iter);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_menu_link_iter_next(GMenuLinkIterHandle iter);
}
