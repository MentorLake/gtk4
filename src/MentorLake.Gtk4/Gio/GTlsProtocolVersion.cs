using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public enum GTlsProtocolVersion
{
	G_TLS_PROTOCOL_VERSION_UNKNOWN,
	G_TLS_PROTOCOL_VERSION_SSL_3_0,
	G_TLS_PROTOCOL_VERSION_TLS_1_0,
	G_TLS_PROTOCOL_VERSION_TLS_1_1,
	G_TLS_PROTOCOL_VERSION_TLS_1_2,
	G_TLS_PROTOCOL_VERSION_TLS_1_3,
	G_TLS_PROTOCOL_VERSION_DTLS_1_0,
	G_TLS_PROTOCOL_VERSION_DTLS_1_2
}
