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

public class GtkLayoutChildHandle : GObjectHandle
{
}

public static class GtkLayoutChildSignals
{
}

public static class GtkLayoutChildHandleExtensions
{
	public static GtkWidgetHandle GetChildWidget(this GtkLayoutChildHandle layout_child)
	{
		return GtkLayoutChildExterns.gtk_layout_child_get_child_widget(layout_child);
	}

	public static GtkLayoutManagerHandle GetLayoutManager(this GtkLayoutChildHandle layout_child)
	{
		return GtkLayoutChildExterns.gtk_layout_child_get_layout_manager(layout_child);
	}

}

internal class GtkLayoutChildExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_layout_child_get_child_widget(GtkLayoutChildHandle layout_child);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLayoutManagerHandle gtk_layout_child_get_layout_manager(GtkLayoutChildHandle layout_child);
}
