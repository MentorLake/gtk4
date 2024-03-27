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

public class GDBusAuthObserverHandle : GObjectHandle
{
	public static GDBusAuthObserverHandle GDbusAuthObserverNew()
	{
		return GDBusAuthObserverExterns.g_dbus_auth_observer_new();
	}
}

public class GDBusAuthObserverSignal
{
	public string Value { get; set; }
	public GDBusAuthObserverSignal(string value) => Value = value;
}

public static class GDBusAuthObserverSignals
{
	public static GDBusAuthObserverSignal AllowMechanism = new("allow-mechanism");
	public static GDBusAuthObserverSignal AuthorizeAuthenticatedPeer = new("authorize-authenticated-peer");
}

public static class GDBusAuthObserverHandleExtensions
{
	public static bool GDbusAuthObserverAllowMechanism(this GDBusAuthObserverHandle observer, string mechanism)
	{
		return GDBusAuthObserverExterns.g_dbus_auth_observer_allow_mechanism(observer, mechanism);
	}

	public static bool GDbusAuthObserverAuthorizeAuthenticatedPeer(this GDBusAuthObserverHandle observer, GIOStreamHandle stream, GCredentialsHandle credentials)
	{
		return GDBusAuthObserverExterns.g_dbus_auth_observer_authorize_authenticated_peer(observer, stream, credentials);
	}

	public static GDBusAuthObserverHandle Connect(this GDBusAuthObserverHandle instance, GDBusAuthObserverSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GDBusAuthObserverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_auth_observer_allow_mechanism(GDBusAuthObserverHandle observer, string mechanism);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_auth_observer_authorize_authenticated_peer(GDBusAuthObserverHandle observer, GIOStreamHandle stream, GCredentialsHandle credentials);
	[DllImport(Libraries.Gio)]
	internal static extern GDBusAuthObserverHandle g_dbus_auth_observer_new();
}
