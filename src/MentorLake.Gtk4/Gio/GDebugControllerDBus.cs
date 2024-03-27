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

public class GDebugControllerDBusHandle : GObjectHandle
{
	public static GDebugControllerDBusHandle GDebugControllerDbusNew(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDebugControllerDBusExterns.g_debug_controller_dbus_new(connection, cancellable, out error);
	}
}

public class GDebugControllerDBusSignal
{
	public string Value { get; set; }
	public GDebugControllerDBusSignal(string value) => Value = value;
}

public static class GDebugControllerDBusSignals
{
	public static GDebugControllerDBusSignal Authorize = new("authorize");
}

public static class GDebugControllerDBusHandleExtensions
{
	public static GDebugControllerDBusHandle GDebugControllerDbusStop(this GDebugControllerDBusHandle self)
	{
		GDebugControllerDBusExterns.g_debug_controller_dbus_stop(self);
		return self;
	}

	public static GDebugControllerDBusHandle Connect(this GDebugControllerDBusHandle instance, GDebugControllerDBusSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GDebugControllerDBusExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_debug_controller_dbus_stop(GDebugControllerDBusHandle self);
	[DllImport(Libraries.Gio)]
	internal static extern GDebugControllerDBusHandle g_debug_controller_dbus_new(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
}
