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

public class GtkSignalListItemFactoryHandle : GtkListItemFactoryHandle
{
	public static GtkSignalListItemFactoryHandle New()
	{
		return GtkSignalListItemFactoryExterns.gtk_signal_list_item_factory_new();
	}
}

public class GtkSignalListItemFactorySignal
{
	public string Value { get; set; }
	public GtkSignalListItemFactorySignal(string value) => Value = value;
}

public static class GtkSignalListItemFactorySignals
{
	public static GtkSignalListItemFactorySignal Bind = new("bind");
	public static GtkSignalListItemFactorySignal Setup = new("setup");
	public static GtkSignalListItemFactorySignal Teardown = new("teardown");
	public static GtkSignalListItemFactorySignal Unbind = new("unbind");
}

public static class GtkSignalListItemFactoryHandleExtensions
{
	public static GtkSignalListItemFactoryHandle Connect(this GtkSignalListItemFactoryHandle instance, GtkSignalListItemFactorySignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkSignalListItemFactoryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSignalListItemFactoryHandle gtk_signal_list_item_factory_new();
}
