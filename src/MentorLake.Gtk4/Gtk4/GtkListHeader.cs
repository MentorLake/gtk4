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

public class GtkListHeaderHandle : GObjectHandle
{
}

public static class GtkListHeaderSignals
{
}

public static class GtkListHeaderHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkListHeaderHandle self)
	{
		return GtkListHeaderExterns.gtk_list_header_get_child(self);
	}

	public static uint GetEnd(this GtkListHeaderHandle self)
	{
		return GtkListHeaderExterns.gtk_list_header_get_end(self);
	}

	public static GObjectHandle GetItem(this GtkListHeaderHandle self)
	{
		return GtkListHeaderExterns.gtk_list_header_get_item(self);
	}

	public static uint GetNItems(this GtkListHeaderHandle self)
	{
		return GtkListHeaderExterns.gtk_list_header_get_n_items(self);
	}

	public static uint GetStart(this GtkListHeaderHandle self)
	{
		return GtkListHeaderExterns.gtk_list_header_get_start(self);
	}

	public static GtkListHeaderHandle SetChild(this GtkListHeaderHandle self, GtkWidgetHandle child)
	{
		GtkListHeaderExterns.gtk_list_header_set_child(self, child);
		return self;
	}

}

internal class GtkListHeaderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_list_header_get_child(GtkListHeaderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_list_header_get_end(GtkListHeaderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_list_header_get_item(GtkListHeaderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_list_header_get_n_items(GtkListHeaderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_list_header_get_start(GtkListHeaderHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_header_set_child(GtkListHeaderHandle self, GtkWidgetHandle child);
}
