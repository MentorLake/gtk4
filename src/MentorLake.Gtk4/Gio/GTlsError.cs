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

public enum GTlsError
{
	G_TLS_ERROR_UNAVAILABLE,
	G_TLS_ERROR_MISC,
	G_TLS_ERROR_BAD_CERTIFICATE,
	G_TLS_ERROR_NOT_TLS,
	G_TLS_ERROR_HANDSHAKE,
	G_TLS_ERROR_CERTIFICATE_REQUIRED,
	G_TLS_ERROR_EOF,
	G_TLS_ERROR_INAPPROPRIATE_FALLBACK,
	G_TLS_ERROR_BAD_CERTIFICATE_PASSWORD
}
