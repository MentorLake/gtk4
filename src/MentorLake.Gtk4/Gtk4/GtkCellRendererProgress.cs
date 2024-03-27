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

public class GtkCellRendererProgressHandle : GtkCellRendererHandle
{
	public static GtkCellRendererProgressHandle New()
	{
		return GtkCellRendererProgressExterns.gtk_cell_renderer_progress_new();
	}
}

public static class GtkCellRendererProgressSignals
{
}

public static class GtkCellRendererProgressHandleExtensions
{
}

internal class GtkCellRendererProgressExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererProgressHandle gtk_cell_renderer_progress_new();
}
