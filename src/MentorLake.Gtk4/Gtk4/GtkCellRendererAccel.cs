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

public class GtkCellRendererAccelHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererAccelHandle New()
	{
		return GtkCellRendererAccelExterns.gtk_cell_renderer_accel_new();
	}

}

public class GtkCellRendererAccelSignal
{
	public string Value { get; set; }
	public GtkCellRendererAccelSignal(string value) => Value = value;
}

public static class GtkCellRendererAccelSignals
{
	public static GtkCellRendererAccelSignal AccelCleared = new("accel-cleared");
	public static GtkCellRendererAccelSignal AccelEdited = new("accel-edited");
}

public static class GtkCellRendererAccelHandleExtensions
{
	public static GtkCellRendererAccelHandle Connect(this GtkCellRendererAccelHandle instance, GtkCellRendererAccelSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkCellRendererAccelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererAccelHandle gtk_cell_renderer_accel_new();
}
