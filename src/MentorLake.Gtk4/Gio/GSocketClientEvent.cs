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

public enum GSocketClientEvent
{
	G_SOCKET_CLIENT_RESOLVING,
	G_SOCKET_CLIENT_RESOLVED,
	G_SOCKET_CLIENT_CONNECTING,
	G_SOCKET_CLIENT_CONNECTED,
	G_SOCKET_CLIENT_PROXY_NEGOTIATING,
	G_SOCKET_CLIENT_PROXY_NEGOTIATED,
	G_SOCKET_CLIENT_TLS_HANDSHAKING,
	G_SOCKET_CLIENT_TLS_HANDSHAKED,
	G_SOCKET_CLIENT_COMPLETE
}
