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

public class GtkCellRendererComboHandle : GtkCellRendererTextHandle
{
	public static GtkCellRendererComboHandle New()
	{
		return GtkCellRendererComboExterns.gtk_cell_renderer_combo_new();
	}

}

public class GtkCellRendererComboSignal
{
	public string Value { get; set; }
	public GtkCellRendererComboSignal(string value) => Value = value;
}

public static class GtkCellRendererComboSignals
{
	public static GtkCellRendererComboSignal Changed = new("changed");
}

public static class GtkCellRendererComboHandleExtensions
{
	public static GtkCellRendererComboHandle Connect(this GtkCellRendererComboHandle instance, GtkCellRendererComboSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkCellRendererComboExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererComboHandle gtk_cell_renderer_combo_new();
}
